Public Class Form1

    ' Variables teclado
    Dim tableroTeclado(5, 5) As Button
    Dim arrayLetras() As Char = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    ' Variable para seleccionar aleatoriamente la palabra a jugar
    Dim numAleatorio As New Random()
    Dim indicePalabra As Integer
    ' Variable para crear los label donde se iran mostrando los aciertos
    Dim guionesPalabra() As Label
    Dim largoPalabra As Integer
    Dim palabraJugada As String
    ' Variable para controlar los intentos
    Dim intentos As Integer = 0
    ' Variable para transformar la palabra a jugar en char
    Dim palabraSeleccionada() As Char
    ' Variables para el boton de pista
    Dim pbPista As PictureBox
    Dim aparecePista As Boolean = True


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarPartida()
    End Sub

    ''' <summary>
    ''' Metodo para crear los guiones donde se iran mostrando los aciertos
    ''' </summary>
    Private Sub crearLabelPalabra()
        Dim contador As Integer = 0

        For i As Integer = 0 To largoPalabra - 1
            guionesPalabra(i) = New Label
            guionesPalabra(i).Width = 20
            guionesPalabra(i).Height = 20
            guionesPalabra(i).Text = "_"

            tbLetras.Controls.Add(guionesPalabra(i))
        Next
    End Sub

    ''' <summary>
    ''' Metodo para seleccionar aleatoriamente la palabra a jugar.
    ''' </summary>
    ''' <returns>
    ''' Retorna la palabra seleccionada por su indice, desde el numero aleatorio
    ''' </returns>
    Public Function seleccionarPalabra() As Integer
        indicePalabra = numAleatorio.Next(1, Form2.lbPalabras.Items.Count)
        palabraJugada = Form2.lbPalabras.Items.Item(indicePalabra)
        palabraSeleccionada = palabraJugada.ToUpper.ToArray
        tbSolucion.Text = palabraJugada
        Return palabraSeleccionada.Length
    End Function

    ''' <summary>
    ''' Metodo para crear en tiempo de ejecución los botones de las letras
    ''' </summary>
    Private Sub crearBotonesTeclado()
        Dim contador As Integer = 0

        For i As Integer = 0 To 4
            For j As Integer = 0 To 4
                tableroTeclado(i, j) = New Button
                tableroTeclado(i, j).Width = 40
                tableroTeclado(i, j).Height = 40
                tableroTeclado(i, j).Name = "bt" + i.ToString
                tableroTeclado(i, j).Text = arrayLetras(contador).ToString

                AddHandler tableroTeclado(i, j).Click, AddressOf Button_Click
                tlTablero.Controls.Add(tableroTeclado(i, j))
                contador += 1
            Next
        Next

        tableroTeclado(5, 0) = New Button
        tableroTeclado(5, 0).Width = 40
        tableroTeclado(5, 0).Height = 40
        tableroTeclado(5, 0).Name = "bt" + "25"
        tableroTeclado(5, 0).Text = arrayLetras(25).ToString
        AddHandler tableroTeclado(5, 0).Click, AddressOf Button_Click
        tlTablero.Controls.Add(tableroTeclado(5, 0))

        tableroTeclado(5, 1) = New Button
        tableroTeclado(5, 1).Width = 40
        tableroTeclado(5, 1).Height = 40
        tableroTeclado(5, 1).Name = "bt" + "26"
        tableroTeclado(5, 1).Text = arrayLetras(26).ToString
        AddHandler tableroTeclado(5, 1).Click, AddressOf Button_Click
        tlTablero.Controls.Add(tableroTeclado(5, 1))

    End Sub

    ''' <summary>
    ''' Metodo para deshabilitar los botones de las letras uno a uno
    ''' </summary>
    Private Sub deshabilitarBotonesTeclado()
        Dim contador As Integer = 0

        For i As Integer = 0 To 4
            For j As Integer = 0 To 4
                If (tableroTeclado(i, j).Enabled = True) Then
                    tableroTeclado(i, j).Enabled = False
                Else
                    tableroTeclado(i, j).Enabled = True
                End If
                contador += 1
            Next
        Next

        tableroTeclado(5, 0).Enabled = False
        tableroTeclado(5, 1).Enabled = False
    End Sub

    ''' <summary>
    ''' Metodo del evento click sobre cualquiera de las letras del teclado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim boton As Button = TryCast(sender, Button)
        boton.Enabled = False
        Dim encontrada = True

        For i As Integer = 0 To palabraSeleccionada.Length - 1
            If boton.Text = palabraSeleccionada(i) Then
                guionesPalabra(i).Text = boton.Text
            End If
        Next

        If (palabraJugada.Contains(boton.Text.ToLower)) = False Then
            intentos += 1
            pbAhoracado.Image = ilImagenes.Images.Item(intentos)
        End If

        txIntentos.Text = intentos.ToString
        comprobarPalabra()
        activarPista()
    End Sub

    ''' <summary>
    ''' Metodo para comprobar si se ha terminado de descubrir toda la palabra
    ''' </summary>
    Private Sub comprobarPalabra()
        Dim contador As Integer = 0
        Dim result As DialogResult
        Dim mensaje As String = "¿Desea jugar otra partida?"
        Dim titulo = "FIN PARTIDA"

        For i As Integer = 0 To guionesPalabra.Length - 1
            If (guionesPalabra(i).Text <> "_") Then
                contador = contador + 1
            End If
        Next

        ' Mostraremos mensaje de ganar o perder
        ' Tanto si se gana como si se pierde, preguntará si queremos una nueva partida, o no
        If (contador = guionesPalabra.Length) Then
            MessageBox.Show("EHNORABUENA!! HAS GANADO", "FIN PARTIDA")
            result = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (result = DialogResult.No) Then
                Me.Close()
            Else
                iniciarPartida()
            End If
        ElseIf (contador <> guionesPalabra.Length And intentos = 10) Then
            deshabilitarBotonesTeclado()
            MessageBox.Show("LO SIENTO! HAS PERDIDO", "FIN PARTIDA")
            result = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (result = DialogResult.No) Then
                Me.Close()
            Else
                iniciarPartida()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Metodo para empezar una partida nueva, con las variables reseteadas
    ''' </summary>
    Private Sub iniciarPartida()
        intentos = 0
        txIntentos.Text = intentos
        tlTablero.Controls.Clear()
        tbLetras.Controls.Clear()

        crearBotonesTeclado()
        pbAhoracado.Image = ilImagenes.Images.Item(0)
        largoPalabra = seleccionarPalabra()
        ReDim guionesPalabra(largoPalabra - 1)
        crearLabelPalabra()
        aparecePista = True
    End Sub

    ''' <summary>
    ''' Metodo para activar el pictureBox de la pista, a los 5 intentos
    ''' </summary>
    Private Sub activarPista()
        If intentos = 5 And aparecePista = True Then
            pbPista = New PictureBox()

            With pbPista
                .Width = 80
                .Height = 80
                .Image = ilImagenes.Images(11)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .Location = New Point(200, 40)
                AddHandler pbPista.Click, AddressOf PbPista_Click
                Me.Controls.Add(pbPista)
            End With
        End If
    End Sub

    ''' <summary>
    ''' Metodo para el evento click del pictureBox de pista
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PbPista_Click(sender As Object, e As EventArgs)
        Dim contador As Integer = 0
        For i As Integer = 0 To palabraSeleccionada.Length - 1
            If guionesPalabra(i).Text = "_" And contador = 0 Then
                guionesPalabra(i).Text = palabraSeleccionada(i)
                contador += 1
                pbPista.Hide()
                aparecePista = False
            End If
        Next
    End Sub

    ''' <summary>
    ''' Eventos click del menu strip
    ''' </summary>
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub MostrarListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarListaToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub JuegoNuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JuegoNuevoToolStripMenuItem.Click
        iniciarPartida()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ComoJugarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComoJugarToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub NivelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NivelToolStripMenuItem.Click
        Form5.Show()
    End Sub
End Class
