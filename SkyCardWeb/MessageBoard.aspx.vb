Imports System.Data
Partial Class MessageBoard
    Inherits System.Web.UI.Page
    Private txtInitialComment As TextBox = Nothing
    Private ddlInitialCommentType As DropDownList = Nothing

    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = True Then
            Me.lblContentBodyError.Visible = False
        End If
    End Sub

    Protected Sub gvLookupTable_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLookupTable.RowCommand
        Select Case e.CommandName
            Case "Insert"
                Me.sqldsLookupTableData.Insert()
                Me.gvLookupTable.DataBind()
        End Select

    End Sub

    Protected Sub sqldsLookupTableData_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsLookupTableData.Selecting
        'e.Command.Parameters("CommentTable").Value = Session("CommentTable")
        'e.Command.Parameters("CommentID").Value = Session("CommentID").ToString
        e.Command.Parameters("@CommentTable").Value = "Admin"
        e.Command.Parameters("@CommentID").Value = "1"


    End Sub


    Protected Sub sqldsLookupTableData_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Inserting
        Dim txtComment As TextBox = Nothing
        Dim ddlCommentType As DropDownList = Nothing

        If Me.gvLookupTable.Rows.Count = 0 Then
            txtComment = txtInitialComment
            ddlCommentType = ddlInitialCommentType
        Else
            txtComment = CType(Me.gvLookupTable.FooterRow.FindControl("CommentDesc"), TextBox)
            ddlCommentType = CType(Me.gvLookupTable.FooterRow.FindControl("CommentType"), DropDownList)
        End If

        If String.IsNullOrEmpty(txtComment.Text) Then
            Me.lblContentBodyError.Text = "The Comment field is required."
            Me.lblContentBodyError.Visible = True
            e.Cancel = True
            Exit Sub
        End If

        e.Command.Parameters("@CommentTable").Value = "Admin"
        e.Command.Parameters("@CommentID").Value = "1"
        e.Command.Parameters("@CommentDesc").Value = txtComment.Text
        e.Command.Parameters("@UserID").Value = Session("LoginID")
        e.Command.Parameters("@CommentType").Value = ddlCommentType.SelectedValue

    End Sub


    Protected Sub btnEmptyAddItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        txtInitialComment = CType(CType(sender, ImageButton).NamingContainer.FindControl("CommentDesc"), TextBox)
        ddlInitialCommentType = CType(CType(sender, ImageButton).NamingContainer.FindControl("CommentType"), DropDownList)
        Me.sqldsLookupTableData.Insert()
        Me.gvLookupTable.DataBind()

    End Sub

    Public Sub New()

    End Sub
End Class
