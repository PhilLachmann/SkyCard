
Partial Class SearchEditAuctionItems
    Inherits System.Web.UI.Page
    Private arrControlBaseNames As String() = {"TagNumber", "DateStart", "DateEnd"}
    Private intRowIndex As Integer
    Private parmAssetAuctionID As Integer
    Private parmCEOMinValue As Decimal
    Private strErrorMsg As String = ""

    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)

        If Page.IsPostBack = False Then
            Me.GVTitle.Visible = False

            If Session("SearchCriteria") IsNot Nothing Then
                'this page is being called from another page, restore the search options last seen
                Dim arrlstSearchCriteria As ArrayList = Session("SearchCriteria")

                If arrlstSearchCriteria(0) = True Then
                    For iCounter As Integer = 0 To arrlstSearchCriteria.Count - 1
                        Select Case iCounter
                            Case 1
                                Me.txtTagNumber.Text = arrlstSearchCriteria(iCounter)
                            Case 2
                                Me.txtDateStart.Text = arrlstSearchCriteria(iCounter)
                            Case 3
                                Me.txtDateEnd.Text = arrlstSearchCriteria(iCounter)
                        End Select
                    Next

                    Session("SearchCriteria") = Nothing

                    'trigger a search
                    Me.btnSearch_Click(sender, e)

                Else
                    Session("SearchCriteria") = Nothing
                End If

            End If

        Else
            mstr.RemoveErrorMessage()
        End If

    End Sub


    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ClearGridview()

        If EditSearchCriteria() = False Then
            Me.GVTitle.Visible = False
            Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
            mstr.ShowErrorMessage(strErrorMsg)
            Exit Sub
        End If

        Me.gvSearchRecs.Visible = True
        Me.gvSearchRecs.DataSourceID = "sqldsItemSearch"
        Me.gvSearchRecs.DataBind()
        Me.GVTitle.Visible = True

        ComputePageCountSettings(Me.hfdTotalRecords.Value)

    End Sub

    Protected Sub ClearGridview()

        Me.gvSearchRecs.Visible = False
        Me.gvSearchRecs.PageIndex = 0

    End Sub
    Protected Function EditSearchCriteria() As Boolean
        Dim bolRetValue As Boolean = True

        If Not String.IsNullOrEmpty(Me.txtDateStart.Text) And String.IsNullOrEmpty(Me.txtDateEnd.Text) Then
            strErrorMsg = "You must supply both a Begin and End Date to search by Date range."
            bolRetValue = False
        End If

        If String.IsNullOrEmpty(Me.txtDateStart.Text) And Not String.IsNullOrEmpty(Me.txtDateEnd.Text) Then
            strErrorMsg = "You must supply both a Begin and End Date to search by Date range."
            bolRetValue = False
        End If

        Return bolRetValue
    End Function

    Protected Sub btnClearCriteria_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClearCriteria.Click
        ClearGridview()
        Me.GVTitle.Visible = False

        Dim arrlstControls As ArrayList = New ArrayList(arrControlBaseNames)
        For Each cntlname As String In arrlstControls
            Dim strTextBoxName As String = "txt" & cntlname
            Dim strCheckBoxName As String = "cbx" & cntlname
            Dim strDropDownName As String = "ddl" & cntlname

            Dim txtbx As TextBox = CType(Me.Form.FindControl("cphBody").FindControl(strTextBoxName), TextBox)
            Dim chkbx As CheckBox = CType(Me.Form.FindControl("cphBody").FindControl(strCheckBoxName), CheckBox)
            Dim ddlbx As DropDownList = CType(Me.Form.FindControl("cphBody").FindControl(strDropDownName), DropDownList)

            If Not txtbx Is Nothing Then
                txtbx.Text = ""
            End If
            If Not chkbx Is Nothing Then
                chkbx.Checked = False
            End If
            If Not ddlbx Is Nothing Then
                ddlbx.SelectedValue = ""
            End If

        Next

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

    Protected Sub sqldsItemSearch_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsItemSearch.Selected
        Me.hfdTotalRecords.Value = e.AffectedRows
    End Sub

    Protected Sub sqldsItemSearch_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsItemSearch.Selecting
        Dim strTagNumber As String = Nothing
        Dim dtmDateStart As DateTime = Nothing
        Dim dtmDateEnd As DateTime = Nothing

        If Not String.IsNullOrEmpty(Me.txtTagNumber.Text) Then
            strTagNumber = Me.txtTagNumber.Text
        End If

        If String.IsNullOrEmpty(Me.txtDateStart.Text) Then
            dtmDateStart = DateTime.MinValue
        Else
            dtmDateStart = Me.txtDateStart.Text & " 00:00:00"
        End If

        If String.IsNullOrEmpty(Me.txtDateEnd.Text) Then
            dtmDateEnd = DateTime.MaxValue
        Else
            dtmDateEnd = Me.txtDateEnd.Text & " 23:59:59"
        End If

        e.Command.Parameters("theTagNumber").Value = strTagNumber
        e.Command.Parameters("DateRangeStart").Value = dtmDateStart
        e.Command.Parameters("DateRangeEnd").Value = dtmDateEnd

    End Sub

    Protected Sub gvSearchRecs_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvSearchRecs.DataBound
        If Me.gvSearchRecs.Rows.Count > 0 Then
            If Session("SecurityRole") <> "superadmin" Then
                Me.gvSearchRecs.ShowFooter = False
            End If
        End If
    End Sub

    Protected Sub gvSearchRecs_PageIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvSearchRecs.PageIndexChanged
        ComputePageCountSettings(Me.hfdTotalRecords.Value)
    End Sub

    Protected Sub gvSearchRecs_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvSearchRecs.RowDataBound
        If Session("SecurityRole") <> "superadmin" Then
            If e.Row.RowType = DataControlRowType.DataRow Then
                For Each tcell As TableCell In e.Row.Cells
                    If tcell.HasControls = True Then
                        For Each tcntl As Control In tcell.Controls
                            If tcntl.ID = "CEOMinBidValue" Then
                                Dim txt As TextBox = CType(tcntl, TextBox)
                                txt.ReadOnly = True
                                If Not String.IsNullOrEmpty(txt.Text) Then
                                    txt.Text = "************"
                                End If
                            End If

                            If tcntl.ID = "ftbxCEOMinBidValue" Then
                                Dim ftbx As AjaxControlToolkit.FilteredTextBoxExtender = CType(tcntl, AjaxControlToolkit.FilteredTextBoxExtender)
                                ftbx.Enabled = False
                            End If


                        Next
                    End If
                Next
            End If
        End If

    End Sub

    Protected Sub gvSearchRecs_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles gvSearchRecs.RowEditing
        Dim strAssetAuctionID As String = Me.gvSearchRecs.DataKeys(e.NewEditIndex).Value.ToString
        Session("AssetAuctionID") = strAssetAuctionID

        Dim arrlstSearchCriteria As ArrayList = New ArrayList()
        arrlstSearchCriteria.Add(False)
        arrlstSearchCriteria.Add(Me.txtTagNumber.Text)
        arrlstSearchCriteria.Add(Me.txtDateStart.Text)
        arrlstSearchCriteria.Add(Me.txtDateEnd.Text)
        Session("SearchCriteria") = arrlstSearchCriteria

        Response.Redirect("AuctionItemEdit.aspx")

    End Sub

    Protected Sub gvSearchRecs_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvSearchRecs.RowCommand
        Select Case e.CommandName
            Case "Delete"
                intRowIndex = CType(e.CommandArgument, Integer) + (Me.gvSearchRecs.PageSize * Me.gvSearchRecs.PageIndex)
                Me.sqldsItemSearch.Update()
                Me.gvSearchRecs.DataBind()
                ComputePageCountSettings(Me.hfdTotalRecords.Value)
        End Select

    End Sub

    Protected Sub sqldsItemSearch_Updating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsItemSearch.Updating
        Dim strAssetAuctionID As Integer = Me.gvSearchRecs.DataKeys(intRowIndex).Value

        e.Command.Parameters("AssetAuctionID").Value = strAssetAuctionID

    End Sub

    Protected Sub sqldsItemSearch_Deleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsItemSearch.Deleting
        e.Cancel = True
    End Sub

    Protected Sub sqldsItemSearch_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsItemSearch.Inserting
        e.Command.Parameters("AssetAuctionID").Value = parmAssetAuctionID
        e.Command.Parameters("CEOMinBidvalue").Value = parmCEOMinValue
    End Sub

    Protected Sub btnSaveChanges_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If EditCEOMinValues() = False Then
            Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
            mstr.ShowErrorMessage(strErrorMsg)
            Exit Sub
        End If

        For Each gvr As GridViewRow In Me.gvSearchRecs.Rows
            parmAssetAuctionID = Me.gvSearchRecs.DataKeys(gvr.RowIndex).Value
            Dim txt As TextBox = CType(gvr.FindControl("CEOMinBidValue"), TextBox)
            parmCEOMinValue = IIf(String.IsNullOrEmpty(txt.Text), 0, txt.Text)
            sqldsItemSearch.Insert()
        Next

        Me.gvSearchRecs.DataSourceID = "sqldsItemSearch"
        Me.gvSearchRecs.DataBind()
        Me.GVTitle.Visible = True

        ComputePageCountSettings(Me.hfdTotalRecords.Value)

    End Sub

    Protected Function EditCEOMinValues() As Boolean
        Dim bolRetValue As Boolean = True

        For Each gvr As GridViewRow In Me.gvSearchRecs.Rows
            Dim lbl As Label = CType(gvr.FindControl("BuyNowPrice"), Label)
            Dim lblMin As Label = CType(gvr.FindControl("MinBidValue"), Label)
            Dim txt As TextBox = CType(gvr.FindControl("CEOMinBidValue"), TextBox)
            If Not String.IsNullOrEmpty(txt.Text) And Not IsNumeric(txt.Text) Then
                strErrorMsg = "CEO Minimum values must be numeric."
                bolRetValue = False
                Exit For
            End If
            If Not String.IsNullOrEmpty(txt.Text) Then
                Dim decCEOamt As Decimal = IIf(String.IsNullOrEmpty(txt.Text), 0, txt.Text)
                Dim decBuyNow As Decimal = CType(lbl.Text, Decimal)
                Dim decMinBid As Decimal = CType(lblMin.Text, Decimal)
                If decCEOamt > decBuyNow Then
                    strErrorMsg = "The CEO Minimum value cannot be greater than the Buy Now Price."
                    bolRetValue = False
                    Exit For
                End If
                If decMinBid > decCEOamt Then
                    strErrorMsg = "The CEO Minimum value must be greater than the Minimum Bid Value."
                    bolRetValue = False
                    Exit For
                End If
            End If

        Next

        Return bolRetValue
    End Function


End Class
