<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="SearchInventory.aspx.vb" Inherits="SearchInventory" title="Inventory Search" %>


<asp:Content ID="Content5" ContentPlaceHolderID="cphBody" Runat="Server">
    <table cellspacing="0" cellpadding="0" width="100%" border="0" class="TableSearch">
        <tbody>
            <tr>
                <td>
                    <table cellspacing="1" cellpadding="1" width="100%" border="1">
                        <tbody>
                            <tr>
                                <td class="tableCaptionLabel" colspan="6" align="center">
                                    Inventory Search
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
                                    <asp:Label ID="Label2" runat="server" Text="Item ID"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="txtItemID" runat="server" CssClass="dControl" Width="50%" MaxLength="25"></asp:TextBox>
                                    <asp:CheckBox ID="cbxItemID" runat="server" Text="Use Contains" Visible="False" CssClass="dControl" />
                                </td>
                                <td align="left">
                                    <asp:Label ID="Label4" runat="server" Text="Item Description"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="txtItemDesc" runat="server" CssClass="dControl" Width="50%" MaxLength="100"></asp:TextBox>
                                    <asp:CheckBox ID="cbxItemDesc" runat="server" Text="Use Contains" Visible="False" CssClass="dControl" />
                                </td>
                            </tr>
                            <tr valign="top">
                                <td align="left">
                                    <asp:Label ID="Label3" runat="server" Text="Item Barcode"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="txtBarcode" runat="server" CssClass="dControl" Width="50%" MaxLength="100"></asp:TextBox>
                                    <asp:CheckBox ID="cbxBarcode" runat="server" Text="Use Contains" Visible="False" CssClass="dControl" />
                                </td>
                                <td align="left">
                                    <asp:Label ID="Label10" runat="server" Text="Job ID"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="txtJobID" runat="server" CssClass="dControl" Width="50%" MaxLength="100"></asp:TextBox>
                                    <asp:CheckBox ID="cbxJobID" runat="server" Text="Use Contains" Visible="False" CssClass="dControl" />
                                </td>
                            </tr>


                            <tr valign="top">
                                <td align="left">
                                    <asp:Label ID="Label1" runat="server" Text="Location ID"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="txtLocationID" runat="server" CssClass="dControl" Width="50%" MaxLength="20"></asp:TextBox>
                                    <asp:CheckBox ID="cbxLocationID" runat="server" Text="Use Contains" Visible="False" CssClass="dControl" />
                                </td>
                                <td align="left">
                                    <asp:Label ID="Label5" runat="server" Text="Pricing Category"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:SqlDataSource ID="sqldsCategoryLookup" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                        SelectCommand="Call GetAllTags()" SelectCommandType="StoredProcedure">
                                    </asp:SqlDataSource>
                                    <asp:DropDownList ID="PriceCategory" runat="server" 
                                        DataTextField="TagDesc" DataValueField="TagDesc" AppendDataBoundItems="True" >
                                        <asp:ListItem Text="" Value="" Selected="True" ></asp:ListItem>
                                    </asp:DropDownList>&nbsp;&nbsp;
                                </td>
                            </tr>
                            <tr valign="top">
                                <td align="left">
                                    <asp:Label ID="Label6" runat="server" Text="Size"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:SqlDataSource ID="sqldsSizeLookup" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                        SelectCommand="Call GetAllTags()" SelectCommandType="StoredProcedure">
                                    </asp:SqlDataSource>
                                    
                                    <asp:TextBox ID="txtSize" runat="server" CssClass="dControl" Width="50%" 
                                        MaxLength="20"></asp:TextBox>
                                </td>
                                <td align="left">&nbsp;
                                </td>
                                <td align="left">&nbsp;
                                </td>
                            </tr>


                        </tbody>
                    </table>
                    <table cellspacing="1" cellpadding="1" width="100%" border="1">
                        <tbody>
                            <tr>
                                <td align="center" style="width: 33%;">
                                    <asp:Button ID="btnSearch" runat="server" Text="Search / List Inventory"></asp:Button>
                                </td>
                                <td align="center" style="width: 33%">
                                    <asp:Button ID="btnClearCriteria" runat="server" Text="Clear Criteria/Results"></asp:Button>
                                </td>
                                <td align="center" style="width: 34%">
                                    <asp:Button ID="btnReport" runat="server" Text="Send To Report"></asp:Button>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <br />
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
                                    <asp:GridView ID="gvSearchRecs" runat="server" Width="100%" AllowSorting="True" HeaderStyle-CssClass="Header2"
                                        AllowPaging="True" PageSize="15" EmptyDataText="There are no Inventory Items in the system that match the above criteria."
                                        AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ItemID,LocationID,JobID" ForeColor="#333333"
                                        GridLines="Vertical">
                                        <AlternatingRowStyle CssClass="gvRowDataAlt"></AlternatingRowStyle>
                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <PagerSettings Mode="NextPreviousFirstLast" FirstPageImageUrl="Images/resultset_first.png"
                                            FirstPageText="First" LastPageImageUrl="Images/resultset_last.png" LastPageText="Last"
                                            NextPageImageUrl="Images/resultset_next.png" NextPageText="Next" PreviousPageImageUrl="Images/resultset_previous.png"
                                            PreviousPageText="Previous"></PagerSettings>
                                        <RowStyle CssClass="gvRowData"></RowStyle>
                                        <Columns>
                                            <asp:BoundField DataField="ItemID" HeaderText="Item ID" 
                                                SortExpression="ItemID" />
                                            <asp:BoundField DataField="pct" HeaderText="Pct Match" SortExpression="pct" Visible="False" />
                                            <asp:BoundField DataField="UOM" HeaderText="Size" SortExpression="UOM" />
                                            <asp:BoundField DataField="ItemDesc" HeaderText="Item Desc" SortExpression="ItemDesc" ItemStyle-HorizontalAlign="Left" />
                                            <asp:BoundField DataField="PriceCategory" HeaderText="Category" SortExpression="PriceCategory" ItemStyle-HorizontalAlign="Left" />
                                            <asp:BoundField DataField="JobDesc" HeaderText="Job Desc" SortExpression="JobDesc" ItemStyle-HorizontalAlign="Left" />
                                            <asp:BoundField DataField="LocDesc" HeaderText="Location Desc" SortExpression="LocDesc" />
                                            <asp:BoundField DataField="QuantityOnHand" HeaderText="Quantity On Hand" SortExpression="QuantityOnHand" />
                                            <asp:BoundField DataField="LastModified" HeaderText="Last Activity" SortExpression="LastModified" />
                                            <asp:TemplateField HeaderText="Actions">
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="btnAddViewComment" runat="server" CommandName="Select" Text="Add / View Comments" ImageUrl="~/Images/comments.png" ToolTip="Add / View Comments"/>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle CssClass="Header2" Font-Bold="True"></HeaderStyle>
                                        <PagerStyle BackColor="DarkGray" ForeColor="White" HorizontalAlign="Center" />
                                    </asp:GridView>
                                    <asp:SqlDataSource ID="sqldsInventorySearch" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                        SelectCommand="Call Get_Inventory_Records(?,?,?,?,?,?,?)" SelectCommandType="StoredProcedure">
                                        <SelectParameters>
                                            <asp:Parameter Name="t_ItemID" Type="String" DefaultValue="" />
                                            <asp:Parameter Name="t_JobID" Type="String" DefaultValue="" />
                                            <asp:Parameter Name="t_LocationID" Type="String" DefaultValue="" />
                                            <asp:Parameter Name="t_Barcode" Type="String" DefaultValue="" />
                                            <asp:Parameter Name="t_ItemDesc" Type="String" DefaultValue="" />
                                            <asp:Parameter Name="t_Category" Type="String" DefaultValue="" />
                                            <asp:Parameter Name="t_Size" Type="String" DefaultValue="" />
                                        </SelectParameters>
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







