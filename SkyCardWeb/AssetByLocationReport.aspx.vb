Imports System.Data.Odbc

Partial Class AssetByLocationReport
    Inherits System.Web.UI.Page
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim rpt As New ReportAssetByLocation
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString

        If Page.IsPostBack = False Then
            Me.pnlReport.Visible = False
            'these need to be loaded programmatically in order to force the Databind early (so that we can set defaults in the DataBound)
            Me.BuildingID.DataSourceID = "sqldsBuildings"
            Me.BuildingID.DataBind()
            Me.LocationID.DataSourceID = "sqldsLocations"
            Me.LocationID.DataBind()

        Else
            Me.hfdFirstTime.Value = Me.hfdFirstTime.Value + 1
        End If

        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("theLocationID").Value = IIf(Me.LocationID.SelectedValue = 0, Me.BuildingID.SelectedValue, Me.LocationID.SelectedValue)

        Me.rptvwrOrders.Report = rpt

    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click

        Response.Redirect("Default.aspx")

    End Sub

    Protected Sub btnRunReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRunReport.Click

        Me.pnlReport.Visible = True

    End Sub
    Protected Sub LocationID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LocationID.SelectedIndexChanged
        If Me.hfdFirstTime.Value > 1 Then
            Me.pnlReport.Visible = False
        Else
            Me.pnlReport.Visible = True
        End If
    End Sub

    Protected Sub BuildingID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BuildingID.SelectedIndexChanged

        If Me.hfdFirstTime.Value > 1 Then
            Me.pnlReport.Visible = False
        Else
            Me.pnlReport.Visible = True
        End If

        Me.LocationID.Items.Clear()
        Dim itm As ListItem = New ListItem("All", "0")
        Me.LocationID.Items.Add(itm)
        Me.LocationID.DataBind()

    End Sub

    Protected Sub sqldsLocations_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsLocations.Selecting
        Dim a As String = ""

        If e.Command.Parameters("theRoot").Value = 0 Then
            e.Command.Parameters("theRoot").Value = -1
        End If
    End Sub
End Class
