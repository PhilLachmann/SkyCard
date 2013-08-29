<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="ProductEdit.aspx.vb" Inherits="ProductEdit" title="Edit Product" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">

                <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Edit Product
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="2">
                                    
                                    
                                        <asp:GridView ID="gvLookupTable" runat="server" AllowPaging="True" RowStyle-VerticalAlign="Top"
                                            AllowSorting="False" Width="100%" PageSize="20" DataSourceID="sqldsLookupTableData" DataKeyNames="ItemID"
                                            AutoGenerateColumns="False" EditRowStyle-HorizontalAlign="Center" EditRowStyle-VerticalAlign="Bottom" >
                                            <Columns>
                                               <asp:TemplateField HeaderText="Actions">
                                                    <EditItemTemplate>
                                                        <asp:ImageButton ID="btnUpdateItem" runat="server" CommandName="Update" Text="Update Product" ImageUrl="~/Images/badge_save.png" ToolTip="Update Product"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelUpdate" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/Images/badge_cancel.png" ToolTip="Cancel Update"/>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                               <asp:TemplateField HeaderText="Item ID" SortExpression="ItemID">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="ItemID" runat="server" Text='<%# Bind("ItemID") %>' Width="90%" Enabled="false"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Size" SortExpression="UOM">
                                                    <EditItemTemplate>
                                                         <asp:SqlDataSource ID="sqldsUOMLookup" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                            ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                            SelectCommand="Call GetUnitsOfMeasure()" SelectCommandType="StoredProcedure">
                                                        </asp:SqlDataSource>
                                                        <asp:DropDownList ID="UOM" runat="server" DataSourceID="sqldsUOMLookup"
                                                            DataTextField="UOM" DataValueField="UOM" SelectedValue='<%# Bind("UOM") %>' >
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Item Desc" SortExpression="ItemDesc">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="ItemDesc" runat="server" Text='<%# Bind("ItemDesc") %>' Width="90%"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="20%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Item Barcode" SortExpression="Barcode">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="Barcode" runat="server" Text='<%# Bind("Barcode") %>' Width="90%"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Price Category" SortExpression="PriceCategory">
                                                    <EditItemTemplate>
                                                         <asp:SqlDataSource ID="sqldsCategoryLookup" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                            ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                            SelectCommand="Call GetCategories()" SelectCommandType="StoredProcedure">
                                                        </asp:SqlDataSource>
                                                        <asp:DropDownList ID="PriceCategory" runat="server" DataSourceID="sqldsCategoryLookup"
                                                            DataTextField="PriceCategory" DataValueField="PriceCategory" SelectedValue='<%# Bind("PriceCategory") %>' >
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="List Price" SortExpression="ListPrice">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="ListPrice" runat="server" Text='<%# Bind("ListPrice") %>' Width="90%"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Inv Min" SortExpression="InvMin">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="InvMin" runat="server" Text='<%# Bind("InvMin") %>' Width="90%"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Inv Max" SortExpression="InvMax">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="InvMax" runat="server" Text='<%# Bind("InvMax") %>' Width="90%"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Active" SortExpression="IsActive">
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="IsActive" runat="server" SelectedValue='<%# Bind("IsActive") %>' onchange="checkInactivating(this,'Product');"   >
                                                            <asp:ListItem Text="True" Value="True" Selected="True"></asp:ListItem>
                                                            <asp:ListItem Text="False" Value="False"></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                            </Columns>
                                            <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                            <EmptyDataTemplate>
                                                The Product Was Not Found
                                            </EmptyDataTemplate>
                                            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                                            <HeaderStyle BackColor="DarkGray" Font-Bold="True" />
                                            <AlternatingRowStyle></AlternatingRowStyle>
                                            <RowStyle></RowStyle>
                                        </asp:GridView>
                                    
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                
                 <asp:SqlDataSource ID="sqldsLookupTableData" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetProduct(?)" SelectCommandType="StoredProcedure" 
                    UpdateCommand="Call UpdateProduct(?,?,?,?,?,?,?,?,?,?)" UpdateCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="ItemID" Type="String" DefaultValue="" />
                    </SelectParameters>
                    <UpdateParameters>
                         <asp:Parameter Name="ItemIDKey" Type="String" />
                         <asp:Parameter Name="ItemDesc" Type="String" />
                         <asp:Parameter Name="Barcode" Type="String" />
                         <asp:Parameter Name="ListPrice" Type="Decimal" />
                         <asp:Parameter Name="PriceCategory" Type="String" />
                         <asp:Parameter Name="InvMin" Type="Int32" />
                         <asp:Parameter Name="InvMax" Type="Int32" />
                         <asp:Parameter Name="UOM" Type="String" />
                         <asp:Parameter Name="IsActive" Type="String" />
                         <asp:Parameter Name="ItemID" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                

</asp:Content>

