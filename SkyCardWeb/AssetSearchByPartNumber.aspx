<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="AssetSearchByPartNumber.aspx.vb" Inherits="AssetSearchByPartNumber" title="Search Assets By Part Number" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>

<script type="text/javascript" language="javascript">
// <!--

    function onKeySignin() 
    {
    if (window.event.keyCode == 13)
        {
        document.getElementById('<%=btnRunReport.ClientID%>').focus();
        document.getElementById('<%=btnRunReport.ClientID%>').click();
        }
    }

    document.attachEvent("onkeydown", onKeySignin);

// -->
</script>

                <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Asset Search By Part Number
                                    </td>
                                </tr>
                               <tr valign="top">
                                    <td width="100%" class="tableCaptionLabel" >
                                        <table width="100%">
                                            <tr>
                                                
                                                <td align="left" width="80%">
                                                
                                                    &nbsp;<asp:Label ID="Label1" runat="server" Text="Enter the Part Number:"></asp:Label>
                                                    
                                                    <asp:TextBox ID="tbPartNumber" runat="server"></asp:TextBox>
                                                   
                                                    <asp:Button ID="btnRunReport" runat="server" Text="Run Report" Width="100px"  />
                                                    
                                                </td>
                                            </tr>



                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>

                 <asp:SqlDataSource ID="sqldsLookupTableData" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetAllTags()" SelectCommandType="StoredProcedure" 
                    InsertCommand="Call InsertTagName(?,?)" InsertCommandType="StoredProcedure"  
                    UpdateCommand="Call UpdateTagName(?,?,?)" UpdateCommandType="StoredProcedure">
                    <UpdateParameters>
                         <asp:Parameter Name="TagNameID" Type="Int32" />
                         <asp:Parameter Name="TagName" Type="String" />
                         <asp:Parameter Name="TagType" Type="String" />
                    </UpdateParameters>
                    <InsertParameters>
                         <asp:Parameter Name="TagName" Type="String" />
                         <asp:Parameter Name="TagType" Type="String" />
                    </InsertParameters>
                </asp:SqlDataSource>
                
                <asp:SqlDataSource ID="sqldsSearchSchema" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetSearchSchema()" SelectCommandType="StoredProcedure"> 
                </asp:SqlDataSource>

                <asp:SqlDataSource ID="sqldsTagList" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetSearchableTags()" SelectCommandType="StoredProcedure"> 
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="sqldsTagByDescription" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetSearchableTagByDescription(?)" SelectCommandType="StoredProcedure"> 
                    <SelectParameters>
                        <asp:Parameter Name="TagDesc" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>

</asp:Content>

