<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="AssetSearchPhoto.aspx.vb" Inherits="AssetSearchPhoto" title="Search Asset by Photo" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"/>

<script type="text/javascript" language="javascript">
// <!--

    function onKeySignin() 
    {
    if (window.event.keyCode == 13)
        {
        document.getElementById('<%=btnQuery.ClientID%>').focus();
        document.getElementById('<%=btnQuery.ClientID%>').click();
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
                                        Asset Search by Photo
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="2">
                                        <asp:Label ID="Label2" runat="server" Text="In Building: "></asp:Label>
                                        <asp:SqlDataSource ID="sqldsBuildings" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                            ProviderName="<%$ ConnectionStrings:CaseMgmtConnectionString.ProviderName %>"
                                            SelectCommand="Call GetAllRootLocations()" SelectCommandType="StoredProcedure">
                                        </asp:SqlDataSource>
                                        <asp:DropDownList ID="BuildingID" runat="server" AppendDataBoundItems="True" DataSourceID="sqldsBuildings"
                                                DataTextField="LocDesc" DataValueField="LocNameID" >
                                                <asp:ListItem Selected="True" Text="All" Value="0"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>

                                <tr valign="top">
                                    <td colspan="2">
                                    
                                                                                
                                                                                 
                                        <asp:ListView ID="lvQuery" runat="server" >
                                            <LayoutTemplate>
                                                <asp:Placeholder
                                                id="groupPlaceholder"
                                                runat="server" />
                                            </LayoutTemplate>
                                            <GroupTemplate>
                                                <div>
                                                <asp:Placeholder
                                                id="itemPlaceholder"
                                                runat="server" />
                                                </div>
                                            </GroupTemplate>
                                            <ItemTemplate>
                                                <asp:DropDownList ID="tagname" runat="server" DataSourceID="sqldsTagList" SelectedValue='<%# Bind("Tagname") %>'
                                                            DataTextField="TagDesc" DataValueField="TagDesc"  AppendDataBoundItems ="true" AutoPostBack="true" OnSelectedIndexChanged="lstTagname_SelectedIndexChanged">
                                                            <asp:ListItem Text="All" Value="All" />
                                                </asp:DropDownList>
                                                
                                               <asp:DropDownList ID="Operation" runat="server" SelectedValue='<%# Bind("Operation") %>' AutoPostBack="true" OnSelectedIndexChanged="lstOperation_SelectedIndexChanged">
                                                            <asp:ListItem Text="Equals" Value="Equals" Selected="True"/>
                                                            <asp:ListItem Text="Like" Value="Like"  />
                                               </asp:DropDownList>
                                                
                                                <asp:TextBox ID="TagValue" runat="server" Text='<%# Bind("TagValue") %>' Width="75%"></asp:TextBox>
                                                
                                                <asp:DropDownList ID="ddlAlphabet" runat="server" Visible="false" AutoPostBack="true" OnSelectedIndexChanged="lstAlphabet_SelectedIndexChanged">
                                                    <asp:ListItem Text="A" Value="A" Selected="True"/>
                                                    <asp:ListItem Text="B" Value="B"  />
                                                    <asp:ListItem Text="C" Value="C"  />
                                                    <asp:ListItem Text="D" Value="D"  />
                                                    <asp:ListItem Text="E" Value="E"  />
                                                    <asp:ListItem Text="F" Value="F"  />
                                                    <asp:ListItem Text="G" Value="G"  />
                                                    <asp:ListItem Text="H" Value="H"  />
                                                    <asp:ListItem Text="I" Value="I"  />
                                                    <asp:ListItem Text="J" Value="J"  />
                                                    <asp:ListItem Text="K" Value="K"  />
                                                    <asp:ListItem Text="L" Value="L"  />
                                                    <asp:ListItem Text="M" Value="M"  />
                                                    <asp:ListItem Text="N" Value="N"  />
                                                    <asp:ListItem Text="O" Value="O"  />
                                                    <asp:ListItem Text="P" Value="P"  />
                                                    <asp:ListItem Text="Q" Value="Q"  />
                                                    <asp:ListItem Text="R" Value="R"  />
                                                    <asp:ListItem Text="S" Value="S"  />
                                                    <asp:ListItem Text="T" Value="T"  />
                                                    <asp:ListItem Text="U" Value="U"  />
                                                    <asp:ListItem Text="V" Value="V"  />
                                                    <asp:ListItem Text="W" Value="W"  />
                                                    <asp:ListItem Text="X" Value="X"  />
                                                    <asp:ListItem Text="Y" Value="Y"  />
                                                    <asp:ListItem Text="Z" Value="Z"  />
                                                    <asp:ListItem Text="0" Value="0"  />
                                                    <asp:ListItem Text="1" Value="1"  />
                                                    <asp:ListItem Text="2" Value="2"  />
                                                    <asp:ListItem Text="3" Value="3"  />
                                                    <asp:ListItem Text="4" Value="4"  />
                                                    <asp:ListItem Text="5" Value="5"  />
                                                    <asp:ListItem Text="6" Value="6"  />
                                                    <asp:ListItem Text="7" Value="7"  />
                                                    <asp:ListItem Text="8" Value="8"  />
                                                    <asp:ListItem Text="9" Value="9"  />
                                                </asp:DropDownList>
                                            </ItemTemplate>
                                            <EmptyItemTemplate>           
                                               
                                            </EmptyItemTemplate>
                                        </asp:ListView>
                                        
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnQuery" runat="server" Text="Submit" />
                                    </td>
                                    <td align="right">
                                        <asp:Button ID="btnAddRow" runat="server" Text="Add Row" />
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

