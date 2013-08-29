
Partial Class ProductEdit
    Inherits System.Web.UI.Page
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            'BindData()
        End If
    End Sub

    Protected Sub sqldsLookupTableData_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsLookupTableData.Selecting
        Dim strItemID As String = Session("ItemID")

        e.Command.Parameters("ItemID").Value = strItemID

    End Sub


    Protected Sub gvLookupTable_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvLookupTable.DataBound
        Me.gvLookupTable.EditIndex = 0
    End Sub

    Protected Sub gvLookupTable_RowCancelingEdit(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCancelEditEventArgs) Handles gvLookupTable.RowCancelingEdit
        Dim arrlstProductSrchCriteria As ArrayList = Session("SearchCriteria")
        arrlstProductSrchCriteria(0) = True
        Session("SearchCriteria") = arrlstProductSrchCriteria

        Response.Redirect("SearchProduct.aspx")

    End Sub

    Protected Sub gvLookupTable_RowUpdated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewUpdatedEventArgs) Handles gvLookupTable.RowUpdated
        If e.AffectedRows > 0 Then
            Dim arrlstProductSrchCriteria As ArrayList = Session("SearchCriteria")
            arrlstProductSrchCriteria(0) = True
            Session("SearchCriteria") = arrlstProductSrchCriteria

            Response.Redirect("SearchProduct.aspx")
        Else
            If e.Exception IsNot Nothing Then
                Me.lblContentBodyError.Text = e.Exception.Message
                Me.lblContentBodyError.Visible = True
            End If
        End If


    End Sub

    Protected Sub sqldsLookupTableData_Updating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Updating

        Dim row As GridViewRow = Me.gvLookupTable.Rows(Me.gvLookupTable.EditIndex)

        Dim strItemIDKey As String = Me.gvLookupTable.DataKeys(Me.gvLookupTable.EditIndex).Value.ToString
        Dim txtItemID As TextBox = CType(row.FindControl("ItemID"), TextBox)
        Dim txtItemDesc As TextBox = CType(row.FindControl("ItemDesc"), TextBox)
        Dim txtBarcode As TextBox = CType(row.FindControl("Barcode"), TextBox)
        Dim txtListPrice As TextBox = CType(row.FindControl("ListPrice"), TextBox)
        Dim txtInvMin As TextBox = CType(row.FindControl("InvMin"), TextBox)
        Dim txtInvMax As TextBox = CType(row.FindControl("InvMax"), TextBox)
        Dim ddlPriceCategory As DropDownList = CType(row.FindControl("PriceCategory"), DropDownList)
        Dim ddlUOM As DropDownList = CType(row.FindControl("UOM"), DropDownList)
        Dim ddlActive As DropDownList = CType(row.FindControl("IsActive"), DropDownList)

        If String.IsNullOrEmpty(txtItemID.Text) Or String.IsNullOrEmpty(txtItemDesc.Text) Then
            Me.lblContentBodyError.Text = "The ItemID and Item Description fields are both required."
            Me.lblContentBodyError.Visible = True
            e.Cancel = True
            Exit Sub
        End If

        If Not IsNumeric(txtInvMin.Text) Or Not IsNumeric(txtInvMax.Text) Or Not IsNumeric(txtListPrice.Text) Then
            Me.lblContentBodyError.Text = "The Inventory Min, Max and List Price must be numeric."
            Me.lblContentBodyError.Visible = True
            e.Cancel = True
            Exit Sub
        End If

        Dim uintActive As UInt32 = 0
        If ddlActive.SelectedValue.ToString.ToUpper = "TRUE" Then
            uintActive = 1
        End If

        e.Command.Parameters("ItemIDKey").Value = strItemIDKey
        e.Command.Parameters("ItemID").Value = txtItemID.Text
        e.Command.Parameters("ItemDesc").Value = txtItemDesc.Text
        e.Command.Parameters("Barcode").Value = txtBarcode.Text
        e.Command.Parameters("ListPrice").Value = txtListPrice.Text
        e.Command.Parameters("InvMin").Value = txtInvMin.Text
        e.Command.Parameters("InvMax").Value = txtInvMax.Text
        e.Command.Parameters("PriceCategory").Value = ddlPriceCategory.SelectedValue
        e.Command.Parameters("UOM").Value = ddlUOM.SelectedValue
        e.Command.Parameters("IsActive").Value = uintActive

    End Sub
End Class
