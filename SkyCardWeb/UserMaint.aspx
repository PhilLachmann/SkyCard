<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="UserMaint.aspx.vb" Inherits="UserMaint" title="User Maintenance" %>

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
                                        User Store Maintenance
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
                                               <asp:TemplateField HeaderText="UserID" SortExpression="login">
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="UserName" runat="server" Text='<%# Bind("login") %>'></asp:TextBox>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:Label ID="UserName" runat="server" Text='<%# Bind("login") %>'></asp:Label>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1x" runat="server" Text='<%# Bind("login") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="15%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="User Name" SortExpression="username">
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="UserDesc" runat="server" Text='<%# Bind("username") %>'></asp:TextBox>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="UserDesc" runat="server" Text='<%# Bind("username") %>'></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("username") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="20%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                
                                                                                                
                                                <asp:TemplateField HeaderText="Password" SortExpression="password">
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="Password" runat="server" Text='<%# Bind("password") %>' TextMode="Password"></asp:TextBox>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="Password" runat="server" Text='<%# Bind("password") %>' TextMode="Password"></asp:TextBox>
                                                        <asp:TextBox ID="OriginalPassword" runat="server" Text='<%# Bind("password") %>' Visible="False"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label44" runat="server" Text="********"></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="15%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Confirm Password" SortExpression="password">
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="ConfirmPassword" runat="server" Text='<%# Bind("password") %>' TextMode="Password"></asp:TextBox>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="ConfirmPassword" runat="server" Text='<%# Bind("password") %>' TextMode="Password"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label4" runat="server" Text="********"></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="15%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="UserRole" SortExpression="Role">
                                                    <FooterTemplate>
                                                        <asp:DropDownList ID="UserRole" runat="server" SelectedValue='<%# Bind("Role") %>' OnLoad="UserRole_Load"  >
                                                            <asp:ListItem Text="admin" Value="admin"></asp:ListItem>
                                                            <asp:ListItem Text="user" Value="user" Selected="True"></asp:ListItem>
                                                            <asp:ListItem Text="readonly" Value="readonly" ></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="UserRole" runat="server" SelectedValue='<%# Bind("Role") %>' OnLoad="UserRole_Load" >
                                                            <asp:ListItem Text="admin" Value="admin" Selected="True"></asp:ListItem>
                                                            <asp:ListItem Text="user" Value="user"></asp:ListItem>
                                                            <asp:ListItem Text="readonly" Value="readonly" ></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="UserRole" runat="server" Text='<%# Bind("Role") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="15%" />
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
                    SelectCommand="GetAllAppUsers" SelectCommandType="StoredProcedure" 
                    InsertCommand="InsertAppUser" 
        InsertCommandType="StoredProcedure" UpdateCommandType="StoredProcedure" UpdateCommand="UpdateAppUsr">
                    <InsertParameters>
                         <asp:Parameter Name="LoginID" Type="String" />
                         <asp:Parameter Name="Username" Type="String" />
                         <asp:Parameter Name="Password" Type="String" />
                         <asp:Parameter Name="Role" Type="String" />
                    </InsertParameters>
                     <UpdateParameters>
                         <asp:Parameter Name="id" Type="String" />
                         <asp:Parameter Name="login" Type="String" />
                         <asp:Parameter Name="username" Type="String" />
                         <asp:Parameter Name="password" Type="String" />
                         <asp:Parameter Name="role" Type="String" />
                    </UpdateParameters>
                                   
                    
                </asp:SqlDataSource>


</asp:Content>

