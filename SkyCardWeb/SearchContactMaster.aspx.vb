
Partial Class SearchContactMaster
    Inherits System.Web.UI.Page
    Private arrControlBaseNames As String() = {"ContactName", "City", "State", "Zip", "Email1", "ContactAlias"}
    Private intRowIndex As Integer
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
                            Case 2
                                Me.txtContactName.Text = arrlstSearchCriteria(iCounter)
                            Case 3
                                Me.txtContactAlias.Text = arrlstSearchCriteria(iCounter)
                                ' Case 4
                                '    Me.ddlContactState.SelectedValue = arrlstSearchCriteria(iCounter)
                                ' Case 5
                                '   Me.txtContactZipCode.Text = arrlstSearchCriteria(iCounter)
                                '  Case 6
                                '  Me.txtContactEmail.Text = arrlstSearchCriteria(iCounter)
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
            Me.GVTitle.Visible = False
            Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
            mstr.ShowErrorMessage(strErrorMsg)
            Exit Sub
        End If

        Me.gvSearchRecs.Visible = True
        Me.gvSearchRecs.DataSourceID = "sqldsItemSearch"
        Me.gvSearchRecs.DataBind()
        Me.GVTitle.Visible = True

        If Me.hfdTotalRecords.Value.Length > 0 Then
            ComputePageCountSettings(Me.hfdTotalRecords.Value)
        End If
        'ComputePageCountSettings(1)

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

    Protected Sub gvSearchRecs_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvSearchRecs.SelectedIndexChanged
        Session("CommentTable") = "ContactMaster"
        Session("CommentID") = CType(sender, GridView).SelectedDataKey.Value

        Dim arrlstSearchCriteria As ArrayList = New ArrayList()
        arrlstSearchCriteria.Add(False)
        arrlstSearchCriteria.Add("SearchContactMaster.aspx")
        arrlstSearchCriteria.Add(Me.txtContactName.Text)
        arrlstSearchCriteria.Add(Me.txtContactAlias.Text)
        'arrlstSearchCriteria.Add(Me.ddlContactState.SelectedValue)
        'arrlstSearchCriteria.Add(Me.txtContactZipCode.Text)
        'arrlstSearchCriteria.Add(Me.txtContactEmail.Text)
        Session("SearchCriteria") = arrlstSearchCriteria

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
        Dim strContactID As String = Me.gvSearchRecs.DataKeys(e.NewEditIndex).Value.ToString
        Session("ContactID") = strContactID

        Dim arrlstSearchCriteria As ArrayList = New ArrayList()
        arrlstSearchCriteria.Add(False)
        arrlstSearchCriteria.Add("SearchContactMaster.aspx")
        arrlstSearchCriteria.Add(Me.txtContactName.Text)
        arrlstSearchCriteria.Add(Me.txtContactAlias.Text)
        'arrlstSearchCriteria.Add(Me.ddlContactState.SelectedValue)
        ' arrlstSearchCriteria.Add(Me.txtContactZipCode.Text)
        'arrlstSearchCriteria.Add(Me.txtContactEmail.Text)
        Session("SearchCriteria") = arrlstSearchCriteria

        Response.Redirect("ContactEdit.aspx")

    End Sub

    Protected Sub gvSearchRecs_PageIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvSearchRecs.PageIndexChanged
        ComputePageCountSettings(Me.hfdTotalRecords.Value)
    End Sub


    Protected Sub sqldsItemSearch_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsItemSearch.Selected
        Me.hfdTotalRecords.Value = e.AffectedRows
    End Sub

    Protected Sub sqldsItemSearch_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsItemSearch.Selecting
        Dim strContactName As String = Nothing
        Dim strContactAlias As String = Nothing
        'Dim strContactState As String = Nothing
        'Dim strContactZipCode As String = Nothing
        'Dim strContactEmail As String = Nothing

        If Not String.IsNullOrEmpty(Me.txtContactName.Text) Then
            strContactName = Me.txtContactName.Text
        Else
            strContactName = ""
        End If

        If Not String.IsNullOrEmpty(Me.txtContactAlias.Text) Then
            strContactAlias = Me.txtContactAlias.Text
        Else
            strContactAlias = ""
        End If

        'If Not String.IsNullOrEmpty(Me.ddlContactState.SelectedValue) Then
        '    strContactState = Me.ddlContactState.SelectedValue
        'End If

        'If Not String.IsNullOrEmpty(Me.txtContactZipCode.Text) Then
        '    strContactZipCode = Me.txtContactZipCode.Text
        'End If

        'If Not String.IsNullOrEmpty(Me.txtContactEmail.Text) Then
        '    strContactEmail = Me.txtContactEmail.Text
        'End If

        ' e.Command.Parameters("@ContactName").Value = strContactName
        ' e.Command.Parameters("@City").Value = strContactCity
        'e.Command.Parameters("@State").Value = strContactState
        ' e.Command.Parameters("@Zip").Value = strContactZipCode
        ' e.Command.Parameters("@Email1").Value = strContactEmail

        e.Command.Parameters("@ContactName").Value = strContactName
        e.Command.Parameters("@AliasName").Value = strContactAlias

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
        Dim intContactID As Integer = Me.gvSearchRecs.DataKeys(intRowIndex).Value

        e.Command.Parameters("ID").Value = intContactID
        e.Command.Parameters("UserID").Value = Session("LoginID")

    End Sub

    Protected Sub sqldsItemSearch_Deleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsItemSearch.Deleting
        e.Cancel = True
    End Sub


    Protected Sub btnAddItem_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAddItem.Click

        Dim arrlstSearchCriteria As ArrayList = New ArrayList()
        arrlstSearchCriteria.Add(False)
        arrlstSearchCriteria.Add("SearchContactMaster.aspx")
        arrlstSearchCriteria.Add(Me.txtContactName.Text)
        arrlstSearchCriteria.Add(Me.txtContactAlias.Text)
        ' arrlstSearchCriteria.Add(Me.ddlContactState.SelectedValue)
        ' arrlstSearchCriteria.Add(Me.txtContactZipCode.Text)
        'arrlstSearchCriteria.Add(Me.txtContactEmail.Text)
        Session("SearchCriteria") = arrlstSearchCriteria

        Response.Redirect("ContactAdd.aspx")
    End Sub
End Class
