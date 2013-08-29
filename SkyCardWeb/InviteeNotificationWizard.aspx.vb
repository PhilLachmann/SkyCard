Imports System.Data
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.IO

Partial Class InviteeNotificationWizard
    Inherits System.Web.UI.Page

    Private theTagDesc As String = ""
    Private theWhereClause As String = ""
    Private theLocationID As Integer = 0
    Private objAssetAuctionToFind As AssetForAuction = Nothing
    Private drListing As DataRow = Nothing

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)

        If Page.IsPostBack = False Then
            Me.GVTitle.Visible = False
            InitInviteeList()
        Else
            mstr.RemoveErrorMessage()

        End If

    End Sub
    Protected Sub InitInviteeList()
        Dim dv As DataView = CType(Me.sqldsSelectInvitees.Select(DataSourceSelectArguments.Empty), DataView)
        Dim dt As DataTable = dv.ToTable
        Dim keys(1) As DataColumn
        Dim pkdc As DataColumn = dt.Columns("ID")
        keys(0) = pkdc
        dt.PrimaryKey = keys

        Session("AuctionInvitees") = dt
        Me.hfdTotalRecords.Value = dt.Rows.Count

        Me.gvSearchRecs.DataSource = dt
        Me.gvSearchRecs.DataBind()

    End Sub

    'Protected Sub wizInviteeNotification_ActiveStepChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles wizInviteeNotification.ActiveStepChanged
    '    Select Case Me.wizInviteeNotification.ActiveStepIndex
    '        Case 0

    '    End Select

    'End Sub

    Protected Sub wizInviteeNotification_NextButtonClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.WizardNavigationEventArgs) Handles wizInviteeNotification.NextButtonClick
        Select Case Me.wizInviteeNotification.ActiveStepIndex
            Case 0
                'save the last page's selections into the session arraylist
                Dim dt As DataTable = Session("AuctionInvitees")

                For Each gvr As GridViewRow In Me.gvSearchRecs.Rows
                    Dim lbl As Label = CType(gvr.FindControl("lblID"), Label)
                    Dim cbx As CheckBox = CType(gvr.FindControl("cbxSelect"), CheckBox)
                    Dim fnddr As DataRow = dt.Rows.Find(lbl.Text)
                    If cbx.Checked = True Then
                        fnddr("selected") = 1
                    Else
                        fnddr("selected") = 0
                    End If
                Next

                Session("AuctionInvitees") = dt

            Case 1
                'check for a message
                If String.IsNullOrEmpty(Me.EmailMessage.Text) Then
                    Dim mstr As GMechMaster = Me.Page.Master
                    mstr.ShowErrorMessage("Please enter your email text.")
                    e.Cancel = True
                    Exit Select
                Else
                    'perform some cleanup if it was a paste from word
                    Dim intXMLelementStart As Integer = Me.EmailMessage.Text.IndexOf("&lt;?xml")
                    If intXMLelementStart > -1 Then
                        Dim intXMLelementEnd As Integer = Me.EmailMessage.Text.IndexOf("/&gt;", intXMLelementStart)
                        Me.EmailMessage.Text = Me.EmailMessage.Text.Substring(0, intXMLelementStart) & Me.EmailMessage.Text.Substring((intXMLelementEnd + 5), Me.EmailMessage.Text.Length - (intXMLelementEnd + 5))
                    End If
                    Me.EmailMessage.Text = Me.EmailMessage.Text.Replace("&lt;o:p&gt;&lt;/o:p&gt;", "")
                    Me.EmailMessage.Text = Me.EmailMessage.Text.Replace("&lt;o:p&gt; &lt;/o:p&gt;", "")
                    Dim a As String = ""
                End If

            Case 2
                'edit for subject
                If String.IsNullOrEmpty(Me.txtSubject.Text) Then
                    Dim mstr As GMechMaster = Me.Page.Master
                    mstr.ShowErrorMessage("Please enter a Subject for the Email.")
                    e.Cancel = True
                    Exit Select
                End If

                'get the uploaded files as attachments
                Dim arrlstMailAttachments As ArrayList = New ArrayList()
                Dim arrlstMailAttachmentBlobs As ArrayList = New ArrayList()
                Dim arrlstMailAttachmentTypes As ArrayList = New ArrayList()
                If Context.Request.Files.Count <= 0 Then
                    'no attachemnts
                Else
                    For i As Integer = 0 To Context.Request.Files.Count - 1
                        Dim file As HttpPostedFile = Context.Request.Files(i)
                        Dim filelen As Integer = file.ContentLength
                        If filelen > 0 Then
                            'Dim attchmnt As New Attachment(file.InputStream, file.FileName, file.ContentType)
                            'the attachments are saved into byte arrays and not into attachments directly because on Server 2003, the files are not read into the streams
                            'until the MailMessage.send() method is called.  By then, the files were closed and inaccessible.
                            'To work around this, the files are read into byte arrays.  At Attachment Creation time, the byte arrays are the input of a memory stream, essentially
                            'recreating the attachment from a memory location.  Then when the Send() is invoked, there is no hiccup trying to read a closed file.
                            Dim filebyte As Byte() = New Byte(filelen - 1) {}
                            file.InputStream.Read(filebyte, 0, filelen)

                            Dim filename As String = System.IO.Path.GetFileName(file.FileName)

                            arrlstMailAttachments.Add(filename)
                            arrlstMailAttachmentBlobs.Add(filebyte)
                            arrlstMailAttachmentTypes.Add(file.ContentType)
                        Else
                            'there ain't no bytes in dat file
                        End If
                    Next
                End If
                Context.Session("MailAttachments") = arrlstMailAttachments
                Context.Session("MailAttachmentBlobs") = arrlstMailAttachmentBlobs
                Context.Session("MailAttachmentTypes") = arrlstMailAttachmentTypes

        End Select

    End Sub

    'Protected Sub wizInviteeNotification_PreviousButtonClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.WizardNavigationEventArgs) Handles wizInviteeNotification.PreviousButtonClick
    '    Select Case Me.wizInviteeNotification.ActiveStepIndex
    '        'Case 1
    '        '    Session("SelectedAssets") = Nothing
    '        'Case 2
    '        '    Session("SelectedAssetsDataTable") = Nothing
    '    End Select

    'End Sub

    Protected Sub wizInviteeNotification_FinishButtonClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.WizardNavigationEventArgs) Handles wizInviteeNotification.FinishButtonClick
        lblInstructions.Visible = False

        'Session("AuctionInvitees") = Nothing
        'Session("MailAttachments") = Nothing
        'Session("MailAttachmentBlobs") = Nothing
        'Session("MailAttachmentTypes") = Nothing

        ''Chrome seems to have a problem redirecting to Alerts, so in the event that the redirect fails, users will at least not be able to shoot themselves in the foot.
        'Dim btnFinish As Button = CType(Me.wizInviteeNotification.FindControl("FinishNavigationTemplateContainerID").FindControl("FinishButton"), Button)
        'Dim btnPrev As Button = CType(Me.wizInviteeNotification.FindControl("FinishNavigationTemplateContainerID").FindControl("PreviousButton"), Button)
        'btnFinish.Enabled = False
        'btnPrev.Enabled = False
        'Me.lblSending.Text = "Invitation Emails Sent"

        Response.Redirect("Alerts.aspx")
        'Response.Redirect("Default.aspx")
    End Sub

    Private Sub ComputePageCountSettings(ByVal intTotalRows As Integer)
        Dim intGVRowDisplayCount As Integer = Me.gvSearchRecs.PageSize
        Dim intPageCount As Integer = 0
        Dim intPageOn As Integer = 0
        Dim intRecCount As Integer = 0
        Dim intRecOnMin As Integer = 0
        Dim intRecOnMax As Integer = 0
        Dim intRemainder As Integer = 0

        'compute the page count
        If intTotalRows > 0 Then
            intPageOn = Me.gvSearchRecs.PageIndex + 1
            intRemainder = intTotalRows Mod intGVRowDisplayCount
            If intRemainder = 0 Then
                intPageCount = intTotalRows \ intGVRowDisplayCount
            Else
                intPageCount = (intTotalRows \ intGVRowDisplayCount) + 1
            End If
        Else
            intPageOn = 0
            intPageCount = 0
        End If

        'compute the record count
        If intTotalRows > 0 Then
            intRecOnMin = intGVRowDisplayCount * (intPageOn - 1) + 1
            intRecOnMax = intGVRowDisplayCount * intPageOn
            intRecCount = intTotalRows
            If intRecOnMax > intRecCount Then
                intRecOnMax = intRecCount
            End If
        Else
            intRecOnMin = 0
            intRecOnMax = 0
            intRecCount = 0
        End If

        'set the text
        Me.lblPageCount.Text = "Page " & intPageOn.ToString & " of " & intPageCount.ToString
        Me.lblRecordCount.Text = "Records (" & intRecOnMin.ToString & " to " & intRecOnMax.ToString & ") of " & intRecCount.ToString

    End Sub

    Protected Sub gvSearchRecs_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvSearchRecs.PageIndexChanging
        Dim dt As DataTable = Session("AuctionInvitees")

        For Each gvr As GridViewRow In Me.gvSearchRecs.Rows
            Dim lbl As Label = CType(gvr.FindControl("lblID"), Label)
            Dim cbx As CheckBox = CType(gvr.FindControl("cbxSelect"), CheckBox)
            Dim fnddr As DataRow = dt.Rows.Find(lbl.Text)
            If cbx.Checked = True Then
                fnddr("selected") = 1
            Else
                fnddr("selected") = 0
            End If
        Next

        Session("AuctionInvitees") = dt

        Me.gvSearchRecs.PageIndex = e.NewPageIndex
        Me.gvSearchRecs.DataSource = dt
        Me.gvSearchRecs.DataBind()

        ComputePageCountSettings(Me.hfdTotalRecords.Value)

    End Sub

    Protected Sub UpdateButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        lblInstructions.Visible = False

        'Chrome seems to have a problem redirecting to Alerts, so in the event that the redirect fails, users will at least not be able to shoot themselves in the foot.
        Dim btnFinish As Button = CType(Me.wizInviteeNotification.FindControl("FinishNavigationTemplateContainerID").FindControl("FinishButton"), Button)
        Dim btnPrev As Button = CType(Me.wizInviteeNotification.FindControl("FinishNavigationTemplateContainerID").FindControl("PreviousButton"), Button)
        btnFinish.Enabled = False
        btnPrev.Enabled = False

        Dim strFromAddress As String = ConfigurationManager.AppSettings("EmailFromAddress")
        Dim strServer As String = ConfigurationManager.AppSettings("EmailServer")
        Dim strSubject As String = Me.txtSubject.Text
        Dim strEmailBody As String = Me.EmailMessage.Text
        Dim arrlstMailAttachments As ArrayList = Session("MailAttachments")
        Dim arrlstMailAttachmentBlobs As ArrayList = Session("MailAttachmentBlobs")
        Dim arrlstMailAttachmentTypes As ArrayList = Session("MailAttachmentTypes")
        Dim client As SmtpClient = New SmtpClient(strServer)

        Dim dt As DataTable = Session("AuctionInvitees")
        If dt.Rows.Count > 0 Then
            For Each dr As DataRow In dt.Rows
                If dr("selected") = 1 Then
                    Dim maFrom As MailAddress = New MailAddress(strFromAddress)
                    Dim maTo As MailAddress = New MailAddress(dr("Email"))

                    Dim mmEmailMessage As MailMessage = New MailMessage(maFrom, maTo)
                    mmEmailMessage.Subject = strSubject
                    mmEmailMessage.Body = strEmailBody
                    mmEmailMessage.IsBodyHtml = True

                    Dim i As Integer = 0
                    For Each attchmntname As String In arrlstMailAttachments
                        Dim filebyte As Byte() = arrlstMailAttachmentBlobs(i)
                        Dim strFileType As String = arrlstMailAttachmentTypes(i)

                        'The attachments are "recreated" here using the blob of bytes that were read in and saved on the prior screen
                        Dim newattachment As Attachment = New Attachment(New MemoryStream(filebyte), attchmntname, strFileType)

                        mmEmailMessage.Attachments.Add(newattachment)
                        i = i + 1
                    Next

                    'send the email to the recipient
                    Try
                        client.Send(mmEmailMessage)
                    Catch ex As Exception
                        Throw ex
                    End Try
                    mmEmailMessage.Dispose()
                    'used for testing
                    'System.Threading.Thread.Sleep(2000)

                End If
            Next
        Else
            Dim mstr As GMechMaster = Me.Page.Master
            mstr.ShowErrorMessage("Your session timed out.  Please attempt the Email notification again.")
        End If

        Session("AuctionInvitees") = Nothing
        Session("MailAttachments") = Nothing
        Session("MailAttachmentBlobs") = Nothing
        Session("MailAttachmentTypes") = Nothing


        'Chrome seems to have a problem redirecting to Alerts, so in the event that the redirect fails, users will at least not be able to shoot themselves in the foot.
        Me.lblSending.Visible = True
        Me.lblSending.Text = "Invitation Emails Sent"



    End Sub

    Protected Sub wizstpConfirmNotifications_Activate(ByVal sender As Object, ByVal e As System.EventArgs) Handles wizstpConfirmNotifications.Activate
        Dim lbl As Label = Me.lblInstructions
        Dim btntrgr As Button = Me.UpdateButton
        Dim btn As Button = CType(Me.wizInviteeNotification.FindControl("FinishNavigationTemplateContainerID").FindControl("FinishButton"), Button)

        btn.Attributes.Add("onclick", "javascript:hideConfirmMessage('" & lbl.ClientID & "','" & btntrgr.ClientID & "','" & Me.lblSending.ClientID & "','" & Me.imgProgBar.ClientID & "');")
        Me.UpdateButton.Attributes.Add("style", "display: none;")
        Me.lblSending.Attributes.Add("style", "display: none;")
        Me.imgProgBar.Attributes.Add("style", "display: none;")
    End Sub
End Class
