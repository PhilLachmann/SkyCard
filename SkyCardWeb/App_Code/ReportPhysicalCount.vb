Public Class ReportPhysicalCount
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
    Private WithEvents StartDate As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents EndDate As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents odbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Private WithEvents odbcConnection1 As System.Data.Odbc.OdbcConnection
    Private WithEvents odbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Private WithEvents dataSet21 As DataSet2
    Private WithEvents xrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupFooterBand1 As DevExpress.XtraReports.UI.GroupFooterBand
    Private WithEvents xrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Private WithEvents xrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine3 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Private WithEvents xrLine4 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents xrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLine2 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "ReportPhysicalCount.resx"
        Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim xrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel25 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.StartDate = New DevExpress.XtraReports.Parameters.Parameter
        Me.EndDate = New DevExpress.XtraReports.Parameters.Parameter
        Me.odbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.odbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.odbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.dataSet21 = New DataSet2
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.groupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.xrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.xrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.dataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel16, Me.xrLabel19, Me.xrLabel20, Me.xrLabel25, Me.xrLabel24, Me.xrLabel23, Me.xrLabel3, Me.xrLabel7})
        Me.Detail.Height = 19
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLabel16
        '
        Me.xrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.ItemID", "")})
        Me.xrLabel16.Location = New System.Drawing.Point(25, 0)
        Me.xrLabel16.Name = "xrLabel16"
        Me.xrLabel16.Size = New System.Drawing.Size(92, 18)
        Me.xrLabel16.StyleName = "DataField"
        '
        'xrLabel19
        '
        Me.xrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.Quantity", "")})
        Me.xrLabel19.Location = New System.Drawing.Point(729, 0)
        Me.xrLabel19.Name = "xrLabel19"
        Me.xrLabel19.Size = New System.Drawing.Size(71, 18)
        Me.xrLabel19.StyleName = "DataField"
        Me.xrLabel19.StylePriority.UseTextAlignment = False
        Me.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrLabel20
        '
        Me.xrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.UserID", "")})
        Me.xrLabel20.Location = New System.Drawing.Point(662, 0)
        Me.xrLabel20.Name = "xrLabel20"
        Me.xrLabel20.Size = New System.Drawing.Size(61, 18)
        Me.xrLabel20.StyleName = "DataField"
        '
        'xrLabel25
        '
        Me.xrLabel25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.LocDesc", "")})
        Me.xrLabel25.Location = New System.Drawing.Point(550, 0)
        Me.xrLabel25.Name = "xrLabel25"
        Me.xrLabel25.Size = New System.Drawing.Size(112, 18)
        Me.xrLabel25.StyleName = "DataField"
        '
        'xrLabel24
        '
        Me.xrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.JobDesc", "")})
        Me.xrLabel24.Location = New System.Drawing.Point(413, 0)
        Me.xrLabel24.Name = "xrLabel24"
        Me.xrLabel24.Size = New System.Drawing.Size(136, 18)
        Me.xrLabel24.StyleName = "DataField"
        '
        'xrLabel23
        '
        Me.xrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.ItemDesc", "")})
        Me.xrLabel23.Location = New System.Drawing.Point(242, 0)
        Me.xrLabel23.Name = "xrLabel23"
        Me.xrLabel23.Size = New System.Drawing.Size(171, 18)
        Me.xrLabel23.StyleName = "DataField"
        '
        'xrLabel3
        '
        Me.xrLabel3.BackColor = System.Drawing.Color.White
        Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.QtyInv", "")})
        Me.xrLabel3.Location = New System.Drawing.Point(808, 0)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.Size = New System.Drawing.Size(88, 17)
        Me.xrLabel3.StylePriority.UseBackColor = False
        Me.xrLabel3.StylePriority.UseTextAlignment = False
        Me.xrLabel3.Text = "xrLabel3"
        Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrLabel7
        '
        Me.xrLabel7.BackColor = System.Drawing.Color.White
        Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.UOM", "")})
        Me.xrLabel7.Location = New System.Drawing.Point(125, 0)
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel7.Size = New System.Drawing.Size(117, 17)
        Me.xrLabel7.StylePriority.UseBackColor = False
        Me.xrLabel7.Text = "xrLabel7"
        '
        'StartDate
        '
        Me.StartDate.Name = "StartDate"
        Me.StartDate.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.DateTime
        Me.StartDate.Value = New Date(2010, 3, 1, 0, 0, 0, 0)
        '
        'EndDate
        '
        Me.EndDate.Name = "EndDate"
        Me.EndDate.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.DateTime
        Me.EndDate.Value = New Date(2010, 4, 1, 0, 0, 0, 0)
        '
        'odbcSelectCommand1
        '
        Me.odbcSelectCommand1.CommandText = "{? = CALL ""dba"".""GetReportPhysicalCount""(?, ?)}"
        Me.odbcSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.odbcSelectCommand1.Connection = Me.odbcConnection1
        Me.odbcSelectCommand1.Parameters.AddRange(New System.Data.Odbc.OdbcParameter() {New System.Data.Odbc.OdbcParameter("@ReturnValue", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.Odbc.OdbcParameter("@StartDate", System.Data.Odbc.OdbcType.DateTime, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "2010-3-1"), New System.Data.Odbc.OdbcParameter("@EndDate", System.Data.Odbc.OdbcType.DateTime, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "20104-1-")})
        '
        'odbcConnection1
        '
        Me.odbcConnection1.ConnectionString = "Dsn=GmechDB"
        '
        'odbcDataAdapter1
        '
        Me.odbcDataAdapter1.SelectCommand = Me.odbcSelectCommand1
        '
        'dataSet21
        '
        Me.dataSet21.DataSetName = "DataSet2"
        Me.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'xrLabel1
        '
        Me.xrLabel1.Location = New System.Drawing.Point(29, 0)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Size = New System.Drawing.Size(102, 25)
        Me.xrLabel1.StyleName = "FieldCaption"
        Me.xrLabel1.Text = "Record Date"
        '
        'groupHeaderBand1
        '
        Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel12, Me.xrLabel1})
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("RecordDate", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)})
        Me.groupHeaderBand1.Height = 40
        Me.groupHeaderBand1.Level = 1
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        Me.groupHeaderBand1.RepeatEveryPage = True
        '
        'xrLabel12
        '
        Me.xrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.RecordDate", "{0:MM/dd/yyyy}")})
        Me.xrLabel12.Location = New System.Drawing.Point(142, 0)
        Me.xrLabel12.Name = "xrLabel12"
        Me.xrLabel12.Size = New System.Drawing.Size(102, 23)
        Me.xrLabel12.StyleName = "DataField"
        '
        'groupFooterBand1
        '
        Me.groupFooterBand1.Height = 0
        Me.groupFooterBand1.Level = 1
        Me.groupFooterBand1.Name = "groupFooterBand1"
        '
        'xrLabel13
        '
        Me.xrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.Quantity", "")})
        Me.xrLabel13.ForeColor = System.Drawing.Color.Black
        Me.xrLabel13.Location = New System.Drawing.Point(729, 4)
        Me.xrLabel13.Name = "xrLabel13"
        Me.xrLabel13.Size = New System.Drawing.Size(71, 18)
        Me.xrLabel13.StyleName = "FieldCaption"
        Me.xrLabel13.StylePriority.UseForeColor = False
        Me.xrLabel13.StylePriority.UseTextAlignment = False
        xrSummary1.IgnoreNullValues = True
        xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel13.Summary = xrSummary1
        Me.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrLabel14
        '
        Me.xrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.QtyInv", "")})
        Me.xrLabel14.ForeColor = System.Drawing.Color.Black
        Me.xrLabel14.Location = New System.Drawing.Point(808, 4)
        Me.xrLabel14.Name = "xrLabel14"
        Me.xrLabel14.Size = New System.Drawing.Size(90, 18)
        Me.xrLabel14.StyleName = "FieldCaption"
        Me.xrLabel14.StylePriority.UseForeColor = False
        Me.xrLabel14.StylePriority.UseTextAlignment = False
        xrSummary2.IgnoreNullValues = True
        xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel14.Summary = xrSummary2
        Me.xrLabel14.Text = "xrLabel14"
        Me.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrLabel15
        '
        Me.xrLabel15.ForeColor = System.Drawing.Color.Black
        Me.xrLabel15.Location = New System.Drawing.Point(150, 4)
        Me.xrLabel15.Name = "xrLabel15"
        Me.xrLabel15.Size = New System.Drawing.Size(102, 18)
        Me.xrLabel15.StyleName = "FieldCaption"
        Me.xrLabel15.StylePriority.UseForeColor = False
        Me.xrLabel15.Text = "Item Sum"
        '
        'pageFooterBand1
        '
        Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrPageInfo2})
        Me.pageFooterBand1.Height = 29
        Me.pageFooterBand1.Name = "pageFooterBand1"
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.Location = New System.Drawing.Point(6, 6)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.Size = New System.Drawing.Size(438, 23)
        Me.xrPageInfo1.StyleName = "PageInfo"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Format = "Page {0} of {1}"
        Me.xrPageInfo2.Location = New System.Drawing.Point(456, 6)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.Size = New System.Drawing.Size(438, 23)
        Me.xrPageInfo2.StyleName = "PageInfo"
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'reportHeaderBand1
        '
        Me.reportHeaderBand1.Height = 0
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        '
        'xrLabel26
        '
        Me.xrLabel26.Location = New System.Drawing.Point(8, 4)
        Me.xrLabel26.Name = "xrLabel26"
        Me.xrLabel26.Size = New System.Drawing.Size(888, 33)
        Me.xrLabel26.StyleName = "Title"
        Me.xrLabel26.Text = "Physical Count"
        '
        'xrLine3
        '
        Me.xrLine3.Location = New System.Drawing.Point(8, 0)
        Me.xrLine3.Name = "xrLine3"
        Me.xrLine3.Size = New System.Drawing.Size(888, 2)
        '
        'GroupHeader1
        '
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ItemID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.Height = 0
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel15, Me.xrLabel14, Me.xrLabel13, Me.xrLine4})
        Me.GroupFooter1.Height = 44
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'xrLine4
        '
        Me.xrLine4.Location = New System.Drawing.Point(150, 0)
        Me.xrLine4.Name = "xrLine4"
        Me.xrLine4.Size = New System.Drawing.Size(746, 2)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel26, Me.xrLine3, Me.xrLabel8, Me.xrLabel2, Me.xrLabel5, Me.xrLabel6, Me.xrLabel9, Me.xrLabel10, Me.xrLabel11, Me.xrLine1, Me.xrLine2, Me.xrLabel4})
        Me.PageHeader.Height = 125
        Me.PageHeader.Name = "PageHeader"
        '
        'xrLabel8
        '
        Me.xrLabel8.Location = New System.Drawing.Point(800, 83)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Size = New System.Drawing.Size(96, 36)
        Me.xrLabel8.StyleName = "FieldCaption"
        Me.xrLabel8.StylePriority.UseTextAlignment = False
        Me.xrLabel8.Text = "Inventory Qty (Qty On Hand)"
        Me.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrLabel2
        '
        Me.xrLabel2.Location = New System.Drawing.Point(25, 83)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Size = New System.Drawing.Size(92, 36)
        Me.xrLabel2.StyleName = "FieldCaption"
        Me.xrLabel2.StylePriority.UseTextAlignment = False
        Me.xrLabel2.Text = "Item ID"
        Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrLabel5
        '
        Me.xrLabel5.Location = New System.Drawing.Point(725, 83)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Size = New System.Drawing.Size(71, 36)
        Me.xrLabel5.StyleName = "FieldCaption"
        Me.xrLabel5.StylePriority.UseTextAlignment = False
        Me.xrLabel5.Text = "Quantity Counted"
        Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrLabel6
        '
        Me.xrLabel6.Location = New System.Drawing.Point(662, 83)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Size = New System.Drawing.Size(61, 36)
        Me.xrLabel6.StyleName = "FieldCaption"
        Me.xrLabel6.StylePriority.UseTextAlignment = False
        Me.xrLabel6.Text = "User ID"
        Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrLabel9
        '
        Me.xrLabel9.Location = New System.Drawing.Point(242, 83)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Size = New System.Drawing.Size(171, 36)
        Me.xrLabel9.StyleName = "FieldCaption"
        Me.xrLabel9.StylePriority.UseTextAlignment = False
        Me.xrLabel9.Text = "Item Desc"
        Me.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrLabel10
        '
        Me.xrLabel10.Location = New System.Drawing.Point(413, 83)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Size = New System.Drawing.Size(133, 36)
        Me.xrLabel10.StyleName = "FieldCaption"
        Me.xrLabel10.StylePriority.UseTextAlignment = False
        Me.xrLabel10.Text = "Job Desc"
        Me.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrLabel11
        '
        Me.xrLabel11.Location = New System.Drawing.Point(550, 83)
        Me.xrLabel11.Name = "xrLabel11"
        Me.xrLabel11.Size = New System.Drawing.Size(112, 36)
        Me.xrLabel11.StyleName = "FieldCaption"
        Me.xrLabel11.StylePriority.UseTextAlignment = False
        Me.xrLabel11.Text = "Loc Desc"
        Me.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrLine1
        '
        Me.xrLine1.Location = New System.Drawing.Point(8, 79)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.Size = New System.Drawing.Size(888, 2)
        '
        'xrLine2
        '
        Me.xrLine2.Location = New System.Drawing.Point(8, 121)
        Me.xrLine2.Name = "xrLine2"
        Me.xrLine2.Size = New System.Drawing.Size(888, 2)
        '
        'xrLabel4
        '
        Me.xrLabel4.Location = New System.Drawing.Point(125, 83)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Size = New System.Drawing.Size(117, 36)
        Me.xrLabel4.StyleName = "FieldCaption"
        Me.xrLabel4.StylePriority.UseTextAlignment = False
        Me.xrLabel4.Text = "Size"
        Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportPhysicalCount
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.groupHeaderBand1, Me.groupFooterBand1, Me.pageFooterBand1, Me.reportHeaderBand1, Me.GroupHeader1, Me.GroupFooter1, Me.PageHeader})
        Me.DataAdapter = Me.odbcDataAdapter1
        Me.DataMember = "Table"
        Me.DataSource = Me.dataSet21
        Me.GridSize = New System.Drawing.Size(4, 4)
        Me.Landscape = True
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.StartDate, Me.EndDate})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "9.2"
        CType(Me.dataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand

#End Region

    Private Sub odbcDataAdapter1_RowUpdated(ByVal sender As System.Object, ByVal e As System.Data.Odbc.OdbcRowUpdatedEventArgs)

    End Sub
End Class