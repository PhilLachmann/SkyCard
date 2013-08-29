﻿<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="MP2Report.aspx.vb" Inherits="MP2Report" title="MP2 Report" %>

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
                                        MP2 Report
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

