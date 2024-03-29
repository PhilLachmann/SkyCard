Imports DevExpress.XtraReports.UI
Imports System.Data
Public Class ReportAssetByLocation
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
    Private WithEvents odbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Private WithEvents odbcConnection1 As System.Data.Odbc.OdbcConnection
    Private WithEvents odbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Private WithEvents assetByLocation1 As AssetByLocation
    Private WithEvents FormatAssetTagNumberLink As DevExpress.XtraReports.UI.FormattingRule
    Private WithEvents xrTable2 As DevExpress.XtraReports.UI.XRTable
    Private WithEvents xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Private WithEvents xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents pageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents xrTable1 As DevExpress.XtraReports.UI.XRTable
    Private WithEvents xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Private WithEvents xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Private WithEvents xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Private WithEvents xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Private WithEvents bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "ReportAssetByLocation.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.ReportAssetByLocation.ResourceManager
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.FormatAssetTagNumberLink = New DevExpress.XtraReports.UI.FormattingRule
        Me.odbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.odbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.odbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.assetByLocation1 = New AssetByLocation
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle
        Me.pageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell
        Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand
        CType(Me.assetByLocation1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
        Me.Detail.HeightF = 23.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "DataField"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'FormatAssetTagNumberLink
        '
        Me.FormatAssetTagNumberLink.Condition = "Not IsNullOrEmpty([tagnumber])"
        '
        '
        '
        Me.FormatAssetTagNumberLink.Formatting.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormatAssetTagNumberLink.Name = "FormatAssetTagNumberLink"
        '
        'odbcSelectCommand1
        '
        Me.odbcSelectCommand1.CommandText = "{? = CALL ""dba"".""GetAssetsByLocationReport""(?)}"
        Me.odbcSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.odbcSelectCommand1.Connection = Me.odbcConnection1
        Me.odbcSelectCommand1.Parameters.AddRange(New System.Data.Odbc.OdbcParameter() {New System.Data.Odbc.OdbcParameter("@ReturnValue", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, CType(resources.GetObject("odbcSelectCommand1.Parameters"), Object)), New System.Data.Odbc.OdbcParameter("theLocationID", System.Data.Odbc.OdbcType.Int, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "0")})
        '
        'odbcConnection1
        '
        Me.odbcConnection1.ConnectionString = "Dsn=CaseMgmt;userid=dba;"
        '
        'odbcDataAdapter1
        '
        Me.odbcDataAdapter1.SelectCommand = Me.odbcSelectCommand1
        '
        'assetByLocation1
        '
        Me.assetByLocation1.DataSetName = "AssetByLocation"
        Me.assetByLocation1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.White
        Me.Title.BorderColor = System.Drawing.SystemColors.ControlText
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ForeColor = System.Drawing.Color.Maroon
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.White
        Me.FieldCaption.BorderColor = System.Drawing.SystemColors.ControlText
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.FieldCaption.BorderWidth = 1
        Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.White
        Me.PageInfo.BorderColor = System.Drawing.SystemColors.ControlText
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1
        Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.White
        Me.DataField.BorderColor = System.Drawing.SystemColors.ControlText
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1
        Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.DataField.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'pageHeaderBand1
        '
        Me.pageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
        Me.pageHeaderBand1.HeightF = 42.0!
        Me.pageHeaderBand1.Name = "pageHeaderBand1"
        '
        'xrTable1
        '
        Me.xrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.xrTable1.Name = "xrTable1"
        Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow3})
        Me.xrTable1.SizeF = New System.Drawing.SizeF(817.0!, 36.0!)
        '
        'xrTableRow1
        '
        Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
        Me.xrTableRow1.Name = "xrTableRow1"
        Me.xrTableRow1.Weight = 1
        '
        'xrTableCell1
        '
        Me.xrTableCell1.Name = "xrTableCell1"
        Me.xrTableCell1.Text = "xrTableCell1"
        Me.xrTableCell1.Weight = 1
        '
        'xrTableCell2
        '
        Me.xrTableCell2.Name = "xrTableCell2"
        Me.xrTableCell2.Text = "xrTableCell2"
        Me.xrTableCell2.Weight = 1
        '
        'xrTableCell3
        '
        Me.xrTableCell3.Name = "xrTableCell3"
        Me.xrTableCell3.Text = "xrTableCell3"
        Me.xrTableCell3.Weight = 1
        '
        'xrTable2
        '
        Me.xrTable2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 0.0!)
        Me.xrTable2.Name = "xrTable2"
        Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow4})
        Me.xrTable2.SizeF = New System.Drawing.SizeF(817.0!, 23.0!)
        '
        'xrTableRow2
        '
        Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
        Me.xrTableRow2.Name = "xrTableRow2"
        Me.xrTableRow2.Weight = 1
        '
        'xrTableCell4
        '
        Me.xrTableCell4.Name = "xrTableCell4"
        Me.xrTableCell4.Text = "xrTableCell4"
        Me.xrTableCell4.Weight = 1
        '
        'xrTableCell5
        '
        Me.xrTableCell5.Name = "xrTableCell5"
        Me.xrTableCell5.Text = "xrTableCell5"
        Me.xrTableCell5.Weight = 1
        '
        'xrTableCell6
        '
        Me.xrTableCell6.Name = "xrTableCell6"
        Me.xrTableCell6.Text = "xrTableCell6"
        Me.xrTableCell6.Weight = 1
        '
        'xrTableRow3
        '
        Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell7, Me.xrTableCell9, Me.xrTableCell11, Me.xrTableCell13, Me.xrTableCell15})
        Me.xrTableRow3.Name = "xrTableRow3"
        Me.xrTableRow3.Weight = 1
        '
        'xrTableRow4
        '
        Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell8, Me.xrTableCell10, Me.xrTableCell12, Me.xrTableCell14, Me.xrTableCell16})
        Me.xrTableRow4.Name = "xrTableRow4"
        Me.xrTableRow4.Weight = 1
        '
        'xrTableCell7
        '
        Me.xrTableCell7.CanGrow = False
        Me.xrTableCell7.Name = "xrTableCell7"
        Me.xrTableCell7.StyleName = "FieldCaption"
        Me.xrTableCell7.Text = "Tag Number"
        Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrTableCell7.Weight = 48.880038650120483
        '
        'xrTableCell8
        '
        Me.xrTableCell8.CanGrow = False
        Me.xrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.TagNumber")})
        Me.xrTableCell8.Name = "xrTableCell8"
        Me.xrTableCell8.StyleName = "DataField"
        Me.xrTableCell8.Text = "xrTableCell8"
        Me.xrTableCell8.Weight = 48.572238385166649
        '
        'xrTableCell9
        '
        Me.xrTableCell9.CanGrow = False
        Me.xrTableCell9.Name = "xrTableCell9"
        Me.xrTableCell9.StyleName = "FieldCaption"
        Me.xrTableCell9.Text = "Description"
        Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrTableCell9.Weight = 116.61996134987952
        '
        'xrTableCell10
        '
        Me.xrTableCell10.CanGrow = False
        Me.xrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.AssetDesc")})
        Me.xrTableCell10.Name = "xrTableCell10"
        Me.xrTableCell10.StyleName = "DataField"
        Me.xrTableCell10.Text = "xrTableCell10"
        Me.xrTableCell10.Weight = 116.92776161483334
        '
        'xrTableCell11
        '
        Me.xrTableCell11.CanGrow = False
        Me.xrTableCell11.Name = "xrTableCell11"
        Me.xrTableCell11.StyleName = "FieldCaption"
        Me.xrTableCell11.Text = "Modified"
        Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrTableCell11.Weight = 91
        '
        'xrTableCell12
        '
        Me.xrTableCell12.CanGrow = False
        Me.xrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.last_modified")})
        Me.xrTableCell12.Name = "xrTableCell12"
        Me.xrTableCell12.StyleName = "DataField"
        Me.xrTableCell12.Text = "xrTableCell12"
        Me.xrTableCell12.Weight = 91
        '
        'xrTableCell13
        '
        Me.xrTableCell13.CanGrow = False
        Me.xrTableCell13.Name = "xrTableCell13"
        Me.xrTableCell13.StyleName = "FieldCaption"
        Me.xrTableCell13.Text = "Building"
        Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrTableCell13.Weight = 100.56720464699417
        '
        'xrTableCell14
        '
        Me.xrTableCell14.CanGrow = False
        Me.xrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.ParentDesc")})
        Me.xrTableCell14.Name = "xrTableCell14"
        Me.xrTableCell14.StyleName = "DataField"
        Me.xrTableCell14.Text = "xrTableCell14"
        Me.xrTableCell14.Weight = 99.62604043650073
        '
        'xrTableCell15
        '
        Me.xrTableCell15.CanGrow = False
        Me.xrTableCell15.Name = "xrTableCell15"
        Me.xrTableCell15.StyleName = "FieldCaption"
        Me.xrTableCell15.Text = "Location"
        Me.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrTableCell15.Weight = 50.432795353005829
        '
        'xrTableCell16
        '
        Me.xrTableCell16.CanGrow = False
        Me.xrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.LocDesc")})
        Me.xrTableCell16.Name = "xrTableCell16"
        Me.xrTableCell16.StyleName = "DataField"
        Me.xrTableCell16.Text = "xrTableCell16"
        Me.xrTableCell16.Weight = 51.37395956349927
        '
        'pageFooterBand1
        '
        Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrPageInfo2})
        Me.pageFooterBand1.HeightF = 29.0!
        Me.pageFooterBand1.Name = "pageFooterBand1"
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(403.0!, 23.0!)
        Me.xrPageInfo1.StyleName = "PageInfo"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Format = "Page {0} of {1}"
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(421.0!, 6.0!)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(403.0!, 23.0!)
        Me.xrPageInfo2.StyleName = "PageInfo"
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'reportHeaderBand1
        '
        Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
        Me.reportHeaderBand1.HeightF = 51.0!
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        '
        'xrLabel1
        '
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(818.0!, 33.0!)
        Me.xrLabel1.StyleName = "Title"
        Me.xrLabel1.Text = "Asset By Location"
        '
        'topMarginBand1
        '
        Me.topMarginBand1.HeightF = 10.0!
        Me.topMarginBand1.Name = "topMarginBand1"
        '
        'bottomMarginBand1
        '
        Me.bottomMarginBand1.HeightF = 10.0!
        Me.bottomMarginBand1.Name = "bottomMarginBand1"
        '
        'ReportAssetByLocation
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.pageHeaderBand1, Me.pageFooterBand1, Me.reportHeaderBand1, Me.topMarginBand1, Me.bottomMarginBand1})
        Me.DataAdapter = Me.odbcDataAdapter1
        Me.DataMember = "Table"
        Me.DataSource = Me.assetByLocation1
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormatAssetTagNumberLink})
        Me.Margins = New System.Drawing.Printing.Margins(10, 10, 10, 10)
        Me.SnapGridSize = 4.0!
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.SnapToGrid
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "10.2"
        CType(Me.assetByLocation1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand

#End Region

    Private Sub xrAssetTagNumber_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
        CType(sender, XRLabel).Tag = GetCurrentRow()

        'this gets a refrnc to the label and sets its NAVIGATEURL property
        Dim lnk As XRLabel = CType(sender, XRLabel)
        If CType(sender, XRLabel).Tag Is Nothing Then
            Exit Sub
        Else
            If String.IsNullOrEmpty(CType(GetCurrentRow(), DataRowView).Item("TagNumber").ToString()) Then
                lnk.NavigateUrl = Nothing
                Exit Sub
            End If
        End If

        lnk.NavigateUrl = "javascript:openRedirector('AssetEdit','" & CType(GetCurrentRow(), DataRowView).Item("TagNumber").ToString() & "');"

    End Sub
End Class