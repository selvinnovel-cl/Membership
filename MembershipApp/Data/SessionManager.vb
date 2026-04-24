Namespace Data

    ''' <summary>
    ''' Holds runtime context for the currently authenticated user.
    ''' </summary>
    Public Class SessionManager

        Public Shared Property UserId As Integer
        Public Shared Property UserName As String
        Public Shared Property Role As String
        Public Shared Property IsAuthenticated As Boolean = False

        Public Shared Sub Clear()
            UserId = 0
            UserName = String.Empty
            Role = String.Empty
            IsAuthenticated = False
        End Sub

    End Class

End Namespace
