Public Class ReportJobProducts
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
    Private WithEvents odbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Private WithEvents odbcConnection1 As System.Data.Odbc.OdbcConnection
    Private WithEvents dataSet11 As DataSet1
    Private WithEvents JobID As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents JobDesc As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents JobBarcode As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupHeaderBand2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLine2 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Private WithEvents xrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents GroupHeaderLocation As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel23 As DevExpress.XtraReports.UI.XRLabel

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "ReportJobProducts.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.ReportJobProducts.ResourceManager
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.odbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.odbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.odbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.dataSet11 = New DataSet1
        Me.JobID = New DevExpress.XtraReports.Parameters.Parameter
        Me.JobDesc = New DevExpress.XtraReports.Parameters.Parameter
        Me.JobBarcode = New DevExpress.XtraReports.Parameters.Parameter
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.groupHeaderBand2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeaderLocation = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel13, Me.xrLabel14, Me.xrLabel15, Me.xrLabel12, Me.xrLabel23})
        Me.Detail.Height = 25
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLabel13
        '
        Me.xrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.ItemID", "")})
        Me.xrLabel13.Location = New System.Drawing.Point(46, 0)
        Me.xrLabel13.Name = "xrLabel13"
        Me.xrLabel13.Size = New System.Drawing.Size(88, 23)
        Me.xrLabel13.StyleName = "DataField"
        '
        'xrLabel14
        '
        Me.xrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.ItemDesc", "")})
        Me.xrLabel14.Location = New System.Drawing.Point(375, 0)
        Me.xrLabel14.Name = "xrLabel14"
        Me.xrLabel14.Size = New System.Drawing.Size(308, 23)
        Me.xrLabel14.StyleName = "DataField"
        '
        'xrLabel15
        '
        Me.xrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.QuantityOnHand", "")})
        Me.xrLabel15.Location = New System.Drawing.Point(692, 0)
        Me.xrLabel15.Name = "xrLabel15"
        Me.xrLabel15.Size = New System.Drawing.Size(92, 23)
        Me.xrLabel15.StyleName = "DataField"
        Me.xrLabel15.StylePriority.UseTextAlignment = False
        Me.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel12
        '
        Me.xrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.LastModified", "{0:MM/dd/yyyy}")})
        Me.xrLabel12.Location = New System.Drawing.Point(792, 0)
        Me.xrLabel12.Name = "xrLabel12"
        Me.xrLabel12.Size = New System.Drawing.Size(96, 23)
        Me.xrLabel12.StyleName = "DataField"
        '
        'xrLabel23
        '
        Me.xrLabel23.BackColor = System.Drawing.Color.White
        Me.xrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.UOM", "")})
        Me.xrLabel23.Location = New System.Drawing.Point(138, 0)
        Me.xrLabel23.Name = "xrLabel23"
        Me.xrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel23.Size = New System.Drawing.Size(233, 25)
        Me.xrLabel23.StylePriority.UseBackColor = False
        Me.xrLabel23.Text = "xrLabel23"
        '
        'xrLabel11
        '
        Me.xrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.JobBarcode", "")})
        Me.xrLabel11.Location = New System.Drawing.Point(396, 0)
        Me.xrLabel11.Name = "xrLabel11"
        Me.xrLabel11.Size = New System.Drawing.Size(98, 21)
        Me.xrLabel11.StyleName = "DataField"
        '
        'odbcSelectCommand1
        '
        Me.odbcSelectCommand1.CommandText = "{? = CALL ""dba"".""GetReportJobProducts""(?, ?, ?)}"
        Me.odbcSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.odbcSelectCommand1.Connection = Me.odbcConnection1
        Me.odbcSelectCommand1.Parameters.AddRange(New System.Data.Odbc.OdbcParameter() {New System.Data.Odbc.OdbcParameter("@ReturnValue", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, CType(resources.GetObject("odbcSelectCommand1.Parameters"), Object)), New System.Data.Odbc.OdbcParameter("@JobID", System.Data.Odbc.OdbcType.VarChar, 2147483647, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "J8877%"), New System.Data.Odbc.OdbcParameter("@JobDesc", System.Data.Odbc.OdbcType.VarChar, 2147483647, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "%"), New System.Data.Odbc.OdbcParameter("@JobBarcode", System.Data.Odbc.OdbcType.VarChar, 2147483647, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "%")})
        '
        'odbcConnection1
        '
        Me.odbcConnection1.ConnectionString = "Dsn=GmechDB"
        '
        'odbcDataAdapter1
        '
        Me.odbcDataAdapter1.SelectCommand = Me.odbcSelectCommand1
        '
        'dataSet11
        '
        Me.dataSet11.DataSetName = "DataSet1"
        Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JobID
        '
        Me.JobID.Name = "JobID"
        Me.JobID.Value = "J8877%"
        '
        'JobDesc
        '
        Me.JobDesc.Name = "JobDesc"
        Me.JobDesc.Value = "%"
        '
        'JobBarcode
        '
        Me.JobBarcode.Name = "JobBarcode"
        Me.JobBarcode.Value = "%"
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
        Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2, Me.xrLabel1, Me.xrLabel10, Me.xrLabel11, Me.xrLabel3, Me.xrLabel17})
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("JobDesc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand1.Height = 29
        Me.groupHeaderBand1.Level = 2
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        '
        'xrLabel2
        '
        Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.JobID", "")})
        Me.xrLabel2.Location = New System.Drawing.Point(312, 0)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Size = New System.Drawing.Size(62, 21)
        Me.xrLabel2.StyleName = "DataField"
        '
        'xrLabel1
        '
        Me.xrLabel1.Location = New System.Drawing.Point(6, 0)
        Me.xrLabel1.Multiline = True
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Size = New System.Drawing.Size(160, 25)
        Me.xrLabel1.StyleName = "FieldCaption"
        Me.xrLabel1.Text = "Job Desc / ID / Barcode:"
        '
        'xrLabel10
        '
        Me.xrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.JobDesc", "")})
        Me.xrLabel10.Location = New System.Drawing.Point(175, 0)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Size = New System.Drawing.Size(117, 23)
        Me.xrLabel10.StyleName = "DataField"
        '
        'xrLabel3
        '
        Me.xrLabel3.ForeColor = System.Drawing.Color.Black
        Me.xrLabel3.Location = New System.Drawing.Point(296, 0)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Size = New System.Drawing.Size(12, 18)
        Me.xrLabel3.StyleName = "FieldCaption"
        Me.xrLabel3.StylePriority.UseForeColor = False
        Me.xrLabel3.Text = "/"
        '
        'xrLabel17
        '
        Me.xrLabel17.ForeColor = System.Drawing.Color.Black
        Me.xrLabel17.Location = New System.Drawing.Point(379, 0)
        Me.xrLabel17.Name = "xrLabel17"
        Me.xrLabel17.Size = New System.Drawing.Size(12, 18)
        Me.xrLabel17.StyleName = "FieldCaption"
        Me.xrLabel17.StylePriority.UseForeColor = False
        Me.xrLabel17.Text = "/"
        '
        'groupHeaderBand2
        '
        Me.groupHeaderBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel5, Me.xrLabel7, Me.xrLabel8, Me.xrLabel9, Me.xrLine1, Me.xrLine2, Me.xrLabel22})
        Me.groupHeaderBand2.Height = 34
        Me.groupHeaderBand2.Name = "groupHeaderBand2"
        '
        'xrLabel5
        '
        Me.xrLabel5.Location = New System.Drawing.Point(792, 8)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Size = New System.Drawing.Size(96, 18)
        Me.xrLabel5.StyleName = "FieldCaption"
        Me.xrLabel5.Text = "Last Modified"
        '
        'xrLabel7
        '
        Me.xrLabel7.Location = New System.Drawing.Point(42, 8)
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Size = New System.Drawing.Size(92, 18)
        Me.xrLabel7.StyleName = "FieldCaption"
        Me.xrLabel7.Text = "Item ID"
        '
        'xrLabel8
        '
        Me.xrLabel8.Location = New System.Drawing.Point(375, 8)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Size = New System.Drawing.Size(308, 18)
        Me.xrLabel8.StyleName = "FieldCaption"
        Me.xrLabel8.Text = "Item Desc"
        '
        'xrLabel9
        '
        Me.xrLabel9.Location = New System.Drawing.Point(692, 8)
        Me.xrLabel9.Multiline = True
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Size = New System.Drawing.Size(92, 18)
        Me.xrLabel9.StyleName = "FieldCaption"
        Me.xrLabel9.Text = "Qty On Hand" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'xrLine1
        '
        Me.xrLine1.Location = New System.Drawing.Point(42, 4)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.Size = New System.Drawing.Size(846, 2)
        '
        'xrLine2
        '
        Me.xrLine2.Location = New System.Drawing.Point(42, 29)
        Me.xrLine2.Name = "xrLine2"
        Me.xrLine2.Size = New System.Drawing.Size(846, 2)
        '
        'xrLabel22
        '
        Me.xrLabel22.Location = New System.Drawing.Point(138, 8)
        Me.xrLabel22.Name = "xrLabel22"
        Me.xrLabel22.Size = New System.Drawing.Size(233, 18)
        Me.xrLabel22.StyleName = "FieldCaption"
        Me.xrLabel22.Text = "Size"
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
        Me.xrPageInfo1.Size = New System.Drawing.Size(313, 23)
        Me.xrPageInfo1.StyleName = "PageInfo"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Format = "Page {0} of {1}"
        Me.xrPageInfo2.Location = New System.Drawing.Point(583, 8)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.Size = New System.Drawing.Size(313, 23)
        Me.xrPageInfo2.StyleName = "PageInfo"
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'reportHeaderBand1
        '
        Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel16})
        Me.reportHeaderBand1.Height = 46
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        '
        'xrLabel16
        '
        Me.xrLabel16.Location = New System.Drawing.Point(4, 0)
        Me.xrLabel16.Name = "xrLabel16"
        Me.xrLabel16.Size = New System.Drawing.Size(638, 33)
        Me.xrLabel16.StyleName = "Title"
        Me.xrLabel16.Text = "Job Products Report"
        '
        'GroupHeaderLocation
        '
        Me.GroupHeaderLocation.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel4, Me.xrLabel6, Me.xrLabel18, Me.xrLabel19, Me.xrLabel20, Me.xrLabel21})
        Me.GroupHeaderLocation.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("LocDesc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeaderLocation.Height = 27
        Me.GroupHeaderLocation.Level = 1
        Me.GroupHeaderLocation.Name = "GroupHeaderLocation"
        '
        'xrLabel4
        '
        Me.xrLabel4.Location = New System.Drawing.Point(25, 0)
        Me.xrLabel4.Multiline = True
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Size = New System.Drawing.Size(196, 25)
        Me.xrLabel4.StyleName = "FieldCaption"
        Me.xrLabel4.Text = "Location Desc / ID / Barcode:"
        '
        'xrLabel6
        '
        Me.xrLabel6.ForeColor = System.Drawing.Color.Black
        Me.xrLabel6.Location = New System.Drawing.Point(346, 0)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Size = New System.Drawing.Size(12, 18)
        Me.xrLabel6.StyleName = "FieldCaption"
        Me.xrLabel6.StylePriority.UseForeColor = False
        Me.xrLabel6.Text = "/"
        '
        'xrLabel18
        '
        Me.xrLabel18.ForeColor = System.Drawing.Color.Black
        Me.xrLabel18.Location = New System.Drawing.Point(429, 0)
        Me.xrLabel18.Name = "xrLabel18"
        Me.xrLabel18.Size = New System.Drawing.Size(12, 18)
        Me.xrLabel18.StyleName = "FieldCaption"
        Me.xrLabel18.StylePriority.UseForeColor = False
        Me.xrLabel18.Text = "/"
        '
        'xrLabel19
        '
        Me.xrLabel19.BackColor = System.Drawing.Color.White
        Me.xrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.LocDesc", "")})
        Me.xrLabel19.Location = New System.Drawing.Point(225, 0)
        Me.xrLabel19.Name = "xrLabel19"
        Me.xrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel19.Size = New System.Drawing.Size(117, 23)
        Me.xrLabel19.StylePriority.UseBackColor = False
        Me.xrLabel19.Text = "xrLabel19"
        '
        'xrLabel20
        '
        Me.xrLabel20.BackColor = System.Drawing.Color.White
        Me.xrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.LocationID", "")})
        Me.xrLabel20.Location = New System.Drawing.Point(362, 0)
        Me.xrLabel20.Name = "xrLabel20"
        Me.xrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel20.Size = New System.Drawing.Size(62, 23)
        Me.xrLabel20.StylePriority.UseBackColor = False
        Me.xrLabel20.Text = "xrLabel20"
        '
        'xrLabel21
        '
        Me.xrLabel21.BackColor = System.Drawing.Color.White
        Me.xrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.LocBarcode", "")})
        Me.xrLabel21.Location = New System.Drawing.Point(446, 0)
        Me.xrLabel21.Name = "xrLabel21"
        Me.xrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel21.Size = New System.Drawing.Size(98, 23)
        Me.xrLabel21.StylePriority.UseBackColor = False
        Me.xrLabel21.Text = "xrLabel21"
        '
        'ReportJobProducts
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.GroupHeaderLocation, Me.groupHeaderBand1, Me.groupHeaderBand2, Me.pageFooterBand1, Me.reportHeaderBand1})
        Me.DataAdapter = Me.odbcDataAdapter1
        Me.DataMember = "Table"
        Me.DataSource = Me.dataSet11
        Me.GridSize = New System.Drawing.Size(4, 4)
        Me.Landscape = True
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.JobID, Me.JobDesc, Me.JobBarcode})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "9.2"
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand

#End Region

    Private Sub odbcDataAdapter1_RowUpdated(ByVal sender As System.Object, ByVal e As System.Data.Odbc.OdbcRowUpdatedEventArgs) Handles odbcDataAdapter1.RowUpdated

    End Sub
End Class