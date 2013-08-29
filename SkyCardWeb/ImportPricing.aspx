<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="ImportPricing.aspx.vb" Inherits="ImportPricing" title="Import Pricing" %>

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
                                    Import Pricing CSV File
                                </td>
                            </tr>
                            <tr>
                                <td align="center" >
                                    <asp:Button ID="btnProcessImport" runat="server" Text="Process Pricing CSV File" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            
             <asp:SqlDataSource ID="sqldsLookupTableData" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                InsertCommand="Call Import_Price_main()" InsertCommandType="StoredProcedure">
            </asp:SqlDataSource>
            


</asp:Content>

