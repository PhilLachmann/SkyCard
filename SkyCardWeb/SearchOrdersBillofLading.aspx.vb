
Partial Class SearchOrdersBillofLading
    Inherits System.Web.UI.Page
    'Private arrControlBaseNames As String() = {"ItemID", "ItemDesc", "Barcode"}

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
                Dim arrlstOrderSrchCriteria As ArrayList = Session("SearchCriteria")

                If arrlstOrderSrchCriteria(0) = True Then
                    For iCounter As Integer = 0 To arrlstOrderSrchCriteria.Count - 1
                        Select Case iCounter
                            Case 1
                                Me.txtStartDate.Text = arrlstOrderSrchCriteria(iCounter)
                            Case 2
                                Me.txtEndDate.Text = arrlstOrderSrchCriteria(iCounter)
                        End Select
                    Next

                    Session("SearchCriteria") = Nothing

                    'trigger a search
                    Me.btnSearch_Click(sender, e)

                Else
                    Session("SearchCriteria") = Nothing
                End If
            Else
                Me.txtStartDate.Text = Today.AddDays(-1).ToShortDateString
                Me.txtEndDate.Text = Today.ToShortDateString

                'trigger a search
                Me.btnSearch_Click(sender, e)
            End If

        Else
            Me.hfdFirstTime.Value = Me.hfdFirstTime.Value + 1
            mstr.RemoveErrorMessage()
        End If

        Session("OrderID") = Nothing

    End Sub


    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ClearGridview()

        If EditSearchCriteria() = False Then
            Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
            mstr.ShowErrorMessage("The Date Range entered is invalid.")
            Exit Sub
        End If

        Me.gvSearchRecs.Visible = True
        Me.gvSearchRecs.DataSourceID = "sqldsItemSearch"
        Me.gvSearchRecs.DataBind()
        Me.GVTitle.Visible = True
        Me.gvSearchRecs.Visible = True

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


    Protected Sub gvSearchRecs_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvSearchRecs.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            For Each tcell As TableCell In e.Row.Cells
                If tcell.HasControls = True Then
                    For Each tcntl As Control In tcell.Controls
                        If tcntl.ID = "btnShowReport" Then
                            Dim btn As ImageButton = CType(tcntl, ImageButton)
                            btn.Attributes.Add("onclick", "javascript:this.style.cursor = 'wait';waitCursor();")
                        End If
                    Next
                End If
            Next
        End If

    End Sub


    Protected Sub gvSearchRecs_PageIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvSearchRecs.PageIndexChanged
        ComputePageCountSettings(Me.hfdTotalRecords.Value)
    End Sub

    Protected Sub sqldsInventorySearch_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsItemSearch.Selected
        Me.hfdTotalRecords.Value = e.AffectedRows
    End Sub

    Protected Sub sqldsItemSearch_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsItemSearch.Selecting
        Dim strStartDate As String = Me.txtStartDate.Text
        Dim strEndDate As String = Me.txtEndDate.Text & " 23:59:58"

        e.Command.Parameters("StartDate").Value = strStartDate
        e.Command.Parameters("EndDate").Value = strEndDate

    End Sub

    Protected Sub gvSearchRecs_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvSearchRecs.RowCommand
        Dim a As String = ""

        If e.CommandName = "Report" Then
            Dim strOrderNumber As String = e.CommandArgument.ToString()
            Session("OrderNumber") = strOrderNumber

            Dim arrlstOrderSrchCriteria As ArrayList = New ArrayList()
            arrlstOrderSrchCriteria.Add(False)
            arrlstOrderSrchCriteria.Add(Me.txtStartDate.Text)
            arrlstOrderSrchCriteria.Add(Me.txtEndDate.Text)
            Session("SearchCriteria") = arrlstOrderSrchCriteria

            Response.Redirect("RptBillofLadingGmech.aspx")

        End If

    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Response.Redirect("Default.aspx")
    End Sub

    Protected Sub txtStartDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStartDate.TextChanged
        If Me.hfdFirstTime.Value > 1 Then
            Me.GVTitle.Visible = False
            Me.gvSearchRecs.Visible = False
        Else
            Me.GVTitle.Visible = True
            Me.gvSearchRecs.Visible = True
        End If
    End Sub

    Protected Sub txtEndDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEndDate.TextChanged
        If Me.hfdFirstTime.Value > 1 Then
            Me.GVTitle.Visible = False
            Me.gvSearchRecs.Visible = False
        Else
            Me.GVTitle.Visible = True
            Me.gvSearchRecs.Visible = True
        End If
    End Sub
End Class
