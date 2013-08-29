Imports System.Data.Odbc

Partial Class RptMultiplierHistory
    Inherits System.Web.UI.Page
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim rpt As New ReportMultiplierHistory
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString

        If Page.IsPostBack = False Then
            'these need to be loaded programmatically in order to force the Databind early (so that we can set defaults in the DataBound)
            Me.PriceCategory.DataSourceID = "sqldsCategoryLookup"
            Me.PriceCategory.DataBind()
        Else
            Me.hfdFirstTime.Value = Me.hfdFirstTime.Value + 1
        End If

        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@CategoryID").Value = Me.PriceCategory.SelectedValue

        Me.rptvwrMultHist.Report = rpt

        btnRunReport_Click(sender, e)

    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click

        Response.Redirect("Default.aspx")

    End Sub
    Protected Sub btnRunReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRunReport.Click

        Me.pnlReport.Visible = True

    End Sub

    Protected Sub PriceCategory_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles PriceCategory.DataBound
        If Page.IsPostBack = False Then
            'set default values
            'Me.PriceCategory.SelectedValue = ConfigurationManager.AppSettings("OutofStockDefaultJobID")
            Me.hfdFirstTime.Value = Me.hfdFirstTime.Value + 1
        End If
    End Sub
    Protected Sub PriceCategory_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PriceCategory.SelectedIndexChanged
        If Me.hfdFirstTime.Value > 1 Then
            'Me.pnlReport.Visible = False
        Else
            Me.pnlReport.Visible = True
        End If
    End Sub

End Class
