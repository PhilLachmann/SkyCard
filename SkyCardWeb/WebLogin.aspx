<%@ Page Language="VB" AutoEventWireup="false" CodeFile="WebLogin.aspx.vb" Inherits="WebLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Case Management</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
        <tr>
        <td style="height:150px;">&nbsp;
        </td>
        </tr>
        </table>
   
        <table width="50%" align="center" style="border-right: #056839 thin solid; border-top: #056839 thin solid; border-left: #056839 thin solid; border-bottom: #056839 thin solid;">
            <tr>
                <td colspan="3" align="center">
                    <asp:Label ID="lblTitle" runat="server" Text="Scorecard System Login" BackColor="#056839" Font-Bold="True" Font-Size="Large" ForeColor="White" Width="100%"></asp:Label></td>
            </tr>
            <tr>
                <td width="30%">
                </td>
                <td width="40%">
                </td>
                <td width="30%">
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td align="center">
                    <asp:Login ID="lgnLogin" runat="server" BorderColor="#056839" BorderStyle="Double" LoginButtonText="Logon" TitleText="Logon" Width="268px" DisplayRememberMe="False">
                        <TextBoxStyle Width="100px" />
                    </asp:Login>
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
        <br />
        &nbsp;
    </div>
    <asp:SqlDataSource ID="sqldsUserCredentials" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>"
        SelectCommand="GetSystemUserCredentials" SelectCommandType="StoredProcedure" 
        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>">
        <SelectParameters>
            <asp:ControlParameter Name="LoginID" ControlID="lgnLogin" PropertyName="UserName" Type="String" />
            <asp:ControlParameter Name="Password" ControlID="lgnLogin" PropertyName="Password" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    
   
    </form>
</body>
</html>
