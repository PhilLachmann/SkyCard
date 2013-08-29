Imports System.Data.Odbc
Imports System.Data

Partial Class Alerts

    Inherits System.Web.UI.Page

    Private minCount As Integer = 0
    Private reorderCount As Integer = 0
    Private maxCount As Integer = 0

    Private parmValue As Integer = 1

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = True Then
            Me.lblContentBodyError.Visible = False
        End If

        
    End Sub



    Protected Sub GetMinVal()

        'Dim conn As New OdbcConnection(ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString)
        'Dim cmd As New OdbcCommand("SELECT func_NumBelowMinOrReorder(1)", conn)

        'cmd.Connection.Open()
        'Try
        '    Dim i As Integer = cmd.ExecuteScalar()
        '    If i = 0 Then
        '        minCount = 0
        '    Else
        '        minCount = i
        '    End If

        'Catch ex As Exception
        '    minCount = 0
        'End Try

        'cmd.Connection.Close()

        'call the select
        parmValue = 1
        Dim s As Integer
        Dim dv2 As DataView = CType(Me.sqldsMinOrReorder.Select(DataSourceSelectArguments.Empty), DataView)
        Dim dt2 As DataTable = dv2.ToTable

        If dt2.Rows.Count > 0 Then
            Dim dr2 As DataRow = dt2.Rows(0)

            Try
                s = dr2("thetotal")
            Catch ex As Exception
                s = 0
            End Try

        Else
            s = 0
        End If


        'set the hidden field
        minCount = s
    End Sub

    Protected Sub GetReorderVal()

        'Dim conn As New OdbcConnection(ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString)
        'Dim cmd As New OdbcCommand("SELECT func_NumBelowMinOrReorder(2)", conn)

        'cmd.Connection.Open()
        'Try
        '    Dim i As Integer = cmd.ExecuteScalar()
        '    If i = 0 Then
        '        reorderCount = 0
        '    Else
        '        reorderCount = i
        '    End If

        'Catch ex As Exception
        '    reorderCount = 0
        'End Try

        'cmd.Connection.Close()

        'call the select
        parmValue = 2
        Dim s As Integer
        Dim dv2 As DataView = CType(Me.sqldsMinOrReorder.Select(DataSourceSelectArguments.Empty), DataView)
        Dim dt2 As DataTable = dv2.ToTable

        If dt2.Rows.Count > 0 Then
            Dim dr2 As DataRow = dt2.Rows(0)

            Try
                s = dr2("thetotal")
            Catch ex As Exception
                s = 0
            End Try

        Else
            s = 0
        End If


        'set the hidden field
        reorderCount = s
    End Sub
    Protected Sub GetMaxVal()

        'call the select
        parmValue = 3
        Dim s As Integer
        Dim dv2 As DataView = CType(Me.sqldsMinOrReorder.Select(DataSourceSelectArguments.Empty), DataView)
        Dim dt2 As DataTable = dv2.ToTable

        If dt2.Rows.Count > 0 Then
            Dim dr2 As DataRow = dt2.Rows(0)

            Try
                s = dr2("thetotal")
            Catch ex As Exception
                s = 0
            End Try

        Else
            s = 0
        End If

        'set the hidden field
        maxCount = s
    End Sub

    Protected Sub btnContinue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        Response.Redirect("AssetSearch2.aspx")
    End Sub

    
End Class
