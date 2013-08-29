
Partial Class BackOrderMaint
    Inherits System.Web.UI.Page
    Dim intRowIndex As Integer

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
            Case "Delete"
                intRowIndex = CType(e.CommandArgument, Integer) + (Me.gvLookupTable.PageSize * Me.gvLookupTable.PageIndex)
                Me.sqldsLookupTableData.Update()
                Me.gvLookupTable.DataBind()
        End Select

    End Sub

    Protected Sub sqldsLookupTableData_Deleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Deleting
        e.Cancel = True
    End Sub

    Protected Sub sqldsLookupTableData_Updating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Updating

        Dim strRecordID As String = Me.gvLookupTable.DataKeys(intRowIndex).Value.ToString

        e.Command.Parameters("RecordID").Value = strRecordID

    End Sub



End Class
