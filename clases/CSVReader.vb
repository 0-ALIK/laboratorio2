Imports Microsoft.VisualBasic.FileIO
Public Class CSVReader

    Private CSVruta As String
    Private delimitador As String

    Public Sub New(CSVruta As String, Optional delimitador As String = ";")
        Me.CSVruta = CSVruta
        Me.delimitador = delimitador
    End Sub

    Public Function cargarDatosCSV() As String()()
        Try
            Dim datos As New List(Of String())()

            Using parser As New TextFieldParser(CSVruta)
                parser.TextFieldType = FieldType.Delimited
                parser.SetDelimiters(Me.delimitador)

                While Not parser.EndOfData
                    datos.Add(parser.ReadFields())
                End While
            End Using

            Return datos.ToArray()
        Catch ex As Exception
            Throw New Exception("Error al cargar el archivo CSV: " & ex.Message)
        End Try
    End Function

End Class
