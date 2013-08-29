Imports System.Data.Odbc

Partial Class TransactionHistoryReport
    Inherits System.Web.UI.Page
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim rpt As New ReportTransactionHistory
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString

        If Page.IsPostBack = False Then
            Me.pnlReport.Visible = False
            'these need to be loaded programmatically in order to force the Databind early (so that we can set defaults in the DataBound)
            Me.UserNames.DataSourceID = "sqldsUsers"
            Me.UserNames.DataBind()
            Me.ddlCaseID.DataSourceID = "sqldsCase"
            Me.ddlCaseID.DataBind()
            Me.txtFromDate.Text = DateAdd(DateInterval.Day, -30, Today()).ToShortDateString
            Me.txtEndDate.Text = DateAdd(DateInterval.Day, -1, Today()).ToShortDateString
        Else
            Me.hfdFirstTime.Value = Me.hfdFirstTime.Value + 1
           
        End If

        Dim fromDate As Date
        Dim toDate As Date
        If Not Date.TryParse(Me.txtFromDate.Text, fromDate) Then
            fromDate = DateAdd(DateInterval.Day, -30, Date.Now())
        End If
        If Not Date.TryParse(Me.txtEndDate.Text, toDate) Then
            toDate = Date.Now()
        End If


        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@startdate").Value = fromDate.Year.ToString() + " " + fromDate.Month.ToString() + " " + fromDate.Day.ToString() + " 00:00"
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@enddate").Value = toDate.Year.ToString() + " " + toDate.Month.ToString() + " " + toDate.Day.ToString() + " 23:59"
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@username").Value = Me.UserNames.SelectedValue
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@caseid").Value = Me.ddlCaseID.SelectedValue

        If Me.rblTagNumberSortOrder.SelectedValue = "Desc" Then
            CType(rpt.Bands("groupHeaderBand1"), DevExpress.XtraReports.UI.GroupHeaderBand).GroupFields("CaseNumber").SortOrder = DevExpress.XtraReports.UI.XRColumnSortOrder.Descending
        Else
            CType(rpt.Bands("groupHeaderBand1"), DevExpress.XtraReports.UI.GroupHeaderBand).GroupFields("CaseNumber").SortOrder = DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending
        End If

        Me.rptvwrOrders.Report = rpt

    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click

        Response.Redirect("Default.aspx")

    End Sub

    Protected Sub btnRunReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRunReport.Click

        Me.pnlReport.Visible = True

    End Sub
    Protected Sub JobID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserNames.SelectedIndexChanged
        If Me.hfdFirstTime.Value > 1 Then
            Me.pnlReport.Visible = False
        Else
            Me.pnlReport.Visible = True
        End If
    End Sub

End Class
