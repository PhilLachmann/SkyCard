Imports System.Data
Public Class ReportAssetByLocationFlex
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
    Private WithEvents assetByLocationFlex1 As AssetByLocationFlex
    Private WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Private WithEvents xrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Private WithEvents bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Private WithEvents xrLocDesc As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrParentDesc As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid
    Private WithEvents fieldTagNumber As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Private WithEvents fieldTagName As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Private WithEvents fieldTagValue As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Private WithEvents fieldParentDesc As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Private WithEvents fieldLocDesc As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Private WithEvents groupFooterBand1 As DevExpress.XtraReports.UI.GroupFooterBand
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "ReportAssetByLocationFlex.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.ReportAssetByLocationFlex.ResourceManager
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.odbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.odbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.odbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.assetByLocationFlex1 = New AssetByLocationFlex
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLocDesc = New DevExpress.XtraReports.UI.XRLabel
        Me.xrParentDesc = New DevExpress.XtraReports.UI.XRLabel
        Me.xrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid
        Me.fieldTagNumber = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.fieldTagName = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.fieldTagValue = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.fieldParentDesc = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.fieldLocDesc = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.groupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        CType(Me.assetByLocationFlex1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "DataField"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'odbcSelectCommand1
        '
        Me.odbcSelectCommand1.CommandText = "{? = CALL ""dba"".""GetAssetsByLocationFlexReport""(?, ?)}"
        Me.odbcSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.odbcSelectCommand1.Connection = Me.odbcConnection1
        Me.odbcSelectCommand1.Parameters.AddRange(New System.Data.Odbc.OdbcParameter() {New System.Data.Odbc.OdbcParameter("@ReturnValue", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, CType(resources.GetObject("odbcSelectCommand1.Parameters"), Object)), New System.Data.Odbc.OdbcParameter("theLocationID", System.Data.Odbc.OdbcType.Int, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "13"), New System.Data.Odbc.OdbcParameter("theTagNameIDList", System.Data.Odbc.OdbcType.NVarChar, 2000)})
        '
        'odbcConnection1
        '
        Me.odbcConnection1.ConnectionString = "Dsn=CaseMgmt;userid=dba;"
        '
        'odbcDataAdapter1
        '
        Me.odbcDataAdapter1.SelectCommand = Me.odbcSelectCommand1
        '
        'assetByLocationFlex1
        '
        Me.assetByLocationFlex1.DataSetName = "AssetByLocationFlex"
        Me.assetByLocationFlex1.EnforceConstraints = False
        Me.assetByLocationFlex1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1, Me.xrLocDesc, Me.xrParentDesc})
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ParentDesc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("LocDesc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand1.HeightF = 24.54163!
        Me.groupHeaderBand1.KeepTogether = True
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        '
        'xrLabel1
        '
        Me.xrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(452.0!, 0.0!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(36.0!, 20.00002!)
        Me.xrLabel1.StyleName = "FieldCaption"
        Me.xrLabel1.StylePriority.UseBackColor = False
        Me.xrLabel1.Text = "Loc:"
        '
        'xrLocDesc
        '
        Me.xrLocDesc.BackColor = System.Drawing.Color.Transparent
        Me.xrLocDesc.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.LocDesc")})
        Me.xrLocDesc.LocationFloat = New DevExpress.Utils.PointFloat(491.9999!, 0.0!)
        Me.xrLocDesc.Name = "xrLocDesc"
        Me.xrLocDesc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLocDesc.SizeF = New System.Drawing.SizeF(387.9999!, 20.00001!)
        Me.xrLocDesc.StyleName = "FieldCaption"
        Me.xrLocDesc.StylePriority.UseBackColor = False
        Me.xrLocDesc.Text = "Loc Desc"
        '
        'xrParentDesc
        '
        Me.xrParentDesc.BackColor = System.Drawing.Color.Transparent
        Me.xrParentDesc.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.ParentDesc")})
        Me.xrParentDesc.LocationFloat = New DevExpress.Utils.PointFloat(3.999996!, 0.0!)
        Me.xrParentDesc.Name = "xrParentDesc"
        Me.xrParentDesc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrParentDesc.SizeF = New System.Drawing.SizeF(444.0!, 20.00001!)
        Me.xrParentDesc.StyleName = "FieldCaption"
        Me.xrParentDesc.StylePriority.UseBackColor = False
        Me.xrParentDesc.Text = "Parent Desc"
        '
        'xrPivotGrid1
        '
        Me.xrPivotGrid1.Appearance.FieldHeader.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrPivotGrid1.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrPivotGrid1.DataAdapter = Me.odbcDataAdapter1
        Me.xrPivotGrid1.DataMember = "Table"
        Me.xrPivotGrid1.DataSource = Me.assetByLocationFlex1
        Me.xrPivotGrid1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldTagNumber, Me.fieldTagName, Me.fieldTagValue, Me.fieldParentDesc, Me.fieldLocDesc})
        Me.xrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(3.999996!, 0.0!)
        Me.xrPivotGrid1.Name = "xrPivotGrid1"
        Me.xrPivotGrid1.OptionsChartDataSource.UpdateDelay = 300
        Me.xrPivotGrid1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.xrPivotGrid1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.xrPivotGrid1.OptionsView.ShowColumnGrandTotalHeader = False
        Me.xrPivotGrid1.OptionsView.ShowColumnGrandTotals = False
        Me.xrPivotGrid1.OptionsView.ShowRowGrandTotalHeader = False
        Me.xrPivotGrid1.OptionsView.ShowRowGrandTotals = False
        Me.xrPivotGrid1.SizeF = New System.Drawing.SizeF(715.9999!, 88.00001!)
        '
        'fieldTagNumber
        '
        Me.fieldTagNumber.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldTagNumber.AreaIndex = 0
        Me.fieldTagNumber.Caption = "Asset Tag Number"
        Me.fieldTagNumber.FieldName = "TagNumber"
        Me.fieldTagNumber.Name = "fieldTagNumber"
        Me.fieldTagNumber.Width = 110
        '
        'fieldTagName
        '
        Me.fieldTagName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldTagName.AreaIndex = 0
        Me.fieldTagName.FieldName = "TagName"
        Me.fieldTagName.Name = "fieldTagName"
        Me.fieldTagName.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom
        '
        'fieldTagValue
        '
        Me.fieldTagValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldTagValue.AreaIndex = 0
        Me.fieldTagValue.FieldName = "TagValue"
        Me.fieldTagValue.Name = "fieldTagValue"
        Me.fieldTagValue.UseNativeFormat = DevExpress.Utils.DefaultBoolean.[False]
        '
        'fieldParentDesc
        '
        Me.fieldParentDesc.AreaIndex = 0
        Me.fieldParentDesc.FieldName = "ParentDesc"
        Me.fieldParentDesc.Name = "fieldParentDesc"
        Me.fieldParentDesc.Visible = False
        '
        'fieldLocDesc
        '
        Me.fieldLocDesc.AreaIndex = 0
        Me.fieldLocDesc.FieldName = "LocDesc"
        Me.fieldLocDesc.Name = "fieldLocDesc"
        Me.fieldLocDesc.Visible = False
        '
        'pageFooterBand1
        '
        Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrPageInfo2})
        Me.pageFooterBand1.HeightF = 50.87497!
        Me.pageFooterBand1.Name = "pageFooterBand1"
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(3.999996!, 0.0!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(578.0!, 23.0!)
        Me.xrPageInfo1.StyleName = "PageInfo"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Format = "Page {0} of {1}"
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(3.999996!, 23.99998!)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(578.0!, 23.0!)
        Me.xrPageInfo2.StyleName = "PageInfo"
        Me.xrPageInfo2.StylePriority.UseTextAlignment = False
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'reportHeaderBand1
        '
        Me.reportHeaderBand1.HeightF = 0.0!
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        '
        'xrLabel17
        '
        Me.xrLabel17.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(3.999996!, 0.0!)
        Me.xrLabel17.Name = "xrLabel17"
        Me.xrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel17.SizeF = New System.Drawing.SizeF(1168.0!, 33.0!)
        Me.xrLabel17.StyleName = "Title"
        Me.xrLabel17.StylePriority.UseBackColor = False
        Me.xrLabel17.StylePriority.UseTextAlignment = False
        Me.xrLabel17.Text = "Assets By Location"
        Me.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        'groupFooterBand1
        '
        Me.groupFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPivotGrid1})
        Me.groupFooterBand1.HeightF = 135.4167!
        Me.groupFooterBand1.Name = "groupFooterBand1"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel17})
        Me.PageHeader.HeightF = 44.79167!
        Me.PageHeader.Name = "PageHeader"
        '
        'ReportAssetByLocationFlex
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.groupHeaderBand1, Me.pageFooterBand1, Me.reportHeaderBand1, Me.topMarginBand1, Me.bottomMarginBand1, Me.groupFooterBand1, Me.PageHeader})
        Me.DataAdapter = Me.odbcDataAdapter1
        Me.DataMember = "Table"
        Me.DataSource = Me.assetByLocationFlex1
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(10, 10, 10, 10)
        Me.PageHeight = 850
        Me.PageWidth = 1200
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.SnapGridSize = 4.0!
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.SnapToGrid
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "10.2"
        CType(Me.assetByLocationFlex1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand

#End Region

    Private Sub xrPivotGrid1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrPivotGrid1.BeforePrint

        ' Clear the filter value collection and add an item
        Me.xrPivotGrid1.Fields("ParentDesc").FilterValues.Clear()
        Me.xrPivotGrid1.Fields("ParentDesc").FilterValues.Add(Me.xrParentDesc.Text)
        Me.xrPivotGrid1.Fields("ParentDesc").FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Included

        Me.xrPivotGrid1.Fields("LocDesc").FilterValues.Clear()
        Me.xrPivotGrid1.Fields("LocDesc").FilterValues.Add(Me.xrLocDesc.Text)
        Me.xrPivotGrid1.Fields("LocDesc").FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Included


    End Sub

    Private Sub xrPivotGrid1_CustomCellDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs) Handles xrPivotGrid1.CustomCellDisplayText
        If CType(e.CreateDrillDownDataSource, DevExpress.XtraPivotGrid.ClientPivotDrillDownDataSource).RowCount = 1 Then
            Select Case e.DataField.Name
                Case "fieldTagValue"
                    Select Case CType(e.CreateDrillDownDataSource, DevExpress.XtraPivotGrid.ClientPivotDrillDownDataSource).GetValue(0, "TagValueType")
                        Case "Integer"
                            If CType(e.CreateDrillDownDataSource, DevExpress.XtraPivotGrid.ClientPivotDrillDownDataSource).GetValue(0, "TagValue") Is Nothing Then
                                e.DisplayText = "-"
                            Else
                                Dim intInteger As Integer = CType(e.CreateDrillDownDataSource, DevExpress.XtraPivotGrid.ClientPivotDrillDownDataSource).GetValue(0, "TagValue")
                                e.DisplayText = intInteger.ToString()
                            End If
                        Case "Decimal"
                            If CType(e.CreateDrillDownDataSource, DevExpress.XtraPivotGrid.ClientPivotDrillDownDataSource).GetValue(0, "TagValue") Is Nothing Then
                                e.DisplayText = "-"
                            Else
                                Dim decDecimal As Decimal = CType(e.CreateDrillDownDataSource, DevExpress.XtraPivotGrid.ClientPivotDrillDownDataSource).GetValue(0, "TagValue")
                                e.DisplayText = String.Format("{0:F2}", decDecimal)
                            End If
                        Case "Timestamp"
                            If CType(e.CreateDrillDownDataSource, DevExpress.XtraPivotGrid.ClientPivotDrillDownDataSource).GetValue(0, "TagValue") Is Nothing Then
                                e.DisplayText = "-"
                            Else
                                Dim dtTimestamp As DateTime = CType(e.CreateDrillDownDataSource, DevExpress.XtraPivotGrid.ClientPivotDrillDownDataSource).GetValue(0, "TagValue")
                                e.DisplayText = String.Format("{0:MM/dd/yyyy hh:mm:ss tt}", dtTimestamp)
                            End If
                        Case Else
                            e.DisplayText = CType(e.CreateDrillDownDataSource, DevExpress.XtraPivotGrid.ClientPivotDrillDownDataSource).GetValue(0, "TagValue")
                    End Select
            End Select
        End If


    End Sub
    Private Sub xrPivotGrid1_PrintCell(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.CustomExportCellEventArgs) Handles xrPivotGrid1.PrintCell

        Select Case e.DataField.Name
            Case "fieldTagValue"
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        End Select

    End Sub

    Private Sub xrPivotGrid1_CustomColumnWidth(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomColumnWidthEventArgs) Handles xrPivotGrid1.CustomColumnWidth
        Select Case e.DataField.Name
            Case "fieldTagValue"
                Dim strTagName As String = CType(e.CreateDrillDownDataSource, DevExpress.XtraPivotGrid.ClientPivotDrillDownDataSource).GetValue(0, "TagName")
                Select Case strTagName
                    Case "Description"
                        e.ColumnWidth = 280
                    Case "Last Modified"
                        e.ColumnWidth = 150
                    Case "Comments"
                        e.ColumnWidth = 200
                    Case Else
                        Dim strTagType = CType(e.CreateDrillDownDataSource, DevExpress.XtraPivotGrid.ClientPivotDrillDownDataSource).GetValue(0, "TagValueType")
                        Select Case strTagType
                            Case "Timestamp"
                                e.ColumnWidth = 150
                            Case Else
                                e.ColumnWidth = 100
                        End Select
                End Select

        End Select


    End Sub

    Private Sub xrPivotGrid1_PrintFieldValue(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.CustomExportFieldValueEventArgs) Handles xrPivotGrid1.PrintFieldValue
        If e.Field IsNot Nothing Then
            Select Case e.Field.Name
                Case "fieldTagName"
                    e.Appearance.Font = New System.Drawing.Font(e.Appearance.Font, Drawing.FontStyle.Bold)
                    e.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
                Case "fieldTagNumber"
                    e.Appearance.Font = New System.Drawing.Font(e.Appearance.Font, Drawing.FontStyle.Underline)
                    e.Brick.Url = "javascript:openRedirector('AssetEdit','" & e.Value.ToString() & "');"
            End Select
        End If

    End Sub

    Private Sub xrPivotGrid1_CustomFieldSort(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomFieldSortEventArgs) Handles xrPivotGrid1.CustomFieldSort
        Dim val1 As Integer = Me.assetByLocationFlex1.Tables(0).Rows(e.ListSourceRowIndex1)("TagSortOrder")
        Dim val2 As Integer = Me.assetByLocationFlex1.Tables(0).Rows(e.ListSourceRowIndex2)("TagSortOrder")
        If (val1 > val2) Then
            e.Result = 1
        ElseIf (val1 < val2) Then
            e.Result = -1
        Else
            e.Result = 0
        End If

        e.Handled = True

    End Sub
End Class