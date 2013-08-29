<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="AuctionWizard.aspx.vb" Inherits="AuctionWizard" title="Asset Auction Wizard" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>


                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableWizardLabel" colspan="2">
                                        Asset Auction Wizard
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td width="100%" >
                                         <asp:Wizard ID="wizAddAuctionListings" runat="server" DisplaySideBar="False" Width="100%">
                                            <WizardSteps>
                                                <asp:WizardStep ID="wizstpSearchAssets" runat="server" Title="Search Assets">
                                                    <table cellspacing="0" cellpadding="0" width="100%" border="1" class="TableSearch">
                                                        <tr>
                                                            <td>
                                                                <table cellspacing="1" cellpadding="1" width="100%" border="0">
                                                                    <tbody>
                                                                        <tr>
                                                                            <td class="tableCaptionLabel" colspan="6" align="center">
                                                                                Search Assets
                                                                            </td>
                                                                        </tr>
                                                                        
                                                                        <tr valign="top">
                                                                            <td colspan="2">
                                                                                <asp:Label ID="Label2" runat="server" Text="In Building: "></asp:Label>
                                                                                <asp:SqlDataSource ID="sqldsBuildings" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                                                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                                                    SelectCommand="Call GetAllRootLocations()" SelectCommandType="StoredProcedure">
                                                                                </asp:SqlDataSource>
                                                                                <asp:DropDownList ID="BuildingID" runat="server" AppendDataBoundItems="True" DataSourceID="sqldsBuildings"
                                                                                        DataTextField="LocDesc" DataValueField="LocNameID" >
                                                                                        <asp:ListItem Selected="True" Text="All" Value="0"></asp:ListItem>
                                                                                </asp:DropDownList>
                                                                            </td>
                                                                        </tr>

                                                                        <tr valign="top">
                                                                            <td colspan="2">
                                                                            
                                                                                <asp:ListView ID="lvQuery" runat="server" >
                                                                                    <LayoutTemplate>
                                                                                        <asp:Placeholder
                                                                                        id="groupPlaceholder"
                                                                                        runat="server" />
                                                                                    </LayoutTemplate>
                                                                                    <GroupTemplate>
                                                                                        <div>
                                                                                        <asp:Placeholder
                                                                                        id="itemPlaceholder"
                                                                                        runat="server" />
                                                                                        </div>
                                                                                    </GroupTemplate>
                                                                                    <ItemTemplate>
                                                                                        <asp:DropDownList ID="tagname" runat="server" DataSourceID="sqldsTagList" SelectedValue='<%# Bind("Tagname") %>'
                                                                                                    DataTextField="TagDesc" DataValueField="TagDesc"  AppendDataBoundItems ="true" AutoPostBack="true" OnSelectedIndexChanged="lstTagname_SelectedIndexChanged">
                                                                                                    <asp:ListItem Text="All" Value="All" />
                                                                                        </asp:DropDownList>
                                                                                        
                                                                                       <asp:DropDownList ID="Operation" runat="server" SelectedValue='<%# Bind("Operation") %>' AutoPostBack="true" OnSelectedIndexChanged="lstOperation_SelectedIndexChanged">
                                                                                                    <asp:ListItem Text="Equals" Value="Equals" Selected="True"/>
                                                                                                    <asp:ListItem Text="Like" Value="Like"  />
                                                                                       </asp:DropDownList>
                                                                                        
                                                                                        <asp:TextBox ID="TagValue" runat="server" Text='<%# Bind("TagValue") %>' Width="75%"></asp:TextBox>
                                                                                        
                                                                                        <asp:DropDownList ID="ddlAlphabet" runat="server" Visible="false" AutoPostBack="true" OnSelectedIndexChanged="lstAlphabet_SelectedIndexChanged">
                                                                                            <asp:ListItem Text="A" Value="A" Selected="True"/>
                                                                                            <asp:ListItem Text="B" Value="B"  />
                                                                                            <asp:ListItem Text="C" Value="C"  />
                                                                                            <asp:ListItem Text="D" Value="D"  />
                                                                                            <asp:ListItem Text="E" Value="E"  />
                                                                                            <asp:ListItem Text="F" Value="F"  />
                                                                                            <asp:ListItem Text="G" Value="G"  />
                                                                                            <asp:ListItem Text="H" Value="H"  />
                                                                                            <asp:ListItem Text="I" Value="I"  />
                                                                                            <asp:ListItem Text="J" Value="J"  />
                                                                                            <asp:ListItem Text="K" Value="K"  />
                                                                                            <asp:ListItem Text="L" Value="L"  />
                                                                                            <asp:ListItem Text="M" Value="M"  />
                                                                                            <asp:ListItem Text="N" Value="N"  />
                                                                                            <asp:ListItem Text="O" Value="O"  />
                                                                                            <asp:ListItem Text="P" Value="P"  />
                                                                                            <asp:ListItem Text="Q" Value="Q"  />
                                                                                            <asp:ListItem Text="R" Value="R"  />
                                                                                            <asp:ListItem Text="S" Value="S"  />
                                                                                            <asp:ListItem Text="T" Value="T"  />
                                                                                            <asp:ListItem Text="U" Value="U"  />
                                                                                            <asp:ListItem Text="V" Value="V"  />
                                                                                            <asp:ListItem Text="W" Value="W"  />
                                                                                            <asp:ListItem Text="X" Value="X"  />
                                                                                            <asp:ListItem Text="Y" Value="Y"  />
                                                                                            <asp:ListItem Text="Z" Value="Z"  />
                                                                                            <asp:ListItem Text="0" Value="0"  />
                                                                                            <asp:ListItem Text="1" Value="1"  />
                                                                                            <asp:ListItem Text="2" Value="2"  />
                                                                                            <asp:ListItem Text="3" Value="3"  />
                                                                                            <asp:ListItem Text="4" Value="4"  />
                                                                                            <asp:ListItem Text="5" Value="5"  />
                                                                                            <asp:ListItem Text="6" Value="6"  />
                                                                                            <asp:ListItem Text="7" Value="7"  />
                                                                                            <asp:ListItem Text="8" Value="8"  />
                                                                                            <asp:ListItem Text="9" Value="9"  />
                                                                                        </asp:DropDownList>
                                                                                    </ItemTemplate>
                                                                                    <EmptyItemTemplate>           
                                                                                       
                                                                                    </EmptyItemTemplate>
                                                                                </asp:ListView>
                                                                                
                                                                                
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                                <asp:Button ID="btnAddRow" runat="server" Text="Add Row" 
                                                                                    UseSubmitBehavior="False" Visible="False" />
                                                                            </td>
                                                                            <td align="right">&nbsp;
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>&nbsp;
                                                                            </td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>

                                                    <asp:SqlDataSource ID="sqldsSearchSchema" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                        SelectCommand="Call GetSearchSchema()" SelectCommandType="StoredProcedure"> 
                                                    </asp:SqlDataSource>

                                                    <asp:SqlDataSource ID="sqldsTagList" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                        SelectCommand="Call GetSearchableTags()" SelectCommandType="StoredProcedure"> 
                                                    </asp:SqlDataSource>

                                                    <asp:SqlDataSource ID="sqldsTagByDescription" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                        SelectCommand="Call GetSearchableTagByDescription(?)" SelectCommandType="StoredProcedure"> 
                                                        <SelectParameters>
                                                            <asp:Parameter Name="TagDesc" Type="String" />
                                                        </SelectParameters>
                                                    </asp:SqlDataSource>
                                                </asp:WizardStep>
                                                
                                                <asp:WizardStep ID="wizstpSelectAssets" runat="server" Title="Select Assets for Auction">
                                                    <table cellspacing="0" cellpadding="0" width="100%" border="1" class="TableSearch">
                                                        <tr>
                                                            <td>
                                                                <table cellspacing="1" cellpadding="1" width="100%" border="0">
                                                                    <tbody>
                                                                        <tr>
                                                                            <td class="tableCaptionLabel" colspan="6" align="center">
                                                                                Select Assets For Auction
                                                                            </td>
                                                                        </tr>

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

                                                                        <tr valign="top">
                                                                            <td colspan="2">

                                                                                <asp:HiddenField ID="hfdTotalRecords" runat="server" />
                                                                                <asp:GridView ID="gvSearchRecs" runat="server" Width="100%" AllowSorting="True" HeaderStyle-CssClass="Header2"
                                                                                    AllowPaging="True" PageSize="15" EmptyDataText="There are no Assets in the system that match the above criteria."
                                                                                    AutoGenerateColumns="False" CellPadding="4" DataKeyNames="TagNumber" ForeColor="#333333"
                                                                                    GridLines="Vertical">
                                                                                    <AlternatingRowStyle CssClass="gvRowDataAlt"></AlternatingRowStyle>
                                                                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                                                    <PagerSettings Mode="NextPreviousFirstLast" FirstPageImageUrl="Images/resultset_first.png"
                                                                                        FirstPageText="First" LastPageImageUrl="Images/resultset_last.png" LastPageText="Last"
                                                                                        NextPageImageUrl="Images/resultset_next.png" NextPageText="Next" PreviousPageImageUrl="Images/resultset_previous.png"
                                                                                        PreviousPageText="Previous"></PagerSettings>
                                                                                    <RowStyle CssClass="gvRowData"></RowStyle>
                                                                                    <Columns>
                                                                                        <asp:TemplateField HeaderText='<table width="100%"><tr><td align="left" width="20%"><input id="Checkbox2" type="checkbox" title="Select/Unselect All on Page" onclick="javascript:setAllCheckBoxes(this);" /></td><td align="center" width="80%">Select</td></tr></table>' HeaderStyle-Width="10%" ItemStyle-VerticalAlign="Top">
                                                                                            <ItemTemplate>
                                                                                                <asp:CheckBox ID="cbxSelect" runat="server" />
                                                                                            </ItemTemplate>

<HeaderStyle Width="10%"></HeaderStyle>

<ItemStyle VerticalAlign="Top"></ItemStyle>
                                                                                        </asp:TemplateField>
                                                                                        <asp:TemplateField HeaderText="Photo" HeaderStyle-Width="10%" ItemStyle-VerticalAlign="Top">
                                                                                            <ItemTemplate>
                                                                                                <asp:Image ID="AssetPhoto" runat="server" ImageUrl='<%# "PhotoDisplay.ashx?TagNumber=" + Eval("TagNumber")  %>' Height="32px" Width="32px"  />
                                                                                            </ItemTemplate>

<HeaderStyle Width="10%"></HeaderStyle>

<ItemStyle VerticalAlign="Top"></ItemStyle>
                                                                                        </asp:TemplateField>
                                                                                        <asp:BoundField DataField="TagNumber" HeaderText="Tag No" 
                                                                                            SortExpression="TagNumber" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                                                                                        </asp:BoundField>
                                                                                        <asp:BoundField DataField="TV_varchar" HeaderText="Decription" 
                                                                                            SortExpression="TV_varchar" HeaderStyle-Width="30%" >
<HeaderStyle Width="30%"></HeaderStyle>
                                                                                        </asp:BoundField>
                                                                                        <asp:BoundField DataField="location" HeaderText="Location" 
                                                                                            SortExpression="location" HeaderStyle-Width="30%" >
<HeaderStyle Width="30%"></HeaderStyle>
                                                                                        </asp:BoundField>
                                                                                        <asp:BoundField DataField="quantity" HeaderText="Qty" SortExpression="quantity" 
                                                                                            HeaderStyle-Width="10%" ItemStyle-HorizontalAlign="Center" >
<HeaderStyle Width="10%"></HeaderStyle>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                                                        </asp:BoundField>
                                                                                    </Columns>
                                                                                    <HeaderStyle BackColor="DarkGray" Font-Bold="True"></HeaderStyle>
                                                                                    <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                                                                </asp:GridView>
 
 
                                                                                
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>&nbsp;
                                                                            </td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>

                                                    <asp:SqlDataSource ID="sqldsSearchAssets" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                        SelectCommand="Call GetAssetsForAuction(?,?)" SelectCommandType="StoredProcedure"> 
                                                        <SelectParameters>
                                                            <asp:Parameter Name="thewhereclause" Type="String" />
                                                            <asp:Parameter Name="thelocationID" Type="Int32" />
                                                        </SelectParameters>
                                                    </asp:SqlDataSource>
                                                
                                                </asp:WizardStep>
                                                
                                                
                                                 <asp:WizardStep ID="wizstpListingSetup" runat="server" Title="Auction Listing Setup">
                                                    <table cellspacing="0" cellpadding="0" width="100%" border="1" class="TableSearch">
                                                        <tr>
                                                            <td>
                                                                <table cellspacing="1" cellpadding="1" width="100%" border="0">
                                                                    <tbody>
                                                                        <tr>
                                                                            <td class="tableCaptionLabel" colspan="6" align="center">
                                                                                Auction Listing Setup
                                                                            </td>
                                                                        </tr>

                                                                        <tr>
                                                                            <td>
                                                                                <div runat="server" id="GVAuctionTitle">
                                                                                    <table cellspacing="0" cellpadding="0" width="100%" border="0" class="captionLabel">
                                                                                        <tr>
                                                                                            <td align="left" class="RptHeader" width="33%" style="height: 20px">
                                                                                                <asp:Label Width="100%" ID="lblPageCountAuction" runat="server" Text="Page 1 of 1" Font-Size="smaller"></asp:Label>
                                                                                            </td>
                                                                                            <td class="RptHeader" width="34%" style="height: 20px" align="center">
                                                                                                <asp:Label ID="lblReportResultsAuction" runat="server" Text="Selected Items For Auction"></asp:Label>
                                                                                            </td>
                                                                                            <td class="RptHeader" width="33%" style="height: 20px" align="right">
                                                                                                <asp:Label ID="lblRecordCountAuction" runat="server" Text="Record 1 of 1" Font-Size="smaller"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </div>
                                                                            </td>
                                                                        </tr>

                                                                        <tr valign="top">
                                                                            <td colspan="2">
                                                                                <asp:HiddenField ID="hfdTotalRecordsAuction" runat="server" />
                                                                                <asp:GridView ID="gvAuctionRecords" runat="server" Width="100%" AllowSorting="False" HeaderStyle-CssClass="Header2"
                                                                                    AllowPaging="True" PageSize="15" EmptyDataText="There are no Assets in the system that match the above criteria."
                                                                                    AutoGenerateColumns="False" CellPadding="4" DataKeyNames="TagNumber" ForeColor="#333333"
                                                                                    GridLines="Vertical">
                                                                                    <AlternatingRowStyle CssClass="gvRowDataAlt"></AlternatingRowStyle>
                                                                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                                                    <PagerSettings Mode="NextPreviousFirstLast" FirstPageImageUrl="Images/resultset_first.png"
                                                                                        FirstPageText="First" LastPageImageUrl="Images/resultset_last.png" LastPageText="Last"
                                                                                        NextPageImageUrl="Images/resultset_next.png" NextPageText="Next" PreviousPageImageUrl="Images/resultset_previous.png"
                                                                                        PreviousPageText="Previous"></PagerSettings>
                                                                                    <RowStyle CssClass="gvRowData"></RowStyle>
                                                                                    <Columns>
                                                                                        <asp:TemplateField HeaderText="Photo" HeaderStyle-Width="10%" ItemStyle-VerticalAlign="Top">
                                                                                            <ItemTemplate>
                                                                                                <asp:Image ID="AssetPhoto" runat="server" ImageUrl='<%# "PhotoDisplay.ashx?TagNumber=" + Eval("TagNumber")  %>' Height="32px" Width="32px"  />
                                                                                            </ItemTemplate>

<HeaderStyle Width="10%"></HeaderStyle>

<ItemStyle VerticalAlign="Top"></ItemStyle>
                                                                                        </asp:TemplateField>
                                                                                        <asp:BoundField DataField="TagNumber" HeaderText="Tag No" 
                                                                                            SortExpression="TagNumber" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                                                                                        </asp:BoundField>
                                                                                        <asp:TemplateField HeaderText="Listing Title" HeaderStyle-Width="20%" ItemStyle-VerticalAlign="Top">
                                                                                            <ItemTemplate>
                                                                                                <asp:TextBox ID="Title" runat="server" Width="98%" Text='<%# Bind("Title") %>'></asp:TextBox>
                                                                                            </ItemTemplate>

<HeaderStyle Width="20%"></HeaderStyle>

<ItemStyle VerticalAlign="Top"></ItemStyle>
                                                                                        </asp:TemplateField>
                                                                                        <asp:TemplateField HeaderText="Listing Subtitle" HeaderStyle-Width="40%" ItemStyle-VerticalAlign="Top">
                                                                                            <ItemTemplate>
                                                                                                <asp:TextBox ID="Subtitle" runat="server" Text='<%# Bind("Subtitle") %>' Width="98%"></asp:TextBox>
                                                                                            </ItemTemplate>

<HeaderStyle Width="40%"></HeaderStyle>

<ItemStyle VerticalAlign="Top"></ItemStyle>
                                                                                        </asp:TemplateField>
                                                                                        <asp:TemplateField HeaderText="Buy Now Price" HeaderStyle-Width="10%" ItemStyle-VerticalAlign="Top">
                                                                                            <ItemTemplate>
                                                                                                <asp:TextBox ID="BuyNowPrice" runat="server" Text='<%# Bind("BuyNowPrice") %>'></asp:TextBox>
                                                                                                <ajaxToolkit:FilteredTextBoxExtender ID="ftbxBuyNowPrice" runat="server" Enabled="True" FilterType="Numbers,Custom" ValidChars="." TargetControlID="BuyNowPrice">
                                                                                                </ajaxToolkit:FilteredTextBoxExtender>
                                                                                             </ItemTemplate>

<HeaderStyle Width="10%"></HeaderStyle>

<ItemStyle VerticalAlign="Top"></ItemStyle>
                                                                                        </asp:TemplateField>
                                                                                        <asp:TemplateField HeaderText="Min Bid Value" HeaderStyle-Width="10%" ItemStyle-VerticalAlign="Top">
                                                                                            <ItemTemplate>
                                                                                                <asp:TextBox ID="MinBidValue" runat="server" Text='<%# Bind("MinBidValue") %>'></asp:TextBox>
                                                                                                  <ajaxToolkit:FilteredTextBoxExtender ID="ftbxminBidValue" runat="server" Enabled="True" FilterType="Numbers,Custom" ValidChars="." TargetControlID="minBidValue">
                                                                                                  </ajaxToolkit:FilteredTextBoxExtender>
                                                                                            </ItemTemplate>

<HeaderStyle Width="10%"></HeaderStyle>

<ItemStyle VerticalAlign="Top"></ItemStyle>
                                                                                        </asp:TemplateField>
                                                                                    </Columns>
                                                                                    <HeaderStyle BackColor="DarkGray" Font-Bold="True"></HeaderStyle>
                                                                                    <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                                                                </asp:GridView>

                                                                                
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>&nbsp;
                                                                            </td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>

                                                    <asp:SqlDataSource ID="sqldsAssetAuction" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                        SelectCommand="Call GetAssetAuctionSchema()" SelectCommandType="StoredProcedure"> 
                                                    </asp:SqlDataSource>
                                                
                                                </asp:WizardStep>
                                               
                                                
                                                 <asp:WizardStep ID="wizstpAuctionSetup" runat="server" Title="Auction Setup">
                                                    <table cellspacing="0" cellpadding="0" width="100%" border="1" class="TableSearch">
                                                        <tr>
                                                            <td>
                                                                <table cellspacing="1" cellpadding="1" width="100%" border="0">
                                                                    <tbody>
                                                                        <tr>
                                                                            <td class="tableCaptionLabel" colspan="6" align="center">
                                                                                Auction Setup
                                                                            </td>
                                                                        </tr>

                                                                        <tr valign="top">
                                                                            <td colspan="2">
                                                                                <asp:FormView ID="fvAuction" runat="server" DataKeyNames="" Width="100%"  >
                                                                                    <InsertItemTemplate>
                                                                                        <table width="100%">
                                                                                            <tr>
                                                                                                <td width="50%" align="right">
                                                                                                    <asp:Label ID="Label1" runat="server" Text="Region:"></asp:Label>
                                                                                                </td>
                                                                                                <td width="50%">&nbsp;
                                                                                                    <asp:DropDownList ID="RegionID" runat="server" SelectedValue='<%# Bind("RegionID") %>' DataSourceID="sqldsAuctionRegions" DataTextField="Name" DataValueField="ID" AppendDataBoundItems="True" >
                                                                                                        <asp:ListItem Text="" Value=""></asp:ListItem>
                                                                                                    </asp:DropDownList>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td width="50%" align="right">
                                                                                                    <asp:Label ID="Label3" runat="server" Text="Category:"></asp:Label>
                                                                                                </td>
                                                                                                <td width="50%">&nbsp;
                                                                                                    <asp:DropDownList ID="CategoryID" runat="server" SelectedValue='<%# Bind("CategoryID") %>' DataSourceID="sqldsAuctionCategories" DataTextField="Name" DataValueField="ID" AppendDataBoundItems="True" >
                                                                                                        <asp:ListItem Text="" Value=""></asp:ListItem>
                                                                                                    </asp:DropDownList>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td width="50%" align="right">
                                                                                                    <asp:Label ID="Label5" runat="server" Text="Currency:"></asp:Label>
                                                                                                </td>
                                                                                                <td width="50%">&nbsp;
                                                                                                    <asp:DropDownList ID="CurrencyCode" runat="server" SelectedValue='<%# Bind("CurrencyCode") %>' DataSourceID="sqldsAuctionCurrencies" DataTextField="Code" DataValueField="Code" AppendDataBoundItems="True" >
                                                                                                        <asp:ListItem Text="" Value=""></asp:ListItem>
                                                                                                    </asp:DropDownList>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td width="50%" align="right">
                                                                                                    <asp:Label ID="Label7" runat="server" Text="Start Date:"></asp:Label>
                                                                                                </td>
                                                                                                <td width="50%">&nbsp;
                                                                                                    <asp:TextBox ID="StartDate" runat="server" Width="70px" Text='<%# Bind("AuctionStartDate") %>' ></asp:TextBox>
                                                                                                    <ajaxToolkit:CalendarExtender ID="calStartDate" runat="server" TargetControlID="StartDate" Format="MM/dd/yyyy" PopupButtonID="imgStartDateCalendarIcon" />
                                                                                                    <asp:ImageButton runat="Server" ID="imgStartDateCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar"/>&nbsp;&nbsp;
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td width="50%" align="right">
                                                                                                    <asp:Label ID="Label9" runat="server" Text="Duration (Days):"></asp:Label>
                                                                                                </td>
                                                                                                <td width="50%">&nbsp;
                                                                                                    <asp:TextBox ID="Duration" runat="server" Width="70px" Text='<%# Bind("Duration") %>' ></asp:TextBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>

                                                                                    
                                                                                    </InsertItemTemplate>
                                                                                
                                                                                </asp:FormView>
                                                                                
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>&nbsp;
                                                                            </td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>

                                                    <asp:SqlDataSource ID="sqldsAuctionSettings" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                        SelectCommand="Call GetAssetAuctionSchema()" SelectCommandType="StoredProcedure"> 
                                                    </asp:SqlDataSource>
                                                
                                                    <asp:SqlDataSource ID="sqldsAuctionRegions" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                        SelectCommand="Call GetAuctionSiteRegions()" SelectCommandType="StoredProcedure"> 
                                                    </asp:SqlDataSource>

                                                    <asp:SqlDataSource ID="sqldsAuctionCategories" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                        SelectCommand="Call GetAuctionSiteCategories()" SelectCommandType="StoredProcedure"> 
                                                    </asp:SqlDataSource>

                                                    <asp:SqlDataSource ID="sqldsAuctionCurrencies" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                        SelectCommand="Call GetAuctionSiteCurrencies()" SelectCommandType="StoredProcedure"> 
                                                    </asp:SqlDataSource>
                                                </asp:WizardStep>
                                                
                                                
                                                 <asp:WizardStep ID="wizstpAuctionConfirm" runat="server" Title="Auction Listing Confirmation">
                                                    <table cellspacing="0" cellpadding="0" width="100%" border="1" class="TableSearch">
                                                        <tr>
                                                            <td>
                                                                <table cellspacing="1" cellpadding="1" width="100%" border="0">
                                                                    <tbody>
                                                                        <tr>
                                                                            <td class="tableCaptionLabel" colspan="6" align="center">
                                                                                Auction Listing Confirmation
                                                                            </td>
                                                                        </tr>

                                                                        <tr>
                                                                            <td>
                                                                                <div runat="server" id="Div1">
                                                                                    <table cellspacing="0" cellpadding="0" width="100%" border="0" class="captionLabel">
                                                                                        <tr>
                                                                                            <td align="left" class="RptHeader" width="33%" style="height: 20px">
                                                                                                <asp:Label Width="100%" ID="lblPageCountConfirm" runat="server" Text="Page 1 of 1" Font-Size="smaller"></asp:Label>
                                                                                            </td>
                                                                                            <td class="RptHeader" width="34%" style="height: 20px" align="center">
                                                                                                <asp:Label ID="lblReportResultsConfirm" runat="server" Text="Auction Item Confirmation"></asp:Label>
                                                                                            </td>
                                                                                            <td class="RptHeader" width="33%" style="height: 20px" align="right">
                                                                                                <asp:Label ID="lblRecordCountConfirm" runat="server" Text="Record 1 of 1" Font-Size="smaller"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </div>
                                                                            </td>
                                                                        </tr>

                                                                        <tr valign="top">
                                                                            <td colspan="2">

                                                                                <asp:HiddenField ID="hfdTotalRecordsConfirm" runat="server" />
                                                                                <asp:GridView ID="gvAuctionConfirm" runat="server" Width="100%" AllowSorting="False" HeaderStyle-CssClass="Header2"
                                                                                    AllowPaging="True" PageSize="15" EmptyDataText="There are no Assets in the system that match the above criteria."
                                                                                    AutoGenerateColumns="False" CellPadding="4" DataKeyNames="TagNumber" ForeColor="#333333"
                                                                                    GridLines="Vertical">
                                                                                    <AlternatingRowStyle CssClass="gvRowDataAlt"></AlternatingRowStyle>
                                                                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                                                    <PagerSettings Mode="NextPreviousFirstLast" FirstPageImageUrl="Images/resultset_first.png"
                                                                                        FirstPageText="First" LastPageImageUrl="Images/resultset_last.png" LastPageText="Last"
                                                                                        NextPageImageUrl="Images/resultset_next.png" NextPageText="Next" PreviousPageImageUrl="Images/resultset_previous.png"
                                                                                        PreviousPageText="Previous"></PagerSettings>
                                                                                    <RowStyle CssClass="gvRowData"></RowStyle>
                                                                                    <Columns>
                                                                                        <asp:TemplateField HeaderText="Photo" HeaderStyle-Width="10%" ItemStyle-VerticalAlign="Top">
                                                                                            <ItemTemplate>
                                                                                                <asp:Image ID="AssetPhoto" runat="server" ImageUrl='<%# "PhotoDisplay.ashx?TagNumber=" + Eval("TagNumber")  %>' Height="32px" Width="32px"  />
                                                                                            </ItemTemplate>

<HeaderStyle Width="10%"></HeaderStyle>

<ItemStyle VerticalAlign="Top"></ItemStyle>
                                                                                        </asp:TemplateField>
                                                                                        <asp:BoundField DataField="TagNumber" HeaderText="Tag No" 
                                                                                            SortExpression="TagNumber" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                                                                                        </asp:BoundField>
                                                                                        <asp:BoundField DataField="Title" HeaderText="Listing Title" 
                                                                                            SortExpression="Title" HeaderStyle-Width="20%" >
<HeaderStyle Width="20%"></HeaderStyle>
                                                                                        </asp:BoundField>
                                                                                        <asp:BoundField DataField="Subtitle" HeaderText="Listing Subtitle" 
                                                                                            SortExpression="Subtitle" HeaderStyle-Width="40%" >
<HeaderStyle Width="40%"></HeaderStyle>
                                                                                        </asp:BoundField>
                                                                                        <asp:BoundField DataField="BuyNowPrice" HeaderText="Buy Now Price" 
                                                                                            SortExpression="BuyNowPrice" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                                                                                        </asp:BoundField>
                                                                                        <asp:BoundField DataField="MinBidValue" HeaderText="Min Bid Value" 
                                                                                            SortExpression="MinBidValue" HeaderStyle-Width="10%" >

<HeaderStyle Width="10%"></HeaderStyle>
                                                                                        </asp:BoundField>

                                                                                    </Columns>
                                                                                    <HeaderStyle BackColor="DarkGray" Font-Bold="True"></HeaderStyle>
                                                                                    <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                                                                </asp:GridView>


                                                                                
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>&nbsp;
                                                                            </td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>

                                                    <asp:SqlDataSource ID="sqldsAssetAuctionUpdates" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                        InsertCommand="Call InsertAssetAuctionItem(?,?,?,?,?,?,?,?,?,?,?)" InsertCommandType="StoredProcedure"
                                                        SelectCommand="Call GetAssetAuctionSchema()" SelectCommandType="StoredProcedure">
                                                        <InsertParameters>
                                                            <asp:Parameter Name="TagNumber" Type="String" />
                                                            <asp:Parameter Name="RegionID" Type="String" />
                                                            <asp:Parameter Name="CategoryID" Type="String" />
                                                            <asp:Parameter Name="Title" Type="String" />
                                                            <asp:Parameter Name="Subtitle" Type="String" />
                                                            <asp:Parameter Name="ListingType" Type="String" />
                                                            <asp:Parameter Name="CurrencyCode" Type="String" />
                                                            <asp:Parameter Name="BuyNowPrice" Type="Decimal" />
                                                            <asp:Parameter Name="MinBidValue" Type="Decimal" />
                                                            <asp:Parameter Name="AuctionStartDate" Type="DateTime" />
                                                            <asp:Parameter Name="AuctionDuration" Type="Decimal" />
                                                        </InsertParameters>
                                                    </asp:SqlDataSource>
                                                
                                                
                                                </asp:WizardStep>
                                                
                                                
                                            </WizardSteps>
                                        </asp:Wizard>
                                   
                                    
                                    
                                    
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>





















</asp:Content>

