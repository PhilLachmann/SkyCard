
Partial Class UserMaint
    Inherits System.Web.UI.Page

    Private Updating As Integer = 0

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = True Then
            Me.lblContentBodyError.Visible = False
        End If
    End Sub

    Protected Sub gvLookupTable_RowCancelingEdit(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCancelEditEventArgs) Handles gvLookupTable.RowCancelingEdit
        gvLookupTable.ShowFooter = True
    End Sub

    Protected Sub gvLookupTable_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLookupTable.RowCommand
        Select Case e.CommandName
            Case "Insert"
                Me.sqldsLookupTableData.Insert()
                Me.gvLookupTable.DataBind()
            Case "Update"
                Updating = 1
                Me.sqldsLookupTableData.Update()
                Me.gvLookupTable.DataBind()
                gvLookupTable.ShowFooter = True
        End Select

    End Sub

    Protected Sub sqldsLookupTableData_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsLookupTableData.Inserted
        Dim a As String = ""
    End Sub

    Protected Sub sqldsLookupTableData_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Inserting
        Dim txtUserID As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("UserName"), TextBox)
        Dim txtUsername As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("UserDesc"), TextBox)
        Dim txtPassword As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("Password"), TextBox)
        Dim txtConfirmPassword As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("ConfirmPassword"), TextBox)
        Dim txtEmail As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("Email"), TextBox)
        Dim ddlAdmin As DropDownList = CType(Me.gvLookupTable.FooterRow.FindControl("UserRole"), DropDownList)
        Dim ddlActive As DropDownList = CType(Me.gvLookupTable.FooterRow.FindControl("IsActive"), DropDownList)

        If String.IsNullOrEmpty(Trim(txtUserID.Text)) Or String.IsNullOrEmpty(Trim(txtUsername.Text)) Or String.IsNullOrEmpty(Trim(txtPassword.Text)) Then
            Me.lblContentBodyError.Text = "The UserID, UserName and Password fields are all required."
            Me.lblContentBodyError.Visible = True
            e.Cancel = True
            Exit Sub
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            Me.lblContentBodyError.Text = "Password and Confirm Password were not the same.  Please Re-enter the new user information."
            Me.lblContentBodyError.Visible = True
            'Dim mstr As SD1Claims = CType(Me.Master, SD1Claims)
            'mstr.ShowErrorMessage("Password and Confirm Password are not the same.")
            e.Cancel = True
            Exit Sub
        End If

        e.Command.Parameters("@LoginID").Value = txtUserID.Text
        e.Command.Parameters("@Username").Value = txtUsername.Text
        'e.Command.Parameters("@Password").Value = Utilities.PasswordHasher(txtPassword.Text)
        e.Command.Parameters("@Password").Value = txtPassword.Text
        e.Command.Parameters("@Role").Value = ddlAdmin.SelectedValue

    End Sub

    'Protected Sub sqldsLookupTableData_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsLookupTableData.Selecting
    '    e.Command.Parameters("UserRole").Value = Session("SecurityRole")
    'End Sub

    Protected Sub sqldsLookupTableData_Updating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Updating
        If Updating = 1 Then


            Dim row As GridViewRow = Me.gvLookupTable.Rows(Me.gvLookupTable.EditIndex)

            Dim intID As Integer = Me.gvLookupTable.DataKeys(Me.gvLookupTable.EditIndex).Value

            Dim strPassword As String = ""

            Dim txtUsername As Label = CType(row.FindControl("UserName"), Label)
            Dim txtUserDesc As TextBox = CType(row.FindControl("UserDesc"), TextBox)
            Dim txtPassword As TextBox = CType(row.FindControl("Password"), TextBox)
            Dim txtEmail As TextBox = CType(row.FindControl("Email"), TextBox)
            Dim txtOriginalPassword As TextBox = CType(row.FindControl("OriginalPassword"), TextBox)
            Dim txtConfirmPassword As TextBox = CType(row.FindControl("ConfirmPassword"), TextBox)
            Dim ddlAdmin As DropDownList = CType(row.FindControl("UserRole"), DropDownList)
            Dim ddlActive As DropDownList = CType(row.FindControl("IsActive"), DropDownList)

            If String.IsNullOrEmpty(Trim(txtUsername.Text)) Then
                Me.lblContentBodyError.Text = "The UserName field is required."
                Me.lblContentBodyError.Visible = True
                e.Cancel = True
                Exit Sub
            End If

            If txtPassword.Text <> txtConfirmPassword.Text Then
                Me.lblContentBodyError.Text = "Password and Confirm Password were not the same.  Please Re-enter the changes."
                Me.lblContentBodyError.Visible = True
                e.Cancel = True
                Exit Sub
            End If

            If String.IsNullOrEmpty(txtPassword.Text) And String.IsNullOrEmpty(txtConfirmPassword.Text) Then
                strPassword = txtOriginalPassword.Text
            Else
                strPassword = txtPassword.Text
            End If


            e.Command.Parameters("@id").Value = intID
            e.Command.Parameters("@login").Value = txtUsername.Text
            e.Command.Parameters("@username").Value = txtUserDesc.Text
            e.Command.Parameters("@password").Value = strPassword
            e.Command.Parameters("@role").Value = ddlAdmin.SelectedValue
           
            Updating = 0
        End If
    End Sub

    Protected Sub gvLookupTable_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvLookupTable.RowDataBound
        'CType(sender,GridView).
        Dim a As String = ""
        If e.Row.RowType = DataControlRowType.DataRow Then
            If CType(sender, GridView).EditIndex = -1 Then
                Dim lbl As Label = CType(e.Row.FindControl("UserRole"), Label)
                If lbl.Text = "superadmin" Then
                    If Session("SecurityRole") <> "superadmin" Then
                        Dim ibtn As ImageButton = CType(e.Row.FindControl("btnEditItem"), ImageButton)
                        ibtn.Visible = False
                    End If
                End If
            Else
                If e.Row.RowIndex = CType(sender, GridView).EditIndex Then
                    'edit mode, edittemplate on row
                    'continue
                Else
                    'edit mode, itemtemplate on row
                    Dim lbl As Label = CType(e.Row.FindControl("UserRole"), Label)
                    If lbl.Text = "superadmin" Then
                        If Session("SecurityRole") <> "superadmin" Then
                            Dim ibtn As ImageButton = CType(e.Row.FindControl("btnEditItem"), ImageButton)
                            ibtn.Visible = False
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Protected Sub gvLookupTable_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles gvLookupTable.RowEditing
        gvLookupTable.ShowFooter = False
    End Sub

    Protected Sub UserRole_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        If Session("SecurityRole") = "superadmin" Then
            'add superadmin to role ddl
            Dim ddl As DropDownList = CType(sender, DropDownList)
            Dim litm As ListItem = New ListItem("superadmin", "superadmin")
            ddl.Items.Add(litm)
        End If

    End Sub

End Class
