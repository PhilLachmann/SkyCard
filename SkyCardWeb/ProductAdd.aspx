<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="ProductAdd.aspx.vb" Inherits="ProductAdd" title="Add New Product" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">

                <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Add New Product
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="2">
                                    
                                    
                                        <asp:GridView ID="gvLookupTable" runat="server" AllowPaging="True" RowStyle-VerticalAlign="Top"
                                            AllowSorting="False" Width="100%" PageSize="20" DataKeyNames="ItemID"
                                            AutoGenerateColumns="False" EditRowStyle-HorizontalAlign="Center" >
                                            <Columns>
                                               <asp:TemplateField HeaderText="Actions">
                                                    <ItemTemplate>
                                                        <asp:ImageButton ID="btnInsertItem" runat="server" CommandName="Insert" Text="Insert New Product" ImageUrl="~/Images/badge_save.png" ToolTip="Insert New Job"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelAdd" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/Images/badge_cancel.png" ToolTip="Cancel Insert"/>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom" /> 
                                                </asp:TemplateField>
                                               <asp:TemplateField HeaderText="Item ID" SortExpression="ItemID">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="ItemID" runat="server" Text='<%# Bind("ItemID") %>' Width="90%" MaxLength="200" ></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Size" SortExpression="UOM">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="UOM" runat="server" Text='<%# Bind("UOM") %>' Width="90%" MaxLength="50" ></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Item Desc" SortExpression="ItemDesc">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="ItemDesc" runat="server" Text='<%# Bind("ItemDesc") %>' Width="90%" MaxLength="200"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="20%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Price Category" SortExpression="PriceCategory">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="PriceCategory" runat="server" Text='<%# Bind("PriceCategory") %>' Width="90%" MaxLength="200" ></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="List Price" SortExpression="ListPrice">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="ListPrice" runat="server" Text='0.00' Width="90%"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Inv Min" SortExpression="InvMin">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="InvMin" runat="server" Text='0' Width="90%"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Inv Max" SortExpression="InvMax">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="InvMax" runat="server" Text='0' Width="90%"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Active" SortExpression="IsActive">
                                                    <ItemTemplate>
                                                        <asp:DropDownList ID="IsActive" runat="server"   >
                                                            <asp:ListItem Text="True" Value="True" Selected="True"></asp:ListItem>
                                                            <asp:ListItem Text="False" Value="False"></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </ItemTemplate>
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
                    InsertCommand="Call InsertProduct(?,?,?,?,?,?,?,?)" InsertCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="ItemID" Type="String" DefaultValue="NEVERFOUND" />
                    </SelectParameters>
                    <InsertParameters>
                         <asp:Parameter Name="ItemID" Type="String" />
                         <asp:Parameter Name="ItemDesc" Type="String" />
                         <asp:Parameter Name="ListPrice" Type="Decimal" />
                         <asp:Parameter Name="PriceCategory" Type="String" />
                         <asp:Parameter Name="InvMin" Type="Int32" />
                         <asp:Parameter Name="InvMax" Type="Int32" />
                         <asp:Parameter Name="UOM" Type="String" />
                         <asp:Parameter Name="IsActive" Type="String" />
                    </InsertParameters>
                </asp:SqlDataSource>
                

</asp:Content>

