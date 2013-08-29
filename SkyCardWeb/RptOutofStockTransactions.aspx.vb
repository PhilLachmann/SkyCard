Imports System.Data.Odbc

Partial Class RptOutofStockTransactions
    Inherits System.Web.UI.Page
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim rpt As New ReportOutofStockTransactions
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString

        If Page.IsPostBack = False Then
            'set default values
            Me.txtStartDate.Text = DateAdd(DateInterval.Day, -(Day(Today) - 1), Today).ToShortDateString
            Me.txtEndDate.Text = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, DateAdd(DateInterval.Day, -(Day(Today) - 1), Today))).ToShortDateString
        Else
            Me.hfdFirstTime.Value = Me.hfdFirstTime.Value + 1
        End If

        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@StartDate").Value = CType(Me.txtStartDate.Text.ToString + " 00:00:00", DateTime)
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@EndDate").Value = CType(Me.txtEndDate.Text.ToString + " 23:59:58", DateTime)
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@TransType").Value = Me.TransType.SelectedValue
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@JobID").Value = Me.JobID.SelectedValue

        Me.rptvwrOutStkTxns.Report = rpt



    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click

        Response.Redirect("Default.aspx")

    End Sub
    Protected Sub btnRunReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRunReport.Click

        Me.pnlReport.Visible = True

    End Sub
    Protected Sub txtStartDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStartDate.TextChanged
        If Me.hfdFirstTime.Value > 1 Then
            Me.pnlReport.Visible = False
        Else
            Me.pnlReport.Visible = True
        End If
    End Sub
    Protected Sub txtEndDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEndDate.TextChanged
        If Me.hfdFirstTime.Value > 1 Then
            Me.pnlReport.Visible = False
        Else
            Me.pnlReport.Visible = True
        End If
    End Sub

End Class
