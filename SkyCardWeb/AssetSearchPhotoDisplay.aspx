<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="AssetSearchPhotoDisplay.aspx.vb" Inherits="AssetSearchPhotoDisplay" title="Photo Search" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content3" ContentPlaceHolderID="cphError" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>

                <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Search Assets by Photo
                                    </td>
                                    <asp:HiddenField ID="hfdTagNumber" runat="server" />
                                </tr>
                               
                               
                             
                                 <tr>
                                    <td>
                                        <asp:ListView ID="ListView1" GroupItemCount="8" runat="server" DataKeyNames="photoid"
                                        DataSourceID="sqldsPhotos">
                                            <LayoutTemplate>
                                                <asp:Placeholder
                                                id="groupPlaceholder"
                                                runat="server" />
                                            </LayoutTemplate>
                                            <GroupTemplate>
                                                <div>
                                                <asp:Placeholder
                                                id="itemPlaceholder"
                                                runat="server" />
                                                </div>
                                            </GroupTemplate>
                                            <ItemTemplate>
                                                
                                                <asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl='<%# Eval("tagnumber", "EditAsset.aspx?Tag={0}") %>' >
                                                    <asp:Image
                                                        id="picAlbum" runat="server" AlternateText='<% #Eval("tagnumber") %>'
                                                        ImageUrl='<%# "ShowImage.ashx?id=" + Convert.ToString(Eval("photoid")) %>'  ToolTip='<% #Eval("thedesc") %>' />
                                                </asp:HyperLink>
                                                
                                            </ItemTemplate>
                                            <EmptyDataTemplate>           
                                                <asp:Label ID="Label1" runat="server" Text="Search produced no results." Font-Bold="True"></asp:Label>
                                            </EmptyDataTemplate>
                                        </asp:ListView>
                                    </td>
                                 </tr>
                            </table>
                        </td>
                    </tr>
                </table>

              
                
                
                <asp:SqlDataSource ID="sqldsPhotos" runat="server"
                    ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetAssetReportPhotos(?,?)" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="WhereClause" Type="String" />
                         <asp:Parameter Name="BuildingLocID" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
</asp:Content>

