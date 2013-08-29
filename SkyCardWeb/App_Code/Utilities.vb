Imports System.Data

Public NotInheritable Class Utilities
    Private Sub New()
    End Sub
    Public Shared Function NullableFormatDateTimeShortDate(ByVal datetm As Object) As String

        If IsDBNull(datetm) Then
            Return ""
        End If
        Return FormatDateTime(datetm, vbShortDate)
    End Function

    Public Shared Function NullableFormatDateTimeDateAndTime(ByVal datetm As Object) As String

        If IsDBNull(datetm) Then
            Return ""
        End If
        Return FormatDateTime(datetm, DateFormat.GeneralDate)
    End Function

    Public Shared Function NullableFormatNumberDecimal2(ByVal num As Object) As String

        If IsDBNull(num) Then
            Return ""
        End If
        Return FormatNumber(num, 2)
    End Function

    Public Shared Function FormatPhone(ByVal strPhoneIn As Object) As String
        Dim strRetValue As String = ""

        If IsDBNull(strPhoneIn) Then
            Return ""
        End If

        If String.IsNullOrEmpty(strPhoneIn) Then
            Return ""
        End If

        strRetValue = "(" & strPhoneIn.Substring(0, 3) & ") " & strPhoneIn.Substring(3, 3) & "-" & strPhoneIn.Substring(6, 4)

        Return strRetValue
    End Function
    Public Shared Function FormatCommentBreaks(ByVal strText As Object) As String
        Dim strRetValue As String = ""

        If IsDBNull(strText) Then
            Return ""
        End If

        If String.IsNullOrEmpty(strText) Then
            Return ""
        End If

        strRetValue = strText.Replace(Convert.ToChar(10).ToString(), "<br />")

        Return strRetValue
    End Function
    Public Shared Function PasswordHasher(ByVal Password As String) As String
        Dim hashMethod As String = "SHA1"
        Dim newHash = FormsAuthentication.HashPasswordForStoringInConfigFile(Password, hashMethod)
        Return newHash
    End Function
End Class
