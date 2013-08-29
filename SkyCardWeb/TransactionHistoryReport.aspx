<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="TransactionHistoryReport.aspx.vb" Inherits="TransactionHistoryReport" title="Assets By Location Report" %>

<%@ Register Assembly="DevExpress.XtraReports.v10.2.Web" Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>
<script type="text/javascript" language="javascript">
// <!--

    function onKeySignin() 
    {
    if (window.event.keyCode == 13)
        {
        document.getElementById('<%=btnRunReport.ClientID%>').focus();
        document.getElementById('<%=btnRunReport.ClientID%>').click();
        }
    }

    document.attachEvent("onkeydown", onKeySignin);

// -->
</script>   
   
    <asp:HiddenField ID="hfdFirstTime" runat="server" Value="0" />

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Transaction History Report
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td width="100%" class="tableCaptionLabel" >
                                        <table width="100%" border="0">
                                            <tr>
                                                <td align="left" width="20%">
                                                    <asp:Button ID="btnReturn" runat="server" Text="Return" Width="80px"  />
                                                </td>
                                                <td align="right" width="80%">
                                                    <table border="0">
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="Label3" runat="server" Text="Enter From Date:"></asp:Label>&nbsp;
                                                                <asp:TextBox ID="txtFromDate" runat="server" CssClass="dControl" Font-Size="Small" Width="100px" MaxLength="10" ToolTip="Enter a beginning date for the date range." ></asp:TextBox>
                                                                <ajaxToolkit:CalendarExtender ID="calFromDate" runat="server" TargetControlID="txtFromDate" Format="MM/dd/yyyy" PopupButtonID="imgFromDateCalendarIcon" />
                                                                <asp:ImageButton runat="Server" ID="imgFromDateCalendarIcon" ImageUrl="~/Images/Calendar.gif" AlternateText="Click to show calendar"/>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label1" runat="server" Text="Show History for This User:"></asp:Label>
                                                                <asp:SqlDataSource ID="sqldsUsers" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                                    SelectCommand="GetAllSystemUsers" SelectCommandType="StoredProcedure">
                                                                </asp:SqlDataSource>
                                                                <asp:DropDownList ID="UserNames" runat="server" AutoPostBack="True" AppendDataBoundItems="True" 
                                                                        DataTextField="Username" DataValueField="Username" >
                                                                        <asp:ListItem Selected="True" Text="All" Value="All"></asp:ListItem>
                                                                </asp:DropDownList>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="Label4" runat="server" Text="Enter End Date:"></asp:Label>&nbsp;
                                                                <asp:TextBox ID="txtEndDate" runat="server" CssClass="dControl" MaxLength="10" Font-Size="Small" Width="100px" ToolTip="Enter an end date for the date range." ></asp:TextBox>
                                                                <ajaxToolkit:CalendarExtender ID="calEndDate" runat="server" TargetControlID="txtEndDate" Format="MM/dd/yyyy" PopupButtonID="imgEndDateCalendarIcon"  />
                                                                <asp:ImageButton runat="Server" ID="imgEndDateCalendarIcon" ImageUrl="~/Images/Calendar.gif" AlternateText="Click to show calendar"/>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label2" runat="server" Text="Show History for Tag Number:"></asp:Label>&nbsp;
                                                                <asp:SqlDataSource ID="sqldsCase" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                                    SelectCommand="GetCaseList" SelectCommandType="StoredProcedure">
                                                                </asp:SqlDataSource>
                                                                <asp:DropDownList ID="ddlCaseID" runat="server" AutoPostBack="True" AppendDataBoundItems="True" 
                                                                        DataTextField="Casenumber" DataValueField="Casenumber" >
                                                                        <asp:ListItem Selected="True" Text="All" Value="All"></asp:ListItem>
                                                                </asp:DropDownList>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>&nbsp;
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label5" runat="server" Text="TagNumber Sort:"></asp:Label>&nbsp;
                                                                <asp:RadioButtonList ID="rblTagNumberSortOrder" runat="server" 
                                                                    RepeatDirection="Horizontal" RepeatLayout="Flow">
                                                                    <asp:ListItem Text="Asc" Value="Asc" Selected="True"></asp:ListItem>
                                                                    <asp:ListItem Text="Desc" Value="Desc" ></asp:ListItem>
                                                                </asp:RadioButtonList>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>&nbsp;
                                                            </td>
                                                            <td>
                                                                 <asp:Button ID="btnRunReport" runat="server" Text="Run Report" Width="100px"  />
                                                            </td>
                                                        </tr>
                                                    </table> 
                                                </td>
                                            </tr>



                                        </table>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td width="100%" align="center" >
                                    
                                    
                                        <asp:Panel ID="pnlReport" runat="server" Width="100%" >
                                            <dxxr:ReportToolbar ID="ReportToolbar1" runat='server' 
                                                ShowDefaultButtons='False' ReportViewer="<%# rptvwrOrders %>" Width="100%">
                                                <Items>
                                                    <dxxr:ReportToolbarButton ItemKind='Search' />
                                                    <dxxr:ReportToolbarSeparator />
                                                    <dxxr:ReportToolbarButton ItemKind='PrintReport' />
                                                    <dxxr:ReportToolbarButton ItemKind='PrintPage' />
                                                    <dxxr:ReportToolbarSeparator />
                                                    <dxxr:ReportToolbarButton Enabled='False' ItemKind='FirstPage' />
                                                    <dxxr:ReportToolbarButton Enabled='False' ItemKind='PreviousPage' />
                                                    <dxxr:ReportToolbarLabel ItemKind='PageLabel' />
                                                    <dxxr:ReportToolbarComboBox ItemKind='PageNumber' Width='65px'>
                                                    </dxxr:ReportToolbarComboBox>
                                                    <dxxr:ReportToolbarLabel ItemKind='OfLabel' />
                                                    <dxxr:ReportToolbarTextBox IsReadOnly='True' ItemKind='PageCount' />
                                                    <dxxr:ReportToolbarButton ItemKind='NextPage' />
                                                    <dxxr:ReportToolbarButton ItemKind='LastPage' />
                                                    <dxxr:ReportToolbarSeparator />
                                                    <dxxr:ReportToolbarButton ItemKind='SaveToDisk' />
                                                    <dxxr:ReportToolbarButton ItemKind='SaveToWindow' />
                                                    <dxxr:ReportToolbarComboBox ItemKind='SaveFormat' Width='70px'>
                                                        <Elements>
                                                            <dxxr:ListElement Value='pdf' />
                                                            <dxxr:ListElement Value='xls' />
                                                            <dxxr:ListElement Value='xlsx' />
                                                            <dxxr:ListElement Value='rtf' />
                                                            <dxxr:ListElement Value='mht' />
                                                            <dxxr:ListElement Value='txt' />
                                                            <dxxr:ListElement Value='csv' />
                                                            <dxxr:ListElement Value='png' />
                                                        </Elements>
                                                    </dxxr:ReportToolbarComboBox>
                                                </Items>
                                                <Styles>
                                                    <LabelStyle>
                                                        <Margins MarginLeft='3px' MarginRight='3px' />
                                                    </LabelStyle>
                                                </Styles>
                                            </dxxr:ReportToolbar>

                                            <dxxr:ReportViewer ID="rptvwrOrders" runat="server">
                                            </dxxr:ReportViewer>
                                            
                                        </asp:Panel>
                                    
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>








</asp:Content>

