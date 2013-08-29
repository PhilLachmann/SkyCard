Imports System.Data.Odbc

Partial Class GMechMaster
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
        If Page.IsPostBack = False Then
            Me.lblHeaderUserInfo.Text = Today().ToShortDateString & " " & Now().ToShortTimeString & " - " & Session("LoginID")

        End If

        If Session("SecurityRole") <> "admin" And Session("SecurityRole") <> "superadmin" Then
            'turn off the admin menu
            Me.mnuGMech.Items.RemoveAt(3)
        Else
            Me.mnuGMech.Items.RemoveAt(4)
        End If

        If Session("SecurityRole") = "readonly" Then
            If Me.mnuGMech.Items(0).ChildItems(0).Text = "Edit Assets" Then
                Me.mnuGMech.Items(0).ChildItems(0).Text = "View Assets"
            End If
        End If

        'GetMinValText()
        'GetReorderValText()
    End Sub

    'Protected Sub GetMinValText()
    '    Dim theValue As Integer = 0

    '    Dim conn As New OdbcConnection(ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString)
    '    Dim cmd As New OdbcCommand("SELECT func_NumBelowMinOrReorder(1)", conn)

    '    cmd.Connection.Open()
    '    Try
    '        Dim i As Integer = cmd.ExecuteScalar()
    '        If i = 0 Then
    '            Me.lblMinCount.Text = ""
    '        Else
    '            Me.lblMinCount.Text = "Items Below Min Level: " + i.ToString()
    '        End If

    '    Catch ex As Exception
    '        Me.lblMinCount.Text = ""
    '    End Try

    '    cmd.Connection.Close()
    'End Sub

    'Protected Sub GetReorderValText()
    '    Dim theValue As Integer = 0

    '    Dim conn As New OdbcConnection(ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString)
    '    Dim cmd As New OdbcCommand("SELECT func_NumBelowMinOrReorder(2)", conn)

    '    cmd.Connection.Open()
    '    Try
    '        Dim i As Integer = cmd.ExecuteScalar()
    '        If i = 0 Then
    '            Me.lblReorderCount.Text = ""
    '        Else
    '            Me.lblReorderCount.Text = "   Items Below Reorder Level: " + Convert.ToString(cmd.ExecuteScalar())
    '        End If

    '    Catch ex As Exception
    '        Me.lblReorderCount.Text = ""
    '    End Try

    '    cmd.Connection.Close()
    'End Sub



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

