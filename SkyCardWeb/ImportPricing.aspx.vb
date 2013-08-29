Imports System.Data
Partial Class ImportPricing
    Inherits System.Web.UI.Page

    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)

        If Page.IsPostBack = False Then
            Me.lblContentBodyError.Visible = False

            If Session("SaveStatus") = "Success" Then
                mstr.ShowSuccessMessage("The Pricing CSV File was successfully processed.")
                Session("SaveStatus") = Nothing
            End If

        Else
            mstr.RemoveErrorMessage()
        End If

    End Sub

    Protected Sub btnProcessImport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProcessImport.Click

        Try
            sqldsLookupTableData.Insert()

            Session("SaveStatus") = "Success"
            Response.Redirect("ImportPricing.aspx")
        Catch ex As Exception
            Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
            mstr.ShowErrorMessage("The Import routine encountered a problem.  Please review the file(s) in the import folder for any errors and re-try importing them.")
            Exit Sub
        End Try

    End Sub
End Class
