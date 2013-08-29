Imports System.Data
Imports CuteWebUI
Imports System.Drawing
Imports System.IO

Partial Class ImportProducts
    Inherits System.Web.UI.Page

    Private serverFilePath As String = ""

    Private imageOrig As Byte()
    Private imageThumb As Byte()
    Private theTagNumber As String = ""

    Private strTransDescription As String = ""
    Private strTransUser As String = ""
    Private strTransTag As String = ""

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

        Else
            mstr.RemoveErrorMessage()
        End If

    End Sub

   

    Protected Sub UploadButton_Click(ByVal sender As Object, ByVal e As EventArgs)

        If (FileUploader.HasFile) Then
            Try
                Dim thePath As String = Server.MapPath("confirm//")
                serverFilePath = Server.MapPath("confirm//") + FileUploader.FileName
                FileUploader.SaveAs(serverFilePath)
                Label1.Text = "File name: " + FileUploader.PostedFile.FileName + "<br>" + FileUploader.PostedFile.ContentLength.ToString() + " kb<br>" + "Content type: " + FileUploader.PostedFile.ContentType + "<br><b>Uploaded Successfully"
                'now import the file

                sqldsLookupTableData.Select(DataSourceSelectArguments.Empty)
                Label1.Text = "Import Successful"
            Catch ex As Exception
                Label1.Text = "ERROR: " + ex.Message.ToString()
            End Try

        Else

            Label1.Text = "You have not specified a file."
        End If

    End Sub

    Protected Sub lbDownload_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbDownload.Click
        'download the empty csv file
        Response.Redirect("DownloadCSV.ashx")
    End Sub

    Protected Sub sqldsLookupTableData_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsLookupTableData.Selecting
        e.Command.Parameters("theFileName").Value = serverFilePath
        e.Command.Parameters("theUser").Value = Session("LoginID")
    End Sub

    Protected Sub UploadPhotos_Click(ByVal sender As Object, ByVal e As EventArgs)

        If (FileUploader.HasFile) Then
            Try
                Dim thePath As String = Server.MapPath("confirm//")
                serverFilePath = Server.MapPath("confirm//") + FileUploader.FileName
                FileUploader.SaveAs(serverFilePath)
                Label1.Text = "File name: " + FileUploader.PostedFile.FileName + "<br>" + FileUploader.PostedFile.ContentLength.ToString() + " kb<br>" + "Content type: " + FileUploader.PostedFile.ContentType + "<br><b>Uploaded Successfully"
                'now import the file

                sqldsLookupTableData.Select(DataSourceSelectArguments.Empty)
                Label1.Text = "Import Successful"
            Catch ex As Exception
                Label1.Text = "ERROR: " + ex.Message.ToString()
            End Try

        Else

            Label1.Text = "You have not specified a file."
        End If

    End Sub

    Protected Sub InsertMsg(ByVal msg As String)
        ListBoxEvents.Items.Insert(0, msg)
        ListBoxEvents.SelectedIndex = 0
    End Sub

   

  

    Protected Sub Uploader1_FileUploaded(ByVal sender As Object, ByVal args As CuteWebUI.UploaderEventArgs) Handles Uploader1.FileUploaded
        InsertMsg("File uploaded! " & args.FileName & ", " & args.FileSize & " bytes.")
        'Copies the uploaded file to a new location.
        'args.CopyTo("c:\\temp\\"& args.FileName)
        'You can also open the uploaded file's data stream.
        'System.IO.Stream data = args.OpenStream()

        Dim fileName As String = Server.HtmlEncode(args.FileName)
        Dim extension As String = System.IO.Path.GetExtension(fileName)
        If (extension.ToUpper = ".JPG") Or (extension.ToUpper = ".GIF") Then
            theTagNumber = ""
            Me.imageThumb = Me.GetThumbNail(args)
            Me.imageOrig = Me.GetOriginalImage(args)
            'parse the filename for the barcode number (assume name like "Barcode #### (#)")
            theTagNumber = GetTagNumFromFileName(args.FileName)
            If Not (theTagNumber.Length = 0 Or imageThumb.Length = 0 Or imageOrig.Length = 0) Then
                Me.sqldsPhotos.Insert()

                strTransDescription = theTagNumber + " Photo Added"
                strTransUser = Session("LoginID")
                strTransTag = theTagNumber
                sqldsTranHistory.Insert()
            End If


        Else
            InsertMsg(args.FileName + " is not a GIF or JPG.")
        End If
    End Sub

    Private Function GetTagNumFromFileName(ByVal theFileName As String) As String
        Dim rc As String = ""
        Try
            Dim startIndex As Integer = theFileName.IndexOf("Barcode") + 7
            Dim endIndex As Integer = theFileName.IndexOf("(") - 1
            Dim extraction As String = theFileName.Substring(startIndex, endIndex - startIndex).Trim

            rc = extraction
        Catch ex As Exception
            rc = ""
        End Try
        Return rc
    End Function

    Protected Sub Uploader1_FileValidating(ByVal sender As Object, ByVal args As CuteWebUI.UploaderEventArgs) Handles Uploader1.FileValidating
        InsertMsg("File validated! " & args.FileName & ", " & args.FileSize & " bytes.")
    End Sub





    Private Function GetThumbNail(ByVal args As CuteWebUI.UploaderEventArgs) As Byte()
        Dim b As Byte()


        Dim fileName As String = Server.HtmlEncode(args.FileName)
        Dim extension As String = System.IO.Path.GetExtension(fileName)
        If (extension.ToUpper = ".JPG") Or (extension.ToUpper = ".GIF") Then


            '**** Resize image section ****
            Dim image_file As System.Drawing.Image = System.Drawing.Image.FromStream(args.OpenStream())
            Dim image_height As Integer = image_file.Height
            Dim image_width As Integer = image_file.Width
            Dim max_height As Integer = 120
            Dim max_width As Integer = 160




            image_height = (image_height * max_width) / image_width
            image_width = max_width


            If image_height > max_height Then
                image_width = (image_width * max_height) / image_height
                image_height = max_height
            Else
            End If




            Dim bitmap_file As New Bitmap(image_file, image_width, image_height)
            Dim stream As New System.IO.MemoryStream


            bitmap_file.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
            stream.Position = 0


            Dim data(stream.Length) As Byte
            stream.Read(data, 0, stream.Length)
            '**** End resize image section ****
            Return data
        End If


        Return b
    End Function

    Private Function GetOriginalImage(ByVal args As CuteWebUI.UploaderEventArgs) As Byte()
        Dim b As Byte()


        Dim fileName As String = Server.HtmlEncode(args.FileName)
        Dim extension As String = System.IO.Path.GetExtension(fileName)
        If (extension.ToUpper = ".JPG") Or (extension.ToUpper = ".GIF") Then


            '**** Resize image section ****
            Dim image_file As System.Drawing.Image = System.Drawing.Image.FromStream(args.OpenStream())
            Dim image_height As Integer = image_file.Height
            Dim image_width As Integer = image_file.Width
            Dim max_height As Integer = 120
            Dim max_width As Integer = 160





            Dim bitmap_file As New Bitmap(image_file, image_width, image_height)
            Dim stream As New System.IO.MemoryStream


            bitmap_file.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
            stream.Position = 0


            Dim data(stream.Length) As Byte
            stream.Read(data, 0, stream.Length)
            '**** End resize image section ****
            Return data
        End If


        Return b
    End Function

    Protected Sub sqldsPhotos_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsPhotos.Inserting
        e.Command.Parameters("TagName").Value = theTagNumber
        e.Command.Parameters("OriginalPhoto").Value = Me.imageOrig
        e.Command.Parameters("ThumbnailPhoto").Value = Me.imageThumb
    End Sub

    Protected Sub sqldsTranHistory_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsTranHistory.Inserting
        e.Command.Parameters("Description").Value = strTransDescription
        e.Command.Parameters("TheUser").Value = strTransUser
        e.Command.Parameters("TheTag").Value = strTransTag
    End Sub
End Class
