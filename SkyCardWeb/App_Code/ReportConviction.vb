Public Class ReportConviction
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub ApplySorting(ByVal fieldname As String)

        Detail.SortFields.Clear()
        Dim gf As New DevExpress.XtraReports.UI.GroupField(fieldname, DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)
        Detail.SortFields.Add(gf)


    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    Private WithEvents sqlConnection1 As System.Data.SqlClient.SqlConnection
    Private WithEvents sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Private WithEvents sqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Private WithEvents dataSetConviction1 As DataSetConviction
    Private WithEvents FieldName As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents FromDt As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents ToDt As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents OrderBy As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents xrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrCheckBox1 As DevExpress.XtraReports.UI.XRCheckBox
    Private WithEvents xrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrCheckBox2 As DevExpress.XtraReports.UI.XRCheckBox
    Private WithEvents xrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Private WithEvents xrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Private WithEvents bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Private WithEvents xrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLine2 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents formattingRule1 As DevExpress.XtraReports.UI.FormattingRule

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "ReportConviction.resx"
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox
        Me.xrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrCheckBox2 = New DevExpress.XtraReports.UI.XRCheckBox
        Me.xrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.dataSetConviction1 = New DataSetConviction
        Me.FieldName = New DevExpress.XtraReports.Parameters.Parameter
        Me.FromDt = New DevExpress.XtraReports.Parameters.Parameter
        Me.ToDt = New DevExpress.XtraReports.Parameters.Parameter
        Me.OrderBy = New DevExpress.XtraReports.Parameters.Parameter
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle
        Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel30 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel29 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel28 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel25 = New DevExpress.XtraReports.UI.XRLabel
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand
        CType(Me.dataSetConviction1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine1, Me.xrLabel2, Me.xrLabel1, Me.xrLabel15, Me.xrLabel16, Me.xrLabel17, Me.xrLabel18, Me.xrLabel19, Me.xrLabel20, Me.xrLabel21, Me.xrCheckBox1, Me.xrLabel22, Me.xrCheckBox2, Me.xrLabel23, Me.xrLabel24, Me.xrLabel3, Me.xrLabel14, Me.xrLabel13, Me.xrLabel9, Me.xrLabel4, Me.xrLabel5, Me.xrLabel6, Me.xrLabel7, Me.xrLabel8, Me.xrLabel11, Me.xrLabel10, Me.xrLabel12})
        Me.Detail.HeightF = 199.0416!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("DateInitiated", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.StyleName = "DataField"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLine1
        '
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 194.8752!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(630.0!, 2.0!)
        '
        'xrLabel2
        '
        Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetConvictionSearch.CaseNumber")})
        Me.xrLabel2.FormattingRules.Add(Me.formattingRule1)
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(110.0!, 10.00001!)
        Me.xrLabel2.Multiline = True
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(94.0!, 36.0!)
        Me.xrLabel2.StyleName = "DataField"
        Me.xrLabel2.Text = "xrLabel2"
        '
        'formattingRule1
        '
        Me.formattingRule1.Condition = "1=1"
        '
        '
        '
        Me.formattingRule1.Formatting.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formattingRule1.Formatting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.formattingRule1.Name = "formattingRule1"
        '
        'xrLabel1
        '
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(94.0!, 36.0!)
        Me.xrLabel1.StyleName = "FieldCaption"
        Me.xrLabel1.Text = "Case Number"
        '
        'xrLabel15
        '
        Me.xrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetConvictionSearch.DefendantName")})
        Me.xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(124.3847!, 56.87497!)
        Me.xrLabel15.Name = "xrLabel15"
        Me.xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel15.SizeF = New System.Drawing.SizeF(266.4203!, 22.99999!)
        Me.xrLabel15.Text = "xrLabel15"
        '
        'xrLabel16
        '
        Me.xrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetConvictionSearch.DateInitiated", "{0:MM/dd/yyyy}")})
        Me.xrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(544.3352!, 56.87491!)
        Me.xrLabel16.Name = "xrLabel16"
        Me.xrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel16.SizeF = New System.Drawing.SizeF(95.66507!, 22.99999!)
        Me.xrLabel16.Text = "xrLabel16"
        '
        'xrLabel17
        '
        Me.xrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetConvictionSearch.ArraignmentDate", "{0:MM/dd/yyyy}")})
        Me.xrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(544.3352!, 79.87493!)
        Me.xrLabel17.Name = "xrLabel17"
        Me.xrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel17.SizeF = New System.Drawing.SizeF(95.66507!, 23.00002!)
        Me.xrLabel17.Text = "xrLabel17"
        '
        'xrLabel18
        '
        Me.xrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetConvictionSearch.PreTrialDate", "{0:MM/dd/yyyy}")})
        Me.xrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(544.3352!, 102.8749!)
        Me.xrLabel18.Name = "xrLabel18"
        Me.xrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel18.SizeF = New System.Drawing.SizeF(95.66513!, 23.00002!)
        Me.xrLabel18.Text = "xrLabel18"
        '
        'xrLabel19
        '
        Me.xrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetConvictionSearch.BenchTrialDate", "{0:MM/dd/yyyy}")})
        Me.xrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(544.3352!, 125.875!)
        Me.xrLabel19.Name = "xrLabel19"
        Me.xrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel19.SizeF = New System.Drawing.SizeF(95.66513!, 23.00002!)
        Me.xrLabel19.Text = "xrLabel19"
        '
        'xrLabel20
        '
        Me.xrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetConvictionSearch.JuryTrialDate", "{0:MM/dd/yyyy}")})
        Me.xrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(544.335!, 148.8749!)
        Me.xrLabel20.Name = "xrLabel20"
        Me.xrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel20.SizeF = New System.Drawing.SizeF(95.66516!, 23.0!)
        Me.xrLabel20.Text = "xrLabel20"
        '
        'xrLabel21
        '
        Me.xrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetConvictionSearch.Disposition")})
        Me.xrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(124.3847!, 125.875!)
        Me.xrLabel21.Name = "xrLabel21"
        Me.xrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel21.SizeF = New System.Drawing.SizeF(266.4203!, 23.00002!)
        Me.xrLabel21.Text = "xrLabel21"
        '
        'xrCheckBox1
        '
        Me.xrCheckBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("CheckState", Nothing, "GetConvictionSearch.Amended")})
        Me.xrCheckBox1.LocationFloat = New DevExpress.Utils.PointFloat(126.2816!, 171.8751!)
        Me.xrCheckBox1.Name = "xrCheckBox1"
        Me.xrCheckBox1.SizeF = New System.Drawing.SizeF(30.46656!, 23.00003!)
        '
        'xrLabel22
        '
        Me.xrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetConvictionSearch.AmendedToWhat")})
        Me.xrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(276.7481!, 171.8751!)
        Me.xrLabel22.Name = "xrLabel22"
        Me.xrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel22.SizeF = New System.Drawing.SizeF(367.2519!, 23.00003!)
        Me.xrLabel22.Text = "xrLabel22"
        '
        'xrCheckBox2
        '
        Me.xrCheckBox2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("CheckState", Nothing, "GetConvictionSearch.Conviction")})
        Me.xrCheckBox2.LocationFloat = New DevExpress.Utils.PointFloat(126.2816!, 148.875!)
        Me.xrCheckBox2.Name = "xrCheckBox2"
        Me.xrCheckBox2.SizeF = New System.Drawing.SizeF(30.46655!, 23.00002!)
        '
        'xrLabel23
        '
        Me.xrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetConvictionSearch.CaseType")})
        Me.xrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(124.3847!, 102.8749!)
        Me.xrLabel23.Name = "xrLabel23"
        Me.xrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel23.SizeF = New System.Drawing.SizeF(266.4203!, 22.99998!)
        Me.xrLabel23.Text = "xrLabel23"
        '
        'xrLabel24
        '
        Me.xrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetConvictionSearch.ChargeType")})
        Me.xrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(124.3847!, 79.87499!)
        Me.xrLabel24.Name = "xrLabel24"
        Me.xrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel24.SizeF = New System.Drawing.SizeF(266.4203!, 22.99998!)
        Me.xrLabel24.Text = "xrLabel24"
        '
        'xrLabel3
        '
        Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 56.87497!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(106.5!, 22.99999!)
        Me.xrLabel3.StylePriority.UseFont = False
        Me.xrLabel3.Text = "Defendant Name"
        '
        'xrLabel14
        '
        Me.xrLabel14.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 79.87499!)
        Me.xrLabel14.Name = "xrLabel14"
        Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel14.SizeF = New System.Drawing.SizeF(106.5!, 22.99998!)
        Me.xrLabel14.StylePriority.UseFont = False
        Me.xrLabel14.Text = "Charge Type"
        '
        'xrLabel13
        '
        Me.xrLabel13.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 102.8749!)
        Me.xrLabel13.Name = "xrLabel13"
        Me.xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel13.SizeF = New System.Drawing.SizeF(106.5!, 22.99999!)
        Me.xrLabel13.StylePriority.UseFont = False
        Me.xrLabel13.Text = "Case Type"
        '
        'xrLabel9
        '
        Me.xrLabel9.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 125.875!)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(106.5!, 23.00002!)
        Me.xrLabel9.StylePriority.UseFont = False
        Me.xrLabel9.Text = "Disposition"
        '
        'xrLabel4
        '
        Me.xrLabel4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(407.5701!, 56.87491!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(120.0!, 22.99999!)
        Me.xrLabel4.StylePriority.UseFont = False
        Me.xrLabel4.Text = "Date Initiated"
        '
        'xrLabel5
        '
        Me.xrLabel5.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(407.5701!, 79.87489!)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(120.0!, 23.00002!)
        Me.xrLabel5.StylePriority.UseFont = False
        Me.xrLabel5.Text = "Arraignment Date"
        '
        'xrLabel6
        '
        Me.xrLabel6.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(407.57!, 102.8749!)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel6.SizeF = New System.Drawing.SizeF(120.0!, 23.0!)
        Me.xrLabel6.StylePriority.UseFont = False
        Me.xrLabel6.Text = "Pre Trial Date"
        '
        'xrLabel7
        '
        Me.xrLabel7.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(407.57!, 125.875!)
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel7.SizeF = New System.Drawing.SizeF(120.0!, 23.0!)
        Me.xrLabel7.StylePriority.UseFont = False
        Me.xrLabel7.Text = "Bench Trial Date"
        '
        'xrLabel8
        '
        Me.xrLabel8.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(407.57!, 148.8749!)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel8.SizeF = New System.Drawing.SizeF(120.0!, 23.0!)
        Me.xrLabel8.StylePriority.UseFont = False
        Me.xrLabel8.Text = "Jury Trial Date"
        '
        'xrLabel11
        '
        Me.xrLabel11.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(156.7481!, 171.8751!)
        Me.xrLabel11.Name = "xrLabel11"
        Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel11.SizeF = New System.Drawing.SizeF(120.0!, 23.00002!)
        Me.xrLabel11.StylePriority.UseFont = False
        Me.xrLabel11.Text = "Amended To What"
        '
        'xrLabel10
        '
        Me.xrLabel10.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 171.8751!)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel10.SizeF = New System.Drawing.SizeF(106.5!, 22.99999!)
        Me.xrLabel10.StylePriority.UseFont = False
        Me.xrLabel10.Text = "Amended"
        '
        'xrLabel12
        '
        Me.xrLabel12.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 148.875!)
        Me.xrLabel12.Name = "xrLabel12"
        Me.xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel12.SizeF = New System.Drawing.SizeF(106.5!, 23.0!)
        Me.xrLabel12.StylePriority.UseFont = False
        Me.xrLabel12.Text = "Conviction"
        '
        'sqlConnection1
        '
        Me.sqlConnection1.ConnectionString = "Data Source=192.168.0.160;Initial Catalog=CaseMgmtv1;Persist Security Info=True;U" & _
            "ser ID=CaseMgtUser;Password=1234"
        Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'sqlSelectCommand1
        '
        Me.sqlSelectCommand1.CommandText = "dbo.GetConvictionSearch"
        Me.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.sqlSelectCommand1.Connection = Me.sqlConnection1
        Me.sqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@DateField", System.Data.SqlDbType.VarChar, 50), New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.DateTime, 8), New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.DateTime, 8), New System.Data.SqlClient.SqlParameter("@SortField", System.Data.SqlDbType.VarChar, 50), New System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.VarChar, 50)})
        '
        'sqlDataAdapter1
        '
        Me.sqlDataAdapter1.SelectCommand = Me.sqlSelectCommand1
        Me.sqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GetConvictionSearch", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CaseNumber", "CaseNumber"), New System.Data.Common.DataColumnMapping("DefendantName", "DefendantName"), New System.Data.Common.DataColumnMapping("DateInitiated", "DateInitiated"), New System.Data.Common.DataColumnMapping("ArraignmentDate", "ArraignmentDate"), New System.Data.Common.DataColumnMapping("PreTrialDate", "PreTrialDate"), New System.Data.Common.DataColumnMapping("BenchTrialDate", "BenchTrialDate"), New System.Data.Common.DataColumnMapping("JuryTrialDate", "JuryTrialDate"), New System.Data.Common.DataColumnMapping("Disposition", "Disposition"), New System.Data.Common.DataColumnMapping("Amended", "Amended"), New System.Data.Common.DataColumnMapping("AmendedToWhat", "AmendedToWhat"), New System.Data.Common.DataColumnMapping("Conviction", "Conviction"), New System.Data.Common.DataColumnMapping("Deleted", "Deleted"), New System.Data.Common.DataColumnMapping("Last_modified", "Last_modified"), New System.Data.Common.DataColumnMapping("CaseType", "CaseType"), New System.Data.Common.DataColumnMapping("ChargeType", "ChargeType")})})
        '
        'dataSetConviction1
        '
        Me.dataSetConviction1.DataSetName = "DataSetConviction"
        Me.dataSetConviction1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FieldName
        '
        Me.FieldName.Name = "FieldName"
        Me.FieldName.Value = ""
        '
        'FromDt
        '
        Me.FromDt.Name = "FromDt"
        Me.FromDt.Type = GetType(Date)
        Me.FromDt.Value = New Date(2013, 7, 31, 10, 58, 35, 780)
        '
        'ToDt
        '
        Me.ToDt.Name = "ToDt"
        Me.ToDt.Type = GetType(Date)
        Me.ToDt.Value = New Date(2013, 7, 31, 10, 38, 40, 86)
        '
        'OrderBy
        '
        Me.OrderBy.Name = "OrderBy"
        Me.OrderBy.Value = ""
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
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.xrPageInfo1.StyleName = "PageInfo"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Format = "Page {0} of {1}"
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331.0!, 6.0!)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.xrPageInfo2.StyleName = "PageInfo"
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'reportHeaderBand1
        '
        Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine2, Me.xrLabel30, Me.xrLabel29, Me.xrLabel28, Me.xrLabel27, Me.xrLabel26, Me.xrLabel25})
        Me.reportHeaderBand1.HeightF = 67.66666!
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        '
        'xrLine2
        '
        Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 61.99999!)
        Me.xrLine2.Name = "xrLine2"
        Me.xrLine2.SizeF = New System.Drawing.SizeF(630.0!, 2.0!)
        '
        'xrLabel30
        '
        Me.xrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(312.5!, 39.0!)
        Me.xrLabel30.Name = "xrLabel30"
        Me.xrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel30.SizeF = New System.Drawing.SizeF(44.44865!, 23.0!)
        Me.xrLabel30.Text = "To:"
        '
        'xrLabel29
        '
        Me.xrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(149.5513!, 39.0!)
        Me.xrLabel29.Name = "xrLabel29"
        Me.xrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel29.SizeF = New System.Drawing.SizeF(44.44865!, 23.0!)
        Me.xrLabel29.Text = "From:"
        '
        'xrLabel28
        '
        Me.xrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.ToDt, "Text", "{0:MM/dd/yyyy}")})
        Me.xrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(356.9487!, 39.0!)
        Me.xrLabel28.Name = "xrLabel28"
        Me.xrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel28.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xrLabel28.Text = "xrLabel28"
        '
        'xrLabel27
        '
        Me.xrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.FromDt, "Text", "{0:MM/dd/yyyy}")})
        Me.xrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(194.0!, 39.0!)
        Me.xrLabel27.Name = "xrLabel27"
        Me.xrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel27.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xrLabel27.Text = "xrLabel27"
        '
        'xrLabel26
        '
        Me.xrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.FieldName, "Text", "")})
        Me.xrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 39.0!)
        Me.xrLabel26.Name = "xrLabel26"
        Me.xrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel26.SizeF = New System.Drawing.SizeF(116.6667!, 23.0!)
        Me.xrLabel26.Text = "xrLabel26"
        '
        'xrLabel25
        '
        Me.xrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 4.0!)
        Me.xrLabel25.Name = "xrLabel25"
        Me.xrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel25.SizeF = New System.Drawing.SizeF(638.0!, 33.0!)
        Me.xrLabel25.StyleName = "Title"
        Me.xrLabel25.Text = "Conviction Report"
        '
        'topMarginBand1
        '
        Me.topMarginBand1.Name = "topMarginBand1"
        '
        'bottomMarginBand1
        '
        Me.bottomMarginBand1.Name = "bottomMarginBand1"
        '
        'ReportConviction
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.pageFooterBand1, Me.reportHeaderBand1, Me.topMarginBand1, Me.bottomMarginBand1})
        Me.DataAdapter = Me.sqlDataAdapter1
        Me.DataMember = "GetConvictionSearch"
        Me.DataSource = Me.dataSetConviction1
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.formattingRule1})
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.FieldName, Me.FromDt, Me.ToDt, Me.OrderBy})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "10.2"
        CType(Me.dataSetConviction1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand

#End Region

    Private Sub xrLabel2_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrLabel2.BeforePrint
        xrLabel2.NavigateUrl = "CaseEdit.aspx?caseID=" + xrLabel2.Text
    End Sub

  

  
End Class