Imports System.Data.Odbc

Partial Class ReportBase
    Inherits System.Web.UI.Page
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Dim arrlstJobSrchCriteria As ArrayList = Session("SearchCriteria")
        arrlstJobSrchCriteria(0) = True
        Session("SearchCriteria") = arrlstJobSrchCriteria

        Response.Redirect("SearchJob.aspx")

    End Sub

End Class
