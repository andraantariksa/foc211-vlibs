Imports System.Text.RegularExpressions

Public Class ValidatorHelper
    Public Shared Function IsEmail(email As String) As Boolean
        Return Regex.IsMatch(email, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function
    Public Shared Function IsUsername(username As String) As Boolean
        Return Regex.IsMatch(username, "^[a-zA-Z0-9_]{6,15}$")
    End Function

    Public Shared Function IsPassword(password As String) As Boolean
        Return Regex.IsMatch(password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{6,15})")
    End Function
End Class
