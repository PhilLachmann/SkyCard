
Partial Class AssetAddAttachment
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strTagNumber As String = Request.Params.Item("TagNumber")

        Dim arrlstAttachmentKeys As ArrayList = New ArrayList
        arrlstAttachmentKeys.Add(strTagNumber)
        Session("AttachmentKeys") = arrlstAttachmentKeys

        Dim strTextBoxClientID As String = Me.filAssetAttachDocsAddFileName.ClientID

        Me.btnSave.Attributes.Add("onclick", "javascript:returnUploadFile('Save','" & strTextBoxClientID & "');")
        Me.btnCancel.Attributes.Add("onclick", "javascript:returnUploadFile('Cancel','" & strTextBoxClientID & "');")

    End Sub

End Class
