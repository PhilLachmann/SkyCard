Imports System.Data
Imports System.IO
Imports System.Drawing

Partial Class EditAsset
    Inherits System.Web.UI.Page

    Private Updating As Integer = 0

    Private strTransDescription As String = ""
    Private strTransUser As String = ""
    Private strTransTag As String = ""

    Private imageOrig As Byte()
    Private imageThumb As Byte()

    Private intTagNameID As Integer = 0
    Private strValidationMessage As String = ""

    Private rootSelected As Integer = 1
    Private tagDesc As String = ""
    Private defaultListValue As String = ""

    Private oldQtyValue As String = ""
    Private intDeleteAttachmentID As Integer = 0

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = True Then
            Me.lblContentBodyError.Visible = False
            If Session("SecurityRole") = "admin" Or Session("SecurityRole") = "superadmin" Then
                Me.btnAddAttachment.Attributes.Add("onclick", "javascript:openAddAssetAttachment('" & tbAssetTagNumber.Text & "');return true;")
            End If

        Else
            If Session("SecurityRole") = "readonly" Then
                'hide and disable any controls used for editing
                btnUpdateLocation.Visible = False
                btnAddAttachment.Visible = False
                btnUpload.Visible = False
                FileUpload1.Visible = False
                pnlLocationUpdate.Visible = False
                gvLookupTable.ShowFooter = False
                gvLookupTable.Columns(0).Visible = False
                Me.Title = "View Asset"
                Me.Caption.Text = "View Asset"
                Me.Label1.Text = "Enter Asset Barcode Number to View"
            End If

            If Session("SecurityRole") = "admin" Or Session("SecurityRole") = "superadmin" Then
                Me.btnDeleteAsset.Visible = True
            End If

            Dim thetag As String = Session("AssetTagNumber")
            If String.IsNullOrEmpty(thetag) Then
                'do nothing
                Dim str As String = Request.QueryString("Tag")
                If String.IsNullOrEmpty(str) Then
                    'do nothing
                Else
                    hfdTagNumber.Value = str
                    tbAssetTagNumber.Text = str
                    PopulateForm()
                    PopulateLocation()
                    If Session("SecurityRole") = "admin" Or Session("SecurityRole") = "superadmin" Then
                        Me.btnDeleteAsset.Enabled = True
                    End If
                End If
            Else
                Session("AssetTagNumber") = ""
                hfdTagNumber.Value = thetag
                tbAssetTagNumber.Text = thetag
                PopulateForm()
                PopulateLocation()
                If Session("SecurityRole") = "admin" Or Session("SecurityRole") = "superadmin" Then
                    Me.btnDeleteAsset.Enabled = True
                End If
            End If
        End If
    End Sub

    Protected Sub gvLookupTable_RowCancelingEdit(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCancelEditEventArgs) Handles gvLookupTable.RowCancelingEdit
        gvLookupTable.ShowFooter = True
    End Sub

    Protected Sub gvLookupTable_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLookupTable.RowCommand
        Select Case e.CommandName
            Case "Insert"
                Me.sqldsTagsByAsset.Insert()
                Me.gvLookupTable.DataBind()
            Case "Update"
                Updating = 1
                Me.sqldsTagsByAsset.Update()
                'Me.gvLookupTable.DataBind()
                Session("AssetTagNumber") = hfdTagNumber.Value
                'launch the AssetEdit page
                Response.Redirect("EditAsset.aspx")
        End Select

    End Sub

    Protected Sub sqldsTagsByAsset_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsTagsByAsset.Inserted
        sqldsTranHistory.Insert()
    End Sub

    Private Sub PopulateLocation()

        Dim whsSelectedValue As String = ""
        Dim dv2 As DataView = CType(Me.sqldsAssetRootLocation.Select(DataSourceSelectArguments.Empty), DataView)
        Dim dt2 As DataTable = dv2.ToTable

        If dt2.Rows.Count > 0 Then
            Dim dr2 As DataRow = dt2.Rows(0)

            Try
                Me.lblWarehouse.Text = dr2("LocDesc")
            Catch ex As Exception
                Me.lblWarehouse.Text = "Unknown"
            End Try

            Try
                whsSelectedValue = dr2("LocNameID")
                ddlWarehouse.SelectedValue = whsSelectedValue
            Catch ex As Exception
                ddlLocation.SelectedValue = 1
                whsSelectedValue = 1
            End Try
        Else
            Me.lblWarehouse.Text = "Unknown"
        End If

        Try
            rootSelected = CInt(whsSelectedValue)
        Catch ex As Exception
            rootSelected = 1
        End Try

        Me.sqldsLocationsForRoot.Select(DataSourceSelectArguments.Empty)
        Me.ddlLocation.DataBind()


        Dim dv As DataView = CType(Me.sqldsAssetLocation.Select(DataSourceSelectArguments.Empty), DataView)
        Dim dt As DataTable = dv.ToTable

        If dt.Rows.Count > 0 Then
            Dim dr As DataRow = dt.Rows(0)

            Try
                Me.lblLocation.Text = dr("LocDesc")
            Catch ex As Exception
                Me.lblLocation.Text = "Unknown"
            End Try

            Try
                ddlLocation.SelectedValue = dr("LocNameID")
            Catch ex As Exception
                ddlLocation.SelectedIndex = 0
            End Try

        Else
            Me.lblLocation.Text = "Unknown"
        End If
    End Sub

    Private Function ValidateField(ByVal TagNameID As Integer, ByVal TagValue As String) As Boolean
        strValidationMessage = ""
        Dim theType As String = ""
        
        Dim dv As DataView = CType(Me.sqldsGetTagByID.Select(DataSourceSelectArguments.Empty), DataView)
        Dim dt As DataTable = dv.ToTable

        If dt.Rows.Count > 0 Then
            Dim dr As DataRow = dt.Rows(0)

            Try
                theType = dr("TagType")
            Catch ex As Exception
                theType = ""
            End Try

        End If

        Select Case theType
            Case "String"
                Return True
            Case "List"
                Return True
            Case "Integer"
                Dim reg As New RegularExpressions.Regex("^\d+$")
                If Not reg.IsMatch(TagValue) Then
                    strValidationMessage = "Field value must be an Integer"
                    Return False
                End If
            Case "Decimal"
                Dim reg As New RegularExpressions.Regex("^[1-9][\.\d]*(,\d+)?$")
                If Not reg.IsMatch(TagValue) Then
                    strValidationMessage = "Field value must be a Decimal"
                    Return False
                End If
            Case "Timestamp"
                Dim td As Date
                If Not Date.TryParse(TagValue, td) Then
                    strValidationMessage = "Field value must be an Date in formal mm/dd/yyyy"
                    Return False
                End If
            Case Else
                strValidationMessage = "Field Type Unknown"
                Return False
        End Select
        Return True
    End Function

    Private Function ConvertIfDate(ByVal TagNameID As Integer, ByVal TagValue As String) As String
        Dim dv As DataView = CType(Me.sqldsGetTagByID.Select(DataSourceSelectArguments.Empty), DataView)
        Dim dt As DataTable = dv.ToTable
        Dim theType As String = ""

        If dt.Rows.Count > 0 Then
            Dim dr As DataRow = dt.Rows(0)

            Try
                theType = dr("TagType")
            Catch ex As Exception
                theType = ""
            End Try

        End If

        If theType = "Timestamp" Then
            Dim td As Date
            Dim s As String
            If Date.TryParse(TagValue, td) Then
                s = td.Year.ToString() + " " + td.Month.ToString() + " " + td.Day.ToString()
            Else
                s = ""
            End If
            Return s
        End If
        Return TagValue
    End Function

    Protected Sub sqldsLookupTableData_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsTagsByAsset.Inserting
        Dim theTagValue As String = ""

        Dim strTagNumber As String = hfdTagNumber.Value
        Dim txtTagValue As TextBox = CType(Me.gvLookupTable.FooterRow.FindControl("TagValue"), TextBox)
        Dim ddlTagValue As DropDownList = CType(Me.gvLookupTable.FooterRow.FindControl("ddlTagValue"), DropDownList)

        Dim ddlTagName As DropDownList = CType(Me.gvLookupTable.FooterRow.FindControl("TagName"), DropDownList)

        If txtTagValue.Visible = True Then
            If String.IsNullOrEmpty(Trim(txtTagValue.Text)) Then
                Me.lblContentBodyError.Text = "The Tag Value field is required."
                Me.lblContentBodyError.Visible = True
                e.Cancel = True
                Exit Sub
            End If
            theTagValue = txtTagValue.Text
        Else
            theTagValue = ddlTagValue.SelectedValue()
        End If

        'get the type of the field and make sure it validates
        intTagNameID = ddlTagName.SelectedValue
        If Not ValidateField(intTagNameID, txtTagValue.Text) Then
            Me.lblContentBodyError.Text = strValidationMessage
            Me.lblContentBodyError.Visible = True
            e.Cancel = True
            Exit Sub
        End If

        strTransDescription = "Added Tag Value " + ddlTagName.SelectedItem.ToString() + ":" + theTagValue
        strTransUser = Session("LoginID")
        strTransTag = hfdTagNumber.Value

        e.Command.Parameters("AssetTagNumber").Value = strTagNumber
        e.Command.Parameters("TagNameID").Value = ddlTagName.SelectedValue
        e.Command.Parameters("TagValue").Value = Me.ConvertIfDate(intTagNameID, theTagValue)

    End Sub

    Protected Sub sqldsTagsByAsset_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsTagsByAsset.Selected
        Dim i As Integer
        i = e.AffectedRows
        If i > 0 Then
            hfdTagNumber.Value = tbAssetTagNumber.Text
            pnlUpload.Visible = True
            btnUpdateLocation.Enabled = True
            btnAddAttachment.Enabled = True
        Else
            hfdTagNumber.Value = ""
            pnlUpload.Visible = False
            btnUpdateLocation.Enabled = False
            btnAddAttachment.Enabled = False
        End If
    End Sub

    Protected Sub sqldsTagsByAsset_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsTagsByAsset.Selecting

        e.Command.Parameters("AssetTagNumber").Value = tbAssetTagNumber.Text

    End Sub

    Protected Sub sqldsTagsByAsset_Updated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsTagsByAsset.Updated
        If strTransDescription.Length > 0 Then
            sqldsTranHistory.Insert()
            strTransDescription = ""
            strTransUser = ""
            strTransTag = ""
        End If

    End Sub

    Protected Sub sqldsLookupTableData_Updating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsTagsByAsset.Updating
        If Updating = 1 Then

            Dim theTagValue As String = ""
            Dim row As GridViewRow = Me.gvLookupTable.Rows(Me.gvLookupTable.EditIndex)

            Dim theID As Guid = Me.gvLookupTable.DataKeys(Me.gvLookupTable.EditIndex).Value

            Dim txtTagValue As TextBox = CType(row.FindControl("TagValue"), TextBox)
            Dim ddlTagValue As DropDownList = CType(row.FindControl("ddlTagValue"), DropDownList)

            Dim ddlTagName As DropDownList = CType(row.FindControl("TagName"), DropDownList)

            If txtTagValue.Visible = True Then
                If String.IsNullOrEmpty(Trim(txtTagValue.Text)) Then
                    Me.lblContentBodyError.Text = "The Tag Value field is required."
                    Me.lblContentBodyError.Visible = True
                    e.Cancel = True
                    Exit Sub
                End If
                theTagValue = txtTagValue.Text
            Else
                theTagValue = ddlTagValue.SelectedValue()
            End If


            'get the type of the field and make sure it validates
            intTagNameID = ddlTagName.SelectedValue
            If Not ValidateField(intTagNameID, theTagValue) Then
                Me.lblContentBodyError.Text = strValidationMessage
                Me.lblContentBodyError.Visible = True
                e.Cancel = True
                Exit Sub
            End If

            If ddlTagName.SelectedItem.ToString() = "Quantity" Then
                oldQtyValue = Session("oldQtyValue")
                strTransDescription = "Updated Tag Value Quantity: From " + oldQtyValue + " to " + theTagValue
            Else
                strTransDescription = "Updated Tag Value " + ddlTagName.SelectedItem.ToString() + ":" + theTagValue
            End If

            strTransUser = Session("LoginID")
            strTransTag = hfdTagNumber.Value

            e.Command.Parameters("P1").Value = theID.ToString()
            e.Command.Parameters("P2").Value = CInt(ddlTagName.SelectedValue)
            e.Command.Parameters("P3").Value = Me.ConvertIfDate(intTagNameID, theTagValue)

            Dim l As New ListItem(theTagValue, theTagValue)
            ddlTagValue.Items.Add(l)

            Updating = 0
        End If
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        pnlLocation.Visible = True
        PopulateForm()
        PopulateLocation()
        Me.btnDeleteAsset.Enabled = True
    End Sub

    Private Sub PopulateForm()
        Me.sqldsTagsByAsset.Select(DataSourceSelectArguments.Empty)
        Me.gvLookupTable.DataBind()

        Me.gvAssetAttachments.DataBind()
        ListView1.DataBind()

        PopulateSoldInfo()

    End Sub

    Private Sub PopulateSoldInfo()
        Dim dv As DataView = CType(Me.sqldsAssetSoldInfo.Select(DataSourceSelectArguments.Empty), DataView)

        Dim dt As DataTable = dv.ToTable
        If dt.Rows.Count > 0 Then
            Dim dr As DataRow = dt.Rows(0)
            If String.IsNullOrEmpty(dr("SoldDate").ToString) Then
                Me.lblSoldDate.Visible = False
            Else
                Me.lblSoldDate.Text = "Asset Sold via Auction On " & CType(dr("SoldDate"), Date).ToShortDateString
                Me.lblSoldDate.Visible = True
            End If
        Else
            Me.lblSoldDate.Visible = False
        End If

    End Sub


    Protected Sub sqldsTranHistory_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsTranHistory.Inserting
        e.Command.Parameters("Description").Value = strTransDescription
        e.Command.Parameters("TheUser").Value = strTransUser
        e.Command.Parameters("TheTag").Value = strTransTag
    End Sub




    Protected Sub gvLookupTable_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvLookupTable.RowDataBound
        If (e.Row.RowType = DataControlRowType.DataRow) Then
            Dim ddlTagName As DropDownList = CType(e.Row.FindControl("ddlTagValue"), DropDownList)
            Dim tbTagName As TextBox = CType(e.Row.FindControl("TagValue"), TextBox)
            Dim theTag As DropDownList = CType(e.Row.FindControl("TagName"), DropDownList)

            If Not theTag Is Nothing Then


                Dim tagtype As String = ""
                tagDesc = theTag.SelectedItem.Text
                Dim dv2 As DataView = CType(Me.sqldsGetTagByDescription.Select(DataSourceSelectArguments.Empty), DataView)
                Dim dt2 As DataTable = dv2.ToTable

                If dt2.Rows.Count > 0 Then
                    Dim dr2 As DataRow = dt2.Rows(0)

                    Try
                        tagtype = dr2("tagtype")
                    Catch ex As Exception
                        tagtype = ""
                    End Try
                End If

                If tagtype = "List" Then
                    tbTagName.Visible = False
                Else
                    ddlTagName.Visible = False
                End If

            End If



            'If Not ddlTagName Is Nothing Then
            '    If ddlTagName.Items.Count = 0 Then
            '        ddlTagName.Visible = False
            '    Else
            '        tbTagName.Visible = False
            '    End If
            'End If
        End If
       


    End Sub

    Protected Sub btnUpload_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        If (FileUpload1.HasFile) Then
            Dim fileName As String = Server.HtmlEncode(FileUpload1.FileName)
            Dim extension As String = System.IO.Path.GetExtension(fileName)
            If (extension.ToUpper = ".JPG") Or (extension.ToUpper = ".GIF") Then
                Me.imageThumb = Me.GetThumbNail()
                Me.imageOrig = Me.GetOriginalImage()
                Me.sqldsPhotos.Insert()
                lblMessage.Text = ""
                lblMessage.Visible = False
                Me.ListView1.DataBind()
            Else
                lblMessage.Text = "Please select an image file to upload."
                lblMessage.Visible = True
            End If
        Else
            lblMessage.Text = "Please select an image file to upload."
            lblMessage.Visible = True
        End If


       
    End Sub



    Private Function GetThumbNail() As Byte()
        Dim b As Byte()
        If (FileUpload1.HasFile) Then
            Dim fileName As String = Server.HtmlEncode(FileUpload1.FileName)
            Dim extension As String = System.IO.Path.GetExtension(fileName)
            If (extension.ToUpper = ".JPG") Or (extension.ToUpper = ".GIF") Then


                '**** Resize image section ****
                Dim image_file As System.Drawing.Image = System.Drawing.Image.FromStream(FileUpload1.PostedFile.InputStream)
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
        End If
        Return b
    End Function

    Private Function GetOriginalImage() As Byte()
        Dim b As Byte()
        If (FileUpload1.HasFile) Then
            Dim fileName As String = Server.HtmlEncode(FileUpload1.FileName)
            Dim extension As String = System.IO.Path.GetExtension(fileName)
            If (extension.ToUpper = ".JPG") Or (extension.ToUpper = ".GIF") Then


                '**** Resize image section ****
                Dim image_file As System.Drawing.Image = System.Drawing.Image.FromStream(FileUpload1.PostedFile.InputStream)
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
        End If
        Return b
    End Function

    Protected Sub sqldsPhotos_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsPhotos.Inserting
        e.Command.Parameters("TagName").Value = Me.hfdTagNumber.Value
        e.Command.Parameters("OriginalPhoto").Value = Me.imageOrig
        e.Command.Parameters("ThumbnailPhoto").Value = Me.imageThumb
    End Sub

    Protected Sub SqlDataSource1_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles SqlDataSource1.Selecting
        e.Command.Parameters("TAG").Value = Me.hfdTagNumber.Value
    End Sub

    Protected Sub ddlWarehouse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlWarehouse.SelectedIndexChanged
        rootSelected = CInt(ddlWarehouse.SelectedValue)
        Me.sqldsLocationsForRoot.Select(DataSourceSelectArguments.Empty)
        Me.ddlLocation.DataBind()
    End Sub

    Protected Sub sqldsLocationsForRoot_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsLocationsForRoot.Selecting
        e.Command.Parameters("TheRoot").Value = rootSelected
    End Sub

    Protected Sub sqldsAssetLocation_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles sqldsAssetLocation.Inserted
        sqldsTranHistory.Insert()
    End Sub

    Protected Sub sqldsAssetLocation_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsAssetLocation.Inserting

        strTransDescription = "Location Update: " + ddlWarehouse.SelectedItem.ToString() + "/" + ddlLocation.SelectedItem.ToString()
        strTransUser = Session("LoginID")
        strTransTag = hfdTagNumber.Value

        e.Command.Parameters("TheLocation").Value = CInt(Me.ddlLocation.SelectedValue)
        e.Command.Parameters("TheUser").Value = Session("LoginID")
        e.Command.Parameters("TheTag").Value = Me.hfdTagNumber.Value
    End Sub

    Protected Sub sqldsAssetLocation_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsAssetLocation.Selecting
        e.Command.Parameters("TheTag").Value = Me.hfdTagNumber.Value
    End Sub

    Protected Sub sqldsAssetRootLocation_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsAssetRootLocation.Selecting
        e.Command.Parameters("TheTag").Value = Me.hfdTagNumber.Value
    End Sub

    Protected Sub btnUpdateLocation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdateLocation.Click
        Me.sqldsAssetLocation.Insert()
        PopulateLocation()
    End Sub

    Protected Sub sqldsGetTagByID_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsGetTagByID.Selecting
        e.Command.Parameters("TheID").Value = intTagNameID
    End Sub

    Protected Sub sqldsTags_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsTags.Selecting
        e.Command.Parameters("TagNum").Value = Me.hfdTagNumber.Value
    End Sub

    Protected Sub ButtonCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        'do nothing
        Dim s As String
        s = "phil"
    End Sub

    Protected Sub ButtonOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        'delete the asset with the stored proc
        sqldsAsset.Delete()
        Response.Redirect("EditAsset.aspx")
    End Sub

    Protected Sub sqldsAsset_Deleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsAsset.Deleting
        e.Command.Parameters("TagNum").Value = Me.hfdTagNumber.Value
        e.Command.Parameters("theUser").Value = Session("LoginID")
    End Sub

    Protected Sub sqldsListItems_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsListItems.Selecting
        e.Command.Parameters("TagNameID").Value = intTagNameID
        e.Command.Parameters("theDefaultVal").Value = defaultListValue
    End Sub

    Protected Sub gvLookupTable_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles gvLookupTable.RowEditing
        gvLookupTable.ShowFooter = False

        Dim i As Integer = e.NewEditIndex()
        Dim row As GridViewRow = Me.gvLookupTable.Rows(i)
        Dim lblTagName As Label = CType(row.FindControl("lblTagName"), Label)
        tagDesc = lblTagName.Text
        If tagDesc = "Quantity" Then
            Dim lblTV As Label = CType(row.FindControl("TagValueLabel"), Label)
            oldQtyValue = lblTV.Text
            Session("oldQtyValue") = oldQtyValue
        End If


        Dim tagtype As String = ""
        Dim tagnameid As Integer = 0
        Dim dv2 As DataView = CType(Me.sqldsGetTagByDescription.Select(DataSourceSelectArguments.Empty), DataView)
        Dim dt2 As DataTable = dv2.ToTable

        If dt2.Rows.Count > 0 Then
            Dim dr2 As DataRow = dt2.Rows(0)

            Try
                tagtype = dr2("tagtype")
            Catch ex As Exception
                tagtype = ""
            End Try

            Try
                tagnameid = dr2("tagnameid")
            Catch ex As Exception
                tagnameid = 0
            End Try

        Else
            tagtype = ""
            tagnameid = 0
        End If

        If tagtype = "List" Then
            intTagNameID = tagnameid
            defaultListValue = ""
        Else
            intTagNameID = 0
            Dim lblTagValue As Label = CType(row.FindControl("TagValueLabel"), Label)
            defaultListValue = lblTagValue.Text
        End If

    End Sub

    Protected Sub sqldsGetTagByDescription_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsGetTagByDescription.Selecting
        e.Command.Parameters("TagDesc").Value = tagDesc
    End Sub

    Protected Sub lstItems_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim lst As System.Web.UI.WebControls.DropDownList = DirectCast(sender, System.Web.UI.WebControls.DropDownList)
        Dim s As String = lst.SelectedValue
        'get the tag and see if its a list type
        intTagNameID = CInt(s)

        Dim tagtype As String = ""
        Dim tagnameid As Integer = 0
        Dim dv2 As DataView = CType(Me.sqldsGetTagByID.Select(DataSourceSelectArguments.Empty), DataView)
        Dim dt2 As DataTable = dv2.ToTable

        If dt2.Rows.Count > 0 Then
            Dim dr2 As DataRow = dt2.Rows(0)

            Try
                tagtype = dr2("tagtype")
            Catch ex As Exception
                tagtype = ""
            End Try

            Try
                tagnameid = dr2("tagnameid")
            Catch ex As Exception
                tagnameid = 0
            End Try

        Else
            tagtype = ""
            tagnameid = 0
        End If

        If tagtype = "List" Then
            intTagNameID = tagnameid
            Me.sqldsListItems.Select(DataSourceSelectArguments.Empty)
            Dim ddlTagName As DropDownList = CType(gvLookupTable.FooterRow.FindControl("ddlTagValue"), DropDownList)
            Dim tbTagName As TextBox = CType(gvLookupTable.FooterRow.FindControl("TagValue"), TextBox)
            ddlTagName.Visible = True
            tbTagName.Visible = False
            ddlTagName.DataBind()

        Else
            intTagNameID = 0
            Dim ddlTagName As DropDownList = CType(gvLookupTable.FooterRow.FindControl("ddlTagValue"), DropDownList)
            Dim tbTagName As TextBox = CType(gvLookupTable.FooterRow.FindControl("TagValue"), TextBox)
            ddlTagName.Visible = False
            tbTagName.Visible = True
        End If
    End Sub

    Protected Sub gvLookupTable_RowUpdated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewUpdatedEventArgs) Handles gvLookupTable.RowUpdated
        Dim oldvalue As String
        Dim newvalue As String

        oldvalue = e.OldValues(0)
        newvalue = e.NewValues(0)

        Dim s As String = oldvalue + newvalue
    End Sub

    Protected Sub gvLookupTable_RowUpdating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewUpdateEventArgs) Handles gvLookupTable.RowUpdating
        Dim oldvalue As String
        Dim newvalue As String

        oldvalue = e.OldValues(0)
        newvalue = e.NewValues(0)

        Dim s As String = oldvalue + newvalue
    End Sub

    Protected Sub sqldsAssetAttachments_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsAssetAttachments.Selecting
        e.Command.Parameters("TagNumber").Value = Me.tbAssetTagNumber.Text
    End Sub

    Protected Sub btnAddAttachment_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddAttachment.Click
        Me.gvAssetAttachments.DataBind()
    End Sub

    Protected Sub gvAssetAttachments_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvAssetAttachments.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim ibnAttachment As ImageButton = CType(e.Row.FindControl("ibnAttachment"), ImageButton)
            Dim strItemId As String = CType(e.Row.DataItem, System.Data.DataRowView).Item("ItemId").ToString
            ibnAttachment.Attributes.Add("onclick", "javascript:openAssetAttachment('" & strItemId & "');return false;")
        End If

    End Sub

    Protected Sub ibnRemove_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        intDeleteAttachmentID = CType(sender, ImageButton).CommandArgument
        Me.sqldsAssetAttachments.Update()

        Me.gvAssetAttachments.DataBind()
    End Sub

    Protected Sub sqldsAssetAttachments_Updating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsAssetAttachments.Updating
        e.Command.Parameters("ItemId").Value = intDeleteAttachmentID
    End Sub

    Protected Sub sqldsAssetSoldInfo_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsAssetSoldInfo.Selecting
        e.Command.Parameters("TagNumber").Value = Me.hfdTagNumber.Value
    End Sub
End Class
