Imports System.Data

Partial Class JobAdd
    Inherits System.Web.UI.Page
    Private strJobID As String = ""

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

        Response.Redirect("SearchJob.aspx")

    End Sub

    Protected Sub gvLookupTable_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLookupTable.RowCommand
        Select Case e.CommandName
            Case "Insert"
                Try
                    Dim intAffectedRows As Integer = Me.sqldsLookupTableData.Insert()
                    If intAffectedRows > 0 Then
                        Dim arrlstJobSrchCriteria As ArrayList = New ArrayList()
                        arrlstJobSrchCriteria.Add(True)
                        arrlstJobSrchCriteria.Add(strJobID)
                        Session("SearchCriteria") = arrlstJobSrchCriteria

                        Response.Redirect("SearchJob.aspx")
                    End If

                Catch ex As Exception
                    Me.lblContentBodyError.Text = ex.Message
                    Me.lblContentBodyError.Visible = True
                End Try

        End Select
    End Sub

    Protected Sub sqldsLookupTableData_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Inserting
        Dim row As GridViewRow = Me.gvLookupTable.Rows(0)

        Dim txtJobID As TextBox = CType(row.FindControl("JobID"), TextBox)
        Dim txtJobDesc As TextBox = CType(row.FindControl("JobDesc"), TextBox)
        Dim txtJobBarcode As TextBox = CType(row.FindControl("JobBarcode"), TextBox)

        If String.IsNullOrEmpty(txtJobID.Text) Or String.IsNullOrEmpty(txtJobDesc.Text) Or String.IsNullOrEmpty(txtJobBarcode.Text) Then
            Me.lblContentBodyError.Text = "The JobID, Job Description, and Job Barcode fields are all required."
            Me.lblContentBodyError.Visible = True
            e.Cancel = True
            Exit Sub
        End If

        strJobID = txtJobID.Text
        e.Command.Parameters("JobID").Value = txtJobID.Text
        e.Command.Parameters("JobDesc").Value = txtJobDesc.Text
        e.Command.Parameters("JobBarcode").Value = txtJobBarcode.Text

    End Sub


End Class
