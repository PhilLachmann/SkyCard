<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="EditAsset.aspx.vb" Inherits="EditAsset" title="Edit Asset" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content3" ContentPlaceHolderID="cphError" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>
                
                
               
                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                            
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel">
                                        <asp:Label ID="Caption" runat="server" Text="Edit Asset"></asp:Label>
                                    </td>
                                    <asp:HiddenField ID="hfdTagNumber" runat="server" />
                                </tr>
                               
       
                                <tr>
                                    <td align="left">
                                        <table border="0" width="100%">
                                            <tr>
                                                <td align="left" width="20%">
                                                     <asp:Label ID="Label1" runat="server" Text="Enter Asset Barcode Number to Edit" ></asp:Label>
                                                </td>
                                                <td align="center" width="60%">
                                                     <asp:Label ID="lblSoldDate" runat="server" Text="Asset Sold via Auction On" ForeColor="Firebrick" Visible="false"></asp:Label>
                                                </td>
                                                <td align="right" width="20%">
                                                    <asp:Panel ID="Panel1" runat="server">
                                                        <asp:Button ID="btnDeleteAsset" runat="server" Text="Delete Asset" Enabled="false" Visible="false" />
                                                        
                                                        <asp:Panel ID="PanelPopup" runat="server" CssClass="ModalWindow" Width="350" Height="100" style="display:none;" BorderColor="ActiveBorder"  BorderStyle="Double" BorderWidth="2px">
                                                            <table border="0" width="100%">
                                                                <tr>
                                                                    <td align="center" colspan="2">
                                                                        <asp:Label ID="Label10" runat="server" Text="Are you sure that you want to delete this item?"></asp:Label>
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
                                                            TargetControlID="btnDeleteAsset"
                                                            OkControlID="ButtonOK"
                                                            CancelControlID="ButtonCancel">
                                                        </ajaxtoolkit:ModalPopupExtender>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left">
                                    <asp:Panel runat="server" ID="pnlEnter" DefaultButton="btnSubmit" >
                                        <asp:TextBox ID="tbAssetTagNumber"  runat="server"></asp:TextBox>
                                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                                     </asp:Panel>
                                    </td>
                                   
                                </tr>
                                
                                <tr>
                                    <td>
                                        <asp:UpdatePanel ID="UpdatePanel1" UpdateMode="Conditional" runat="server" >
                                        <ContentTemplate>
                                        <asp:Panel ID="pnlLocation" runat="server" Visible="true">
                                      
                                        <table border="1" width="100%">
                                            <tr>
                                                <td width="30%">
                                                    <table border="0">
                                                        <tr>
                                                            <td colspan="0" align="center" ><asp:Label ID="Label9" runat="server" Text="Current Location"></asp:Label></td>
                                                        </tr>
                                                        <tr>
                                                            <td><asp:Label ID="Label2" runat="server" Text="Warehouse:"></asp:Label></td>
                                                         
                                                           <td><asp:Label ID="lblWarehouse" runat="server" Text="" ></asp:Label></td>
                                                        </tr>
                                                       
                                                        <tr>
                                                            <td><asp:Label ID="Label6" runat="server" Text="Location:"></asp:Label></td>
                                                         
                                                            <td><asp:Label ID="lblLocation" runat="server" Text=""></asp:Label></td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <asp:Panel ID="pnlLocationUpdate" runat="server">
                                                
                                                <td width="30%">
                                                    <table>
                                                        <tr>
                                                            <td><asp:Label ID="Label7" runat="server" Text="Warehouse"></asp:Label></td>
                                                         
                                                            <td><asp:DropDownList ID="ddlWarehouse" runat="server" DataSourceID="sqldsrootlocations" DataTextField="LocDesc" DataValueField="LocNameID" AutoPostBack="true" ></asp:DropDownList></td>
                                                        </tr>
                                                       
                                                        <tr>
                                                            <td><asp:Label ID="Label8" runat="server" Text="Location"></asp:Label></td>
                                                         
                                                            <td><asp:DropDownList ID="ddlLocation" runat="server" DataSourceID="sqldsLocationsForRoot" DataTextField="LocDesc" DataValueField="LocNameID" AutoPostBack="true" ></asp:DropDownList></td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Button ID="btnUpdateLocation" runat="server" Text="Update Location" 
                                                                    Enabled="False" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                </asp:Panel>

                                                
                                                <td width="40%">
                                                    <table width="100%">
                                                        <tr>
                                                            <td>
                                                                <asp:Panel ID="pnlAttachments" runat="server" ScrollBars="Auto" Height="50px" >

                                                                    <asp:GridView ID="gvAssetAttachments" runat="server" ShowHeader="False" DataSourceID="sqldsAssetAttachments" 
                                                                        GridLines="Horizontal" AutoGenerateColumns="False" Width="96%" DataKeyNames="ItemId"   >
                                                                        <Columns>
                                                                            <asp:TemplateField ItemStyle-Width="7%" >
                                                                                <ItemTemplate>
                                                                                    <asp:ImageButton ID="ibnAttachment" runat="server" ImageUrl="Images/PaperClip.gif"  />
                                                                                </ItemTemplate>
                                                                            </asp:TemplateField>
                                                                            <asp:TemplateField ItemStyle-Width="55%" >
                                                                                <ItemTemplate>
                                                                                    <asp:Label ID="lblComment" runat="server" Text='<%# Eval("Comments").ToString() %>' ToolTip='<%# Eval("UploadFilename").ToString() %>'></asp:Label>
                                                                                </ItemTemplate>
                                                                            </asp:TemplateField>
                                                                            <asp:BoundField DataField="EnteredOn" ReadOnly="True" ItemStyle-Width="32%"  />
                                                                           <asp:TemplateField ItemStyle-Width="6%" >
                                                                                <ItemTemplate>
                                                                                    <asp:ImageButton ID="ibnRemove" runat="server" ImageUrl="Images/RemoveAttachment.png" ToolTip="Remove Attachment" OnClick="ibnRemove_Click" CommandArgument='<%# Eval("ItemId").ToString() %>'  />
                                                                                    <ajaxToolkit:ConfirmButtonExtender ID="cbeRemoveAttachment" runat="server" 
                                                                                        TargetControlID="ibnRemove"
                                                                                        ConfirmText="Are you sure you want to Remove this Attachment?" 
                                                                                        OnClientCancel="cancelClick" />
                                                                                </ItemTemplate>
                                                                            </asp:TemplateField>
                                                                         </Columns>
                                                                        <EmptyDataTemplate>
                                                                            No Attachments to Display
                                                                        </EmptyDataTemplate>
                                                                        <RowStyle  BorderStyle="Solid" HorizontalAlign="Left" VerticalAlign="Top"></RowStyle>
                                                                    </asp:GridView>


                                                                </asp:Panel>
                                                            
                                                            </td>
                                                         
                                                        </tr>
                                                       
                                                        <tr>
                                                            <td>
                                                                <asp:Button ID="btnAddAttachment" runat="server" Text="Add Attachment" Enabled="False" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>



                                            </tr>
                                        </table>
                                          </asp:Panel>
                                          </ContentTemplate>
                                          </asp:UpdatePanel>
                                    </td>
                                </tr>
                               
                                <tr valign="top">
                                    <td>
                                    
                                        <asp:UpdatePanel ID="UpdatePanel2" UpdateMode="Conditional" runat="server" >
                                        <ContentTemplate>
                                        <asp:Label ID="lblContentBodyError" runat="server" Text="Text" Font-Bold="True" ForeColor="Red" Visible="False" />
                                        <asp:GridView ID="gvLookupTable" runat="server" AllowPaging="True" RowStyle-VerticalAlign="Top" 
                                            AllowSorting="True" Width="100%" PageSize="20" DataSourceID="sqldsTagsByAsset" DataKeyNames="tagid"
                                            AutoGenerateColumns="False" ShowFooter="True">
                                            <Columns>
                                               <asp:TemplateField HeaderText="Actions">
                                                    <ItemTemplate>
                                                        &nbsp;<asp:ImageButton ID="btnEditItem" runat="server" CommandName="Edit" Text="Edit Tag Value" ImageUrl="~/Images/contact_grey_edit.png" ToolTip="Edit Tag Value"/>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:ImageButton ID="btnUpdateItem" runat="server" CommandName="Update" Text="Update Tag Value" ImageUrl="~/Images/badge_save.png" ToolTip="Update Tag Value"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelUpdate" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/Images/badge_cancel.png" ToolTip="Cancel Update"/>
                                                    </EditItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:ImageButton ID="btnAddItem" runat="server" CommandName="Insert" Text="Insert New Tag Value" ImageUrl="~/Images/badge_save.png" ToolTip="Insert New Tag Value"/>&nbsp;&nbsp;&nbsp;
                                                        <asp:ImageButton ID="btnCancelAdd" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/Images/badge_cancel.png" ToolTip="Cancel Insert"/>
                                                    </FooterTemplate>
                                                    <HeaderStyle Width="25%" />
                                                    <FooterStyle VerticalAlign="Bottom" />
                                                    <ItemStyle VerticalAlign="Bottom" />
                                                </asp:TemplateField>
                                                                                            
                                                
                                                                                           
                                                 <asp:TemplateField HeaderText="Tag Name" SortExpression="TagName">
                                                    <FooterTemplate>
                                                        <asp:DropDownList ID="TagName" runat="server" DataSourceID="sqldsTags" DataValueField="TagNameID" DataTextField="TagDesc" AutoPostBack="true" OnSelectedIndexChanged="lstItems_SelectedIndexChanged"  >
                                                        </asp:DropDownList>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="TagName" runat="server" DataSourceID="sqldsAllTags" DataValueField="TagNameID" DataTextField="TagDesc" SelectedValue='<%# Bind("TagNameID") %>' Enabled="false"  >
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblTagName" runat="server" Text='<%# Bind("TagName") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="25%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                 
                                                
                                                <asp:TemplateField HeaderText="Value" SortExpression="TagValue">
                                                    <FooterTemplate>
                                                        <asp:TextBox ID="TagValue" runat="server" Text='<%# Bind("TagValue") %>' Width="97%"></asp:TextBox>
                                                        <asp:DropDownList ID="ddlTagValue" runat="server" DataSourceID="sqldsListItems" DataValueField="TagListDesc" DataTextField="TagListDesc" Visible="false"  ></asp:DropDownList>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="TagValue" runat="server" Text='<%# Bind("TagValue") %>' Width="97%"></asp:TextBox>
                                                        <asp:DropDownList ID="ddlTagValue" runat="server" DataSourceID="sqldsListItems" DataValueField="TagListDesc" DataTextField="TagListDesc" Visible="true" SelectedValue='<%# Bind("TagValue") %>' ></asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="TagValueLabel" runat="server" Text='<%# Bind("TagValue") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="50%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                
                                                <asp:TemplateField HeaderText="Tag Type" SortExpression="TagType" Visible="false">
                                                    <FooterTemplate>
                                                        <asp:Label ID="TagType" runat="server" Text='<%# Bind("TagType") %>'></asp:Label>
                                                    </FooterTemplate>
                                                    <EditItemTemplate>
                                                        <asp:Label ID="TagType" runat="server" Text='<%# Bind("TagType") %>'></asp:Label>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("TagType") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" />
                                                    <FooterStyle VerticalAlign="Top" />
                                                </asp:TemplateField>
                                                                                                
                                                
                                            </Columns>
                                            <FooterStyle BackColor="#EEEEEE" />
                                            <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                            <EmptyDataTemplate>
                                                No Data Found for the Given Asset Tag Number
                                            </EmptyDataTemplate>
                                            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                                            <HeaderStyle BackColor="DarkGray" Font-Bold="True" />
                                            <AlternatingRowStyle></AlternatingRowStyle>
                                            <RowStyle></RowStyle>
                                        </asp:GridView>
                                        </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </td>
                                </tr>
                                <asp:UpdatePanel ID="UpdatePanel4" UpdateMode="Conditional" runat="server" >
                                <ContentTemplate>
                                <asp:Panel ID="pnlUpload" runat="server" Visible="false">
                                   
                                    <tr>
                                        <td>
                                            <asp:FileUpload ID="FileUpload1" style="width:500px;"  runat="server" />
                                            <asp:Button ID="btnUpload" runat="server"
                                                Text="Upload" />
                                        </td>                               
                                    </tr>
                                    <tr>
                                         <td align="left">
                                            <asp:Label ID="lblMessage" runat="server" Text="" Visible="false" ForeColor="Blue" Font-Bold="True"></asp:Label>
                                        </td>
                                    </tr>
                                 </asp:Panel>
                                 </ContentTemplate>
                                 </asp:UpdatePanel>
                                 <tr>
                                    <td>
                                        <asp:UpdatePanel ID="UpdatePanel3" UpdateMode="Conditional" runat="server" >
                                        <ContentTemplate>
                                        <asp:ListView ID="ListView1" GroupItemCount="8" runat="server" DataKeyNames="photoid"
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
                                                
                                                <asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl='<%# Eval("photoid", "DisplayPhoto.aspx?ID={0}") %>' >
                                                    <asp:Image
                                                        id="picAlbum" runat="server" AlternateText='<% #Eval("theDescription") %>'
                                                        ImageUrl='<%# "ShowImage.ashx?id=" + Convert.ToString(Eval("photoid")) %>'  />
                                                </asp:HyperLink>
                                            </ItemTemplate>
                                            <EmptyItemTemplate>           
                                               
                                            </EmptyItemTemplate>
                                        </asp:ListView>
                                        </ContentTemplate>
                                        </asp:UpdatePanel>
                                        


                                        
                                        
                                        
                                        
                                    </td>
                                 </tr>
                            </table>
                        </td>
                    </tr>
                </table>

                 <asp:SqlDataSource ID="sqldsTagsByAsset" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetTagReportForAsset(?)" SelectCommandType="StoredProcedure" 
                    InsertCommand="Call InsertTagDetail(?,?,?)" InsertCommandType="StoredProcedure"  
                    UpdateCommand="Call UpdateTagDetail(?,?,?)" UpdateCommandType="StoredProcedure">
                    <UpdateParameters>
                         <asp:Parameter Name="P1" Type="String" />
                         <asp:Parameter Name="P2" Type="Int32" />
                         <asp:Parameter Name="P3" Type="String" />
                    </UpdateParameters>
                    <InsertParameters>
                         <asp:Parameter Name="AssetTagNumber" Type="String" />
                         <asp:Parameter Name="TagNameID" Type="Int32" />
                         <asp:Parameter Name="TagValue" Type="String" />
                    </InsertParameters>
                    <SelectParameters>
                         <asp:Parameter Name="AssetTagNumber" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                
                <asp:SqlDataSource ID="sqldsTags" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetAllTagsNotAlreadyUsed(?)" SelectCommandType="StoredProcedure"> 
                    <SelectParameters>
                         <asp:Parameter Name="TagNum" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                
                <asp:SqlDataSource ID="sqldsAllTags" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetAllTags()" SelectCommandType="StoredProcedure"> 
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
                
                 <asp:SqlDataSource ID="sqldsPhotos" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    InsertCommand="Call UploadPhoto(?,?,?)" InsertCommandType="StoredProcedure"  >
                    <InsertParameters>
                         <asp:Parameter Name="TagName" Type="String" />
                         <asp:Parameter Name="OriginalPhoto"  />
                         <asp:Parameter Name="ThumbnailPhoto"  />
                    </InsertParameters>
                </asp:SqlDataSource>
                
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                    ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetThumbnailInfo(?)" SelectCommandType="StoredProcedure" >
                    <SelectParameters>
                         <asp:Parameter Name="TAG" Type="String" DefaultValue="0" />
                    </SelectParameters>
                </asp:SqlDataSource>
                
                 <asp:SqlDataSource ID="sqldsRootLocations" runat="server"
                    ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="call GetAllRootLocations()" SelectCommandType="StoredProcedure">
                </asp:SqlDataSource>
                
                 <asp:SqlDataSource ID="sqldsLocationsForRoot" runat="server"
                    ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="call GetAllLocationsForRoot(?)" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="TheRoot" Type="Int32" DefaultValue="1" />
                    </SelectParameters>
                </asp:SqlDataSource>
                
                <asp:SqlDataSource ID="sqldsAssetLocation" runat="server"
                    ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="call GetAssetLocation(?)" SelectCommandType="StoredProcedure"
                    InsertCommand="Call InsertLocationHistory(?,?,?)" InsertCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="TheTag" Type="String" DefaultValue="1" />
                    </SelectParameters>
                     <InsertParameters>
                         <asp:Parameter Name="TheLocation" Type="Int32" />
                         <asp:Parameter Name="TheUser" Type="String" />
                         <asp:Parameter Name="TheTag" Type="String" />
                    </InsertParameters>
                </asp:SqlDataSource>
                
                <asp:SqlDataSource ID="sqldsAssetRootLocation" runat="server"
                    ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="call GetAssetRootLocation(?)" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="TheTag" Type="String" DefaultValue="1" />
                    </SelectParameters>
                </asp:SqlDataSource>
                
                <asp:SqlDataSource ID="sqldsGetTagByID" runat="server"
                    ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="call GetTagByID(?)" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="TheID" Type="Int32" DefaultValue="0" />
                    </SelectParameters>
                </asp:SqlDataSource>
                
                 <asp:SqlDataSource ID="sqldsAsset" runat="server"
                    ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    DeleteCommand="call DeleteAsset(?,?)" SelectCommandType="StoredProcedure">
                    <DeleteParameters>
                         <asp:Parameter Name="TagNum" Type="String" DefaultValue="0" />
                         <asp:Parameter Name="theUser" Type="String" DefaultValue="0" />
                    </DeleteParameters>
                </asp:SqlDataSource>
                
                <asp:SqlDataSource ID="sqldsListItems" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetListItemsByTagNameIDForEdit(?,?)" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:Parameter Name="TagNameID" Type="Int32" />
                        <asp:Parameter Name="theDefaultVal" Type="String" DefaultValue="0" />
                    </SelectParameters>
                </asp:SqlDataSource>
                
                <asp:SqlDataSource ID="sqldsGetTagByDescription" runat="server"
                    ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="call GetTagByDescription(?)" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="TagDesc" Type="String" DefaultValue="0" />
                    </SelectParameters>
                </asp:SqlDataSource>

                <asp:SqlDataSource ID="sqldsAssetAttachments" runat="server"
                    ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    UpdateCommand="call DeleteAssetAttachment(?)" UpdateCommandType="StoredProcedure"
                    SelectCommand="call GetAssetAttachments(?)" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="TagNumber" Type="String" DefaultValue="0" />
                    </SelectParameters>
                    <UpdateParameters>
                         <asp:Parameter Name="ItemId" Type="Int32" DefaultValue="0" />
                    </UpdateParameters>
                </asp:SqlDataSource>

                <asp:SqlDataSource ID="sqldsAssetSoldInfo" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetAssetSoldInformation(?)" SelectCommandType="StoredProcedure"> 
                    <SelectParameters>
                         <asp:Parameter Name="TagNumber" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                
                
                
</asp:Content>

