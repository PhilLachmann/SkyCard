Imports System.Security

Partial Class ChangePassword
    Inherits System.Web.UI.Page
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Response.Redirect("Default.aspx")
    End Sub

    Protected Sub btnChangePassword_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChangePassword.Click

        If EditControls() = False Then
            Me.lblError.Visible = True
            Exit Sub
        Else
            Me.lblError.Visible = False
        End If

        Dim p1 As String = Session("Username")
        Dim p2 As String = Me.txtCurrentPassword.Text.Trim
        Dim p3 As String = Me.txtNewPassword.Text.Trim

        Me.sqldsUserCredentials.UpdateParameters("LoginID").DefaultValue = p1
        'Me.sqldsUserCredentials.UpdateParameters("OldPassword").DefaultValue = Utilities.PasswordHasher(Me.txtCurrentPassword.Text.Trim)
        'Me.sqldsUserCredentials.UpdateParameters("NewPassword").DefaultValue = Utilities.PasswordHasher(Me.txtNewPassword.Text.Trim)
        Me.sqldsUserCredentials.UpdateParameters("OldPassword").DefaultValue = p2
        Me.sqldsUserCredentials.UpdateParameters("NewPassword").DefaultValue = p3

        Me.sqldsUserCredentials.Update()

    End Sub

    





    Protected Sub btnContinue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        Response.Redirect("Default.aspx")
    End Sub

    Protected Function EditControls() As Boolean
        Dim bolRetValue As Boolean = True

        If Trim(Me.txtNewPassword.Text).Length <= 0 Then
            Me.lblError.Text = "The New password is blank.  Please enter a new password."
            bolRetValue = False
        End If

        If Trim(Me.txtNewPassword.Text) <> Trim(Me.txtConfirmPassword.Text) Then
            Me.lblError.Text = "The Confirmation password is not the same as the New password."
            bolRetValue = False
        End If

        If Trim(Me.txtNewPassword.Text) = Trim(Me.txtCurrentPassword.Text) Then
            Me.lblError.Text = "The New password is the same as the Current password.  Please enter a new password."
            bolRetValue = False
        End If

        Return bolRetValue
    End Function

    Protected Sub sqldsUserCredentials_Updated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsUserCredentials.Updated
        If e.AffectedRows > 0 Then
            'success
            Me.lblTitle.Text = "Password Successfully Changed."
            Me.pnlContinue.Visible = True
            Me.pnlTextBoxControls.Visible = False
        Else


            'display error
            Dim intRealErrorStart As Integer = e.Exception.Message.IndexOf("RAISERROR executed: ") + "RAISERROR executed: ".Length
            Dim strErrMsgText As String = e.Exception.Message.Substring(intRealErrorStart, e.Exception.Message.Length - intRealErrorStart)
            Me.lblError.Text = strErrMsgText
            Me.lblError.Visible = True
            e.ExceptionHandled = True
        End If

    End Sub

End Class
