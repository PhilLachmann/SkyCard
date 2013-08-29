<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="RptBackOrders.aspx.vb" Inherits="RptBackOrders" title="Back Order Report" %>

<%@ Register Assembly="DevExpress.XtraReports.v10.2.Web" Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>
    <asp:HiddenField ID="hfdFirstTime" runat="server" Value="0" />

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Back Order Report
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
                                                
                                                    &nbsp;<asp:Label ID="Label1" runat="server" Text="Show Orders For This Job:"></asp:Label>
                                                    <asp:SqlDataSource ID="sqldsJobList" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                        SelectCommand="Call GetJobList()" SelectCommandType="StoredProcedure">
                                                    </asp:SqlDataSource>
                                                    <asp:DropDownList ID="JobID" runat="server" AutoPostBack="True" AppendDataBoundItems="True" 
                                                            DataTextField="JobDesc" DataValueField="JobID" >
                                                            <asp:ListItem Selected="True" Text="All" Value=""></asp:ListItem>
                                                    </asp:DropDownList>&nbsp;&nbsp;
                                                   
                                                    <asp:Button ID="btnRunReport" runat="server" Text="Run Report" Width="100px"  />
                                                    
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" width="20%">&nbsp;
                                                </td>
                                                <td align="right" width="80%">
                                                    &nbsp;<asp:Label ID="Label2" runat="server" Text="For This Date Range:"></asp:Label>
                                                    <asp:TextBox ID="txtStartDate" runat="server" Width="70px" AutoPostBack="True" ></asp:TextBox>
                                                    <ajaxToolkit:CalendarExtender ID="calStartDate" runat="server" TargetControlID="txtStartDate" Format="MM/dd/yyyy" PopupButtonID="imgStartDateCalendarIcon" />
                                                    <asp:ImageButton runat="Server" ID="imgStartDateCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar"/>&nbsp;&nbsp;
                                                    
                                                    <asp:Label ID="Label4" runat="server" Text=" To "></asp:Label>
                                                     <asp:TextBox ID="txtEndDate" runat="server" Width="70px" AutoPostBack="True" ></asp:TextBox>
                                                    <ajaxToolkit:CalendarExtender ID="calEndDate" runat="server" TargetControlID="txtEndDate" Format="MM/dd/yyyy" PopupButtonID="imgEndDateCalendarIcon" />
                                                    <asp:ImageButton runat="Server" ID="imgEndDateCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar"/>&nbsp;&nbsp;

                                                    <asp:Label ID="lblSpacer1" runat="server" Text=" " Width="100px" ></asp:Label>
                                                </td>
                                            </tr>

                                            <tr>
                                                <td align="left" width="20%">&nbsp;
                                                </td>
                                                <td align="right" width="80%">
                                                    &nbsp;<asp:Label ID="Label3" runat="server" Text="That Are in This Status:"></asp:Label>

                                                    <asp:SqlDataSource ID="sqldsOrderStatusList" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                        SelectCommand="Call GetBackOrderStatusList()" SelectCommandType="StoredProcedure">
                                                    </asp:SqlDataSource>
                                                    <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="True" AppendDataBoundItems="True" 
                                                            DataTextField="OrderStatus" DataValueField="OrderStatus" >
                                                            <asp:ListItem Selected="True" Text="All" Value=""></asp:ListItem>
                                                    </asp:DropDownList>&nbsp;&nbsp;



                                                    <asp:Label ID="Label6" runat="server" Text=" " Width="100px" ></asp:Label>
                                                </td>
                                            </tr>


                                        </table>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td width="100%" align="center" >
                                    
                                    
                                        <asp:Panel ID="pnlReport" runat="server" Width="100%" >
                                            <dxxr:ReportToolbar ID="ReportToolbar1" runat='server' 
                                                ShowDefaultButtons='False' ReportViewer="<%# rptvwrBackOrders %>" Width="100%">
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

                                            <dxxr:ReportViewer ID="rptvwrBackOrders" runat="server">
                                            </dxxr:ReportViewer>
                                            
                                        </asp:Panel>
                                    
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>








</asp:Content>

