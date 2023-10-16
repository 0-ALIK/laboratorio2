Public Class FrmProb2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim temp As Double = Val(txtTemp.Text)
        lvTemps.Clear()
        If temp <> 0 Then
            sensorTemp.RegistrarTemperatura(temp)
        Else
            lvTemps.Items.Add(sensorTemp.ObtenerTempMenor())
            lvTemps.Items.Add(sensorTemp.ObtenerTempMayor())
        End If
        txtTemp.Text = ""
    End Sub
End Class