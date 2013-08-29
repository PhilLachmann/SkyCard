
Partial Class SearchProduct
    Inherits System.Web.UI.Page
    Private arrControlBaseNames As String() = {"ItemID", "ItemDesc", "Barcode", "Size"}

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

            Me.PriceCategory.DataSourceID = "sqldsCategoryLookup"
            Me.PriceCategory.DataBind()

            'Me.Size.DataSourceID = "sqldsSizeLookup"
            'Me.Size.DataBind()

            If Session("SearchCriteria") IsNot Nothing Then
                'this page is being called from another page, restore the search options last seen
                Dim arrlstProductSrchCriteria As ArrayList = Session("SearchCriteria")

                If arrlstProductSrchCriteria(0) = True Then
                    For iCounter As Integer = 0 To arrlstProductSrchCriteria.Count - 1
                        Select Case iCounter
                            Case 1
                                Me.txtItemID.Text = arrlstProductSrchCriteria(iCounter)
                            Case 2
                                Me.txtItemDesc.Text = arrlstProductSrchCriteria(iCounter)
                            Case 3
                                Me.txtBarcode.Text = arrlstProductSrchCriteria(iCounter)
                            Case 4
                                Me.PriceCategory.SelectedValue = arrlstProductSrchCriteria(iCounter)
                            Case 5
                                'Me.Size.SelectedValue = arrlstProductSrchCriteria(iCounter)
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

        Session("ItemID") = Nothing

    End Sub


    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ClearGridview()

        If EditSearchCriteria() = False Then
            Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
            mstr.ShowErrorMessage("The Criteria entered is invalid.")
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


        Return bolRetValue
    End Function

    Protected Sub btnClearCriteria_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClearCriteria.Click
        ClearGridview()
        Me.GVTitle.Visible = False

        Dim arrlstControls As ArrayList = New ArrayList(arrControlBaseNames)
        For Each cntlname As String In arrlstControls
            Dim strTextBoxName As String = "txt" & cntlname
            Dim strCheckBoxName As String = "cbx" & cntlname

            Dim txtbx As TextBox = CType(Me.Form.FindControl("cphBody").FindControl(strTextBoxName), TextBox)
            Dim chkbx As CheckBox = CType(Me.Form.FindControl("cphBody").FindControl(strCheckBoxName), CheckBox)

            If Not txtbx Is Nothing Then
                txtbx.Text = ""
            End If
            If Not chkbx Is Nothing Then
                chkbx.Checked = False
            End If

        Next

        Me.PriceCategory.SelectedValue = ""
        Me.txtSize.Text = ""

    End Sub

    Private Sub ComputePageCountSettings(ByVal intTotalRows As Integer)
        'Dim intTotalRows As Integer = 50
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

    'End Sub
    Protected Sub gvSearchRecs_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvSearchRecs.SelectedIndexChanged
        Session("CommentTableName") = "Product"
        Session("CommentTableKeyID") = CType(sender, GridView).SelectedDataKey.Value

        Dim arrlstProductSrchCriteria As ArrayList = New ArrayList()
        arrlstProductSrchCriteria.Add(False)
        arrlstProductSrchCriteria.Add(Me.txtItemID.Text)
        arrlstProductSrchCriteria.Add(Me.txtItemDesc.Text)
        arrlstProductSrchCriteria.Add(Me.txtBarcode.Text)
        arrlstProductSrchCriteria.Add(Me.PriceCategory.SelectedValue.ToString)
        arrlstProductSrchCriteria.Add(Me.txtSize.Text)
        Session("SearchCriteria") = arrlstProductSrchCriteria

        Response.Redirect("CommentMaint.aspx")

    End Sub


    Protected Sub gvSearchRecs_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvSearchRecs.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            For Each tcell As TableCell In e.Row.Cells
                If tcell.HasControls = True Then
                    For Each tcntl As Control In tcell.Controls
                        If tcntl.ID = "EditButton" Then
                            Dim btn As Button = CType(tcntl, Button)
                            btn.Attributes.Add("onclick", "javascript:this.style.cursor = 'wait';waitCursor();")
                        End If
                    Next
                End If
            Next
        End If

    End Sub

    Protected Sub gvSearchRecs_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles gvSearchRecs.RowEditing
        Dim strItemID As String = Me.gvSearchRecs.DataKeys(e.NewEditIndex).Value
        Session("ItemID") = strItemID

        Dim arrlstProductSrchCriteria As ArrayList = New ArrayList()
        arrlstProductSrchCriteria.Add(False)
        arrlstProductSrchCriteria.Add(Me.txtItemID.Text)
        arrlstProductSrchCriteria.Add(Me.txtItemDesc.Text)
        arrlstProductSrchCriteria.Add(Me.txtBarcode.Text)
        arrlstProductSrchCriteria.Add(Me.PriceCategory.SelectedValue.ToString)
        arrlstProductSrchCriteria.Add(Me.txtSize.Text)
        Session("SearchCriteria") = arrlstProductSrchCriteria

        Response.Redirect("ProductEdit.aspx")

    End Sub

    Protected Sub gvSearchRecs_PageIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvSearchRecs.PageIndexChanged
        ComputePageCountSettings(Me.hfdTotalRecords.Value)
    End Sub

    Protected Sub sqldsInventorySearch_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsItemSearch.Selected
        Me.hfdTotalRecords.Value = e.AffectedRows
    End Sub

    Protected Sub sqldsInventorySearch_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsItemSearch.Selecting
        Dim strItemId As String = Me.txtItemID.Text & "%"
        Dim strItemDesc As String = Me.txtItemDesc.Text & "%"
        Dim strItemBarcode As String = Me.txtBarcode.Text & "%"
        Dim strCategory As String = Me.PriceCategory.SelectedValue.ToString & "%"
        Dim strSize As String = Me.txtSize.Text & "%"

        If strItemId <> "%" Then
            strItemId = "%" & strItemId
        End If

        If strItemDesc <> "%" Then
            strItemDesc = "%" & strItemDesc
        End If

        If strItemBarcode <> "%" Then
            strItemBarcode = "%" & strItemBarcode
        End If

        If strCategory <> "%" Then
            strCategory = "%" & strCategory
        End If

        If strSize <> "%" Then
            strSize = strSize.Replace("%", "")
        End If

        e.Command.Parameters("ItemID").Value = strItemId
        e.Command.Parameters("ItemDesc").Value = strItemDesc
        e.Command.Parameters("Barcode").Value = strItemBarcode
        e.Command.Parameters("CategoryID").Value = strCategory
        e.Command.Parameters("Size").Value = strSize

    End Sub

    Protected Sub gvSearchRecs_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvSearchRecs.RowCommand
        Dim a As String = ""

        If e.CommandName = "Report" Then
            Dim strItemID As String = e.CommandArgument.ToString()
            Session("ItemID") = strItemID

            Dim arrlstProductSrchCriteria As ArrayList = New ArrayList()
            arrlstProductSrchCriteria.Add(False)
            arrlstProductSrchCriteria.Add(Me.txtItemID.Text)
            arrlstProductSrchCriteria.Add(Me.txtItemDesc.Text)
            arrlstProductSrchCriteria.Add(Me.txtBarcode.Text)
            arrlstProductSrchCriteria.Add(Me.PriceCategory.SelectedValue.ToString)
            arrlstProductSrchCriteria.Add(Me.txtSize.Text)
            Session("SearchCriteria") = arrlstProductSrchCriteria

            Response.Redirect("RptVendorHistory.aspx")

        End If

    End Sub

End Class
