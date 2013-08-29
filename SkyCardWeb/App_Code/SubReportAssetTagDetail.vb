Public Class SubReportAssetTagDetail
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrTagValue As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents odbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Private WithEvents odbcConnection1 As System.Data.Odbc.OdbcConnection
    Private WithEvents odbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Private WithEvents assetReportDetail1 As AssetReportDetail

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "SubReportAssetTagDetail.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.SubReportAssetTagDetail.ResourceManager
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrTagValue = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.odbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.odbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.odbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.assetReportDetail1 = New AssetReportDetail
        CType(Me.assetReportDetail1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTagValue, Me.xrLabel1})
        Me.Detail.HeightF = 20.8333!
        Me.Detail.MultiColumn.ColumnCount = 2
        Me.Detail.MultiColumn.ColumnSpacing = 30.0!
        Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseBackColor = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrTagValue
        '
        Me.xrTagValue.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.tagvalue")})
        Me.xrTagValue.LocationFloat = New DevExpress.Utils.PointFloat(180.0!, 0.0!)
        Me.xrTagValue.Name = "xrTagValue"
        Me.xrTagValue.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrTagValue.SizeF = New System.Drawing.SizeF(172.0!, 20.0!)
        Me.xrTagValue.Text = "xrLabel1"
        '
        'xrLabel1
        '
        Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.tagname")})
        Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(36.0!, 0.0!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(140.0!, 20.0!)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.StylePriority.UseTextAlignment = False
        Me.xrLabel1.Text = "xrLabel1"
        Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 10.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 10.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'odbcSelectCommand1
        '
        Me.odbcSelectCommand1.CommandText = "{? = CALL ""dba"".""GetAssetReportDetails""(?)}"
        Me.odbcSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.odbcSelectCommand1.Connection = Me.odbcConnection1
        Me.odbcSelectCommand1.Parameters.AddRange(New System.Data.Odbc.OdbcParameter() {New System.Data.Odbc.OdbcParameter("@ReturnValue", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, CType(resources.GetObject("odbcSelectCommand1.Parameters"), Object)), New System.Data.Odbc.OdbcParameter("theTagNumber", System.Data.Odbc.OdbcType.NVarChar, 2000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "123")})
        '
        'odbcConnection1
        '
        Me.odbcConnection1.ConnectionString = "Dsn=CaseMgmt;uid=dba;password=sql;"
        '
        'odbcDataAdapter1
        '
        Me.odbcDataAdapter1.SelectCommand = Me.odbcSelectCommand1
        '
        'assetReportDetail1
        '
        Me.assetReportDetail1.DataSetName = "AssetReportDetail"
        Me.assetReportDetail1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubReportAssetTagDetail
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.DataAdapter = Me.odbcDataAdapter1
        Me.DataMember = "Table"
        Me.DataSource = Me.assetReportDetail1
        Me.Margins = New System.Drawing.Printing.Margins(10, 10, 10, 10)
        Me.PageColor = System.Drawing.Color.Transparent
        Me.SnapGridSize = 4.0!
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.SnapToGrid
        Me.Version = "10.2"
        CType(Me.assetReportDetail1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

    Private Sub xrTagValue_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrTagValue.BeforePrint

        If GetCurrentRow() IsNot Nothing Then
            Select Case GetCurrentColumnValue("tagtype").ToString.ToLower
                Case "timestamp"
                    'xrTagValue.Text = CType(GetCurrentColumnValue("tagvalue"), DateTime).ToShortDateString()
                    xrTagValue.Text = String.Format("{0:g}", CType(GetCurrentColumnValue("tagvalue"), DateTime))
                Case "decimal"
                    xrTagValue.Text = String.Format("{0:n2}", CType(GetCurrentColumnValue("tagvalue"), Decimal))

                Case Else
                    'no formatting

            End Select
        End If



    End Sub
End Class