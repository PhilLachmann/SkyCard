<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="SearchEditAuctionItems.aspx.vb" Inherits="SearchEditAuctionItems" title="Edit Items To Be Auctioned" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>
    <table cellspacing="0" cellpadding="0" width="100%" border="0" class="TableSearch">
        <tbody>
            <tr>
                <td>
                    <table cellspacing="1" cellpadding="1" width="100%" border="1">
                        <tbody>
                            <tr>
                                <td class="tableCaptionLabel" colspan="6" align="center">
                                    Edit Auction Properties For Items Scheduled To Be Auctioned
                                </td>
                            </tr>
                            <tr>
                                <td class="Header2" width="17%">
                                    Search By
                                </td>
                                <td class="Header2" width="33%">
                                    Search Criteria
                                </td>
                                <td class="Header2" width="17%">
                                    Search By
                                </td>
                                <td class="Header2" width="33%">
                                    Search Criteria
                                </td>
                            </tr>
                            <tr valign="top">
                                <td align="left">
                                    <asp:Label ID="Label2" runat="server" Text="Tag Number"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="txtTagNumber" runat="server" CssClass="dControl" Width="50%" MaxLength="10"></asp:TextBox>
                                </td>
                                <td align="left">
                                    <asp:Label ID="Label1" runat="server" Text="Auction Start Date Between"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="txtDateStart" runat="server" CssClass="dControl" Width="30%" MaxLength="10"></asp:TextBox>
                                    <ajaxToolkit:CalendarExtender ID="calDateStart" runat="server" TargetControlID="txtDateStart" Format="MM/dd/yyyy" PopupButtonID="imgDateStartCalendarIcon" />
                                    <asp:ImageButton runat="Server" ID="imgDateStartCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar"/>&nbsp;&nbsp;
                                    And&nbsp;&nbsp;
                                    <asp:TextBox ID="txtDateEnd" runat="server" CssClass="dControl" Width="30%" MaxLength="10"></asp:TextBox>
                                    <ajaxToolkit:CalendarExtender ID="calDateEnd" runat="server" TargetControlID="txtDateEnd" Format="MM/dd/yyyy" PopupButtonID="imgDateEndCalendarIcon" />
                                    <asp:ImageButton runat="Server" ID="imgDateEndCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar"/>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <table cellspacing="1" cellpadding="1" width="100%" border="1">
                        <tbody>
                            <tr>
                                <td align="center" style="width: 50%;">
                                    <asp:Button ID="btnSearch" runat="server" Text="Search / List Items To Be Auctioned"></asp:Button>
                                </td>
                                <td align="center" style="width: 50%">
                                    <asp:Button ID="btnClearCriteria" runat="server" Text="Clear Criteria/Results"></asp:Button>
                                </td>
                            </tr>
                        </tbody>
                    </table>

                    <table cellspacing="1" cellpadding="1" width="100%" border="0">
                        <tbody>
                            <tr>
                                <td>
                                    <div runat="server" id="GVTitle">
                                        <table cellspacing="0" cellpadding="0" width="100%" border="0" class="captionLabel">
                                            <tr>
                                                <td align="left" class="RptHeader" width="33%" style="height: 20px">
                                                    <asp:Label Width="100%" ID="lblPageCount" runat="server" Text="Page 1 of 1" Font-Size="smaller"></asp:Label>
                                                </td>
                                                <td class="RptHeader" width="34%" style="height: 20px" align="center">
                                                    <asp:Label ID="lblReportResults" runat="server" Text="Search Results"></asp:Label>
                                                </td>
                                                <td class="RptHeader" width="33%" style="height: 20px" align="right">
                                                    <asp:Label ID="lblRecordCount" runat="server" Text="Record 1 of 1" Font-Size="smaller"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:HiddenField ID="hfdTotalRecords" runat="server" />
                                    <asp:GridView ID="gvSearchRecs" runat="server" Width="100%" AllowSorting="False" HeaderStyle-CssClass="Header2" ShowFooter="True"
                                        AllowPaging="True" PageSize="15" EmptyDataText="There are no Assets in the system that are set to be auctioned that match the above criteria."
                                        AutoGenerateColumns="False" CellPadding="4" DataKeyNames="AssetAuctionID" ForeColor="#333333"
                                        GridLines="Vertical">
                                        <AlternatingRowStyle CssClass="gvRowDataAlt" HorizontalAlign="Left"></AlternatingRowStyle>
                                        <FooterStyle BackColor="#A9A9A9"  />
                                        <PagerSettings Mode="NextPreviousFirstLast" FirstPageImageUrl="Images/resultset_first.png"
                                            FirstPageText="First" LastPageImageUrl="Images/resultset_last.png" LastPageText="Last"
                                            NextPageImageUrl="Images/resultset_next.png" NextPageText="Next" PreviousPageImageUrl="Images/resultset_previous.png"
                                            PreviousPageText="Previous"></PagerSettings>
                                        <RowStyle CssClass="gvRowData" HorizontalAlign="Left"></RowStyle>
                                        <Columns>
                                            <asp:TemplateField HeaderText="Photo" HeaderStyle-Width="5%" ItemStyle-VerticalAlign="Top">
                                                <ItemTemplate>
                                                    <asp:Image ID="AssetPhoto" runat="server" ImageUrl='<%# "PhotoDisplay.ashx?TagNumber=" + Eval("TagNumber")  %>' Height="32px" Width="32px"  />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="TagNumber" HeaderText="Tag No" SortExpression="TagNumber" HeaderStyle-Width="8%" />
                                            <asp:TemplateField HeaderText="Auction Date" HeaderStyle-Width="10%" ItemStyle-VerticalAlign="Middle" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="AuctionStartDate" runat="server" Text='<%# Utilities.NullableFormatDateTimeShortDate(Eval("AuctionStartDate")) %>' ToolTip='<%# Utilities.NullableFormatDateTimeDateAndTime(Eval("AuctionStartDate")) %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="Title" HeaderText="Listing Title" SortExpression="Title" HeaderStyle-Width="15%" />
                                            <asp:BoundField DataField="Subtitle" HeaderText="Listing Subtitle" SortExpression="Subtitle" HeaderStyle-Width="25%" />
                                            <asp:TemplateField HeaderText="BuyNowPrice" HeaderStyle-Width="10%" ItemStyle-VerticalAlign="Middle" ItemStyle-HorizontalAlign="Right">
                                                <ItemTemplate>
                                                    <asp:Label ID="BuyNowPrice" runat="server" Text='<%# Utilities.NullableFormatNumberDecimal2(Eval("BuyNowPrice")) %>'></asp:Label>
                                                 </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Min Bid Value" HeaderStyle-Width="10%" ItemStyle-VerticalAlign="Middle" ItemStyle-HorizontalAlign="Right">
                                                <ItemTemplate>
                                                    <asp:Label ID="MinBidValue" runat="server" Text='<%# Utilities.NullableFormatNumberDecimal2(Eval("MinBidValue")) %>'></asp:Label>
                                                 </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="CEO Min Value" HeaderStyle-Width="10%" ItemStyle-VerticalAlign="Middle">
                                                <ItemTemplate>
                                                    <asp:TextBox ID="CEOMinBidValue" runat="server" Text='<%# Utilities.NullableFormatNumberDecimal2(Eval("CEOMinBidValue")) %>'></asp:TextBox>
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="ftbxCEOMinBidValue" runat="server" Enabled="True" FilterType="Numbers,Custom" ValidChars="." TargetControlID="CEOMinBidValue">
                                                    </ajaxToolkit:FilteredTextBoxExtender>
                                                 </ItemTemplate>
                                                 <FooterTemplate>
                                                     <asp:Button ID="btnSaveChanges" runat="server" Text="Save Changes to CEO&#010;Min Values on Page" Width="140px" OnClick="btnSaveChanges_Click" />
                                                 </FooterTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Actions" HeaderStyle-Width="7%" ItemStyle-HorizontalAlign="Center" >
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="btnEditItem" runat="server" CommandName="Edit" Text="Edit Auction Item" ImageUrl="~/Images/item_edit.png" ToolTip="Edit Auction Item"/>&nbsp;&nbsp;&nbsp;
                                                    <asp:ImageButton ID="btnRemoveItem" runat="server" CommandName="Delete" CommandArgument="<%# Container.DataItemIndex %>" Text="Remove Auction Item" ImageUrl="~/Images/item_remove.png" ToolTip="Remove Item From Being Sent To Auction"/>&nbsp;&nbsp;&nbsp;
                                                    <ajaxToolkit:ConfirmButtonExtender ID="cbeRemoveItem" runat="server" 
                                                        TargetControlID="btnRemoveItem"
                                                        ConfirmText="Are you sure you want to Remove this item from being auctioned?" 
                                                        OnClientCancel="cancelClick" />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <HeaderStyle BackColor="DarkGray" Font-Bold="True" ></HeaderStyle>
                                        <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                    </asp:GridView>
                                    <asp:SqlDataSource ID="sqldsItemSearch" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>" CancelSelectOnNullParameter="False"
                                        SelectCommand="Call GetAssetAuctionItems(?,?,?)" SelectCommandType="StoredProcedure" 
                                        UpdateCommand="Call DeleteAssetAuctionItem(?)" UpdateCommandType="StoredProcedure"
                                        DeleteCommand="XXXX" DeleteCommandType="StoredProcedure"
                                        InsertCommand="Call UpdateAssetAuctionItemCEOMinValue(?,?)" InsertCommandType="StoredProcedure">
                                        <SelectParameters>
                                            <asp:Parameter Name="theTagNumber" Type="String" />
                                            <asp:Parameter Name="DateRangeStart" Type="DateTime" />
                                            <asp:Parameter Name="DateRangeEnd" Type="DateTime" />
                                        </SelectParameters>
                                        <UpdateParameters>
                                            <asp:Parameter Name="AssetAuctionID" Type="Int32" />
                                        </UpdateParameters>
                                        <InsertParameters>
                                            <asp:Parameter Name="AssetAuctionID" Type="Int32" />
                                            <asp:Parameter Name="CEOMinBidvalue" Type="Decimal" />
                                        </InsertParameters>
                                    </asp:SqlDataSource>




                                    
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>



</asp:Content>

