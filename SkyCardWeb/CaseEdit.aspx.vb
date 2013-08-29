Imports System.Data
Imports System.IO

Partial Class CaseEdit
    Inherits System.Web.UI.Page

    Private localAttachmentFilename As String
    Private localAttachmentDirectory As String
    Private localAttachmentType As String

    'constants 
    Friend Const ClaimInformationTab As Integer = 0
    Friend Const AttachedDocumentsTab As Integer = 1
    Friend Const ClaimStatusTab As Integer = 2

    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mstr As GMechMaster = Me.Master

        'for testing
        'Session("CaseID") = "8675309"

        If Not (Request.QueryString("caseID") Is Nothing) Then

            Session("CaseID") = Request.QueryString("caseID").ToString()

        End If


        Dim s As String = Session("CaseID")

        If Page.IsPostBack = False Then
            SetTabLabels()

        Else
            mstr.RemoveErrorMessage()
        End If

    End Sub

    Protected Sub sqldsComments_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsComments.Inserting
        e.Command.Parameters("@CommentTable").Value = "CaseMaster"
        e.Command.Parameters("@CommentID").Value = Session("CaseID")
        e.Command.Parameters("@CommentDesc").Value = Me.CommentsAddTextBox.Text
        e.Command.Parameters("@UserID").Value = Session("Username")
        e.Command.Parameters("@CommentType").Value = Me.ddlCommentType.Text
    End Sub

    Protected Sub sqldsComments_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsComments.Selecting
        'e.Command.Parameters("CommentTable").Value = Session("CommentTable")
        'e.Command.Parameters("CommentID").Value = Session("CommentID").ToString
        e.Command.Parameters("@CommentTable").Value = "CaseMaster"
        e.Command.Parameters("@CommentID").Value = Session("CaseID")


    End Sub




    Protected Sub fvClaim_ItemCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.FormViewCommandEventArgs) Handles fvClaim.ItemCommand

        Select Case e.CommandName
            Case "Cancel"
                Response.Redirect("Default.aspx")
            Case "Print"
                Response.Redirect("PrintClaim.aspx")
            Case "Update"
                If ValidateData() = False Then
                    Exit Sub
                Else
                    Me.sqldsCase.Update()
                End If
        End Select

    End Sub
    Protected Function ValidateData() As Boolean
        Dim bolRetValue As Boolean = True

        Dim row As FormViewRow = Me.fvClaim.Row

     

       

        Return bolRetValue
    End Function

    Protected Sub sqldsCase_Updating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsCase.Updating

        

        Dim row As FormViewRow = Me.fvClaim.Row

        Dim txtCaseNumber As TextBox = CType(row.FindControl("tbCaseNum"), TextBox)
        Dim txtDefendantName As TextBox = CType(row.FindControl("tbDefendant"), TextBox)
        Dim txtDisposition As TextBox = CType(row.FindControl("tbDisposition"), TextBox)
        Dim txtAmendedTo As TextBox = CType(row.FindControl("tbAmendedTo"), TextBox)

        Dim txtDateAssigned As TextBox = CType(row.FindControl("DateInitiated"), TextBox)
        Dim txtArraignmentDate As TextBox = CType(row.FindControl("ArraignmentDate"), TextBox)
        Dim txtPreTrialDate As TextBox = CType(row.FindControl("PreTrialDate"), TextBox)
        Dim txtBenchTrialDate As TextBox = CType(row.FindControl("BenchTrialDate"), TextBox)
        Dim txtJuryTrialDate As TextBox = CType(row.FindControl("JuryTrialDate"), TextBox)

        Dim cbConviction As CheckBox = CType(row.FindControl("cbConviction"), CheckBox)
        Dim cbAmended As CheckBox = CType(row.FindControl("cbAmended"), CheckBox)
        Dim ddlCaseType As DropDownList = CType(row.FindControl("ddlCaseTypes"), DropDownList)
        Dim ddlChargeType As DropDownList = CType(row.FindControl("ddlChargeTypes"), DropDownList)


        e.Command.Parameters("@CaseNumber").Value = txtCaseNumber.Text
        e.Command.Parameters("@DefendantName").Value = txtDefendantName.Text

        If txtDateAssigned.Text.Trim() = "" Then
            e.Command.Parameters("@DateInitiated").Value = Nothing
        Else
            e.Command.Parameters("@DateInitiated").Value = txtDateAssigned.Text
        End If

        If txtArraignmentDate.Text.Trim() = "" Then
            e.Command.Parameters("@ArraignmentDate").Value = Nothing
        Else
            e.Command.Parameters("@ArraignmentDate").Value = txtArraignmentDate.Text
        End If

        If txtPreTrialDate.Text.Trim() = "" Then
            e.Command.Parameters("@PreTrialDate").Value = Nothing
        Else
            e.Command.Parameters("@PreTrialDate").Value = txtPreTrialDate.Text
        End If

        If txtBenchTrialDate.Text.Trim() = "" Then
            e.Command.Parameters("@BenchTrialDate").Value = Nothing
        Else
            e.Command.Parameters("@BenchTrialDate").Value = txtBenchTrialDate.Text
        End If

        If txtJuryTrialDate.Text.Trim() = "" Then
            e.Command.Parameters("@JuryTrialDate").Value = Nothing
        Else
            e.Command.Parameters("@JuryTrialDate").Value = txtJuryTrialDate.Text
        End If

        e.Command.Parameters("@Disposition").Value = txtDisposition.Text
        If cbAmended.Checked = True Then
            e.Command.Parameters("@Amended").Value = 1
        Else
            e.Command.Parameters("@Amended").Value = 0
        End If
        e.Command.Parameters("@AmendedToWhat").Value = txtAmendedTo.Text
        If cbConviction.Checked = True Then
            e.Command.Parameters("@Conviction").Value = 1
        Else
            e.Command.Parameters("@Conviction").Value = 0
        End If
        e.Command.Parameters("@CaseType").Value = ddlCaseType.SelectedValue
        e.Command.Parameters("@ChargeType").Value = ddlChargeType.SelectedValue
        e.Command.Parameters("@Deleted").Value = 0
        e.Command.Parameters("@UserID").Value = Session("Username")

    End Sub


    Protected Sub fvClaim_ItemUpdating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.FormViewUpdateEventArgs) Handles fvClaim.ItemUpdating
        e.Cancel = True
    End Sub

    Protected Sub SetTabLabels()
        'Dim strClaimNumber As String = CType(Me.fvClaim.FindControl("CaseNumberTextBox"), TextBox).Text
        'Dim strClaimNumber As String = "PJL"
        'Me.lblCaseNumber.Text = strClaimNumber
       
    End Sub
    'Protected Sub lbnAddComment_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim strCommentTag As String = "[" & Now.ToString & " - " & Session("LoginID") & "] "

    '    Dim txtComments As TextBox = CType(Me.fvClaim.FindControl("CommentsTextBox"), TextBox)
    '    Dim txtAddComments As TextBox = CType(Me.fvClaim.FindControl("CommentsAddTextBox"), TextBox)

    '    If Not String.IsNullOrEmpty(txtAddComments.Text) Then
    '        txtComments.Text = strCommentTag & txtAddComments.Text & vbCrLf & txtComments.Text
    '    End If

    '    txtAddComments.Text = ""
    '    Me.Tabs.ActiveTabIndex = ClaimInformationTab

    'End Sub

    Protected Sub AddNewComments()
        
    End Sub

    Protected Sub gvAttachedDocuments_Sorted(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Tabs.ActiveTabIndex = AttachedDocumentsTab
    End Sub

    


    Protected Sub ClaimTypeIDTextBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)

       

    End Sub
   

    'Protected Sub btnAddClaimStatusComment_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddClaimStatusComment.Click
    '    If ClaimStatusValidateData() = False Then
    '        Exit Sub
    '    Else
    '        Me.sqldsClaimStatusComments.Insert()
    '        Me.calCommentDate.SelectedDate = Today()
    '        Me.txtCommentBy.Text = ""
    '        Me.txtCommentSentTo.Text = ""
    '        Me.txtCommentText.Text = ""
    '        fvClaim.DataBind()
    '        Me.Tabs.ActiveTabIndex = ClaimStatusTab
    '    End If

    'End Sub
   

    'Protected Sub sqldsClaimStatusComments_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsClaimStatusComments.Inserting

    '    e.Command.Parameters("@ClaimID").Value = Session("ClaimID")
    '    e.Command.Parameters("@NewCommentDate").Value = Me.txtCommentDate.Text
    '    e.Command.Parameters("@NewCommentSentTo").Value = Me.txtCommentSentTo.Text
    '    e.Command.Parameters("@NewCommentByUser").Value = Me.txtCommentBy.Text
    '    e.Command.Parameters("@NewCommentCreatedBy").Value = Session("LoginID")
    '    e.Command.Parameters("@NewCommentText").Value = Me.txtCommentText.Text

    'End Sub

    Protected Sub sqldsClaimStatusComments_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs)
        e.Command.Parameters("@ClaimID").Value = Session("ClaimID")
    End Sub

    Protected Sub gvClaimStatusComments_Sorted(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Tabs.ActiveTabIndex = ClaimStatusTab
    End Sub

   

    Protected Sub lbnAddAdjuster_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        

    End Sub

    Protected Sub ClaimTypeIDTextBox_DataBound(ByVal sender As Object, ByVal e As System.EventArgs)

       

    End Sub

    Protected Sub AdjusterIDTextBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)

       

    End Sub

    Protected Sub AdjusterIDTextBox_DataBound(ByVal sender As Object, ByVal e As System.EventArgs)
        'set the phone and cell
        

    End Sub

    Protected Sub btnAddComment_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddComment.Click
        Me.sqldsComments.Insert()
        Me.CommentsAddTextBox.Text = ""
    End Sub

    Protected Sub btnUpload_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        Dim path As String = Server.MapPath("~/UploadedFiles/")
        Dim fullpath As String
        Dim fileOK As Boolean = False
        If FileUpload1.HasFile Then
           
            localAttachmentFilename = ""
            localAttachmentDirectory = ""
            localAttachmentType = ""

            Try
                'get the case number
                Dim casenum As String = Session("CaseID")
                'if there is no directory with the casenumber then create one
                fullpath = path + casenum + "\"

                If Not Directory.Exists(fullpath) Then
                    Directory.CreateDirectory(fullpath)
                End If

                FileUpload1.PostedFile.SaveAs(fullpath & FileUpload1.FileName)
                Label1.Text = "File uploaded!"

                'file uploaded add the appropriate db entry
                localAttachmentFilename = FileUpload1.FileName
                localAttachmentDirectory = fullpath
                localAttachmentType = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower()
                Me.sqldsAttachment.Insert()

            Catch ex As Exception
                Label1.Text = "File could not be uploaded."
            End Try
        
        End If
    End Sub

    Protected Sub sqldsAttachment_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsAttachment.Inserting
        e.Command.Parameters("@CaseNumber").Value = Session("CaseID")
        e.Command.Parameters("@AttachmentFileName").Value = localAttachmentFilename
        e.Command.Parameters("@AttachmentType").Value = localAttachmentType
        e.Command.Parameters("@DirectoryLocation").Value = localAttachmentDirectory
    End Sub


    Protected Sub sqldsAttachment_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsAttachment.Selecting
       
        e.Command.Parameters("@CaseNumber").Value = Session("CaseID")


    End Sub

    Protected Sub sqldsContacts_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsContacts.Inserting
        e.Command.Parameters("@CaseNumber").Value = Session("CaseID")
        e.Command.Parameters("@ContactID").Value = Me.ddlContact.SelectedValue()
        e.Command.Parameters("@ContactTypeID").Value = Me.ddlContactType.SelectedValue()
    End Sub

    Protected Sub sqldsContacts_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsContacts.Selecting
        e.Command.Parameters("@CaseNumber").Value = Session("CaseID")
    End Sub

    Protected Sub btnAddContact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddContact.Click
        sqldsContacts.Insert()
    End Sub

    Protected Sub sqldsCharges_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsCharges.Inserting
        e.Command.Parameters("@CaseNumber").Value = Session("CaseID")
        e.Command.Parameters("@ChargeUOR").Value = Me.ddlCharge.SelectedValue()
    End Sub

    Protected Sub sqldsCharges_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsCharges.Selecting
        e.Command.Parameters("@CaseNumber").Value = Session("CaseID")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        sqldsCharges.Insert()
    End Sub

    Protected Sub sqldsSubpoenas_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsSubpoenas.Inserting
        e.Command.Parameters("@CaseNumber").Value = Session("CaseID")

        Dim row As FormViewRow = Me.fvClaim.Row
        Dim txtDefendantName As TextBox = CType(row.FindControl("tbDefendant"), TextBox)
        e.Command.Parameters("@DefendantName").Value = txtDefendantName.Text
        e.Command.Parameters("@WitnessName").Value = Me.tbWitnessName.Text
        e.Command.Parameters("@WitnessAddress1").Value = Me.tbWitnessAddress1.Text
        e.Command.Parameters("@WitnessAddress2").Value = Me.tbWitnessAddress2.Text
        e.Command.Parameters("@WitnessCity").Value = Me.tbWitnessCity.Text
        e.Command.Parameters("@WitnessState").Value = Me.tbWitnessState.Text
        e.Command.Parameters("@WitnessZip").Value = Me.tbWitnessZip.Text
        e.Command.Parameters("@AppearDate").Value = Me.AppearanceDate.Text + " " + ddlHour.SelectedValue + ":" + ddlMinute.SelectedValue + " " + ddlAMPM.SelectedValue
        e.Command.Parameters("@Courtroom").Value = Me.tbCourtroom.Text
        If Me.cbtestify.Checked = True Then
            e.Command.Parameters("@Testify").Value = 1
        Else
            e.Command.Parameters("@Testify").Value = 0
        End If
        If Me.cbProduce.Checked = True Then
            e.Command.Parameters("@Produce").Value = 1
        Else
            e.Command.Parameters("@Produce").Value = 0
        End If
        e.Command.Parameters("@DiscoveryDueDate").Value = Me.DiscoveryDueDate.Text
        e.Command.Parameters("@RequestingAtty").Value = Me.tbAtty.Text
        e.Command.Parameters("@AttyExt").Value = Me.tbAttyExt.Text
       
    End Sub

    Protected Sub sqldsSubpoenas_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsSubpoenas.Selecting
        e.Command.Parameters("@CaseNumber").Value = Session("CaseID")
    End Sub

    Protected Sub btnAddSubpoena_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddSubpoena.Click
        sqldsSubpoenas.Insert()
    End Sub

    'Protected Sub gvSearchRecs_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvSearchRecs.SelectedIndexChanged
    '    'Session("CommentTable") = "DogPermit"
    '    Dim dv As DataView = CType(Me.sqldsCompanyHeaderInfo.Select(DataSourceSelectArguments.Empty), DataView)

    '    Dim dt As DataTable = dv.ToTable
    '    If dt.Rows.Count > 0 Then
    '        Dim dr As DataRow = dt.Rows(0)
    '        Session("PermitIssuingEntity") = dr("CompanyName")
    '    End If

    '    Session("RecordID") = CType(sender, GridView).SelectedDataKey.Value.ToString()

    '    Dim arrlstSearchCriteria As ArrayList = New ArrayList()
    '    arrlstSearchCriteria.Add(False)
    '    arrlstSearchCriteria.Add(Me.txtPermitNumber.Text)
    '    arrlstSearchCriteria.Add(Me.txtDateStart.Text)
    '    arrlstSearchCriteria.Add(Me.txtDateEnd.Text)
    '    arrlstSearchCriteria.Add(Me.txtVendorName.Text)
    '    arrlstSearchCriteria.Add(Me.ddlVendorState.SelectedValue)
    '    arrlstSearchCriteria.Add(Me.txtVendorZipCode.Text)
    '    arrlstSearchCriteria.Add(Me.txtVendorID.Text)
    '    Session("SearchCriteria") = arrlstSearchCriteria

    '    Response.Redirect("PrintDogPermit.aspx")

    'End Sub

    Protected Sub gvSaerchRecs_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvSaerchRecs.SelectedIndexChanged

        Session("RecordID") = CType(sender, GridView).SelectedDataKey.Value.ToString()

        Response.Redirect("PrintSubpoena.aspx")
    End Sub
End Class
