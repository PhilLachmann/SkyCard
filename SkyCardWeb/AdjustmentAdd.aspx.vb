Imports System.Data
Partial Class AdjustmentAdd
    Inherits System.Web.UI.Page
    Private drAsParm As DataRow = Nothing
    Private intAdjustmentsInserted As Integer = 0
    Private intAdjustmentsSent As Integer = 0
    Private strErrMsgText As String = ""

    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)

        If Page.IsPostBack = False Then
            Me.lblContentBodyError.Visible = False

            If Session("SaveStatus") = "Success" Then
                mstr.ShowSuccessMessage("All Inventory Adjustments were successfully processed.")
                Session("SaveStatus") = Nothing
            End If

            InitializeGridview()
        Else
            mstr.RemoveErrorMessage()
        End If

    End Sub

    Protected Sub InitializeGridview()

        Dim dv As DataView = CType(Me.sqldsLookupTableData.Select(DataSourceSelectArguments.Empty), DataView)

        Dim dt As DataTable = dv.ToTable
        Dim dr As DataRow = dt.NewRow()
        dr("RecordID") = New System.Guid("00000000-0000-0000-0000-000000000000")
        dt.Rows.Add(dr)

        Me.gvLookupTable.EditIndex = 0

        Me.gvLookupTable.DataSource = dt
        Me.gvLookupTable.DataBind()

        Session("AdjustmentsDataTable") = dt

    End Sub

    Protected Function SaveAdjustmentGridviewToDataTable() As Boolean
        Dim bolRetVal As Boolean = True

        Dim dt As DataTable = Session("AdjustmentsDataTable")
        Dim iCounter As Integer = 0

        'walk through the gridview saving the info in the datatable
        For Each gvr As GridViewRow In Me.gvLookupTable.Rows

            If (dt.Rows(iCounter).Item("RecordID").ToString() = "00000000-0000-0000-0000-000000000000") Then
                If String.IsNullOrEmpty(CType(gvr.FindControl("Quantity"), TextBox).Text) Then
                    dt.Rows(iCounter)("ItemID") = CType(gvr.FindControl("ItemID"), DropDownList).SelectedValue
                    dt.Rows(iCounter)("LocationID") = CType(gvr.FindControl("LocationID"), DropDownList).SelectedValue
                    dt.Rows(iCounter)("JobID") = CType(gvr.FindControl("JobID"), DropDownList).SelectedValue
                    dt.Rows(iCounter)("TransType") = CType(gvr.FindControl("TransType"), DropDownList).SelectedValue

                    Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
                    mstr.ShowErrorMessage("The Quantity field for the last adjustment is blank.  Please enter a value for Quantity and click Accept Changes for this adjustment to include it or Cancel to ignore it.")
                    Return False
                    'Exit Function
                Else
                    'its a new row, show edited with a valid system guid
                    dt.Rows(iCounter)("RecordID") = Guid.NewGuid()
                    dt.Rows(iCounter)("ItemID") = CType(gvr.FindControl("ItemID"), DropDownList).SelectedValue
                    dt.Rows(iCounter)("LocationID") = CType(gvr.FindControl("LocationID"), DropDownList).SelectedValue
                    dt.Rows(iCounter)("JobID") = CType(gvr.FindControl("JobID"), DropDownList).SelectedValue
                    dt.Rows(iCounter)("TransType") = CType(gvr.FindControl("TransType"), DropDownList).SelectedValue
                    dt.Rows(iCounter)("Quantity") = CType(gvr.FindControl("Quantity"), TextBox).Text
                    dt.Rows(iCounter)("UserID") = Session("LoginID")
                End If

            End If

            iCounter = iCounter + 1

        Next

        Session("AdjustmentsDataTable") = dt

        Return bolRetVal

    End Function

    Protected Sub gvLookupTable_RowCancelingEdit(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCancelEditEventArgs) Handles gvLookupTable.RowCancelingEdit
        Dim dt As DataTable = Session("AdjustmentsDataTable")
        dt.Rows.RemoveAt(e.RowIndex)

        'If dt.Rows.Count < 1 Then
        Dim dr As DataRow = dt.NewRow()
        dr("RecordID") = New System.Guid("00000000-0000-0000-0000-000000000000")
        dt.Rows.Add(dr)
        Me.gvLookupTable.EditIndex = dt.Rows.Count - 1
        'End If

        Me.gvLookupTable.DataSource = dt
        Me.gvLookupTable.DataBind()

        Session("AdjustmentsDataTable") = dt

    End Sub

    Protected Sub gvLookupTable_RowUpdating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewUpdateEventArgs) Handles gvLookupTable.RowUpdating
        Dim bolReturnVal As Boolean = SaveAdjustmentGridviewToDataTable()

        If bolReturnVal = True Then
            Dim dt As DataTable = Session("AdjustmentsDataTable")

            Dim dr As DataRow = dt.NewRow()
            dr("RecordID") = New System.Guid("00000000-0000-0000-0000-000000000000")
            dt.Rows.Add(dr)

            Me.gvLookupTable.EditIndex = dt.Rows.Count - 1

            Me.gvLookupTable.DataSource = dt
            Me.gvLookupTable.DataBind()

            Session("AdjustmentsDataTable") = dt
        End If

    End Sub

    Protected Sub gvLookupTable_RowDeleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles gvLookupTable.RowDeleting

        Dim dt As DataTable = Session("AdjustmentsDataTable")
        dt.Rows.RemoveAt(e.RowIndex)

        Me.gvLookupTable.EditIndex = dt.Rows.Count - 1

        Me.gvLookupTable.DataSource = dt
        Me.gvLookupTable.DataBind()

        Session("AdjustmentsDataTable") = dt

    End Sub


    Protected Sub btnProcessAdjustments_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProcessAdjustments.Click
        'check for a quantity in an unaccepted record and error off
        Dim gvr As GridViewRow = Me.gvLookupTable.Rows(Me.gvLookupTable.Rows.Count - 1)
        Dim txtQuantity As TextBox = CType(gvr.FindControl("Quantity"), TextBox)

        Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
        If Not String.IsNullOrEmpty(txtQuantity.Text) Then
            mstr.ShowErrorMessage("The last adjustment appears to have a non blank value in the Quantity field.  Please click Accept Changes for this adjustment to include it or Cancel to ignore it.")
            Exit Sub
        End If

        Dim dt As DataTable = Session("AdjustmentsDataTable")

        'cycle throught the dt and call the Insert method of the sqlds for each one
        For Each dr As DataRow In dt.Rows

            If (dr.Item("RecordID").ToString() = "00000000-0000-0000-0000-000000000000") Then
                'skip
            Else
                drAsParm = dr
                sqldsLookupTableData.Insert()
            End If
        Next

        If intAdjustmentsInserted = intAdjustmentsSent Then
            Session("SaveStatus") = "Success"
            Response.Redirect("AdjustmentAdd.aspx")
        Else
            mstr.ShowErrorMessage("Some of the transcations were unable to be processed.  Please review the Inventory Adjustments Report to determine the items that erred and re-try processing them.")
            Exit Sub
        End If

    End Sub

    Protected Sub sqldsLookupTableData_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsLookupTableData.Inserted
        intAdjustmentsSent = intAdjustmentsSent + 1
        If e.AffectedRows > 0 Then
            'success
            intAdjustmentsInserted = intAdjustmentsInserted + 1
        Else
            Dim intRealErrorStart As Integer = e.Exception.Message.IndexOf("RAISERROR executed: ") + "RAISERROR executed: ".Length
            strErrMsgText = strErrMsgText & ", " & e.Exception.Message.Substring(intRealErrorStart, e.Exception.Message.Length - intRealErrorStart)
            e.ExceptionHandled = True
        End If
    End Sub

    Protected Sub sqldsLookupTableData_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Inserting

        e.Command.Parameters("ItemID").Value = drAsParm("ItemID")
        e.Command.Parameters("LocationID").Value = drAsParm("LocationID")
        e.Command.Parameters("JobID").Value = drAsParm("JobID")
        e.Command.Parameters("TransType").Value = drAsParm("TransType")
        e.Command.Parameters("Quantity").Value = drAsParm("Quantity")
        e.Command.Parameters("UserID").Value = drAsParm("UserID")

    End Sub
End Class
