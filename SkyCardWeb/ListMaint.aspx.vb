Imports System.Data

Partial Class ListMaint
    Inherits System.Web.UI.Page

    Private Updating As Integer = 0

    Private strTransDescription As String = ""
    Private strTransUser As String = ""
    Private strTransTag As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = True Then
            Me.lblContentBodyError.Visible = False
        Else
            Initialize()
        End If
    End Sub

    Private Sub Initialize()
        'call the select
        Dim s As String = ""
        Dim dv2 As DataView = CType(Me.sqldsLists.Select(DataSourceSelectArguments.Empty), DataView)
        Dim dt2 As DataTable = dv2.ToTable

        If dt2.Rows.Count > 0 Then
            Dim dr2 As DataRow = dt2.Rows(0)

            Try
                s = dr2("tagnameid")
            Catch ex As Exception
                s = "0"
            End Try

        Else
            s = "0"
        End If


        'set the hidden field
        hfdTagNameID.Value = s
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



    Protected Sub sqldsLookupTableData_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Inserting
        Dim txtTagDesc As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("TagDesc"), TextBox)


        If String.IsNullOrEmpty(Trim(txtTagDesc.Text)) Then
            Me.lblContentBodyError.Text = "The List Item field is required."
            Me.lblContentBodyError.Visible = True
            e.Cancel = True
            Exit Sub
        End If


        e.Command.Parameters("TagNameID").Value = Me.hfdTagNameID.Value()
        e.Command.Parameters("TagListDesc").Value = txtTagDesc.Text

       
    End Sub

    Protected Sub sqldsLookupTableData_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsLookupTableData.Selecting
        Dim tagnameid As Integer = 0
        Try
            tagnameid = CInt(hfdTagNameID.Value)
        Catch ex As Exception
            tagnameid = 0
        End Try
        e.Command.Parameters("TagNameID").Value = tagnameid
    End Sub

    

    Protected Sub sqldsLookupTableData_Updating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Updating
        If Updating = 1 Then


            Dim row As GridViewRow = Me.gvLookupTable.Rows(Me.gvLookupTable.EditIndex)

            Dim intID As Integer = Me.gvLookupTable.DataKeys(Me.gvLookupTable.EditIndex).Value

            Dim txtTagDesc As TextBox = CType(row.FindControl("TagDesc"), TextBox)



            If String.IsNullOrEmpty(Trim(txtTagDesc.Text)) Then
                Me.lblContentBodyError.Text = "The List Item field is required."
                Me.lblContentBodyError.Visible = True
                e.Cancel = True
                Exit Sub
            End If



            e.Command.Parameters("TagListID").Value = intID
            e.Command.Parameters("TagListDesc").Value = txtTagDesc.Text


           

            Updating = 0
        End If
    End Sub


  
    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        Me.hfdTagNameID.Value = DropDownList1.SelectedValue()
        Me.sqldsLookupTableData.Select(DataSourceSelectArguments.Empty)
        Me.gvLookupTable.DataBind()
    End Sub

    Protected Sub gvLookupTable_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles gvLookupTable.RowEditing
        gvLookupTable.ShowFooter = False
    End Sub
End Class
