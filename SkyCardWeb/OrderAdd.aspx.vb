Imports System.Data
Partial Class OrderAdd
    Inherits System.Web.UI.Page
    Private drAsParm As DataRow = Nothing
    Private intAdjustmentsInserted As Integer = 0
    Private intAdjustmentsSent As Integer = 0
    Private strErrMsgText As String = ""
    Private intOrderNumber As Integer = 0
    Private intItemCounter As Integer = 0

    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)

        If Page.IsPostBack = False Then
            'these need to be loaded programmatically in order to force the Databind early (so that we can set defaults in the DataBound)
            Me.JobID.DataSourceID = "sqldsJoblistddl"
            Me.JobID.DataBind()
            Me.LocationID.DataSourceID = "sqldsLocationListddl"
            Me.LocationID.DataBind()
            Me.lblContentBodyError.Visible = False

            If Session("SaveStatus") = "Success" Then
                mstr.ShowSuccessMessage("The Order was successfully processed.")
                Session("SaveStatus") = Nothing
            End If

            Me.hfdJobID.Value = Me.JobID.SelectedValue
            Me.hfdLocationID.Value = Me.LocationID.SelectedValue

            InitializeGridview()
        Else
            mstr.RemoveErrorMessage()
        End If

    End Sub

    Protected Sub InitializeGridview()
        'save off anything that has been entered so far
        Dim dtSaved As DataTable = Nothing
        If Session("OrdersDataTable") IsNot Nothing Then
            Dim dtTest As DataTable = CType(Session("OrdersDataTable"), DataTable)
            If dtTest.Rows.Count > 1 Then
                dtSaved = CType(Session("OrdersDataTable"), DataTable).Copy()
            End If
        End If

        'get structure of Order record
        Dim dv As DataView = CType(Me.sqldsLookupTableData.Select(DataSourceSelectArguments.Empty), DataView)
        Dim dt As DataTable = dv.ToTable

        'query for Back orders here and format rows if any found
        Dim dvbo As DataView = CType(Me.sqldsBackOrders.Select(DataSourceSelectArguments.Empty), DataView)
        If dvbo IsNot Nothing Then
            Dim dtbo As DataTable = dvbo.ToTable
            If dtbo.Rows.Count > 0 Then
                For Each drbo As DataRow In dtbo.Rows
                    Dim drNewRow As DataRow = dt.NewRow()
                    drNewRow("RecordID") = drbo("RecordID")
                    drNewRow("OrderNumber") = 0 'drbo("OrderNumber")
                    drNewRow("LineNumber") = drbo("LineNumber")
                    drNewRow("ItemID") = drbo("ItemID")
                    drNewRow("TransType") = "ORD"
                    drNewRow("Quantity") = drbo("BackOrderQty")
                    drNewRow("JobID") = drbo("JobID")
                    drNewRow("LocationID") = drbo("LocationID")
                    drNewRow("PriceCategory") = drbo("PriceCategory")
                    drNewRow("UserID") = Session("LoginID")
                    drNewRow("Comments") = drbo("Comments")
                    drNewRow("ItemDesc") = drbo("ItemDesc")
                    dt.Rows.Add(drNewRow)
                Next
            End If
        End If

        If dtSaved IsNot Nothing Then
            'load the entries already entered
            For Each drSaved As DataRow In dtSaved.Rows
                dt.ImportRow(drSaved)
            Next
        Else
            'loads a new row for entry
            Dim dr As DataRow = dt.NewRow()
            dr("RecordID") = New System.Guid("00000000-0000-0000-0000-000000000000")
            dr("OrderNumber") = 0
            dr("LineNumber") = 0
            dt.Rows.Add(dr)

        End If

        'Me.gvLookupTable.EditIndex = Me.gvLookupTable.Rows.Count - 1
        Me.gvLookupTable.EditIndex = dt.Rows.Count - 1

        Me.gvLookupTable.DataSource = dt
        Me.gvLookupTable.DataBind()

        'load up the item ddlb for the default category
        Dim e As EventArgs = New EventArgs
        Me.PriceCategory_SelectedIndexChanged(Me.gvLookupTable, e)

        Session("OrdersDataTable") = dt

    End Sub

    Protected Function SaveLineItemGridviewToDataTable() As Boolean
        Dim bolRetVal As Boolean = True

        Dim dt As DataTable = Session("OrdersDataTable")
        'Dim iCounter As Integer = 0

        Dim intEditIndex As Integer = Me.gvLookupTable.EditIndex

        Dim gvr As GridViewRow = Me.gvLookupTable.Rows(intEditIndex)

        If String.IsNullOrEmpty(CType(gvr.FindControl("Quantity"), TextBox).Text) Then
            Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
            mstr.ShowErrorMessage("The Quantity field for the last line item is blank.  Please enter a value for Quantity and click Accept Changes for this line item to include it or Cancel to ignore it.")
            Return False
        Else
            If IsNumeric(CType(gvr.FindControl("Quantity"), TextBox).Text) Then
                'its a new row, show edited with a valid system guid
                dt.Rows(intEditIndex)("ItemID") = CType(gvr.FindControl("ItemID"), DropDownList).SelectedValue
                dt.Rows(intEditIndex)("LocationID") = Me.LocationID.SelectedValue
                dt.Rows(intEditIndex)("JobID") = Me.JobID.SelectedValue
                dt.Rows(intEditIndex)("TransType") = "ORD"
                dt.Rows(intEditIndex)("Quantity") = CType(gvr.FindControl("Quantity"), TextBox).Text
                dt.Rows(intEditIndex)("Comments") = CType(gvr.FindControl("Comments"), TextBox).Text
                dt.Rows(intEditIndex)("PriceCategory") = CType(gvr.FindControl("PriceCategory"), DropDownList).SelectedValue
                dt.Rows(intEditIndex)("ItemDesc") = CType(gvr.FindControl("ItemID"), DropDownList).SelectedItem.Text
                dt.Rows(intEditIndex)("UserID") = Session("LoginID")
            Else
                Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
                mstr.ShowErrorMessage("The Quantity field must be Numeric.")
                Return False
            End If

        End If


        Session("OrdersDataTable") = dt

        Return bolRetVal

    End Function

    Protected Sub gvLookupTable_RowCancelingEdit(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCancelEditEventArgs) Handles gvLookupTable.RowCancelingEdit
        Dim dt As DataTable = Session("OrdersDataTable")
        dt.Rows.RemoveAt(e.RowIndex)

        'loads a new row for entry
        Dim dr As DataRow = dt.NewRow()
        dr("RecordID") = New System.Guid("00000000-0000-0000-0000-000000000000")
        dr("OrderNumber") = 0
        dr("LineNumber") = 0
        dt.Rows.Add(dr)

        Me.gvLookupTable.EditIndex = dt.Rows.Count - 1

        Me.gvLookupTable.DataSource = dt
        Me.gvLookupTable.DataBind()

        'load up the item ddlb for the default category
        Dim e2 As EventArgs = New EventArgs
        Me.PriceCategory_SelectedIndexChanged(Me.gvLookupTable, e2)

        Session("OrdersDataTable") = dt

    End Sub

    Protected Sub gvLookupTable_RowUpdating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewUpdateEventArgs) Handles gvLookupTable.RowUpdating
        Dim bolReturnVal As Boolean = SaveLineItemGridviewToDataTable()

        If bolReturnVal = True Then
            Dim dt As DataTable = Session("OrdersDataTable")

            'Find the last category chosen
            Dim strLastChosenCategory As String = ""
            If dt.Rows.Count > 0 Then
                strLastChosenCategory = dt.Rows(dt.Rows.Count - 1)("PriceCategory")
            End If

            'loads a new row for entry
            Dim dr As DataRow = dt.NewRow()
            dr("RecordID") = New System.Guid("00000000-0000-0000-0000-000000000000")
            dr("OrderNumber") = 0
            dr("LineNumber") = 0
            dt.Rows.Add(dr)

            Me.gvLookupTable.EditIndex = dt.Rows.Count - 1

            Me.gvLookupTable.DataSource = dt
            Me.gvLookupTable.DataBind()

            'make last category chosen the default
            If Not String.IsNullOrEmpty(strLastChosenCategory) Then
                Dim ddl As DropDownList = CType(Me.gvLookupTable.Rows(Me.gvLookupTable.Rows.Count - 1).FindControl("PriceCategory"), DropDownList)
                ddl.SelectedValue = strLastChosenCategory
            End If

            'load up the item ddlb for the default category
            Dim e2 As EventArgs = New EventArgs
            Me.PriceCategory_SelectedIndexChanged(Me.gvLookupTable, e2)

            Session("OrdersDataTable") = dt
        End If

    End Sub

    Protected Sub gvLookupTable_RowDeleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles gvLookupTable.RowDeleting

        Dim dt As DataTable = Session("OrdersDataTable")
        dt.Rows.RemoveAt(e.RowIndex)

        Me.gvLookupTable.EditIndex = dt.Rows.Count - 1

        Me.gvLookupTable.DataSource = dt
        Me.gvLookupTable.DataBind()

        'load up the item ddlb for the default category
        Dim e2 As EventArgs = New EventArgs
        Me.PriceCategory_SelectedIndexChanged(Me.gvLookupTable, e2)

        Session("OrdersDataTable") = dt

    End Sub


    Protected Sub btnProcessOrder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProcessOrder.Click
        'check for a quantity in an unaccepted record and error off
        Dim gvr As GridViewRow = Me.gvLookupTable.Rows(Me.gvLookupTable.Rows.Count - 1)
        Dim txtQuantity As TextBox = CType(gvr.FindControl("Quantity"), TextBox)

        Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
        If Not String.IsNullOrEmpty(txtQuantity.Text) Then
            mstr.ShowErrorMessage("The last adjustment appears to have a non blank value in the Quantity field.  Please click Accept Line Item for this line to include it or Cancel to ignore it.")
            Exit Sub
        End If
        If String.IsNullOrEmpty(Me.txtOrderedBy.Text) Then
            mstr.ShowErrorMessage("Please enter a value for Ordered By.")
            Exit Sub
        End If
        If Me.JobID.SelectedValue = "" Then
            mstr.ShowErrorMessage("Please Select a Job for this order.")
            Exit Sub
        End If
        If Me.LocationID.SelectedValue = "" Then
            mstr.ShowErrorMessage("Please Select a Location for this order.")
            Exit Sub
        End If


        Dim dt As DataTable = Session("OrdersDataTable")
        Dim bolRowSaved As Boolean = False

        'cycle throught the dt and call the Insert method of the sqlds for each one
        For Each dr As DataRow In dt.Rows

            If (dr.Item("Quantity").ToString() = "") Then
                'skip
            Else
                drAsParm = dr
                drAsParm("LocationID") = Me.LocationID.SelectedValue
                drAsParm("JobID") = Me.JobID.SelectedValue

                'Adjust drAsParm's order number
                If intOrderNumber <> 0 Then
                    drAsParm("OrderNumber") = intOrderNumber
                End If
                sqldsLookupTableData.Insert()
                bolRowSaved = True
            End If
        Next

        If intAdjustmentsInserted = intAdjustmentsSent Then
            If bolRowSaved = True Then
                Session("SaveStatus") = "Success"
            End If
            Session("OrdersDataTable") = Nothing
            Response.Redirect("OrderAdd.aspx")
        Else
            mstr.ShowErrorMessage("An Error was encountered:" & strErrMsgText & ".  Some of the line items were unable to be processed.  Please review the Order Report to determine the items that erred and re-try processing them.")
            Exit Sub
        End If

    End Sub

    Protected Sub sqldsLookupTableData_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsLookupTableData.Inserted
        intAdjustmentsSent = intAdjustmentsSent + 1
        If e.AffectedRows > 0 Then
            'success
            intAdjustmentsInserted = intAdjustmentsInserted + 1

            'get the order number and compare it to the one being used
            Dim intRetValue As Integer = e.Command.Parameters("ReturnValue").Value
            If intOrderNumber <> intRetValue Then
                intOrderNumber = intRetValue
            End If

        Else
            Dim intRealErrorStart As Integer = e.Exception.Message.IndexOf("RAISERROR executed: ") + "RAISERROR executed: ".Length
            strErrMsgText = strErrMsgText & ", " & e.Exception.Message.Substring(intRealErrorStart, e.Exception.Message.Length - intRealErrorStart)
            e.ExceptionHandled = True
        End If
    End Sub

    Protected Sub sqldsLookupTableData_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Inserting

        intItemCounter = intItemCounter + 1

        e.Command.Parameters("RecordID").Value = drAsParm("RecordID").ToString()
        e.Command.Parameters("OrderNumber").Value = drAsParm("OrderNumber")
        e.Command.Parameters("ItemID").Value = drAsParm("ItemID")
        e.Command.Parameters("TransType").Value = drAsParm("TransType")
        e.Command.Parameters("Quantity").Value = drAsParm("Quantity")
        e.Command.Parameters("LocationID").Value = drAsParm("LocationID")
        e.Command.Parameters("JobID").Value = drAsParm("JobID")
        e.Command.Parameters("UserID").Value = drAsParm("UserID")
        e.Command.Parameters("Comments").Value = drAsParm("Comments")
        If intItemCounter = 1 Then
            e.Command.Parameters("OrderBy").Value = Me.txtOrderedBy.Text
        Else
            e.Command.Parameters("OrderBy").Value = ""
        End If

    End Sub

    Protected Sub PriceCategory_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim dv As DataView = CType(Me.sqldsProductSizeList.Select(DataSourceSelectArguments.Empty), DataView)

        Dim dt As DataTable = dv.ToTable

        Dim ddlItems As DropDownList = CType(Me.gvLookupTable.Rows(Me.gvLookupTable.Rows.Count - 1).FindControl("ItemID"), DropDownList)
        ddlItems.Items.Clear()
        ddlItems.DataSource = dt
        ddlItems.DataBind()

    End Sub

    Protected Sub sqldsProductSizeList_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsProductSizeList.Selecting

        Dim ddlCategories As DropDownList = CType(Me.gvLookupTable.Rows(Me.gvLookupTable.Rows.Count - 1).FindControl("PriceCategory"), DropDownList)
        e.Command.Parameters("CategoryID").Value = ddlCategories.SelectedValue

    End Sub

    Protected Sub JobID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles JobID.SelectedIndexChanged

        'If Me.gvLookupTable.Rows.Count > 1 Then
        '    'msg that they must process the order before changing Job/Location
        '    Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
        '    mstr.ShowErrorMessage("This order has not been processed yet.  Please click Process Order button to process it or Cancel to cancel it.")
        '    Me.JobID.SelectedValue = Me.hfdJobID.Value
        '    Exit Sub
        'Else
        Me.hfdJobID.Value = Me.JobID.SelectedValue
        InitializeGridview()
        'End If

    End Sub

    Protected Sub LocationID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LocationID.SelectedIndexChanged
        'If Me.gvLookupTable.Rows.Count > 1 Then
        '    'msg that they must process the order before changing Job/Location
        '    Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
        '    mstr.ShowErrorMessage("This order has not been processed yet.  Please click Process Order button to process it or Cancel to cancel it.")
        '    Me.LocationID.SelectedValue = Me.hfdLocationID.Value
        '    Exit Sub
        'Else
        Me.hfdLocationID.Value = Me.LocationID.SelectedValue
        InitializeGridview()
        'End If
    End Sub

    Protected Sub gvLookupTable_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvLookupTable.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            If Me.gvLookupTable.DataKeys(e.Row.RowIndex).Value.ToString <> "00000000-0000-0000-0000-000000000000" Then
                Dim txtCategory As TextBox = CType(e.Row.FindControl("PriceCategory"), TextBox)
                Dim txtItemDesc As TextBox = CType(e.Row.FindControl("ItemDesc"), TextBox)
                txtCategory.BackColor = Drawing.Color.LightGoldenrodYellow
                txtItemDesc.BackColor = Drawing.Color.LightGoldenrodYellow
            End If
        End If
    End Sub

    Protected Sub btnCancelOrder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelOrder.Click
        Session("OrdersDataTable") = Nothing
        Response.Redirect("OrderAdd.aspx")
    End Sub
End Class
