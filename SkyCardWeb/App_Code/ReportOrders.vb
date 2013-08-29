Public Class ReportOrders
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
    Private WithEvents orders1 As Orders
    Private WithEvents JobID As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents StartDate As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents EndDate As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents Status As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents xrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupHeaderBand2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupHeaderBand3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLine2 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Private WithEvents xrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel12 As DevExpress.XtraReports.UI.XRLabel

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "ReportOrders.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.ReportOrders.ResourceManager
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel29 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel30 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.odbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.odbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.odbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.orders1 = New Orders
        Me.JobID = New DevExpress.XtraReports.Parameters.Parameter
        Me.StartDate = New DevExpress.XtraReports.Parameters.Parameter
        Me.EndDate = New DevExpress.XtraReports.Parameters.Parameter
        Me.Status = New DevExpress.XtraReports.Parameters.Parameter
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.groupHeaderBand2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.groupHeaderBand3 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.xrLabel31 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.orders1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel19, Me.xrLabel20, Me.xrLabel23, Me.xrLabel24, Me.xrLabel26, Me.xrLabel27, Me.xrLabel29, Me.xrLabel30, Me.xrLabel22})
        Me.Detail.Height = 19
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLabel19
        '
        Me.xrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.LineNumber", "")})
        Me.xrLabel19.Location = New System.Drawing.Point(71, 0)
        Me.xrLabel19.Name = "xrLabel19"
        Me.xrLabel19.Size = New System.Drawing.Size(54, 18)
        Me.xrLabel19.StyleName = "DataField"
        '
        'xrLabel20
        '
        Me.xrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.ItemID", "")})
        Me.xrLabel20.Location = New System.Drawing.Point(129, 0)
        Me.xrLabel20.Name = "xrLabel20"
        Me.xrLabel20.Size = New System.Drawing.Size(79, 18)
        Me.xrLabel20.StyleName = "DataField"
        '
        'xrLabel23
        '
        Me.xrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.FillQty", "")})
        Me.xrLabel23.Location = New System.Drawing.Point(529, 0)
        Me.xrLabel23.Name = "xrLabel23"
        Me.xrLabel23.Size = New System.Drawing.Size(50, 18)
        Me.xrLabel23.StyleName = "DataField"
        Me.xrLabel23.StylePriority.UseTextAlignment = False
        Me.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel24
        '
        Me.xrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.BackOrderQty", "")})
        Me.xrLabel24.Location = New System.Drawing.Point(579, 0)
        Me.xrLabel24.Name = "xrLabel24"
        Me.xrLabel24.Size = New System.Drawing.Size(79, 18)
        Me.xrLabel24.StyleName = "DataField"
        Me.xrLabel24.StylePriority.UseTextAlignment = False
        Me.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel26
        '
        Me.xrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.RecordDate", "{0:MM/dd/yyyy}")})
        Me.xrLabel26.Location = New System.Drawing.Point(662, 0)
        Me.xrLabel26.Name = "xrLabel26"
        Me.xrLabel26.Size = New System.Drawing.Size(75, 18)
        Me.xrLabel26.StyleName = "DataField"
        '
        'xrLabel27
        '
        Me.xrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.UserID", "")})
        Me.xrLabel27.Location = New System.Drawing.Point(738, 0)
        Me.xrLabel27.Name = "xrLabel27"
        Me.xrLabel27.Size = New System.Drawing.Size(62, 18)
        Me.xrLabel27.StyleName = "DataField"
        '
        'xrLabel29
        '
        Me.xrLabel29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.OrderStatus", "")})
        Me.xrLabel29.Location = New System.Drawing.Point(804, 0)
        Me.xrLabel29.Name = "xrLabel29"
        Me.xrLabel29.Size = New System.Drawing.Size(92, 18)
        Me.xrLabel29.StyleName = "DataField"
        '
        'xrLabel30
        '
        Me.xrLabel30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.ItemDesc", "")})
        Me.xrLabel30.Location = New System.Drawing.Point(212, 0)
        Me.xrLabel30.Name = "xrLabel30"
        Me.xrLabel30.Size = New System.Drawing.Size(267, 18)
        Me.xrLabel30.StyleName = "DataField"
        '
        'xrLabel22
        '
        Me.xrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.Quantity", "")})
        Me.xrLabel22.Location = New System.Drawing.Point(483, 0)
        Me.xrLabel22.Name = "xrLabel22"
        Me.xrLabel22.Size = New System.Drawing.Size(42, 18)
        Me.xrLabel22.StyleName = "DataField"
        '
        'odbcSelectCommand1
        '
        Me.odbcSelectCommand1.CommandText = "{? = CALL ""dba"".""GetReportOrders""(?, ?, ?, ?)}"
        Me.odbcSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.odbcSelectCommand1.Connection = Me.odbcConnection1
        Me.odbcSelectCommand1.Parameters.AddRange(New System.Data.Odbc.OdbcParameter() {New System.Data.Odbc.OdbcParameter("@ReturnValue", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, CType(resources.GetObject("odbcSelectCommand1.Parameters"), Object)), New System.Data.Odbc.OdbcParameter("@JobID", System.Data.Odbc.OdbcType.NVarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "J8877"), New System.Data.Odbc.OdbcParameter("@StartDate", System.Data.Odbc.OdbcType.DateTime, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "2010-05-01"), New System.Data.Odbc.OdbcParameter("@EndDate", System.Data.Odbc.OdbcType.DateTime, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "2010-05-10"), New System.Data.Odbc.OdbcParameter("@Status", System.Data.Odbc.OdbcType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "OPEN")})
        '
        'odbcConnection1
        '
        Me.odbcConnection1.ConnectionString = "Dsn=GmechDB"
        '
        'odbcDataAdapter1
        '
        Me.odbcDataAdapter1.SelectCommand = Me.odbcSelectCommand1
        '
        'orders1
        '
        Me.orders1.DataSetName = "Orders"
        Me.orders1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JobID
        '
        Me.JobID.Name = "JobID"
        Me.JobID.Value = "J8877"
        '
        'StartDate
        '
        Me.StartDate.Name = "StartDate"
        Me.StartDate.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.DateTime
        Me.StartDate.Value = New Date(2010, 5, 1, 0, 0, 0, 0)
        '
        'EndDate
        '
        Me.EndDate.Name = "EndDate"
        Me.EndDate.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.DateTime
        Me.EndDate.Value = New Date(2010, 5, 10, 0, 0, 0, 0)
        '
        'Status
        '
        Me.Status.Name = "Status"
        Me.Status.Value = "OPEN"
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
        Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2, Me.xrLabel1})
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("JobID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand1.Height = 30
        Me.groupHeaderBand1.Level = 3
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        '
        'xrLabel2
        '
        Me.xrLabel2.AutoWidth = True
        Me.xrLabel2.CanGrow = False
        Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.JobID", "")})
        Me.xrLabel2.Location = New System.Drawing.Point(63, 4)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Size = New System.Drawing.Size(183, 25)
        Me.xrLabel2.StyleName = "DataField"
        '
        'xrLabel1
        '
        Me.xrLabel1.Location = New System.Drawing.Point(8, 4)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Size = New System.Drawing.Size(52, 25)
        Me.xrLabel1.StyleName = "FieldCaption"
        Me.xrLabel1.Text = "Job ID:"
        '
        'groupHeaderBand2
        '
        Me.groupHeaderBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel4, Me.xrLabel3})
        Me.groupHeaderBand2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("OrderNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand2.Height = 43
        Me.groupHeaderBand2.Level = 1
        Me.groupHeaderBand2.Name = "groupHeaderBand2"
        '
        'xrLabel4
        '
        Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.OrderNumber", "")})
        Me.xrLabel4.Location = New System.Drawing.Point(150, 17)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Size = New System.Drawing.Size(150, 25)
        Me.xrLabel4.StyleName = "DataField"
        '
        'xrLabel3
        '
        Me.xrLabel3.Location = New System.Drawing.Point(38, 17)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Size = New System.Drawing.Size(105, 25)
        Me.xrLabel3.StyleName = "FieldCaption"
        Me.xrLabel3.Text = "Order Number:"
        '
        'groupHeaderBand3
        '
        Me.groupHeaderBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel6, Me.xrLabel7, Me.xrLabel9, Me.xrLabel10, Me.xrLabel11, Me.xrLabel13, Me.xrLabel14, Me.xrLabel17, Me.xrLine1, Me.xrLine2, Me.xrLabel16})
        Me.groupHeaderBand3.Height = 47
        Me.groupHeaderBand3.Name = "groupHeaderBand3"
        '
        'xrLabel6
        '
        Me.xrLabel6.Location = New System.Drawing.Point(71, 4)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Size = New System.Drawing.Size(54, 38)
        Me.xrLabel6.StyleName = "FieldCaption"
        Me.xrLabel6.Text = "Line Number"
        '
        'xrLabel7
        '
        Me.xrLabel7.Location = New System.Drawing.Point(129, 4)
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Size = New System.Drawing.Size(79, 18)
        Me.xrLabel7.StyleName = "FieldCaption"
        Me.xrLabel7.Text = "Item ID"
        '
        'xrLabel9
        '
        Me.xrLabel9.Location = New System.Drawing.Point(483, 4)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Size = New System.Drawing.Size(42, 18)
        Me.xrLabel9.StyleName = "FieldCaption"
        Me.xrLabel9.Text = "Qty"
        '
        'xrLabel10
        '
        Me.xrLabel10.Location = New System.Drawing.Point(529, 4)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Size = New System.Drawing.Size(49, 17)
        Me.xrLabel10.StyleName = "FieldCaption"
        Me.xrLabel10.Text = "Fill Qty"
        '
        'xrLabel11
        '
        Me.xrLabel11.Location = New System.Drawing.Point(579, 4)
        Me.xrLabel11.Multiline = True
        Me.xrLabel11.Name = "xrLabel11"
        Me.xrLabel11.Size = New System.Drawing.Size(79, 33)
        Me.xrLabel11.StyleName = "FieldCaption"
        Me.xrLabel11.StylePriority.UseTextAlignment = False
        Me.xrLabel11.Text = "Back Order Qty"
        Me.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel13
        '
        Me.xrLabel13.Location = New System.Drawing.Point(662, 4)
        Me.xrLabel13.Name = "xrLabel13"
        Me.xrLabel13.Size = New System.Drawing.Size(75, 18)
        Me.xrLabel13.StyleName = "FieldCaption"
        Me.xrLabel13.Text = "Date"
        '
        'xrLabel14
        '
        Me.xrLabel14.Location = New System.Drawing.Point(738, 4)
        Me.xrLabel14.Name = "xrLabel14"
        Me.xrLabel14.Size = New System.Drawing.Size(62, 18)
        Me.xrLabel14.StyleName = "FieldCaption"
        Me.xrLabel14.Text = "User ID"
        '
        'xrLabel17
        '
        Me.xrLabel17.Location = New System.Drawing.Point(212, 4)
        Me.xrLabel17.Name = "xrLabel17"
        Me.xrLabel17.Size = New System.Drawing.Size(267, 18)
        Me.xrLabel17.StyleName = "FieldCaption"
        Me.xrLabel17.Text = "Item Desc"
        '
        'xrLine1
        '
        Me.xrLine1.Location = New System.Drawing.Point(67, 0)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.Size = New System.Drawing.Size(828, 2)
        '
        'xrLine2
        '
        Me.xrLine2.Location = New System.Drawing.Point(67, 42)
        Me.xrLine2.Name = "xrLine2"
        Me.xrLine2.Size = New System.Drawing.Size(828, 2)
        '
        'xrLabel16
        '
        Me.xrLabel16.Location = New System.Drawing.Point(804, 4)
        Me.xrLabel16.Name = "xrLabel16"
        Me.xrLabel16.Size = New System.Drawing.Size(92, 18)
        Me.xrLabel16.StyleName = "FieldCaption"
        Me.xrLabel16.Text = "Status"
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
        Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel31})
        Me.reportHeaderBand1.Height = 36
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        '
        'xrLabel31
        '
        Me.xrLabel31.Location = New System.Drawing.Point(8, 0)
        Me.xrLabel31.Name = "xrLabel31"
        Me.xrLabel31.Size = New System.Drawing.Size(888, 33)
        Me.xrLabel31.StyleName = "Title"
        Me.xrLabel31.Text = "Orders Report"
        '
        'xrLabel5
        '
        Me.xrLabel5.BackColor = System.Drawing.Color.White
        Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.LocationID", "")})
        Me.xrLabel5.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.xrLabel5.Location = New System.Drawing.Point(108, 0)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel5.Size = New System.Drawing.Size(221, 25)
        Me.xrLabel5.StylePriority.UseBackColor = False
        Me.xrLabel5.StylePriority.UseFont = False
        Me.xrLabel5.Text = "xrLabel5"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel12, Me.xrLabel5})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("LocationID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.Height = 25
        Me.GroupHeader1.Level = 2
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'xrLabel12
        '
        Me.xrLabel12.Location = New System.Drawing.Point(21, 0)
        Me.xrLabel12.Name = "xrLabel12"
        Me.xrLabel12.Size = New System.Drawing.Size(83, 25)
        Me.xrLabel12.StyleName = "FieldCaption"
        Me.xrLabel12.Text = "Location ID:"
        '
        'ReportOrders
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.groupHeaderBand1, Me.Detail, Me.groupHeaderBand2, Me.groupHeaderBand3, Me.pageFooterBand1, Me.reportHeaderBand1, Me.GroupHeader1})
        Me.DataAdapter = Me.odbcDataAdapter1
        Me.DataMember = "Table"
        Me.DataSource = Me.orders1
        Me.GridSize = New System.Drawing.Size(4, 4)
        Me.Landscape = True
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.JobID, Me.StartDate, Me.EndDate, Me.Status})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "9.2"
        CType(Me.orders1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand

#End Region

End Class