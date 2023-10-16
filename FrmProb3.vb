Public Class FrmProb3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer = Val(txtNumero.Text)
        If numero < 0 Then
            MessageBox.Show("Coloca valores mayores o iguales a 0", "Error de Insertación")
        Else
            txtResultado.Text = numeroRevez.InvertirNumero(numero)
            txtNumero.Text = ""
        End If
    End Sub
End Class