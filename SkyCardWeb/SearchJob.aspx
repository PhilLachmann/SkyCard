<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="SearchJob.aspx.vb" Inherits="SearchJob" title="Job Search" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content5" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>
    <table cellspacing="0" cellpadding="0" width="100%" border="0" class="TableSearch">
        <tbody>
            <tr>
                <td>
                    <table cellspacing="1" cellpadding="1" width="100%" border="1">
                        <tbody>
                            <tr>
                                <td class="tableCaptionLabel" colspan="6" align="center">
                                    Job Search
                                </td>
                            </tr>
                            <tr>
                                <td class="Header2" width="17%">
                                    Search By
                                </td>
                                <td class="Header2" width="33%">
                                    Search Criteria
                                </td>
                                <td class="Header2" width="17%">
                                    Search By
                                </td>
                                <td class="Header2" width="33%">
                                    Search Criteria
                                </td>
                            </tr>
                            <tr valign="top">
                                <td align="left">
                                    <asp:Label ID="Label2" runat="server" Text="Job ID"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="txtJobID" runat="server" CssClass="dControl" Width="50%" MaxLength="25"></asp:TextBox>
                                    <asp:CheckBox ID="cbxJobID" runat="server" Text="Use Contains" Visible="False" CssClass="dControl" />
                                </td>
                                <td align="left">
                                    <asp:Label ID="Label1" runat="server" Text="Job Desc"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="txtJobDesc" runat="server" CssClass="dControl" Width="50%" MaxLength="20"></asp:TextBox>
                                    <asp:CheckBox ID="cbxJobDesc" runat="server" Text="Use Contains" Visible="False" CssClass="dControl" />
                                </td>
                            </tr>
                            <tr valign="top">
                                <td align="left">
                                    <asp:Label ID="Label10" runat="server" Text="Job Barcode"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="txtJobBarcode" runat="server" CssClass="dControl" Width="50%" MaxLength="100"></asp:TextBox>
                                    <asp:CheckBox ID="cbxJobBarcode" runat="server" Text="Use Contains" Visible="False" CssClass="dControl" />
                                </td>
                                <td align="left">&nbsp;
                                </td>
                                <td align="left">&nbsp;
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <table cellspacing="1" cellpadding="1" width="100%" border="1">
                        <tbody>
                            <tr>
                                <td align="center" style="width: 50%;">
                                    <asp:Button ID="btnSearch" runat="server" Text="Search / List Jobs"></asp:Button>
                                </td>
                                <td align="center" style="width: 50%">
                                    <asp:Button ID="btnClearCriteria" runat="server" Text="Clear Criteria/Results"></asp:Button>
                                </td>
                            </tr>
                        </tbody>
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
                                        AllowPaging="True" PageSize="15" EmptyDataText="There are no Jobs in the system that match the above criteria."
                                        AutoGenerateColumns="False" CellPadding="4" DataKeyNames="JobID" ForeColor="#333333"
                                        GridLines="Vertical">
                                        <AlternatingRowStyle CssClass="gvRowDataAlt"></AlternatingRowStyle>
                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <PagerSettings Mode="NextPreviousFirstLast" FirstPageImageUrl="Images/resultset_first.png"
                                            FirstPageText="First" LastPageImageUrl="Images/resultset_last.png" LastPageText="Last"
                                            NextPageImageUrl="Images/resultset_next.png" NextPageText="Next" PreviousPageImageUrl="Images/resultset_previous.png"
                                            PreviousPageText="Previous"></PagerSettings>
                                        <RowStyle CssClass="gvRowData"></RowStyle>
                                        <Columns>
                                            <asp:BoundField DataField="JobID" HeaderText="Job ID" SortExpression="JobID" HeaderStyle-Width="10%" />
                                            <asp:BoundField DataField="pct" HeaderText="Pct Match" SortExpression="pct" Visible="False" />
                                            <asp:BoundField DataField="JobDesc" HeaderText="Job Desc" SortExpression="JobDesc" HeaderStyle-Width="40%" />
                                            <asp:BoundField DataField="JobBarcode" HeaderText="Job Barcode" SortExpression="JobBarcode" HeaderStyle-Width="20%" />
                                            <asp:BoundField DataField="LastModified" HeaderText="Last Activity" SortExpression="LastModified" HeaderStyle-Width="20%" />
                                            <asp:TemplateField HeaderText="Actions" HeaderStyle-Width="10%" >
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="btnEditJob" runat="server" CommandName="Edit" Text="Edit Job" ImageUrl="~/Images/item_edit.png" ToolTip="Edit Job"/>&nbsp;&nbsp;&nbsp;
                                                    <asp:ImageButton ID="btnRemoveJob" runat="server" CommandName="Delete" Text="Remove Job" ImageUrl="~/Images/item_remove.png" ToolTip="Inactivate Job"/>&nbsp;&nbsp;&nbsp;
                                                    <ajaxToolkit:ConfirmButtonExtender ID="cbeRemoveJob" runat="server" 
                                                        TargetControlID="btnRemoveJob"
                                                        ConfirmText="Are you sure you want to Inactivate this Job?" 
                                                        OnClientCancel="cancelClick" />
                                                    <asp:ImageButton ID="btnAddViewComment" runat="server" CommandName="Select" Text="Add / View Comments" ImageUrl="~/Images/comments.png" ToolTip="Add / View Comments"/>&nbsp;&nbsp;&nbsp;
                                                    <asp:ImageButton ID="btnShowReport" runat="server" CommandName="Report" CommandArgument='<%# Bind("JobID") %>' Text="Show Job Products Report" ImageUrl="~/Images/show_report.png" ToolTip="Show Job Products Report"/>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <HeaderStyle CssClass="Header2" Font-Bold="True"></HeaderStyle>
                                        <PagerStyle BackColor="DarkGray" ForeColor="White" HorizontalAlign="Center" />
                                    </asp:GridView>
                                    <asp:SqlDataSource ID="sqldsJobSearch" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                        SelectCommand="Call GetJobSearch(?,?,?)" SelectCommandType="StoredProcedure" DeleteCommand="Call DeleteJob(?)" DeleteCommandType="StoredProcedure">
                                        <SelectParameters>
                                            <asp:Parameter Name="JobID" Type="String" DefaultValue="" />
                                            <asp:Parameter Name="JobDesc" Type="String" DefaultValue="" />
                                            <asp:Parameter Name="JobBarcode" Type="String" DefaultValue="" />
                                        </SelectParameters>
                                        <DeleteParameters>
                                            <asp:Parameter Name="JobID" Type="String" DefaultValue="" />
                                        </DeleteParameters>
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







