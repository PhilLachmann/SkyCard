<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="ChangePassword.aspx.vb" Inherits="ChangePassword" title="Change Password" %>

<asp:Content ID="Content5" ContentPlaceHolderID="cphBody" Runat="Server">
        <table>
        <tr>
        <td style="height:50px;">&nbsp;
        </td>
        </tr>
        </table>
    
        <table width="50%" align="center" style="border-right: #056839 thin solid; border-top: #056839 thin solid; border-left: #056839 thin solid; border-bottom: #056839 thin solid;">
            <tr>
                <td colspan="3" align="center">
                    <asp:Label ID="lblTitle" runat="server" Text="Change My Password" BackColor="#056839" Font-Bold="True" Font-Size="Large" ForeColor="White" Width="100%"></asp:Label></td>
            </tr>
            <tr>
                <td width="20%">
                </td>
                <td width="60%">
                </td>
                <td width="20%">
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td align="center" style="border: 4px double #056839">
                    <asp:Panel ID="pnlTextBoxControls" runat="server">
                    <table width="100%">
                        <tr>
                            <td colspan="2" align="center">
                                <asp:Label ID="Label4" runat="server" Text="Change My Password" Font-Bold="True"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td width="50%" align="right">
                                <asp:Label ID="Label1" runat="server" Text="Current Password:"></asp:Label>
                            </td>
                            <td width="50%" align="left">
                                <asp:TextBox ID="txtCurrentPassword" runat="server" Width="90%" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="Label2" runat="server" Text="New Password:"></asp:Label>
                            </td>
                            <td align="left">
                                <asp:TextBox ID="txtNewPassword" runat="server" Width="90%" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="Label3" runat="server" Text="Confirm New Password:"></asp:Label>
                            </td>
                            <td align="left">
                                <asp:TextBox ID="txtConfirmPassword" runat="server" Width="90%" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="center">
                                <asp:Label ID="lblError" runat="server" Text="" Visible="False" ForeColor="Red" Font-Bold="True"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="center">
                                <asp:Button ID="btnChangePassword" runat="server" Text="Change Password" />
                                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                            </td>
                        </tr>
                    </table>
                    </asp:Panel>
                    <asp:Panel ID="pnlContinue" runat="server" Visible="False">
                        <asp:Button ID="btnContinue" runat="server" Text="Continue" />
                    </asp:Panel>
                
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
        </table>
        
        <table>
        <tr>
        <td style="height:100px;">&nbsp;
        </td>
        </tr>
        </table>

    <asp:SqlDataSource ID="sqldsUserCredentials" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
        UpdateCommand="UpdateUserPassword" UpdateCommandType="StoredProcedure">
        <UpdateParameters>
            <asp:SessionParameter Name="LoginID" SessionField="Username" Type="String" />
            <asp:Parameter Name="OldPassword" Type="String" />
            <asp:Parameter Name="NewPassword" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>


</asp:Content>

