Imports System.Data

Partial Class LocationAdd
    Inherits System.Web.UI.Page
    Private strLocID As String = ""

    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Dim dv As DataView = CType(Me.sqldsLookupTableData.Select(DataSourceSelectArguments.Empty), DataView)

            Dim dt As DataTable = dv.ToTable
            Dim dr As DataRow = dt.NewRow()
            dt.Rows.Add(dr)

            Me.gvLookupTable.DataSource = dt
            Me.gvLookupTable.DataBind()

        End If
    End Sub

    Protected Sub gvLookupTable_RowCancelingEdit(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCancelEditEventArgs) Handles gvLookupTable.RowCancelingEdit

        Response.Redirect("SearchLocation.aspx")

    End Sub

    Protected Sub gvLookupTable_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLookupTable.RowCommand
        Select Case e.CommandName
            Case "Insert"
                Try
                    Dim intAffectedRows As Integer = Me.sqldsLookupTableData.Insert()
                    If intAffectedRows > 0 Then
                        Dim arrlstLocSrchCriteria As ArrayList = New ArrayList()
                        arrlstLocSrchCriteria.Add(True)
                        arrlstLocSrchCriteria.Add(strLocID)
                        Session("SearchCriteria") = arrlstLocSrchCriteria

                        Response.Redirect("SearchLocation.aspx")
                    End If

                Catch ex As Exception
                    Me.lblContentBodyError.Text = ex.Message
                    Me.lblContentBodyError.Visible = True
                End Try

        End Select
    End Sub

    Protected Sub sqldsLookupTableData_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Inserting
        Dim row As GridViewRow = Me.gvLookupTable.Rows(0)

        Dim txtLocID As TextBox = CType(row.FindControl("LocationID"), TextBox)
        Dim txtLocDesc As TextBox = CType(row.FindControl("LocDesc"), TextBox)
        Dim txtLocBarcode As TextBox = CType(row.FindControl("LocBarcode"), TextBox)

        If String.IsNullOrEmpty(txtLocID.Text) Or String.IsNullOrEmpty(txtLocDesc.Text) Or String.IsNullOrEmpty(txtLocBarcode.Text) Then
            Me.lblContentBodyError.Text = "The LocationID, Location Description and Location Barcode fields are all required."
            Me.lblContentBodyError.Visible = True
            e.Cancel = True
            Exit Sub
        End If

        strLocID = txtLocID.Text
        e.Command.Parameters("LocationID").Value = txtLocID.Text
        e.Command.Parameters("LocDesc").Value = txtLocDesc.Text
        e.Command.Parameters("LocBarcode").Value = txtLocBarcode.Text

    End Sub


End Class
