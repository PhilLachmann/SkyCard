Imports System.Data
Imports System.Data.Odbc

Partial Class AssetDisplayAttachment
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RetrieveDocument()
    End Sub
    Sub RetrieveDocument()
        Dim strItemID As String = Request.Params.Item("ItemID")

        Dim connection As OdbcConnection = New OdbcConnection(ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString)
        connection.Open()
        Dim command As OdbcCommand = New OdbcCommand("Call GetAssetAttachment(?)", connection)
        command.Parameters.Add(New OdbcParameter("ItemID", strItemID))


        Dim dr As OdbcDataReader = command.ExecuteReader()
        dr.Read()

        Dim bytarrDocument As Byte() = CType(dr(1), Byte())
        Dim strExtention As String = dr(0)
        connection.Close()

        Response.ClearContent()
        Response.ClearHeaders()
        Response.Buffer = True

        ''Response.Clear()
        ''Response.Buffer = True

        Select Case strExtention.ToLower
            Case "doc", "docx"
                Response.ContentType = "application/msword"
            Case "xls", "xlsx"
                'Response.ContentType = "application/msexcel"
                Response.ContentType = "application/vnd.ms-excel"
            Case "ppt", "pptx"
                Response.ContentType = "application/vnd.mspowerpoint"
            Case "jpg", "jpeg"
                Response.ContentType = "image/jpeg"
            Case "gif"
                Response.ContentType = "image/gif"
            Case "tiff"
                Response.ContentType = "image/tiff"
            Case "bmp"
                Response.ContentType = "image/bmp"
            Case "pdf"
                Response.ContentType = "application/pdf"
            Case "mpeg", "mpg", "mpe"
                Response.ContentType = "video/mpeg"
            Case "mov"
                Response.ContentType = "video/quicktime"
            Case "avi"
                Response.ContentType = "video/x-msvideo"
            Case Else
                Response.ContentType = "text/txt"
        End Select

        Response.BinaryWrite(bytarrDocument)

        Response.Flush()
        Response.Close()
        Response.End()



    End Sub

End Class
