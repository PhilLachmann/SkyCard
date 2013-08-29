<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="ContactTypeMaint.aspx.vb" Inherits="ContactTypeMaint" title="Maintain Contact Types" %>

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
                                        Contact Type Maintenance <asp:Label ID="lblContactNumber" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="2">
                                    
                                    
                                        <asp:GridView ID="gvLookupTable" runat="server" AllowPaging="True" RowStyle-VerticalAlign="Top"
                                            AllowSorting="True" Width="100%" PageSize="20" DataSourceID="sqldsLookupTableData" DataKeyNames="ID"
                                            AutoGenerateColumns="False" ShowFooter="True">
                                            <Columns>
                                               <asp:TemplateField HeaderText="Actions">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="btnEditItem" runat="server" Text="Edit" CommandName="Edit"></asp:LinkButton> 
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:LinkButton ID="btnUpdateItem" runat="server" Text="Update" CommandName="Update"></asp:LinkButton> 
                                                        <asp:LinkButton ID="btnCancelUpdate" runat="server" Text="Cancel" CommandName="Cancel"></asp:LinkButton> 
                                                    </EditItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:LinkButton ID="btnAddItem" runat="server" Text="Insert" CommandName="Insert"></asp:LinkButton> 
                                                        <asp:LinkButton ID="btnCancelAdd" runat="server" Text="Cancel" CommandName="Cancel"></asp:LinkButton> 
                                                    </FooterTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="ContactType" SortExpression="ContactType">
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="ContactType" runat="server" Width="95%" Text='<%# Bind("ContactType") %>'></asp:TextBox>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("ContactType") %>'></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("ContactType") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="50%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Delete" SortExpression="Deleted">
                                                    <FooterTemplate>
                                                        <asp:DropDownList ID="Deleted" runat="server" SelectedValue='<%# Bind("Deleted") %>'  >
                                                            <asp:ListItem Text="True" Value="True"></asp:ListItem>
                                                            <asp:ListItem Text="False" Value="False" Selected="True"></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="Deleted" runat="server" SelectedValue='<%# Bind("Deleted") %>'  >
                                                            <asp:ListItem Text="True" Value="True" Selected="True"></asp:ListItem>
                                                            <asp:ListItem Text="False" Value="False"></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Deleted") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                            </Columns>
                                            <FooterStyle BackColor="Tan" />
                                            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                            <EmptyDataTemplate>
                                                No Data Found for the Given Lookup table
                                            </EmptyDataTemplate>
                                            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                                            <HeaderStyle BackColor="Tan" Font-Bold="True" />
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
                    SelectCommand="GetAllContactTypes" SelectCommandType="StoredProcedure" 
                    InsertCommand="InsertContactTypes" InsertCommandType="StoredProcedure"  
                    UpdateCommand="UpdateContactTypes" UpdateCommandType="StoredProcedure">
                     <InsertParameters>
                         <asp:Parameter Name="ContactType" Type="String" />
                         
                     </InsertParameters>
                </asp:SqlDataSource>


</asp:Content>


