<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="PriceMultiplierMaint.aspx.vb" Inherits="PriceMultiplierMaint" title="Maintain Price Multipliers" %>

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
                                        Price Multiplier Maintenance
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" Text="Pricing Category:"></asp:Label>&nbsp;&nbsp;
                                        <asp:SqlDataSource ID="sqldsCategoryLookup" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                            ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                            SelectCommand="Call GetCategories()" SelectCommandType="StoredProcedure">
                                        </asp:SqlDataSource>
                                        <asp:DropDownList ID="PriceCategory" runat="server" DataSourceID="sqldsCategoryLookup"
                                            DataTextField="PriceCategory" DataValueField="PriceCategory" AutoPostBack="true"  >
                                        </asp:DropDownList>
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
                                                        <asp:ImageButton ID="btnEditItem" runat="server" CommandName="Edit" Text="Edit Price Multiplier" Visible="False" ImageUrl="~/Images/item_edit.png" ToolTip="Edit Price Multiplier"/>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:ImageButton ID="btnUpdateItem" runat="server" CommandName="Update" Text="Update Price Multiplier" ImageUrl="~/Images/badge_save.png" ToolTip="Update Price Multiplier"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelUpdate" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/Images/badge_cancel.png" ToolTip="Cancel Update"/>
                                                    </EditItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:ImageButton ID="btnAddItem" runat="server" CommandName="Insert" Text="Insert New Price Multiplier" ImageUrl="~/Images/badge_save.png" ToolTip="Insert New Price Multiplier"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelAdd" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/Images/badge_cancel.png" ToolTip="Cancel Insert"/>
                                                    </FooterTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <FooterStyle VerticalAlign="Bottom" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                               <asp:TemplateField HeaderText="Category ID" SortExpression="CategoryID">
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="CategoryID" runat="server" Text='<%# Bind("CategoryID") %>' Width="90%" Enabled="false"></asp:TextBox>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:Label ID="Label1xx" runat="server" Text='<%# Bind("CategoryID") %>'></asp:Label>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1x" runat="server" Text='<%# Bind("CategoryID") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="20%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Price Desc" SortExpression="PriceDesc">
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="PriceDesc" runat="server" Text='<%# Bind("PriceDesc") %>' Width="90%"></asp:TextBox>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="PriceDesc" runat="server" Text='<%# Bind("PriceDesc") %>' Width="90%"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("PriceDesc") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Cost Multiplier" SortExpression="CostMultiplier">
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="CostMultiplier" runat="server" Text='<%# Bind("CostMultiplier") %>' Width="90%"></asp:TextBox>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="CostMultiplier" runat="server" Text='<%# Bind("CostMultiplier") %>' Width="90%"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2a" runat="server" Text='<%# Bind("CostMultiplier") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Sell Multiplier" SortExpression="SellMultiplier">
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="SellMultiplier" runat="server" Text='<%# Bind("SellMultiplier") %>' Width="90%"></asp:TextBox>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="SellMultiplier" runat="server" Text='<%# Bind("SellMultiplier") %>' Width="90%"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2b" runat="server" Text='<%# Bind("SellMultiplier") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Start Date" SortExpression="StartDate">
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="StartDate" runat="server" Text='' Width="70%" onchange="javascript:checkPriceStartDate(this);"></asp:TextBox>
                                                        <ajaxToolkit:CalendarExtender ID="calStartDate" runat="server" TargetControlID="StartDate" Format="MM/dd/yyyy" PopupButtonID="imgStartDateCalendarIcon" />
                                                        <asp:ImageButton runat="Server" ID="imgStartDateCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar"/>&nbsp;&nbsp;
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="StartDate" runat="server" Text='<%# Utilities.NullableFormatDateTimeShortDate(Eval("StartDate")) %>' Width="70%"></asp:TextBox>
                                                        <ajaxToolkit:CalendarExtender ID="calStartDate" runat="server" TargetControlID="StartDate" Format="MM/dd/yyyy" PopupButtonID="imgStartDateCalendarIcon" />
                                                        <asp:ImageButton runat="Server" ID="imgStartDateCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar"/>&nbsp;&nbsp;
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2c" runat="server" Text='<%# Utilities.NullableFormatDateTimeShortDate(Eval("StartDate")) %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Stop Date" SortExpression="StopDate">
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="StopDate" runat="server" Text='' Width="70%" Enabled="False"></asp:TextBox>
                                                        <ajaxToolkit:CalendarExtender ID="calStopDate" runat="server" TargetControlID="StopDate" Format="MM/dd/yyyy" PopupButtonID="imgStopDateCalendarIcon" Enabled="False"/>
                                                        <asp:ImageButton runat="Server" ID="imgStopDateCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar" Enabled="False"/>&nbsp;&nbsp;
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="StopDate" runat="server" Text='<%# Utilities.NullableFormatDateTimeShortDate(Eval("StopDate")) %>' Width="70%" ></asp:TextBox>
                                                        <ajaxToolkit:CalendarExtender ID="calStopDate" runat="server" TargetControlID="StopDate" Format="MM/dd/yyyy" PopupButtonID="imgStopDateCalendarIcon"  />
                                                        <asp:ImageButton runat="Server" ID="imgStopDateCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar" />&nbsp;&nbsp;
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2d" runat="server" Text='<%# Utilities.NullableFormatDateTimeShortDate(Eval("StopDate")) %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Active" SortExpression="IsActive">
                                                    <FooterTemplate>
                                                        <asp:DropDownList ID="IsActive" runat="server" SelectedValue='<%# Bind("IsActive") %>' Enabled="false"  >
                                                            <asp:ListItem Text="True" Value="1"></asp:ListItem>
                                                            <asp:ListItem Text="False" Value="0"></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="IsActive" runat="server" SelectedValue='<%# Bind("IsActive") %>'  >
                                                            <asp:ListItem Text="True" Value="True" Selected="True"></asp:ListItem>
                                                            <asp:ListItem Text="False" Value="False"></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("IsActive") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="5%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Last Modified" SortExpression="LastModified">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2e" runat="server" Text='<%# Bind("LastModified") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="15%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                
                                                
                                            </Columns>
                                            <FooterStyle BackColor="#EEEEEE" />
                                            <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                            <EmptyDataTemplate>
                                                No Price Multipliers Found for the Given Category
                                                <asp:LinkButton ID="lbnAddPriceMultiplier" runat="server" OnClick="lbnAddPriceMultiplier_Click">Add A Price Multiplier</asp:LinkButton>
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
                    SelectCommand="Call GetPriceMultipliers(?)" SelectCommandType="StoredProcedure" 
                    InsertCommand="Call InsertPriceMultiplier(?,?,?,?,?,?)" InsertCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:ControlParameter ControlID="PriceCategory" PropertyName="SelectedValue" Name="CategoryID" DefaultValue="" Type="String" />
                    </SelectParameters>
                    <InsertParameters>
                         <asp:Parameter Name="CategoryID" Type="String" />
                         <asp:Parameter Name="PriceDesc" Type="String" />
                         <asp:Parameter Name="CostMultiplier" Type="Decimal" />
                         <asp:Parameter Name="SellMultiplier" Type="Decimal" />
                         <asp:Parameter Name="StartDate" Type="DateTime" />
                         <asp:Parameter Name="Stopdate" Type="DateTime" />
                    </InsertParameters>
                </asp:SqlDataSource>


</asp:Content>

