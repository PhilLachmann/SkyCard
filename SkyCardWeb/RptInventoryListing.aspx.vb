Imports System.Data.Odbc

Partial Class RptInventoryListing
    Inherits System.Web.UI.Page
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim rpt As New ReportInventoryListing
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString

        'If Page.IsPostBack = False Then
        Dim arrlstInvSrchCriteria As ArrayList = Session("SearchCriteria")
        For iCounter As Integer = 0 To arrlstInvSrchCriteria.Count - 1
            Select Case iCounter
                Case 1
                    CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@ItemID").Value = IIf(String.IsNullOrEmpty(arrlstInvSrchCriteria(iCounter)), "%", "%" & arrlstInvSrchCriteria(iCounter) & "%")
                Case 2
                    CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@ItemDesc").Value = IIf(String.IsNullOrEmpty(arrlstInvSrchCriteria(iCounter)), "%", "%" & arrlstInvSrchCriteria(iCounter) & "%")
                Case 3
                    CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@Barcode").Value = IIf(String.IsNullOrEmpty(arrlstInvSrchCriteria(iCounter)), "%", "%" & arrlstInvSrchCriteria(iCounter) & "%")
                Case 4
                    CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@JobID").Value = IIf(String.IsNullOrEmpty(arrlstInvSrchCriteria(iCounter)), "%", "%" & arrlstInvSrchCriteria(iCounter) & "%")
                Case 5
                    CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@LocationID").Value = IIf(String.IsNullOrEmpty(arrlstInvSrchCriteria(iCounter)), "%", "%" & arrlstInvSrchCriteria(iCounter) & "%")
                Case 6
                    CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@CategoryID").Value = IIf(String.IsNullOrEmpty(arrlstInvSrchCriteria(iCounter)), "%", "%" & arrlstInvSrchCriteria(iCounter) & "%")
                Case 7
                    CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("@Size").Value = IIf(String.IsNullOrEmpty(arrlstInvSrchCriteria(iCounter)), "%", arrlstInvSrchCriteria(iCounter))
            End Select
        Next

        Me.rptvwrInvListing.Report = rpt

        'End If


    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Dim arrlstInvSrchCriteria As ArrayList = Session("SearchCriteria")
        arrlstInvSrchCriteria(0) = True
        Session("SearchCriteria") = arrlstInvSrchCriteria

        Response.Redirect("SearchInventory.aspx")

    End Sub
End Class
