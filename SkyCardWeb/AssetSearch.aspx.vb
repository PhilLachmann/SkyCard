Imports System.Data



Partial Class AssetSearch
    Inherits System.Web.UI.Page
    Private drAsParm As DataRow = Nothing
    Private intAdjustmentsInserted As Integer = 0
    Private intAdjustmentsSent As Integer = 0
    Private strErrMsgText As String = ""
    Private storeSelected As Boolean = False
    Private headerID As Integer

    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)

        If Page.IsPostBack = False Then
            InitializeGridview()
        Else
            mstr.RemoveErrorMessage()
        End If
    End Sub

    Protected Sub InitializeGridview()

        Dim dv As DataView = CType(Me.sqldsSearchSchema.Select(DataSourceSelectArguments.Empty), DataView)

        Dim dt As DataTable = dv.ToTable
        'Dim dr As DataRow = dt.NewRow()
        'dr("Record_ID") = 0
        'dr("tagname") = "Description"
        'dr("operation") = "Equals"
        'dt.Rows.Add(dr)

        Me.gvLookupTable.EditIndex = 0

        Me.gvLookupTable.DataSource = dt
        Me.gvLookupTable.DataBind()

        Session("AdjustmentsDataTable") = dt

    End Sub

   

  

    Protected Function SaveAdjustmentGridviewToDataTable() As Boolean
        Dim bolRetVal As Boolean = True

        Dim dt As DataTable = Session("AdjustmentsDataTable")
        Dim iCounter As Integer = 0

        'save the header info here


        'walk through the gridview saving the info in the datatable
        For Each gvr As GridViewRow In Me.gvLookupTable.Rows

            If (dt.Rows(iCounter).Item("Record_ID") = 0) Or (gvr.RowState And DataControlRowState.Edit) <> 0 Then
                If String.IsNullOrEmpty(CType(gvr.FindControl("Tagvalue"), TextBox).Text) Then
                    dt.Rows(iCounter)("Tagname") = CType(gvr.FindControl("Tagname"), DropDownList).SelectedValue
                    dt.Rows(iCounter)("Operation") = CType(gvr.FindControl("Operation"), DropDownList).SelectedValue

                    Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
                    mstr.ShowErrorMessage("The TagValue field for the last criterion is blank.  Please enter a value to search for and click Accept Changes for this criterion to include it or Cancel to ignore it.")

                    Return False
                    'Exit Function
                Else
                    'its a new row, show edited with a valid system guid
                    dt.Rows(iCounter)("Record_ID") = dt.Rows.Count + 1
                    dt.Rows(iCounter)("Tagname") = CType(gvr.FindControl("Tagname"), DropDownList).SelectedValue
                    dt.Rows(iCounter)("TagValue") = CType(gvr.FindControl("TagValue"), TextBox).Text
                    dt.Rows(iCounter)("Operation") = CType(gvr.FindControl("Operation"), DropDownList).SelectedValue

                End If

            End If

            iCounter = iCounter + 1

        Next

        Session("AdjustmentsDataTable") = dt

        Return bolRetVal

    End Function

    Protected Sub gvLookupTable_RowCancelingEdit(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCancelEditEventArgs) Handles gvLookupTable.RowCancelingEdit
        Dim dt As DataTable = Session("AdjustmentsDataTable")
        If dt.Rows(e.RowIndex)("Record_ID") = 0 Then
            dt.Rows.RemoveAt(e.RowIndex)
        End If

        'If dt.Rows.Count < 1 Then
        Dim dr As DataRow = dt.NewRow()
        dr("Record_ID") = 0
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
            dr("Record_ID") = 0
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


    Protected Sub btnQuery_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Dim strWhereClause As String = ""
        Dim clsReportParms As New AssetReportParms

        Dim gvr As GridViewRow = Me.gvLookupTable.Rows(Me.gvLookupTable.Rows.Count - 1)
        Dim txtTagValue As TextBox = CType(gvr.FindControl("TagValue"), TextBox)

        Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
        If Not String.IsNullOrEmpty(txtTagValue.Text) Then
            mstr.ShowErrorMessage("The last criterion appears to have a non blank value in the Tag Value field.  Please click Accept Changes for this criterion to include it or Cancel to ignore it.")
            Exit Sub
        End If

        'testing code
        'strWhereClause = "where tagnumber = '123'"
        'strWhereClause = "where tagnumber like 'EQ100%'"

        strWhereClause = "where 1 = 1 "

        Try
            Dim dt As DataTable = Session("AdjustmentsDataTable")
            Dim a As String = ""
            If dt.Rows.Count > 0 Then
                For Each dr As DataRow In dt.Rows
                    If Not String.IsNullOrEmpty(dr("tagvalue").ToString()) Then
                        Dim arrTableData As String() = dr("tagname").ToString.Split("|")
                        If dr("operation") = "=" Then
                            strWhereClause = strWhereClause & " and (tagnameid = " & arrTableData(0) & " and " & arrTableData(1) & " " & dr("operation") & " '" & dr("tagvalue") & "') "
                        Else
                            strWhereClause = strWhereClause & " and (tagnameid = " & arrTableData(0) & " and " & arrTableData(1) & " " & dr("operation") & " '%" & dr("tagvalue") & "%') "
                        End If
                    End If
                Next
            Else
                mstr.ShowErrorMessage("Please enter a least one search criterion for the report.")

            End If
        Catch ex As Exception

        End Try



        clsReportParms.WhereClause = strWhereClause
        Session("ReportParms") = clsReportParms
        Response.Redirect("AssetSearchReport.aspx")


    End Sub
End Class

