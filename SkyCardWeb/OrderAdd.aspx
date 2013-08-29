<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="OrderAdd.aspx.vb" Inherits="OrderAdd" title="Enter New Order" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>

            <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />

            <table class="TabPanelTable">
                <tr style="vertical-align: top;">
                    <td>
                        <table cellpadding="3" cellspacing="1" border="0" width="100%">
                            <tr>
                                <td align="center" width="100%" class="tableCaptionLabel" colspan="3">
                                    Add New Order
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btnProcessOrder" runat="server" Text="Process Order" />&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="btnCancelOrder" runat="server" Text="Cancel/Clear Order" />
                                    <ajaxToolkit:ConfirmButtonExtender ID="cbeCancelOrder" runat="server" 
                                        TargetControlID="btnCancelOrder"
                                        ConfirmText="Are you sure you want to Clear this order?" 
                                        OnClientCancel="cancelClick" />
                                </td>
                            </tr>
                            <tr valign="top">
                                <td width="10%">
                                </td>
                                <td width="20%" align="right">
                                    <asp:Label ID="Label1" runat="server" Text="Enter Order For Job: "></asp:Label>
                                </td>
                                <td width="70%">
                                    <asp:SqlDataSource ID="sqldsJobListddl" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                        SelectCommand="Call GetJobList()" SelectCommandType="StoredProcedure">
                                    </asp:SqlDataSource>
                                    <asp:DropDownList ID="JobID" runat="server" AutoPostBack="True" 
                                        DataTextField="JobDesc" DataValueField="JobID" AppendDataBoundItems="True" >
                                        <asp:ListItem Text="Select Job" Value="" Selected="True"></asp:ListItem>
                                    </asp:DropDownList>&nbsp;&nbsp;
                                    <asp:HiddenField ID="hfdJobID" runat="server" />
                                </td>
                            </tr>
                            <tr valign="top">
                                <td>
                                </td>
                                <td align="right">
                                    <asp:Label ID="Label4" runat="server" Text="Location: "></asp:Label>
                                </td>
                                <td>
                                    <asp:SqlDataSource ID="sqldsLocationListddl" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                        SelectCommand="Call GetLocationList()" SelectCommandType="StoredProcedure">
                                    </asp:SqlDataSource>
                                    <asp:DropDownList ID="LocationID" runat="server" AutoPostBack="True" 
                                        DataTextField="LocDesc" DataValueField="LocationID" AppendDataBoundItems="True">
                                        <asp:ListItem Text="Select Location" Value="" Selected="True"></asp:ListItem>
                                    </asp:DropDownList>&nbsp;&nbsp;
                                    <asp:HiddenField ID="hfdLocationID" runat="server" />
                                </td>
                            </tr>
                            <tr valign="top">
                                <td>
                                </td>
                                <td align="right">
                                    <asp:Label ID="Label2" runat="server" Text="Ordered By: "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtOrderedBy" runat="server" MaxLength="50"></asp:TextBox>
                                </td>
                            </tr>
                            <tr valign="top">
                                <td colspan="3">
                                        <asp:GridView ID="gvLookupTable" runat="server" AllowPaging="False" RowStyle-VerticalAlign="Top"
                                            AllowSorting="False" DataKeyNames="RecordID" 
                                            AutoGenerateColumns="False" Width="100%" ShowFooter="True">
                                            <EmptyDataTemplate>
                                                No Data Found
                                            </EmptyDataTemplate>
                                            <Columns>
                                                 <asp:TemplateField HeaderText="Category" SortExpression="Category">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="PriceCategory" runat="server" Text='<%# Bind("PriceCategory") %>' Enabled="False" Width="95%" ></asp:TextBox>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="PriceCategory" runat="server" DataSourceID="sqldsCategoryLookup" OnSelectedIndexChanged="PriceCategory_SelectedIndexChanged" 
                                                            DataTextField="PriceCategory" DataValueField="PriceCategory" AutoPostBack="true" >
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle Width="20%" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Product/Item" SortExpression="ItemID">
                                                   <ItemTemplate>
                                                       <asp:TextBox ID="ItemDesc" runat="server" Text='<%# Bind("ItemDesc") %>' Enabled="False" Width="95%" ></asp:TextBox>
                                                   </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="ItemID" runat="server" 
                                                            DataTextField="ItemDescSize" DataValueField="ItemID" AppendDataBoundItems="True" >
                                                            <asp:ListItem Text="Select a Value" Value=""></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle Width="20%" HorizontalAlign="Center" />
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
                                                <asp:TemplateField HeaderText="Comments" SortExpression="Comments">
                                                   <ItemTemplate>
                                                       <asp:Label ID="Label1cx" runat="server" Text='<%# Bind("Comments") %>'></asp:Label>
                                                   </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="Comments" runat="server" Text='' Width="90%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <HeaderStyle Width="40%" HorizontalAlign="Center" />
                                                </asp:TemplateField>



                                                <asp:TemplateField HeaderText="Actions">
                                                   <ItemTemplate>
                                                        <asp:ImageButton ID="btnRemoveAdjustment" runat="server" CommandName="Delete" Text="Remove Line Item" ImageUrl="~/Images/item_remove.png" ToolTip="Remove This Line item"/>&nbsp;&nbsp;&nbsp;
                                                        <ajaxToolkit:ConfirmButtonExtender ID="cbeRemoveAdjustment" runat="server" 
                                                            TargetControlID="btnRemoveAdjustment"
                                                            ConfirmText="Are you sure you want to Remove this Line Item?" 
                                                            OnClientCancel="cancelClick" />
                                                   </ItemTemplate>
                                                   <EditItemTemplate>
                                                        <asp:ImageButton ID="btnAcceptChanges" runat="server" CommandName="Update" Text="Accept Changes" ImageUrl="~/Images/okay.png" ToolTip="Accept Line Item"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelChanges" runat="server" CommandName="Cancel" Text="Cancel Changes" ImageUrl="~/Images/remove.png" ToolTip="Cancel Line Item"/>&nbsp;&nbsp;&nbsp;
                                                   </EditItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
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
                SelectCommand="Call GetOrder()" SelectCommandType="StoredProcedure"
                InsertCommand="? = Call func_InsertOrder(?,?,?,?,?,?,?,?,?,?)" InsertCommandType="StoredProcedure">
                <InsertParameters>
                     <asp:Parameter Name="ReturnValue" Type="Int32" Direction="ReturnValue"/>
                     <asp:Parameter Name="RecordID" Type="String" />
                     <asp:Parameter Name="OrderNumber" Type="Int32" />
                     <asp:Parameter Name="ItemID" Type="String" />
                     <asp:Parameter Name="TransType" Type="String" />
                     <asp:Parameter Name="Quantity" Type="Int32" />
                     <asp:Parameter Name="LocationID" Type="String" />
                     <asp:Parameter Name="JobID" Type="String" />
                     <asp:Parameter Name="UserID" Type="String" />
                     <asp:Parameter Name="Comments" Type="String" />
                     <asp:Parameter Name="OrderBy" Type="String" />
                </InsertParameters>
            </asp:SqlDataSource>

             <asp:SqlDataSource ID="sqldsBackOrders" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                SelectCommand="Call GetBackOrdersForJob(?,?)" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="JobID" PropertyName="SelectedValue" Name="JobID" Type="String" />
                    <asp:ControlParameter ControlID="LocationID" PropertyName="SelectedValue" Name="LocationID" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>

            <asp:SqlDataSource ID="sqldsCategoryLookup" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                SelectCommand="Call GetCategories()" SelectCommandType="StoredProcedure">
            </asp:SqlDataSource>
            
            <asp:SqlDataSource ID="sqldsProductSizeList" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                SelectCommand="Call GetFilteredProductSizeList(?)" SelectCommandType="StoredProcedure">
                <SelectParameters>
                     <asp:Parameter Name="CategoryID" Type="String" DefaultValue="" />
                </SelectParameters>
            </asp:SqlDataSource>





</asp:Content>

