Public Class Form2
    ' Variable para la ordenación
    Dim ordenado As Boolean = True
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comprobarCantidadPalabras()
    End Sub

    ''' <summary>
    ''' Metodo para comprobar cuantas palabras hay en la lista
    ''' </summary>
    Private Sub comprobarCantidadPalabras()
        If (lbPalabras.Items.Count < 6) Then
            btBorrar.Enabled = False
        ElseIf (lbPalabras.Items.Count >= 5) Then
            btBorrar.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Metodo para el evento click de boton ordenar y su inversa
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btOrdenar_Click(sender As Object, e As EventArgs) Handles btOrdenar.Click
        Dim listaNueva(lbPalabras.Items.Count - 1) As Object

        If ordenado Then
            lbPalabras.Sorted = True
            ordenado = False
        ElseIf ordenado = False Then
            lbPalabras.Sorted = False
            lbPalabras.Items.CopyTo(listaNueva, 0)
            Array.Reverse(listaNueva)
            lbPalabras.Items.Clear()
            lbPalabras.Items.AddRange(listaNueva)
            ordenado += 1
        End If
    End Sub

    ''' <summary>
    ''' Metodo para el evento click del boton borrar palabra
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        Dim mensaje As String = "¿Seguro que desea borrar la palabra?"
        Dim titulo = "Borrar Palabra"
        Dim result As DialogResult

        If (lbPalabras.SelectedIndex) = -1 Then
            MsgBox("Debe seleccionar una palabra a borrar", , "Borrar Palabra")
        Else
            result = MessageBox.Show(mensaje + "  " + lbPalabras.SelectedItem.ToString, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (result = DialogResult.No) Then
                Me.Close()
            Else
                lbPalabras.Items.RemoveAt(lbPalabras.SelectedIndex)
            End If
        End If

        comprobarCantidadPalabras()
    End Sub

    ''' <summary>
    ''' Metodo para el evento click del boton añadir palabra
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Dim mensaje = "Escriba la palabra a añadir"
        Dim titulo = "Palabra nueva"
        Dim result As String


        result = InputBox(mensaje, titulo)
        If (result = "") Then
            MsgBox("Debe introducir una palabra")
        Else
            If (comprobarDuplicada(result)) Then
                MsgBox("La palabra está repetida", , "Añadir Palabra")
            Else
                lbPalabras.Items.Add(result)

            End If
        End If
        comprobarCantidadPalabras()
    End Sub

    ''' <summary>
    ''' Metodo para comprobar si la palabra nueva introducida ya existe en la lista
    ''' </summary>
    ''' <param name="palabra"></param>
    ''' <returns></returns>
    Private Function comprobarDuplicada(ByRef palabra As String) As Boolean
        Dim duplicada As Boolean

        For Each itemValue As String In lbPalabras.Items
            If itemValue = palabra Then
                duplicada = True
            End If
        Next

        Return duplicada
    End Function

End Class