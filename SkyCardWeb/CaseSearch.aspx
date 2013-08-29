<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="CaseSearch.aspx.vb" Inherits="CaseSearch" title="Case Search" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content5" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>
    
      <table class="TabPanelTable" width="100%">
                    <tr style="vertical-align: top; height: 15px;">
                        <td colspan="3" style="vertical-align: top; height: 0px; width: 100%; text-align: center;">
                        </td>
                    </tr>
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr valign="top">
                                    <td>
                                        <table cellpadding="3" cellspacing="1" border="1" width="100%">
                                            <tr valign="top">
                                                <td class="tableCaptionLabel" colspan="6" align="center">
                                                    Case Search
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Header2" width="15%">
                                                    Search By
                                                </td>
                                                <td class="Header2" width="35%">
                                                    Search Criteria
                                                </td>
                                                <td class="Header2" width="15%">
                                                    Search By
                                                </td>
                                                <td class="Header2" width="35%">
                                                    Search Criteria
                                                </td>
                                            </tr>
                                            <tr valign="top">
                                                <td align="left">
                                                    Case Number</td>
                                                <td align="left">
                                                    
                                                    <asp:TextBox ID="tbCaseNum" runat="server" Width="189px"></asp:TextBox>
                                                </td>
                                                <td align="left">
                                                    Defendant
                                                </td>
                                                <td align="left">
                                                   
                                                    <asp:TextBox ID="tbDefName" runat="server" Width="189px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            
                                                                                        
                                    </table>



                                    <table cellspacing="1" cellpadding="1" width="100%" border="1">
                                        <tbody>
                                            <tr>
                                                <td style="width: 25%" class="Record">
                                                    <asp:Button ID="btnSearch" runat="server" Text="Search Cases"></asp:Button>
                                                </td>
                                                <td style="width: 25%" class="Record">
                                                    <asp:Button ID="btnClear" runat="server" Text="Clear Criteria/Results"></asp:Button>
                                                </td>
                                                <td style="width: 25%" class="Record">
                                                    &nbsp;</td>
                                                <td style="width: 25%" align="center">
                                                    &nbsp;</td>
                                            </tr>
                                        </tbody>
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
                                    <asp:GridView ID="gvSearchResults" runat="server" Width="100%" AllowSorting="True" HeaderStyle-CssClass="Header2"
                                        AllowPaging="True" PageSize="15" EmptyDataText="There are no Claims in the system that match the above criteria."
                                        AutoGenerateColumns="False" CellPadding="4" DataKeyNames="CaseNumber" ForeColor="#333333"
                                        GridLines="Vertical">
                                        <EmptyDataTemplate>
                                            No Data Found for the Given Criteria
                                        </EmptyDataTemplate>
                                        <AlternatingRowStyle CssClass="gvRowDataAlt"></AlternatingRowStyle>
                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <RowStyle CssClass="gvRowData"></RowStyle>
                                        <Columns>
                                            <asp:BoundField DataField="CaseNumber" HeaderText="Case Num" InsertVisible="False"
                                                ReadOnly="True" SortExpression="CaseNumber" Visible="true"  HeaderStyle-Width="10%" ItemStyle-HorizontalAlign="Left" ItemStyle-VerticalAlign="Top" />
                                            <asp:BoundField DataField="DefendantName" HeaderText="Defendant Name" SortExpression="DefendantName" HeaderStyle-Width="10%" ItemStyle-HorizontalAlign="Left" ItemStyle-VerticalAlign="Top" />
                                            <asp:TemplateField HeaderText="Date Initiated" HeaderStyle-Width="10%" SortExpression="DateInitiated" ItemStyle-VerticalAlign="Top" >
                                                <ItemTemplate>
                                                    <asp:Label ID="DateInitiated" runat="server" Text='<%# Eval("DateInitiated", "{0:d}") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            
                                            <asp:TemplateField HeaderText="Actions" HeaderStyle-Width="10%" ItemStyle-VerticalAlign="Middle" >
                                                <ItemTemplate>
                                                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="View / Edit"
                                                        Width="80px" />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <HeaderStyle CssClass="Header2" Font-Bold="True"></HeaderStyle>
                                        
                                        
                                    </asp:GridView>



                                    <asp:SqlDataSource ID="sqldsSearch" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                        SelectCommand="GetCaseSearch" SelectCommandType="StoredProcedure">
                                        <SelectParameters>
                                            <asp:Parameter Name="CaseNumber" Type="String" DefaultValue="" />
                                            <asp:Parameter Name="Defendant" Type="String" DefaultValue="" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                </td>
                            </tr>
                        </tbody>
                    </table>

                    </td>
                </tr>
        </table>

    </asp:Content>







