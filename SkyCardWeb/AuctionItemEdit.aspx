<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="AuctionItemEdit.aspx.vb" Inherits="AuctionItemEdit" title="Edit Asset To Be Auctioned" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Edit Asset To Be Auctioned
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnUpdateAuctionItem" runat="server" Text="Update Auction Item" />&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button ID="btnCancelAuctionItem" runat="server" Text="Cancel Auction Item Edit" />
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="2">

                                        <asp:DetailsView ID="dvAssetAuctionItem" runat="server" AutoGenerateRows="False" DataKeyNames="AssetAuctionID"
                                            DefaultMode="Edit" DataSourceID="sqldsLookupTableData" 
                                            Width="100%" Visible="True" CssClass="gview">
                                            <Fields>
                                                <asp:BoundField DataField="AssetAuctionID" HeaderText="RecordID" InsertVisible="False" ReadOnly="True" SortExpression="RecordID" Visible="False" />
                                                <asp:TemplateField HeaderText="Tag Number: ">
                                                    <EditItemTemplate>
                                                        &nbsp;&nbsp;&nbsp;<asp:Label ID="TagNumber" runat="server" Text='<%# Bind("TagNumber") %>'></asp:Label>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="50%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText='Region'>
                                                    <EditItemTemplate>
                                                        &nbsp;&nbsp;
                                                        <asp:DropDownList ID="RegionID" runat="server" SelectedValue='<%# Bind("RegionID") %>' DataSourceID="sqldsAuctionRegions" DataTextField="Name" DataValueField="ID"  >
                                                        </asp:DropDownList>
                                                        <asp:SqlDataSource ID="sqldsAuctionRegions" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                            ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                            SelectCommand="Call GetAuctionSiteRegions()" SelectCommandType="StoredProcedure"> 
                                                        </asp:SqlDataSource>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="50%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText='Category'>
                                                    <EditItemTemplate>
                                                        &nbsp;&nbsp;
                                                        <asp:DropDownList ID="CategoryID" runat="server" SelectedValue='<%# Bind("CategoryID") %>' DataSourceID="sqldsAuctionCategories" DataTextField="Name" DataValueField="ID"  >
                                                        </asp:DropDownList>
                                                        <asp:SqlDataSource ID="sqldsAuctionCategories" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                            ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                            SelectCommand="Call GetAuctionSiteCategories()" SelectCommandType="StoredProcedure"> 
                                                        </asp:SqlDataSource>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="50%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Title: ">
                                                    <EditItemTemplate>
                                                        &nbsp;&nbsp;&nbsp;<asp:TextBox ID="Title" runat="server" Text='<%# Bind("Title") %>' Width="80%"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="50%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Subtitle: ">
                                                    <EditItemTemplate>
                                                        &nbsp;&nbsp;&nbsp;<asp:TextBox ID="Subtitle" runat="server" Text='<%# Bind("Subtitle") %>' Width="80%"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="50%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText='Currency'>
                                                    <EditItemTemplate>
                                                        &nbsp;&nbsp;
                                                        <asp:DropDownList ID="CurrencyCode" runat="server" SelectedValue='<%# Bind("CurrencyCode") %>' DataSourceID="sqldsAuctionCurrencies" DataTextField="Code" DataValueField="Code"  >
                                                        </asp:DropDownList>
                                                        <asp:SqlDataSource ID="sqldsAuctionCurrencies" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                            ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                            SelectCommand="Call GetAuctionSiteCurrencies()" SelectCommandType="StoredProcedure"> 
                                                        </asp:SqlDataSource>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="50%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Buy Now Price: ">
                                                    <EditItemTemplate>
                                                        &nbsp;&nbsp;&nbsp;<asp:TextBox ID="BuyNowPrice" runat="server" Text='<%# Utilities.NullableFormatNumberDecimal2(Eval("BuyNowPrice")) %>'></asp:TextBox>
                                                        <ajaxToolkit:FilteredTextBoxExtender ID="ftbxBuyNowPrice" runat="server" Enabled="True" FilterType="Numbers,Custom" ValidChars="." TargetControlID="BuyNowPrice">
                                                        </ajaxToolkit:FilteredTextBoxExtender>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="50%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Min Bid Value: ">
                                                    <EditItemTemplate>
                                                        &nbsp;&nbsp;&nbsp;<asp:TextBox ID="MinBidValue" runat="server" Text='<%# Utilities.NullableFormatNumberDecimal2(Eval("MinBidValue")) %>'></asp:TextBox>
                                                        <ajaxToolkit:FilteredTextBoxExtender ID="ftbxminBidValue" runat="server" Enabled="True" FilterType="Numbers,Custom" ValidChars="." TargetControlID="minBidValue">
                                                        </ajaxToolkit:FilteredTextBoxExtender>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="50%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="CEOMinBidValue: " Visible="false">
                                                    <EditItemTemplate>
                                                        &nbsp;&nbsp;&nbsp;<asp:Label ID="CEOMinBidValue" runat="server" Text='<%# Bind("CEOMinBidValue") %>'></asp:Label>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="50%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Auction Start Date: ">
                                                    <EditItemTemplate>
                                                        &nbsp;&nbsp;&nbsp;<asp:TextBox ID="StartDate" runat="server" Width="70px" Text='<%# Utilities.NullableFormatDateTimeShortDate(Eval("AuctionStartDate")) %>' ></asp:TextBox>
                                                        <ajaxToolkit:CalendarExtender ID="calStartDate" runat="server" TargetControlID="StartDate" Format="MM/dd/yyyy" PopupButtonID="imgStartDateCalendarIcon" />
                                                        <asp:ImageButton runat="Server" ID="imgStartDateCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar"/>&nbsp;&nbsp;
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="50%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Duration: ">
                                                    <EditItemTemplate>
                                                        &nbsp;&nbsp;&nbsp;<asp:TextBox ID="AuctionDuration" runat="server" Text='<%# Bind("AuctionDuration") %>'></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="50%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Last Modified On: ">
                                                    <EditItemTemplate>
                                                        &nbsp;&nbsp;&nbsp;<asp:Label ID="Last_Modified" runat="server" Text='<%# Bind("Last_Modified") %>'></asp:Label>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="50%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>



                                            </Fields>
                                        </asp:DetailsView>
                                    
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                
                 <asp:SqlDataSource ID="sqldsLookupTableData" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetAssetAuctionItem(?)" SelectCommandType="StoredProcedure" 
                    UpdateCommand="Call UpdateAssetAuctionItem(?,?,?,?,?,?,?,?,?,?)" UpdateCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="AssetAuctionID" Type="Int32" />
                    </SelectParameters>
                    <UpdateParameters>
                         <asp:Parameter Name="AssetAuctionID" Type="Int32" />
                         <asp:Parameter Name="RegionID" Type="String" />
                         <asp:Parameter Name="CategoryID" Type="String" />
                         <asp:Parameter Name="Title" Type="String" />
                         <asp:Parameter Name="Subtitle" Type="String" />
                         <asp:Parameter Name="CurrencyCode" Type="String" />
                         <asp:Parameter Name="BuyNowPrice" Type="Decimal" />
                         <asp:Parameter Name="MinBidValue" Type="Decimal" />
                         <asp:Parameter Name="AuctionStartDate" Type="Datetime" />
                         <asp:Parameter Name="AuctionDuration" Type="Decimal" />
                    </UpdateParameters>
                </asp:SqlDataSource>



</asp:Content>

