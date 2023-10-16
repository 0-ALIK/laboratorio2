<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProb4
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
        Me.txtBoxAno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxR = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBoxAno
        '
        Me.txtBoxAno.Location = New System.Drawing.Point(238, 83)
        Me.txtBoxAno.Name = "txtBoxAno"
        Me.txtBoxAno.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxAno.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingresa el año"
        '
        'txtBoxR
        '
        Me.txtBoxR.Location = New System.Drawing.Point(515, 79)
        Me.txtBoxR.Name = "txtBoxR"
        Me.txtBoxR.ReadOnly = True
        Me.txtBoxR.Size = New System.Drawing.Size(229, 20)
        Me.txtBoxR.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(361, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmProb4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBoxR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBoxAno)
        Me.Name = "FrmProb4"
        Me.Text = "FrmProb4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBoxAno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxR As TextBox
    Friend WithEvents Button1 As Button
End Class
