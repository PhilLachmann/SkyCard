Imports System.Data.SqlClient

Partial Class RptConviction
    Inherits System.Web.UI.Page
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim rpt As New ReportConviction
        CType(rpt.DataAdapter, SqlDataAdapter).SelectCommand.Connection.ConnectionString = ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString


        If Page.IsPostBack = False Then
            Me.pnlReport.Visible = False
            

            Me.txtStartDate.Text = Today.AddDays(-7).ToShortDateString
            Me.txtEndDate.Text = Today.ToShortDateString

        Else
            Me.hfdFirstTime.Value = Me.hfdFirstTime.Value + 1
        End If

        rpt.ApplySorting(Me.ddlSort.SelectedValue())

        'report parms
        rpt.Parameters("FieldName").Value = Me.ddlDateField.SelectedItem.ToString()
        rpt.Parameters("FromDt").Value = IIf(String.IsNullOrEmpty(Me.txtStartDate.Text), Nothing, CType(Me.txtStartDate.Text.ToString + " 00:00:00", DateTime))
        rpt.Parameters("ToDt").Value = IIf(String.IsNullOrEmpty(Me.txtEndDate.Text), Nothing, CType(Me.txtEndDate.Text.ToString + " 23:59:58", DateTime))
        rpt.Parameters("OrderBy").Value = IIf(String.IsNullOrEmpty(Me.ddlSort.SelectedValue), Nothing, Trim(Me.ddlSort.SelectedValue))

        CType(rpt.DataAdapter, SqlDataAdapter).SelectCommand.Parameters("@DateField").Value = Me.ddlDateField.SelectedValue
        CType(rpt.DataAdapter, SqlDataAdapter).SelectCommand.Parameters("@FromDate").Value = IIf(String.IsNullOrEmpty(Me.txtStartDate.Text), Nothing, CType(Me.txtStartDate.Text.ToString + " 00:00:00", DateTime))
        CType(rpt.DataAdapter, SqlDataAdapter).SelectCommand.Parameters("@ToDate").Value = IIf(String.IsNullOrEmpty(Me.txtEndDate.Text), Nothing, CType(Me.txtEndDate.Text.ToString + " 23:59:58", DateTime))
        CType(rpt.DataAdapter, SqlDataAdapter).SelectCommand.Parameters("@SortField").Value = IIf(String.IsNullOrEmpty(Me.ddlSort.SelectedValue), Nothing, Trim(Me.ddlSort.SelectedValue))
        CType(rpt.DataAdapter, SqlDataAdapter).SelectCommand.Parameters("@UserName").Value = Session("Username")
        Me.rptvwrOrders.Report = rpt

    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click

        Response.Redirect("Default.aspx")

    End Sub

    Protected Sub btnRunReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRunReport.Click

        Me.pnlReport.Visible = True

    End Sub
    Protected Sub txtStartDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStartDate.TextChanged
        If Me.hfdFirstTime.Value > 1 Then
            Me.pnlReport.Visible = False
        Else
            Me.pnlReport.Visible = True
        End If
    End Sub
    Protected Sub txtEndDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEndDate.TextChanged
        If Me.hfdFirstTime.Value > 1 Then
            Me.pnlReport.Visible = False
        Else
            Me.pnlReport.Visible = True
        End If
    End Sub
    Protected Sub JobID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlDateField.SelectedIndexChanged
        If Me.hfdFirstTime.Value > 1 Then
            Me.pnlReport.Visible = False
        Else
            Me.pnlReport.Visible = True
        End If
    End Sub

    Protected Sub ddlStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlSort.SelectedIndexChanged
        If Me.hfdFirstTime.Value > 1 Then
            Me.pnlReport.Visible = False
        Else
            Me.pnlReport.Visible = True
        End If

    End Sub
End Class
