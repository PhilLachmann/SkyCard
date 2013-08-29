Imports System.Data.Odbc

Partial Class RptLocationProduct
    Inherits System.Web.UI.Page
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim rpt As New ReportLocationProducts
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString

        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@LocationID").Value = Session("LocationID")
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@LocDesc").Value = "%"
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@LocBarcode").Value = "%"

        Me.rptvwrLocProducts.Report = rpt

    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Dim arrlstLocSrchCriteria As ArrayList = Session("SearchCriteria")
        arrlstLocSrchCriteria(0) = True
        Session("SearchCriteria") = arrlstLocSrchCriteria

        Response.Redirect("SearchLocation.aspx")

    End Sub

End Class
