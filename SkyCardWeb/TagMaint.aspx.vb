
Partial Class TagMaint
    Inherits System.Web.UI.Page

    Private Updating As Integer = 0

    Private strTransDescription As String = ""
    Private strTransUser As String = ""
    Private strTransTag As String = ""

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
        sqldsTranHistory.Insert()
    End Sub

    

    Protected Sub sqldsLookupTableData_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Inserting
        Dim txtTagDesc As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("TagDesc"), TextBox)
        Dim ddlTagType As DropDownList = CType(Me.gvLookupTable.FooterRow.FindControl("TagType"), DropDownList)


        If String.IsNullOrEmpty(Trim(txtTagDesc.Text)) Then
            Me.lblContentBodyError.Text = "The Tag Description field is required."
            Me.lblContentBodyError.Visible = True
            e.Cancel = True
            Exit Sub
        End If


        e.Command.Parameters("TagName").Value = txtTagDesc.Text
        e.Command.Parameters("TagType").Value = ddlTagType.SelectedValue
        
        strTransDescription = "Created New Tag: " + txtTagDesc.Text
        strTransUser = Session("LoginID")
        strTransTag = ""
    End Sub

    Protected Sub sqldsLookupTableData_Updated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsLookupTableData.Updated
        If strTransDescription.Length > 0 Then
            sqldsTranHistory.Insert()
            strTransDescription = ""
            strTransUser = ""
            strTransTag = ""
        End If
    End Sub

    Protected Sub sqldsLookupTableData_Updating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Updating
        If Updating = 1 Then


            Dim row As GridViewRow = Me.gvLookupTable.Rows(Me.gvLookupTable.EditIndex)

            Dim intID As Integer = Me.gvLookupTable.DataKeys(Me.gvLookupTable.EditIndex).Value

            Dim txtTagDesc As TextBox = CType(row.FindControl("TagDesc"), TextBox)
            Dim ddlTagType As DropDownList = CType(row.FindControl("TagType"), DropDownList)


            If String.IsNullOrEmpty(Trim(txtTagDesc.Text)) Then
                Me.lblContentBodyError.Text = "The Tag Description field is required."
                Me.lblContentBodyError.Visible = True
                e.Cancel = True
                Exit Sub
            End If



            e.Command.Parameters("TagNameID").Value = intID
            e.Command.Parameters("TagName").Value = txtTagDesc.Text
            e.Command.Parameters("TagType").Value = ddlTagType.SelectedValue

            strTransDescription = "Updated Existing Tag: " + txtTagDesc.Text
            strTransUser = Session("LoginID")
            strTransTag = ""

            Updating = 0
        End If
    End Sub


    Protected Sub sqldsTranHistory_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsTranHistory.Inserting
        e.Command.Parameters("Description").Value = strTransDescription
        e.Command.Parameters("TheUser").Value = strTransUser
        e.Command.Parameters("TheTag").Value = strTransTag
    End Sub

    Protected Sub gvLookupTable_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles gvLookupTable.RowEditing
        gvLookupTable.ShowFooter = False
    End Sub
End Class
