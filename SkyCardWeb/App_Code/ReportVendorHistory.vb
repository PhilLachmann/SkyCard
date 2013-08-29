Public Class ReportVendorHistory
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
    Private WithEvents TableKeyID As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents TableName As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents vendorHistory1 As VendorHistory
    Private WithEvents xrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupHeaderBand2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLine2 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Private WithEvents xrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel18 As DevExpress.XtraReports.UI.XRLabel

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "ReportVendorHistory.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.ReportVendorHistory.ResourceManager
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.odbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.odbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.odbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.TableKeyID = New DevExpress.XtraReports.Parameters.Parameter
        Me.TableName = New DevExpress.XtraReports.Parameters.Parameter
        Me.vendorHistory1 = New VendorHistory
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.groupHeaderBand2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.vendorHistory1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel13, Me.xrLabel14, Me.xrLabel15})
        Me.Detail.Height = 18
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'odbcSelectCommand1
        '
        Me.odbcSelectCommand1.CommandText = "{? = CALL ""dba"".""GetReportVendorHistory""(?, ?)}"
        Me.odbcSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.odbcSelectCommand1.Connection = Me.odbcConnection1
        Me.odbcSelectCommand1.Parameters.AddRange(New System.Data.Odbc.OdbcParameter() {New System.Data.Odbc.OdbcParameter("@ReturnValue", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, CType(resources.GetObject("odbcSelectCommand1.Parameters"), Object)), New System.Data.Odbc.OdbcParameter("@TableKeyID", System.Data.Odbc.OdbcType.NVarChar, 500, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "T397-01"), New System.Data.Odbc.OdbcParameter("@TableName", System.Data.Odbc.OdbcType.NVarChar, 500, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "Product")})
        '
        'odbcDataAdapter1
        '
        Me.odbcDataAdapter1.SelectCommand = Me.odbcSelectCommand1
        '
        'odbcConnection1
        '
        Me.odbcConnection1.ConnectionString = "Dsn=GmechDB"
        '
        'TableKeyID
        '
        Me.TableKeyID.Name = "TableKeyID"
        Me.TableKeyID.Value = "T397-01"
        '
        'TableName
        '
        Me.TableName.Name = "TableName"
        Me.TableName.Value = "Product"
        '
        'vendorHistory1
        '
        Me.vendorHistory1.DataSetName = "VendorHistory"
        Me.vendorHistory1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2, Me.xrLabel1, Me.xrLabel18, Me.xrLabel16})
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ItemID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand1.Height = 32
        Me.groupHeaderBand1.Level = 1
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        '
        'xrLabel1
        '
        Me.xrLabel1.Location = New System.Drawing.Point(6, 0)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Size = New System.Drawing.Size(135, 25)
        Me.xrLabel1.StyleName = "FieldCaption"
        Me.xrLabel1.Text = "Item ID / Item Desc:"
        '
        'xrLabel2
        '
        Me.xrLabel2.AutoWidth = True
        Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.ItemID", "")})
        Me.xrLabel2.Location = New System.Drawing.Point(150, 0)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Size = New System.Drawing.Size(92, 25)
        Me.xrLabel2.StyleName = "DataField"
        '
        'groupHeaderBand2
        '
        Me.groupHeaderBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel6, Me.xrLabel7, Me.xrLabel8, Me.xrLine1, Me.xrLine2})
        Me.groupHeaderBand2.Height = 28
        Me.groupHeaderBand2.Name = "groupHeaderBand2"
        '
        'xrLabel6
        '
        Me.xrLabel6.Location = New System.Drawing.Point(38, 4)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Size = New System.Drawing.Size(154, 18)
        Me.xrLabel6.StyleName = "FieldCaption"
        Me.xrLabel6.Text = "Comments for Product"
        '
        'xrLabel7
        '
        Me.xrLabel7.Location = New System.Drawing.Point(458, 4)
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Size = New System.Drawing.Size(92, 18)
        Me.xrLabel7.StyleName = "FieldCaption"
        Me.xrLabel7.Text = "Date Added"
        '
        'xrLabel8
        '
        Me.xrLabel8.Location = New System.Drawing.Point(562, 4)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Size = New System.Drawing.Size(79, 18)
        Me.xrLabel8.StyleName = "FieldCaption"
        Me.xrLabel8.Text = "User ID"
        '
        'xrLine1
        '
        Me.xrLine1.BackColor = System.Drawing.Color.Black
        Me.xrLine1.ForeColor = System.Drawing.Color.Black
        Me.xrLine1.Location = New System.Drawing.Point(38, 0)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.Size = New System.Drawing.Size(608, 2)
        Me.xrLine1.StylePriority.UseBackColor = False
        Me.xrLine1.StylePriority.UseForeColor = False
        '
        'xrLine2
        '
        Me.xrLine2.BackColor = System.Drawing.Color.Black
        Me.xrLine2.ForeColor = System.Drawing.Color.Black
        Me.xrLine2.Location = New System.Drawing.Point(36, 25)
        Me.xrLine2.Name = "xrLine2"
        Me.xrLine2.Size = New System.Drawing.Size(608, 2)
        Me.xrLine2.StylePriority.UseBackColor = False
        Me.xrLine2.StylePriority.UseForeColor = False
        '
        'xrLabel13
        '
        Me.xrLabel13.AutoWidth = True
        Me.xrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.RecordComment", "")})
        Me.xrLabel13.Location = New System.Drawing.Point(38, 0)
        Me.xrLabel13.Multiline = True
        Me.xrLabel13.Name = "xrLabel13"
        Me.xrLabel13.Size = New System.Drawing.Size(417, 18)
        Me.xrLabel13.StyleName = "DataField"
        '
        'xrLabel14
        '
        Me.xrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.RecordDate", "{0:MM/dd/yyyy}")})
        Me.xrLabel14.Location = New System.Drawing.Point(458, 0)
        Me.xrLabel14.Name = "xrLabel14"
        Me.xrLabel14.Size = New System.Drawing.Size(92, 18)
        Me.xrLabel14.StyleName = "DataField"
        Me.xrLabel14.StylePriority.UseTextAlignment = False
        Me.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel15
        '
        Me.xrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.UserID", "")})
        Me.xrLabel15.Location = New System.Drawing.Point(562, 0)
        Me.xrLabel15.Name = "xrLabel15"
        Me.xrLabel15.Size = New System.Drawing.Size(79, 18)
        Me.xrLabel15.StyleName = "DataField"
        '
        'xrLabel16
        '
        Me.xrLabel16.AutoWidth = True
        Me.xrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.ItemDesc", "")})
        Me.xrLabel16.Location = New System.Drawing.Point(262, 0)
        Me.xrLabel16.Name = "xrLabel16"
        Me.xrLabel16.Size = New System.Drawing.Size(296, 25)
        Me.xrLabel16.StyleName = "DataField"
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
        Me.xrPageInfo1.Size = New System.Drawing.Size(313, 23)
        Me.xrPageInfo1.StyleName = "PageInfo"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Format = "Page {0} of {1}"
        Me.xrPageInfo2.Location = New System.Drawing.Point(331, 6)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.Size = New System.Drawing.Size(313, 23)
        Me.xrPageInfo2.StyleName = "PageInfo"
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'reportHeaderBand1
        '
        Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel17})
        Me.reportHeaderBand1.Height = 42
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        '
        'xrLabel17
        '
        Me.xrLabel17.Location = New System.Drawing.Point(8, 0)
        Me.xrLabel17.Name = "xrLabel17"
        Me.xrLabel17.Size = New System.Drawing.Size(638, 33)
        Me.xrLabel17.StyleName = "Title"
        Me.xrLabel17.Text = "Vendor History"
        '
        'xrLabel18
        '
        Me.xrLabel18.ForeColor = System.Drawing.Color.Black
        Me.xrLabel18.Location = New System.Drawing.Point(246, 0)
        Me.xrLabel18.Name = "xrLabel18"
        Me.xrLabel18.Size = New System.Drawing.Size(12, 18)
        Me.xrLabel18.StyleName = "FieldCaption"
        Me.xrLabel18.StylePriority.UseForeColor = False
        Me.xrLabel18.Text = "/"
        '
        'ReportVendorHistory
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.groupHeaderBand1, Me.groupHeaderBand2, Me.pageFooterBand1, Me.reportHeaderBand1})
        Me.DataAdapter = Me.odbcDataAdapter1
        Me.DataMember = "Table"
        Me.DataSource = Me.vendorHistory1
        Me.GridSize = New System.Drawing.Size(4, 4)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.TableKeyID, Me.TableName})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "9.2"
        CType(Me.vendorHistory1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand

#End Region

End Class