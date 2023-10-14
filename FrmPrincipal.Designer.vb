<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.ButtonProb1 = New System.Windows.Forms.Button()
        Me.ButtonProb2 = New System.Windows.Forms.Button()
        Me.ButtonProb3 = New System.Windows.Forms.Button()
        Me.ButtonProb4 = New System.Windows.Forms.Button()
        Me.ButtonProb5 = New System.Windows.Forms.Button()
        Me.ButtonProb6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonProb1
        '
        Me.ButtonProb1.Location = New System.Drawing.Point(12, 189)
        Me.ButtonProb1.Name = "ButtonProb1"
        Me.ButtonProb1.Size = New System.Drawing.Size(116, 68)
        Me.ButtonProb1.TabIndex = 0
        Me.ButtonProb1.Text = "Problema 1"
        Me.ButtonProb1.UseVisualStyleBackColor = True
        '
        'ButtonProb2
        '
        Me.ButtonProb2.Location = New System.Drawing.Point(134, 189)
        Me.ButtonProb2.Name = "ButtonProb2"
        Me.ButtonProb2.Size = New System.Drawing.Size(116, 68)
        Me.ButtonProb2.TabIndex = 1
        Me.ButtonProb2.Text = "Problema 2"
        Me.ButtonProb2.UseVisualStyleBackColor = True
        '
        'ButtonProb3
        '
        Me.ButtonProb3.Location = New System.Drawing.Point(256, 189)
        Me.ButtonProb3.Name = "ButtonProb3"
        Me.ButtonProb3.Size = New System.Drawing.Size(116, 68)
        Me.ButtonProb3.TabIndex = 2
        Me.ButtonProb3.Text = "Problema 3"
        Me.ButtonProb3.UseVisualStyleBackColor = True
        '
        'ButtonProb4
        '
        Me.ButtonProb4.Location = New System.Drawing.Point(378, 189)
        Me.ButtonProb4.Name = "ButtonProb4"
        Me.ButtonProb4.Size = New System.Drawing.Size(116, 68)
        Me.ButtonProb4.TabIndex = 3
        Me.ButtonProb4.Text = "Problema 4"
        Me.ButtonProb4.UseVisualStyleBackColor = True
        '
        'ButtonProb5
        '
        Me.ButtonProb5.Location = New System.Drawing.Point(500, 189)
        Me.ButtonProb5.Name = "ButtonProb5"
        Me.ButtonProb5.Size = New System.Drawing.Size(116, 68)
        Me.ButtonProb5.TabIndex = 4
        Me.ButtonProb5.Text = "Problema 5"
        Me.ButtonProb5.UseVisualStyleBackColor = True
        '
        'ButtonProb6
        '
        Me.ButtonProb6.Location = New System.Drawing.Point(622, 189)
        Me.ButtonProb6.Name = "ButtonProb6"
        Me.ButtonProb6.Size = New System.Drawing.Size(116, 68)
        Me.ButtonProb6.TabIndex = 5
        Me.ButtonProb6.Text = "Problema 6"
        Me.ButtonProb6.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 450)
        Me.Controls.Add(Me.ButtonProb6)
        Me.Controls.Add(Me.ButtonProb5)
        Me.Controls.Add(Me.ButtonProb4)
        Me.Controls.Add(Me.ButtonProb3)
        Me.Controls.Add(Me.ButtonProb2)
        Me.Controls.Add(Me.ButtonProb1)
        Me.Name = "FrmPrincipal"
        Me.Text = "Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonProb1 As Button
    Friend WithEvents ButtonProb2 As Button
    Friend WithEvents ButtonProb3 As Button
    Friend WithEvents ButtonProb4 As Button
    Friend WithEvents ButtonProb5 As Button
    Friend WithEvents ButtonProb6 As Button
End Class
