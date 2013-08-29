<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="AssetSearch.aspx.vb" Inherits="AssetSearch" title="Search Assets" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>

                <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Asset Search
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="2">
                                    
                                                                                
                                             <asp:GridView ID="gvLookupTable" runat="server" AllowPaging="True" RowStyle-VerticalAlign="Top"
                                            AllowSorting="False" DataKeyNames="Record_ID" PageSize="20" 
                                            AutoGenerateColumns="False" Width="100%" ShowFooter="True">
                                            <EmptyDataTemplate>
                                                No Data Found
                                            </EmptyDataTemplate>
                                            <Columns>
                                                <asp:TemplateField HeaderText="Tag Name" SortExpression="tagname">
                                                   <ItemTemplate>
                                                        <asp:DropDownList ID="tagname" runat="server" DataSourceID="sqldsTagList" enabled="False" SelectedValue='<%# Bind("Tagname") %>'
                                                            DataTextField="TagDesc" DataValueField="TagNameValue" >
                                                        </asp:DropDownList>
                                                   </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="tagname" runat="server" DataSourceID="sqldsTagList" 
                                                            DataTextField="TagDesc" DataValueField="TagNameValue" >
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle Width="30%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                
                                                 <asp:TemplateField HeaderText="Operation" >
                                                   <ItemTemplate>
                                                        <asp:DropDownList ID="Operation" runat="server"  enabled="False" SelectedValue='<%# Bind("Operation") %>'>
                                                            <asp:ListItem Text="Equals" Value="=" />
                                                            <asp:ListItem Text="Like" Value="Like" />
                                                        </asp:DropDownList>
                                                   </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="Operation" runat="server" >
                                                            <asp:ListItem Text="Equals" Value="=" />
                                                            <asp:ListItem Text="Like" Value="Like" Selected="True" />
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle Width="30%" HorizontalAlign="Center" />
                                                </asp:TemplateField>           
                                                     
                                                                
                                                <asp:TemplateField HeaderText="Tag Value">
                                                   <ItemTemplate>
                                                       <asp:Label ID="Label1c" runat="server" Text='<%# Bind("TagValue") %>'></asp:Label>
                                                   </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="TagValue" runat="server" Text='' Width="90%"></asp:TextBox>
                                                        
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                
                                                
                                                            
                                               
                                               
                                               <asp:TemplateField HeaderText="Actions">
                                                   <ItemTemplate>
                                                        <asp:ImageButton ID="btnRemoveAdjustment" runat="server" CommandName="Delete" Text="Remove Item" ImageUrl="~/Images/item_remove.png" ToolTip="Remove This Item"/>&nbsp;&nbsp;&nbsp;
                                                        <ajaxToolkit:ConfirmButtonExtender ID="cbeRemoveAdjustment" runat="server" 
                                                            TargetControlID="btnRemoveAdjustment"
                                                            ConfirmText="Are you sure you want to Remove this Search Criteria?" 
                                                            OnClientCancel="cancelClick" />
                                                   </ItemTemplate>
                                                   <EditItemTemplate>
                                                        <asp:ImageButton ID="btnAcceptChanges" runat="server" CommandName="Update" Text="Accept Criterion" ImageUrl="~/Images/okay.png" ToolTip="Accept Criterion"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelChanges" runat="server" CommandName="Cancel" Text="Cancel Criterion" ImageUrl="~/Images/remove.png" ToolTip="Cancel Criterion"/>&nbsp;&nbsp;&nbsp;
                                                   </EditItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                            </Columns>
                                            <HeaderStyle BackColor="DarkGray" Font-Bold="True" />
                                        </asp:GridView>
                                    
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnQuery" runat="server" Text="Submit" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>

                 <asp:SqlDataSource ID="sqldsLookupTableData" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetAllTags()" SelectCommandType="StoredProcedure" 
                    InsertCommand="Call InsertTagName(?,?)" InsertCommandType="StoredProcedure"  
                    UpdateCommand="Call UpdateTagName(?,?,?)" UpdateCommandType="StoredProcedure">
                    <UpdateParameters>
                         <asp:Parameter Name="TagNameID" Type="Int32" />
                         <asp:Parameter Name="TagName" Type="String" />
                         <asp:Parameter Name="TagType" Type="String" />
                    </UpdateParameters>
                    <InsertParameters>
                         <asp:Parameter Name="TagName" Type="String" />
                         <asp:Parameter Name="TagType" Type="String" />
                    </InsertParameters>
                </asp:SqlDataSource>
                
                <asp:SqlDataSource ID="sqldsSearchSchema" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetSearchSchema()" SelectCommandType="StoredProcedure"> 
                </asp:SqlDataSource>

                <asp:SqlDataSource ID="sqldsTagList" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetSearchableTags()" SelectCommandType="StoredProcedure"> 
                </asp:SqlDataSource>

</asp:Content>

