Imports System.Data.Odbc
Imports System.Data.SqlClient

Partial Class RptOutofStockPricing
    Inherits System.Web.UI.Page
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        


        'pull values from session, assign to rptAdapter parms and run
        'Dim rpt As ReportSubpoena = Me.rptvwrReport.Report
        ' CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString

        'CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@RecordID").Value = Session("RecordID")





        Dim rpt As New ReportSubpoena
        CType(rpt.DataAdapter, SqlDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString

        

        CType(rpt.DataAdapter, SqlDataAdapter).SelectCommand.Parameters("@SubpoenaID").Value = Session("RecordID")
        
        Me.rptvwrReport.Report = rpt


    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click

        Response.Redirect("Default.aspx")

    End Sub
    

    

    

End Class
