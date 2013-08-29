<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="LocationMaint.aspx.vb" Inherits="LocationMaint" title="Maintain Locations" %>

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
                                        Location Maintenance
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="2">
                                    
                                    
                                        <asp:GridView ID="gvLookupTable" runat="server" AllowPaging="True" RowStyle-VerticalAlign="Top" 
                                            AllowSorting="True" Width="100%" PageSize="20" DataSourceID="sqldsLookupTableData" DataKeyNames="LocNameID"
                                            AutoGenerateColumns="False" ShowFooter="True">
                                            <Columns>
                                               <asp:TemplateField HeaderText="Actions">
                                                    <ItemTemplate>
                                                        &nbsp;<asp:ImageButton ID="btnEditItem" runat="server" CommandName="Edit" Text="Edit User" ImageUrl="~/Images/contact_grey_edit.png" ToolTip="Edit User"/>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:ImageButton ID="btnUpdateItem" runat="server" CommandName="Update" Text="Update User" ImageUrl="~/Images/badge_save.png" ToolTip="Update User"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelUpdate" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/Images/badge_cancel.png" ToolTip="Cancel Update"/>
                                                    </EditItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:ImageButton ID="btnAddItem" runat="server" CommandName="Insert" Text="Insert New User" ImageUrl="~/Images/badge_save.png" ToolTip="Insert New User"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelAdd" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/Images/badge_cancel.png" ToolTip="Cancel Insert"/>
                                                    </FooterTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <FooterStyle VerticalAlign="Bottom" />
                                                    <ItemStyle VerticalAlign="Bottom" />
                                                </asp:TemplateField>
                                                                                            
                                                
                                                <asp:TemplateField HeaderText="Location Name" SortExpression="LocDesc">
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="LocDesc" runat="server" Text='<%# Bind("LocDesc") %>'></asp:TextBox>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="LocDesc" runat="server" Text='<%# Bind("LocDesc") %>'></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2em" runat="server" Text='<%# Bind("LocDesc") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="20%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                 
                                                
                                                <asp:TemplateField HeaderText="Location Parent" SortExpression="Parent">
                                                    <FooterTemplate>
                                                        <asp:DropDownList ID="Parent" runat="server" DataSourceID="sqldsRootLocations" DataValueField="LocNameID" DataTextField="LocDesc" AppendDataBoundItems="true">
                                                            <asp:ListItem Text="None" Value="0" />
                                                        </asp:DropDownList>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="Parent" runat="server" DataSourceID="sqldsRootLocations" DataValueField="LocNameID" DataTextField="LocDesc" AppendDataBoundItems="true" SelectedValue='<%# Bind("Parent") %>' >
                                                            <asp:ListItem Text="None" Value="0" />
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <%--<asp:Label ID="Label3" runat="server" Text='<%# Bind("Parent") %>'></asp:Label>--%>
                                                        <asp:DropDownList ID="Parent111" runat="server" DataSourceID="sqldsRootLocations" DataValueField="LocNameID" DataTextField="LocDesc" AppendDataBoundItems="true" SelectedValue='<%# Bind("Parent") %>' Enabled="false">
                                                            <asp:ListItem Text="None" Value="0" />
                                                        </asp:DropDownList>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" />
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
                    SelectCommand="Call GetAllLocations()" SelectCommandType="StoredProcedure" 
                    InsertCommand="Call InsertLocationName(?,?)" InsertCommandType="StoredProcedure"  
                    UpdateCommand="Call UpdateLocationName(?,?,?)" UpdateCommandType="StoredProcedure">
                    <UpdateParameters>
                         <asp:Parameter Name="P1" Type="Int32" />
                         <asp:Parameter Name="P2" Type="String" />
                         <asp:Parameter Name="P3" Type="Int32" />
                    </UpdateParameters>
                    <InsertParameters>
                         <asp:Parameter Name="LocDesc" Type="String" />
                         <asp:Parameter Name="Parent" Type="Int32" />
                    </InsertParameters>
                </asp:SqlDataSource>
                
                <asp:SqlDataSource ID="sqldsTranHistory" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    InsertCommand="Call InsertTransHistory(?,?,?)" InsertCommandType="StoredProcedure"  >
                    <InsertParameters>
                         <asp:Parameter Name="Description" Type="String" />
                         <asp:Parameter Name="TheUser" Type="String" />
                         <asp:Parameter Name="TheTag" Type="String" />
                    </InsertParameters>
                </asp:SqlDataSource>
                
               <asp:SqlDataSource ID="sqldsRootLocations" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetAllRootLocations()" SelectCommandType="StoredProcedure">
                </asp:SqlDataSource>
</asp:Content>

