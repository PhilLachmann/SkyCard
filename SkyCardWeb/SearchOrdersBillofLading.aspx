<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="SearchOrdersBillofLading.aspx.vb" Inherits="SearchOrdersBillofLading" title="Bill of Lading Order List" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content5" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>
    <asp:HiddenField ID="hfdFirstTime" runat="server" Value="0" />
    <table cellspacing="0" cellpadding="0" width="100%" border="0" class="TableSearch">
        <tbody>
            <tr>
                <td>
                    <table cellpadding="3" cellspacing="1" border="0" width="100%">
                        <tr>
                            <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                Bill of Lading Order Listing
                            </td>
                        </tr>
                        <tr valign="top">
                            <td width="100%" class="tableCaptionLabel" >
                                <table width="100%">
                                    <tr>
                                        <td align="left" width="20%">
                                            <asp:Button ID="btnReturn" runat="server" Text="Return" Width="80px"  />
                                        </td>
                                        <td align="right" width="80%">
                                        
                                            &nbsp;<asp:Label ID="Label3" runat="server" Text="Show Bill of Lading Orders In This Date Range:"></asp:Label>
                                            <asp:TextBox ID="txtStartDate" runat="server" Width="70px" AutoPostBack="True" ></asp:TextBox>
                                            <ajaxToolkit:CalendarExtender ID="calStartDate" runat="server" TargetControlID="txtStartDate" Format="MM/dd/yyyy" PopupButtonID="imgStartDateCalendarIcon" />
                                            <asp:ImageButton runat="Server" ID="imgStartDateCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar"/>&nbsp;&nbsp;
                                            
                                            <asp:Label ID="Label4" runat="server" Text=" To "></asp:Label>
                                             <asp:TextBox ID="txtEndDate" runat="server" Width="70px" AutoPostBack="True" ></asp:TextBox>
                                            <ajaxToolkit:CalendarExtender ID="calEndDate" runat="server" TargetControlID="txtEndDate" Format="MM/dd/yyyy" PopupButtonID="imgEndDateCalendarIcon" />
                                            <asp:ImageButton runat="Server" ID="imgEndDateCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar"/>&nbsp;&nbsp;
                                           
                                            <asp:Button ID="btnSearch" runat="server" Text="Select Orders"  />
                                            
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    
                    <br />
                    <table cellspacing="1" cellpadding="1" width="100%" border="0">
                        <tbody>
                            <tr>
                                <td>
                                    <div runat="server" id="GVTitle">
                                        <table cellspacing="0" cellpadding="0" width="100%" border="0" class="captionLabel">
                                            <tr>
                                                <td align="left" class="RptHeader" width="33%" style="height: 20px">
                                                    <asp:Label Width="100%" ID="lblPageCount" runat="server" Text="Page 1 of 1" Font-Size="smaller"></asp:Label>
                                                </td>
                                                <td class="RptHeader" width="34%" style="height: 20px" align="center">
                                                    <asp:Label ID="lblReportResults" runat="server" Text="Search Results"></asp:Label>
                                                </td>
                                                <td class="RptHeader" width="33%" style="height: 20px" align="right">
                                                    <asp:Label ID="lblRecordCount" runat="server" Text="Record 1 of 1" Font-Size="smaller"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:HiddenField ID="hfdTotalRecords" runat="server" />
                                    <asp:GridView ID="gvSearchRecs" runat="server" Width="100%" AllowSorting="True" HeaderStyle-CssClass="Header2"
                                        AllowPaging="True" PageSize="15" EmptyDataText="There are no Completed Orders in the system for that given date range."
                                        AutoGenerateColumns="False" CellPadding="4" DataKeyNames="OrderNumber" ForeColor="#333333"
                                        GridLines="Vertical">
                                        <AlternatingRowStyle CssClass="gvRowDataAlt"></AlternatingRowStyle>
                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <PagerSettings Mode="NextPreviousFirstLast" FirstPageImageUrl="Images/resultset_first.png"
                                            FirstPageText="First" LastPageImageUrl="Images/resultset_last.png" LastPageText="Last"
                                            NextPageImageUrl="Images/resultset_next.png" NextPageText="Next" PreviousPageImageUrl="Images/resultset_previous.png"
                                            PreviousPageText="Previous"></PagerSettings>
                                        <RowStyle CssClass="gvRowData"></RowStyle>
                                        <Columns>
                                            <asp:BoundField DataField="JobDesc" HeaderText="Job" SortExpression="JobDesc" HeaderStyle-Width="25%" />
                                            <asp:BoundField DataField="LocDesc" HeaderText="Location" SortExpression="LocDesc" HeaderStyle-Width="25%" />
                                            <asp:BoundField DataField="OrderNumber" HeaderText="Order Number" SortExpression="OrderNumber" HeaderStyle-Width="20%" />
                                            <asp:BoundField DataField="RecordDate" HeaderText="Entry Date" SortExpression="RecordDate" HeaderStyle-Width="20%" />
                                            <asp:TemplateField HeaderText="Actions" HeaderStyle-Width="10%" >
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="btnShowReport" runat="server" CommandName="Report" CommandArgument='<%# Bind("OrderNumber") %>' Text="Show Bill of Lading Report" ImageUrl="~/Images/show_report.png" ToolTip="Show Bill of Lading Report"/>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <HeaderStyle CssClass="Header2" Font-Bold="True"></HeaderStyle>
                                        <PagerStyle BackColor="DarkGray" ForeColor="White" HorizontalAlign="Center" />
                                    </asp:GridView>
                                    <asp:SqlDataSource ID="sqldsItemSearch" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                        SelectCommand="Call GetBillofLadingOrderList(?,?)" SelectCommandType="StoredProcedure" >
                                        <SelectParameters>
                                            <asp:Parameter Name="StartDate" Type="DateTime" DefaultValue="" />
                                            <asp:Parameter Name="EndDate" Type="DateTime" DefaultValue="" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>



</asp:Content>







