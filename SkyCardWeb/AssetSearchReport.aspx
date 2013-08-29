<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="AssetSearchReport.aspx.vb" Inherits="AssetSearchReport" title="Asset Report" %>

<%@ Register Assembly="DevExpress.XtraReports.v10.2.Web" Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>
<%@ Register Assembly="DevExpress.Web.v10.2" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dxxr" %>
<%@ Register Assembly="DevExpress.Web.v10.2" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dxxr" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v10.2" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxxr" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <table width="100%">
        <tr>
            <td colspan="4" align="center" class="PageHeaderText">
                <asp:Label ID="lblPageHeaderText" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" >

                            <asp:Panel ID="pnlReport" runat="server" Width="100%" Visible="True" >
                                <dxxr:ReportToolbar ID="ReportToolbar1" runat='server' 
                                    ShowDefaultButtons='False' ReportViewer="<%# rptvwrReport %>" Width="100%">
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

                                <dxxr:ReportViewer ID="rptvwrReport" runat="server" Report="<%#New ReportAssetList()%>" AutoSize="False" Width="100%" Height="100%" CssClass="viewerColors" >
                                </dxxr:ReportViewer>
                                
                            </asp:Panel>

            
            
            </td>
        </tr>
        
        
        
        
    </table>



</asp:Content>

