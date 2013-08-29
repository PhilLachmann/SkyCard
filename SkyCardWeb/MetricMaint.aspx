<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="MetricMaint.aspx.vb" Inherits="MetricMaint" title="Maintain Metrics" %>

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
                                            AllowSorting="True" Width="100%" PageSize="20" DataSourceID="sqldsLookupTableData" DataKeyNames="metricid"
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

                                                <asp:TemplateField HeaderText="Metric Name" SortExpression="metricname">
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="metricname" runat="server" Text='<%# Bind("metricname")%>'></asp:TextBox>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("metricname")%>'></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("metricname")%>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="5%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                               
                                                <asp:TemplateField HeaderText="Computed" SortExpression="computed">
                                                    <FooterTemplate>
                                                        <asp:CheckBox ID="computed" runat="server" Checked='<%# Bind("computed")%>' />
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:CheckBox ID="cb1" runat="server" Checked='<%# Bind("computed")%>' />
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="cblabel" runat="server" Checked='<%# Bind("computed")%>' Enabled="false" />
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
                    SelectCommand="GetAllMetrics" SelectCommandType="StoredProcedure" 
                    InsertCommand="InsertMetric" InsertCommandType="StoredProcedure"  
                    UpdateCommand="UpdateMetric" UpdateCommandType="StoredProcedure">
                     <InsertParameters>
                         <asp:Parameter Name="metricname" Type="String" />
                         <asp:Parameter Name="computed" Type="Int32" />
                    </InsertParameters>
                </asp:SqlDataSource>


</asp:Content>


