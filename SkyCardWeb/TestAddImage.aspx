<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="TestAddImage.aspx.vb" Inherits="TestAddImage" title="Scorecard Item Add Attachment" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server" />
    <table width="100%">
        <tr>
            <td colspan="4" align="center" class="PageHeaderText">
                <asp:Label ID="lblPageHeaderText" runat="server" Text="Select Image File To save to Asset"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" ><br />
            </td>
        </tr>
        <tr>
            <td style="width:20%;" class="PageLabelText" align="right">
                <asp:Label ID="Label1" runat="server" Text="Asset Number:"></asp:Label>&nbsp;
            </td>
            <td style="width:5%;" >&nbsp;</td>
            <td style="width:75%;" align="left">
                
                <asp:TextBox ID="txtAssetNumber" runat="server"></asp:TextBox>
        
            </td>
        </tr>
        <tr>
            <td style="width:20%;" class="PageLabelText" align="right">
                <asp:Label ID="Label3" runat="server" Text="Add Image File:"></asp:Label>&nbsp;
            </td>
            <td style="width:5%;" >&nbsp;</td>
            <td style="width:75%;" align="left">
                
                     <asp:FileUpload ID="filScorecardAttachDocsAddFileName" runat="server" Width="100%" />
        
            </td>
        </tr>
        <tr>
            <td align="center" colspan="3">
                <asp:Button ID="btnSave" runat="server" Text="Save" PostBackUrl="UploadHandler.ashx" />&nbsp;&nbsp;
                <asp:Button ID="btnCancel" runat="server" Text="Cancel"  />
            </td>
        </tr>
        
    </table>



</asp:Content>

