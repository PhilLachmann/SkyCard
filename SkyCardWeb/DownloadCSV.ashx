<%@ WebHandler Language="VB" Class="DownloadCSV" %>

Imports System
Imports System.Web

Public Class DownloadCSV : Implements IHttpHandler
    
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        'context.Response.ContentType = "text/plain"
        'context.Response.Write("Hello World")
        Dim filename As String = "AssetImport.csv"
              
        context.Response.AddHeader("Content-Disposition", "attachment; filename=" + filename)
        context.Response.ContentType = "text/plain"
        context.Response.WriteFile(context.Server.MapPath(filename))
    End Sub
 
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class