<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProb5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCadena = New System.Windows.Forms.TextBox()
        Me.ListBoxResultados = New System.Windows.Forms.ListBox()
        Me.ButtonEjecutar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese la cadena"
        '
        'TextBoxCadena
        '
        Me.TextBoxCadena.BackColor = System.Drawing.Color.Sienna
        Me.TextBoxCadena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCadena.Location = New System.Drawing.Point(201, 20)
        Me.TextBoxCadena.Multiline = True
        Me.TextBoxCadena.Name = "TextBoxCadena"
        Me.TextBoxCadena.Size = New System.Drawing.Size(316, 64)
        Me.TextBoxCadena.TabIndex = 1
        '
        'ListBoxResultados
        '
        Me.ListBoxResultados.BackColor = System.Drawing.Color.Snow
        Me.ListBoxResultados.FormattingEnabled = True
        Me.ListBoxResultados.ItemHeight = 18
        Me.ListBoxResultados.Location = New System.Drawing.Point(68, 90)
        Me.ListBoxResultados.Name = "ListBoxResultados"
        Me.ListBoxResultados.Size = New System.Drawing.Size(449, 202)
        Me.ListBoxResultados.TabIndex = 2
        '
        'ButtonEjecutar
        '
        Me.ButtonEjecutar.BackColor = System.Drawing.Color.Sienna
        Me.ButtonEjecutar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEjecutar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEjecutar.Location = New System.Drawing.Point(201, 311)
        Me.ButtonEjecutar.Name = "ButtonEjecutar"
        Me.ButtonEjecutar.Size = New System.Drawing.Size(113, 55)
        Me.ButtonEjecutar.TabIndex = 3
        Me.ButtonEjecutar.Text = "Ejecutar algoritmo"
        Me.ButtonEjecutar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ButtonEjecutar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ListBoxResultados)
        Me.Panel1.Controls.Add(Me.TextBoxCadena)
        Me.Panel1.Location = New System.Drawing.Point(113, 74)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 387)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(267, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 48)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "BIENVENIDO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rotación de Texto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmProb5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.laboratorio2.My.Resources.Resources.mitchell_luo_xREzOtWzDrQ_unsplash__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(738, 484)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmProb5"
        Me.Text = "FrmProb5"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCadena As TextBox
    Friend WithEvents ListBoxResultados As ListBox
    Friend WithEvents ButtonEjecutar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
