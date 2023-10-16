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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonExplorar
        '
        Me.ButtonExplorar.BackColor = System.Drawing.Color.Sienna
        Me.ButtonExplorar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonExplorar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonExplorar.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExplorar.Location = New System.Drawing.Point(51, 77)
        Me.ButtonExplorar.Name = "ButtonExplorar"
        Me.ButtonExplorar.Size = New System.Drawing.Size(150, 63)
        Me.ButtonExplorar.TabIndex = 0
        Me.ButtonExplorar.Text = "Explorador de archivos"
        Me.ButtonExplorar.UseVisualStyleBackColor = False
        '
        'TextBoxMas
        '
        Me.TextBoxMas.BackColor = System.Drawing.Color.Sienna
        Me.TextBoxMas.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMas.Location = New System.Drawing.Point(28, 223)
        Me.TextBoxMas.Multiline = True
        Me.TextBoxMas.Name = "TextBoxMas"
        Me.TextBoxMas.Size = New System.Drawing.Size(182, 51)
        Me.TextBoxMas.TabIndex = 1
        '
        'TextBoxMenos
        '
        Me.TextBoxMenos.BackColor = System.Drawing.Color.Sienna
        Me.TextBoxMenos.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMenos.Location = New System.Drawing.Point(278, 223)
        Me.TextBoxMenos.Multiline = True
        Me.TextBoxMenos.Name = "TextBoxMenos"
        Me.TextBoxMenos.Size = New System.Drawing.Size(227, 51)
        Me.TextBoxMenos.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "El que tuvo más votos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(305, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "El que tuvo menos votos"
        '
        'ButtonGuardado
        '
        Me.ButtonGuardado.BackColor = System.Drawing.Color.Sienna
        Me.ButtonGuardado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGuardado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonGuardado.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardado.Location = New System.Drawing.Point(328, 77)
        Me.ButtonGuardado.Name = "ButtonGuardado"
        Me.ButtonGuardado.Size = New System.Drawing.Size(149, 63)
        Me.ButtonGuardado.TabIndex = 5
        Me.ButtonGuardado.Text = "CSV ya guardado"
        Me.ButtonGuardado.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(208, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(345, 42)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Toque cualquiera de los " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2 botones para realizar un calculo de votos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Buscar el archivo CSV en tu PC"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(274, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(281, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Utilizar el CSV de votos ya cargado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(290, 19)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 48)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "BIENVENIDO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rotación de Texto"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ButtonExplorar)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ButtonGuardado)
        Me.Panel1.Controls.Add(Me.TextBoxMenos)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBoxMas)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(111, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 302)
        Me.Panel1.TabIndex = 10
        '
        'FrmProb6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(738, 484)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmProb6"
        Me.Text = "FrmProb6"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
End Class
