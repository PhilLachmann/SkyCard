
Partial Class CaseSearch
    Inherits System.Web.UI.Page
    Private arrControlBaseNames As String() = {"ClaimNumber", "ClaimantFirstName", "ClaimantLastName", "Comments", "Street1", "City", "StatusID", "ClaimTypeID", "DateOfLossStart", "DateOfLossEnd", "DateInsRecvNoticeClaimStart", "DateInsRecvNoticeClaimEnd"}

    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("ClaimID") = Nothing

        Dim mstr As GMechMaster = Me.Master

        If Page.IsPostBack = False Then
            Me.GVTitle.Visible = False
        Else
            mstr.RemoveErrorMessage()
        End If

    End Sub

    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ClearGridview()

        If EditSearchCriteria() = False Then
            Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
            mstr.ShowErrorMessage("Please enter some criteria to search by.")
            Exit Sub
        End If

        Me.gvSearchResults.Visible = True
        Me.gvSearchResults.DataSourceID = "sqldsSearch"
        Me.gvSearchResults.DataBind()
        Me.GVTitle.Visible = True

        ComputePageCountSettings(Me.hfdTotalRecords.Value)

    End Sub
    Protected Sub ClearGridview()

        Me.gvSearchResults.Visible = False
        Me.gvSearchResults.PageIndex = 0

    End Sub

    Protected Function EditSearchCriteria() As Boolean
        Dim bolRetValue As Boolean = True

        'place to code some criteria edits

        Return bolRetValue
    End Function

    Protected Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearGridview()
        Me.GVTitle.Visible = False

        Me.tbCaseNum.Text = ""
        Me.tbDefName.Text = ""

    End Sub

    Private Sub ComputePageCountSettings(ByVal intTotalRows As Integer)
        'Dim intTotalRows As Integer = 50
        Dim intGVRowDisplayCount As Integer = Me.gvSearchResults.PageSize
        Dim intPageCount As Integer = 0
        Dim intPageOn As Integer = 0
        Dim intRecCount As Integer = 0
        Dim intRecOnMin As Integer = 0
        Dim intRecOnMax As Integer = 0
        Dim intRemainder As Integer = 0

        'compute the page count
        If intTotalRows > 0 Then
            intPageOn = Me.gvSearchResults.PageIndex + 1
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

    Protected Sub gvSearchResults_PageIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvSearchResults.PageIndexChanged
        ComputePageCountSettings(Me.hfdTotalRecords.Value)
    End Sub

    Protected Sub gvSearchResults_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvSearchResults.RowDataBound
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

    Protected Sub gvSearchResults_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles gvSearchResults.RowEditing
        Dim intClaimID As String = Me.gvSearchResults.DataKeys(e.NewEditIndex).Value

        Session("CaseID") = intClaimID
        Response.Redirect("CaseEdit.aspx")

    End Sub

    Protected Sub sqldsSearch_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsSearch.Selected
        Me.hfdTotalRecords.Value = e.AffectedRows
    End Sub

    Protected Sub sqldsSearch_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsSearch.Selecting
        e.Command.Parameters("@CaseNumber").Value = tbCaseNum.Text
        e.Command.Parameters("@Defendant").Value = tbDefName.Text


    End Sub

    
End Class
