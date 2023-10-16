Module sensorTemp
    Dim contadorMayor37 As Integer = 0
    Dim contadorMenor33 As Integer = 0

    Public Sub RegistrarTemperatura(temperaturaTexto As Double)
        Dim temp As Double

        If Not String.IsNullOrEmpty(temperaturaTexto) AndAlso Double.TryParse(temperaturaTexto, temp) Then
            If temp > 37 Then
                contadorMayor37 += 1
            ElseIf temp < 33 Then
                contadorMenor33 += 1
            End If
        End If
    End Sub

    Public Function ObtenerTempMayor() As String
        Return "Personas con temperatura mayor a 37°C: " & contadorMayor37
    End Function
    Public Function ObtenerTempMenor() As String
        Return "Personas con temperatura menor a 33°C: " & contadorMenor33
    End Function
End Module




