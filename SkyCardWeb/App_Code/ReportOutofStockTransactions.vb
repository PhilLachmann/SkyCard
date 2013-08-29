Public Class ReportOutofStockTransactions
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
    Private WithEvents outofStockTransactions1 As OutofStockTransactions
    Private WithEvents StartDate As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents EndDate As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents xrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupHeaderBand2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupHeaderBand3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLine2 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupFooterBand1 As DevExpress.XtraReports.UI.GroupFooterBand
    Private WithEvents groupFooterBand3 As DevExpress.XtraReports.UI.GroupFooterBand
    Private WithEvents xrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine3 As DevExpress.XtraReports.UI.XRLine

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "ReportOutofStockTransactions.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.ReportOutofStockTransactions.ResourceManager
        Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim xrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel25 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel28 = New DevExpress.XtraReports.UI.XRLabel
        Me.odbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.odbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.odbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.outofStockTransactions1 = New OutofStockTransactions
        Me.StartDate = New DevExpress.XtraReports.Parameters.Parameter
        Me.EndDate = New DevExpress.XtraReports.Parameters.Parameter
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel39 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel29 = New DevExpress.XtraReports.UI.XRLabel
        Me.groupHeaderBand2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.groupHeaderBand3 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.groupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.groupFooterBand3 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.xrLabel33 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel34 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel35 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine
        CType(Me.outofStockTransactions1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel21, Me.xrLabel22, Me.xrLabel23, Me.xrLabel24, Me.xrLabel25, Me.xrLabel26, Me.xrLabel27, Me.xrLabel28})
        Me.Detail.Height = 20
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("RecordDate", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLabel21
        '
        Me.xrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.ItemID", "")})
        Me.xrLabel21.Location = New System.Drawing.Point(66, 0)
        Me.xrLabel21.Name = "xrLabel21"
        Me.xrLabel21.Size = New System.Drawing.Size(114, 18)
        Me.xrLabel21.StyleName = "DataField"
        '
        'xrLabel22
        '
        Me.xrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.UOM", "")})
        Me.xrLabel22.Location = New System.Drawing.Point(183, 0)
        Me.xrLabel22.Name = "xrLabel22"
        Me.xrLabel22.Size = New System.Drawing.Size(146, 18)
        Me.xrLabel22.StyleName = "DataField"
        '
        'xrLabel23
        '
        Me.xrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.ItemDesc", "")})
        Me.xrLabel23.Location = New System.Drawing.Point(329, 0)
        Me.xrLabel23.Name = "xrLabel23"
        Me.xrLabel23.Size = New System.Drawing.Size(233, 18)
        Me.xrLabel23.StyleName = "DataField"
        '
        'xrLabel24
        '
        Me.xrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.TransType", "")})
        Me.xrLabel24.Location = New System.Drawing.Point(567, 0)
        Me.xrLabel24.Name = "xrLabel24"
        Me.xrLabel24.Size = New System.Drawing.Size(45, 18)
        Me.xrLabel24.StyleName = "DataField"
        Me.xrLabel24.StylePriority.UseTextAlignment = False
        Me.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel25
        '
        Me.xrLabel25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.Quantity", "")})
        Me.xrLabel25.Location = New System.Drawing.Point(717, 0)
        Me.xrLabel25.Name = "xrLabel25"
        Me.xrLabel25.Size = New System.Drawing.Size(58, 18)
        Me.xrLabel25.StyleName = "DataField"
        Me.xrLabel25.StylePriority.UseTextAlignment = False
        Me.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel26
        '
        Me.xrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.RecordDate", "{0:MM/dd/yyyy}")})
        Me.xrLabel26.Location = New System.Drawing.Point(621, 0)
        Me.xrLabel26.Name = "xrLabel26"
        Me.xrLabel26.Size = New System.Drawing.Size(88, 18)
        Me.xrLabel26.StyleName = "DataField"
        Me.xrLabel26.StylePriority.UseTextAlignment = False
        Me.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel27
        '
        Me.xrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.UnitCost", "{0:C2}")})
        Me.xrLabel27.Location = New System.Drawing.Point(779, 0)
        Me.xrLabel27.Name = "xrLabel27"
        Me.xrLabel27.Size = New System.Drawing.Size(50, 18)
        Me.xrLabel27.StyleName = "DataField"
        Me.xrLabel27.StylePriority.UseTextAlignment = False
        Me.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel28
        '
        Me.xrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.TotalCost", "{0:C2}")})
        Me.xrLabel28.Location = New System.Drawing.Point(833, 0)
        Me.xrLabel28.Name = "xrLabel28"
        Me.xrLabel28.Size = New System.Drawing.Size(62, 18)
        Me.xrLabel28.StyleName = "DataField"
        Me.xrLabel28.StylePriority.UseTextAlignment = False
        Me.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'odbcSelectCommand1
        '
        Me.odbcSelectCommand1.CommandText = "{? = CALL ""dba"".""GetReportOutofStockTransactions""(?, ?, ?, ?)}"
        Me.odbcSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.odbcSelectCommand1.Connection = Me.odbcConnection1
        Me.odbcSelectCommand1.Parameters.AddRange(New System.Data.Odbc.OdbcParameter() {New System.Data.Odbc.OdbcParameter("@ReturnValue", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, CType(resources.GetObject("odbcSelectCommand1.Parameters"), Object)), New System.Data.Odbc.OdbcParameter("@StartDate", System.Data.Odbc.OdbcType.DateTime, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "2010-3-1"), New System.Data.Odbc.OdbcParameter("@EndDate", System.Data.Odbc.OdbcType.DateTime, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "2010-3-31"), New System.Data.Odbc.OdbcParameter("@TransType", System.Data.Odbc.OdbcType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "%"), New System.Data.Odbc.OdbcParameter("@JobID", System.Data.Odbc.OdbcType.NVarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "%")})
        '
        'odbcConnection1
        '
        Me.odbcConnection1.ConnectionString = "Dsn=GmechDB"
        '
        'odbcDataAdapter1
        '
        Me.odbcDataAdapter1.SelectCommand = Me.odbcSelectCommand1
        '
        'outofStockTransactions1
        '
        Me.outofStockTransactions1.DataSetName = "OutofStockTransactions"
        Me.outofStockTransactions1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.EndDate.Value = New Date(2010, 3, 31, 0, 0, 0, 0)
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
        Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel4, Me.xrLabel5, Me.xrLabel6, Me.xrLabel39, Me.xrLabel3, Me.xrLabel1, Me.xrLabel29})
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("JobDesc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("JobID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("JobBarcode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand1.Height = 77
        Me.groupHeaderBand1.Level = 2
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        '
        'xrLabel4
        '
        Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.JobDesc", "")})
        Me.xrLabel4.Location = New System.Drawing.Point(175, 50)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Size = New System.Drawing.Size(117, 23)
        Me.xrLabel4.StyleName = "DataField"
        '
        'xrLabel5
        '
        Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.JobID", "")})
        Me.xrLabel5.Location = New System.Drawing.Point(304, 50)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Size = New System.Drawing.Size(62, 23)
        Me.xrLabel5.StyleName = "DataField"
        '
        'xrLabel6
        '
        Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.JobBarcode", "")})
        Me.xrLabel6.Location = New System.Drawing.Point(379, 50)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Size = New System.Drawing.Size(98, 23)
        Me.xrLabel6.StyleName = "DataField"
        '
        'xrLabel39
        '
        Me.xrLabel39.Location = New System.Drawing.Point(8, 50)
        Me.xrLabel39.Multiline = True
        Me.xrLabel39.Name = "xrLabel39"
        Me.xrLabel39.Size = New System.Drawing.Size(160, 25)
        Me.xrLabel39.StyleName = "FieldCaption"
        Me.xrLabel39.Text = "Job Desc / ID / Barcode:"
        '
        'xrLabel3
        '
        Me.xrLabel3.ForeColor = System.Drawing.Color.Black
        Me.xrLabel3.Location = New System.Drawing.Point(292, 50)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Size = New System.Drawing.Size(12, 18)
        Me.xrLabel3.StyleName = "FieldCaption"
        Me.xrLabel3.StylePriority.UseForeColor = False
        Me.xrLabel3.Text = "/"
        '
        'xrLabel1
        '
        Me.xrLabel1.ForeColor = System.Drawing.Color.Black
        Me.xrLabel1.Location = New System.Drawing.Point(367, 50)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Size = New System.Drawing.Size(12, 18)
        Me.xrLabel1.StyleName = "FieldCaption"
        Me.xrLabel1.StylePriority.UseForeColor = False
        Me.xrLabel1.Text = "/"
        '
        'xrLabel29
        '
        Me.xrLabel29.Location = New System.Drawing.Point(8, 4)
        Me.xrLabel29.Name = "xrLabel29"
        Me.xrLabel29.Size = New System.Drawing.Size(888, 33)
        Me.xrLabel29.StyleName = "Title"
        Me.xrLabel29.Text = "Out of Stock Transactions Report"
        '
        'groupHeaderBand2
        '
        Me.groupHeaderBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel10, Me.xrLabel11, Me.xrLabel12, Me.xrLabel2, Me.xrLabel7, Me.xrLabel8})
        Me.groupHeaderBand2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("LocDesc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("LocationID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("LocBarcode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand2.Height = 33
        Me.groupHeaderBand2.Level = 1
        Me.groupHeaderBand2.Name = "groupHeaderBand2"
        '
        'xrLabel10
        '
        Me.xrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.LocDesc", "")})
        Me.xrLabel10.Location = New System.Drawing.Point(233, 8)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Size = New System.Drawing.Size(117, 23)
        Me.xrLabel10.StyleName = "DataField"
        '
        'xrLabel11
        '
        Me.xrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.LocationID", "")})
        Me.xrLabel11.Location = New System.Drawing.Point(362, 8)
        Me.xrLabel11.Name = "xrLabel11"
        Me.xrLabel11.Size = New System.Drawing.Size(67, 23)
        Me.xrLabel11.StyleName = "DataField"
        '
        'xrLabel12
        '
        Me.xrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.LocBarcode", "")})
        Me.xrLabel12.Location = New System.Drawing.Point(450, 8)
        Me.xrLabel12.Name = "xrLabel12"
        Me.xrLabel12.Size = New System.Drawing.Size(85, 23)
        Me.xrLabel12.StyleName = "DataField"
        '
        'xrLabel2
        '
        Me.xrLabel2.Location = New System.Drawing.Point(38, 8)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Size = New System.Drawing.Size(194, 25)
        Me.xrLabel2.StyleName = "FieldCaption"
        Me.xrLabel2.Text = "Location Desc / ID / Barcode:"
        '
        'xrLabel7
        '
        Me.xrLabel7.ForeColor = System.Drawing.Color.Black
        Me.xrLabel7.Location = New System.Drawing.Point(350, 8)
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Size = New System.Drawing.Size(12, 18)
        Me.xrLabel7.StyleName = "FieldCaption"
        Me.xrLabel7.StylePriority.UseForeColor = False
        Me.xrLabel7.Text = "/"
        '
        'xrLabel8
        '
        Me.xrLabel8.ForeColor = System.Drawing.Color.Black
        Me.xrLabel8.Location = New System.Drawing.Point(433, 8)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Size = New System.Drawing.Size(12, 18)
        Me.xrLabel8.StyleName = "FieldCaption"
        Me.xrLabel8.StylePriority.UseForeColor = False
        Me.xrLabel8.Text = "/"
        '
        'groupHeaderBand3
        '
        Me.groupHeaderBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel13, Me.xrLabel14, Me.xrLabel15, Me.xrLabel16, Me.xrLabel17, Me.xrLabel18, Me.xrLabel19, Me.xrLabel20, Me.xrLine1, Me.xrLine2})
        Me.groupHeaderBand3.Height = 42
        Me.groupHeaderBand3.Name = "groupHeaderBand3"
        '
        'xrLabel13
        '
        Me.xrLabel13.Location = New System.Drawing.Point(67, 4)
        Me.xrLabel13.Name = "xrLabel13"
        Me.xrLabel13.Size = New System.Drawing.Size(113, 18)
        Me.xrLabel13.StyleName = "FieldCaption"
        Me.xrLabel13.Text = "Item ID"
        '
        'xrLabel14
        '
        Me.xrLabel14.Location = New System.Drawing.Point(183, 4)
        Me.xrLabel14.Name = "xrLabel14"
        Me.xrLabel14.Size = New System.Drawing.Size(142, 18)
        Me.xrLabel14.StyleName = "FieldCaption"
        Me.xrLabel14.Text = "Size"
        '
        'xrLabel15
        '
        Me.xrLabel15.Location = New System.Drawing.Point(329, 4)
        Me.xrLabel15.Name = "xrLabel15"
        Me.xrLabel15.Size = New System.Drawing.Size(229, 18)
        Me.xrLabel15.StyleName = "FieldCaption"
        Me.xrLabel15.Text = "Item Desc"
        '
        'xrLabel16
        '
        Me.xrLabel16.Location = New System.Drawing.Point(567, 4)
        Me.xrLabel16.Name = "xrLabel16"
        Me.xrLabel16.Size = New System.Drawing.Size(46, 33)
        Me.xrLabel16.StyleName = "FieldCaption"
        Me.xrLabel16.StylePriority.UseTextAlignment = False
        Me.xrLabel16.Text = "Trans Type"
        Me.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel17
        '
        Me.xrLabel17.Location = New System.Drawing.Point(717, 4)
        Me.xrLabel17.Name = "xrLabel17"
        Me.xrLabel17.Size = New System.Drawing.Size(58, 18)
        Me.xrLabel17.StyleName = "FieldCaption"
        Me.xrLabel17.StylePriority.UseTextAlignment = False
        Me.xrLabel17.Text = "Quantity"
        Me.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel18
        '
        Me.xrLabel18.Location = New System.Drawing.Point(621, 4)
        Me.xrLabel18.Name = "xrLabel18"
        Me.xrLabel18.Size = New System.Drawing.Size(87, 18)
        Me.xrLabel18.StyleName = "FieldCaption"
        Me.xrLabel18.Text = "Record Date"
        '
        'xrLabel19
        '
        Me.xrLabel19.Location = New System.Drawing.Point(779, 4)
        Me.xrLabel19.Name = "xrLabel19"
        Me.xrLabel19.Size = New System.Drawing.Size(50, 33)
        Me.xrLabel19.StyleName = "FieldCaption"
        Me.xrLabel19.StylePriority.UseTextAlignment = False
        Me.xrLabel19.Text = "Unit Cost"
        Me.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel20
        '
        Me.xrLabel20.Location = New System.Drawing.Point(833, 4)
        Me.xrLabel20.Name = "xrLabel20"
        Me.xrLabel20.Size = New System.Drawing.Size(62, 33)
        Me.xrLabel20.StyleName = "FieldCaption"
        Me.xrLabel20.StylePriority.UseTextAlignment = False
        Me.xrLabel20.Text = "Total Cost"
        Me.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLine1
        '
        Me.xrLine1.Location = New System.Drawing.Point(67, 0)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.Size = New System.Drawing.Size(828, 2)
        '
        'xrLine2
        '
        Me.xrLine2.Location = New System.Drawing.Point(67, 38)
        Me.xrLine2.Name = "xrLine2"
        Me.xrLine2.Size = New System.Drawing.Size(828, 2)
        '
        'pageFooterBand1
        '
        Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrPageInfo2})
        Me.pageFooterBand1.Height = 29
        Me.pageFooterBand1.Name = "pageFooterBand1"
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.Format = "{0:dddd, dd MMMM yyyy hh:mm tt}"
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
        'groupFooterBand1
        '
        Me.groupFooterBand1.Height = 1
        Me.groupFooterBand1.Name = "groupFooterBand1"
        '
        'groupFooterBand3
        '
        Me.groupFooterBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel33, Me.xrLabel34, Me.xrLabel35, Me.xrLine3})
        Me.groupFooterBand3.Height = 25
        Me.groupFooterBand3.Level = 2
        Me.groupFooterBand3.Name = "groupFooterBand3"
        Me.groupFooterBand3.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        '
        'xrLabel33
        '
        Me.xrLabel33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.Quantity", "")})
        Me.xrLabel33.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.xrLabel33.Location = New System.Drawing.Point(712, 4)
        Me.xrLabel33.Name = "xrLabel33"
        Me.xrLabel33.Size = New System.Drawing.Size(67, 18)
        Me.xrLabel33.StyleName = "FieldCaption"
        Me.xrLabel33.StylePriority.UseFont = False
        Me.xrLabel33.StylePriority.UseForeColor = False
        Me.xrLabel33.StylePriority.UseTextAlignment = False
        xrSummary1.IgnoreNullValues = True
        xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel33.Summary = xrSummary1
        Me.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel34
        '
        Me.xrLabel34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.TotalCost", "{0:C2}")})
        Me.xrLabel34.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.xrLabel34.Location = New System.Drawing.Point(825, 4)
        Me.xrLabel34.Name = "xrLabel34"
        Me.xrLabel34.Size = New System.Drawing.Size(73, 18)
        Me.xrLabel34.StyleName = "FieldCaption"
        Me.xrLabel34.StylePriority.UseFont = False
        Me.xrLabel34.StylePriority.UseForeColor = False
        Me.xrLabel34.StylePriority.UseTextAlignment = False
        xrSummary2.FormatString = "{0:C2}"
        xrSummary2.IgnoreNullValues = True
        xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel34.Summary = xrSummary2
        Me.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel35
        '
        Me.xrLabel35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.xrLabel35.Location = New System.Drawing.Point(538, 4)
        Me.xrLabel35.Name = "xrLabel35"
        Me.xrLabel35.Size = New System.Drawing.Size(160, 18)
        Me.xrLabel35.StyleName = "FieldCaption"
        Me.xrLabel35.StylePriority.UseForeColor = False
        Me.xrLabel35.Text = "Job Total"
        '
        'xrLine3
        '
        Me.xrLine3.Location = New System.Drawing.Point(538, 0)
        Me.xrLine3.Name = "xrLine3"
        Me.xrLine3.Size = New System.Drawing.Size(357, 2)
        '
        'ReportOutofStockTransactions
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.groupHeaderBand1, Me.groupHeaderBand2, Me.groupHeaderBand3, Me.pageFooterBand1, Me.groupFooterBand3})
        Me.DataAdapter = Me.odbcDataAdapter1
        Me.DataMember = "Table"
        Me.DataSource = Me.outofStockTransactions1
        Me.GridSize = New System.Drawing.Size(4, 4)
        Me.Landscape = True
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.StartDate, Me.EndDate})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "9.2"
        CType(Me.outofStockTransactions1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand

#End Region

End Class