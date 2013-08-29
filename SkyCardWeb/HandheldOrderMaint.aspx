<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="HandheldOrderMaint.aspx.vb" Inherits="HandheldOrderMaint" title="Update Order Maintenance HandheldID" %>

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
                                    Import Products From Harrison
                                </td>
                            </tr>
                            <tr>
                                <td align="center" >&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td align="center" >
                                    <asp:Label ID="Label1" runat="server" Text="Handheld ID of Unit to Pull Orders"></asp:Label>
                                    <asp:TextBox ID="txtHandheldID" runat="server" Text=''></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" >&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td align="center" >
                                    <asp:Button ID="btnUpdateHandheld" runat="server" Text="Update Handheld ID" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            
             <asp:SqlDataSource ID="sqldsLookupTableData" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                SelectCommand="Call GetHandheldOrderMaintID()" SelectCommandType="StoredProcedure"
                UpdateCommand="Call UpdateHandheldOrderMaintID(?,?)" UpdateCommandType="StoredProcedure">
                <UpdateParameters>
                     <asp:Parameter Name="HandheldID" Type="String" />
                     <asp:Parameter Name="ModifiedBy" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
            


</asp:Content>

