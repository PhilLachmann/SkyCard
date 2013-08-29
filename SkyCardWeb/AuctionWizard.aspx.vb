Imports System.Data

Partial Class AuctionWizard
    Inherits System.Web.UI.Page

    Private theTagDesc As String = ""
    Private theWhereClause As String = ""
    Private theLocationID As Integer = 0
    Private objAssetAuctionToFind As AssetForAuction = Nothing
    Private drListing As DataRow = Nothing

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)

        If Page.IsPostBack = False Then
            Me.GVTitle.Visible = False
            InitializeGridview()
            Session("SelectedAssetsDataTable") = Nothing
            Session("SelectedAssets") = Nothing
        Else
            mstr.RemoveErrorMessage()

        End If

    End Sub

    Protected Sub InitializeGridview()

        Dim dv As DataView = CType(Me.sqldsSearchSchema.Select(DataSourceSelectArguments.Empty), DataView)

        Dim dt As DataTable = dv.ToTable

        lvQuery.DataSource = dt
        lvQuery.DataBind()

        Session("CriteriaDataTable") = dt

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

    Protected Sub btnAddRow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddRow.Click
        'need to save here
        SaveAdjustmentGridviewToDataTable()

        Dim dt As DataTable = Session("CriteriaDataTable")

        Dim dr As DataRow = dt.NewRow()
        dr("Record_ID") = dt.Rows.Count
        dr("tagname") = "Description"
        dr("operation") = "Equals"
        dr("tagvalue") = "A"
        dt.Rows.Add(dr)

        lvQuery.DataSource = dt
        lvQuery.DataBind()

        Session("CriteriaDataTable") = dt

    End Sub

    Protected Function SaveAdjustmentGridviewToDataTable() As Boolean
        Dim bolRetVal As Boolean = True

        Dim dt As DataTable = Session("CriteriaDataTable")
        Dim iCounter As Integer = 0

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

        Session("CriteriaDataTable") = dt

        Return bolRetVal

    End Function

    Protected Sub QueryAssets() 'As DataTable
        'first need to save contol values into the session data table
        SaveAdjustmentGridviewToDataTable()
        ConvertDataTable()

        Dim strWhereClause As String = ""
        Dim clsReportParms As New AssetReportParms

        strWhereClause = "where 1 = 1 and deleted='N' "

        Try
            Dim dt As DataTable = Session("CriteriaDataTable")
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


        'set the parm values
        Me.theWhereClause = strWhereClause
        Me.theLocationID = Me.BuildingID.SelectedValue

        Dim arrlstCriteria As ArrayList = New ArrayList
        arrlstCriteria.Add(theWhereClause)
        arrlstCriteria.Add(theLocationID)
        Session("SelectCriteria") = arrlstCriteria


    End Sub

    Private Sub ConvertDataTable()
        Try
            Dim dt As DataTable = Session("CriteriaDataTable")
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

        Return s
    End Function

    Protected Sub wizAddAuctionListings_NextButtonClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.WizardNavigationEventArgs) Handles wizAddAuctionListings.NextButtonClick
        Select Case Me.wizAddAuctionListings.ActiveStepIndex
            Case 0
                'Show results of search
                ClearGridview()

                'Dim dt As DataTable = QueryAssets()
                QueryAssets()
                Me.gvSearchRecs.Visible = True
                Me.gvSearchRecs.DataSourceID = "sqldsSearchAssets"
                Me.gvSearchRecs.DataBind()
                Me.GVTitle.Visible = True

                ComputePageCountSettings(Me.hfdTotalRecords.Value)

                'Dim arrlstSelectedAssets As ArrayList = New ArrayList()
                Dim arrlstSelectedAssets As List(Of AssetForAuction) = New List(Of AssetForAuction)
                Session("SelectedAssets") = arrlstSelectedAssets
            Case 1
                'save the last page's selections into the session arraylist
                'Dim arrlstSelectedAssets As ArrayList = Session("SelectedAssets")
                Dim arrlstSelectedAssets As List(Of AssetForAuction) = Session("SelectedAssets")
                For Each gvr As GridViewRow In Me.gvSearchRecs.Rows
                    Dim cbx As CheckBox = CType(gvr.FindControl("cbxSelect"), CheckBox)
                    Dim objSearched As AssetForAuction = New AssetForAuction()
                    objSearched.TagNumber = Server.HtmlDecode(gvr.Cells(2).Text)
                    objSearched.Description = Server.HtmlDecode(gvr.Cells(3).Text)
                    objAssetAuctionToFind = objSearched
                    If cbx.Checked = True Then
                        'Dim fndIndex As Integer = arrlstSelectedAssets.IndexOf(objSearched)
                        Dim fndIndex As Integer = arrlstSelectedAssets.FindIndex(AddressOf FindTagNumber)
                        If fndIndex > -1 Then
                            'its checked and in the list, no need to add/remove
                        Else
                            'its checked and not in list, add it
                            arrlstSelectedAssets.Add(objSearched)
                        End If
                    Else
                        'Dim fndIndex As Integer = arrlstSelectedAssets.IndexOf(objSearched)
                        Dim fndIndex As Integer = arrlstSelectedAssets.FindIndex(AddressOf FindTagNumber)
                        If fndIndex > -1 Then
                            'its not checked and in the list, remove it
                            arrlstSelectedAssets.RemoveAt(fndIndex)
                        Else
                            'its not checked and not in list, no need to add/remove
                        End If
                    End If
                Next

                Session("SelectedAssets") = arrlstSelectedAssets

                'edit for entries
                If arrlstSelectedAssets.Count < 1 Then
                    Dim mstr As GMechMaster = Me.Page.Master
                    mstr.ShowErrorMessage("Please select at least one item for auction.")
                    e.Cancel = True
                End If

                'initialize SelectedAssetsDataTable
                Dim dv As DataView = CType(Me.sqldsAssetAuction.Select(DataSourceSelectArguments.Empty), DataView)
                Dim dt As DataTable = dv.ToTable
                Dim keys(1) As DataColumn
                Dim pkdc As DataColumn = dt.Columns("TagNumber")
                keys(0) = pkdc
                dt.PrimaryKey = keys

                'add a row for each selected asset
                For Each itm As AssetForAuction In arrlstSelectedAssets
                    Dim dr As DataRow = dt.NewRow
                    dr("TagNumber") = itm.TagNumber
                    dr("Subtitle") = itm.Description
                    dt.Rows.Add(dr)
                Next
                Me.hfdTotalRecordsAuction.Value = dt.Rows.Count

                'show list of selected assets
                Session("SelectedAssetsDataTable") = dt
                Me.gvAuctionRecords.DataSource = dt
                Me.gvAuctionRecords.DataBind()

                ComputePageCountSettingsAuction(Me.hfdTotalRecordsAuction.Value)

            Case 2
                Dim dt As DataTable = Session("SelectedAssetsDataTable")

                'save off the data in GV to dt
                Dim arrlstErrors As ArrayList = SaveAuctionItemData(Me.gvAuctionRecords, dt)
                Session("SelectedAssetsDataTable") = dt

                If arrlstErrors.Count > 0 Then
                    Dim strErrorTagNos As String = ""
                    For Each itm As String In arrlstErrors
                        strErrorTagNos = strErrorTagNos & itm & ", "
                    Next
                    strErrorTagNos = strErrorTagNos.Substring(0, strErrorTagNos.Length - 2)
                    Dim mstr As GMechMaster = Me.Page.Master
                    mstr.ShowErrorMessage("Please enter Title, Subtitle, Buy Now Price and Minimum Bid Value for each of the following TagNumbers: " & strErrorTagNos & ".")
                    e.Cancel = True
                End If

                'edit for buyitnow/minbidval relation
                Dim arrlstErrors2 As ArrayList = EditMinBidValues(dt)
                If arrlstErrors2.Count > 0 Then
                    Dim strErrorTagNos As String = ""
                    For Each itm As String In arrlstErrors2
                        strErrorTagNos = strErrorTagNos & itm & ", "
                    Next
                    strErrorTagNos = strErrorTagNos.Substring(0, strErrorTagNos.Length - 2)
                    Dim mstr As GMechMaster = Me.Page.Master
                    mstr.ShowErrorMessage("Please ensure that Buy Now Price is greater than Minimum Bid Value, and that both are numeric values, for each of the following TagNumbers: " & strErrorTagNos & ".")
                    e.Cancel = True
                End If


                'Present Auction general settings
                InitAuctionSettings()
            Case 3
                Dim dt As DataTable = Session("SelectedAssetsDataTable")

                'edit for auction settings
                Dim ddlRegion As DropDownList = Me.fvAuction.Row.FindControl("RegionID")
                Dim ddlCategory As DropDownList = Me.fvAuction.Row.FindControl("CategoryID")
                Dim ddlCurrencyCode As DropDownList = Me.fvAuction.Row.FindControl("CurrencyCode")
                Dim txtStartDate As TextBox = Me.fvAuction.Row.FindControl("StartDate")
                Dim txtDuration As TextBox = Me.fvAuction.Row.FindControl("Duration")

                If String.IsNullOrEmpty(ddlRegion.SelectedValue) Or String.IsNullOrEmpty(ddlCategory.SelectedValue) Or String.IsNullOrEmpty(ddlCurrencyCode.SelectedValue) Or String.IsNullOrEmpty(txtStartDate.Text) Or String.IsNullOrEmpty(txtDuration.Text) Then
                    Dim mstr As GMechMaster = Me.Page.Master
                    mstr.ShowErrorMessage("Please enter or select values for Region, Category, Currency, Start Date and Duration of the auction.")
                    e.Cancel = True
                    Exit Select
                End If


                'save off the data in FV to dt
                SaveAuctionSettings(Me.fvAuction, dt)
                Session("SelectedAssetsDataTable") = dt
                Me.hfdTotalRecordsConfirm.Value = dt.Rows.Count

                'confirmation
                Me.gvAuctionConfirm.DataSource = dt
                Me.gvAuctionConfirm.DataBind()

                ComputePageCountSettingsConfirm(Me.hfdTotalRecordsConfirm.Value)




        End Select

    End Sub

    Protected Sub wizAddAuctionListings_PreviousButtonClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.WizardNavigationEventArgs) Handles wizAddAuctionListings.PreviousButtonClick
        Select Case Me.wizAddAuctionListings.ActiveStepIndex
            Case 1
                Session("SelectedAssets") = Nothing
            Case 2
                Session("SelectedAssetsDataTable") = Nothing
        End Select

    End Sub

    Protected Sub wizAddAuctionListings_FinishButtonClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.WizardNavigationEventArgs) Handles wizAddAuctionListings.FinishButtonClick
        Dim dt As DataTable = Session("SelectedAssetsDataTable")

        For Each dr As DataRow In dt.Rows
            drListing = dr
            Me.sqldsAssetAuctionUpdates.Insert()
        Next

        Dim txtStartDate As TextBox = Me.fvAuction.Row.FindControl("StartDate")

        Dim arrlstSearchCriteria As ArrayList = New ArrayList()
        arrlstSearchCriteria.Add(True)
        arrlstSearchCriteria.Add("")
        arrlstSearchCriteria.Add(txtStartDate.Text)
        arrlstSearchCriteria.Add(txtStartDate.Text)
        Session("SearchCriteria") = arrlstSearchCriteria

        'Dim arrlstSearchCriteria As ArrayList = Session("SearchCriteria")
        'arrlstSearchCriteria(0) = True
        'Session("SearchCriteria") = arrlstSearchCriteria

        Response.Redirect("SearchEditAuctionItems.aspx")

        'Response.Redirect("Default.aspx")

    End Sub

    Protected Sub sqldsSearchAssets_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsSearchAssets.Selected
        Me.hfdTotalRecords.Value = e.AffectedRows
    End Sub

    Protected Sub sqldsSearchAssets_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsSearchAssets.Selecting
        Dim arrlstCriteria As ArrayList = Session("SelectCriteria")

        e.Command.Parameters("thewhereclause").Value = arrlstCriteria(0)
        e.Command.Parameters("thelocationID").Value = arrlstCriteria(1)
    End Sub

    Protected Sub ClearGridview()
        Me.gvSearchRecs.Visible = False
        Me.gvSearchRecs.PageIndex = 0
    End Sub

    Private Sub ComputePageCountSettings(ByVal intTotalRows As Integer)
        Dim intGVRowDisplayCount As Integer = Me.gvSearchRecs.PageSize
        Dim intPageCount As Integer = 0
        Dim intPageOn As Integer = 0
        Dim intRecCount As Integer = 0
        Dim intRecOnMin As Integer = 0
        Dim intRecOnMax As Integer = 0
        Dim intRemainder As Integer = 0

        'compute the page count
        If intTotalRows > 0 Then
            intPageOn = Me.gvSearchRecs.PageIndex + 1
            intRemainder = intTotalRows Mod intGVRowDisplayCount
            If intRemainder = 0 Then
                intPageCount = intTotalRows \ intGVRowDisplayCount
            Else
                intPageCount = (intTotalRows \ intGVRowDisplayCount) + 1
            End If
        Else
            intPageOn = 0
            intPageCount = 0
        End If

        'compute the record count
        If intTotalRows > 0 Then
            intRecOnMin = intGVRowDisplayCount * (intPageOn - 1) + 1
            intRecOnMax = intGVRowDisplayCount * intPageOn
            intRecCount = intTotalRows
            If intRecOnMax > intRecCount Then
                intRecOnMax = intRecCount
            End If
        Else
            intRecOnMin = 0
            intRecOnMax = 0
            intRecCount = 0
        End If

        'set the text
        Me.lblPageCount.Text = "Page " & intPageOn.ToString & " of " & intPageCount.ToString
        Me.lblRecordCount.Text = "Records (" & intRecOnMin.ToString & " to " & intRecOnMax.ToString & ") of " & intRecCount.ToString

    End Sub


    Protected Sub gvSearchRecs_PageIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvSearchRecs.PageIndexChanged
        'Dim arrlstSelectedAssets As ArrayList = Session("SelectedAssets")
        Dim arrlstSelectedAssets As List(Of AssetForAuction) = Session("SelectedAssets")

        For Each gvr As GridViewRow In Me.gvSearchRecs.Rows
            Dim cbx As CheckBox = CType(gvr.FindControl("cbxSelect"), CheckBox)
            Dim objSearched As AssetForAuction = New AssetForAuction()
            objSearched.TagNumber = Server.HtmlDecode(gvr.Cells(2).Text)
            objSearched.Description = Server.HtmlDecode(gvr.Cells(3).Text)
            objAssetAuctionToFind = objSearched
            If cbx.Checked = True Then
                'Dim fndIndex As Integer = arrlstSelectedAssets.IndexOf(objSearched)
                Dim fndIndex As Integer = arrlstSelectedAssets.FindIndex(AddressOf FindTagNumber)
                If fndIndex > -1 Then
                    'its checked and in the list, no need to add/remove
                Else
                    'its checked and not in list, add it
                    arrlstSelectedAssets.Add(objSearched)
                End If
            Else
                'Dim fndIndex As Integer = arrlstSelectedAssets.IndexOf(objSearched)
                Dim fndIndex As Integer = arrlstSelectedAssets.FindIndex(AddressOf FindTagNumber)
                If fndIndex > -1 Then
                    'its not checked and in the list, remove it
                    arrlstSelectedAssets.RemoveAt(fndIndex)
                Else
                    'its not checked and not in list, no need to add/remove
                End If
            End If
        Next

        Session("SelectedAssets") = arrlstSelectedAssets

        ComputePageCountSettings(Me.hfdTotalRecords.Value)
    End Sub

    Protected Sub gvSearchRecs_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvSearchRecs.RowDataBound
        'Dim arrlstSelectedAssets As ArrayList = Session("SelectedAssets")
        Dim arrlstSelectedAssets As List(Of AssetForAuction) = Session("SelectedAssets")
        If arrlstSelectedAssets IsNot Nothing Then
            If arrlstSelectedAssets.Count > 0 Then
                If (e.Row.RowType = DataControlRowType.DataRow) Then
                    Dim objSearched As AssetForAuction = New AssetForAuction()
                    objSearched.TagNumber = Server.HtmlDecode(e.Row.Cells(2).Text)
                    objSearched.Description = Server.HtmlDecode(e.Row.Cells(3).Text)
                    objAssetAuctionToFind = objSearched
                    'Dim fndIndex As Integer = arrlstSelectedAssets.IndexOf(objSearched)
                    Dim fndIndex As Integer = arrlstSelectedAssets.FindIndex(AddressOf FindTagNumber)
                    If fndIndex > -1 Then
                        'check the corresponding checkbox
                        Dim cbx As CheckBox = CType(e.Row.FindControl("cbxSelect"), CheckBox)
                        cbx.Checked = True
                    End If
                End If
            End If

        End If


        If (e.Row.RowType = DataControlRowType.DataRow) Then
            Dim img As Image = e.Row.FindControl("AssetPhoto")
            If img IsNot Nothing Then
                img.Attributes.Add("onmouseover", "javascript:showFullPhoto(this);")
                img.Attributes.Add("onmouseout", "javascript:showSmallPhoto(this);")
            End If
        End If



    End Sub

    Private Sub ComputePageCountSettingsAuction(ByVal intTotalRows As Integer)
        Dim intGVRowDisplayCount As Integer = Me.gvAuctionRecords.PageSize
        Dim intPageCount As Integer = 0
        Dim intPageOn As Integer = 0
        Dim intRecCount As Integer = 0
        Dim intRecOnMin As Integer = 0
        Dim intRecOnMax As Integer = 0
        Dim intRemainder As Integer = 0

        'compute the page count
        If intTotalRows > 0 Then
            intPageOn = Me.gvAuctionRecords.PageIndex + 1
            intRemainder = intTotalRows Mod intGVRowDisplayCount
            If intRemainder = 0 Then
                intPageCount = intTotalRows \ intGVRowDisplayCount
            Else
                intPageCount = (intTotalRows \ intGVRowDisplayCount) + 1
            End If
        Else
            intPageOn = 0
            intPageCount = 0
        End If

        'compute the record count
        If intTotalRows > 0 Then
            intRecOnMin = intGVRowDisplayCount * (intPageOn - 1) + 1
            intRecOnMax = intGVRowDisplayCount * intPageOn
            intRecCount = intTotalRows
            If intRecOnMax > intRecCount Then
                intRecOnMax = intRecCount
            End If
        Else
            intRecOnMin = 0
            intRecOnMax = 0
            intRecCount = 0
        End If

        'set the text
        Me.lblPageCountAuction.Text = "Page " & intPageOn.ToString & " of " & intPageCount.ToString
        Me.lblRecordCountAuction.Text = "Records (" & intRecOnMin.ToString & " to " & intRecOnMax.ToString & ") of " & intRecCount.ToString

    End Sub

    Protected Sub gvAuctionRecords_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvAuctionRecords.PageIndexChanging
        Dim dt As DataTable = Session("SelectedAssetsDataTable")

        'save off the data in GV to dt
        Dim arrlstErrors As ArrayList = SaveAuctionItemData(Me.gvAuctionRecords, dt)
        Session("SelectedAssetsDataTable") = dt

        If arrlstErrors.Count > 0 Then
            Dim strErrorTagNos As String = ""
            For Each itm As String In arrlstErrors
                strErrorTagNos = strErrorTagNos & itm & ", "
            Next
            strErrorTagNos = strErrorTagNos.Substring(0, strErrorTagNos.Length - 2)
            Dim mstr As GMechMaster = Me.Page.Master
            mstr.ShowErrorMessage("Please enter Title, Subtitle, Buy Now Price and Minimum Bid Value for each of the following TagNumbers: " & strErrorTagNos & ".")
            e.Cancel = True
        Else
            gvAuctionRecords.PageIndex = e.NewPageIndex
            gvAuctionRecords.DataSource = dt
            gvAuctionRecords.DataBind()
            ComputePageCountSettingsAuction(Me.hfdTotalRecordsAuction.Value)
        End If

    End Sub

    Protected Sub gvAuctionRecords_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvAuctionRecords.RowDataBound
        If (e.Row.RowType = DataControlRowType.DataRow) Then
            Dim img As Image = e.Row.FindControl("AssetPhoto")
            If img IsNot Nothing Then
                img.Attributes.Add("onmouseover", "javascript:showFullPhoto(this);")
                img.Attributes.Add("onmouseout", "javascript:showSmallPhoto(this);")
            End If
        End If
    End Sub

    Private Function FindTagNumber(ByVal XassetForAuction As AssetForAuction) As Boolean
        If XassetForAuction.TagNumber = objAssetAuctionToFind.TagNumber Then
            Return True
        Else
            Return False
        End If
    End Function

    Protected Sub InitAuctionSettings()
        Me.fvAuction.DataSourceID = "sqldsAuctionSettings"
        Me.fvAuction.DataBind()

        Me.fvAuction.ChangeMode(FormViewMode.Insert)

    End Sub

    Protected Function SaveAuctionItemData(ByVal gv As GridView, ByRef dt As DataTable) As ArrayList

        Dim arrlstErrors As ArrayList = New ArrayList()
        Dim i As Integer = 0
        For Each gvr As GridViewRow In gv.Rows
            Dim a As String = ""
            Dim txtTitle As TextBox = CType(gvr.FindControl("Title"), TextBox)
            Dim txtSubtitle As TextBox = CType(gvr.FindControl("Subtitle"), TextBox)
            Dim txtBuyNowPrice As TextBox = CType(gvr.FindControl("BuyNowPrice"), TextBox)
            Dim txtMinBidValue As TextBox = CType(gvr.FindControl("MinBidValue"), TextBox)

            If String.IsNullOrEmpty(txtTitle.Text) Or String.IsNullOrEmpty(txtSubtitle.Text) Or String.IsNullOrEmpty(txtBuyNowPrice.Text) Or String.IsNullOrEmpty(txtMinBidValue.Text) Then
                arrlstErrors.Add(gv.DataKeys(i).Value)
            Else
                Dim dr As DataRow = dt.Rows.Find(gv.DataKeys(i).Value)
                dr("Title") = txtTitle.Text
                dr("Subtitle") = txtSubtitle.Text
                dr("BuyNowPrice") = txtBuyNowPrice.Text
                dr("MinBidValue") = txtMinBidValue.Text
            End If

            i = i + 1
        Next

        Return arrlstErrors

    End Function

    Protected Sub SaveAuctionSettings(ByVal fv As FormView, ByRef dt As DataTable)

        Dim fvr As FormViewRow = fv.Row
        Dim ddlRegion As DropDownList = fvr.FindControl("RegionID")
        Dim ddlCategory As DropDownList = fvr.FindControl("CategoryID")
        Dim ddlCurrencyCode As DropDownList = fvr.FindControl("CurrencyCode")
        Dim txtStartDate As TextBox = fvr.FindControl("StartDate")
        Dim txtDuration As TextBox = fvr.FindControl("Duration")

        For Each dr As DataRow In dt.Rows
            dr("RegionID") = ddlRegion.SelectedValue
            dr("CategoryID") = ddlCategory.SelectedValue
            dr("CurrencyCode") = ddlCurrencyCode.SelectedValue
            dr("AuctionStartDate") = txtStartDate.Text
            dr("AuctionDuration") = txtDuration.Text
        Next

    End Sub

    Private Sub ComputePageCountSettingsConfirm(ByVal intTotalRows As Integer)
        Dim intGVRowDisplayCount As Integer = Me.gvAuctionConfirm.PageSize
        Dim intPageCount As Integer = 0
        Dim intPageOn As Integer = 0
        Dim intRecCount As Integer = 0
        Dim intRecOnMin As Integer = 0
        Dim intRecOnMax As Integer = 0
        Dim intRemainder As Integer = 0

        'compute the page count
        If intTotalRows > 0 Then
            intPageOn = Me.gvAuctionConfirm.PageIndex + 1
            intRemainder = intTotalRows Mod intGVRowDisplayCount
            If intRemainder = 0 Then
                intPageCount = intTotalRows \ intGVRowDisplayCount
            Else
                intPageCount = (intTotalRows \ intGVRowDisplayCount) + 1
            End If
        Else
            intPageOn = 0
            intPageCount = 0
        End If

        'compute the record count
        If intTotalRows > 0 Then
            intRecOnMin = intGVRowDisplayCount * (intPageOn - 1) + 1
            intRecOnMax = intGVRowDisplayCount * intPageOn
            intRecCount = intTotalRows
            If intRecOnMax > intRecCount Then
                intRecOnMax = intRecCount
            End If
        Else
            intRecOnMin = 0
            intRecOnMax = 0
            intRecCount = 0
        End If

        'set the text
        Me.lblPageCountConfirm.Text = "Page " & intPageOn.ToString & " of " & intPageCount.ToString
        Me.lblRecordCountConfirm.Text = "Records (" & intRecOnMin.ToString & " to " & intRecOnMax.ToString & ") of " & intRecCount.ToString

    End Sub

    Protected Sub fvAuction_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles fvAuction.PreRender
        Dim ddlCurrency As DropDownList = Me.fvAuction.Row.FindControl("CurrencyCode")
        ddlCurrency.SelectedValue = "USD"

        Dim txtStartDate As TextBox = Me.fvAuction.Row.FindControl("StartDate")
        txtStartDate.Text = Today.ToShortDateString
    End Sub

    Protected Sub gvAuctionConfirm_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvAuctionConfirm.PageIndexChanging
        Dim dt As DataTable = Session("SelectedAssetsDataTable")

        gvAuctionConfirm.PageIndex = e.NewPageIndex
        gvAuctionConfirm.DataSource = dt
        gvAuctionConfirm.DataBind()
        ComputePageCountSettingsConfirm(Me.hfdTotalRecordsConfirm.Value)
    End Sub

    Protected Sub sqldsAssetAuctionUpdates_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsAssetAuctionUpdates.Inserting
        e.Command.Parameters("TagNumber").Value = drListing("TagNumber")
        e.Command.Parameters("RegionID").Value = drListing("RegionID")
        e.Command.Parameters("CategoryID").Value = drListing("CategoryID")
        e.Command.Parameters("Title").Value = drListing("Title")
        e.Command.Parameters("Subtitle").Value = drListing("Subtitle")
        e.Command.Parameters("ListingType").Value = "Auction"
        e.Command.Parameters("CurrencyCode").Value = drListing("CurrencyCode")
        e.Command.Parameters("BuyNowPrice").Value = drListing("BuyNowPrice")
        e.Command.Parameters("MinBidValue").Value = drListing("MinBidValue")
        e.Command.Parameters("AuctionStartDate").Value = drListing("AuctionStartDate")
        e.Command.Parameters("AuctionDuration").Value = drListing("AuctionDuration")
    End Sub

    Protected Function EditMinBidValues(ByRef dt As DataTable) As ArrayList

        Dim arrlstErrors As ArrayList = New ArrayList()
        For Each dr As DataRow In dt.Rows
            If Not IsNumeric(dr("BuyNowPrice")) Or Not IsNumeric(dr("MinBidValue")) Then
                arrlstErrors.Add(dr("TagNumber"))
            Else
                If CType(dr("MinBidValue"), Decimal) >= CType(dr("BuyNowPrice"), Decimal) Then
                    arrlstErrors.Add(dr("TagNumber"))
                End If

            End If

        Next

        Return arrlstErrors

    End Function

End Class
