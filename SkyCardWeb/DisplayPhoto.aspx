<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="DisplayPhoto.aspx.vb" Inherits="DisplayPhoto" title="Edit Asset" %>
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
                                    <td align="center" width="100%" class="tableCaptionLabel">
                                        View Photo
                                    </td>
                                    <asp:HiddenField ID="hfdTagNumber" runat="server" />
                                </tr>
                                  <tr valign="top">
                                    <td width="100%" class="tableCaptionLabel" >
                                        <table width="100%" border="0">
                                            <tr>
                                                <td align="left">
                                                    <asp:Button ID="btnBack" runat="server" Text="Back"   />
                                                </td>
                                                <td align="right" width="80%">
                                                    <table border="0">
                                                                                                                
                                                        <tr>
                                                            <td>&nbsp;
                                                            </td>
                                                            <td>
                                                                 <asp:Button ID="btnDeletePhoto" runat="server" Text="Delete Photo" Width="100px" Visible=false  />
                                                                 
                                                                 <asp:Panel ID="PanelPopup" runat="server" CssClass="ModalWindow" Width="350" Height="100" style="display:none;" BorderColor="ActiveBorder"  BorderStyle="Double" BorderWidth="2px">
                                                                    <table border="0" width="100%">
                                                                        <tr>
                                                                            <td align="center" colspan="2">
                                                                                <asp:Label ID="Label10" runat="server" Text="Are you sure that you want to delete this item?" ForeColor="Black"></asp:Label>
                                                                             </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="left">
                                                                                <br /><br />
                                                                                <asp:Button ID="ButtonOK" runat="server" UseSubmitBehavior="False" Text="Yes. Delete this item." />
                                                                            </td>
                                                                            <td align="right">
                                                                                <br /><br />
                                                                                <asp:Button ID="ButtonCancel" runat="server" UseSubmitBehavior="False" Text="Cancel" />
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                            
                                                                </asp:Panel>

                                                                <ajaxtoolkit:ModalPopupExtender 
                                                                    ID="ModalPopupExtender1" 
                                                                    runat="server" 
                                                                    BackgroundCssClass="modalBackground"
                                                                    PopupControlID="PanelPopup"
                                                                    TargetControlID="btnDeletePhoto"
                                                                    OkControlID="ButtonOK"
                                                                    CancelControlID="ButtonCancel">
                                                                </ajaxtoolkit:ModalPopupExtender>
                                                            </td>
                                                        </tr>
                                                    </table> 
                                                </td>
                                            </tr>



                                        </table>
                                    </td>
                                </tr>                                
                          
                                 <tr>
                                    <td>
                                        <asp:ListView ID="ListView1" GroupItemCount="4" runat="server" DataKeyNames="photoid"
                                        DataSourceID="SqlDataSource1">
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
                                                
                                                <asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl='<%# Eval("photoid", "DisplayPhoto.aspx?ID={0}") %>'   >
                                                    <asp:Image
                                                        id="picAlbum" runat="server" AlternateText='<% #Eval("theDescription") %>'
                                                        ImageUrl='<%# "ShowImageFullSize.ashx?id=" + Convert.ToString(Eval("photoid")) %>'  />
                                                </asp:HyperLink>
                                            </ItemTemplate>
                                            <EmptyItemTemplate>           
                                               
                                            </EmptyItemTemplate>
                                        </asp:ListView>
                                    </td>
                                 </tr>
                            </table>
                        </td>
                    </tr>
                </table>

                

                
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                    ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommandType="StoredProcedure" SelectCommand="call GetOriginalImageInfo(?)" 
                    DeleteCommandType="StoredProcedure" DeleteCommand="call DeleteAssetPhoto(?,?)">
                    <SelectParameters>
                         <asp:Parameter Name="ID" Type="Int32" DefaultValue="0" />
                    </SelectParameters>
                    <DeleteParameters>
                        <asp:Parameter Name="PhotoID" Type="Int32" DefaultValue="-1" />
                        <asp:Parameter Name="theUser" Type="string" DefaultValue="0" />
                    </DeleteParameters>
                </asp:SqlDataSource>
                
                <asp:SqlDataSource ID="sqldsTag" runat="server"
                    ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>" 
                    SelectCommandType="StoredProcedure" SelectCommand="call GetTagNumberFromPhotoID(?)">
                    <SelectParameters>
                         <asp:Parameter Name="ID" Type="Int32" DefaultValue="0" />
                    </SelectParameters>
                   
                </asp:SqlDataSource>
</asp:Content>

