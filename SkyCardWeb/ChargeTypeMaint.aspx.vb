
Partial Class ChargeTypeMaint
    Inherits System.Web.UI.Page

    Protected Sub gvLookupTable_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLookupTable.RowCommand
        Select Case e.CommandName
            Case "Insert"
                Me.sqldsLookupTableData.Insert()
                Me.gvLookupTable.DataBind()
        End Select

    End Sub

    Protected Sub sqldsLookupTableData_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Inserting
        Dim txtDesc As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("ChargeType"), TextBox)
        'Dim ddlActive As DropDownList = CType(Me.gvLookupTable.FooterRow.FindControl("Deleted"), DropDownList)


        e.Command.Parameters("@ChargeType").Value = txtDesc.Text
        ' e.Command.Parameters("@Deleted").Value = ddlActive.SelectedValue

    End Sub
End Class
