Imports System.Data
Partial Class HandheldOrderMaint
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
            Dim dv As DataView = CType(Me.sqldsLookupTableData.Select(DataSourceSelectArguments.Empty), DataView)

            Dim dt As DataTable = dv.ToTable

            If dt.Rows.Count > 0 Then
                Me.txtHandheldID.Text = dt.Rows(0)("HandheldID").ToString()
            End If

            Me.lblContentBodyError.Visible = False

            If Session("SaveStatus") = "Success" Then
                mstr.ShowSuccessMessage("The HandheldID to process orders was successfully updated.")
                Session("SaveStatus") = Nothing
            End If

        Else
            mstr.RemoveErrorMessage()
        End If

    End Sub


    Protected Sub btnUpdateHandheld_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdateHandheld.Click
        Try
            If String.IsNullOrEmpty(Me.txtHandheldID.Text) Then
                Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
                mstr.ShowErrorMessage("Please supply a HandheldID to process the orders.")
                Exit Sub
            Else
                sqldsLookupTableData.Update()
                Session("SaveStatus") = "Success"
                Response.Redirect("HandheldOrderMaint.aspx")
            End If

        Catch ex As Exception
            Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
            mstr.ShowErrorMessage("An error was entountered: " & ex.Message)
            Exit Sub
        End Try

    End Sub


    Protected Sub sqldsLookupTableData_Updating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Updating
        e.Command.Parameters("HandheldID").Value = Trim(Me.txtHandheldID.Text)
        e.Command.Parameters("ModifiedBy").Value = Session("LoginID")
    End Sub
End Class
