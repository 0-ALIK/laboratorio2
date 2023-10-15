Imports System.Security.Cryptography

Public Class FrmProb1
    Dim total As Integer
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim i, vectorPrecios(), cantidad, cont1, cont2, cont3 As Integer
        cantidad = txtCantidad.Text
        Dim objSumar As New ClassFrmProb1
        'lstNum.Items.Add(vectorNum(cont))
        'objSumaPar.asignar(vectorNum)
        'txtPar.Text = objSumaPar.sumPar()
        'Call sumaNumImpar(vectorNum, sumaImpar)
        'txtImpar.Text = sumaImpar
        ReDim vectorPrecios(cantidad)
        Try
            For i = 1 To vectorPrecios.Length - 1
                vectorPrecios(i) = InputBox("Precio del Producto", "Registrar precio")
                lvPrecios.Items.Add(vectorPrecios(i))
            Next

            objSumar.asignar(vectorPrecios)
            txtTotal.Text = objSumar.suma(cont1, cont2, cont3)
            txtCont1.Text = cont1
            txtCont2.Text = cont2
            txtCont3.Text = cont3

            txtMayorMil.Text = objSumar.suma1
            txtMenoresQ.Text = objSumar.suma2
            txtMenoresMil.Text = objSumar.suma3

            txtTotal.Text = objSumar.suma1 + objSumar.suma2 + objSumar.suma3


        Catch
        End Try
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lvPrecios.Items.Clear()
        txtTotal.Text = " "
    End Sub

End Class