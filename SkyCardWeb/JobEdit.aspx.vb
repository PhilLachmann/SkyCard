
Partial Class JobEdit
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
        Dim strJobID As String = Session("JobID")

        e.Command.Parameters("JobID").Value = strJobID

    End Sub


    Protected Sub gvLookupTable_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvLookupTable.DataBound
        Me.gvLookupTable.EditIndex = 0
    End Sub

    Protected Sub gvLookupTable_RowCancelingEdit(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCancelEditEventArgs) Handles gvLookupTable.RowCancelingEdit
        Dim arrlstJobSrchCriteria As ArrayList = Session("SearchCriteria")
        arrlstJobSrchCriteria(0) = True
        Session("SearchCriteria") = arrlstJobSrchCriteria

        Response.Redirect("SearchJob.aspx")

    End Sub

    Protected Sub gvLookupTable_RowUpdated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewUpdatedEventArgs) Handles gvLookupTable.RowUpdated
        If e.AffectedRows > 0 Then
            Dim arrlstJobSrchCriteria As ArrayList = Session("SearchCriteria")
            arrlstJobSrchCriteria(0) = True
            Session("SearchCriteria") = arrlstJobSrchCriteria

            Response.Redirect("SearchJob.aspx")
        Else
            If e.Exception IsNot Nothing Then
                Me.lblContentBodyError.Text = e.Exception.Message
                Me.lblContentBodyError.Visible = True
            End If
        End If


    End Sub

    Protected Sub sqldsLookupTableData_Updating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Updating

        Dim row As GridViewRow = Me.gvLookupTable.Rows(Me.gvLookupTable.EditIndex)

        Dim strJobIDKey As String = Me.gvLookupTable.DataKeys(Me.gvLookupTable.EditIndex).Value.ToString
        Dim txtJobID As TextBox = CType(row.FindControl("JobID"), TextBox)
        Dim txtJobDesc As TextBox = CType(row.FindControl("JobDesc"), TextBox)
        Dim txtJobBarcode As TextBox = CType(row.FindControl("JobBarcode"), TextBox)
        Dim ddlActive As DropDownList = CType(row.FindControl("IsActive"), DropDownList)

        If String.IsNullOrEmpty(txtJobID.Text) Or String.IsNullOrEmpty(txtJobDesc.Text) Or String.IsNullOrEmpty(txtJobBarcode.Text) Then
            Me.lblContentBodyError.Text = "The JobID, Job Description, and Job Barcode fields are all required."
            Me.lblContentBodyError.Visible = True
            e.Cancel = True
            Exit Sub
        End If


        Dim uintActive As UInt32 = 0
        If ddlActive.SelectedValue.ToString.ToUpper = "TRUE" Then
            uintActive = 1
        End If

        e.Command.Parameters("JobIDKey").Value = strJobIDKey
        e.Command.Parameters("JobID").Value = txtJobID.Text
        e.Command.Parameters("JobDesc").Value = txtJobDesc.Text
        e.Command.Parameters("JobBarcode").Value = txtJobBarcode.Text
        e.Command.Parameters("IsActive").Value = uintActive


    End Sub
End Class
