Module ConvertAndValidate

    Sub Main()


    End Sub
    Private Function ValidateAndConvert(convertThisString As String, ByRef toThisInteger As Integer) As String
        Dim message As String

        Try
            toThisInteger = CInt(convertThisString)

            message = ""
        Catch ex As Exception
            If convertThisString = "" Then
                message = "is empty"
            Else
                message = "must contain a number"
            End If

        End Try

        Return message$


    End Function
End Module
