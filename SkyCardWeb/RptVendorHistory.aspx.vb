Imports System.Data.Odbc

Partial Class RptVendorHistory
    Inherits System.Web.UI.Page
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim rpt As New ReportVendorHistory
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString

        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@TableKeyID").Value = Session("ItemID")
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@TableName").Value = "Product"

        Me.rptvwrVendorHistory.Report = rpt

    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Dim arrlstProductSrchCriteria As ArrayList = Session("SearchCriteria")
        arrlstProductSrchCriteria(0) = True
        Session("SearchCriteria") = arrlstProductSrchCriteria

        Response.Redirect("SearchProduct.aspx")

    End Sub

End Class
