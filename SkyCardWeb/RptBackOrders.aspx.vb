Imports System.Data.Odbc

Partial Class RptBackOrders
    Inherits System.Web.UI.Page
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim rpt As New ReportBackOrders
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString

        If Page.IsPostBack = False Then
            Me.pnlReport.Visible = False
            'these need to be loaded programmatically in order to force the Databind early (so that we can set defaults in the DataBound)
            Me.JobID.DataSourceID = "sqldsJoblist"
            Me.JobID.DataBind()
            Me.ddlStatus.DataSourceID = "sqldsOrderStatusList"
            Me.ddlStatus.DataBind()

            Me.txtStartDate.Text = Today.AddDays(-1).ToShortDateString
            Me.txtEndDate.Text = Today.ToShortDateString

        Else
            Me.hfdFirstTime.Value = Me.hfdFirstTime.Value + 1
        End If

        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@JobID").Value = Me.JobID.SelectedValue
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@StartDate").Value = IIf(String.IsNullOrEmpty(Me.txtStartDate.Text), Nothing, CType(Me.txtStartDate.Text.ToString + " 00:00:00", DateTime))
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@EndDate").Value = IIf(String.IsNullOrEmpty(Me.txtEndDate.Text), Nothing, CType(Me.txtEndDate.Text.ToString + " 23:59:58", DateTime))
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@Status").Value = IIf(String.IsNullOrEmpty(Me.ddlStatus.SelectedValue), Nothing, Trim(Me.ddlStatus.SelectedValue))

        Me.rptvwrBackOrders.Report = rpt


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
    Protected Sub JobID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles JobID.SelectedIndexChanged
        If Me.hfdFirstTime.Value > 1 Then
            Me.pnlReport.Visible = False
        Else
            Me.pnlReport.Visible = True
        End If
    End Sub

    Protected Sub ddlStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlStatus.SelectedIndexChanged
        If Me.hfdFirstTime.Value > 1 Then
            Me.pnlReport.Visible = False
        Else
            Me.pnlReport.Visible = True
        End If

    End Sub
End Class
