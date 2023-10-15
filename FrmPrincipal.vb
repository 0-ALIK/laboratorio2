Public Class FrmPrincipal
    Private Sub ButtonProb1_Click(sender As Object, e As EventArgs) Handles ButtonProb1.Click
        FrmProb1.Show()
        FrmProb2.Close()
        FrmProb3.Close()
        FrmProb4.Close()
        FrmProb5.Close()
        FrmProb6.Close()
    End Sub

    Private Sub ButtonProb2_Click(sender As Object, e As EventArgs) Handles ButtonProb2.Click
        FrmProb1.Close()
        FrmProb2.Show()
        FrmProb3.Close()
        FrmProb4.Close()
        FrmProb5.Close()
        FrmProb6.Close()
    End Sub

    Private Sub ButtonProb3_Click(sender As Object, e As EventArgs) Handles ButtonProb3.Click
        FrmProb1.Close()
        FrmProb2.Close()
        FrmProb3.Show()
        FrmProb4.Close()
        FrmProb5.Close()
        FrmProb6.Close()
    End Sub

    Private Sub ButtonProb4_Click(sender As Object, e As EventArgs) Handles ButtonProb4.Click
        FrmProb1.Close()
        FrmProb2.Close()
        FrmProb3.Close()
        FrmProb4.Show()
        FrmProb5.Close()
        FrmProb6.Close()
    End Sub

    Private Sub ButtonProb5_Click(sender As Object, e As EventArgs) Handles ButtonProb5.Click
        FrmProb1.Close()
        FrmProb2.Close()
        FrmProb3.Close()
        FrmProb4.Close()
        FrmProb5.Show()
        FrmProb6.Close()
    End Sub

    Private Sub ButtonProb6_Click(sender As Object, e As EventArgs) Handles ButtonProb6.Click
        FrmProb1.Close()
        FrmProb2.Close()
        FrmProb3.Close()
        FrmProb4.Close()
        FrmProb5.Close()
        FrmProb6.Show()
    End Sub

End Class
