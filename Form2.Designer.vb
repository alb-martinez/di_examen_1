<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btBorrar = New System.Windows.Forms.Button()
        Me.btOrdenar = New System.Windows.Forms.Button()
        Me.lbPalabras = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btAdd
        '
        Me.btAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.Location = New System.Drawing.Point(300, 320)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(124, 51)
        Me.btAdd.TabIndex = 7
        Me.btAdd.Text = "Añadir"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'btBorrar
        '
        Me.btBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBorrar.Location = New System.Drawing.Point(300, 417)
        Me.btBorrar.Name = "btBorrar"
        Me.btBorrar.Size = New System.Drawing.Size(124, 51)
        Me.btBorrar.TabIndex = 6
        Me.btBorrar.Text = "Borrar"
        Me.btBorrar.UseVisualStyleBackColor = True
        '
        'btOrdenar
        '
        Me.btOrdenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btOrdenar.Location = New System.Drawing.Point(300, 29)
        Me.btOrdenar.Name = "btOrdenar"
        Me.btOrdenar.Size = New System.Drawing.Size(124, 51)
        Me.btOrdenar.TabIndex = 5
        Me.btOrdenar.Text = "Ordenar"
        Me.btOrdenar.UseVisualStyleBackColor = True
        '
        'lbPalabras
        '
        Me.lbPalabras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPalabras.FormattingEnabled = True
        Me.lbPalabras.ItemHeight = 29
        Me.lbPalabras.Items.AddRange(New Object() {"hello", "horse", "podium", "loser", "starship", "mouse", "laptop", "screen", "pen", "keyboard"})
        Me.lbPalabras.Location = New System.Drawing.Point(29, 29)
        Me.lbPalabras.Name = "lbPalabras"
        Me.lbPalabras.Size = New System.Drawing.Size(235, 439)
        Me.lbPalabras.TabIndex = 4
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 509)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.btBorrar)
        Me.Controls.Add(Me.btOrdenar)
        Me.Controls.Add(Me.lbPalabras)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btAdd As Button
    Friend WithEvents btBorrar As Button
    Friend WithEvents btOrdenar As Button
    Friend WithEvents lbPalabras As ListBox
End Class
