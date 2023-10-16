Module numeroRevez

    Function InvertirNumero(numero As Integer) As Integer
        If numero < 10 Then
            Return numero
        Else
            Dim ultimoDigito As Integer = numero Mod 10
            Dim restoDelNumero As Integer = numero \ 10
            Dim longitudResto As Integer = CStr(restoDelNumero).Length

            Return ultimoDigito * CInt(Math.Pow(10, longitudResto)) + InvertirNumero(restoDelNumero)
        End If
    End Function

End Module

