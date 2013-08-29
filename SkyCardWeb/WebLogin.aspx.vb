Imports System.Data

Partial Class WebLogin
    Inherits System.Web.UI.Page

    Dim dtUserInfo As DataTable = Nothing

    Protected Sub lgnLogin_Authenticate(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AuthenticateEventArgs) Handles lgnLogin.Authenticate
        Dim dv As DataView = CType(sqldsUserCredentials.Select(DataSourceSelectArguments.Empty), DataView)

        If dv.Count > 0 Then
            Dim dt As DataTable = dv.ToTable
            dtUserInfo = dt.Copy
            e.Authenticated = True
            'FormsAuthentication.RedirectFromLoginPage(dt(0)("UserID"), False)
        Else
            Return
        End If

    End Sub

    Protected Sub lgnLogin_LoggedIn(ByVal sender As Object, ByVal e As System.EventArgs) Handles lgnLogin.LoggedIn

        Session("SecurityRole") = dtUserInfo(0)("Role")
        Session("Username") = dtUserInfo(0)("login")
        Session("FullName") = dtUserInfo(0)("username")

        Try
            FormsAuthentication.RedirectFromLoginPage(dtUserInfo(0)("Username"), False)
        Catch ex As Exception
            Dim strURL As String = "Default.aspx"
            FormsAuthentication.SetAuthCookie(dtUserInfo(0)("Username"), False)
            Response.Redirect(strURL)
        End Try

    End Sub

    Protected Sub sqldsUserCredentials_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsUserCredentials.Selecting
        e.Command.Parameters("@LoginID").Value = Me.lgnLogin.UserName
        Dim hash As String = Utilities.PasswordHasher(Me.lgnLogin.Password)
        'Dim hash As String = Me.lgnLogin.Password
        e.Command.Parameters("@Password").Value = Me.lgnLogin.Password
    End Sub
End Class
