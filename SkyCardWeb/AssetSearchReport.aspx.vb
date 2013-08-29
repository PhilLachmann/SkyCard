Imports System.Data.Odbc

Partial Class AssetSearchReport
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)

        If Page.IsPostBack = False Then

        Else
            mstr.RemoveErrorMessage()
        End If

    End Sub

    Protected Sub rptvwrReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles rptvwrReport.Load

        'pull values from session
        Dim clsReportParms As AssetReportParms = Session("ReportParms")
        Dim rpt As ReportAssetList = Me.rptvwrReport.Report
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString

        'subreport objects
        'Details report
        'Dim srTagAssetDetail As SubReportAssetTagDetail = New SubReportAssetTagDetail
        'CType(srTagAssetDetail.DataAdapter, OdbcDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString

        ''set subreport into master
        ''CType(CType(rpt.Bands.Item("Detail"), DevExpress.XtraReports.UI.DetailBand).FindControl("xrSubreportAssetTagDetails", False), DevExpress.XtraReports.UI.XRSubreport).ReportSource = srTagAssetDetail
        'CType(CType(rpt.Bands.Item("groupHeaderBand1"), DevExpress.XtraReports.UI.GroupHeaderBand).FindControl("xrSubreportAssetTagDetails", False), DevExpress.XtraReports.UI.XRSubreport).ReportSource = srTagAssetDetail


        'master rpt parms
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("thewhereclause").Value = clsReportParms.WhereClause
        CType(rpt.DataAdapter, OdbcDataAdapter).SelectCommand.Parameters("thelocationID").Value = clsReportParms.BuildingLocID


        'report parms
        rpt.Parameters("ReportFormat").Value = clsReportParms.ReportFormat


    End Sub
End Class
