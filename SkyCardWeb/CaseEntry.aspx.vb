
Partial Class CaseEntry
    Inherits System.Web.UI.Page
    Private arrControlBaseNames As String() = {"ItemID", "ItemDesc", "Barcode", "Size"}

    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)

        If Page.IsPostBack = False Then
            

            'Me.Size.DataSourceID = "sqldsSizeLookup"
            'Me.Size.DataBind()

            

        Else
            mstr.RemoveErrorMessage()
        End If

        Session("ItemID") = Nothing

    End Sub


    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If sqldsCase.Insert() Then
            lblContentBodyError.Text = "Case Added Successfully"
            lblContentBodyError.Visible = True

            Dim intCaseID As String = Me.tbCaseNum.Text

            Session("CaseID") = intCaseID
            Response.Redirect("CaseEdit.aspx")
        Else
            lblContentBodyError.Text = "Error - Problem adding case."
            lblContentBodyError.Visible = True
        End If
       

    End Sub

    Protected Sub ClearForm()
        Me.tbCaseNum.Text = ""
        Me.tbDefendant.Text = ""
        Me.DateInitiated.Text = ""
        Me.ArraignmentDate.Text = ""
        Me.PretrialDate.Text = ""
        Me.BenchTrialDate.Text = ""
        Me.JuryTrialDate.Text = ""
        Me.tbDisposition.Text = ""
        Me.cbAmended.Checked = False
        Me.tbAmendedTo.Text = ""
        Me.cbConviction.Checked = False
        Me.ddlCaseTypes.SelectedIndex = 0
        Me.ddlChargeTypes.SelectedIndex = 0
    End Sub
   


    Protected Sub sqldsCase_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsCase.Inserting
        e.Command.Parameters("@CaseNumber").Value = Me.tbCaseNum.Text
        e.Command.Parameters("@DefendantName").Value = Me.tbDefendant.Text
        e.Command.Parameters("@DateInitiated").Value = Me.DateInitiated.Text
        e.Command.Parameters("@ArraignmentDate").Value = Me.ArraignmentDate.Text
        e.Command.Parameters("@PretrialDate").Value = Me.PretrialDate.Text
        e.Command.Parameters("@BenchTrialDate").Value = Me.BenchTrialDate.Text
        e.Command.Parameters("@JuryTrialDate").Value = Me.JuryTrialDate.Text
        e.Command.Parameters("@Disposition").Value = Me.tbDisposition.Text

        If Me.cbAmended.Checked = True Then
            e.Command.Parameters("@Amended").Value = 1
        Else
            e.Command.Parameters("@Amended").Value = 0
        End If

        e.Command.Parameters("@AmendedToWhat").Value = Me.tbAmendedTo.Text

        If Me.cbConviction.Checked = True Then
            e.Command.Parameters("@Conviction").Value = 1
        Else
            e.Command.Parameters("@Conviction").Value = 0
        End If

        e.Command.Parameters("@CaseType").Value = Me.ddlCaseTypes.SelectedItem.Text
        e.Command.Parameters("@ChargeType").Value = Me.ddlChargeTypes.SelectedItem.Text
        e.Command.Parameters("@UserID").Value = Session("Username")

    End Sub
End Class
