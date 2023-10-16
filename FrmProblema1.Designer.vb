<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProblema1
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCont2 = New System.Windows.Forms.TextBox()
        Me.txtCont3 = New System.Windows.Forms.TextBox()
        Me.txtCont1 = New System.Windows.Forms.TextBox()
        Me.lvPrecios = New System.Windows.Forms.ListView()
        Me.mayoresMil = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.menoresMil = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MayoresQuinientos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtMayorMil = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtMenoresMil = New System.Windows.Forms.TextBox()
        Me.txtMenoresQ = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Sienna
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(67, 214)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 50)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtCont2)
        Me.Panel1.Controls.Add(Me.txtCont3)
        Me.Panel1.Controls.Add(Me.txtCont1)
        Me.Panel1.Controls.Add(Me.lvPrecios)
        Me.Panel1.Controls.Add(Me.txtMayorMil)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.txtMenoresMil)
        Me.Panel1.Controls.Add(Me.txtMenoresQ)
        Me.Panel1.Location = New System.Drawing.Point(38, 113)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 437)
        Me.Panel1.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(168, 378)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 24)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(402, 47)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 24)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Cantitades"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(284, 47)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Totales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(157, 268)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 48)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Menores " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a 1000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(157, 173)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 48)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Menores " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a 500"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(157, 87)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 48)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Mayores " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a 1000"
        '
        'txtCont2
        '
        Me.txtCont2.BackColor = System.Drawing.Color.Sienna
        Me.txtCont2.Cursor = System.Windows.Forms.Cursors.No
        Me.txtCont2.Location = New System.Drawing.Point(410, 178)
        Me.txtCont2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCont2.Multiline = True
        Me.txtCont2.Name = "txtCont2"
        Me.txtCont2.ReadOnly = True
        Me.txtCont2.Size = New System.Drawing.Size(103, 45)
        Me.txtCont2.TabIndex = 15
        '
        'txtCont3
        '
        Me.txtCont3.BackColor = System.Drawing.Color.Sienna
        Me.txtCont3.Cursor = System.Windows.Forms.Cursors.No
        Me.txtCont3.Location = New System.Drawing.Point(410, 268)
        Me.txtCont3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCont3.Multiline = True
        Me.txtCont3.Name = "txtCont3"
        Me.txtCont3.ReadOnly = True
        Me.txtCont3.Size = New System.Drawing.Size(103, 45)
        Me.txtCont3.TabIndex = 14
        '
        'txtCont1
        '
        Me.txtCont1.BackColor = System.Drawing.Color.Sienna
        Me.txtCont1.Cursor = System.Windows.Forms.Cursors.No
        Me.txtCont1.Location = New System.Drawing.Point(410, 87)
        Me.txtCont1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCont1.Multiline = True
        Me.txtCont1.Name = "txtCont1"
        Me.txtCont1.ReadOnly = True
        Me.txtCont1.Size = New System.Drawing.Size(103, 45)
        Me.txtCont1.TabIndex = 13
        '
        'lvPrecios
        '
        Me.lvPrecios.BackColor = System.Drawing.Color.AntiqueWhite
        Me.lvPrecios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvPrecios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.mayoresMil, Me.menoresMil, Me.MayoresQuinientos})
        Me.lvPrecios.HideSelection = False
        Me.lvPrecios.Location = New System.Drawing.Point(14, 87)
        Me.lvPrecios.Margin = New System.Windows.Forms.Padding(4)
        Me.lvPrecios.Name = "lvPrecios"
        Me.lvPrecios.Size = New System.Drawing.Size(135, 326)
        Me.lvPrecios.TabIndex = 0
        Me.lvPrecios.UseCompatibleStateImageBehavior = False
        '
        'txtMayorMil
        '
        Me.txtMayorMil.BackColor = System.Drawing.Color.Sienna
        Me.txtMayorMil.Cursor = System.Windows.Forms.Cursors.No
        Me.txtMayorMil.Location = New System.Drawing.Point(273, 87)
        Me.txtMayorMil.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMayorMil.Multiline = True
        Me.txtMayorMil.Name = "txtMayorMil"
        Me.txtMayorMil.ReadOnly = True
        Me.txtMayorMil.Size = New System.Drawing.Size(103, 45)
        Me.txtMayorMil.TabIndex = 8
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Sienna
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.No
        Me.txtTotal.Location = New System.Drawing.Point(274, 369)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(103, 45)
        Me.txtTotal.TabIndex = 12
        '
        'txtMenoresMil
        '
        Me.txtMenoresMil.BackColor = System.Drawing.Color.Sienna
        Me.txtMenoresMil.Cursor = System.Windows.Forms.Cursors.No
        Me.txtMenoresMil.Location = New System.Drawing.Point(273, 178)
        Me.txtMenoresMil.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMenoresMil.Multiline = True
        Me.txtMenoresMil.Name = "txtMenoresMil"
        Me.txtMenoresMil.ReadOnly = True
        Me.txtMenoresMil.Size = New System.Drawing.Size(103, 45)
        Me.txtMenoresMil.TabIndex = 9
        '
        'txtMenoresQ
        '
        Me.txtMenoresQ.BackColor = System.Drawing.Color.Sienna
        Me.txtMenoresQ.Cursor = System.Windows.Forms.Cursors.No
        Me.txtMenoresQ.Location = New System.Drawing.Point(273, 268)
        Me.txtMenoresQ.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMenoresQ.Multiline = True
        Me.txtMenoresQ.Name = "txtMenoresQ"
        Me.txtMenoresQ.ReadOnly = True
        Me.txtMenoresQ.Size = New System.Drawing.Size(103, 45)
        Me.txtMenoresQ.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 72)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Introduzca la " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cantidad de precios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " a añadir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OldLace
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.txtCantidad)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Location = New System.Drawing.Point(590, 113)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 370)
        Me.Panel2.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Sienna
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(67, 285)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(111, 53)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Limpiar Lista"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.Sienna
        Me.txtCantidad.Location = New System.Drawing.Point(43, 140)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(156, 45)
        Me.txtCantidad.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(373, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 26)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "TIENDA EGPH"
        '
        'FrmProb1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.laboratorio2.My.Resources.Resources.mitchell_luo_xREzOtWzDrQ_unsplash__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(861, 571)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmProb1"
        Me.Text = "FrmProb1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lvPrecios As ListView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents mayoresMil As ColumnHeader
    Friend WithEvents menoresMil As ColumnHeader
    Friend WithEvents MayoresQuinientos As ColumnHeader
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtMenoresQ As TextBox
    Friend WithEvents txtMenoresMil As TextBox
    Friend WithEvents txtMayorMil As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents txtCont2 As TextBox
    Friend WithEvents txtCont3 As TextBox
    Friend WithEvents txtCont1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
