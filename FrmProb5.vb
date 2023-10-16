Public Class FrmProb5

    Private Sub ButtonEjecutar_Click(sender As Object, e As EventArgs) Handles ButtonEjecutar.Click
        Dim cadena As String = TextBoxCadena.Text
        Dim cadenaOriginal As String = cadena

        ListBoxResultados.Items.Clear()
        ListBoxResultados.Items.Add(cadena)

        Do
            cadena = cadena.Last() & cadena.Substring(0, cadena.Length - 1)
            ListBoxResultados.Items.Add(cadena)
        Loop While cadena <> cadenaOriginal
    End Sub

End Class