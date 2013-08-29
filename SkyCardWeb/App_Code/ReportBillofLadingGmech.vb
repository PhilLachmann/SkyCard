Public Class ReportBillofLadingGmech
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
    Private WithEvents OrderNumber As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents xrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabelPhone As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupHeaderBand2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupHeaderBand3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLine2 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Private WithEvents xrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupFooterBand1 As DevExpress.XtraReports.UI.GroupFooterBand
    Private WithEvents groupFooterBand2 As DevExpress.XtraReports.UI.GroupFooterBand
    Private WithEvents reportFooterBand1 As DevExpress.XtraReports.UI.ReportFooterBand
    Private WithEvents CityStateZip As DevExpress.XtraReports.UI.CalculatedField
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine4 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents billOfLadingGmech21 As BillOfLadingGmech2
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents frulZeroLineNo As DevExpress.XtraReports.UI.FormattingRule
    Private WithEvents frulNegNines As DevExpress.XtraReports.UI.FormattingRule
    Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine5 As DevExpress.XtraReports.UI.XRLine

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "ReportBillofLadingGmech.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.ReportBillofLadingGmech.ResourceManager
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrLabel39 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel40 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel41 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel42 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel43 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel44 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel49 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel50 = New DevExpress.XtraReports.UI.XRLabel
        Me.odbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.odbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.odbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OrderNumber = New DevExpress.XtraReports.Parameters.Parameter
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabelPhone = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.groupHeaderBand2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.groupHeaderBand3 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel28 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel29 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel30 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel31 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel36 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel37 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.xrLabel51 = New DevExpress.XtraReports.UI.XRLabel
        Me.groupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.groupFooterBand2 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.reportFooterBand1 = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.CityStateZip = New DevExpress.XtraReports.UI.CalculatedField
        Me.billOfLadingGmech21 = New BillOfLadingGmech2
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.frulZeroLineNo = New DevExpress.XtraReports.UI.FormattingRule
        Me.frulNegNines = New DevExpress.XtraReports.UI.FormattingRule
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine5 = New DevExpress.XtraReports.UI.XRLine
        CType(Me.billOfLadingGmech21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel39, Me.xrLabel40, Me.xrLabel41, Me.xrLabel42, Me.xrLabel43, Me.xrLabel44, Me.xrLabel49, Me.xrLabel50, Me.xrLabel6})
        Me.Detail.Height = 19
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLabel39
        '
        Me.xrLabel39.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.LineNumber", "")})
        Me.xrLabel39.Font = New System.Drawing.Font("Times New Roman", 7.0!)
        Me.xrLabel39.FormattingRules.Add(Me.frulZeroLineNo)
        Me.xrLabel39.Location = New System.Drawing.Point(142, 0)
        Me.xrLabel39.Name = "xrLabel39"
        Me.xrLabel39.Size = New System.Drawing.Size(21, 18)
        Me.xrLabel39.StyleName = "DataField"
        Me.xrLabel39.StylePriority.UseFont = False
        '
        'xrLabel40
        '
        Me.xrLabel40.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.ItemID", "")})
        Me.xrLabel40.Font = New System.Drawing.Font("Times New Roman", 7.0!)
        Me.xrLabel40.Location = New System.Drawing.Point(165, 0)
        Me.xrLabel40.Name = "xrLabel40"
        Me.xrLabel40.Size = New System.Drawing.Size(67, 18)
        Me.xrLabel40.StyleName = "DataField"
        Me.xrLabel40.StylePriority.UseFont = False
        '
        'xrLabel41
        '
        Me.xrLabel41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.TransType", "")})
        Me.xrLabel41.Font = New System.Drawing.Font("Times New Roman", 7.0!)
        Me.xrLabel41.Location = New System.Drawing.Point(498, 0)
        Me.xrLabel41.Name = "xrLabel41"
        Me.xrLabel41.Size = New System.Drawing.Size(38, 18)
        Me.xrLabel41.StyleName = "DataField"
        Me.xrLabel41.StylePriority.UseFont = False
        Me.xrLabel41.StylePriority.UseTextAlignment = False
        Me.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel42
        '
        Me.xrLabel42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.Quantity", "")})
        Me.xrLabel42.Font = New System.Drawing.Font("Times New Roman", 7.0!)
        Me.xrLabel42.FormattingRules.Add(Me.frulNegNines)
        Me.xrLabel42.Location = New System.Drawing.Point(413, 0)
        Me.xrLabel42.Name = "xrLabel42"
        Me.xrLabel42.Size = New System.Drawing.Size(29, 19)
        Me.xrLabel42.StyleName = "DataField"
        Me.xrLabel42.StylePriority.UseFont = False
        Me.xrLabel42.StylePriority.UseTextAlignment = False
        Me.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel43
        '
        Me.xrLabel43.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.FillQty", "")})
        Me.xrLabel43.Font = New System.Drawing.Font("Times New Roman", 7.0!)
        Me.xrLabel43.FormattingRules.Add(Me.frulNegNines)
        Me.xrLabel43.Location = New System.Drawing.Point(442, 0)
        Me.xrLabel43.Name = "xrLabel43"
        Me.xrLabel43.Size = New System.Drawing.Size(25, 18)
        Me.xrLabel43.StyleName = "DataField"
        Me.xrLabel43.StylePriority.UseFont = False
        Me.xrLabel43.StylePriority.UseTextAlignment = False
        Me.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel44
        '
        Me.xrLabel44.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.BackOrderQty", "")})
        Me.xrLabel44.Font = New System.Drawing.Font("Times New Roman", 7.0!)
        Me.xrLabel44.FormattingRules.Add(Me.frulNegNines)
        Me.xrLabel44.Location = New System.Drawing.Point(468, 0)
        Me.xrLabel44.Name = "xrLabel44"
        Me.xrLabel44.Size = New System.Drawing.Size(29, 18)
        Me.xrLabel44.StyleName = "DataField"
        Me.xrLabel44.StylePriority.UseFont = False
        Me.xrLabel44.StylePriority.UseTextAlignment = False
        Me.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel49
        '
        Me.xrLabel49.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.ItemDesc", "")})
        Me.xrLabel49.Font = New System.Drawing.Font("Times New Roman", 7.0!)
        Me.xrLabel49.Location = New System.Drawing.Point(233, 0)
        Me.xrLabel49.Name = "xrLabel49"
        Me.xrLabel49.Size = New System.Drawing.Size(175, 18)
        Me.xrLabel49.StyleName = "DataField"
        Me.xrLabel49.StylePriority.UseFont = False
        '
        'xrLabel50
        '
        Me.xrLabel50.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.RecordComment", "")})
        Me.xrLabel50.Font = New System.Drawing.Font("Times New Roman", 7.0!)
        Me.xrLabel50.Location = New System.Drawing.Point(538, 0)
        Me.xrLabel50.Name = "xrLabel50"
        Me.xrLabel50.Size = New System.Drawing.Size(108, 18)
        Me.xrLabel50.StyleName = "DataField"
        Me.xrLabel50.StylePriority.UseFont = False
        '
        'odbcSelectCommand1
        '
        Me.odbcSelectCommand1.CommandText = "{? = CALL ""dba"".""GetReportBillofLading""(?)}"
        Me.odbcSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.odbcSelectCommand1.Connection = Me.odbcConnection1
        Me.odbcSelectCommand1.Parameters.AddRange(New System.Data.Odbc.OdbcParameter() {New System.Data.Odbc.OdbcParameter("@ReturnValue", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, CType(resources.GetObject("odbcSelectCommand1.Parameters"), Object)), New System.Data.Odbc.OdbcParameter("@OrderNumber", System.Data.Odbc.OdbcType.Int, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "500018")})
        '
        'odbcConnection1
        '
        Me.odbcConnection1.ConnectionString = "Dsn=GmechDB"
        '
        'odbcDataAdapter1
        '
        Me.odbcDataAdapter1.SelectCommand = Me.odbcSelectCommand1
        '
        'OrderNumber
        '
        Me.OrderNumber.Name = "OrderNumber"
        Me.OrderNumber.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.Int32
        Me.OrderNumber.Value = 500018
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
        Me.groupHeaderBand1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CompanyName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("AddressLine1", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("AddressLine2", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("City", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("State", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("PostalCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("PrimaryPhone", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand1.Height = 3
        Me.groupHeaderBand1.Level = 2
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        Me.groupHeaderBand1.StylePriority.UseFont = False
        '
        'xrLabel8
        '
        Me.xrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.CompanyName", "")})
        Me.xrLabel8.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel8.Location = New System.Drawing.Point(33, 0)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Size = New System.Drawing.Size(283, 21)
        Me.xrLabel8.StyleName = "DataField"
        Me.xrLabel8.StylePriority.UseFont = False
        '
        'xrLabel9
        '
        Me.xrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.AddressLine1", "")})
        Me.xrLabel9.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel9.Location = New System.Drawing.Point(33, 21)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Size = New System.Drawing.Size(283, 21)
        Me.xrLabel9.StyleName = "DataField"
        Me.xrLabel9.StylePriority.UseFont = False
        '
        'xrLabel10
        '
        Me.xrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.AddressLine2", "")})
        Me.xrLabel10.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel10.Location = New System.Drawing.Point(33, 42)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.xrLabel10.Size = New System.Drawing.Size(283, 21)
        Me.xrLabel10.StyleName = "DataField"
        Me.xrLabel10.StylePriority.UseFont = False
        '
        'xrLabelPhone
        '
        Me.xrLabelPhone.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.PrimaryPhone", "")})
        Me.xrLabelPhone.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabelPhone.Location = New System.Drawing.Point(33, 84)
        Me.xrLabelPhone.Name = "xrLabelPhone"
        Me.xrLabelPhone.Size = New System.Drawing.Size(283, 21)
        Me.xrLabelPhone.StyleName = "DataField"
        Me.xrLabelPhone.StylePriority.UseFont = False
        '
        'xrLabel1
        '
        Me.xrLabel1.AutoWidth = True
        Me.xrLabel1.BackColor = System.Drawing.Color.White
        Me.xrLabel1.CanGrow = False
        Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.CityStateZip", "")})
        Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel1.Location = New System.Drawing.Point(33, 63)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.Size = New System.Drawing.Size(283, 21)
        Me.xrLabel1.StylePriority.UseBackColor = False
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.StylePriority.UseTextAlignment = False
        Me.xrLabel1.Text = "xrLabel1"
        Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.xrLabel1.WordWrap = False
        '
        'groupHeaderBand2
        '
        Me.groupHeaderBand2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("JobID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("JobDesc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("LocationID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("LocDesc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("OrderNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand2.Height = 4
        Me.groupHeaderBand2.Level = 1
        Me.groupHeaderBand2.Name = "groupHeaderBand2"
        '
        'xrLabel20
        '
        Me.xrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.JobID", "")})
        Me.xrLabel20.Location = New System.Drawing.Point(442, 0)
        Me.xrLabel20.Name = "xrLabel20"
        Me.xrLabel20.Size = New System.Drawing.Size(204, 21)
        Me.xrLabel20.StyleName = "DataField"
        '
        'xrLabel21
        '
        Me.xrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.JobDesc", "")})
        Me.xrLabel21.Location = New System.Drawing.Point(442, 21)
        Me.xrLabel21.Name = "xrLabel21"
        Me.xrLabel21.Size = New System.Drawing.Size(204, 21)
        Me.xrLabel21.StyleName = "DataField"
        '
        'xrLabel23
        '
        Me.xrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.LocDesc", "")})
        Me.xrLabel23.Location = New System.Drawing.Point(442, 42)
        Me.xrLabel23.Name = "xrLabel23"
        Me.xrLabel23.Size = New System.Drawing.Size(204, 21)
        Me.xrLabel23.StyleName = "DataField"
        '
        'xrLabel24
        '
        Me.xrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.OrderNumber", "")})
        Me.xrLabel24.Location = New System.Drawing.Point(442, 63)
        Me.xrLabel24.Name = "xrLabel24"
        Me.xrLabel24.Size = New System.Drawing.Size(204, 21)
        Me.xrLabel24.StyleName = "DataField"
        '
        'xrLabel15
        '
        Me.xrLabel15.ForeColor = System.Drawing.Color.Black
        Me.xrLabel15.Location = New System.Drawing.Point(388, 0)
        Me.xrLabel15.Name = "xrLabel15"
        Me.xrLabel15.Size = New System.Drawing.Size(51, 21)
        Me.xrLabel15.StyleName = "FieldCaption"
        Me.xrLabel15.StylePriority.UseForeColor = False
        Me.xrLabel15.Text = "Job ID:"
        '
        'xrLabel16
        '
        Me.xrLabel16.ForeColor = System.Drawing.Color.Black
        Me.xrLabel16.Location = New System.Drawing.Point(371, 21)
        Me.xrLabel16.Name = "xrLabel16"
        Me.xrLabel16.Size = New System.Drawing.Size(67, 21)
        Me.xrLabel16.StyleName = "FieldCaption"
        Me.xrLabel16.StylePriority.UseForeColor = False
        Me.xrLabel16.Text = "Job Desc:"
        '
        'xrLabel18
        '
        Me.xrLabel18.ForeColor = System.Drawing.Color.Black
        Me.xrLabel18.Location = New System.Drawing.Point(329, 42)
        Me.xrLabel18.Name = "xrLabel18"
        Me.xrLabel18.Size = New System.Drawing.Size(108, 21)
        Me.xrLabel18.StyleName = "FieldCaption"
        Me.xrLabel18.StylePriority.UseForeColor = False
        Me.xrLabel18.Text = "Location Name:"
        '
        'xrLabel19
        '
        Me.xrLabel19.ForeColor = System.Drawing.Color.Black
        Me.xrLabel19.Location = New System.Drawing.Point(338, 63)
        Me.xrLabel19.Name = "xrLabel19"
        Me.xrLabel19.Size = New System.Drawing.Size(100, 21)
        Me.xrLabel19.StyleName = "FieldCaption"
        Me.xrLabel19.StylePriority.UseForeColor = False
        Me.xrLabel19.Text = "Order Number:"
        '
        'groupHeaderBand3
        '
        Me.groupHeaderBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel26, Me.xrLabel27, Me.xrLabel28, Me.xrLabel29, Me.xrLabel30, Me.xrLabel31, Me.xrLabel36, Me.xrLabel37, Me.xrLine1, Me.xrLine2})
        Me.groupHeaderBand3.Height = 48
        Me.groupHeaderBand3.Name = "groupHeaderBand3"
        '
        'xrLabel26
        '
        Me.xrLabel26.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel26.Location = New System.Drawing.Point(142, 4)
        Me.xrLabel26.Multiline = True
        Me.xrLabel26.Name = "xrLabel26"
        Me.xrLabel26.Size = New System.Drawing.Size(21, 38)
        Me.xrLabel26.StyleName = "FieldCaption"
        Me.xrLabel26.StylePriority.UseFont = False
        Me.xrLabel26.StylePriority.UseTextAlignment = False
        Me.xrLabel26.Text = "Line No"
        Me.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLabel27
        '
        Me.xrLabel27.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel27.Location = New System.Drawing.Point(165, 4)
        Me.xrLabel27.Name = "xrLabel27"
        Me.xrLabel27.Size = New System.Drawing.Size(65, 18)
        Me.xrLabel27.StyleName = "FieldCaption"
        Me.xrLabel27.StylePriority.UseFont = False
        Me.xrLabel27.Text = "Item ID"
        '
        'xrLabel28
        '
        Me.xrLabel28.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel28.Location = New System.Drawing.Point(500, 4)
        Me.xrLabel28.Name = "xrLabel28"
        Me.xrLabel28.Size = New System.Drawing.Size(33, 38)
        Me.xrLabel28.StyleName = "FieldCaption"
        Me.xrLabel28.StylePriority.UseFont = False
        Me.xrLabel28.StylePriority.UseTextAlignment = False
        Me.xrLabel28.Text = "Trans Type"
        Me.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel29
        '
        Me.xrLabel29.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel29.Location = New System.Drawing.Point(413, 4)
        Me.xrLabel29.Name = "xrLabel29"
        Me.xrLabel29.Size = New System.Drawing.Size(29, 38)
        Me.xrLabel29.StyleName = "FieldCaption"
        Me.xrLabel29.StylePriority.UseFont = False
        Me.xrLabel29.StylePriority.UseTextAlignment = False
        Me.xrLabel29.Text = "Order Qty"
        Me.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel30
        '
        Me.xrLabel30.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel30.Location = New System.Drawing.Point(442, 4)
        Me.xrLabel30.Name = "xrLabel30"
        Me.xrLabel30.Size = New System.Drawing.Size(25, 38)
        Me.xrLabel30.StyleName = "FieldCaption"
        Me.xrLabel30.StylePriority.UseFont = False
        Me.xrLabel30.StylePriority.UseTextAlignment = False
        Me.xrLabel30.Text = "Ship Qty"
        Me.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel31
        '
        Me.xrLabel31.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel31.Location = New System.Drawing.Point(469, 4)
        Me.xrLabel31.Name = "xrLabel31"
        Me.xrLabel31.Size = New System.Drawing.Size(29, 38)
        Me.xrLabel31.StyleName = "FieldCaption"
        Me.xrLabel31.StylePriority.UseFont = False
        Me.xrLabel31.StylePriority.UseTextAlignment = False
        Me.xrLabel31.Text = "Back Order Qty"
        Me.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel36
        '
        Me.xrLabel36.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel36.Location = New System.Drawing.Point(233, 4)
        Me.xrLabel36.Name = "xrLabel36"
        Me.xrLabel36.Size = New System.Drawing.Size(175, 18)
        Me.xrLabel36.StyleName = "FieldCaption"
        Me.xrLabel36.StylePriority.UseFont = False
        Me.xrLabel36.Text = "Item Description"
        '
        'xrLabel37
        '
        Me.xrLabel37.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel37.Location = New System.Drawing.Point(533, 4)
        Me.xrLabel37.Name = "xrLabel37"
        Me.xrLabel37.Size = New System.Drawing.Size(113, 18)
        Me.xrLabel37.StyleName = "FieldCaption"
        Me.xrLabel37.StylePriority.UseFont = False
        Me.xrLabel37.Text = "Comment"
        '
        'xrLine1
        '
        Me.xrLine1.Location = New System.Drawing.Point(4, 0)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.Size = New System.Drawing.Size(642, 2)
        '
        'xrLine2
        '
        Me.xrLine2.Location = New System.Drawing.Point(4, 44)
        Me.xrLine2.Name = "xrLine2"
        Me.xrLine2.Size = New System.Drawing.Size(642, 2)
        '
        'pageFooterBand1
        '
        Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrPageInfo2})
        Me.pageFooterBand1.Height = 31
        Me.pageFooterBand1.Name = "pageFooterBand1"
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.Location = New System.Drawing.Point(6, 6)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.Size = New System.Drawing.Size(344, 23)
        Me.xrPageInfo1.StyleName = "PageInfo"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Format = "Page {0} of {1}"
        Me.xrPageInfo2.Location = New System.Drawing.Point(358, 6)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.Size = New System.Drawing.Size(292, 23)
        Me.xrPageInfo2.StyleName = "PageInfo"
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'reportHeaderBand1
        '
        Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel51})
        Me.reportHeaderBand1.Height = 51
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        '
        'xrLabel51
        '
        Me.xrLabel51.Location = New System.Drawing.Point(6, 6)
        Me.xrLabel51.Name = "xrLabel51"
        Me.xrLabel51.Size = New System.Drawing.Size(644, 33)
        Me.xrLabel51.StyleName = "Title"
        Me.xrLabel51.Text = "Bill of Lading"
        '
        'groupFooterBand1
        '
        Me.groupFooterBand1.Height = 1
        Me.groupFooterBand1.Name = "groupFooterBand1"
        '
        'groupFooterBand2
        '
        Me.groupFooterBand2.Height = 3
        Me.groupFooterBand2.Level = 1
        Me.groupFooterBand2.Name = "groupFooterBand2"
        '
        'reportFooterBand1
        '
        Me.reportFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3, Me.xrLine4, Me.xrLabel7, Me.xrLine5})
        Me.reportFooterBand1.Height = 34
        Me.reportFooterBand1.Name = "reportFooterBand1"
        Me.reportFooterBand1.PrintAtBottom = True
        '
        'xrLabel3
        '
        Me.xrLabel3.ForeColor = System.Drawing.Color.Black
        Me.xrLabel3.Location = New System.Drawing.Point(75, 4)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Size = New System.Drawing.Size(71, 18)
        Me.xrLabel3.StyleName = "FieldCaption"
        Me.xrLabel3.StylePriority.UseForeColor = False
        Me.xrLabel3.Text = "Signature:"
        '
        'xrLine4
        '
        Me.xrLine4.Location = New System.Drawing.Point(150, 21)
        Me.xrLine4.Name = "xrLine4"
        Me.xrLine4.Size = New System.Drawing.Size(325, 2)
        '
        'CityStateZip
        '
        Me.CityStateZip.DataMember = "Table"
        Me.CityStateZip.DataSource = Me.billOfLadingGmech21
        Me.CityStateZip.Expression = "[City] + ', ' + [State] + '  ' + [PostalCode]"
        Me.CityStateZip.Name = "CityStateZip"
        '
        'billOfLadingGmech21
        '
        Me.billOfLadingGmech21.DataSetName = "BillOfLadingGmech2"
        Me.billOfLadingGmech21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'xrLabel4
        '
        Me.xrLabel4.ForeColor = System.Drawing.Color.Black
        Me.xrLabel4.Location = New System.Drawing.Point(356, 84)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Size = New System.Drawing.Size(81, 21)
        Me.xrLabel4.StyleName = "FieldCaption"
        Me.xrLabel4.StylePriority.UseForeColor = False
        Me.xrLabel4.Text = "Ordered By:"
        '
        'xrLabel5
        '
        Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.OrderedBy", "")})
        Me.xrLabel5.Location = New System.Drawing.Point(442, 84)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Size = New System.Drawing.Size(204, 21)
        Me.xrLabel5.StyleName = "DataField"
        Me.xrLabel5.Text = "xrLabel5"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel8, Me.xrLabel4, Me.xrLabel20, Me.xrLabel19, Me.xrLabel23, Me.xrLabel24, Me.xrLabel15, Me.xrLabel16, Me.xrLabel18, Me.xrLabel21, Me.xrLabel1, Me.xrLabelPhone, Me.xrLabel10, Me.xrLabel9, Me.xrLabel5})
        Me.PageHeader.Height = 120
        Me.PageHeader.Name = "PageHeader"
        '
        'xrLabel6
        '
        Me.xrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.GroupLabel", "")})
        Me.xrLabel6.Font = New System.Drawing.Font("Times New Roman", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel6.Location = New System.Drawing.Point(4, 0)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Size = New System.Drawing.Size(133, 18)
        Me.xrLabel6.StyleName = "DataField"
        Me.xrLabel6.StylePriority.UseBackColor = False
        Me.xrLabel6.StylePriority.UseFont = False
        Me.xrLabel6.Text = "xrLabel6"
        Me.xrLabel6.WordWrap = False
        '
        'frulZeroLineNo
        '
        Me.frulZeroLineNo.Condition = "[LineNumber] == 0"
        '
        '
        '
        Me.frulZeroLineNo.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.frulZeroLineNo.Name = "frulZeroLineNo"
        '
        'frulNegNines
        '
        Me.frulNegNines.Condition = "[BackOrderQty] == -999  And [FillQty] == -999 And [Quantity] == -999"
        '
        '
        '
        Me.frulNegNines.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.frulNegNines.Name = "frulNegNines"
        '
        'xrLabel7
        '
        Me.xrLabel7.ForeColor = System.Drawing.Color.Black
        Me.xrLabel7.Location = New System.Drawing.Point(492, 4)
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Size = New System.Drawing.Size(38, 18)
        Me.xrLabel7.StyleName = "FieldCaption"
        Me.xrLabel7.StylePriority.UseForeColor = False
        Me.xrLabel7.Text = "Date:"
        '
        'xrLine5
        '
        Me.xrLine5.Location = New System.Drawing.Point(533, 21)
        Me.xrLine5.Name = "xrLine5"
        Me.xrLine5.Size = New System.Drawing.Size(112, 2)
        '
        'ReportBillofLadingGmech
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.groupHeaderBand1, Me.Detail, Me.groupHeaderBand2, Me.groupHeaderBand3, Me.pageFooterBand1, Me.reportHeaderBand1, Me.groupFooterBand2, Me.reportFooterBand1, Me.PageHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CityStateZip})
        Me.DataAdapter = Me.odbcDataAdapter1
        Me.DataMember = "Table"
        Me.DataSource = Me.billOfLadingGmech21
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.frulZeroLineNo, Me.frulNegNines})
        Me.GridSize = New System.Drawing.Size(4, 4)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.OrderNumber})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "9.2"
        CType(Me.billOfLadingGmech21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand

#End Region

    Private Sub xrLabelPhone_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrLabelPhone.BeforePrint
        Dim l As DevExpress.XtraReports.UI.XRLabel = CType(sender, DevExpress.XtraReports.UI.XRLabel)
        Dim i As Long = Convert.ToInt64(l.Text)
        If (i > 0) Then
            l.Text = i.ToString("(###) ###-####")
        Else
            l.Text = "-"
        End If

    End Sub
End Class