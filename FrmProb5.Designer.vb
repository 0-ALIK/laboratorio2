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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(146, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese la cadena"
        '
        'TextBoxCadena
        '
        Me.TextBoxCadena.Location = New System.Drawing.Point(330, 42)
        Me.TextBoxCadena.Name = "TextBoxCadena"
        Me.TextBoxCadena.Size = New System.Drawing.Size(323, 22)
        Me.TextBoxCadena.TabIndex = 1
        '
        'ListBoxResultados
        '
        Me.ListBoxResultados.FormattingEnabled = True
        Me.ListBoxResultados.ItemHeight = 16
        Me.ListBoxResultados.Location = New System.Drawing.Point(151, 87)
        Me.ListBoxResultados.Name = "ListBoxResultados"
        Me.ListBoxResultados.Size = New System.Drawing.Size(502, 244)
        Me.ListBoxResultados.TabIndex = 2
        '
        'ButtonEjecutar
        '
        Me.ButtonEjecutar.Location = New System.Drawing.Point(308, 361)
        Me.ButtonEjecutar.Name = "ButtonEjecutar"
        Me.ButtonEjecutar.Size = New System.Drawing.Size(161, 62)
        Me.ButtonEjecutar.TabIndex = 3
        Me.ButtonEjecutar.Text = "Ejecutar algoritmo"
        Me.ButtonEjecutar.UseVisualStyleBackColor = True
        '
        'FrmProb5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonEjecutar)
        Me.Controls.Add(Me.ListBoxResultados)
        Me.Controls.Add(Me.TextBoxCadena)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmProb5"
        Me.Text = "FrmProb5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCadena As TextBox
    Friend WithEvents ListBoxResultados As ListBox
    Friend WithEvents ButtonEjecutar As Button
End Class
