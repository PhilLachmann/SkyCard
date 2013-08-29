Imports System.Data.Odbc

Partial Class MinMaxReportByPartNumber
    Inherits System.Web.UI.Page
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Page.IsPostBack = False Then
            Dim strAutoRunRptType As String = Request.Params("rptType")
            If String.IsNullOrEmpty(strAutoRunRptType) Then
                Me.pnlReport.Visible = False
            Else
                'called from alerts page
                Me.ddlReportType.SelectedValue = strAutoRunRptType
                btnRunReport_Click(Me.btnRunReport, New EventArgs())
            End If
            'Me.pnlReport.Visible = False
        Else
            Me.hfdFirstTime.Value = Me.hfdFirstTime.Value + 1
        End If



    End Sub


    Protected Sub btnRunReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRunReport.Click

        'This always checks the rptType parm.  If it is present, it will run the rpt with that parm.  if it is not present
        'it will redirect back to this page with that parm set.
        'This was needed so that when a user links from this rpt to the Edit asset screen THEN clicks the browser back button
        'they see the report they left.  Otherwise they were seeing a blank report.
        Dim strAutoRunRptType As String = Request.Params("rptType")
        If (String.IsNullOrEmpty(strAutoRunRptType)) Or (strAutoRunRptType <> Me.ddlReportType.SelectedValue.ToString) Then
            Response.Redirect("MinMaxReportByPartNumber.aspx?rptType=" & Me.ddlReportType.SelectedValue.ToString)
        Else
            Me.pnlReport.Visible = True

            Dim rpt As New ReportMinMaxByPartNumber
            CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString

            CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@ReportType").Value = Me.ddlReportType.SelectedValue
            rpt.Parameters("ReportTypeString").Value = Me.ddlReportType.SelectedItem.ToString()

            Me.rptvwrOrders.Report = rpt
        End If


    End Sub



End Class
