Imports System.Data.Odbc

Partial Class AssetByLocationFlexReport
    Inherits System.Web.UI.Page
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        'Dim rpt As New ReportAssetByLocation
        Dim rpt As New ReportAssetByLocationFlex
        Dim rpta As New ReportAssetByLocationFlex
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString
        CType(rpta.DataAdapter, OdbcDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString

        If Page.IsPostBack = False Then
            Me.pnlReport.Visible = False
            'these need to be loaded programmatically in order to force the Databind early (so that we can set defaults in the DataBound)
            Me.BuildingID.DataSourceID = "sqldsBuildings"
            Me.BuildingID.DataBind()
            Me.LocationID.DataSourceID = "sqldsLocations"
            Me.LocationID.DataBind()

        Else
            Me.hfdFirstTime.Value = Me.hfdFirstTime.Value + 1

            Dim body As HtmlGenericControl = CType(Me.Master.FindControl("body"), HtmlGenericControl)
            Dim pnl As Panel = CType(Me.pnlFullSize, Panel)
            Dim strpnlClientID As String = pnl.ClientID
            body.Attributes.Add("onLoad", "javascript:window.status = 'Ready';hideLargeViewers('" & strpnlClientID & "');")
        End If

        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("theLocationID").Value = IIf(Me.LocationID.SelectedValue = 0, Me.BuildingID.SelectedValue, Me.LocationID.SelectedValue)
        CType(rpta.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("theLocationID").Value = IIf(Me.LocationID.SelectedValue = 0, Me.BuildingID.SelectedValue, Me.LocationID.SelectedValue)

        Dim strChosenTagnames As String = ""
        For Each litem As ListItem In Me.SelectedTagNames.Items
            If litem.Selected = True Then
                If String.IsNullOrEmpty(strChosenTagnames) Then
                    strChosenTagnames = litem.Value.ToString
                Else
                    strChosenTagnames = strChosenTagnames & "," & litem.Value.ToString
                End If

            End If
        Next
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("theTagNameIDList").Value = strChosenTagnames
        CType(rpta.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("theTagNameIDList").Value = strChosenTagnames

        'full size report loaded
        Me.rptvwrExcel.Report = rpta


        'Web presentation version
        rpt.CreateDocument()
        rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1

        Me.rptvwrOrders.Report = rpt

    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click

        Response.Redirect("Default.aspx")

    End Sub

    Protected Sub btnRunReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRunReport.Click

        Me.pnlReport.Visible = True
        Dim body As HtmlGenericControl = CType(Me.Master.FindControl("body"), HtmlGenericControl)
        Dim rptvwr As DevExpress.XtraReports.Web.ReportViewer = CType(Me.rptvwrExcel, DevExpress.XtraReports.Web.ReportViewer)
        Dim strrptvwrClientID As String = rptvwr.ClientID
        Dim strCurrentOnclick As String = body.Attributes.Item("onLoad")
        body.Attributes.Add("onLoad", strCurrentOnclick & "exportToExcel('" & strrptvwrClientID & "');")

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
        If e.Command.Parameters("theRoot").Value = 0 Then
            e.Command.Parameters("theRoot").Value = -1
        End If
    End Sub
End Class
