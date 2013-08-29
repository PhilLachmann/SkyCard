
Partial Class AutoRedirector
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim strRequestedPage As String = Request.Params.Item("pageName")

        Select Case strRequestedPage
            Case "AssetEdit"
                Dim strAssetTagNumber As String = Request.Params.Item("Parm1")

                Session("AssetTagNumber") = strAssetTagNumber

                'launch the AssetEdit page
                Response.Redirect("EditAsset.aspx")

            Case Else
                Response.Redirect("Home.aspx")
        End Select


    End Sub

End Class
