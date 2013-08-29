<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="UserStoreMaint.aspx.vb" Inherits="UserStoreMaint" title="Maintain User Stores" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content3" ContentPlaceHolderID="cphError" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server" />


                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Store Maintenance <asp:Label ID="lblChargeNumber" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="2">
                                    
                                      <asp:GridView ID="gvLookupTable" runat="server" AllowPaging="True" RowStyle-VerticalAlign="Top"
                                            AllowSorting="True" Width="100%" PageSize="20" DataSourceID="sqldsLookupTableData" DataKeyNames="id"
                                            AutoGenerateColumns="False" ShowFooter="True">
                                            <Columns>
                                               <asp:TemplateField HeaderText="Actions">
                                                    <ItemTemplate>
                                                        &nbsp;<asp:ImageButton ID="btnEditItem" runat="server" CommandName="Edit" Text="Edit Store" ImageUrl="~/Images/contact_grey_edit.png" ToolTip="Edit Store"/>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:ImageButton ID="btnUpdateItem" runat="server" CommandName="Update" Text="Update Store" ImageUrl="~/Images/badge_save.png" ToolTip="Update Store"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelUpdate" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/Images/badge_cancel.png" ToolTip="Cancel Update"/>
                                                    </EditItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:ImageButton ID="btnAddItem" runat="server" CommandName="Insert" Text="Insert New Store" ImageUrl="~/Images/badge_save.png" ToolTip="Insert New Store"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelAdd" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/Images/badge_cancel.png" ToolTip="Cancel Insert"/>
                                                    </FooterTemplate>
                                                    <HeaderStyle Width="5%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>

                                                <asp:TemplateField HeaderText="User" SortExpression="userid">
                                                    <FooterTemplate>
                                                        <asp:DropDownList ID="ddlUsers" runat="server" DataSourceID="sqldsUsers" DataValueField="id" DataTextField="username" SelectedValue='<%# Bind("userid")%>'></asp:DropDownList>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="ddlUsersedit" runat="server" DataSourceID="sqldsUsers" DataValueField="id" DataTextField="username" SelectedValue='<%# Bind("userid")%>'></asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:DropDownList ID="ddlUserslabel" runat="server" DataSourceID="sqldsUsers" DataValueField="id" DataTextField="username" SelectedValue='<%# Bind("userid")%>' Enabled="false"></asp:DropDownList>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="5%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                               
                                                <asp:TemplateField HeaderText="Store" SortExpression="storeid">
                                                    <FooterTemplate>
                                                        <asp:DropDownList ID="ddlStores" runat="server" DataSourceID="sqldsStores" DataValueField="storeid" DataTextField="storename" SelectedValue='<%# Bind("storeid")%>'></asp:DropDownList>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="ddlStoresedit" runat="server" DataSourceID="sqldsStores" DataValueField="storeid" DataTextField="storename" SelectedValue='<%# Bind("storeid")%>'></asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:DropDownList ID="ddlStoreslabel" runat="server" DataSourceID="sqldsStores" DataValueField="storeid" DataTextField="storename" SelectedValue='<%# Bind("storeid")%>' Enabled="false"></asp:DropDownList>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="5%" />
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
                    SelectCommand="GetAllUserStores" SelectCommandType="StoredProcedure" 
                    InsertCommand="InsertUserStore" InsertCommandType="StoredProcedure"  
                    UpdateCommand="UpdateUserStore" UpdateCommandType="StoredProcedure">
                     <InsertParameters>
                         <asp:Parameter Name="userid" Type="Int32" />
                         <asp:Parameter Name="storeid" Type="Int32" />
                    </InsertParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="sqldsUsers" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                    SelectCommand="GetAllAppUsers" SelectCommandType="StoredProcedure">
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="sqldsStores" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                    SelectCommand="GetAllStores" SelectCommandType="StoredProcedure">
                </asp:SqlDataSource>
</asp:Content>


