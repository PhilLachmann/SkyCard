Imports System.Data

Partial Class ProductAdd
    Inherits System.Web.UI.Page
    Private strItemID As String = ""
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Dim dv As DataView = CType(Me.sqldsLookupTableData.Select(DataSourceSelectArguments.Empty), DataView)

            Dim dt As DataTable = dv.ToTable
            Dim dr As DataRow = dt.NewRow()
            dt.Rows.Add(dr)

            Me.gvLookupTable.DataSource = dt
            Me.gvLookupTable.DataBind()

        End If
    End Sub

    Protected Sub gvLookupTable_RowCancelingEdit(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCancelEditEventArgs) Handles gvLookupTable.RowCancelingEdit

        Response.Redirect("SearchProduct.aspx")

    End Sub
    Protected Sub gvLookupTable_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLookupTable.RowCommand
        Select Case e.CommandName
            Case "Insert"
                Try
                    Dim intAffectedRows As Integer = Me.sqldsLookupTableData.Insert()
                    If intAffectedRows > 0 Then
                        Dim arrlstProductSrchCriteria As ArrayList = New ArrayList()
                        arrlstProductSrchCriteria.Add(True)
                        arrlstProductSrchCriteria.Add(strItemID)
                        Session("SearchCriteria") = arrlstProductSrchCriteria

                        Response.Redirect("SearchProduct.aspx")
                    End If

                Catch ex As Exception
                    Me.lblContentBodyError.Text = ex.Message
                    Me.lblContentBodyError.Visible = True
                End Try

        End Select
    End Sub
    Protected Sub sqldsLookupTableData_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Inserting
        Dim row As GridViewRow = Me.gvLookupTable.Rows(0)

        Dim txtItemID As TextBox = CType(row.FindControl("ItemID"), TextBox)
        Dim txtItemDesc As TextBox = CType(row.FindControl("ItemDesc"), TextBox)
        Dim txtListPrice As TextBox = CType(row.FindControl("ListPrice"), TextBox)
        Dim txtInvMin As TextBox = CType(row.FindControl("InvMin"), TextBox)
        Dim txtInvMax As TextBox = CType(row.FindControl("InvMax"), TextBox)
        Dim txtPriceCategory As TextBox = CType(row.FindControl("PriceCategory"), TextBox)
        Dim txtUOM As TextBox = CType(row.FindControl("UOM"), TextBox)
        'Dim ddlPriceCategory As DropDownList = CType(row.FindControl("PriceCategory"), DropDownList)
        'Dim ddlUOM As DropDownList = CType(row.FindControl("UOM"), DropDownList)
        Dim ddlActive As DropDownList = CType(row.FindControl("IsActive"), DropDownList)

        If String.IsNullOrEmpty(txtItemID.Text) Or String.IsNullOrEmpty(txtItemDesc.Text) Or String.IsNullOrEmpty(txtPriceCategory.Text) Or String.IsNullOrEmpty(txtUOM.Text) Then
            Me.lblContentBodyError.Text = "The ItemID, Item Description, Size, and Price Category fields are all required."
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

        strItemID = txtItemID.Text
        e.Command.Parameters("ItemID").Value = txtItemID.Text
        e.Command.Parameters("ItemDesc").Value = txtItemDesc.Text
        e.Command.Parameters("ListPrice").Value = txtListPrice.Text
        e.Command.Parameters("InvMin").Value = txtInvMin.Text
        e.Command.Parameters("InvMax").Value = txtInvMax.Text
        e.Command.Parameters("PriceCategory").Value = txtPriceCategory.Text.ToUpper
        e.Command.Parameters("UOM").Value = txtUOM.Text.ToUpper
        'e.Command.Parameters("PriceCategory").Value = ddlPriceCategory.SelectedValue
        'e.Command.Parameters("UOM").Value = ddlUOM.SelectedValue
        e.Command.Parameters("IsActive").Value = uintActive

    End Sub
End Class
