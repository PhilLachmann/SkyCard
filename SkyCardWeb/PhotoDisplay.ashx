<%@ WebHandler Language="VB" Class="PhotoDisplay" %>

Imports System
Imports System.Web
Imports System.Data.Odbc
Imports System.Data
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class PhotoDisplay : Implements IHttpHandler
    
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Dim strTagNumber As String = context.Request.QueryString("TagNumber")
        
        If strTagNumber <> "" Then
            Dim memoryStream As New MemoryStream()
            Dim conn As New OdbcConnection(ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString)
            Dim cmd As New OdbcCommand("Call GetLatestThumbnailPhotoForAsset(?)", conn)
            Dim parm As New OdbcParameter("TagNumber", strTagNumber)
            cmd.Parameters.Add(parm)
            Dim reader As OdbcDataReader = Nothing
            Dim file As Byte()

            Try
                conn.Open()
                reader = cmd.ExecuteReader()
                reader.Read()

                Try
                    file = CType(reader("thumbnailPhoto"), Byte())
                Catch ex As Exception
                    Dim bmp As Bitmap = New Bitmap(120, 160)
                    Dim grphcs As Graphics = Graphics.FromImage(bmp)
                    grphcs.Clear(Color.White)
                    grphcs.DrawString("No Image", New Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold), Brushes.Black, 0, 0)
                    
                    Dim ms As MemoryStream = New MemoryStream()
                    bmp.Save(ms, ImageFormat.Jpeg)

                    file = ms.GetBuffer()

                    bmp.Dispose()
                    ms.Close()

                End Try

                reader.Close()
                conn.Close()

                memoryStream.Write(file, 0, file.Length)
                context.Response.Buffer = True
                context.Response.BinaryWrite(file)

            Catch ex As Exception

            Finally
                reader.Close()
                conn.Close()
                memoryStream.Dispose()
            End Try


        End If


    End Sub
 
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class