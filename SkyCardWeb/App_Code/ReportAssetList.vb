Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Imports System.Data
Imports System.Data.Odbc
Public Class ReportAssetList
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
    Private WithEvents assetReportHeader1 As AssetReportHeader
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrAssetTagNumber As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Private WithEvents bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Private WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrSubreportAssetTagDetails As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents FormatAssetTagNumberLink As DevExpress.XtraReports.UI.FormattingRule
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents PartNumberSumText As DevExpress.XtraReports.UI.CalculatedField
    Private WithEvents ReportFormat As DevExpress.XtraReports.Parameters.Parameter

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "ReportAssetList.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.ReportAssetList.ResourceManager
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.odbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.odbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.odbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.assetReportHeader1 = New AssetReportHeader
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.xrSubreportAssetTagDetails = New DevExpress.XtraReports.UI.XRSubreport
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.xrAssetTagNumber = New DevExpress.XtraReports.UI.XRLabel
        Me.FormatAssetTagNumberLink = New DevExpress.XtraReports.UI.FormattingRule
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.PartNumberSumText = New DevExpress.XtraReports.UI.CalculatedField
        Me.ReportFormat = New DevExpress.XtraReports.Parameters.Parameter
        CType(Me.assetReportHeader1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0.08331934!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "DataField"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'odbcSelectCommand1
        '
        Me.odbcSelectCommand1.CommandText = "{? = CALL ""dba"".""GetAssetReportHeaders""(?, ?)}"
        Me.odbcSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.odbcSelectCommand1.Connection = Me.odbcConnection1
        Me.odbcSelectCommand1.Parameters.AddRange(New System.Data.Odbc.OdbcParameter() {New System.Data.Odbc.OdbcParameter("@RetrunValue", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, CType(resources.GetObject("odbcSelectCommand1.Parameters"), Object)), New System.Data.Odbc.OdbcParameter("thewhereclause", System.Data.Odbc.OdbcType.NVarChar, 8000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "where tagnumber like 'EQ100%'"), New System.Data.Odbc.OdbcParameter("thelocationID", System.Data.Odbc.OdbcType.Int, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "0")})
        '
        'odbcConnection1
        '
        Me.odbcConnection1.ConnectionString = "Dsn=CaseMgmt;userid=dba;"
        '
        'odbcDataAdapter1
        '
        Me.odbcDataAdapter1.SelectCommand = Me.odbcSelectCommand1
        '
        'assetReportHeader1
        '
        Me.assetReportHeader1.DataSetName = "AssetReportHeader"
        Me.assetReportHeader1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
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
        'groupHeaderBand1
        '
        Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel10, Me.xrLabel9, Me.xrLabel8, Me.xrLabel5, Me.xrLabel4, Me.xrLabel2, Me.xrLine1, Me.xrSubreportAssetTagDetails, Me.xrLabel3, Me.xrPictureBox1, Me.xrAssetTagNumber, Me.xrLabel1, Me.xrLabel6})
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("tagnumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.groupHeaderBand1.HeightF = 240.0!
        Me.groupHeaderBand1.KeepTogether = True
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        Me.groupHeaderBand1.StylePriority.UseBackColor = False
        '
        'xrLabel10
        '
        Me.xrLabel10.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.PartNumberSumText")})
        Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(504.0!, 124.0!)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel10.SizeF = New System.Drawing.SizeF(132.0!, 20.0!)
        Me.xrLabel10.StyleName = "DataField"
        Me.xrLabel10.StylePriority.UseBackColor = False
        Me.xrLabel10.Text = "xrAssetTagNumber"
        '
        'xrLabel9
        '
        Me.xrLabel9.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel9.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(288.0!, 124.0!)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(212.0!, 20.00001!)
        Me.xrLabel9.StyleName = "FieldCaption"
        Me.xrLabel9.StylePriority.UseBackColor = False
        Me.xrLabel9.StylePriority.UseFont = False
        Me.xrLabel9.Text = "Total Quantity of Part Number:"
        '
        'xrLabel8
        '
        Me.xrLabel8.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.location")})
        Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(424.0!, 100.0!)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel8.SizeF = New System.Drawing.SizeF(392.0!, 20.00001!)
        Me.xrLabel8.StyleName = "DataField"
        Me.xrLabel8.StylePriority.UseBackColor = False
        Me.xrLabel8.Text = "xrAssetTagNumber"
        '
        'xrLabel5
        '
        Me.xrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel5.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(288.0!, 100.0!)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(132.0!, 20.00001!)
        Me.xrLabel5.StyleName = "FieldCaption"
        Me.xrLabel5.StylePriority.UseBackColor = False
        Me.xrLabel5.StylePriority.UseFont = False
        Me.xrLabel5.Text = "Location"
        '
        'xrLabel4
        '
        Me.xrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.quantity")})
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(288.0!, 74.0!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(132.0!, 20.0!)
        Me.xrLabel4.StyleName = "DataField"
        Me.xrLabel4.StylePriority.UseBackColor = False
        Me.xrLabel4.Text = "xrAssetTagNumber"
        '
        'xrLabel2
        '
        Me.xrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel2.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(288.0!, 52.0!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(132.0!, 20.00001!)
        Me.xrLabel2.StyleName = "FieldCaption"
        Me.xrLabel2.StylePriority.UseBackColor = False
        Me.xrLabel2.StylePriority.UseFont = False
        Me.xrLabel2.Text = "Quantity"
        '
        'xrLine1
        '
        Me.xrLine1.LineWidth = 5
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 224.0!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(812.0!, 12.00002!)
        '
        'xrSubreportAssetTagDetails
        '
        Me.xrSubreportAssetTagDetails.CanShrink = True
        Me.xrSubreportAssetTagDetails.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 156.0!)
        Me.xrSubreportAssetTagDetails.Name = "xrSubreportAssetTagDetails"
        Me.xrSubreportAssetTagDetails.SizeF = New System.Drawing.SizeF(812.0!, 67.99997!)
        '
        'xrLabel3
        '
        Me.xrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel3.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(424.0!, 3.999996!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(88.00003!, 20.00001!)
        Me.xrLabel3.StyleName = "FieldCaption"
        Me.xrLabel3.StylePriority.UseBackColor = False
        Me.xrLabel3.StylePriority.UseFont = False
        Me.xrLabel3.Text = "Description"
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Table.TV_blob")})
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 3.999996!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(276.0!, 144.0!)
        '
        'xrAssetTagNumber
        '
        Me.xrAssetTagNumber.BackColor = System.Drawing.Color.Transparent
        Me.xrAssetTagNumber.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.tagnumber")})
        Me.xrAssetTagNumber.FormattingRules.Add(Me.FormatAssetTagNumberLink)
        Me.xrAssetTagNumber.LocationFloat = New DevExpress.Utils.PointFloat(288.0!, 26.0!)
        Me.xrAssetTagNumber.Name = "xrAssetTagNumber"
        Me.xrAssetTagNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrAssetTagNumber.SizeF = New System.Drawing.SizeF(132.0!, 20.0!)
        Me.xrAssetTagNumber.StyleName = "DataField"
        Me.xrAssetTagNumber.StylePriority.UseBackColor = False
        Me.xrAssetTagNumber.Text = "xrAssetTagNumber"
        '
        'FormatAssetTagNumberLink
        '
        Me.FormatAssetTagNumberLink.Condition = "Not IsNullOrEmpty([tagnumber])"
        '
        '
        '
        Me.FormatAssetTagNumberLink.Formatting.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormatAssetTagNumberLink.Formatting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FormatAssetTagNumberLink.Name = "FormatAssetTagNumberLink"
        '
        'xrLabel1
        '
        Me.xrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel1.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(288.0!, 3.999996!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(132.0!, 20.00001!)
        Me.xrLabel1.StyleName = "FieldCaption"
        Me.xrLabel1.StylePriority.UseBackColor = False
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.Text = "Asset Tag Number"
        '
        'xrLabel6
        '
        Me.xrLabel6.CanShrink = True
        Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.TV_varchar")})
        Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(424.0!, 28.00001!)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel6.SizeF = New System.Drawing.SizeF(396.0!, 65.99998!)
        Me.xrLabel6.Text = "xrLabel6"
        '
        'pageFooterBand1
        '
        Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrPageInfo2})
        Me.pageFooterBand1.HeightF = 29.0!
        Me.pageFooterBand1.Name = "pageFooterBand1"
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.BackColor = System.Drawing.Color.Transparent
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(403.0!, 23.0!)
        Me.xrPageInfo1.StyleName = "PageInfo"
        Me.xrPageInfo1.StylePriority.UseBackColor = False
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.BackColor = System.Drawing.Color.Transparent
        Me.xrPageInfo2.Format = "Page {0} of {1}"
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(421.0!, 6.0!)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(403.0!, 23.0!)
        Me.xrPageInfo2.StyleName = "PageInfo"
        Me.xrPageInfo2.StylePriority.UseBackColor = False
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'reportHeaderBand1
        '
        Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel7})
        Me.reportHeaderBand1.HeightF = 38.49999!
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        '
        'xrLabel7
        '
        Me.xrLabel7.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(3.999996!, 0.0!)
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel7.SizeF = New System.Drawing.SizeF(818.0!, 33.0!)
        Me.xrLabel7.StyleName = "Title"
        Me.xrLabel7.StylePriority.UseBackColor = False
        Me.xrLabel7.StylePriority.UseTextAlignment = False
        Me.xrLabel7.Text = "Asset List Report"
        Me.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        'PartNumberSumText
        '
        Me.PartNumberSumText.DataMember = "Table"
        Me.PartNumberSumText.DataSource = Me.assetReportHeader1
        Me.PartNumberSumText.Expression = "Iif(IsNullOrEmpty([partnumbersum]),'N/A' , [partnumbersum])"
        Me.PartNumberSumText.Name = "PartNumberSumText"
        '
        'ReportFormat
        '
        Me.ReportFormat.Name = "ReportFormat"
        Me.ReportFormat.Value = "P"
        '
        'ReportAssetList
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.groupHeaderBand1, Me.pageFooterBand1, Me.reportHeaderBand1, Me.topMarginBand1, Me.bottomMarginBand1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.PartNumberSumText})
        Me.DataAdapter = Me.odbcDataAdapter1
        Me.DataMember = "Table"
        Me.DataSource = Me.assetReportHeader1
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormatAssetTagNumberLink})
        Me.Margins = New System.Drawing.Printing.Margins(10, 10, 10, 10)
        Me.PageColor = System.Drawing.Color.Transparent
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.ReportFormat})
        Me.SnapGridSize = 4.0!
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.SnapToGrid
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "10.2"
        CType(Me.assetReportHeader1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand

#End Region

    Private Sub xrSubreportAssetTagDetails_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubreportAssetTagDetails.BeforePrint

        Dim srTagAssetDetail As SubReportAssetTagDetail = New SubReportAssetTagDetail
        CType(srTagAssetDetail.DataAdapter, OdbcDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString

        'set subreport into master
        CType(CType(Me.Bands.Item("groupHeaderBand1"), DevExpress.XtraReports.UI.GroupHeaderBand).FindControl("xrSubreportAssetTagDetails", False), DevExpress.XtraReports.UI.XRSubreport).ReportSource = srTagAssetDetail




        CType((CType(sender, XRSubreport)).ReportSource, SubReportAssetTagDetail).DataAdapter.SelectCommand.Parameters("theTagNumber").Value = GetCurrentColumnValue("tagnumber")

    End Sub

    Private Sub xrAssetTagNumber_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrAssetTagNumber.BeforePrint
        CType(sender, XRLabel).Tag = GetCurrentRow()

        'this gets a refrnc to the label and sets its NAVIGATEURL property
        Dim lnk As XRLabel = CType(sender, XRLabel)
        If CType(sender, XRLabel).Tag Is Nothing Then
            Exit Sub
        Else
            If String.IsNullOrEmpty(CType(GetCurrentRow(), DataRowView).Item("tagnumber").ToString()) Then
                lnk.NavigateUrl = Nothing
                Exit Sub
            End If
        End If

        'lnk.NavigateUrl = "javascript:openAdjustmentOPMDOCNumEntry(this,'" & CType(GetCurrentRow(), DataRowView).Item("upc_Code") & "','" & CType(GetCurrentRow(), DataRowView).Item("ID") & "');"
        lnk.NavigateUrl = "javascript:openRedirector('AssetEdit','" & CType(GetCurrentRow(), DataRowView).Item("tagnumber").ToString() & "');"

    End Sub

    Private Sub ReportAssetList_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint

        If Me.Parameters("ReportFormat").Value = "S" Then
            Me.PaperKind = Drawing.Printing.PaperKind.Custom
            Me.PageHeight = Me.PageHeight * 100
            Me.xrPageInfo1.Visible = False
            Me.xrPageInfo2.Visible = False
        End If

    End Sub
End Class