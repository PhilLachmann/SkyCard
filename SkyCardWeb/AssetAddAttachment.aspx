<%@ Page Language="VB" MasterPageFile="~/GMechMasterNoMenu.master" AutoEventWireup="false" CodeFile="AssetAddAttachment.aspx.vb" Inherits="AssetAddAttachment" title="Add Asset Attachment" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <table width="100%">
        <tr>
            <td colspan="4" align="center" class="PageHeaderText">
                <asp:Label ID="lblPageHeaderText" runat="server" Text="Select File To Attach to This Asset"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" ><br />
            </td>
        </tr>
        <tr>
            <td style="width:20%;" class="PageLabelText" align="right">
                <asp:Label ID="Label3" runat="server" Text="Add Attachment:"></asp:Label>&nbsp;
            </td>
            <td style="width:5%;" >&nbsp;</td>
            <td style="width:75%;" align="left">

                     <asp:FileUpload ID="filAssetAttachDocsAddFileName" runat="server" Width="100%"  />
                
        
            </td>
        </tr>
        <tr>
            <td style="width:20%;" class="PageLabelText" align="right">
                <asp:Label ID="Label1" runat="server" Text="Comment:"></asp:Label>&nbsp;
            </td>
            <td style="width:5%;" >&nbsp;</td>
            <td style="width:75%;" align="left">
                 <asp:TextBox ID="txtComment" runat="server" MaxLength="200" Width="80%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="3">
                <asp:Button ID="btnSave" runat="server" Text="Save" PostBackUrl="UploadHandler.ashx" />&nbsp;&nbsp;
                <asp:Button ID="btnCancel" runat="server" Text="Cancel"   />
            </td>
        </tr>
        
    </table>

</asp:Content>

