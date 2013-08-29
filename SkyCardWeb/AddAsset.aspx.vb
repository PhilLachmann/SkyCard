
Partial Class AddAsset
    Inherits System.Web.UI.Page

    Private strTransDescription As String = ""
    Private strTransUser As String = ""
    Private strTransTag As String = ""

    Private rootSelected As Integer = 1

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = True Then
            Me.lblContentBodyError.Visible = False
        End If
    End Sub

   


    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Me.sqldsAsset.Insert()
    End Sub

    Protected Sub sqldsAsset_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsAsset.Inserted
        If e.AffectedRows > 0 Then
           
            'Asset creation
            Me.sqldsTranHistory.Insert()
            'description
            strTransDescription = "Added Tag Value " + "Description" + ":" + Me.tbDescription.Text
            Me.sqldsTranHistory.Insert()
            'quantity
            strTransDescription = "Added Tag Value " + "Quantity" + ":" + Me.tbQty.Text
            Me.sqldsTranHistory.Insert()
            'location
            strTransDescription = "Location Update: " + ddlWarehouse.SelectedItem.ToString() + "/" + ddlLocation.SelectedItem.ToString()
            Me.sqldsTranHistory.Insert()

            'success
            Me.lblMessage.Text = "Asset Added Successfully."
            Me.lblMessage.Visible = True
            Me.lblError.Text = ""
            Me.lblError.Visible = False
            Me.tbDescription.Text = ""
            Me.tbAssetTag.Text = ""
            Me.tbQty.Text = ""
        Else
            Me.lblMessage.Text = ""
            Me.lblMessage.Visible = False
            'display error
            Dim intRealErrorStart As Integer = e.Exception.Message.IndexOf("RAISERROR executed: ") + "RAISERROR executed: ".Length
            Dim strErrMsgText As String = e.Exception.Message.Substring(intRealErrorStart, e.Exception.Message.Length - intRealErrorStart)
            Me.lblError.Text = strErrMsgText
            Me.lblError.Visible = True
            e.ExceptionHandled = True
        End If

    End Sub

   
    Protected Sub sqldsAsset_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsAsset.Inserting
        If String.IsNullOrEmpty(tbAssetTag.Text) Or String.IsNullOrEmpty(tbDescription.Text) Or String.IsNullOrEmpty(tbQty.Text) Then
            Me.lblContentBodyError.Text = "The Tag and Description and Quantity fields are required."
            Me.lblContentBodyError.Visible = True
            e.Cancel = True
            Exit Sub
        End If

        strTransUser = Session("LoginID")
        strTransTag = tbAssetTag.Text

        e.Command.Parameters("TagNumber").Value = tbAssetTag.Text
        e.Command.Parameters("Description").Value = tbDescription.Text
        e.Command.Parameters("Quantity").Value = CInt(tbQty.Text)
        e.Command.Parameters("Location").Value = CInt(ddlLocation.SelectedValue)
        e.Command.Parameters("UserName").Value = strTransUser

        strTransDescription = tbAssetTag.Text + " has been created."
        strTransUser = Session("LoginID")
        strTransTag = tbAssetTag.Text
    End Sub

    Protected Sub sqldsTranHistory_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsTranHistory.Inserting
        e.Command.Parameters("Description").Value = strTransDescription
        e.Command.Parameters("TheUser").Value = strTransUser
        e.Command.Parameters("TheTag").Value = strTransTag
    End Sub

    Protected Sub ddlWarehouse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlWarehouse.SelectedIndexChanged
        rootSelected = CInt(ddlWarehouse.SelectedValue)
        Me.sqldsLocationsForRoot.Select(DataSourceSelectArguments.Empty)
        Me.ddlLocation.DataBind()
    End Sub

    Protected Sub sqldsLocationsForRoot_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsLocationsForRoot.Selecting
        e.Command.Parameters("TheRoot").Value = rootSelected
    End Sub
End Class
