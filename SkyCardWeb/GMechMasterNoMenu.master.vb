Imports System.Data.Odbc

Partial Class GMechMasterNoMenu
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        If String.IsNullOrEmpty(Session("LoginID")) Then
            Dim authUserID As String = HttpContext.Current.User.Identity.Name
            Session("LoginID") = authUserID
        End If
    End Sub

    Protected Overrides Sub AddedControl(ByVal control As Control, ByVal index As Integer)
        ' This is necessary because Safari and Chrome browsers don't display the Menu control correctly. 
        ' Add this to the code in your master page. 
        If Request.ServerVariables("http_user_agent").IndexOf("Safari", StringComparison.CurrentCultureIgnoreCase) <> -1 Then
            Me.Page.ClientTarget = "uplevel"
        End If

        MyBase.AddedControl(control, index)
    End Sub



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub



    Public Sub ShowErrorMessage(ByVal strErrorText As String)

        Me.lblContentBodyError.ForeColor = Drawing.Color.Red
        Me.lblContentBodyError.Text = strErrorText
        Me.lblContentBodyError.Visible = True

    End Sub
    Public Sub ShowSuccessMessage(ByVal strMessageText As String)

        Me.lblContentBodyError.ForeColor = Drawing.Color.ForestGreen
        Me.lblContentBodyError.Text = strMessageText
        Me.lblContentBodyError.Visible = True

    End Sub
    Public Sub RemoveErrorMessage()
        Me.lblContentBodyError.ForeColor = Drawing.Color.Red
        Me.lblContentBodyError.Text = ""
        Me.lblContentBodyError.Visible = False

    End Sub

End Class

