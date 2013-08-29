<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="AssetByLocationFlexReport2.aspx.vb" Inherits="AssetByLocationFlexReport2" title="Assets By Location Report" %>

<%@ Register Assembly="DevExpress.XtraReports.v10.2.Web" Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>
    <asp:HiddenField ID="hfdFirstTime" runat="server" Value="0" />

        <script type="text/javascript">
            var interval
            function exportToExcel() 
            {
                //document.getElementById('ctl00_cphBody_rptvwrOrders_Div').style.cursor = 'wait'; 
	            window.status = "Sending report to Excel...";
	            viewer3.SaveToDisk('XLSX');
	            interval = self.setInterval("clearStatus()",10000);
            }
            
            function clearStatus()
            {
                window.status = "Done";
                interval = window.clearInterval(interval);
            }
            
             function onKeySignin() 
            {
            if (window.event.keyCode == 13)
                {
                document.getElementById('<%=btnRunReport.ClientID%>').focus();
                document.getElementById('<%=btnRunReport.ClientID%>').click();
                }
            }

            document.attachEvent("onkeydown", onKeySignin);

        </script>
                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Assets by Location Report Excel
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td width="100%" class="tableCaptionLabel" >
                                        <table width="100%">
                                            <tr>
                                                <td align="left" width="20%">
                                                    <asp:Button ID="btnReturn" runat="server" Text="Return" Width="80px"  />
                                                </td>
                                                <td align="right" width="80%">
                                                
                                                    &nbsp;<asp:Label ID="Label1" runat="server" Text="Show Assets For This Building:"></asp:Label>
                                                    <asp:SqlDataSource ID="sqldsBuildings" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                        SelectCommand="Call GetAllRootLocations()" SelectCommandType="StoredProcedure">
                                                    </asp:SqlDataSource>
                                                    <asp:DropDownList ID="BuildingID" runat="server" AutoPostBack="True" AppendDataBoundItems="True" 
                                                            DataTextField="LocDesc" DataValueField="LocNameID" >
                                                            <asp:ListItem Selected="True" Text="All" Value="0"></asp:ListItem>
                                                    </asp:DropDownList>
                                                    &nbsp;<asp:Label ID="Label2" runat="server" Text=" and This Location:"></asp:Label>
                                                    <asp:SqlDataSource ID="sqldsLocations" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                        ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                        SelectCommand="Call GetAllLocationsForRoot(?)" SelectCommandType="StoredProcedure">
                                                        <SelectParameters>
                                                            <asp:ControlParameter Name="theroot" Type="Int32" ControlID="BuildingID" PropertyName="SelectedValue" />
                                                        </SelectParameters>
                                                    </asp:SqlDataSource>
                                                    <asp:DropDownList ID="LocationID" runat="server" AutoPostBack="True" AppendDataBoundItems="True" 
                                                            DataTextField="LocDesc" DataValueField="LocNameID" >
                                                            <asp:ListItem Selected="True" Text="All" Value="0"></asp:ListItem>
                                                    </asp:DropDownList>&nbsp;&nbsp;
                                                   
                                                    <asp:Button ID="btnRunReport" runat="server" Text="Run Report" Width="100px"  />
                                                    <ajaxToolkit:ConfirmButtonExtender ID="cbeRunReport" runat="server" 
                                                        TargetControlID="btnRunReport"
                                                        ConfirmText="Depending on the amount of assets selected, this report may take a couple of minutes to generate.  Do you want to continue?" 
                                                        OnClientCancel="cancelClick" />
                                                    
                                                </td>
                                            </tr>

                                            <tr>
                                                <td align="left" width="20%">&nbsp;
                                                </td>
                                                <td align="right" width="80%">
                                                    <table width="100%">
                                                        <tr valign="top">
                                                            <td align="right" width="90%">
                                                                <asp:Label ID="Label3" runat="server" Text="In addition to Description and Last Modified Date, Show the following Asset Properties:"></asp:Label>
                                                            </td>
                                                            <td align="right" width="10%" >
                                                                <asp:SqlDataSource ID="sqldsTagNames" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                                                    SelectCommand="Call GetTagNameList(?)" SelectCommandType="StoredProcedure">
                                                                    <SelectParameters>
                                                                         <asp:Parameter Name="FilterFlag" Type="String" DefaultValue="1" />
                                                                    </SelectParameters>
                                                                </asp:SqlDataSource>
                                                                <asp:ListBox ID="SelectedTagNames" runat="server" AppendDataBoundItems="True" DataSourceID="sqldsTagNames" SelectionMode="Multiple" 
                                                                        Rows="5" DataTextField="TagDesc" DataValueField="TagNameID" >
                                                                    <asp:ListItem Text="All" Value="0"></asp:ListItem>
                                                                </asp:ListBox>
                                                            </td>
                                                        
                                                        </tr>
                                                    </table>
                                                
                                                </td>

                                            </tr>

                                        </table>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td width="100%" align="center" >
                                    
                                    
                                        <asp:Panel ID="pnlReport" runat="server" Width="100%" HorizontalAlign="Left" >
                                            <asp:Button ID="ExportReport" runat="server" Text="Export To Excel" Visible="false" OnClientClick="javascript:exportToExcel();return false;" />

                                            <table>
                                                <tr>
                                                    <td>
                                                        <dxxr:ReportViewer ID="rptvwrOrders" runat="server" ClientInstanceName="viewer1" >
                                                        </dxxr:ReportViewer>
                                                    </td>

                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Panel ID="pnlFullSize" runat="server" Visible="true" Height="1px" Width="1px"  >
                                                            <dxxr:ReportViewer ID="rptvwrExcel" runat="server" Visible="True" ClientInstanceName="viewer3" AutoSize="False" Height="0px" Width="0px">
                                                            </dxxr:ReportViewer>
                                                        </asp:Panel>
                                                    </td>

                                                </tr>
                                            </table>
                                            
                                        </asp:Panel>
                                    
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>


                 <asp:SqlDataSource ID="sqldsReportData" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    SelectCommand="Call GetAssetsByLocationFlexReport2(?,?)" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="theLocationID" Type="Int32" />
                         <asp:Parameter Name="theTagNameIDList" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>






</asp:Content>

