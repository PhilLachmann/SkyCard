Imports System.Data



Partial Class AssetSearchPhoto
    Inherits System.Web.UI.Page
    Private drAsParm As DataRow = Nothing
    Private intAdjustmentsInserted As Integer = 0
    Private intAdjustmentsSent As Integer = 0
    Private strErrMsgText As String = ""
    Private storeSelected As Boolean = False
    Private headerID As Integer

    Private theTagDesc As String = ""

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
        'dr("tagvalue") = "test 123"
        'dt.Rows.Add(dr)

        lvQuery.DataSource = dt
        lvQuery.DataBind()

        Session("AdjustmentsDataTable") = dt

    End Sub





    Protected Function SaveAdjustmentGridviewToDataTable() As Boolean
        Dim bolRetVal As Boolean = True

        Dim dt As DataTable = Session("AdjustmentsDataTable")
        Dim iCounter As Integer = 0

        'save the header info here


        'walk through the gridview saving the info in the datatable
        For Each gvr As ListViewDataItem In Me.lvQuery.Items


            If String.IsNullOrEmpty(CType(gvr.FindControl("Tagvalue"), TextBox).Text) Then
                'skip it

            Else
                'its a new row, show edited with a valid system guid
                dt.Rows(iCounter)("Record_ID") = dt.Rows.Count + 1
                dt.Rows(iCounter)("Tagname") = CType(gvr.FindControl("Tagname"), DropDownList).SelectedValue
                dt.Rows(iCounter)("TagValue") = CType(gvr.FindControl("TagValue"), TextBox).Text
                dt.Rows(iCounter)("Operation") = CType(gvr.FindControl("Operation"), DropDownList).SelectedValue
                iCounter = iCounter + 1
            End If

        Next

        Session("AdjustmentsDataTable") = dt

        Return bolRetVal

    End Function



    Private Sub ConvertDataTable()
        Try
            Dim dt As DataTable = Session("AdjustmentsDataTable")
            Dim a As String = ""
            If dt.Rows.Count > 0 Then
                For Each dr As DataRow In dt.Rows
                    dr.BeginEdit()
                    Dim oldval As String = dr("tagname")
                    Dim newval As String = GetReplacementValue(oldval)
                    dr("tagname") = newval
                    dr.EndEdit()
                Next


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function GetReplacementValue(ByVal originalValue As String) As String
        'call the select
        Dim s As String = ""
        theTagDesc = originalValue
        Dim dv2 As DataView = CType(Me.sqldsTagByDescription.Select(DataSourceSelectArguments.Empty), DataView)
        Dim dt2 As DataTable = dv2.ToTable

        If dt2.Rows.Count > 0 Then
            Dim dr2 As DataRow = dt2.Rows(0)

            Try
                s = dr2("tagnamevalue")
            Catch ex As Exception
                s = ""
            End Try

        Else
            s = ""
        End If


        'set the hidden field
        Return s
    End Function


    Protected Sub btnQuery_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        'first need to save contol values into the session data table
        SaveAdjustmentGridviewToDataTable()
        ConvertDataTable()

        Dim strWhereClause As String = ""
        Dim clsReportParms As New AssetReportParms


        ''testing code
        ''strWhereClause = "where tagnumber = '123'"
        ''strWhereClause = "where tagnumber like 'EQ100%'"

        strWhereClause = "where 1 = 1 and deleted='N' "

        Try
            Dim dt As DataTable = Session("AdjustmentsDataTable")
            Dim a As String = ""
            If dt.Rows.Count > 0 Then
                For Each dr As DataRow In dt.Rows
                    If Not String.IsNullOrEmpty(dr("tagvalue").ToString()) Then
                        Dim arrTableData As String() = dr("tagname").ToString.Split("|")
                        If dr("operation") = "Equals" Then
                            If arrTableData(1) = "All" Then
                                strWhereClause = strWhereClause & " and ((TV_varchar like '" & dr("tagvalue") & "%')" & " or (TV_integer like '" & dr("tagvalue") & "%')" & " or (TV_decimal like '" & dr("tagvalue") & "%'))"
                            Else
                                strWhereClause = strWhereClause & " and (tagnameid = " & arrTableData(0) & " and " & arrTableData(1) & " Like" & " '" & dr("tagvalue") & "%') "
                            End If

                        Else
                            If arrTableData(1) = "All" Then
                                strWhereClause = strWhereClause & " and ((TV_varchar like '%" & dr("tagvalue") & "%')" & " or (TV_integer like '%" & dr("tagvalue") & "%')" & " or (TV_decimal like '%" & dr("tagvalue") & "%'))"
                            Else
                                strWhereClause = strWhereClause & " and (tagnameid = " & arrTableData(0) & " and " & arrTableData(1) & " " & "Like" & " '%" & dr("tagvalue") & "%') "
                            End If
                        End If
                    End If
                Next
            Else
                'mstr.ShowErrorMessage("Please enter a least one search criterion for the report.")

            End If
        Catch ex As Exception

        End Try


        Session("PhotoSearchWhereClause") = strWhereClause
        Session("PhotoSearchBuildingLocID") = Me.BuildingID.SelectedValue

        Response.Redirect("AssetSearchPhotoDisplay.aspx")


    End Sub

    Protected Sub btnAddRow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddRow.Click
        'need to save here
        SaveAdjustmentGridviewToDataTable()



        Dim dt As DataTable = Session("AdjustmentsDataTable")

        Dim dr As DataRow = dt.NewRow()
        dr("Record_ID") = dt.Rows.Count
        dr("tagname") = "Description"
        dr("operation") = "Equals"
        dr("tagvalue") = "A"
        dt.Rows.Add(dr)

        lvQuery.DataSource = dt
        lvQuery.DataBind()

        Session("AdjustmentsDataTable") = dt
    End Sub


    Protected Sub lstOperation_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ddlOperation As System.Web.UI.WebControls.DropDownList = DirectCast(sender, System.Web.UI.WebControls.DropDownList)
        Dim theOpp As String = ddlOperation.SelectedValue

        Dim ddlTagName As DropDownList = ddlOperation.Parent.FindControl("tagname")
        Dim theTag As String = ddlTagName.SelectedValue

        Dim ddlAlphabet As DropDownList = ddlTagName.Parent.FindControl("ddlAlphabet")
        Dim txtTagValue As TextBox = ddlTagName.Parent.FindControl("TagValue")
        If theOpp = "Equals" Then
            ddlAlphabet.Visible = True
            txtTagValue.Visible = False
            txtTagValue.Text = "A"
            ddlAlphabet.SelectedValue = "A"
        Else
            ddlAlphabet.Visible = False
            txtTagValue.Visible = True
            txtTagValue.Text = ""
        End If
    End Sub

    Protected Sub lstTagname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim ddlTagName As System.Web.UI.WebControls.DropDownList = DirectCast(sender, System.Web.UI.WebControls.DropDownList)
        'Dim theTag As String = ddlTagName.SelectedValue

        'Dim ddlOperation As DropDownList = ddlTagName.Parent.FindControl("Operation")
        'Dim theOpp As String = ddlOperation.SelectedValue

        'Dim ddlAlphabet As DropDownList = ddlTagName.Parent.FindControl("ddlAlphabet")
        'Dim txtTagValue As TextBox = ddlTagName.Parent.FindControl("TagValue")
        'If theOpp = "Equals" And theTag = "All" Then
        '    ddlAlphabet.Visible = True
        '    txtTagValue.Visible = False
        'Else
        '    ddlAlphabet.Visible = False
        '    txtTagValue.Visible = True
        'End If
    End Sub

    Protected Sub lstAlphabet_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ddlAlphabet As System.Web.UI.WebControls.DropDownList = DirectCast(sender, System.Web.UI.WebControls.DropDownList)
        Dim theValue As String = ddlAlphabet.SelectedValue

        Dim txtTagValue As TextBox = ddlAlphabet.Parent.FindControl("TagValue")
        txtTagValue.Text = theValue
    End Sub

    Protected Sub lvQuery_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ListViewItemEventArgs) Handles lvQuery.ItemDataBound
        Dim ddlOperation As DropDownList = e.Item.FindControl("Operation")
        Dim ddlTagName As DropDownList = e.Item.FindControl("tagname")

        Dim ddlAlphabet As DropDownList = e.Item.FindControl("ddlAlphabet")
        Dim txtTagValue As TextBox = e.Item.FindControl("TagValue")

        If ddlOperation.Text = "Equals" Then
            ddlAlphabet.Visible = True
            txtTagValue.Visible = False
            'set the value in the drop down
            ddlAlphabet.SelectedValue = txtTagValue.Text
        Else
            ddlAlphabet.Visible = False
            txtTagValue.Visible = True
        End If

    End Sub

    Protected Sub sqldsTagByDescription_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsTagByDescription.Selecting
        e.Command.Parameters("TagDesc").Value = theTagDesc
    End Sub
End Class

