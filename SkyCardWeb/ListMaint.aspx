<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="ListMaint.aspx.vb" Inherits="ListMaint" title="Maintain Lists" %>

<asp:Content ID="Content3" ContentPlaceHolderID="cphError" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
   <asp:ScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server" />

                <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        List Maintenance
                                        <asp:HiddenField ID="hfdTagNameID" runat="server" />
                                    </td>
                                </tr>
                                         <tr valign="top">
                                    <td width="100%" class="tableCaptionLabel" >
                                        <table width="100%" border="0">
                                            <tr>
                                               
                                                <td align="left" width="80%">
                                                    <table border="0">
                                                                                                                
                                                        <tr>
                                                            <td>&nbsp;
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label1" runat="server" Text="Select a List to Maintain:"></asp:Label>
                                                                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="sqldsLists" AutoPostBack="true" DataTextField="TagDesc" DataValueField="TagNameID">
                                                                </asp:DropDownList>
                                                            </td>
                                                        </tr>
                                                    </table> 
                                                </td>
                                            </tr>



                                        </table>
                                    </td>
                                </tr>          
                                <tr valign="top">
                                    <td colspan="2">
                                    
                                    
                                        <asp:GridView ID="gvLookupTable" runat="server" AllowPaging="True" RowStyle-VerticalAlign="Top" 
                                            AllowSorting="True" Width="100%" PageSize="20" DataSourceID="sqldsLookupTableData" DataKeyNames="TagListID"
                                            AutoGenerateColumns="False" ShowFooter="True">
                                            <Columns>
                                               <asp:TemplateField HeaderText="Actions">
                                                    <ItemTemplate>
                                                        &nbsp;<asp:ImageButton ID="btnEditItem" runat="server" CommandName="Edit" Text="Edit List Item" ImageUrl="~/Images/contact_grey_edit.png" ToolTip="Edit List Item"/>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:ImageButton ID="btnUpdateItem" runat="server" CommandName="Update" Text="Update List Item" ImageUrl="~/Images/badge_save.png" ToolTip="Update List Item"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelUpdate" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/Images/badge_cancel.png" ToolTip="Cancel Update"/>
                                                    </EditItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:ImageButton ID="btnAddItem" runat="server" CommandName="Insert" Text="Insert New List Item" ImageUrl="~/Images/badge_save.png" ToolTip="Insert New List Item"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelAdd" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/Images/badge_cancel.png" ToolTip="Cancel Insert"/>
                                                    </FooterTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <FooterStyle VerticalAlign="Bottom" />
                                                    <ItemStyle VerticalAlign="Bottom" />
                                                </asp:TemplateField>
                                                                                            
                                                
                                                <asp:TemplateField HeaderText="List Item" SortExpression="TagDesc">
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="TagDesc" runat="server" Text='<%# Bind("TagListDesc") %>'></asp:TextBox>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="TagDesc" runat="server" Text='<%# Bind("TagListDesc") %>'></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2em" runat="server" Text='<%# Bind("TagListDesc") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="20%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                 
                                                
                                                                                             
                                                
                                                                                                
                                                
                                            </Columns>
                                            <FooterStyle BackColor="#EEEEEE" />
                                            <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                            <EmptyDataTemplate>
                                                No Data Found for the Given Lookup table
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
                    SelectCommand="Call GetListItemsByTagNameID(?)" SelectCommandType="StoredProcedure" 
                    InsertCommand="Call InsertTagListItem(?,?)" InsertCommandType="StoredProcedure"  
                    UpdateCommand="Call UpdateTagListItem(?,?)" UpdateCommandType="StoredProcedure">
                    <UpdateParameters>
                         <asp:Parameter Name="TagListDesc" Type="String" />
                         <asp:Parameter Name="TagListID" Type="Int32" />
                    </UpdateParameters>
                    <InsertParameters>
                         <asp:Parameter Name="TagListDesc" Type="String" />
                         <asp:Parameter Name="TagNameID" Type="Int32" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:Parameter Name="TagNameID" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                
                <asp:SqlDataSource ID="sqldsLists" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="GetCaseTypes" SelectCommandType="StoredProcedure"> 
                </asp:SqlDataSource>

              
</asp:Content>

