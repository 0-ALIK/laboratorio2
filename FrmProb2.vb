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

    Private Sub txtTemp_TextChanged(sender As Object, e As EventArgs) Handles txtTemp.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub lvTemps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvTemps.SelectedIndexChanged

    End Sub
End Class