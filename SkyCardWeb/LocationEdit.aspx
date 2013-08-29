<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="LocationEdit.aspx.vb" Inherits="LocationEdit" title="Edit Location" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">

                <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Edit Location
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="2">
                                    
                                    
                                        <asp:GridView ID="gvLookupTable" runat="server" AllowPaging="True" RowStyle-VerticalAlign="Top"
                                            AllowSorting="False" Width="100%" PageSize="20" DataSourceID="sqldsLookupTableData" DataKeyNames="LocationID"
                                            AutoGenerateColumns="False" EditRowStyle-HorizontalAlign="Center" EditRowStyle-VerticalAlign="Bottom" >
                                            <Columns>
                                               <asp:TemplateField HeaderText="Actions">
                                                    <EditItemTemplate>
                                                        <asp:ImageButton ID="btnUpdateItem" runat="server" CommandName="Update" Text="Update Location" ImageUrl="~/Images/badge_save.png" ToolTip="Update Location"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelUpdate" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/Images/badge_cancel.png" ToolTip="Cancel Update"/>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                               <asp:TemplateField HeaderText="Location ID" SortExpression="LocationID">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="LocationID" runat="server" Text='<%# Bind("LocationID") %>' Width="90%" Enabled="false"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="20%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Location Desc" SortExpression="LocDesc">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="LocDesc" runat="server" Text='<%# Bind("LocDesc") %>' Width="90%"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="35%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Location Barcode" SortExpression="LocBarcode">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="LocBarcode" runat="server" Text='<%# Bind("LocBarcode") %>' Width="90%"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="20%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Active" SortExpression="IsActive">
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="IsActive" runat="server" SelectedValue='<%# Bind("IsActive") %>' onchange="checkInactivating(this,'Location');" >
                                                            <asp:ListItem Text="True" Value="True" Selected="True"></asp:ListItem>
                                                            <asp:ListItem Text="False" Value="False"></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                            </Columns>
                                            <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                            <EmptyDataTemplate>
                                                The Job Was Not Found
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
                    UpdateCommand="Call UpdateLocation(?,?,?,?,?)" UpdateCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="LocationID" Type="String" DefaultValue="" />
                    </SelectParameters>
                    <UpdateParameters>
                         <asp:Parameter Name="LocationIDKey" Type="String" />
                         <asp:Parameter Name="LocDesc" Type="String" />
                         <asp:Parameter Name="LocBarcode" Type="String" />
                         <asp:Parameter Name="IsActive" Type="String" />
                         <asp:Parameter Name="LocationID" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                

</asp:Content>

