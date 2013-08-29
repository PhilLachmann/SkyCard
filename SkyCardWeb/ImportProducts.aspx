<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="ImportProducts.aspx.vb" Inherits="ImportProducts" title="Import Products" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register TagPrefix="CuteWebUI" Namespace="CuteWebUI" Assembly="CuteWebUI.AjaxUploader" %> 

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>

            <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />

            <table class="TabPanelTable">
                <tr style="vertical-align: top;">
                    <td>
                        <table cellpadding="3" cellspacing="1" border="0" width="100%">
                            <tr>
                                <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                    Import Products From CSV File
                                </td>
                            </tr>
                            <tr>
                                
                                <td>
                                    <div>
                                        &nbsp;Select CSV File:
                                        <asp:FileUpload ID="FileUploader" runat="server" />
                                        <br />
                                        <br />
                                        <asp:Button ID="UploadButton" runat="server" Text="Import Selected CSV" OnClick="UploadButton_Click" /><br />
                                        <br />
                                        <asp:Label ID="Label1" runat="server"></asp:Label>
                                        <br />
                                        <asp:LinkButton ID="lbDownload" runat="server">Download Empty CSV</asp:LinkButton>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            
            <table class="TabPanelTable">
                <tr style="vertical-align: top;">
                    <td>
                        <table cellpadding="3" cellspacing="1" border="0" width="100%">
                            <tr>
                                <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                    Import Picture Files
                                </td>
                            </tr>
                            <tr>
                                
                                <td>
                                    <div class="content">
                                        
                                        <p>
                                            Select multiple files in the file browser dialog then upload them at once.</p>
                                        <p>
                                            Filenames should be in the format "Barcode ZZZZZ (Y).jpg" where ZZZZ is the barcode number. (ex. "Barcode 12345 (1).jpg")
                                            </p>
                                        <CuteWebUI:Uploader runat="server" ID="Uploader1" InsertText="Select Files to Upload"
                                            MultipleFilesUpload="true" >
                                            <ValidateOption MaxSizeKB="10240" />
                                        </CuteWebUI:Uploader>
                                        <p>
                                            Messages:
                                            <br />
                                            <asp:ListBox runat="server" ID="ListBoxEvents" Width="33%" />
                                        </p>
                                       
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            
             <asp:SqlDataSource ID="sqldsLookupTableData" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                SelectCommand="Call ImportAssetRecordsFromWeb(?,?)" SelectCommandType="StoredProcedure">
                <SelectParameters>
                     <asp:Parameter Name="theFileName" Type="String" />
                     <asp:Parameter Name="theUser" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            

             <asp:SqlDataSource ID="sqldsPhotos" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    InsertCommand="Call UploadPhoto(?,?,?)" InsertCommandType="StoredProcedure"  >
                    <InsertParameters>
                         <asp:Parameter Name="TagName" Type="String" />
                         <asp:Parameter Name="OriginalPhoto"  />
                         <asp:Parameter Name="ThumbnailPhoto"  />
                    </InsertParameters>
             </asp:SqlDataSource>
             
              <asp:SqlDataSource ID="sqldsTranHistory" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    InsertCommand="Call InsertTransHistory(?,?,?)" InsertCommandType="StoredProcedure"  >
                    <InsertParameters>
                         <asp:Parameter Name="Description" Type="String" />
                         <asp:Parameter Name="TheUser" Type="String" />
                         <asp:Parameter Name="TheTag" Type="String" />
                    </InsertParameters>
              </asp:SqlDataSource>
</asp:Content>

