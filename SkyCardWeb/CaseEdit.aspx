<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="CaseEdit.aspx.vb" Inherits="CaseEdit" title="Edit Case" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content3" ContentPlaceHolderID="cphBody" Runat="Server">

    <%--<asp:ScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server" />--%>
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" EnablePartialRendering="true" runat="server"/>
    
    <ajaxToolkit:TabContainer ScrollBars="Auto" runat="server" ID="Tabs" 
        Height="820px" ActiveTabIndex="5" Width="100%">
        <ajaxToolkit:TabPanel ScrollBars="Auto" runat="server" ID="tabpnlClaim" HeaderText="Case Information">
            <HeaderTemplate>
                Case Information
            </HeaderTemplate>
            <ContentTemplate>
            
                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Case Number <asp:Label ID="lblCaseNumber" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                    
                                    
                                        <asp:FormView ID="fvClaim" runat="server" DataKeyNames="CaseNumber" 
                                            DataSourceID="sqldsCase" DefaultMode="Edit" Width="100%">
                                        
                                        
                                        
                                            <EditItemTemplate>
                                            

                                                <table>
                                                    <tr>
                                                        <td align="left" width="17%">Case Number</td>
                                                        <td align="left" width="33%">
                                                            <asp:TextBox ID="tbCaseNum" runat="server" CssClass="dControl" Enabled="false" 
                                                                ReadOnly="true" Text='<%# Bind("CaseNumber") %>' Width="50%"></asp:TextBox>
                                                        </td>
                                                        <td align="left" width="17%">
                                                            Defendant Name</td>
                                                        <td align="left" width="33%">
                                                            <asp:TextBox ID="tbDefendant" runat="server" CssClass="dControl" 
                                                                Text='<%# Bind("DefendantName") %>' Width="50%"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr valign="top">
                                                        <td align="left">
                                                            Date Initiated</td>
                                                        <td align="left">
                                                            <asp:TextBox ID="DateInitiated" runat="server" 
                                                                Text='<%# Bind("DateInitiated", "{0:d}") %>' Width="50%"></asp:TextBox>
                                                            <ajaxToolkit:CalendarExtender ID="calDateInitiated" runat="server" 
                                                                Format="MM/dd/yyyy" PopupButtonID="imgDateInitiatedCalendarIcon" 
                                                                TargetControlID="DateInitiated" />
                                                            <asp:ImageButton ID="imgDateInitiatedCalendarIcon" runat="Server" 
                                                                AlternateText="Click to show calendar" 
                                                                ImageUrl="~/Images/Calendar_scheduleHS.png" />
                                                        </td>
                                                        <td align="left">
                                                            Arraignment Date</td>
                                                        <td align="left">
                                                            <asp:TextBox ID="ArraignmentDate" runat="server" 
                                                                Text='<%# Bind("ArraignmentDate", "{0:d}") %>' Width="50%"></asp:TextBox>
                                                            <ajaxToolkit:CalendarExtender ID="calArraignmentDate" runat="server" 
                                                                Format="MM/dd/yyyy" PopupButtonID="imgArraignmentDateCalendarIcon" 
                                                                TargetControlID="ArraignmentDate" />
                                                            <asp:ImageButton ID="imgArraignmentDateCalendarIcon" runat="Server" 
                                                                AlternateText="Click to show calendar" 
                                                                ImageUrl="~/Images/Calendar_scheduleHS.png" />
                                                        </td>
                                                    </tr>
                                                    <tr valign="top">
                                                        <td align="left">
                                                            Pretrial Date</td>
                                                        <td align="left">
                                                            <asp:TextBox ID="PretrialDate" runat="server" 
                                                                Text='<%# Bind("PretrialDate", "{0:d}") %>' Width="50%"></asp:TextBox>
                                                            <ajaxToolkit:CalendarExtender ID="calPretrialDate" runat="server" 
                                                                Format="MM/dd/yyyy" PopupButtonID="imgPretrialDateCalendarIcon" 
                                                                TargetControlID="PretrialDate" />
                                                            <asp:ImageButton ID="imgPretrialDateCalendarIcon" runat="Server" 
                                                                AlternateText="Click to show calendar" 
                                                                ImageUrl="~/Images/Calendar_scheduleHS.png" />
                                                        </td>
                                                        <td align="left">
                                                            Bench Trial Date</td>
                                                        <td align="left">
                                                            <asp:TextBox ID="BenchTrialDate" runat="server" 
                                                                Text='<%# Bind("BenchTrialDate", "{0:d}") %>' Width="50%"></asp:TextBox>
                                                            <ajaxToolkit:CalendarExtender ID="calBenchTrialDate" runat="server" 
                                                                Format="MM/dd/yyyy" PopupButtonID="imgBenchTrialDateCalendarIcon" 
                                                                TargetControlID="BenchTrialDate" />
                                                            <asp:ImageButton ID="imgBenchTrialDateCalendarIcon" runat="Server" 
                                                                AlternateText="Click to show calendar" 
                                                                ImageUrl="~/Images/Calendar_scheduleHS.png" />
                                                        </td>
                                                    </tr>
                                                    <tr valign="top">
                                                        <td align="left">
                                                            Jury Trial Date</td>
                                                        <td align="left">
                                                            <asp:TextBox ID="JuryTrialDate" runat="server" 
                                                                Text='<%# Bind("JuryTrialDate", "{0:d}") %>' Width="50%"></asp:TextBox>
                                                            <ajaxToolkit:CalendarExtender ID="calJuryTrialDate" runat="server" 
                                                                Format="MM/dd/yyyy" PopupButtonID="imgJuryTrialDateCalendarIcon" 
                                                                TargetControlID="JuryTrialDate" />
                                                            <asp:ImageButton ID="imgJuryTrialDateCalendarIcon" runat="Server" 
                                                                AlternateText="Click to show calendar" 
                                                                ImageUrl="~/Images/Calendar_scheduleHS.png" />
                                                        </td>
                                                        <td align="left">
                                                            Disposition</td>
                                                        <td align="left" width="33%">
                                                            <asp:TextBox ID="tbDisposition" runat="server" CssClass="dControl" 
                                                                Text='<%# Bind("Disposition") %>' Width="50%"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr valign="top">
                                                        <td align="left">
                                                            Amended</td>
                                                        <td align="left">
                                                            <asp:CheckBox ID="cbAmended" runat="server" checked='<%# Eval("amended") %>' 
                                                                CssClass="dControl" Text="" Visible="True" />
                                                        </td>
                                                        <td align="left">
                                                            Amended To</td>
                                                        <td align="left">
                                                            <asp:TextBox ID="tbAmendedTo" runat="server" CssClass="dControl" 
                                                                Text='<%# Bind("AmendedToWhat") %>' Width="50%"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr valign="top">
                                                        <td align="left">
                                                            Conviction</td>
                                                        <td align="left">
                                                            <asp:CheckBox ID="cbConviction" runat="server" 
                                                                checked='<%# Eval("Conviction") %>' CssClass="dControl" Text="" 
                                                                Visible="True" />
                                                        </td>
                                                        <td align="left">
                                                            Case Type</td>
                                                        <td align="left">
                                                            <asp:SqlDataSource ID="sqldsCaseType" runat="server" 
                                                                ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                                ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>" 
                                                                SelectCommand="GetCaseTypes" SelectCommandType="StoredProcedure">
                                                            </asp:SqlDataSource>
                                                            <asp:DropDownList ID="ddlCaseTypes" runat="server" AppendDataBoundItems="True" 
                                                                DataSourceID="sqldsCaseType" DataTextField="CaseType" DataValueField="CaseType" 
                                                                SelectedValue='<%# Bind("CaseType") %>'>
                                                                <asp:ListItem Selected="True" Text="" Value=""></asp:ListItem>
                                                            </asp:DropDownList>
                                                            &nbsp;&nbsp;
                                                        </td>
                                                    </tr>
                                                    
                                                    <tr valign="top">
                                                        <td align="left"></td>
                                                        <td align="left"></td>
                                                        <td align="left">
                                                            Charge Type</td>
                                                        <td align="left">
                                                            <asp:SqlDataSource ID="sqldsChargeTypes" runat="server" 
                                                                ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                                ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>" 
                                                                SelectCommand="GetAllChargeTypes" SelectCommandType="StoredProcedure">
                                                            </asp:SqlDataSource>
                                                            <asp:DropDownList ID="ddlChargeTypes" runat="server" AppendDataBoundItems="True" 
                                                                DataSourceID="sqldsChargeTypes" DataTextField="ChargeType" DataValueField="ChargeType" 
                                                                SelectedValue='<%# Bind("ChargeType") %>'>
                                                                <asp:ListItem Selected="True" Text="" Value=""></asp:ListItem>
                                                            </asp:DropDownList>
                                                            &nbsp;&nbsp;
                                                        </td>
                                                    </tr>
                                                    
                                                </table>

                                            
                                                <table width="100%">
                                                  
                                                    <tr>
                                                        <td>
                                                            &nbsp; </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right">
                                                            <asp:Button ID="btnUpdateClaim" runat="server" CausesValidation="True" 
                                                                CommandName="Update" TabIndex="-1" Text="Update" />
                                                        </td>
                                                        <td align="left">
                                                            <asp:Button ID="btnUpdateCancel" runat="server" CausesValidation="True" 
                                                                CommandName="Cancel" TabIndex="-1" Text="Cancel" />
                                                        </td>
                                                    </tr>


                                                </table>
                                            

                                            </EditItemTemplate>
                                        
                                        
                                        
                                        </asp:FormView> 
                                                                           
                                        <asp:SqlDataSource ID="sqldsCase" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
                                            SelectCommand="GetCase" SelectCommandType="StoredProcedure" UpdateCommand="UpdateCase" UpdateCommandType="StoredProcedure" >
                                            <SelectParameters>
                                                <asp:SessionParameter DefaultValue="0" Name="CaseNumber" SessionField="CaseID" Type="String" />
                                            </SelectParameters>
                                            <UpdateParameters>
                                                <asp:SessionParameter DefaultValue="0" Name="CaseNumber" Type="String" />
                                                <asp:SessionParameter DefaultValue="0" Name="DefendantName" Type="String" />
                                                <asp:SessionParameter DefaultValue="0" Name="DateInitiated" Type="String" />
                                                <asp:SessionParameter DefaultValue="0" Name="ArraignmentDate" Type="String" />
                                                <asp:SessionParameter DefaultValue="0" Name="PreTrialDate" Type="String" />
                                                <asp:SessionParameter DefaultValue="0" Name="BenchTrialDate" Type="String" />
                                                <asp:SessionParameter DefaultValue="0" Name="JuryTrialDate" Type="String" />
                                                <asp:SessionParameter DefaultValue="0" Name="Disposition" Type="String" />
                                                <asp:SessionParameter DefaultValue="0" Name="Amended" Type="Int32" />
                                                <asp:SessionParameter DefaultValue="0" Name="AmendedToWhat" Type="String" />
                                                <asp:SessionParameter DefaultValue="0" Name="Conviction" Type="Int32" />
                                                <asp:SessionParameter DefaultValue="0" Name="CaseType" Type="String" />
                                                <asp:SessionParameter DefaultValue="0" Name="ChargeType" Type="String" />
                                                <asp:SessionParameter DefaultValue="0" Name="Deleted" Type="Int32" />
                                                <asp:Parameter Name="UserID" Type="String" />
                                            </UpdateParameters>
                                            
                                        </asp:SqlDataSource>
                                    
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>

            </ContentTemplate>
        </ajaxToolkit:TabPanel>
        
        <ajaxToolkit:TabPanel ScrollBars="Auto" runat="server" ID="tabpnlDocuments" HeaderText="Attached Documents">
            <ContentTemplate>
                <table class="TabPanelTable" border="0">
                    <tr>
                        <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                            Case Number <asp:Label ID="Label4" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr style="vertical-align: top;">
                        <td class="style1">
                            <table cellpadding="3" cellspacing="1" border="0" 
                                width="100%">
                                 <tr>
                                    <td align="left" colspan="4" class="style2">
                                        <asp:FileUpload ID="FileUpload1" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" colspan="4" class="style2">
                                        <asp:Button ID="btnUpload" runat="server" Text="Upload" />
                                    </td>
                                </tr>
                                 <tr valign="top">
                                    <td colspan="2" class="style2">
                                        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" Width="100%" PageSize="20" 
                                            AllowSorting="True" DataSourceID="sqldsAttachment" AutoGenerateColumns="False" DataKeyNames="CaseNumber" >
                                            <Columns>
                                                <asp:HyperLinkField 
                                                     DataTextField="AttachmentFileName" 
                                                     HeaderText="File Name"
                                                     SortExpression="AttachmentFileName" 
                                                     DataNavigateUrlFormatString="~/UploadedFiles/{1}/{0}"
                                                     DataNavigateUrlFields="AttachmentFileName,CaseNumber" >
                                                    
                                                </asp:HyperLinkField>
                                                <asp:BoundField DataField="AttachmentType" HeaderText="File Type" 
                                                    SortExpression="AttachmentType" />
                                                <asp:BoundField DataField="Last_Modified" HeaderText="Uploaded At" 
                                                    SortExpression="Last_Modified" />
                                                
                                                
                                            </Columns>
                                            <EmptyDataTemplate>
                                                <table width="100%" >
                                                    <tr>
                                                        <td align="center" width="100%" colspan="3">
                                                            <asp:Label ID="Label3" runat="server" Text="No Messages Found "></asp:Label>
                                                        </td>
                                                    </tr>
                                                   
                                                </table>
                                            </EmptyDataTemplate>
                                           
                                            <HeaderStyle BackColor="DarkGray" Font-Bold="True" />
                                            <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                            <RowStyle VerticalAlign="Top"></RowStyle>
                                            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                                        </asp:GridView>
                                   </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                 </table>
                                    
                           
             
                
                <asp:SqlDataSource ID="sqldsAttachment" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="GetAttachments" SelectCommandType="StoredProcedure" 
                    InsertCommand="InsertAttachment" InsertCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="CaseNumber" Type="String" DefaultValue="" />
                    </SelectParameters>
                    <InsertParameters>
                         <asp:Parameter Name="CaseNumber" Type="String" />
                         <asp:Parameter Name="AttachmentFileName" Type="String" />
                         <asp:Parameter Name="AttachmentType" Type="String" />
                         <asp:Parameter Name="DirectoryLocation" Type="String" />
                    </InsertParameters>
                </asp:SqlDataSource>

            </ContentTemplate>
        </ajaxToolkit:TabPanel>
        
        <ajaxToolkit:TabPanel ScrollBars="Auto" runat="server" ID="TabPanel2" HeaderText="Charges">
            <ContentTemplate>
                 <table class="TabPanelTable" border="0">
                    <tr>
                        <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                            Case Number <asp:Label ID="Label5" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr style="vertical-align: top;">
                        <td class="style1">
                           Add a Charge
                            <asp:DropDownList ID="ddlCharge" runat="server" 
                                DataSourceID="sqldsChargeMaster" DataTextField="LongDesc" 
                                DataValueField="ChargeUOR" AppendDataBoundItems="True">
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                            
                            
                            
                            <asp:Button ID="Button1" runat="server" Text="Add Charge" />
                        </td>
                    </tr>
                      <tr style="vertical-align: top;">
                        <td class="style1">
                            <asp:GridView ID="gvCharges" runat="server" AllowPaging="True" Width="100%" PageSize="20" 
                                AllowSorting="True" AutoGenerateColumns="False" 
                                DataSourceID="sqldsCharges" >
                                <Columns>
                                    <asp:BoundField DataField="ChargeUOR" HeaderText="UOR" 
                                        SortExpression="ChargeUOR" />
                                    <asp:BoundField DataField="ChargeKRS" HeaderText="KRS" 
                                        SortExpression="ChargeKRS" />
                                    <asp:BoundField DataField="ChargeDescription" HeaderText="Description" 
                                        SortExpression="ChargeDescription" />
                                    <asp:BoundField DataField="ChargeLevel" HeaderText="Level" 
                                        SortExpression="ChargeLevel" />
                                    <asp:BoundField DataField="ChargeClass" HeaderText="Class" 
                                        SortExpression="ChargeClass" />
                                </Columns>
                                <EmptyDataTemplate>
                                    <table width="100%" >
                                        <tr>
                                            <td align="center" width="100%" colspan="3">
                                                <asp:Label ID="Label3" runat="server" Text="No Messages Found "></asp:Label>
                                            </td>
                                        </tr>
                                       
                                    </table>
                                </EmptyDataTemplate>
                               
                                <HeaderStyle BackColor="DarkGray" Font-Bold="True" />
                                <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                <RowStyle VerticalAlign="Top"></RowStyle>
                                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                            </asp:GridView>
                            
                        </td>
                    </tr>
                 </table>       
              
                <asp:SqlDataSource ID="sqldsCharges" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="GetCaseCharges" SelectCommandType="StoredProcedure" 
                    InsertCommand="InsertCaseCharge" InsertCommandType="StoredProcedure">
                    <InsertParameters>
                         <asp:Parameter Name="CaseNumber" Type="String" />
                         <asp:Parameter Name="ChargeUOR" Type="String" />
                    </InsertParameters>
                    <SelectParameters>
                         <asp:Parameter Name="CaseNumber" Type="String" DefaultValue="" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="sqldsChargeMaster" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="GetCharges" SelectCommandType="StoredProcedure">
                </asp:SqlDataSource>
            </ContentTemplate>
        </ajaxToolkit:TabPanel>

        <ajaxToolkit:TabPanel ScrollBars="Auto" runat="server" ID="TabPanel1" HeaderText="Contacts">
            <ContentTemplate>
                 <table class="TabPanelTable" border="0">
                    <tr>
                        <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                            Case Number <asp:Label ID="Label6" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr style="vertical-align: top;">
                        <td class="style1">
                           Add a Contact
                            <asp:DropDownList ID="ddlContact" runat="server" 
                                DataSourceID="sqldsContactMaster" DataTextField="ContactName" 
                                DataValueField="ContactID" AppendDataBoundItems="True">
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                            
                            <asp:DropDownList ID="ddlContactType" runat="server" 
                                DataSourceID="sqldsContactTypes" DataTextField="ContactType" 
                                DataValueField="ID" AppendDataBoundItems="True">
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                            
                            <asp:Button ID="btnAddContact" runat="server" Text="Add Contact" />
                        </td>
                    </tr>
                    <tr style="vertical-align: top;">
                        <td class="style1">
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" Width="100%" PageSize="20" 
                                AllowSorting="True" AutoGenerateColumns="False" DataSourceID="sqldsContacts" >
                                <Columns>
                                    <asp:BoundField DataField="ContactName" HeaderText="Name" 
                                        SortExpression="ContactName" />
                                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                                    <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                                    <asp:BoundField DataField="ContactType" HeaderText="Contact Type" 
                                        SortExpression="ContactType" />
                                </Columns>
                                <EmptyDataTemplate>
                                    <table width="100%" >
                                        <tr>
                                            <td align="center" width="100%" colspan="3">
                                                <asp:Label ID="Label3" runat="server" Text="No Messages Found "></asp:Label>
                                            </td>
                                        </tr>
                                       
                                    </table>
                                </EmptyDataTemplate>
                               
                                <HeaderStyle BackColor="DarkGray" Font-Bold="True" />
                                <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                <RowStyle VerticalAlign="Top"></RowStyle>
                                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                            </asp:GridView>
                            <asp:SqlDataSource ID="sqldsContacts" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                SelectCommand="GetCaseContacts" SelectCommandType="StoredProcedure" 
                                InsertCommand="InsertCaseContact" InsertCommandType="StoredProcedure">
                                <InsertParameters>
                                     <asp:Parameter Name="CaseNumber" Type="String" />
                                     <asp:Parameter Name="ContactID" Type="Int32" />
                                     <asp:Parameter Name="ContactTypeID" Type="String" />
                                </InsertParameters>
                                <SelectParameters>
                                     <asp:Parameter Name="CaseNumber" Type="String" DefaultValue="" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                            
                            <asp:SqlDataSource ID="sqldsContactMaster" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                SelectCommand="GetAllContacts" SelectCommandType="StoredProcedure">
                            </asp:SqlDataSource>
                            <asp:SqlDataSource ID="sqldsContactTypes" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                SelectCommand="GetAllContactTypes" SelectCommandType="StoredProcedure">
                            </asp:SqlDataSource>
                        </td>
                    </tr>
                 </table>       
              

            </ContentTemplate>
        </ajaxToolkit:TabPanel>

        <ajaxToolkit:TabPanel ScrollBars="Auto" runat="server" ID="TabPanel12" HeaderText="Comments">
            <ContentTemplate>
                 <table class="TabPanelTable" border="0">
                    <tr>
                        <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                            Case Number <asp:Label ID="Label1" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr style="vertical-align: top;">
                        <td class="style1">
                            <table cellpadding="3" cellspacing="1" border="0" 
                                width="100%">
                                 <tr>
                                    <td align="right" colspan="4" class="style2">
                                        <table width="100%" border="0">
                                            <tr valign="Top">
                                                <td align="right">
                                                    <table width="100%">
                                                        <tr valign="Top">
                                                            <td align="right" width="16%">Add New Comments:
                                                            </td>
                                                            <td align="left" width="84%">
                                                                <asp:TextBox CssClass="txtEntry" ID="CommentsAddTextBox" width="100%" 
                                                                    TextMode="MultiLine" Rows="2" runat="server" TabIndex="20" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" colspan="4" class="style2">
                                        <table width="100%">
                                            <tr valign="Top">
                                                <td>
                                                    <table width="100%">
                                                        <tr>
                                                            <td align="center"> 
                                                                Comment Type:
                                                                <asp:DropDownList ID="ddlCommentType" runat="server">
                                                                        <asp:ListItem>Alert</asp:ListItem>
                                                                        <asp:ListItem Selected="True">Standard</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </td>
                                                            <td>
                                                                <asp:Button ID="btnAddComment" runat="server" Text="Add Comment" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <td>
                                                
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                 <tr valign="top">
                                    <td colspan="2" class="style2">
                                        <asp:GridView ID="gvLookupTable" runat="server" AllowPaging="True"
                                            AllowSorting="True" Width="100%" PageSize="20" 
                                            DataSourceID="sqldsComments" DataKeyNames="ID"
                                            AutoGenerateColumns="False">
                                            <Columns>
                                               
                                                <asp:TemplateField HeaderText="Date Added" SortExpression="CommentDate">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("CommentDate") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="20%" />
                                                </asp:TemplateField>
                                               
                                               <asp:TemplateField HeaderText="Message" SortExpression="CommentDesc">
                                                    
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1x" runat="server" Text='<%# Bind("CommentDesc") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterStyle VerticalAlign="Top" />
                                                    <HeaderStyle Width="50%" />
                                                </asp:TemplateField>
                                                
                                                <asp:TemplateField HeaderText="By" SortExpression="UserID">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2b" runat="server" Text='<%# Bind("UserID") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%" />
                                                </asp:TemplateField>
                                                
                                               <asp:TemplateField HeaderText="Message Type" SortExpression="CommentType">
                                                   
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1xc" runat="server" Text='<%# Bind("CommentType") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterStyle VerticalAlign="Top" />
                                                    <HeaderStyle Width="10%" />
                                                </asp:TemplateField>
                                                
                                            </Columns>
                                            <EmptyDataTemplate>
                                                <table width="100%" >
                                                    <tr>
                                                        <td align="center" width="100%" colspan="3">
                                                            <asp:Label ID="Label3" runat="server" Text="No Messages Found "></asp:Label>
                                                        </td>
                                                    </tr>
                                                   
                                                </table>
                                            </EmptyDataTemplate>
                                           
                                            <HeaderStyle BackColor="DarkGray" Font-Bold="True" />
                                            <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                            <RowStyle VerticalAlign="Top"></RowStyle>
                                            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                                        </asp:GridView>
                                        <asp:SqlDataSource ID="sqldsComments" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                            ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                            SelectCommand="GetComments" SelectCommandType="StoredProcedure" 
                                            InsertCommand="InsertComment" InsertCommandType="StoredProcedure">
                                            <SelectParameters>
                                                 <asp:Parameter Name="CommentTable" Type="String" DefaultValue="" />
                                                 <asp:Parameter Name="CommentID" Type="String" DefaultValue="" />
                                            </SelectParameters>
                                            <InsertParameters>
                                                 <asp:Parameter Name="CommentTable" Type="String" />
                                                 <asp:Parameter Name="CommentID" Type="String" />
                                                 <asp:Parameter Name="CommentDesc" Type="String" />
                                                 <asp:Parameter Name="UserID" Type="String" />
                                                 <asp:Parameter Name="CommentType" Type="String" />
                                            </InsertParameters>
                                        </asp:SqlDataSource>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                 </table>
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
        
        <ajaxToolkit:TabPanel ScrollBars="Auto" runat="server" ID="TabPanel3" HeaderText="Subpoena">
            <HeaderTemplate>
                Subpoena
            </HeaderTemplate>
            <ContentTemplate>
                 <table class="TabPanelTable" border="0">
                    <tr>
                        <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                            Case Number <asp:Label ID="Label7" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                    <td>
                    <ajaxToolkit:Accordion   
                            ID="Accordion1"   
                            runat="server" SelectedIndex="-1" RequireOpenedPane="false" HeaderCssClass="accordionHeader"  >  
                        <Panes>  
                            <ajaxToolkit:AccordionPane runat="server"> 
                            <Header>
                            Creat New Subpoena
                            </Header>
                            <Content>  
                    <table>       
                    <tr>
                        <td>
                            <asp:Button ID="btnAddSubpoena" runat="server" Text="Add Subpoena" />&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnCancelSubpoena" runat="server" Text="Cancel Subpoena" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table>
                                <tr>
                                    <td width="50%">
                                        Witness Name
                                    </td>
                                    
                                    <td width="50%">
                                        <asp:TextBox ID="tbWitnessName" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                         <td>
                            <table>
                                <tr>
                                    <td width="50%">
                                        Appearance Date
                                    </td>
                                    
                                    <td width="50%">
                                        <asp:TextBox ID="AppearanceDate" runat="server" ></asp:TextBox>
                                        <ajaxToolkit:CalendarExtender ID="calJuryTrialDate" runat="server" 
                                            Format="MM/dd/yyyy" PopupButtonID="imgAppearanceDateCalendarIcon" 
                                            TargetControlID="AppearanceDate" Enabled="True" />
                                        <asp:ImageButton ID="imgAppearanceDateCalendarIcon" runat="server" 
                                            AlternateText="Click to show calendar" 
                                            ImageUrl="~/Images/Calendar_scheduleHS.png" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table>
                                <tr>
                                    <td width="50%">
                                        Witness Address1
                                    </td>
                                    
                                    <td width="50%">
                                        <asp:TextBox ID="tbWitnessAddress1" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                         <td>
                            <table>
                                <tr>
                                    <td width="40%">
                                        Appearance Time
                                    </td>
                                    
                                    <td width="50%">
                                        <asp:DropDownList ID="ddlHour" runat="server">
                                            <asp:ListItem Selected="True" >1</asp:ListItem>
                                            <asp:ListItem>2</asp:ListItem>
                                            <asp:ListItem>3</asp:ListItem>
                                            <asp:ListItem>4</asp:ListItem>
                                            <asp:ListItem>5</asp:ListItem>
                                            <asp:ListItem>6</asp:ListItem>
                                            <asp:ListItem>7</asp:ListItem>
                                            <asp:ListItem>8</asp:ListItem>
                                            <asp:ListItem>9</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                            <asp:ListItem>11</asp:ListItem>
                                            <asp:ListItem>12</asp:ListItem>
                                        </asp:DropDownList>:
                                        <asp:DropDownList ID="ddlMinute" runat="server">
                                            <asp:ListItem Selected="True" >00</asp:ListItem>
                                            <asp:ListItem>05</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                            <asp:ListItem>15</asp:ListItem>
                                            <asp:ListItem>20</asp:ListItem>
                                            <asp:ListItem>25</asp:ListItem>
                                            <asp:ListItem>30</asp:ListItem>
                                            <asp:ListItem>35</asp:ListItem>
                                            <asp:ListItem>40</asp:ListItem>
                                            <asp:ListItem>45</asp:ListItem>
                                            <asp:ListItem>50</asp:ListItem>
                                            <asp:ListItem>55</asp:ListItem>
                                        </asp:DropDownList>:
                                        <asp:DropDownList ID="ddlAMPM" runat="server">
                                            <asp:ListItem>AM</asp:ListItem>
                                            <asp:ListItem Selected="True" >PM</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table>
                                <tr>
                                    <td width="50%">
                                        Witness Address2
                                    </td>
                                    
                                    <td width="50%">
                                        <asp:TextBox ID="tbWitnessAddress2" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                         <td>
                            <table>
                                <tr>
                                    <td width="50%">
                                        Courtroom
                                    </td>
                                    
                                    <td width="50%">
                                        <asp:TextBox ID="tbCourtroom" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table>
                                <tr>
                                    <td width="50%">
                                        Witness City
                                    </td>
                                    
                                    <td width="50%">
                                        <asp:TextBox ID="tbWitnessCity" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                         <td>
                            <table width="100%">
                                <tr >
                                    <td width="50%">
                                        Testify
                                    </td>
                                    
                                    <td width="50%">
                                        <asp:CheckBox ID="cbtestify" runat="server" /> 
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table>
                                <tr>
                                    <td width="50%">
                                        Witness State
                                    </td>
                                    
                                    <td width="50%">
                                        <asp:TextBox ID="tbWitnessState" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                         <td>
                            <table width="100%">
                                <tr>
                                    <td width="50%">
                                        Produce
                                    </td>
                                    
                                    <td width="50%">
                                        <asp:CheckBox ID="cbProduce" runat="server" /> 
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table>
                                <tr>
                                    <td width="50%">
                                        Witness Zip
                                    </td>
                                    
                                    <td width="50%">
                                        <asp:TextBox ID="tbWitnessZip" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                         <td>
                                <table>
                                <tr>
                                    <td width="50%">
                                        Discovery Due Date
                                    </td>
                                    
                                    <td width="50%">
                                        <asp:TextBox ID="DiscoveryDueDate" runat="server" ></asp:TextBox>
                                        <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" 
                                            Format="MM/dd/yyyy" PopupButtonID="imgDiscoveryDueDateCalendarIcon" 
                                            TargetControlID="DiscoveryDueDate" Enabled="True" />
                                        <asp:ImageButton ID="imgDiscoveryDueDateCalendarIcon" runat="server" 
                                            AlternateText="Click to show calendar" 
                                            ImageUrl="~/Images/Calendar_scheduleHS.png" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table>
                                <tr>
                                    <td width="50%">
                                        Requesting Attourney
                                    </td>
                                    
                                    <td width="50%">
                                        <asp:TextBox ID="tbAtty" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                         <td>
                            <table>
                                <tr>
                                    <td width="50%">
                                        Attourney Ext.
                                    </td>
                                    
                                    <td width="50%">
                                        <asp:TextBox ID="tbAttyExt" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    </table> 
                            </Content>
                            </ajaxToolkit:AccordionPane>  
                        </Panes>  
                    </ajaxToolkit:Accordion>
                    </td>
                    </tr>
                    
                    <tr style="vertical-align: top;">
                        <td class="style1" colspan="2">
                            <asp:GridView ID="gvSaerchRecs" runat="server" AllowPaging="True" Width="100%" PageSize="20" 
                                AllowSorting="True" AutoGenerateColumns="False" DataSourceID="sqldsSubpoenas" DataKeyNames="ID" >
                                <Columns>
                                    <asp:BoundField DataField="WitnessName" HeaderText="Witness" SortExpression="WitnessName" />
                                    <asp:BoundField DataField="AppearDate" HeaderText="Appear Date" SortExpression="AppearDate" />
                                    <asp:BoundField DataField="Courtroom" HeaderText="Courtroom" SortExpression="Courtroom" />
                                    <asp:BoundField DataField="RequestingAtty" HeaderText="Requesting Atty" SortExpression="RequestingAtty" />
                                    <asp:TemplateField HeaderText="Actions" >
                                        <ItemTemplate>
                                            <asp:ImageButton ID="btnPrintPermit" runat="server" CommandName="Select" Text="Print Permit" ImageUrl="~/Images/printer.png" ToolTip="Print Permit"/>&nbsp;&nbsp;&nbsp;
                                        </ItemTemplate>
                                        <HeaderStyle Width="10%" />
                                    </asp:TemplateField>
                                </Columns>
                                <EmptyDataTemplate>
                                    <table width="100%" >
                                        <tr>
                                            <td align="center" width="100%" colspan="3">
                                                <asp:Label ID="Label3" runat="server" Text="No Subpoenas Found "></asp:Label>
                                            </td>
                                        </tr>
                                       
                                    </table>
                                </EmptyDataTemplate>
                               
                                <HeaderStyle BackColor="DarkGray" Font-Bold="True" />
                                <PagerStyle BackColor="#CCCCCC" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                <RowStyle VerticalAlign="Top"></RowStyle>
                                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                            </asp:GridView>
                            <asp:SqlDataSource ID="sqldsSubpoenas" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                SelectCommand="GetCaseSubpoenas" SelectCommandType="StoredProcedure" 
                                InsertCommand="InsertSubpoena" InsertCommandType="StoredProcedure">
                                <SelectParameters>
                                     <asp:Parameter Name="CaseNumber" Type="String" DefaultValue="" />
                                </SelectParameters>
                                <InsertParameters>
                                     <asp:Parameter Name="CaseNumber" Type="String" />
                                     <asp:Parameter Name="DefendantName" Type="String" />
                                     <asp:Parameter Name="WitnessName" Type="String" />
                                     <asp:Parameter Name="WitnessAddress1" Type="String" />
                                     <asp:Parameter Name="WitnessAddress2" Type="String" />
                                     <asp:Parameter Name="WitnessCity" Type="String" />
                                     <asp:Parameter Name="WitnessState" Type="String" />
                                     <asp:Parameter Name="WitnessZip" Type="String" />
                                     <asp:Parameter Name="AppearDate" Type="String" />
                                     <asp:Parameter Name="Courtroom" Type="String" />
                                     <asp:Parameter Name="Testify" Type="Int32" />
                                     <asp:Parameter Name="Produce" Type="Int32" />
                                     <asp:Parameter Name="DiscoveryDueDate" Type="String" />
                                     <asp:Parameter Name="RequestingAtty" Type="String" />
                                     <asp:Parameter Name="AttyExt" Type="String" />
                                    
                                </InsertParameters>
                            </asp:SqlDataSource>
                            
                            
                        </td>
                    </tr>
                 </table>       
              

            </ContentTemplate>
        </ajaxToolkit:TabPanel>

    </ajaxToolkit:TabContainer>


</asp:Content>




