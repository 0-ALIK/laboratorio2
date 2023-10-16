Imports System.IO

Public Class FrmProb6

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonExplorar.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            Dim csvReader As New CSVReader(filePath)
            Dim data As String()() = csvReader.cargarDatosCSV()

            realizarCalculo(data)
        End If
    End Sub

    Private Sub ButtonGuardado_Click(sender As Object, e As EventArgs) Handles ButtonGuardado.Click
        Dim ruta As String = Application.StartupPath & "../../../datos/votos.csv"

        Dim csvReader As New CSVReader(ruta)
        Dim data As String()() = csvReader.cargarDatosCSV()

        realizarCalculo(data)
    End Sub

    Public Sub realizarCalculo(data As String()())
        Dim candidato1 As Integer = 0
        Dim candidato2 As Integer = 0
        Dim candidato3 As Integer = 0
        Dim candidato4 As Integer = 0

        For Each fila As String() In data
            candidato1 += Val(fila(0))
            candidato2 += Val(fila(1))
            candidato3 += Val(fila(2))
            candidato4 += Val(fila(3))
        Next

        If candidato1 >= candidato2 AndAlso candidato1 >= candidato3 AndAlso candidato1 >= candidato4 Then
            TextBoxMas.Text = "El candidato con más votos fue el 1, total: " & candidato1
        ElseIf candidato2 >= candidato1 AndAlso candidato2 >= candidato3 AndAlso candidato2 >= candidato4 Then
            TextBoxMas.Text = "El candidato con más votos fue el 2, total: " & candidato2
        ElseIf candidato3 >= candidato1 AndAlso candidato3 >= candidato2 AndAlso candidato3 >= candidato4 Then
            TextBoxMas.Text = "El candidato con más votos fue el 3, total: " & candidato3
        Else
            TextBoxMas.Text = "El candidato con más votos fue el 4, total: " & candidato4
        End If

        If candidato1 <= candidato2 AndAlso candidato1 <= candidato3 AndAlso candidato1 <= candidato4 Then
            TextBoxMenos.Text = "El candidato con menos votos fue el 1, total: " & candidato1
        ElseIf candidato2 <= candidato1 AndAlso candidato2 <= candidato3 AndAlso candidato2 <= candidato4 Then
            TextBoxMenos.Text = "El candidato con menos votos fue el 2, total: " & candidato2
        ElseIf candidato3 <= candidato1 AndAlso candidato3 <= candidato2 AndAlso candidato3 <= candidato4 Then
            TextBoxMenos.Text = "El candidato con menos votos fue el 3, total: " & candidato3
        Else
            TextBoxMenos.Text = "El candidato con menos votos fue el 4, total: " & candidato4
        End If

    End Sub


End Class