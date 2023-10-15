Public Class ClassFrmProb1
    Private vector() As Integer
    Public suma1, suma2, suma3 As Integer
    Public Sub asignar(numVec() As Integer)
        vector = numVec
    End Sub

    Public Function suma(ByRef cont1 As Integer, ByRef cont2 As Integer, ByRef Cont3 As Integer) As Integer
        Dim i As Integer
        suma = 0
        Try
            For i = 1 To vector.Length - 1
                If vector(i) >= 1000 Then
                    cont1 += 1
                    suma1 += vector(i)
                    MsgBox("Mayor a 1000")

                ElseIf vector(i) <= 500 Then
                    cont2 += 1
                    suma2 += vector(i)
                    MsgBox("Menor 500")

                ElseIf vector(i) > 500 And vector(i) < 1000 Then
                    Cont3 += 1
                    suma3 += vector(i)
                    MsgBox("Mayor a 500 y Menor a 1000")

                Else
                    MsgBox("Valor Incorrecto")

                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


End Class
