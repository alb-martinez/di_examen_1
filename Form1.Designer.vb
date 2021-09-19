<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txIntentos = New System.Windows.Forms.Label()
        Me.tbLetras = New System.Windows.Forms.FlowLayoutPanel()
        Me.tbSolucion = New System.Windows.Forms.TextBox()
        Me.tlTablero = New System.Windows.Forms.TableLayoutPanel()
        Me.pbAhoracado = New System.Windows.Forms.PictureBox()
        Me.lbIntentos = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JuegoNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiccionarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComoJugarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ilImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.NivelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pbAhoracado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txIntentos
        '
        Me.txIntentos.AutoSize = True
        Me.txIntentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txIntentos.Location = New System.Drawing.Point(125, 53)
        Me.txIntentos.Name = "txIntentos"
        Me.txIntentos.Size = New System.Drawing.Size(0, 29)
        Me.txIntentos.TabIndex = 41
        '
        'tbLetras
        '
        Me.tbLetras.Location = New System.Drawing.Point(393, 616)
        Me.tbLetras.Name = "tbLetras"
        Me.tbLetras.Size = New System.Drawing.Size(473, 50)
        Me.tbLetras.TabIndex = 40
        '
        'tbSolucion
        '
        Me.tbSolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSolucion.Location = New System.Drawing.Point(17, 616)
        Me.tbSolucion.Name = "tbSolucion"
        Me.tbSolucion.Size = New System.Drawing.Size(302, 35)
        Me.tbSolucion.TabIndex = 39
        '
        'tlTablero
        '
        Me.tlTablero.ColumnCount = 5
        Me.tlTablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlTablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlTablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlTablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlTablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlTablero.Location = New System.Drawing.Point(393, 211)
        Me.tlTablero.Name = "tlTablero"
        Me.tlTablero.RowCount = 6
        Me.tlTablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlTablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlTablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlTablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlTablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlTablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlTablero.Size = New System.Drawing.Size(293, 376)
        Me.tlTablero.TabIndex = 38
        '
        'pbAhoracado
        '
        Me.pbAhoracado.Location = New System.Drawing.Point(17, 211)
        Me.pbAhoracado.Name = "pbAhoracado"
        Me.pbAhoracado.Size = New System.Drawing.Size(302, 376)
        Me.pbAhoracado.TabIndex = 37
        Me.pbAhoracado.TabStop = False
        '
        'lbIntentos
        '
        Me.lbIntentos.AutoSize = True
        Me.lbIntentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIntentos.Location = New System.Drawing.Point(12, 46)
        Me.lbIntentos.Name = "lbIntentos"
        Me.lbIntentos.Padding = New System.Windows.Forms.Padding(5)
        Me.lbIntentos.Size = New System.Drawing.Size(107, 39)
        Me.lbIntentos.TabIndex = 36
        Me.lbIntentos.Text = "Intentos"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.DiccionarioToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 33)
        Me.MenuStrip1.TabIndex = 42
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JuegoNuevoToolStripMenuItem, Me.NivelToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(88, 29)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'JuegoNuevoToolStripMenuItem
        '
        Me.JuegoNuevoToolStripMenuItem.Name = "JuegoNuevoToolStripMenuItem"
        Me.JuegoNuevoToolStripMenuItem.Size = New System.Drawing.Size(215, 34)
        Me.JuegoNuevoToolStripMenuItem.Text = "Juego nuevo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(215, 34)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'DiccionarioToolStripMenuItem
        '
        Me.DiccionarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarListaToolStripMenuItem})
        Me.DiccionarioToolStripMenuItem.Name = "DiccionarioToolStripMenuItem"
        Me.DiccionarioToolStripMenuItem.Size = New System.Drawing.Size(116, 29)
        Me.DiccionarioToolStripMenuItem.Text = "Diccionario"
        '
        'MostrarListaToolStripMenuItem
        '
        Me.MostrarListaToolStripMenuItem.Name = "MostrarListaToolStripMenuItem"
        Me.MostrarListaToolStripMenuItem.Size = New System.Drawing.Size(212, 34)
        Me.MostrarListaToolStripMenuItem.Text = "Mostrar lista"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComoJugarToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(79, 29)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ComoJugarToolStripMenuItem
        '
        Me.ComoJugarToolStripMenuItem.Name = "ComoJugarToolStripMenuItem"
        Me.ComoJugarToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ComoJugarToolStripMenuItem.Text = "Como jugar"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(208, 34)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'ilImagenes
        '
        Me.ilImagenes.ImageStream = CType(resources.GetObject("ilImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.ilImagenes.Images.SetKeyName(0, "AHOR0.BMP")
        Me.ilImagenes.Images.SetKeyName(1, "AHOR1.BMP")
        Me.ilImagenes.Images.SetKeyName(2, "AHOR2.BMP")
        Me.ilImagenes.Images.SetKeyName(3, "AHOR3.BMP")
        Me.ilImagenes.Images.SetKeyName(4, "AHOR4.BMP")
        Me.ilImagenes.Images.SetKeyName(5, "AHOR5.BMP")
        Me.ilImagenes.Images.SetKeyName(6, "AHOR6.BMP")
        Me.ilImagenes.Images.SetKeyName(7, "AHOR7.BMP")
        Me.ilImagenes.Images.SetKeyName(8, "AHOR8.BMP")
        Me.ilImagenes.Images.SetKeyName(9, "AHOR9.BMP")
        Me.ilImagenes.Images.SetKeyName(10, "AHOR10.BMP")
        Me.ilImagenes.Images.SetKeyName(11, "tip.jpg")
        '
        'NivelToolStripMenuItem
        '
        Me.NivelToolStripMenuItem.Name = "NivelToolStripMenuItem"
        Me.NivelToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.NivelToolStripMenuItem.Text = "Nivel"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 703)
        Me.Controls.Add(Me.txIntentos)
        Me.Controls.Add(Me.tbLetras)
        Me.Controls.Add(Me.tbSolucion)
        Me.Controls.Add(Me.tlTablero)
        Me.Controls.Add(Me.pbAhoracado)
        Me.Controls.Add(Me.lbIntentos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbAhoracado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txIntentos As Label
    Friend WithEvents tbLetras As FlowLayoutPanel
    Friend WithEvents tbSolucion As TextBox
    Friend WithEvents tlTablero As TableLayoutPanel
    Friend WithEvents pbAhoracado As PictureBox
    Friend WithEvents lbIntentos As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JuegoNuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiccionarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComoJugarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ilImagenes As ImageList
    Friend WithEvents NivelToolStripMenuItem As ToolStripMenuItem
End Class
