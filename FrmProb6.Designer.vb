<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProb6
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
        Me.ButtonExplorar = New System.Windows.Forms.Button()
        Me.TextBoxMas = New System.Windows.Forms.TextBox()
        Me.TextBoxMenos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonGuardado = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonExplorar
        '
        Me.ButtonExplorar.Location = New System.Drawing.Point(109, 129)
        Me.ButtonExplorar.Name = "ButtonExplorar"
        Me.ButtonExplorar.Size = New System.Drawing.Size(193, 100)
        Me.ButtonExplorar.TabIndex = 0
        Me.ButtonExplorar.Text = "Explorador de archivos"
        Me.ButtonExplorar.UseVisualStyleBackColor = True
        '
        'TextBoxMas
        '
        Me.TextBoxMas.Location = New System.Drawing.Point(52, 346)
        Me.TextBoxMas.Multiline = True
        Me.TextBoxMas.Name = "TextBoxMas"
        Me.TextBoxMas.Size = New System.Drawing.Size(250, 53)
        Me.TextBoxMas.TabIndex = 1
        '
        'TextBoxMenos
        '
        Me.TextBoxMenos.Location = New System.Drawing.Point(499, 346)
        Me.TextBoxMenos.Multiline = True
        Me.TextBoxMenos.Name = "TextBoxMenos"
        Me.TextBoxMenos.Size = New System.Drawing.Size(289, 53)
        Me.TextBoxMenos.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(52, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "El que tuvo más votos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(496, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "El que tuvo menos votos"
        '
        'ButtonGuardado
        '
        Me.ButtonGuardado.Location = New System.Drawing.Point(485, 129)
        Me.ButtonGuardado.Name = "ButtonGuardado"
        Me.ButtonGuardado.Size = New System.Drawing.Size(193, 100)
        Me.ButtonGuardado.TabIndex = 5
        Me.ButtonGuardado.Text = "CSV ya guardado"
        Me.ButtonGuardado.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(95, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(596, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Toque cualquiera de los 2 botones para realizar un calculo de votos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(62, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(290, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Buscar el archivo CSV en tu PC"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(414, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(319, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Utilizar el CSV de votos ya cargado"
        '
        'FrmProb6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonGuardado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxMenos)
        Me.Controls.Add(Me.TextBoxMas)
        Me.Controls.Add(Me.ButtonExplorar)
        Me.Name = "FrmProb6"
        Me.Text = "FrmProb6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonExplorar As Button
    Friend WithEvents TextBoxMas As TextBox
    Friend WithEvents TextBoxMenos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonGuardado As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
