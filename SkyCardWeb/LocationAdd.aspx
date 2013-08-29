<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="LocationAdd.aspx.vb" Inherits="LocationAdd" title="Add New Location" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">

                <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Add New Location
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="2">
                                    
                                    
                                        <asp:GridView ID="gvLookupTable" runat="server" AllowPaging="True" RowStyle-VerticalAlign="Top"
                                            AllowSorting="False" Width="100%" PageSize="20" DataKeyNames="LocationID" 
                                            AutoGenerateColumns="False" EditRowStyle-HorizontalAlign="Center" >
                                            <Columns>
                                               <asp:TemplateField HeaderText="Actions">
                                                   <ItemTemplate>
                                                        <asp:ImageButton ID="btnInsertItem" runat="server" CommandName="Insert" Text="Insert New Location" ImageUrl="~/Images/badge_save.png" ToolTip="Insert New Location"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelAdd" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/Images/badge_cancel.png" ToolTip="Cancel Insert"/>
                                                   </ItemTemplate>
                                                   <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                                   <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom" /> 
                                                </asp:TemplateField>
                                               <asp:TemplateField HeaderText="Location ID" SortExpression="LocationID">
                                                   <ItemTemplate>
                                                        <asp:TextBox ID="LocationID" runat="server" Text='<%# Bind("LocationID") %>' Width="90%"></asp:TextBox>
                                                   </ItemTemplate>
                                                    <HeaderStyle Width="20%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Location Desc" SortExpression="LocDesc">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="LocDesc" runat="server" Text='<%# Bind("LocDesc") %>' Width="90%"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="35%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Location Barcode" SortExpression="LocBarcode">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="LocBarcode" runat="server" Text='<%# Bind("LocBarcode") %>' Width="90%"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="20%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Active" SortExpression="IsActive">
                                                    <ItemTemplate>
                                                        <asp:DropDownList ID="IsActive" runat="server" Enabled="False"  >
                                                            <asp:ListItem Text="True" Value="True" Selected="True"></asp:ListItem>
                                                            <asp:ListItem Text="False" Value="False"></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                            </Columns>
                                            <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                            <EmptyDataTemplate>
                                                The Location Was Not Found
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
                    SelectCommand="Call GetLocation(?)" SelectCommandType="StoredProcedure" 
                    InsertCommand="Call Insert_MasterLocation(?,?,?)" InsertCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="LocationID" Type="String" DefaultValue="NEVERFOUND" />
                    </SelectParameters>
                    <InsertParameters>
                         <asp:Parameter Name="LocationID" Type="String" />
                         <asp:Parameter Name="LocDesc" Type="String" />
                         <asp:Parameter Name="LocBarcode" Type="String" />
                    </InsertParameters>
                </asp:SqlDataSource>
                

</asp:Content>

