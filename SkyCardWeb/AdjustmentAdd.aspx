<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="AdjustmentAdd.aspx.vb" Inherits="AdjustmentAdd" title="Add Inventory Adjustment" %>

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
                                    Add Inventory Adjustments
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btnProcessAdjustments" runat="server" Text="Process Adjustments" />
                                </td>
                            </tr>
                            <tr valign="top">
                                <td colspan="2">
                                        <asp:GridView ID="gvLookupTable" runat="server" AllowPaging="True" RowStyle-VerticalAlign="Top"
                                            AllowSorting="False" DataKeyNames="RecordID" PageSize="20" 
                                            AutoGenerateColumns="False" Width="100%" ShowFooter="True">
                                            <EmptyDataTemplate>
                                                No Data Found
                                            </EmptyDataTemplate>
                                            <Columns>
                                                <asp:TemplateField HeaderText="Product/Item" SortExpression="ItemID">
                                                   <ItemTemplate>
                                                        <asp:DropDownList ID="ItemID" runat="server" DataSourceID="sqldsProductSizeList" enabled="False" SelectedValue='<%# Bind("ItemID") %>'
                                                            DataTextField="ItemDescSize" DataValueField="ItemID" >
                                                        </asp:DropDownList>
                                                   </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="ItemID" runat="server" DataSourceID="sqldsProductSizeList"
                                                            DataTextField="ItemDescSize" DataValueField="ItemID" >
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle Width="30%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                
                                                <asp:TemplateField HeaderText="Job" SortExpression="JobID">
                                                   <ItemTemplate>
                                                        <asp:DropDownList ID="JobID" runat="server" DataSourceID="sqldsJobList" enabled="False" SelectedValue='<%# Bind("JobID") %>'
                                                            DataTextField="JobDesc" DataValueField="JobID" >
                                                        </asp:DropDownList>
                                                   </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="JobID" runat="server" DataSourceID="sqldsJobList"
                                                            DataTextField="JobDesc" DataValueField="JobID" >
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                
                                                <asp:TemplateField HeaderText="Location" SortExpression="LocationID">
                                                   <ItemTemplate>
                                                        <asp:DropDownList ID="LocationID" runat="server" DataSourceID="sqldsLocationList" enabled="False" SelectedValue='<%# Bind("LocationID") %>'
                                                            DataTextField="LocDesc" DataValueField="LocationID" >
                                                        </asp:DropDownList>
                                                   </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="LocationID" runat="server" DataSourceID="sqldsLocationList"
                                                            DataTextField="LocDesc" DataValueField="LocationID" >
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                
                                                 <asp:TemplateField HeaderText="Transaction Type" SortExpression="TransType">
                                                   <ItemTemplate>
                                                        <asp:DropDownList ID="TransType" runat="server" enabled="False" SelectedValue='<%# Bind("TransType") %>'  >
                                                            <asp:ListItem Text="Beginning On Hand" Value="BOH"></asp:ListItem>
                                                            <asp:ListItem Text="Adjustment" Value="ADJ" Selected="True"></asp:ListItem>
                                                        </asp:DropDownList>
                                                   </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="TransType" runat="server"  >
                                                            <asp:ListItem Text="Beginning On Hand" Value="BOH"></asp:ListItem>
                                                            <asp:ListItem Text="Adjustment" Value="ADJ" Selected="True"></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                
                                                <asp:TemplateField HeaderText="Quantity" SortExpression="Quantity">
                                                   <ItemTemplate>
                                                       <asp:Label ID="Label1c" runat="server" Text='<%# Bind("Quantity") %>'></asp:Label>
                                                   </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="Quantity" runat="server" Text='' Width="90%"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                               
                                               <asp:TemplateField HeaderText="Actions">
                                                   <ItemTemplate>
                                                        <asp:ImageButton ID="btnRemoveAdjustment" runat="server" CommandName="Delete" Text="Remove Adjustment" ImageUrl="~/Images/item_remove.png" ToolTip="Remove This Adjustment"/>&nbsp;&nbsp;&nbsp;
                                                        <ajaxToolkit:ConfirmButtonExtender ID="cbeRemoveAdjustment" runat="server" 
                                                            TargetControlID="btnRemoveAdjustment"
                                                            ConfirmText="Are you sure you want to Remove this Adjustment?" 
                                                            OnClientCancel="cancelClick" />
                                                   </ItemTemplate>
                                                   <EditItemTemplate>
                                                        <asp:ImageButton ID="btnAcceptChanges" runat="server" CommandName="Update" Text="Accept Changes" ImageUrl="~/Images/okay.png" ToolTip="Accept Adustment"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelChanges" runat="server" CommandName="Cancel" Text="Cancel Changes" ImageUrl="~/Images/remove.png" ToolTip="Cancel Adustment"/>&nbsp;&nbsp;&nbsp;
                                                   </EditItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                            </Columns>
                                            <HeaderStyle BackColor="DarkGray" Font-Bold="True" />
                                        </asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            
             <asp:SqlDataSource ID="sqldsLookupTableData" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                SelectCommand="Call GetInvTrans()" SelectCommandType="StoredProcedure"
                InsertCommand="Call InsertInvTransBatch(?,?,?,?,?,?)" InsertCommandType="StoredProcedure">
                <InsertParameters>
                     <asp:Parameter Name="ItemID" Type="String" />
                     <asp:Parameter Name="LocationID" Type="String" />
                     <asp:Parameter Name="JobID" Type="String" />
                     <asp:Parameter Name="TransType" Type="String" />
                     <asp:Parameter Name="Quantity" Type="Int32" />
                     <asp:Parameter Name="UserID" Type="String" />
                </InsertParameters>
            </asp:SqlDataSource>
            
            <asp:SqlDataSource ID="sqldsProductSizeList" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                SelectCommand="Call GetProductSizeList()" SelectCommandType="StoredProcedure">
            </asp:SqlDataSource>

            <asp:SqlDataSource ID="sqldsLocationList" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                SelectCommand="Call GetLocationList()" SelectCommandType="StoredProcedure">
            </asp:SqlDataSource>

            <asp:SqlDataSource ID="sqldsJobList" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                SelectCommand="Call GetJobList()" SelectCommandType="StoredProcedure">
            </asp:SqlDataSource>



</asp:Content>

