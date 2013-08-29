Public Class ReportSubpoena
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
    Private WithEvents sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Private WithEvents sqlConnection1 As System.Data.SqlClient.SqlConnection
    Private WithEvents sqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Private WithEvents dataSetSubpoena21 As DataSetSubpoena2
    Private WithEvents xrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrCheckBox1 As DevExpress.XtraReports.UI.XRCheckBox
    Private WithEvents xrCheckBox2 As DevExpress.XtraReports.UI.XRCheckBox
    Private WithEvents xrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLine2 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Private WithEvents xrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Private WithEvents bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Private WithEvents xrLine3 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents xrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine4 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Private WithEvents xrLine5 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine6 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLine7 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine8 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine9 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel53 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel56 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine10 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLine11 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel57 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel58 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel59 As DevExpress.XtraReports.UI.XRLabel

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "ReportSubpoena.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.ReportSubpoena.ResourceManager
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox
        Me.xrCheckBox2 = New DevExpress.XtraReports.UI.XRCheckBox
        Me.xrLabel25 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel28 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.sqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.dataSetSubpoena21 = New DataSetSubpoena2
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle
        Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand
        Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel
        Me.xrLine9 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel39 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine8 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel38 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine7 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLine6 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel37 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel36 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine5 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.xrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel35 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel34 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel33 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel32 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel31 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel30 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel29 = New DevExpress.XtraReports.UI.XRLabel
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.xrLabel40 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel41 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel42 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel43 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel44 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel45 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel46 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel47 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel48 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel49 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel50 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel51 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel52 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel53 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel54 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel55 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel56 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine10 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLine11 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel57 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel58 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel59 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.dataSetSubpoena21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel59, Me.xrLabel58, Me.xrLabel14, Me.xrLabel13, Me.xrLabel57, Me.xrLabel12, Me.xrLine11, Me.xrLine10, Me.xrLabel56, Me.xrLabel11, Me.xrLabel10, Me.xrLabel9, Me.xrLabel8, Me.xrLabel7, Me.xrLabel55, Me.xrLabel54, Me.xrLabel53, Me.xrLabel52, Me.xrLabel51, Me.xrLabel50, Me.xrLabel49, Me.xrLabel48, Me.xrLabel19, Me.xrLabel15, Me.xrLabel6, Me.xrLabel5, Me.xrLabel4, Me.xrLabel3, Me.xrLabel2, Me.xrLabel47, Me.xrLabel46, Me.xrLabel45, Me.xrLabel44, Me.xrLabel43, Me.xrLabel42, Me.xrLabel41, Me.xrLabel17, Me.xrLabel18, Me.xrLabel20, Me.xrLabel21, Me.xrLabel22, Me.xrLabel23, Me.xrLabel24, Me.xrCheckBox1, Me.xrCheckBox2, Me.xrLabel25, Me.xrLabel26, Me.xrLabel27, Me.xrLabel28, Me.xrLine1, Me.xrLine2})
        Me.Detail.HeightF = 542.1249!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "DataField"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLabel17
        '
        Me.xrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetSubpoena.WitnessName")})
        Me.xrLabel17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(291.4977!, 58.29169!)
        Me.xrLabel17.Name = "xrLabel17"
        Me.xrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel17.SizeF = New System.Drawing.SizeF(204.7174!, 18.0!)
        Me.xrLabel17.StylePriority.UseFont = False
        Me.xrLabel17.Text = "xrLabel17"
        '
        'xrLabel18
        '
        Me.xrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetSubpoena.WitnessAddress1")})
        Me.xrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(43.12213!, 76.29166!)
        Me.xrLabel18.Name = "xrLabel18"
        Me.xrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel18.SizeF = New System.Drawing.SizeF(126.9905!, 18.0!)
        Me.xrLabel18.Text = "xrLabel18"
        '
        'xrLabel20
        '
        Me.xrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetSubpoena.WitnessCity")})
        Me.xrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(170.1127!, 76.29166!)
        Me.xrLabel20.Name = "xrLabel20"
        Me.xrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel20.SizeF = New System.Drawing.SizeF(89.40128!, 18.0!)
        Me.xrLabel20.Text = "xrLabel20"
        '
        'xrLabel21
        '
        Me.xrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetSubpoena.WitnessState")})
        Me.xrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(259.5139!, 76.29166!)
        Me.xrLabel21.Name = "xrLabel21"
        Me.xrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel21.SizeF = New System.Drawing.SizeF(97.52869!, 18.0!)
        Me.xrLabel21.Text = "xrLabel21"
        '
        'xrLabel22
        '
        Me.xrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetSubpoena.WitnessZip")})
        Me.xrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(357.0426!, 76.29166!)
        Me.xrLabel22.Name = "xrLabel22"
        Me.xrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel22.SizeF = New System.Drawing.SizeF(80.6!, 18.0!)
        Me.xrLabel22.Text = "xrLabel22"
        '
        'xrLabel23
        '
        Me.xrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetSubpoena.AppearDate", "{0:MMMM dd, yyyy}")})
        Me.xrLabel23.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(425.3227!, 147.9167!)
        Me.xrLabel23.Name = "xrLabel23"
        Me.xrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel23.SizeF = New System.Drawing.SizeF(132.4713!, 18.0!)
        Me.xrLabel23.StylePriority.UseFont = False
        Me.xrLabel23.Text = "xrLabel23"
        '
        'xrLabel24
        '
        Me.xrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetSubpoena.Courtroom")})
        Me.xrLabel24.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(116.4063!, 201.9166!)
        Me.xrLabel24.Name = "xrLabel24"
        Me.xrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel24.SizeF = New System.Drawing.SizeF(127.5!, 18.0!)
        Me.xrLabel24.StylePriority.UseFont = False
        Me.xrLabel24.Text = "xrLabel24"
        '
        'xrCheckBox1
        '
        Me.xrCheckBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("CheckState", Nothing, "GetSubpoena.Testify")})
        Me.xrCheckBox1.LocationFloat = New DevExpress.Utils.PointFloat(21.2293!, 288.5834!)
        Me.xrCheckBox1.Name = "xrCheckBox1"
        Me.xrCheckBox1.SizeF = New System.Drawing.SizeF(232.2778!, 22.99997!)
        Me.xrCheckBox1.StylePriority.UseTextAlignment = False
        Me.xrCheckBox1.Text = "To Testify on Behalf Commonwealth"
        Me.xrCheckBox1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrCheckBox2
        '
        Me.xrCheckBox2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("CheckState", Nothing, "GetSubpoena.Produce")})
        Me.xrCheckBox2.LocationFloat = New DevExpress.Utils.PointFloat(21.2293!, 324.1667!)
        Me.xrCheckBox2.Name = "xrCheckBox2"
        Me.xrCheckBox2.SizeF = New System.Drawing.SizeF(104.0982!, 23.0!)
        Me.xrCheckBox2.StylePriority.UseTextAlignment = False
        Me.xrCheckBox2.Text = "To Produce:"
        Me.xrCheckBox2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrLabel25
        '
        Me.xrLabel25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetSubpoena.DiscoveryDueDate", "{0:MMMM dd, yyyy}")})
        Me.xrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(330.3086!, 401.1668!)
        Me.xrLabel25.Name = "xrLabel25"
        Me.xrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel25.SizeF = New System.Drawing.SizeF(131.0959!, 23.0!)
        Me.xrLabel25.Text = "xrLabel25"
        '
        'xrLabel26
        '
        Me.xrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetSubpoena.RequestingAtty")})
        Me.xrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(357.0426!, 452.25!)
        Me.xrLabel26.Name = "xrLabel26"
        Me.xrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel26.SizeF = New System.Drawing.SizeF(200.7513!, 17.99994!)
        Me.xrLabel26.Text = "xrLabel26"
        '
        'xrLabel27
        '
        Me.xrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetSubpoena.AttyExt")})
        Me.xrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(502.4424!, 506.2499!)
        Me.xrLabel27.Name = "xrLabel27"
        Me.xrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel27.SizeF = New System.Drawing.SizeF(55.35162!, 18.0!)
        Me.xrLabel27.Text = "xrLabel27"
        '
        'xrLabel28
        '
        Me.xrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetSubpoena.DefendantName")})
        Me.xrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(330.0796!, 0.0!)
        Me.xrLabel28.Name = "xrLabel28"
        Me.xrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel28.SizeF = New System.Drawing.SizeF(309.9204!, 18.0!)
        Me.xrLabel28.Text = "xrLabel28"
        '
        'xrLine1
        '
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(6.00001!, 133.75!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(638.0!, 2.0!)
        '
        'xrLine2
        '
        Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 276.2084!)
        Me.xrLine2.Name = "xrLine2"
        Me.xrLine2.SizeF = New System.Drawing.SizeF(638.0!, 2.0!)
        '
        'xrLabel16
        '
        Me.xrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetSubpoena.CaseNumber")})
        Me.xrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(536.0547!, 13.62499!)
        Me.xrLabel16.Name = "xrLabel16"
        Me.xrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel16.SizeF = New System.Drawing.SizeF(105.9135!, 18.0!)
        Me.xrLabel16.Text = "xrLabel16"
        '
        'sqlSelectCommand1
        '
        Me.sqlSelectCommand1.CommandText = "dbo.GetSubpoena"
        Me.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.sqlSelectCommand1.Connection = Me.sqlConnection1
        Me.sqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0), New System.Data.SqlClient.SqlParameter("@SubpoenaID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "1")})
        '
        'sqlConnection1
        '
        Me.sqlConnection1.ConnectionString = "Data Source=192.168.0.160;Initial Catalog=CaseMgmtv1;User ID=CaseMgtUser;"
        Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'sqlDataAdapter1
        '
        Me.sqlDataAdapter1.SelectCommand = Me.sqlSelectCommand1
        Me.sqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GetSubpoena", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("CaseNumber", "CaseNumber"), New System.Data.Common.DataColumnMapping("DefendantName", "DefendantName"), New System.Data.Common.DataColumnMapping("WitnessName", "WitnessName"), New System.Data.Common.DataColumnMapping("WitnessAddress1", "WitnessAddress1"), New System.Data.Common.DataColumnMapping("WitnessAddress2", "WitnessAddress2"), New System.Data.Common.DataColumnMapping("WitnessCity", "WitnessCity"), New System.Data.Common.DataColumnMapping("WitnessState", "WitnessState"), New System.Data.Common.DataColumnMapping("WitnessZip", "WitnessZip"), New System.Data.Common.DataColumnMapping("AppearDate", "AppearDate"), New System.Data.Common.DataColumnMapping("Courtroom", "Courtroom"), New System.Data.Common.DataColumnMapping("Testify", "Testify"), New System.Data.Common.DataColumnMapping("Produce", "Produce"), New System.Data.Common.DataColumnMapping("DiscoveryDueDate", "DiscoveryDueDate"), New System.Data.Common.DataColumnMapping("RequestingAtty", "RequestingAtty"), New System.Data.Common.DataColumnMapping("AttyExt", "AttyExt"), New System.Data.Common.DataColumnMapping("Last_Modified", "Last_Modified")})})
        '
        'dataSetSubpoena21
        '
        Me.dataSetSubpoena21.DataSetName = "DataSetSubpoena2"
        Me.dataSetSubpoena21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel40, Me.xrPanel1, Me.xrPageInfo1})
        Me.pageFooterBand1.HeightF = 199.8334!
        Me.pageFooterBand1.Name = "pageFooterBand1"
        '
        'xrPanel1
        '
        Me.xrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine9, Me.xrLabel39, Me.xrLine8, Me.xrLabel38, Me.xrLine7, Me.xrLine6, Me.xrLabel37, Me.xrLabel36, Me.xrLine5, Me.xrLabel1})
        Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(6.00001!, 9.999974!)
        Me.xrPanel1.Name = "xrPanel1"
        Me.xrPanel1.SizeF = New System.Drawing.SizeF(634.0!, 134.9584!)
        Me.xrPanel1.StylePriority.UseBorders = False
        '
        'xrLine9
        '
        Me.xrLine9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrLine9.LocationFloat = New DevExpress.Utils.PointFloat(424.7106!, 111.9584!)
        Me.xrLine9.Name = "xrLine9"
        Me.xrLine9.SizeF = New System.Drawing.SizeF(199.2894!, 9.999977!)
        Me.xrLine9.StylePriority.UseBorders = False
        '
        'xrLabel39
        '
        Me.xrLabel39.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrLabel39.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(378.7106!, 101.0001!)
        Me.xrLabel39.Name = "xrLabel39"
        Me.xrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel39.SizeF = New System.Drawing.SizeF(46.0!, 23.0!)
        Me.xrLabel39.StylePriority.UseBorders = False
        Me.xrLabel39.StylePriority.UseFont = False
        Me.xrLabel39.Text = "TITLE"
        '
        'xrLine8
        '
        Me.xrLine8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrLine8.LocationFloat = New DevExpress.Utils.PointFloat(40.20837!, 111.9584!)
        Me.xrLine8.Name = "xrLine8"
        Me.xrLine8.SizeF = New System.Drawing.SizeF(338.5022!, 10.0!)
        Me.xrLine8.StylePriority.UseBorders = False
        '
        'xrLabel38
        '
        Me.xrLabel38.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrLabel38.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 101.0001!)
        Me.xrLabel38.Name = "xrLabel38"
        Me.xrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel38.SizeF = New System.Drawing.SizeF(30.20833!, 23.0!)
        Me.xrLabel38.StylePriority.UseBorders = False
        Me.xrLabel38.StylePriority.UseFont = False
        Me.xrLabel38.Text = "BY"
        '
        'xrLine7
        '
        Me.xrLine7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrLine7.LocationFloat = New DevExpress.Utils.PointFloat(50.0!, 78.00007!)
        Me.xrLine7.Name = "xrLine7"
        Me.xrLine7.SizeF = New System.Drawing.SizeF(134.2084!, 10.00004!)
        Me.xrLine7.StylePriority.UseBorders = False
        '
        'xrLine6
        '
        Me.xrLine6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrLine6.LocationFloat = New DevExpress.Utils.PointFloat(241.4977!, 78.00007!)
        Me.xrLine6.Name = "xrLine6"
        Me.xrLine6.SizeF = New System.Drawing.SizeF(382.5022!, 10.00004!)
        Me.xrLine6.StylePriority.UseBorders = False
        '
        'xrLabel37
        '
        Me.xrLabel37.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrLabel37.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(185.4977!, 67.12506!)
        Me.xrLabel37.Name = "xrLabel37"
        Me.xrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel37.SizeF = New System.Drawing.SizeF(56.0!, 23.00002!)
        Me.xrLabel37.StylePriority.UseBorders = False
        Me.xrLabel37.StylePriority.UseFont = False
        Me.xrLabel37.Text = "DAY OF"
        '
        'xrLabel36
        '
        Me.xrLabel36.AutoWidth = True
        Me.xrLabel36.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrLabel36.CanGrow = False
        Me.xrLabel36.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 67.12506!)
        Me.xrLabel36.Name = "xrLabel36"
        Me.xrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel36.SizeF = New System.Drawing.SizeF(40.0!, 23.00002!)
        Me.xrLabel36.StylePriority.UseBorders = False
        Me.xrLabel36.StylePriority.UseFont = False
        Me.xrLabel36.Text = "THIS"
        Me.xrLabel36.WordWrap = False
        '
        'xrLine5
        '
        Me.xrLine5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrLine5.LocationFloat = New DevExpress.Utils.PointFloat(10.00006!, 45.49999!)
        Me.xrLine5.Name = "xrLine5"
        Me.xrLine5.SizeF = New System.Drawing.SizeF(613.9999!, 10.0!)
        Me.xrLine5.StylePriority.UseBorders = False
        '
        'xrLabel1
        '
        Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(9.999975!, 9.999974!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(347.3201!, 23.00002!)
        Me.xrLabel1.StylePriority.UseBorders = False
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.Text = "This Subpoena was served by delivering a true copy to:"
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6.00001!, 144.9584!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.xrPageInfo1.StyleName = "PageInfo"
        '
        'reportHeaderBand1
        '
        Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine4, Me.xrLabel35, Me.xrLabel34, Me.xrLabel33, Me.xrLabel32, Me.xrLabel31, Me.xrLabel30, Me.xrPictureBox1, Me.xrLine3, Me.xrLabel29, Me.xrLabel16})
        Me.reportHeaderBand1.HeightF = 152.0417!
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        '
        'xrLine4
        '
        Me.xrLine4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 103.4167!)
        Me.xrLine4.Name = "xrLine4"
        Me.xrLine4.SizeF = New System.Drawing.SizeF(646.5032!, 13.625!)
        '
        'xrLabel35
        '
        Me.xrLabel35.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 64.58334!)
        Me.xrLabel35.Name = "xrLabel35"
        Me.xrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel35.SizeF = New System.Drawing.SizeF(180.2084!, 17.99999!)
        Me.xrLabel35.StylePriority.UseFont = False
        Me.xrLabel35.Text = "Commonwealth of Kentucky"
        '
        'xrLabel34
        '
        Me.xrLabel34.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(475.638!, 49.62498!)
        Me.xrLabel34.Name = "xrLabel34"
        Me.xrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel34.SizeF = New System.Drawing.SizeF(60.41669!, 18.0!)
        Me.xrLabel34.StylePriority.UseFont = False
        Me.xrLabel34.Text = "County:"
        '
        'xrLabel33
        '
        Me.xrLabel33.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(536.0547!, 49.62498!)
        Me.xrLabel33.Name = "xrLabel33"
        Me.xrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel33.SizeF = New System.Drawing.SizeF(105.9135!, 18.0!)
        Me.xrLabel33.StylePriority.UseFont = False
        Me.xrLabel33.Text = "Kenton"
        '
        'xrLabel32
        '
        Me.xrLabel32.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(536.0547!, 31.62498!)
        Me.xrLabel32.Name = "xrLabel32"
        Me.xrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel32.SizeF = New System.Drawing.SizeF(105.9135!, 18.0!)
        Me.xrLabel32.StylePriority.UseFont = False
        Me.xrLabel32.Text = "District"
        '
        'xrLabel31
        '
        Me.xrLabel31.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(475.638!, 31.62498!)
        Me.xrLabel31.Name = "xrLabel31"
        Me.xrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel31.SizeF = New System.Drawing.SizeF(60.41669!, 18.0!)
        Me.xrLabel31.StylePriority.UseFont = False
        Me.xrLabel31.Text = "Court:"
        '
        'xrLabel30
        '
        Me.xrLabel30.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(475.638!, 13.62499!)
        Me.xrLabel30.Name = "xrLabel30"
        Me.xrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel30.SizeF = New System.Drawing.SizeF(60.41669!, 18.0!)
        Me.xrLabel30.StylePriority.UseFont = False
        Me.xrLabel30.Text = "Case No:"
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.Image = CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image)
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(291.4977!, 13.62499!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(117.7083!, 89.79168!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'xrLine3
        '
        Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(3.496838!, 0.0!)
        Me.xrLine3.Name = "xrLine3"
        Me.xrLine3.SizeF = New System.Drawing.SizeF(646.5032!, 13.625!)
        '
        'xrLabel29
        '
        Me.xrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(3.968175!, 117.0417!)
        Me.xrLabel29.Name = "xrLabel29"
        Me.xrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel29.SizeF = New System.Drawing.SizeF(638.0!, 33.0!)
        Me.xrLabel29.StyleName = "Title"
        Me.xrLabel29.StylePriority.UseTextAlignment = False
        Me.xrLabel29.Text = "Subpoena"
        Me.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'topMarginBand1
        '
        Me.topMarginBand1.Name = "topMarginBand1"
        '
        'bottomMarginBand1
        '
        Me.bottomMarginBand1.Name = "bottomMarginBand1"
        '
        'xrLabel40
        '
        Me.xrLabel40.Font = New System.Drawing.Font("Times New Roman", 7.0!)
        Me.xrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(6.00001!, 167.9584!)
        Me.xrLabel40.Name = "xrLabel40"
        Me.xrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrLabel40.SizeF = New System.Drawing.SizeF(634.0!, 23.00002!)
        Me.xrLabel40.StylePriority.UseFont = False
        Me.xrLabel40.StylePriority.UseTextAlignment = False
        Me.xrLabel40.Text = "Office of the Kenton County Attorney, 303 Court Street Room 307, Covington, KY 41" & _
            "011; Phone 859-491-0600; Fax: 859-491-0986 www.kentoncoatty.com"
        Me.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel41
        '
        Me.xrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(3.496838!, 0.0!)
        Me.xrLabel41.Name = "xrLabel41"
        Me.xrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel41.SizeF = New System.Drawing.SizeF(240.42!, 18.0!)
        Me.xrLabel41.Text = "COMMONWEALTH OF KENTUCKY"
        '
        'xrLabel42
        '
        Me.xrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(251.9144!, 0.0!)
        Me.xrLabel42.Name = "xrLabel42"
        Me.xrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel42.SizeF = New System.Drawing.SizeF(29.16667!, 18.0!)
        Me.xrLabel42.Text = "vs."
        '
        'xrLabel43
        '
        Me.xrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(3.496838!, 18.0!)
        Me.xrLabel43.Name = "xrLabel43"
        Me.xrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel43.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xrLabel43.Text = "Plaintiff"
        '
        'xrLabel44
        '
        Me.xrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(330.0796!, 18.0!)
        Me.xrLabel44.Name = "xrLabel44"
        Me.xrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel44.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xrLabel44.Text = "Defendant(s)"
        '
        'xrLabel45
        '
        Me.xrLabel45.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 58.29169!)
        Me.xrLabel45.Name = "xrLabel45"
        Me.xrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel45.SizeF = New System.Drawing.SizeF(14.75!, 18.0!)
        Me.xrLabel45.StylePriority.UseFont = False
        Me.xrLabel45.Text = "1."
        '
        'xrLabel46
        '
        Me.xrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(16.00008!, 58.29169!)
        Me.xrLabel46.Name = "xrLabel46"
        Me.xrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel46.SizeF = New System.Drawing.SizeF(227.91!, 18.0!)
        Me.xrLabel46.Text = "The Commonwealth of Kentucky to:"
        '
        'xrLabel47
        '
        Me.xrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(3.968175!, 76.29166!)
        Me.xrLabel47.Name = "xrLabel47"
        Me.xrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel47.SizeF = New System.Drawing.SizeF(29.17!, 18.0!)
        Me.xrLabel47.Text = "At:"
        '
        'xrLabel2
        '
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(15.99998!, 105.2083!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(303.0001!, 18.0!)
        Me.xrLabel2.Text = "YOU ARE COMMANDED TO APPEAR BEFORE:"
        '
        'xrLabel3
        '
        Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 105.2083!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(14.75!, 18.0!)
        Me.xrLabel3.StylePriority.UseFont = False
        Me.xrLabel3.Text = "2."
        '
        'xrLabel4
        '
        Me.xrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(324.7971!, 105.2083!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(184.0385!, 18.0!)
        Me.xrLabel4.StylePriority.UseFont = False
        Me.xrLabel4.Text = "KENTON DISTRICT COURT"
        '
        'xrLabel5
        '
        Me.xrLabel5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 147.9167!)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(14.75!, 18.0!)
        Me.xrLabel5.StylePriority.UseFont = False
        Me.xrLabel5.Text = "3."
        '
        'xrLabel6
        '
        Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(15.99998!, 147.9167!)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel6.SizeF = New System.Drawing.SizeF(227.91!, 18.0!)
        Me.xrLabel6.Text = "At the Kenton County Justice Center"
        '
        'xrLabel15
        '
        Me.xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(15.99998!, 165.9167!)
        Me.xrLabel15.Name = "xrLabel15"
        Me.xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel15.SizeF = New System.Drawing.SizeF(227.91!, 18.0!)
        Me.xrLabel15.Text = "230 Madison Avenue"
        '
        'xrLabel19
        '
        Me.xrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(16.00682!, 183.9167!)
        Me.xrLabel19.Name = "xrLabel19"
        Me.xrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel19.SizeF = New System.Drawing.SizeF(227.91!, 18.0!)
        Me.xrLabel19.Text = "Covington, KY 41011"
        '
        'xrLabel48
        '
        Me.xrLabel48.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(15.99998!, 201.9166!)
        Me.xrLabel48.Name = "xrLabel48"
        Me.xrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel48.SizeF = New System.Drawing.SizeF(87.49687!, 18.00003!)
        Me.xrLabel48.StylePriority.UseFont = False
        Me.xrLabel48.Text = "In Courtroom"
        '
        'xrLabel49
        '
        Me.xrLabel49.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(384.7106!, 147.9167!)
        Me.xrLabel49.Name = "xrLabel49"
        Me.xrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel49.SizeF = New System.Drawing.SizeF(14.75!, 18.0!)
        Me.xrLabel49.StylePriority.UseFont = False
        Me.xrLabel49.Text = "4."
        '
        'xrLabel50
        '
        Me.xrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(399.4606!, 147.9167!)
        Me.xrLabel50.Name = "xrLabel50"
        Me.xrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel50.SizeF = New System.Drawing.SizeF(24.0!, 18.0!)
        Me.xrLabel50.Text = "On"
        '
        'xrLabel51
        '
        Me.xrLabel51.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GetSubpoena.AppearDate", "{0:h:mm tt}")})
        Me.xrLabel51.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel51.LocationFloat = New DevExpress.Utils.PointFloat(425.3227!, 165.9167!)
        Me.xrLabel51.Name = "xrLabel51"
        Me.xrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel51.SizeF = New System.Drawing.SizeF(132.4713!, 18.0!)
        Me.xrLabel51.StylePriority.UseFont = False
        Me.xrLabel51.Text = "xrLabel23"
        '
        'xrLabel52
        '
        Me.xrLabel52.LocationFloat = New DevExpress.Utils.PointFloat(400.3227!, 165.9167!)
        Me.xrLabel52.Name = "xrLabel52"
        Me.xrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel52.SizeF = New System.Drawing.SizeF(24.0!, 18.0!)
        Me.xrLabel52.Text = "At"
        '
        'xrLabel53
        '
        Me.xrLabel53.LocationFloat = New DevExpress.Utils.PointFloat(400.3227!, 183.9167!)
        Me.xrLabel53.Name = "xrLabel53"
        Me.xrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel53.SizeF = New System.Drawing.SizeF(227.91!, 18.0!)
        Me.xrLabel53.Text = "Eastern Time"
        '
        'xrLabel54
        '
        Me.xrLabel54.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 230.2083!)
        Me.xrLabel54.Name = "xrLabel54"
        Me.xrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel54.SizeF = New System.Drawing.SizeF(612.2259!, 23.0!)
        Me.xrLabel54.StylePriority.UseFont = False
        Me.xrLabel54.StylePriority.UseTextAlignment = False
        Me.xrLabel54.Text = "**PLEASE CALL or EMAIL ISSUING ATTORNEY TO CONFIRM RECEIPT and"
        Me.xrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel55
        '
        Me.xrLabel55.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 253.2084!)
        Me.xrLabel55.Name = "xrLabel55"
        Me.xrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel55.SizeF = New System.Drawing.SizeF(612.2259!, 23.0!)
        Me.xrLabel55.StylePriority.UseFont = False
        Me.xrLabel55.StylePriority.UseTextAlignment = False
        Me.xrLabel55.Text = "TO RECEIVE ANY ADDITIONAL INSTRUCTIONS NECESSARY**"
        Me.xrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel7
        '
        Me.xrLabel7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 293.5834!)
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel7.SizeF = New System.Drawing.SizeF(14.75!, 18.0!)
        Me.xrLabel7.StylePriority.UseFont = False
        Me.xrLabel7.Text = "5."
        '
        'xrLabel8
        '
        Me.xrLabel8.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(151.6059!, 329.1668!)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel8.SizeF = New System.Drawing.SizeF(482.3873!, 17.99997!)
        Me.xrLabel8.StylePriority.UseFont = False
        Me.xrLabel8.Text = "ANY and ALL REPORTS, INCLUDING BUT LIMITED TO:"
        '
        'xrLabel9
        '
        Me.xrLabel9.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(151.6059!, 347.1667!)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(482.3873!, 18.00003!)
        Me.xrLabel9.StylePriority.UseFont = False
        Me.xrLabel9.Text = "BA Ticket, Field Notes, Citation, Photographs, or Recordings of Any Kind, Any"
        '
        'xrLabel10
        '
        Me.xrLabel10.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(151.6059!, 365.1668!)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel10.SizeF = New System.Drawing.SizeF(482.3873!, 18.00003!)
        Me.xrLabel10.StylePriority.UseFont = False
        Me.xrLabel10.Text = "Dispatch Related Calls Include Phone Numbers and Addresses of who called."
        '
        'xrLabel11
        '
        Me.xrLabel11.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(151.6059!, 383.1668!)
        Me.xrLabel11.Name = "xrLabel11"
        Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel11.SizeF = New System.Drawing.SizeF(482.3873!, 18.00003!)
        Me.xrLabel11.StylePriority.UseFont = False
        Me.xrLabel11.Text = "When in Doubt, Send It."
        '
        'xrLabel56
        '
        Me.xrLabel56.LocationFloat = New DevExpress.Utils.PointFloat(16.00682!, 401.1668!)
        Me.xrLabel56.Name = "xrLabel56"
        Me.xrLabel56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel56.SizeF = New System.Drawing.SizeF(314.3018!, 23.0!)
        Me.xrLabel56.Text = "***** All Discovery Must Be Received no later than:"
        '
        'xrLine10
        '
        Me.xrLine10.LocationFloat = New DevExpress.Utils.PointFloat(6.006813!, 426.0417!)
        Me.xrLine10.Name = "xrLine10"
        Me.xrLine10.SizeF = New System.Drawing.SizeF(638.0!, 2.0!)
        '
        'xrLine11
        '
        Me.xrLine11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrLine11.LocationFloat = New DevExpress.Utils.PointFloat(16.00682!, 470.2499!)
        Me.xrLine11.Name = "xrLine11"
        Me.xrLine11.SizeF = New System.Drawing.SizeF(157.0!, 2.0!)
        Me.xrLine11.StylePriority.UseBorders = False
        '
        'xrLabel12
        '
        Me.xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(16.00682!, 472.25!)
        Me.xrLabel12.Name = "xrLabel12"
        Me.xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel12.SizeF = New System.Drawing.SizeF(157.0!, 18.0!)
        Me.xrLabel12.Text = "Kenton Circuit Court Clerk"
        '
        'xrLabel57
        '
        Me.xrLabel57.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel57.LocationFloat = New DevExpress.Utils.PointFloat(16.00682!, 452.25!)
        Me.xrLabel57.Name = "xrLabel57"
        Me.xrLabel57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel57.SizeF = New System.Drawing.SizeF(157.0!, 18.0!)
        Me.xrLabel57.StylePriority.UseFont = False
        Me.xrLabel57.Text = "John C. Middleton"
        '
        'xrLabel13
        '
        Me.xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(357.0426!, 434.25!)
        Me.xrLabel13.Name = "xrLabel13"
        Me.xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel13.SizeF = New System.Drawing.SizeF(154.67!, 17.99997!)
        Me.xrLabel13.Text = "Issuing Attorney:"
        '
        'xrLabel14
        '
        Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(357.0426!, 470.2499!)
        Me.xrLabel14.Name = "xrLabel14"
        Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel14.SizeF = New System.Drawing.SizeF(154.67!, 17.99997!)
        Me.xrLabel14.Text = "@KentonCoAtty.com"
        '
        'xrLabel58
        '
        Me.xrLabel58.LocationFloat = New DevExpress.Utils.PointFloat(357.0427!, 488.2499!)
        Me.xrLabel58.Name = "xrLabel58"
        Me.xrLabel58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel58.SizeF = New System.Drawing.SizeF(282.9573!, 18.0!)
        Me.xrLabel58.Text = "ASSISTANT KENTON COUNTY ATTORNEY"
        '
        'xrLabel59
        '
        Me.xrLabel59.LocationFloat = New DevExpress.Utils.PointFloat(357.0427!, 506.2499!)
        Me.xrLabel59.Name = "xrLabel59"
        Me.xrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel59.SizeF = New System.Drawing.SizeF(139.1725!, 17.99988!)
        Me.xrLabel59.Text = "(859)491-0600 EXT"
        '
        'ReportSubpoena
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.pageFooterBand1, Me.reportHeaderBand1, Me.topMarginBand1, Me.bottomMarginBand1})
        Me.DataAdapter = Me.sqlDataAdapter1
        Me.DataMember = "GetSubpoena"
        Me.DataSource = Me.dataSetSubpoena21
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "10.2"
        CType(Me.dataSetSubpoena21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand

#End Region

End Class