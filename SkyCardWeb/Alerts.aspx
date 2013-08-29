<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="Alerts.aspx.vb" Inherits="Alerts" title="Alerts" %>

<asp:Content ID="Content3" ContentPlaceHolderID="cphError" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
   <asp:ScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server" />

                <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" >
                                        Alerts
                                    </td>
                                </tr>
                               
                                <tr valign="top">
                                    <td style="width:15%">
                                        <asp:Button ID="btnContinue" runat="server" Text="Asset Search" />
                                    </td>
                                    
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>

                
                
              
                
                 <asp:SqlDataSource ID="sqldsMinOrReorder" runat="server"
                    ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="call GetNumBelowMinOrReorder(?)" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="TheParm" Type="Int32" DefaultValue="1" />
                    </SelectParameters>
                </asp:SqlDataSource>
</asp:Content>

