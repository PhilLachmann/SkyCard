﻿<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="SearchContactMaster.aspx.vb" Inherits="SearchContactMaster" title="Case Management" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content5" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" EnablePartialRendering="true" runat="server"/>
    <table cellspacing="0" cellpadding="0" width="100%" border="0" class="TableSearch">
        <tbody>
            <tr>
                <td>
                    <table cellspacing="1" cellpadding="1" width="100%" border="1">
                        <tbody>
                            <tr>
                                <td class="tableCaptionLabel" colspan="6" align="center">
                                    Contact Search
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
                                    <asp:Label ID="Label10" runat="server" Text="Contact Name"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="txtContactName" runat="server" CssClass="dControl" Width="75%" MaxLength="200"></asp:TextBox>
                                </td>
                                <td align="left">
                                    <asp:Label ID="Label2" runat="server" Text="Contact Alias"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="txtContactAlias" runat="server" CssClass="dControl" Width="75%" MaxLength="200"></asp:TextBox>
                                </td>
                            </tr>
                            
                            
                        </tbody>
                    </table>
                    <table cellspacing="1" cellpadding="1" width="100%" border="1">
                        <tbody>
                            <tr>
                                <td align="center" style="width: 50%;">
                                    <asp:Button ID="btnSearch" runat="server" Text="Search / List Contacts"></asp:Button>
                                </td>
                                <td align="center" style="width: 50%">
                                    <asp:Button ID="btnClearCriteria" runat="server" Text="Clear Criteria/Results"></asp:Button>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <asp:Label ID="Label4" runat="server" Text="" Height="30px"></asp:Label>
                    &nbsp;&nbsp;&nbsp;<asp:ImageButton ID="btnAddItem" runat="server" CommandName="Insert" Text="Add New Contact" ImageUrl="~/Images/addnew.png" ToolTip="Add New Contact"/>&nbsp;&nbsp;&nbsp;

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
                                        AllowPaging="True" PageSize="15" EmptyDataText="There are no Contacts in the system that match the above criteria."
                                        AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ContactID" ForeColor="#333333"
                                        GridLines="Vertical">
                                        <AlternatingRowStyle CssClass="gvRowDataAlt"></AlternatingRowStyle>
                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <PagerSettings Mode="NextPreviousFirstLast" FirstPageImageUrl="Images/resultset_first.png"
                                            FirstPageText="First" LastPageImageUrl="Images/resultset_last.png" LastPageText="Last"
                                            NextPageImageUrl="Images/resultset_next.png" NextPageText="Next" PreviousPageImageUrl="Images/resultset_previous.png"
                                            PreviousPageText="Previous"></PagerSettings>
                                        <RowStyle CssClass="gvRowData"></RowStyle>
                                        <Columns>
                                            <asp:BoundField DataField="ContactName" HeaderText="Contact Name" SortExpression="ContactName" HeaderStyle-Width="20%" />
                                            <asp:BoundField DataField="City" HeaderText="Contact City" SortExpression="ContactCity" HeaderStyle-Width="10%" />
                                            <asp:BoundField DataField="State" HeaderText="Contact State" SortExpression="ContactState" HeaderStyle-Width="10%" />
                                            <asp:BoundField DataField="Zip" HeaderText="Contact Zip Code" SortExpression="ContactZipCode" HeaderStyle-Width="10%" />
                                            <asp:TemplateField HeaderText="Contact Phone" HeaderStyle-Width="10%" >
                                                <ItemTemplate>
                                                    <asp:Label ID="Label6" runat="server" Text='<%# Utilities.FormatPhone(Container.DataItem("Phone1")) %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="Email1" HeaderText="Contact Email" SortExpression="ContactEmail" HeaderStyle-Width="10%" />
                                            <asp:TemplateField HeaderText="Actions" HeaderStyle-Width="10%" >
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="btnEditItem" runat="server" CommandName="Edit" Text="Edit Item" ImageUrl="~/Images/item_edit.png" ToolTip="Edit Contact"/>&nbsp;&nbsp;&nbsp;
                                                    <asp:ImageButton ID="btnRemoveItem" runat="server" CommandName="Delete" CommandArgument="<%# Container.DataItemIndex %>" Text="Remove Item" ImageUrl="~/Images/item_remove.png" ToolTip="Remove Contact"/>&nbsp;&nbsp;&nbsp;
                                                    <ajaxToolkit:ConfirmButtonExtender ID="cbeRemoveItem" runat="server" 
                                                        TargetControlID="btnRemoveItem"
                                                        ConfirmText="Are you sure you want to Delete this Contact?" 
                                                        OnClientCancel="cancelClick" />
                                                    <asp:ImageButton ID="btnAddViewComment" runat="server" CommandName="Select" Text="Add / View Comments" ImageUrl="~/Images/comments.png" ToolTip="Add / View Comments"/>&nbsp;&nbsp;&nbsp;
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <HeaderStyle CssClass="Header2" Font-Bold="True"></HeaderStyle>
                                        <PagerStyle BackColor="#E4D0AD" ForeColor="White" HorizontalAlign="Center" />
                                    </asp:GridView>
                                    <asp:SqlDataSource ID="sqldsItemSearch" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                                        SelectCommand="GetContactMasterSearch" SelectCommandType="StoredProcedure"
                                         UpdateCommand="DeleteContactMaster" UpdateCommandType="StoredProcedure"
                                        DeleteCommand="XXXX" DeleteCommandType="StoredProcedure" >
                                        <SelectParameters>
                                            <asp:Parameter Name="ContactName" Type="String" DefaultValue=" " />
                                            <asp:Parameter Name="AliasName" Type="String" DefaultValue=" "/>
                                       </SelectParameters>
                                        <DeleteParameters>
                                            <asp:Parameter Name="ContactName" Type="String"  />
                                            <asp:Parameter Name="AliasName" Type="String" />
                                      </DeleteParameters>
                                        <UpdateParameters>
                                            <asp:Parameter Name="ID" Type="Int32" DefaultValue="0" />
                                            <asp:Parameter Name="UserID" Type="String" DefaultValue="" />
                                        </UpdateParameters>
                                    </asp:SqlDataSource>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>

    <asp:SqlDataSource ID="sqldsStateList" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
       SelectCommand="GetStates" SelectCommandType="StoredProcedure">
    </asp:SqlDataSource>



</asp:Content>







