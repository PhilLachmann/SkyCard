Imports System.Data
Imports System.IO
Imports System.Drawing

Partial Class DisplayPhoto
    Inherits System.Web.UI.Page

    Private thePhotoID As Integer = 0

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = True Then
            Me.lblContentBodyError.Visible = False
        Else
            thePhotoID = Request.QueryString("ID")

            If Session("SecurityRole") = "admin" Or Session("SecurityRole") = "superadmin" Then
                Me.btnDeletePhoto.Visible = True
            End If
        End If
    End Sub

    Protected Sub SqlDataSource1_Deleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles SqlDataSource1.Deleting
        e.Command.Parameters("PhotoID").Value = thePhotoID
        e.Command.Parameters("theUser").Value = Session("LoginID")
    End Sub



    Protected Sub SqlDataSource1_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles SqlDataSource1.Selecting
        e.Command.Parameters("ID").Value = thePhotoID
    End Sub

   
    Protected Sub ButtonOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        'get the tag number
        GetTagNumber()
        'delete the photo
        SqlDataSource1.Delete()
        'redirect back to edit form
        Response.Redirect("EditAsset.aspx?Tag=" + hfdTagNumber.Value.ToString())
    End Sub

    Private Sub GetTagNumber()
        'call the select
        Dim s As String = ""
        Dim dv2 As DataView = CType(Me.sqldsTag.Select(DataSourceSelectArguments.Empty), DataView)
        Dim dt2 As DataTable = dv2.ToTable

        If dt2.Rows.Count > 0 Then
            Dim dr2 As DataRow = dt2.Rows(0)

            Try
                s = dr2("tagnumber")
            Catch ex As Exception
                s = ""
            End Try

        Else
            s = ""
        End If

       
        'set the hidden field
        hfdTagNumber.Value = s
    End Sub

    Protected Sub sqldsTag_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsTag.Selecting
        thePhotoID = Request.QueryString("ID")
        e.Command.Parameters("ID").Value = thePhotoID
    End Sub

    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'get the tag number
        GetTagNumber()
       
        'redirect back to edit form
        Response.Redirect("EditAsset.aspx?Tag=" + hfdTagNumber.Value.ToString())
    End Sub
End Class
