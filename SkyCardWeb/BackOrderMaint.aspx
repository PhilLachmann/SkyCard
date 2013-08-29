<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="BackOrderMaint.aspx.vb" Inherits="BackOrderMaint" title="Maintain Backorders" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content3" ContentPlaceHolderID="cphError" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>

                <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Backorder Maintenance
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="2">
                                    
                                    
                                        <asp:GridView ID="gvLookupTable" runat="server" AllowPaging="True" RowStyle-VerticalAlign="Top" 
                                            AllowSorting="True" Width="100%" PageSize="20" DataSourceID="sqldsLookupTableData" DataKeyNames="RecordID"
                                            AutoGenerateColumns="False" ShowFooter="True">
                                            <Columns>
                                               <asp:TemplateField HeaderText="Actions">
                                                    <ItemTemplate>
                                                        &nbsp;<asp:ImageButton ID="btnVoidBackOrder" runat="server" CommandName="Delete" CommandArgument="<%# Container.DataItemIndex %>" Text="Void this Backordered line item" ImageUrl="~/Images/remove.png" ToolTip="Void this Backordered line item"/>
                                                        <ajaxToolkit:ConfirmButtonExtender ID="cbeVoidBackOrder" runat="server" 
                                                            TargetControlID="btnVoidBackOrder"
                                                            ConfirmText="Are you sure you want to Void this Line Item?" 
                                                            OnClientCancel="cancelClick" />
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <ItemStyle VerticalAlign="Bottom" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Job" SortExpression="JobDesc">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2a" runat="server" Text='<%# Bind("JobDesc") %>' ToolTip='<%# Bind("JobID") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="15%" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Location" SortExpression="LocDesc">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2b" runat="server" Text='<%# Bind("LocDesc") %>' ToolTip='<%# Bind("LocationID") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Item" SortExpression="ItemDesc">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2c" runat="server" Text='<%# Bind("ItemDesc") %>' ToolTip='<%# Bind("ItemID") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="20%" />
                                                </asp:TemplateField>
                                               <asp:TemplateField HeaderText="Order Num" SortExpression="OrderNumber">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1x" runat="server" Text='<%# Bind("OrderNumber") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <ItemStyle VerticalAlign="Bottom" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Line Num" SortExpression="LineNumber">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("LineNumber") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="5%" />
                                                    <ItemStyle VerticalAlign="Bottom" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Qty" SortExpression="Quantity">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2d" runat="server" Text='<%# Bind("Quantity") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <ItemStyle VerticalAlign="Bottom" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Fill Qty" SortExpression="FillQty">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2e" runat="server" Text='<%# Bind("FillQty") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <ItemStyle VerticalAlign="Bottom" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="BkOrd Qty" SortExpression="BackOrderQty">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2f" runat="server" Text='<%# Bind("BackOrderQty") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle VerticalAlign="Bottom" HorizontalAlign="Center" />
                                                    <HeaderStyle Width="10%" />
                                                </asp:TemplateField>
                                            </Columns>
                                            <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                            <EmptyDataTemplate>
                                                No Open Backorders Found
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
                    SelectCommand="Call GetAllBackorders()" SelectCommandType="StoredProcedure" DeleteCommand="XXXX" DeleteCommandType="StoredProcedure" 
                    UpdateCommand="Call UpdateVoidBackOrder(?)" UpdateCommandType="StoredProcedure">
                    <UpdateParameters>
                         <asp:Parameter Name="RecordID" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>


</asp:Content>

