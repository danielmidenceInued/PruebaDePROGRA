<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnRojo = New System.Windows.Forms.Button()
        Me.BtnAmarillo = New System.Windows.Forms.Button()
        Me.BtnAzul = New System.Windows.Forms.Button()
        Me.BtnVerde = New System.Windows.Forms.Button()
        Me.BtnGris = New System.Windows.Forms.Button()
        Me.TxtColores = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnRojo
        '
        Me.BtnRojo.Location = New System.Drawing.Point(77, 53)
        Me.BtnRojo.Name = "BtnRojo"
        Me.BtnRojo.Size = New System.Drawing.Size(94, 34)
        Me.BtnRojo.TabIndex = 0
        Me.BtnRojo.Text = "Rojo"
        Me.BtnRojo.UseVisualStyleBackColor = True
        '
        'BtnAmarillo
        '
        Me.BtnAmarillo.Location = New System.Drawing.Point(77, 109)
        Me.BtnAmarillo.Name = "BtnAmarillo"
        Me.BtnAmarillo.Size = New System.Drawing.Size(94, 33)
        Me.BtnAmarillo.TabIndex = 1
        Me.BtnAmarillo.Text = "Amarillo"
        Me.BtnAmarillo.UseVisualStyleBackColor = True
        '
        'BtnAzul
        '
        Me.BtnAzul.Location = New System.Drawing.Point(77, 166)
        Me.BtnAzul.Name = "BtnAzul"
        Me.BtnAzul.Size = New System.Drawing.Size(94, 34)
        Me.BtnAzul.TabIndex = 2
        Me.BtnAzul.Text = "Azul"
        Me.BtnAzul.UseVisualStyleBackColor = True
        '
        'BtnVerde
        '
        Me.BtnVerde.Location = New System.Drawing.Point(77, 224)
        Me.BtnVerde.Name = "BtnVerde"
        Me.BtnVerde.Size = New System.Drawing.Size(94, 32)
        Me.BtnVerde.TabIndex = 3
        Me.BtnVerde.Text = "Verde"
        Me.BtnVerde.UseVisualStyleBackColor = True
        '
        'BtnGris
        '
        Me.BtnGris.Location = New System.Drawing.Point(77, 279)
        Me.BtnGris.Name = "BtnGris"
        Me.BtnGris.Size = New System.Drawing.Size(94, 33)
        Me.BtnGris.TabIndex = 4
        Me.BtnGris.Text = "Gris"
        Me.BtnGris.UseVisualStyleBackColor = True
        '
        'TxtColores
        '
        Me.TxtColores.Location = New System.Drawing.Point(214, 53)
        Me.TxtColores.Multiline = True
        Me.TxtColores.Name = "TxtColores"
        Me.TxtColores.Size = New System.Drawing.Size(421, 249)
        Me.TxtColores.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(699, 346)
        Me.Controls.Add(Me.TxtColores)
        Me.Controls.Add(Me.BtnGris)
        Me.Controls.Add(Me.BtnVerde)
        Me.Controls.Add(Me.BtnAzul)
        Me.Controls.Add(Me.BtnAmarillo)
        Me.Controls.Add(Me.BtnRojo)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRojo As Button
    Friend WithEvents BtnAmarillo As Button
    Friend WithEvents BtnAzul As Button
    Friend WithEvents BtnVerde As Button
    Friend WithEvents BtnGris As Button
    Friend WithEvents TxtColores As TextBox
End Class
