<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="CommentMaint.aspx.vb" Inherits="CommentMaint" title="Admin Message" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
   <asp:ScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server" />

                <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Comments
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="2">
                                        <asp:GridView ID="gvLookupTable" runat="server" AllowPaging="True" RowStyle-VerticalAlign="Top"
                                            AllowSorting="True" Width="100%" PageSize="20" DataSourceID="sqldsLookupTableData" DataKeyNames="ID"
                                            AutoGenerateColumns="False" ShowFooter="True">
                                            <Columns>
                                               <asp:TemplateField HeaderText="Actions">
                                                    <FooterTemplate>
                                                        <asp:ImageButton ID="btnAddItem" runat="server" CommandName="Insert" Text="Insert New Comment" ImageUrl="~/Images/badge_save.png" ToolTip="Insert New Comment"/>&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelAdd" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/Images/badge_cancel.png" ToolTip="Cancel Insert"/>
                                                    </FooterTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <FooterStyle VerticalAlign="Top" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                               <asp:TemplateField HeaderText="Message" SortExpression="CommentDesc">
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="CommentDesc" runat="server" Text='<%# Bind("CommentDesc") %>' Rows="3" Width="95%" MaxLength="500" TextMode="MultiLine"></asp:TextBox>
                                                    </FooterTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1x" runat="server" Text='<%# Bind("CommentDesc") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="50%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                               <asp:TemplateField HeaderText="Message Type" SortExpression="CommentType">
                                                    <FooterTemplate>
                                                        <asp:DropDownList ID="CommentType" runat="server" Selectedvalue='<%# Bind("CommentType") %>'>
                                                            <asp:ListItem Text="Standard" Value="Standard"></asp:ListItem>
                                                            <asp:ListItem Text="Alert" Value="Alert"></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </FooterTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1xc" runat="server" Text='<%# Bind("CommentType") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Date Added" SortExpression="CommentDate">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("CommentDate") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="20%" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="By" SortExpression="UserID">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2b" runat="server" Text='<%# Bind("UserID") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" />
                                                </asp:TemplateField>
                                                
                                            </Columns>
                                            <FooterStyle BackColor="#EEDDC3" />
                                            <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                            <EmptyDataTemplate>
                                                <table width="100%" >
                                                    <tr>
                                                        <td align="center" width="100%" colspan="3">
                                                            <asp:Label ID="Label3" runat="server" Text="No Messages Found "></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td width="100%">
                                                            <table width="100%">
                                                                <tr valign="top">
                                                                    <td width="10%" align="left">
                                                                        <asp:ImageButton ID="btnEmptyAddItem" runat="server" CommandName="EmptyInsert" Text="Insert New Comment" OnClick="btnEmptyAddItem_Click" ImageUrl="~/Images/badge_save.png" ToolTip="Insert New Comment"/>&nbsp;&nbsp;&nbsp;
                                                                        <asp:ImageButton ID="btnEmptyCancelAdd" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/Images/badge_cancel.png" ToolTip="Cancel Insert"/>
                                                                    </td>
                                                                    <td width="90%" align="left">
                                                                        <table width="100%">
                                                                            <tr valign="top">
                                                                                <td width="80%">
                                                                                    <asp:Label ID="Label1" runat="server" Text="Enter Comment"></asp:Label>
                                                                                </td>
                                                                                <td width="20%">
                                                                                    <asp:Label ID="Label4" runat="server" Text="Comment Type"></asp:Label>
                                                                                </td>
                                                                            </tr>
                                                                            <tr valign="top">
                                                                                <td width="80%">
                                                                                    <asp:TextBox ID="CommentDesc" runat="server" Text="" Rows="3" Width="90%" TextMode="MultiLine" MaxLength="500"></asp:TextBox>
                                                                                </td>
                                                                                <td width="20%">
                                                                                    <asp:DropDownList ID="CommentType" runat="server" >
                                                                                        <asp:ListItem Text="Standard" Value="Standard" Selected="True"></asp:ListItem>
                                                                                        <asp:ListItem Text="Alert" Value="Alert"></asp:ListItem>
                                                                                    </asp:DropDownList>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
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
                    SelectCommand="GetComments" SelectCommandType="StoredProcedure" 
                    InsertCommand="InsertComment" InsertCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="CommentTable" Type="String" DefaultValue="" />
                         <asp:Parameter Name="CommentID" Type="String" DefaultValue="" />
                    </SelectParameters>
                    <InsertParameters>
                         <asp:Parameter Name="CommentTable" Type="String" />
                         <asp:Parameter Name="CommentID" Type="String" />
                         <asp:Parameter Name="CommentDesc" Type="String" />
                         <asp:Parameter Name="UserID" Type="String" />
                         <asp:Parameter Name="CommentType" Type="String" />
                    </InsertParameters>
                </asp:SqlDataSource>


</asp:Content>

