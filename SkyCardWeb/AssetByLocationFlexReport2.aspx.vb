Imports System.Data.Odbc
Imports DevExpress.XtraReports.UI
Imports System.Data
Imports System.Drawing

Partial Class AssetByLocationFlexReport2
    Inherits System.Web.UI.Page
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Page.IsPostBack = False Then
            Me.pnlReport.Visible = False
            'these need to be loaded programmatically in order to force the Databind early (so that we can set defaults in the DataBound)
            Me.BuildingID.DataSourceID = "sqldsBuildings"
            Me.BuildingID.DataBind()
            Me.LocationID.DataSourceID = "sqldsLocations"
            Me.LocationID.DataBind()

            Session("ReportObjs") = Nothing
        Else
            Me.hfdFirstTime.Value = Me.hfdFirstTime.Value + 1

            Dim body As HtmlGenericControl = CType(Me.Master.FindControl("body"), HtmlGenericControl)
            Dim pnl As Panel = CType(Me.pnlFullSize, Panel)
            Dim strpnlClientID As String = pnl.ClientID
            body.Attributes.Add("onLoad", "javascript:window.status = 'Ready';hideLargeViewers('" & strpnlClientID & "');")

            If Session("ReportObjs") Is Nothing Then
                'there is nothing to set in the viewers
            Else
                Dim arrlstReportObjs As ArrayList = Session("ReportObjs")
                Dim rpta As XtraReport = arrlstReportObjs(0)
                'Dim rpt As XtraReport = arrlstReportObjs(1)
                rpta.CreateDocument()
                'rpt.CreateDocument()
                Me.rptvwrExcel.Report = rpta
                'Me.rptvwrOrders.Report = rpt
                Session("ReportObjs") = Nothing
            End If


        End If


    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click

        Response.Redirect("Default.aspx")

    End Sub

    Protected Sub LocationID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LocationID.SelectedIndexChanged
        If Me.hfdFirstTime.Value > 1 Then
            Me.pnlReport.Visible = False
        Else
            Me.pnlReport.Visible = True
        End If
    End Sub

    Protected Sub BuildingID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BuildingID.SelectedIndexChanged

        If Me.hfdFirstTime.Value > 1 Then
            Me.pnlReport.Visible = False
        Else
            Me.pnlReport.Visible = True
        End If

        Me.LocationID.Items.Clear()
        Dim itm As ListItem = New ListItem("All", "0")
        Me.LocationID.Items.Add(itm)
        Me.LocationID.DataBind()

    End Sub

    Protected Sub sqldsLocations_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsLocations.Selecting
        If e.Command.Parameters("theRoot").Value = 0 Then
            e.Command.Parameters("theRoot").Value = -1
        End If
    End Sub

    Protected Sub btnRunReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRunReport.Click
        'prepare page for presenting report
        Me.pnlReport.Visible = True
        Dim body As HtmlGenericControl = CType(Me.Master.FindControl("body"), HtmlGenericControl)
        Dim rptvwr As DevExpress.XtraReports.Web.ReportViewer = CType(Me.rptvwrExcel, DevExpress.XtraReports.Web.ReportViewer)
        Dim strrptvwrClientID As String = rptvwr.ClientID
        Dim strCurrentOnclick As String = body.Attributes.Item("onLoad")
        body.Attributes.Add("onLoad", strCurrentOnclick & "exportToExcel('" & strrptvwrClientID & "');")


        ' Create XtraReport online instance
        Dim rpt As XtraReport = New XtraReport()
        rpt.PaperKind = Printing.PaperKind.Custom
        rpt.Landscape = True
        rpt.PageWidth = 1530
        rpt.PageHeight = 850


        ' Create XtraReport Excel instance
        Dim rpta As XtraReport = New XtraReport()
        rpta.PaperKind = Printing.PaperKind.Custom
        rpta.Landscape = True
        rpta.PageWidth = 4000
        rpta.PageHeight = 20000



        ' Set the XtraReport.DataSource
        rpt.DataSource = FillDataset()
        rpt.DataMember = (CType(rpt.DataSource, DataSet)).Tables(0).TableName

        rpta.DataSource = FillDataset()
        rpta.DataMember = (CType(rpt.DataSource, DataSet)).Tables(0).TableName


        ' Add required bands to the Xtrareport.Bands collection
        InitBands(rpt)
        InitBands(rpta)

        ' Arrange required controls on bands and bind the controls to data
        ' Use XRLabels to display data
        CreateReportObjects(rpt)
        CreateReportObjects(rpta)


        Dim arrlstReportObjs As ArrayList = New ArrayList
        'full size report loaded
        'Dim rpta As XtraReport = New XtraReport()
        'rpta = rpt
        rpta.CreateDocument()
        arrlstReportObjs.Add(rpta)

        rpt.CreateDocument()
        rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1


        'Me.rptvwrOrders.Report = rpt


        'Me.rptvwrExcel.Report = rpt
        Session("ReportObjs") = Nothing
        Session("ReportObjs") = arrlstReportObjs


    End Sub

    Public Function FillDataset() As DataSet


        Dim dataSet1 As DataSet = New DataSet()
        dataSet1.DataSetName = "AssetsByLocationDataSet"

        Dim dv As DataView = CType(Me.sqldsReportData.Select(DataSourceSelectArguments.Empty), DataView)
        Dim dt As DataTable = dv.ToTable
        dt.TableName = "ReportData"
        'Dim dvm As DataView = CType(Me.sqldsMoreReportData.Select(DataSourceSelectArguments.Empty), DataView)
        'Dim dtm As DataTable = dvm.ToTable
        'dtm.TableName = "GroupData"

        dataSet1.Tables.Add(dt)
        'dataSet1.Tables.Add(dtm)

        Return dataSet1

    End Function

    Public Sub InitBands(ByRef rpt As XtraReport)
        ' Create bands
        Dim detail As DetailBand = New DetailBand()
        detail.Name = "dtlBand"
        detail.Height = 20

        Dim pageHeader As PageHeaderBand = New PageHeaderBand()
        pageHeader.Height = 45

        Dim reportFooter As ReportFooterBand = New ReportFooterBand()
        reportFooter.Height = 25

        Dim pgFooter As PageFooterBand = New PageFooterBand()
        pgFooter.Height = 52

        'Dim grpHeader As GroupHeaderBand = New GroupHeaderBand()
        'grpHeader.Name = "grpHeader1"
        'grpHeader.HeightF = 25
        'grpHeader.Level = 1
        'grpHeader.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ParentDesc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("LocDesc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})


        'Dim grpFooter As GroupFooterBand = New GroupFooterBand()
        'grpFooter.Name = "grpFooter1"
        'grpFooter.HeightF = 33
        'grpFooter.Level = 1


        Dim grpHeader0 As GroupHeaderBand = New GroupHeaderBand()
        grpHeader0.Name = "grpHeader0"
        grpHeader0.HeightF = 25
        grpHeader0.Level = 0

        Dim grpFooter0 As GroupFooterBand = New GroupFooterBand()
        grpFooter0.HeightF = 0
        grpFooter0.Level = 0
        grpFooter0.Name = "grpFooter0"


        ' Place the bands onto a report
        rpt.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {detail, pageHeader, pgFooter, grpHeader0, grpFooter0, reportFooter})
        'rpt.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {detail, pageHeader, pgFooter, grpHeader, grpFooter, grpHeader0, grpFooter0, reportFooter})
    End Sub

    Public Sub CreateReportObjects(ByRef rpt As XtraReport)
        Dim ds As DataSet = (CType(rpt.DataSource, DataSet))
        Dim colCount As Integer = ds.Tables(0).Columns.Count

        'page header controls
        Dim lbl As XRLabel = New XRLabel()
        lbl.Location = New Point(0, 0)
        lbl.Size = New Size(rpt.PageWidth, 33)
        lbl.Text = "Assets By Location"
        lbl.ForeColor = Color.Maroon
        lbl.Font = New Drawing.Font("Times New Roman", 20, FontStyle.Bold)
        rpt.Bands(BandKind.PageHeader).Controls.Add(lbl)

        'rpt footer controls
        Dim lblz As XRLabel = New XRLabel()
        lblz.Location = New Point(0, 0)
        lblz.Size = New Size(rpt.PageWidth, 25)
        lblz.Text = String.Format("{0:dddd, MMMM dd, yyyy}", Today())
        lblz.ForeColor = Color.Black
        lblz.Font = New Drawing.Font("Times New Roman", 10, FontStyle.Bold)
        rpt.Bands(BandKind.ReportFooter).Controls.Add(lblz)



        ''groupheader controls
        'For j As Integer = 1 To 3
        '    Dim lbl1 As XRLabel = New XRLabel()
        '    lbl1.ForeColor = Color.Maroon
        '    lbl1.Font = New Drawing.Font("Arial", 10, FontStyle.Bold)
        '    Select Case j
        '        Case 1
        '            lbl1.Location = New Point(0, 0)
        '            lbl1.Size = New Size(444, 20)
        '            lbl1.DataBindings.Add("Text", Nothing, ds.Tables(0).Columns("ParentDesc").Caption)
        '        Case 2
        '            lbl1.Location = New Point(452, 0)
        '            lbl1.Size = New Size(36, 20)
        '            lbl1.Text = "Loc:"
        '        Case 3
        '            lbl1.Location = New Point(492, 0)
        '            lbl1.Size = New Size(388, 20)
        '            lbl1.DataBindings.Add("Text", Nothing, ds.Tables(0).Columns("LocDesc").Caption)
        '    End Select

        '    rpt.Bands("grpHeader1").Controls.Add(lbl1)
        'Next

        Dim intNextColumnStartX As Integer = 0
        ' Create header captions
        For i As Integer = 0 To colCount - 1
            Dim colWidth As Integer = 0
            Dim strRawCaption As String = ds.Tables(0).Columns(i).Caption
            If Not strRawCaption.Contains("|") Then
                strRawCaption = strRawCaption & "|String"
            End If
            Dim arrTagInfo As String() = strRawCaption.Split("|")
            Dim strDataType As String = arrTagInfo(1)
            Dim strTagName As String = arrTagInfo(0)
            Select Case strTagName
                Case "ParentDesc"
                    'need to create a lable in the grp hdr band
                    colWidth = 280
                    'Case "ParentDesc", "LocDesc"
                    '    'need to create a lable in the grp hdr band
                Case "Description"
                    colWidth = 280
                Case "Last Modified"
                    colWidth = 150
                Case "Comments"
                    colWidth = 200
                Case Else
                    Select Case strDataType
                        Case "Timestamp"
                            colWidth = 150
                        Case Else
                            colWidth = 100
                    End Select
            End Select


            If colWidth > 0 Then
                Dim label As XRLabel = New XRLabel()
                label.Location = New Point(intNextColumnStartX, 0)
                label.Size = New Size(colWidth, 25)
                label.Text = strTagName
                label.CanGrow = False
                label.CanShrink = False
                label.Font = New Drawing.Font("Times New Roman", 10, FontStyle.Bold)
                label.Borders = DevExpress.XtraPrinting.BorderSide.All
                label.BackColor = Drawing.Color.FromArgb(255, 255, 204, 153)
                label.BorderColor = Drawing.Color.FromArgb(255, 128, 128, 128)

                ' Place the headers onto a grpHeader0 band
                rpt.Bands("grpHeader0").Controls.Add(label)
            End If


            If colWidth > 0 Then
                Dim label As XRLabel = New XRLabel()
                label.Location = New Point(intNextColumnStartX, 0)
                label.Size = New Size(colWidth, 25)
                label.CanGrow = False
                label.CanShrink = False
                'If strTagName = "TagNumber" Then
                '    label.BackColor = Drawing.Color.FromArgb(255, 255, 204, 153)
                'End If
                Select Case strTagName
                    Case "TagNumber", "ParentDesc", "LocDesc"
                        label.BackColor = Drawing.Color.FromArgb(255, 255, 204, 153)
                    Case Else
                        'no label color
                End Select
                label.Borders = DevExpress.XtraPrinting.BorderSide.All
                label.BorderColor = Drawing.Color.FromArgb(255, 128, 128, 128)
                label.DataBindings.Add("Text", Nothing, ds.Tables(0).Columns(i).Caption)


                Select Case strDataType
                    Case "Integer"
                        AddHandler label.BeforePrint, AddressOf xrIntegerLabel_BeforePrint
                    Case "Decimal"
                        AddHandler label.BeforePrint, AddressOf xrDecimalLabel_BeforePrint
                    Case "Timestamp"
                        AddHandler label.BeforePrint, AddressOf xrDateTimeLabel_BeforePrint
                    Case Else
                        'no format, just print the string
                End Select

                '' Place the labels onto a Detail band
                rpt.Bands("dtlBand").Controls.Add(label)
                intNextColumnStartX = intNextColumnStartX + colWidth
            End If

        Next i


        'Dim lblFtr As XRLabel = New XRLabel()
        'lblFtr.Location = New Point(0, 0)
        'lblFtr.Size = New Size(20, 1)
        'lblFtr.Text = ""
        'lblFtr.CanGrow = False
        'lblFtr.CanShrink = False
        'rpt.Bands("grpFooter1").Controls.Add(lblFtr)


    End Sub
    Private Sub xrDateTimeLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)

        Dim a As String = ""
        Dim strText As String = CType(sender, XRLabel).Text
        If Not String.IsNullOrEmpty(strText) Then
            Dim arrstrTimestamp As String() = strText.Split(",")
            If arrstrTimestamp.Length > 0 Then
                Dim dtTimestamp As DateTime = CType(arrstrTimestamp(0), DateTime)
                CType(sender, XRLabel).Text = String.Format("{0:MM/dd/yyyy hh:mm:ss tt}", dtTimestamp)
            End If
        End If

    End Sub

    Private Sub xrIntegerLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)

        Dim a As String = ""
        Dim strText As String = CType(sender, XRLabel).Text
        If Not String.IsNullOrEmpty(strText) Then
            Dim arrstrNumbers As String() = strText.Split(",")
            If arrstrNumbers.Length > 0 Then
                Dim intNumber As Integer = CType(arrstrNumbers(0), Integer)
                CType(sender, XRLabel).Text = intNumber.ToString
            End If
        End If

    End Sub

    Private Sub xrDecimalLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)

        Dim a As String = ""
        Dim strText As String = CType(sender, XRLabel).Text
        If Not String.IsNullOrEmpty(strText) Then
            Dim arrstrNumbers As String() = strText.Split(",")
            If arrstrNumbers.Length > 0 Then
                Dim decNumber As Decimal = CType(arrstrNumbers(0), Decimal)
                CType(sender, XRLabel).Text = String.Format("{0:F2}", decNumber)
            End If
        End If

    End Sub


    Protected Sub sqldsReportData_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsReportData.Selecting
        Dim strChosenTagnames As String = ""
        For Each litem As ListItem In Me.SelectedTagNames.Items
            If litem.Selected = True Then
                If String.IsNullOrEmpty(strChosenTagnames) Then
                    strChosenTagnames = litem.Value.ToString
                Else
                    strChosenTagnames = strChosenTagnames & "," & litem.Value.ToString
                End If

            End If
        Next

        e.Command.Parameters("theLocationID").Value = IIf(Me.LocationID.SelectedValue = 0, Me.BuildingID.SelectedValue, Me.LocationID.SelectedValue)
        e.Command.Parameters("theTagNameIDList").Value = strChosenTagnames

    End Sub

    Protected Sub rptvwrExcel_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles rptvwrExcel.Unload
        rptvwrExcel.Report = Nothing
    End Sub

    Protected Sub rptvwrOrders_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles rptvwrOrders.Unload
        rptvwrOrders.Report = Nothing
    End Sub

End Class
