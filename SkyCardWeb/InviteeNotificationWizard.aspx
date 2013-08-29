<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="InviteeNotificationWizard.aspx.vb" Inherits="InviteeNotificationWizard" title="Auction Invitee Notification Wizard" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>


                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableWizardLabel" colspan="2">
                                        Auction Invitee Notification Wizard
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td width="100%" >
                                         <asp:Wizard ID="wizInviteeNotification" runat="server" DisplaySideBar="False" Width="100%">
                                            <WizardSteps>
                                                
                                                <asp:WizardStep ID="wizstpSelectInvitees" runat="server" Title="Select Invitees to Auction">
                                                    <table cellspacing="0" cellpadding="0" width="100%" border="1" class="TableSearch">
                                                        <tr>
                                                            <td>
                                                                <table cellspacing="1" cellpadding="1" width="100%" border="0">
                                                                    <tbody>
                                                                        <tr>
                                                                            <td class="tableCaptionLabel" colspan="6" align="center">
                                                                                Select Invitees For Auction Notification
                                                                            </td>
                                                                        </tr>

                                                                        <tr>
                                                                            <td>
                                                                                <div runat="server" id="GVTitle">
                                                                                    <table cellspacing="0" cellpadding="0" width="100%" border="0" class="captionLabel">
                                                                                        <tr>
                                                                                            <td align="left" class="RptHeader" width="33%" style="height: 20px">
                                                                                                <asp:Label Width="100%" ID="lblPageCount" runat="server" Text="Page 1 of 1" Font-Size="smaller"></asp:Label>
                                                                                            </td>
                                                                                            <td class="RptHeader" width="34%" style="height: 20px" align="center">
                                                                                                <asp:Label ID="lblReportResults" runat="server" Text="Search Results"></asp:Label>
                                                                                            </td>
                                                                                            <td class="RptHeader" width="33%" style="height: 20px" align="right">
                                                                                                <asp:Label ID="lblRecordCount" runat="server" Text="Record 1 of 1" Font-Size="smaller"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </div>
                                                                            </td>
                                                                        </tr>

                                                                        <tr valign="top">
                                                                            <td colspan="2">

                                                                                <asp:HiddenField ID="hfdTotalRecords" runat="server" />
                                                                                <asp:GridView ID="gvSearchRecs" runat="server" Width="100%" AllowSorting="True" HeaderStyle-CssClass="Header2" 
                                                                                    AllowPaging="True" PageSize="15" EmptyDataText="There are no Users registered in the Auction Web Site."
                                                                                    AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" ForeColor="#333333"
                                                                                    GridLines="Vertical">
                                                                                    <AlternatingRowStyle CssClass="gvRowDataAlt"></AlternatingRowStyle>
                                                                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                                                    <PagerSettings Mode="NextPreviousFirstLast" FirstPageImageUrl="Images/resultset_first.png"
                                                                                        FirstPageText="First" LastPageImageUrl="Images/resultset_last.png" LastPageText="Last"
                                                                                        NextPageImageUrl="Images/resultset_next.png" NextPageText="Next" PreviousPageImageUrl="Images/resultset_previous.png"
                                                                                        PreviousPageText="Previous"></PagerSettings>
                                                                                    <RowStyle CssClass="gvRowData"></RowStyle>
                                                                                    <Columns>
                                                                                        <asp:TemplateField ItemStyle-VerticalAlign="Top" Visible="false">
                                                                                            <ItemTemplate>
                                                                                                <asp:Label ID="lblID" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                                                                                            </ItemTemplate>
                                                                                        </asp:TemplateField>
                                                                                        <asp:TemplateField HeaderText='<table width="100%"><tr><td align="left" width="20%"><input id="Checkbox2" type="checkbox" title="Select/Unselect All on Page" onclick="javascript:setAllCheckBoxes(this);" checked="true" /></td><td align="center" width="80%">Select</td></tr></table>' HeaderStyle-Width="10%" ItemStyle-VerticalAlign="Top">
                                                                                            <ItemTemplate>
                                                                                                <asp:CheckBox ID="cbxSelect" runat="server" Checked='<%# IIF(Eval("selected") = 1,"True","False") %>' />
                                                                                            </ItemTemplate>
                                                                                        </asp:TemplateField>
                                                                                        <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="LastName" HeaderStyle-Width="15%" />
                                                                                        <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="FirstName" HeaderStyle-Width="15%" />
                                                                                        <asp:BoundField DataField="Email" HeaderText="Email Address" SortExpression="Email" HeaderStyle-Width="45%" />
                                                                                        <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" HeaderStyle-Width="10%" />
                                                                                        <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" HeaderStyle-Width="5%" />
                                                                                    </Columns>
                                                                                    <HeaderStyle BackColor="DarkGray" Font-Bold="True"></HeaderStyle>
                                                                                    <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                                                                </asp:GridView>
                                                                                
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>&nbsp;
                                                                            </td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>

                                                    <asp:SqlDataSource ID="sqldsSelectInvitees" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                        SelectCommand="Call GetAuctionSiteUsers()" SelectCommandType="StoredProcedure"> 
                                                    </asp:SqlDataSource>
                                                
                                                </asp:WizardStep>
                                                
                                                 <asp:WizardStep ID="wizstpEmailText" runat="server" Title="Specify Email Notification Text">
                                                    <table cellspacing="0" cellpadding="0" width="100%" border="1" class="TableSearch">
                                                        <tr>
                                                            <td>
                                                                <table cellspacing="1" cellpadding="1" width="100%" border="0">
                                                                    <tbody>
                                                                        <tr>
                                                                            <td class="tableCaptionLabel" colspan="6" align="center">
                                                                                Invitee Email Text
                                                                            </td>
                                                                        </tr>

                                                                        <tr>
                                                                            <td>
                                                                                <asp:TextBox ID="EmailMessage" runat="server" TextMode="MultiLine" Width="100%" Columns="150" Rows="20" ></asp:TextBox>
                                                                                <ajaxToolkit:HtmlEditorExtender runat="server" ID="htmlEmailMessage" TargetControlID="EmailMessage" DisplaySourceTab="True" EnableSanitization="False"     >
                                                                                    <Toolbar>
                                                                                        <ajaxToolkit:Undo />
                                                                                        <ajaxToolkit:Redo />
                                                                                        <ajaxToolkit:Bold />
                                                                                        <ajaxToolkit:Italic />
                                                                                        <ajaxToolkit:Underline />
                                                                                        <ajaxToolkit:StrikeThrough />
                                                                                        <ajaxToolkit:Subscript />
                                                                                        <ajaxToolkit:Superscript />
                                                                                        <ajaxToolkit:JustifyLeft />
                                                                                        <ajaxToolkit:JustifyCenter />
                                                                                        <ajaxToolkit:JustifyRight />
                                                                                        <ajaxToolkit:JustifyFull />
                                                                                        <ajaxToolkit:InsertOrderedList />
                                                                                        <ajaxToolkit:InsertUnorderedList />
                                                                                        <ajaxToolkit:CreateLink />
                                                                                        <ajaxToolkit:UnLink />
                                                                                        <ajaxToolkit:RemoveFormat />
                                                                                        <ajaxToolkit:SelectAll />
                                                                                        <ajaxToolkit:UnSelect />
                                                                                        <ajaxToolkit:Delete />
                                                                                        <ajaxToolkit:Cut />
                                                                                        <ajaxToolkit:Copy />
                                                                                        <ajaxToolkit:Paste />
                                                                                        <ajaxToolkit:BackgroundColorSelector />
                                                                                        <ajaxToolkit:ForeColorSelector />
                                                                                        <ajaxToolkit:FontNameSelector />
                                                                                        <ajaxToolkit:FontSizeSelector />
                                                                                        <ajaxToolkit:Indent />
                                                                                        <ajaxToolkit:Outdent />
                                                                                        <ajaxToolkit:InsertHorizontalRule />
                                                                                        <ajaxToolkit:HorizontalSeparator />
                                                                                    
                                                                                    </Toolbar>
                                                                                </ajaxToolkit:HtmlEditorExtender>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>&nbsp;
                                                                            </td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </asp:WizardStep>

                                                 <asp:WizardStep ID="wizstpEmailAttachments" runat="server" Title="Select File Attachments For Email">
                                                    <table cellspacing="0" cellpadding="0" width="100%" border="1" class="TableSearch">
                                                        <tr>
                                                            <td>
                                                                <table cellspacing="1" cellpadding="1" width="100%" border="0">
                                                                    <tbody>
                                                                        <tr>
                                                                            <td class="tableCaptionLabel" colspan="6" align="center">
                                                                                Email Subject & Attachments 
                                                                            </td>
                                                                        </tr>

                                                                        <tr>
                                                                            <td style="width:33%;" class="PageLabelText" align="right">
                                                                                <asp:Label ID="Label1" runat="server" Text="Email Subject:"></asp:Label>&nbsp;
                                                                            </td>
                                                                            <td style="width:67%;">
                                                                                 <asp:TextBox ID="txtSubject" runat="server" MaxLength="200" Width="80%"></asp:TextBox>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="right">
                                                                                <asp:Label ID="Label3" runat="server" Text="Add Attachment:"></asp:Label>&nbsp;
                                                                            </td>
                                                                            <td>
                                                                                 <asp:FileUpload ID="filEmailAttachment1" runat="server" Width="80%"  />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="right">&nbsp;
                                                                            </td>
                                                                            <td>
                                                                                 <asp:FileUpload ID="filEmailAttachment2" runat="server" Width="80%"  />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="right">&nbsp;
                                                                            </td>
                                                                            <td>
                                                                                 <asp:FileUpload ID="filEmailAttachment3" runat="server" Width="80%"  />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="right">&nbsp;
                                                                            </td>
                                                                            <td>
                                                                                 <asp:FileUpload ID="filEmailAttachment4" runat="server" Width="80%"  />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>&nbsp;
                                                                            </td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </asp:WizardStep>

                                                 <asp:WizardStep ID="wizstpConfirmNotifications" runat="server" Title="Confirm the Email Notifications">
                                                    <table cellspacing="0" cellpadding="0" width="100%" border="1" class="TableSearch">
                                                        <tr>
                                                            <td>
                                                                <table cellspacing="1" cellpadding="1" width="100%" border="0">
                                                                    <tbody>
                                                                        <tr>
                                                                            <td class="tableCaptionLabel" colspan="6" align="center">
                                                                                Confirm Email Notifications 
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>&nbsp;
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td colspan="3" style="width:100%;" class="PageLabelText" align="center">
                                                                            
                                                                            
                                                                            
                                                                                        <asp:Label ID="lblInstructions" runat="server" Text="Click the Send Emails button below to send the Auction invitation emails to the selected invitees." ForeColor="Navy" Font-Bold="True"></asp:Label>&nbsp;
                                                                                        <asp:Button runat="server" id="UpdateButton" text="Update"  />

                                                                                        <asp:Label ID="lblSending" runat="server" Text="Sending Emails..." ForeColor="Navy" Font-Bold="True" ></asp:Label><br />                        
                                                                                        <asp:Image ID="imgProgBar" runat="server" ImageUrl="Images/progress_bar.gif" height="14" width="190"   />            






                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>&nbsp;
                                                                            </td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                
                                                </asp:WizardStep>
                                                
                                            </WizardSteps>
                                            
                                            <FinishNavigationTemplate>
                                                <br />
                                                <asp:Button ID="PreviousButton" runat="server" CommandName="MovePrevious" Text="Previous" CausesValidation="False"  />
                                                &nbsp;
                                                <asp:Button ID="FinishButton" runat="server" CommandName="MoveComplete" Text="Send Emails" />
                                                &nbsp;&nbsp;
                                            </FinishNavigationTemplate>
                                            
                                        </asp:Wizard>
                                    
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>


</asp:Content>

