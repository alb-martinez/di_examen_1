<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.gbNivel = New System.Windows.Forms.GroupBox()
        Me.rdExper = New System.Windows.Forms.RadioButton()
        Me.rdInter = New System.Windows.Forms.RadioButton()
        Me.rdPrin = New System.Windows.Forms.RadioButton()
        Me.btOK = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.gbNivel.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbNivel
        '
        Me.gbNivel.Controls.Add(Me.rdExper)
        Me.gbNivel.Controls.Add(Me.rdInter)
        Me.gbNivel.Controls.Add(Me.rdPrin)
        Me.gbNivel.Location = New System.Drawing.Point(36, 53)
        Me.gbNivel.Name = "gbNivel"
        Me.gbNivel.Size = New System.Drawing.Size(248, 237)
        Me.gbNivel.TabIndex = 0
        Me.gbNivel.TabStop = False
        Me.gbNivel.Text = "Seleccionar nivel"
        '
        'rdExper
        '
        Me.rdExper.AutoSize = True
        Me.rdExper.Location = New System.Drawing.Point(17, 194)
        Me.rdExper.Name = "rdExper"
        Me.rdExper.Size = New System.Drawing.Size(89, 24)
        Me.rdExper.TabIndex = 2
        Me.rdExper.TabStop = True
        Me.rdExper.Text = "Experto"
        Me.rdExper.UseVisualStyleBackColor = True
        '
        'rdInter
        '
        Me.rdInter.AutoSize = True
        Me.rdInter.Location = New System.Drawing.Point(17, 123)
        Me.rdInter.Name = "rdInter"
        Me.rdInter.Size = New System.Drawing.Size(110, 24)
        Me.rdInter.TabIndex = 1
        Me.rdInter.TabStop = True
        Me.rdInter.Text = "Intermedio"
        Me.rdInter.UseVisualStyleBackColor = True
        '
        'rdPrin
        '
        Me.rdPrin.AutoSize = True
        Me.rdPrin.Location = New System.Drawing.Point(17, 58)
        Me.rdPrin.Name = "rdPrin"
        Me.rdPrin.Size = New System.Drawing.Size(116, 24)
        Me.rdPrin.TabIndex = 0
        Me.rdPrin.TabStop = True
        Me.rdPrin.Text = "Principiante"
        Me.rdPrin.UseVisualStyleBackColor = True
        '
        'btOK
        '
        Me.btOK.Location = New System.Drawing.Point(36, 350)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(106, 51)
        Me.btOK.TabIndex = 1
        Me.btOK.Text = "OK"
        Me.btOK.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(178, 350)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(106, 51)
        Me.btCancelar.TabIndex = 2
        Me.btCancelar.Text = "CANCELAR"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 426)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.gbNivel)
        Me.Name = "Form5"
        Me.Text = "Nivel"
        Me.gbNivel.ResumeLayout(False)
        Me.gbNivel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbNivel As GroupBox
    Friend WithEvents rdExper As RadioButton
    Friend WithEvents rdInter As RadioButton
    Friend WithEvents rdPrin As RadioButton
    Friend WithEvents btOK As Button
    Friend WithEvents btCancelar As Button
End Class
