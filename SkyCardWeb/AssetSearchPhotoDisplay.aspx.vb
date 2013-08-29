Imports System.Data
Imports System.IO
Imports System.Drawing

Partial Class AssetSearchPhotoDisplay
    Inherits System.Web.UI.Page

    Dim theWhereClause As String = ""
    Dim theBuildingLocID As Integer = 0

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = True Then
            Me.lblContentBodyError.Visible = False
        Else
            'get the sessionvariable
            theWhereClause = Session("PhotoSearchWhereClause")
            theBuildingLocID = Session("PhotoSearchBuildingLocID")
        End If
    End Sub




    Protected Sub sqldsPhotos_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsPhotos.Selecting
        e.Command.Parameters("WhereClause").Value = theWhereClause
        e.Command.Parameters("BuildingLocID").Value = theBuildingLocID
    End Sub
End Class
