<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="AddAsset.aspx.vb" Inherits="AddAsset" title="Add New Asset" %>

<asp:Content ID="Content3" ContentPlaceHolderID="cphError" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
   <asp:ScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server" />

                <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Add Asset
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width:15%">
                                        <asp:Label ID="Label1" runat="server" Text="Asset Tag Value:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="tbAssetTag" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width:15%">
                                        <asp:Label ID="Label2" runat="server" Text="Description:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="tbDescription" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td style="width:15%">
                                        <asp:Label ID="Label3" runat="server" Text="Quantity:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="tbQty" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                               
                                <tr>
                                    <td><asp:Label ID="Label7" runat="server" Text="Warehouse"></asp:Label></td>
                                 
                                    <td><asp:DropDownList ID="ddlWarehouse" runat="server" DataSourceID="sqldsrootlocations" DataTextField="LocDesc" DataValueField="LocNameID" AutoPostBack="true" ></asp:DropDownList></td>
                                </tr>
                               
                                <tr>
                                    <td><asp:Label ID="Label8" runat="server" Text="Location"></asp:Label></td>
                                 
                                    <td><asp:DropDownList ID="ddlLocation" runat="server" DataSourceID="sqldsLocationsForRoot" DataTextField="LocDesc" DataValueField="LocNameID" AutoPostBack="true" ></asp:DropDownList></td>
                                </tr>
                                     
                                <tr valign="top">
                                    <td colspan="2">
                                        <asp:Button ID="btnSubmit" runat="server" Text="Submit"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" align="left">
                                        <asp:Label ID="lblMessage" runat="server" Text="" Visible="False" ForeColor="Blue" Font-Bold="True"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" align="left">
                                        <asp:Label ID="lblError" runat="server" Text="" Visible="False" ForeColor="Red" Font-Bold="True"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>

                 <asp:SqlDataSource ID="sqldsAsset" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                    InsertCommand="Call InsertAsset(?,?,?,?,?)" InsertCommandType="StoredProcedure"  >
                    <InsertParameters>
                         <asp:Parameter Name="TagNumber" Type="String" />
                         <asp:Parameter Name="Description" Type="String" />
                         <asp:Parameter Name="Quantity" Type="Int32" />
                         <asp:Parameter Name="Location" Type="Int32" />
                         <asp:Parameter Name="UserName" Type="String" />
                    </InsertParameters>
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
</asp:Content>

