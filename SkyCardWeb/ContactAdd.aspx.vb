Imports System.Data

Partial Class ContactAdd
    Inherits System.Web.UI.Page
    Private strErrMsgText As String = ""
    Private strContactID As String = ""

    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
        If Page.IsPostBack = False Then
            'Dim dv As DataView = CType(Me.sqldsLookupTableData.Select(DataSourceSelectArguments.Empty), DataView)

            'Dim dt As DataTable = dv.ToTable
            'Dim dr As DataRow = dt.NewRow()
            ''dr("LinkID") = 0
            ''dr("Deleted") = 0
            'dt.Rows.Add(dr)

            'Me.dvContact.DataSource = dt
            'Me.dvContact.DataBind()
        Else
            mstr.RemoveErrorMessage()

        End If
    End Sub

    Protected Sub sqldsLookupTableData_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsLookupTableData.Selecting
        ' Dim strContactID As String = Session("ContactID").ToString
        ' e.Command.Parameters("@ContactID").Value = strContactID

    End Sub
    Protected Sub sqldsLookupTableData_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsLookupTableData.Inserted
        If e.AffectedRows <> 0 Then
            'success
            'The function that does the insert returns the New ID of the newly inserted record
            'strContactID = e.Command.Parameters("@return_value").Value
        Else
            strErrMsgText = e.Exception.Message
            e.ExceptionHandled = True
        End If
    End Sub

    Protected Sub sqldsLookupTableData_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Inserting

        Dim row As DetailsViewRow = Me.dvContact.Rows(0)


        'Dim strContactIDKey As String = Me.dvContact.DataKey.Value.ToString
        Dim txtContactName As TextBox = CType(row.FindControl("ContactName"), TextBox)
        Dim txtFirstName As TextBox = CType(row.FindControl("FirstName"), TextBox)
        Dim txtMiddleName As TextBox = CType(row.FindControl("MiddleName"), TextBox)
        Dim txtLastName As TextBox = CType(row.FindControl("LastName"), TextBox)
        Dim txtDateOfBirth As TextBox = CType(row.FindControl("DateOfBirth"), TextBox)
        Dim txtSSN As TextBox = CType(row.FindControl("SocialSecurityNumber"), TextBox)
        Dim txtAddress1 As TextBox = CType(row.FindControl("Address1"), TextBox)
        Dim txtAddress2 As TextBox = CType(row.FindControl("Address2"), TextBox)
        Dim txtAddress3 As TextBox = CType(row.FindControl("Address3"), TextBox)
        Dim txtCity As TextBox = CType(row.FindControl("City"), TextBox)
        Dim ddlState As DropDownList = CType(row.FindControl("State"), DropDownList)
        Dim txtZip As TextBox = CType(row.FindControl("Zip"), TextBox)
        Dim txtCountry As TextBox = CType(row.FindControl("Country"), TextBox)
        Dim txtPhone1 As TextBox = CType(row.FindControl("Phone1"), TextBox)
        Dim txtPhone2 As TextBox = CType(row.FindControl("Phone2"), TextBox)
        Dim txtPhone3 As TextBox = CType(row.FindControl("Phone3"), TextBox)
        Dim txtEmail1 As TextBox = CType(row.FindControl("Email1"), TextBox)
        Dim txtEmail2 As TextBox = CType(row.FindControl("Email2"), TextBox)
        Dim txtEmail3 As TextBox = CType(row.FindControl("Email3"), TextBox)
        Dim txtGender As TextBox = CType(row.FindControl("Gender"), TextBox)
        Dim txtRace As TextBox = CType(row.FindControl("Race"), TextBox)
        Dim txtAlias As TextBox = CType(row.FindControl("AliasName"), TextBox)
        'Dim ddlDeleted As DropDownList = CType(row.FindControl("Deleted"), DropDownList)

        'If String.IsNullOrEmpty(txtContactName.Text) Or String.IsNullOrEmpty(txtContactName.Text) Or String.IsNullOrEmpty(txtContactAddress1.Text) Or String.IsNullOrEmpty(txtContactCity.Text) Or String.IsNullOrEmpty(ddlContactState.SelectedValue) Or String.IsNullOrEmpty(txtContactZipCode.Text) Or String.IsNullOrEmpty(txtContactEmail.Text) Then
        '    Me.lblContentBodyError.Text = "The Contact Name, Contact Name, Address, City, State, Zip and Email are all required."
        '    Me.lblContentBodyError.Visible = True
        '    e.Cancel = True
        '    Exit Sub
        'End If

        'If String.IsNullOrEmpty(txtContactWorkPhone.Text.Replace("_", "").Replace("-", "")) And String.IsNullOrEmpty(txtContactCellPhone.Text.Replace("_", "").Replace("-", "")) And String.IsNullOrEmpty(txtContactHomePhone.Text.Replace("_", "").Replace("-", "")) Then
        '    Me.lblContentBodyError.Text = "At least one phone number is required"
        '    Me.lblContentBodyError.Visible = True
        '    e.Cancel = True
        '    Exit Sub
        'End If

        'e.Command.Parameters("@ContactID").Value = CInt(strContactIDKey)
        e.Command.Parameters("@ContactName").Value = txtContactName.Text
        e.Command.Parameters("@FirstName").Value = txtFirstName.Text
        e.Command.Parameters("@MiddleName").Value = txtMiddleName.Text
        e.Command.Parameters("@LastName").Value = txtLastName.Text
        e.Command.Parameters("@DateOfBirth").Value = txtDateOfBirth.Text
        e.Command.Parameters("@SocialSecurityNumber").Value = txtSSN.Text
        e.Command.Parameters("@Address1").Value = txtAddress1.Text
        e.Command.Parameters("@Address2").Value = txtAddress2.Text
        e.Command.Parameters("@Address3").Value = txtAddress3.Text
        e.Command.Parameters("@City").Value = txtCity.Text
        e.Command.Parameters("@State").Value = ddlState.SelectedValue
        e.Command.Parameters("@Zip").Value = txtZip.Text
        e.Command.Parameters("@Country").Value = txtCountry.Text
        e.Command.Parameters("@Phone1").Value = txtPhone1.Text
        e.Command.Parameters("@Phone2").Value = txtPhone2.Text
        e.Command.Parameters("@Phone3").Value = txtPhone3.Text
        e.Command.Parameters("@Email1").Value = txtEmail1.Text
        e.Command.Parameters("@Email2").Value = txtEmail2.Text
        e.Command.Parameters("@Email3").Value = txtEmail3.Text
        e.Command.Parameters("@Gender").Value = txtGender.Text
        e.Command.Parameters("@Race").Value = txtRace.Text
        e.Command.Parameters("@AliasName").Value = txtAlias.Text
        'e.Command.Parameters("@Deleted").Value = ddlDeleted.SelectedValue

        e.Command.Parameters("UserID").Value = Session("Username")
    End Sub

    Protected Sub btnCancelContact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelContact.Click
        Dim arrlstSearchCriteria As ArrayList = Session("SearchCriteria")
        arrlstSearchCriteria(0) = True
        Session("SearchCriteria") = arrlstSearchCriteria

        Response.Redirect("SearchContactMaster.aspx")

    End Sub

    Protected Sub btnAddContact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddContact.Click
        Try
            Dim intAffectedRows As Integer = Me.sqldsLookupTableData.Insert()
            If intAffectedRows > 0 Then
                Dim arrlstSearchCriteria As ArrayList = Session("SearchCriteria")
                arrlstSearchCriteria(0) = True
                Session("SearchCriteria") = arrlstSearchCriteria

                Response.Redirect("SearchContactMaster.aspx")
            Else
                If Me.lblContentBodyError.Visible = True Then
                    'let the message be seen
                Else
                    Me.lblContentBodyError.Text = "An Error was encountered: No Rows were updated."
                    Me.lblContentBodyError.Visible = True
                End If
            End If
        Catch ex As Exception
            Me.lblContentBodyError.Text = ex.Message
            Me.lblContentBodyError.Visible = True
        End Try
    End Sub

End Class

