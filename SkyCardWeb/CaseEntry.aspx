<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="CaseEntry.aspx.vb" Inherits="CaseEntry" title="Case Entry" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content5" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>
    
     <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />
     
    <table cellspacing="0" cellpadding="0" width="100%" border="0" class="TableSearch">
        <tbody>
            <tr>
                <td>
                    <table cellspacing="1" cellpadding="1" width="100%" border="1">
                        <tbody>
                            <tr>
                                <td class="tableCaptionLabel" colspan="6" align="center">
                                    Enter a New Case
                                </td>
                            </tr>
                            <tr>
                                <td align="left" width="17%">
                                    Case Number</td>
                                <td align="left" width="33%">
                                    <asp:TextBox ID="tbCaseNum" runat="server" CssClass="dControl" Width="50%" MaxLength="25"></asp:TextBox>
                                </td>
                                <td align="left" width="17%">
                                    Defendant Name</td>
                                <td align="left" width="33%">
                                    <asp:TextBox ID="tbDefendant" runat="server" CssClass="dControl" Width="50%" MaxLength="25"></asp:TextBox>
                                </td>
                            </tr>
                            <tr valign="top">
                                <td align="left">
                                    Date Initiated</td>
                                <td align="left">
                                    <asp:TextBox ID="DateInitiated" runat="server" Width="50%" Text='<%# Utilities.NullableFormatDateTimeShortDate(Eval("AuctionStartDate")) %>' ></asp:TextBox>
                                    <ajaxToolkit:CalendarExtender ID="calDateInitiated" runat="server" TargetControlID="DateInitiated" Format="MM/dd/yyyy" PopupButtonID="imgDateInitiatedCalendarIcon" />
                                    <asp:ImageButton runat="Server" ID="imgDateInitiatedCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar"/>
                                </td>
                                <td align="left">
                                    Arraignment Date</td>
                                <td align="left">
                                    <asp:TextBox ID="ArraignmentDate" runat="server" Width="50%" Text='<%# Utilities.NullableFormatDateTimeShortDate(Eval("AuctionStartDate")) %>' ></asp:TextBox>
                                    <ajaxToolkit:CalendarExtender ID="calArraignmentDate" runat="server" TargetControlID="ArraignmentDate" Format="MM/dd/yyyy" PopupButtonID="imgArraignmentDateCalendarIcon" />
                                    <asp:ImageButton runat="Server" ID="imgArraignmentDateCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar"/>
                                </td>
                            </tr>
                            <tr valign="top">
                                <td align="left">
                                    Pretrial Date</td>
                                <td align="left">
                                    <asp:TextBox ID="PretrialDate" runat="server" Width="50%" Text='<%# Utilities.NullableFormatDateTimeShortDate(Eval("AuctionStartDate")) %>' ></asp:TextBox>
                                    <ajaxToolkit:CalendarExtender ID="calPretrialDate" runat="server" TargetControlID="PretrialDate" Format="MM/dd/yyyy" PopupButtonID="imgPretrialDateCalendarIcon" />
                                    <asp:ImageButton runat="Server" ID="imgPretrialDateCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar"/>
                                </td>
                                <td align="left">
                                    Bench Trial Date</td>
                                <td align="left">
                                    <asp:TextBox ID="BenchTrialDate" runat="server" Width="50%" Text='<%# Utilities.NullableFormatDateTimeShortDate(Eval("AuctionStartDate")) %>' ></asp:TextBox>
                                    <ajaxToolkit:CalendarExtender ID="calBenchTrialDate" runat="server" TargetControlID="BenchTrialDate" Format="MM/dd/yyyy" PopupButtonID="imgBenchTrialDateCalendarIcon" />
                                    <asp:ImageButton runat="Server" ID="imgBenchTrialDateCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar"/>
                                </td>
                            </tr>
                            <tr valign="top">
                                <td align="left">
                                    Jury Trial Date</td>
                                <td align="left">
                                    <asp:TextBox ID="JuryTrialDate" runat="server" Width="50%" Text='<%# Utilities.NullableFormatDateTimeShortDate(Eval("AuctionStartDate")) %>' ></asp:TextBox>
                                    <ajaxToolkit:CalendarExtender ID="calJuryTrialDate" runat="server" TargetControlID="JuryTrialDate" Format="MM/dd/yyyy" PopupButtonID="imgJuryTrialDateCalendarIcon" />
                                    <asp:ImageButton runat="Server" ID="imgJuryTrialDateCalendarIcon" ImageUrl="~/Images/Calendar_scheduleHS.png" AlternateText="Click to show calendar"/>
                                </td>
                                <td align="left">
                                    Disposition</td>
                                <td align="left" width="33%">
                                    <asp:TextBox ID="tbDisposition" runat="server" CssClass="dControl" Width="50%" MaxLength="25"></asp:TextBox>
                                </td>
                            </tr>
                            <tr valign="top">
                                <td align="left">
                                    Amended</td>
                                <td align="left">
                                    <asp:CheckBox ID="cbAmended" runat="server" Text="" Visible="True" CssClass="dControl" />
                                </td>
                                <td align="left">
                                    Amended To</td>
                                <td align="left">
                                    <asp:TextBox ID="tbAmendedTo" runat="server" CssClass="dControl" Width="50%" MaxLength="25"></asp:TextBox>
                                </td>
                            </tr>
                            <tr valign="top">
                                <td align="left">
                                    Conviction</td>
                                <td align="left">
                                    <asp:CheckBox ID="cbConviction" runat="server" Text="" Visible="True" CssClass="dControl"  />
                                </td>
                                <td align="left">
                                    Case Type</td>
                                <td align="left">
                                    <asp:SqlDataSource ID="sqldsCaseType" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                        SelectCommand="GetCaseTypes" SelectCommandType="StoredProcedure">
                                    </asp:SqlDataSource>
                                    <asp:DropDownList ID="ddlCaseTypes" runat="server" DataSourceID="sqldsCaseType"
                                        DataTextField="CaseType" DataValueField="CaseType" AppendDataBoundItems="True" >
                                        <asp:ListItem Text="" Value="" Selected="True" ></asp:ListItem>
                                    </asp:DropDownList>&nbsp;&nbsp;
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
                                        DataSourceID="sqldsChargeTypes" DataTextField="ChargeType" DataValueField="ChargeType" >
                                        <asp:ListItem Selected="True" Text="" Value=""></asp:ListItem>
                                    </asp:DropDownList>
                                    &nbsp;&nbsp;
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <table cellspacing="1" cellpadding="1" width="100%" border="1">
                        <tbody>
                            <tr>
                                <td align="center" style="width: 50%;">
                                    <asp:Button ID="btnSearch" runat="server" Text="Save"></asp:Button>
                                </td>
                                <td align="center" style="width: 50%">
                                   
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <br />
                    <table cellspacing="1" cellpadding="1" width="100%" border="0">
                        <tbody>
                            <tr>
                                <td>
                                    
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>

    <asp:SqlDataSource ID="sqldsCase" runat="server"
            ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
            ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
            InsertCommand="InsertCase" InsertCommandType="StoredProcedure">
             <InsertParameters>
                 <asp:Parameter Name="CaseNumber" Type="String" />
                 <asp:Parameter Name="DefendantName" Type="String" />
                 <asp:Parameter Name="DateInitiated" Type="String" />
                 <asp:Parameter Name="ArraignmentDate" Type="String" />
                 <asp:Parameter Name="PretrialDate" Type="String" />
                 <asp:Parameter Name="BenchTrialDate" Type="String" />
                 <asp:Parameter Name="JuryTrialDate" Type="String" />
                 <asp:Parameter Name="Disposition" Type="String" />
                 <asp:Parameter Name="Amended" Type="Int32" />
                 <asp:Parameter Name="AmendedToWhat" Type="String" />
                 <asp:Parameter Name="Conviction" Type="Int32" />
                 <asp:Parameter Name="CaseType" Type="String" />
                 <asp:Parameter Name="ChargeType" Type="String" />
                 <asp:Parameter Name="UserID" Type="String" />
            </InsertParameters>
        </asp:SqlDataSource>

    </asp:Content>







