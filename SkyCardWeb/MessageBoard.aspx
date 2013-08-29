<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="MessageBoard.aspx.vb" Inherits="MessageBoard" title="MessageBoard" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
   <asp:ScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server" />

                <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Message Board
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="2">
                                        <asp:GridView ID="gvLookupTable" runat="server" AllowPaging="True" RowStyle-VerticalAlign="Top"
                                            AllowSorting="True" Width="100%" PageSize="20" DataSourceID="sqldsLookupTableData" DataKeyNames="ID"
                                            AutoGenerateColumns="False" ShowFooter="True">
                                            <Columns>
                                               <asp:TemplateField HeaderText="Message" SortExpression="CommentDesc">
                                                    <FooterTemplate>
                                                     </FooterTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1x" runat="server" Text='<%# Bind("CommentDesc") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="60%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                               <asp:TemplateField HeaderText="Message Type" SortExpression="CommentType">
                                                    <FooterTemplate>
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
                                            <FooterStyle BackColor="#EEEEEE" />
                                            <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                            <EmptyDataTemplate>
                                                <table width="100%" >
                                                    <tr>
                                                        <td align="center" width="100%" colspan="3">
                                                            <asp:Label ID="Label3" runat="server" Text="No Comments Found for This Item"></asp:Label>
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

