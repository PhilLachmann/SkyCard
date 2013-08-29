<%@ WebHandler Language="VB" Class="UploadHandler" %>


Imports System
Imports System.Web
Imports System.Data.Odbc

Public Class UploadHandler : Implements IHttpHandler, System.Web.SessionState.IRequiresSessionState
    
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        'write your handler implementation here.
        If context.Request.Files.Count <= 0 Then
            context.Response.Write("<html><head></head><body style='background-color: #EEEEEE'><script type='text/javascript'>alert('No file uploaded');window.close();</script></body></html>")
        Else
            Dim arrlstAttchmentKeys As ArrayList = context.Session("AttachmentKeys")
            Dim file As HttpPostedFile = context.Request.Files(0)

            Dim strUserID As String = context.Session("LoginID")
            Dim strFileName As String = System.IO.Path.GetFileName(file.FileName)
            Dim strFileExt As String = System.IO.Path.GetExtension(file.FileName)
            Dim filelen As Integer = file.ContentLength
            If filelen > 0 Then
                'find the comments
                Dim strComments As String = ""
                For Each keyname As String In context.Request.Form.Keys
                    If keyname.Contains("txtComment") Then
                        strComments = context.Request.Form(keyname)
                    End If
                Next
                
                Dim filebyte As Byte() = New Byte(filelen - 1) {}

                file.InputStream.Read(filebyte, 0, filelen)

                Dim conn As New OdbcConnection(ConfigurationManager.ConnectionStrings("CaseMgmtConnectionString").ConnectionString)
                Dim cmd As New OdbcCommand("Call InsertAssetAttachment(?,?,?,?,?,?)", conn)
                Dim parm As New OdbcParameter("TagNumber", arrlstAttchmentKeys(0))
                cmd.Parameters.Add(parm)
                parm = New OdbcParameter("Comments", strComments)
                cmd.Parameters.Add(parm)
                parm = New OdbcParameter("Extension", strFileExt.Substring(1, strFileExt.Length - 1))
                cmd.Parameters.Add(parm)
                parm = New OdbcParameter("EnteredBy", strUserID)
                cmd.Parameters.Add(parm)
                parm = New OdbcParameter("UpldFileName", strFileName)
                cmd.Parameters.Add(parm)
                parm = New OdbcParameter("UpldFileBytes", filebyte)
                cmd.Parameters.Add(parm)

                cmd.Connection.Open()
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    Dim c As String = ""
                End Try

                cmd.Connection.Close()
                context.Session("AttachmentKeys") = Nothing
                'Dim b As String = ""

            Else
                'there ain't no bytes in dat file
            End If

            context.Response.Write("<html><head></head><body style='background-color: #EEEEEE'><script type='text/javascript'>alert('File uploaded');window.close();</script></body></html>")
        End If

    End Sub
 
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class