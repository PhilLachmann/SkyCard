
Partial Class UserStoreMaint
    Inherits System.Web.UI.Page

    Protected Sub gvLookupTable_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLookupTable.RowCommand
        Select Case e.CommandName
            Case "Insert"
                Me.sqldsLookupTableData.Insert()
                Me.gvLookupTable.DataBind()
            Case "Update"
                Me.gvLookupTable.DataBind()
                gvLookupTable.ShowFooter = True
        End Select

    End Sub

    Protected Sub sqldsLookupTableData_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Inserting
        Dim ddlUser As DropDownList = CType(Me.gvLookupTable.FooterRow.FindControl("ddlUsers"), DropDownList)
        Dim ddlStore As DropDownList = CType(Me.gvLookupTable.FooterRow.FindControl("ddlStores"), DropDownList)


        e.Command.Parameters("@userid").Value = ddlUser.SelectedValue
        e.Command.Parameters("@storeid").Value = ddlStore.SelectedValue
       
    End Sub

    Protected Sub gvLookupTable_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles gvLookupTable.RowEditing
        gvLookupTable.ShowFooter = False
    End Sub

    Protected Sub gvLookupTable_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvLookupTable.SelectedIndexChanged

    End Sub
End Class
