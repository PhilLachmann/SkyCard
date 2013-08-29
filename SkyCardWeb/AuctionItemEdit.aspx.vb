
Partial Class AuctionItemEdit
    Inherits System.Web.UI.Page
    Private strErrorMsg As String = ""

    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim pgError As Exception = Server.GetLastError()

        Server.ClearError()
        Session("UntrappedError") = pgError
        Response.Redirect("UntrappedError.aspx")

    End Sub

    Protected Sub sqldsLookupTableData_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles sqldsLookupTableData.Selecting
        Dim strAssetAuctionID As String = Session("AssetAuctionID").ToString

        e.Command.Parameters("AssetAuctionID").Value = strAssetAuctionID

    End Sub

    Protected Sub btnCancelAuctionItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelAuctionItem.Click
        Dim arrlstSearchCriteria As ArrayList = Session("SearchCriteria")
        arrlstSearchCriteria(0) = True
        Session("SearchCriteria") = arrlstSearchCriteria

        Response.Redirect("SearchEditAuctionItems.aspx")

    End Sub

    Protected Sub btnUpdateAuctionItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdateAuctionItem.Click
        Try
            If EditAssetAuctionItem() = False Then
                Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
                mstr.ShowErrorMessage(strErrorMsg)
                Exit Sub
            End If

            Dim intAffectedRows As Integer = Me.sqldsLookupTableData.Update()
            If intAffectedRows > 0 Then
                Dim arrlstSearchCriteria As ArrayList = Session("SearchCriteria")
                arrlstSearchCriteria(0) = True
                Session("SearchCriteria") = arrlstSearchCriteria

                Response.Redirect("SearchEditAuctionItems.aspx")
            Else
                Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
                mstr.ShowErrorMessage("An Error was encountered: No Rows were updated.")
            End If
        Catch ex As Exception
            Dim mstr As GMechMaster = CType(Me.Master, GMechMaster)
            mstr.ShowErrorMessage("An Error was encountered: No Rows were updated.  " & ex.Message)
        End Try

    End Sub

    Protected Function EditAssetAuctionItem() As Boolean
        Dim bolRetValue As Boolean = True

        Dim row As DetailsViewRow = Me.dvAssetAuctionItem.Rows(0)

        Dim ddlRegionID As DropDownList = CType(row.FindControl("RegionID"), DropDownList)
        Dim ddlCategoryID As DropDownList = CType(row.FindControl("CategoryID"), DropDownList)
        Dim txtTitle As TextBox = CType(row.FindControl("Title"), TextBox)
        Dim txtSubtitle As TextBox = CType(row.FindControl("Subtitle"), TextBox)
        Dim txtBuyNowPrice As TextBox = CType(row.FindControl("BuyNowPrice"), TextBox)
        Dim txtMinBidValue As TextBox = CType(row.FindControl("MinBidValue"), TextBox)
        Dim txtStartDate As TextBox = CType(row.FindControl("StartDate"), TextBox)
        Dim txtAuctionDuration As TextBox = CType(row.FindControl("AuctionDuration"), TextBox)
        Dim ddlCurrencyCode As DropDownList = CType(row.FindControl("CurrencyCode"), DropDownList)
        Dim lblCEOMinBidVaue As Label = CType(row.FindControl("CEOMinBidValue"), Label)

        If bolRetValue = True Then
            If String.IsNullOrEmpty(txtTitle.Text) Then
                strErrorMsg = "The Item must have a Title."
                bolRetValue = False
            End If
        End If

        If bolRetValue = True Then
            If String.IsNullOrEmpty(txtBuyNowPrice.Text) Then
                strErrorMsg = "The Item must have a Buy Now Price."
                bolRetValue = False
            End If
        End If

        If bolRetValue = True Then
            If String.IsNullOrEmpty(txtMinBidValue.Text) Then
                strErrorMsg = "The Item must have a Min Bid Value."
                bolRetValue = False
            End If
        End If

        If bolRetValue = True Then
            Dim decCEOMinBidVal As Decimal = IIf(String.IsNullOrEmpty(lblCEOMinBidVaue.Text), 0, lblCEOMinBidVaue.Text)
            If CType(txtBuyNowPrice.Text, Decimal) < decCEOMinBidVal Then
                strErrorMsg = "The Buy Now Price cannot be lower than the CEO Minimum Bid Value."
                bolRetValue = False
            End If
        End If

        If bolRetValue = True Then
            If CType(txtMinBidValue.Text, Decimal) > CType(txtBuyNowPrice.Text, Decimal) Then
                strErrorMsg = "The Buy Now Price cannot be lower than the Minimum Bid Value."
                bolRetValue = False
            End If
        End If

        If bolRetValue = True Then
            Dim decCEOMinBidVal As Decimal = IIf(String.IsNullOrEmpty(lblCEOMinBidVaue.Text), 0, lblCEOMinBidVaue.Text)
            If decCEOMinBidVal > 0 Then
                If CType(txtMinBidValue.Text, Decimal) > decCEOMinBidVal Then
                    strErrorMsg = "The CEO Minimum Bid Value cannot be lower than the Minimum Bid Value.  Please decrease the Minimum Bid Value."
                    bolRetValue = False
                End If
            End If
        End If

        If bolRetValue = True Then
            If String.IsNullOrEmpty(txtStartDate.Text) Then
                strErrorMsg = "The Item must have an Auction Start Date."
                bolRetValue = False
            End If
        End If

        If bolRetValue = True Then
            If String.IsNullOrEmpty(txtAuctionDuration.Text) Then
                strErrorMsg = "The Item must have an Auction Duration."
                bolRetValue = False
            End If
        End If

        If bolRetValue = True Then
            If txtAuctionDuration.Text < 1 Then
                strErrorMsg = "The Item must have a positive Auction Duration."
                bolRetValue = False
            End If
        End If

        If bolRetValue = True Then
            If CType(txtStartDate.Text, Date) < Today() Then
                strErrorMsg = "The Start date cannot be in the past."
                bolRetValue = False
            End If
        End If


        Return bolRetValue
    End Function

    Protected Sub sqldsLookupTableData_Updating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceCommandEventArgs) Handles sqldsLookupTableData.Updating
        Dim row As DetailsViewRow = Me.dvAssetAuctionItem.Rows(0)

        Dim strAssetAuctionID As String = Me.dvAssetAuctionItem.DataKey.Value.ToString
        Dim ddlRegionID As DropDownList = CType(row.FindControl("RegionID"), DropDownList)
        Dim ddlCategoryID As DropDownList = CType(row.FindControl("CategoryID"), DropDownList)
        Dim txtTitle As TextBox = CType(row.FindControl("Title"), TextBox)
        Dim txtSubtitle As TextBox = CType(row.FindControl("Subtitle"), TextBox)
        Dim txtBuyNowPrice As TextBox = CType(row.FindControl("BuyNowPrice"), TextBox)
        Dim txtMinBidValue As TextBox = CType(row.FindControl("MinBidValue"), TextBox)
        Dim txtStartDate As TextBox = CType(row.FindControl("StartDate"), TextBox)
        Dim txtAuctionDuration As TextBox = CType(row.FindControl("AuctionDuration"), TextBox)
        Dim ddlCurrencyCode As DropDownList = CType(row.FindControl("CurrencyCode"), DropDownList)

        e.Command.Parameters("AssetAuctionID").Value = strAssetAuctionID
        e.Command.Parameters("RegionID").Value = ddlRegionID.SelectedValue
        e.Command.Parameters("CategoryID").Value = ddlCategoryID.SelectedValue
        e.Command.Parameters("Title").Value = txtTitle.Text
        e.Command.Parameters("Subtitle").Value = txtSubtitle.Text
        e.Command.Parameters("CurrencyCode").Value = ddlCurrencyCode.SelectedValue
        e.Command.Parameters("BuyNowPrice").Value = txtBuyNowPrice.Text
        e.Command.Parameters("MinBidValue").Value = txtMinBidValue.Text
        e.Command.Parameters("AuctionStartDate").Value = txtStartDate.Text
        e.Command.Parameters("AuctionDuration").Value = txtAuctionDuration.Text

    End Sub
End Class
