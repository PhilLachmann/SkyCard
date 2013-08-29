Imports System.Data

Partial Class PriceMultiplierMaint
    Inherits System.Web.UI.Page
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

        Me.gvLookupTable.DataSourceID = "sqldsLookupTableData"

    End Sub

    Protected Sub gvLookupTable_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLookupTable.RowCommand
        Select Case e.CommandName
            Case "Insert"
                Me.sqldsLookupTableData.Insert()
                Me.gvLookupTable.DataBind()
        End Select

    End Sub

    Protected Sub sqldsLookupTableData_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Inserting
        Dim txtCategoryID As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("CategoryID"), TextBox)
        Dim txtPriceDesc As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("PriceDesc"), TextBox)
        Dim txtCostMultiplier As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("CostMultiplier"), TextBox)
        Dim txtSellMultiplier As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("SellMultiplier"), TextBox)
        Dim txtStartDate As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("StartDate"), TextBox)
        Dim txtStopDate As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("StopDate"), TextBox)

        If String.IsNullOrEmpty(Trim(txtPriceDesc.Text)) Or String.IsNullOrEmpty(Trim(txtCostMultiplier.Text)) Or String.IsNullOrEmpty(Trim(txtSellMultiplier.Text)) Or String.IsNullOrEmpty(Trim(txtStartDate.Text)) Then
            Me.lblContentBodyError.Text = "The Price Description, Cost Multiplier, Sell Multiplier and Start Date fields are all required."
            Me.lblContentBodyError.Visible = True
            e.Cancel = True
            Exit Sub
        End If

        e.Command.Parameters("CategoryID").Value = txtCategoryID.Text
        e.Command.Parameters("PriceDesc").Value = txtPriceDesc.Text
        e.Command.Parameters("CostMultiplier").Value = txtCostMultiplier.Text
        e.Command.Parameters("SellMultiplier").Value = txtSellMultiplier.Text
        e.Command.Parameters("StartDate").Value = txtStartDate.Text
        e.Command.Parameters("Stopdate").Value = txtStopDate.Text

    End Sub


    Protected Sub gvLookupTable_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvLookupTable.DataBound
        If Me.gvLookupTable.Rows.Count > 0 Then
            Dim txtCategoryID As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("CategoryID"), TextBox)
            Dim txtStartDate As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("StartDate"), TextBox)
            Dim txtEndDate As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("StopDate"), TextBox)

            txtCategoryID.Text = Me.PriceCategory.SelectedValue
            txtStartDate.Text = FormatDateTime(Today(), DateFormat.ShortDate)
            txtEndDate.Text = FormatDateTime(CDate("12/31/2999"), DateFormat.ShortDate)
        End If


    End Sub


    Protected Sub lbnAddPriceMultiplier_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim dv As DataView = CType(Me.sqldsLookupTableData.Select(DataSourceSelectArguments.Empty), DataView)

        Dim dt As DataTable = dv.ToTable
        Dim dr As DataRow = dt.NewRow()
        dr("RecordID") = New System.Guid("00000000-0000-0000-0000-000000000000")
        dr("IsActive") = 1
        dt.Rows.Add(dr)

        'Me.gvLookupTable.EditIndex = 0

        Me.gvLookupTable.DataSourceID = Nothing
        Me.gvLookupTable.DataSource = dt
        Me.gvLookupTable.DataBind()

        Me.gvLookupTable.Rows(0).Visible = False

    End Sub
End Class
