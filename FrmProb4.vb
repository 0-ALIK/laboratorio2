Public Class FrmProb4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ano As Integer = Val(txtBoxAno.Text)
        Dim mes, dia As String
        Dim A, B, C, D, _E, N As Integer
        A = ano Mod 19
        B = ano Mod 4
        C = ano Mod 7
        D = (19 * A + 24) Mod 30
        _E = (2 * B + 4 * C + 6 * D + 5) Mod 7
        N = 22 + D + _E

        If N <= 31 Then
            mes = "marzo"
            dia = N
        Else
            mes = "abril"
            dia = N - 31
        End If

        txtBoxR.Text = "Domingo de Pascua en " & ano & ": " & dia & " del " & mes

    End Sub
End Class