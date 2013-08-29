<%@ Page Language="VB" MasterPageFile="~/GMechMaster.master" AutoEventWireup="false" CodeFile="ContactEdit.aspx.vb" Inherits="ContactEdit" title="CaseMgmt" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBody" Runat="Server">
 <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" EnablePartialRendering="true" runat="server"/>
    
                <asp:Label ID="lblContentBodyError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" />

                <table class="TabPanelTable">
                    <tr style="vertical-align: top;">
                        <td>
                            <table cellpadding="3" cellspacing="1" border="0" width="100%">
                                <tr>
                                    <td align="center" width="100%" class="tableCaptionLabel" colspan="2">
                                        Edit Contact
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnUpdateContact" runat="server" Text="Update Contact" />&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button ID="btnCancelContact" runat="server" Text="Cancel Update" />
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="2">

                                        <asp:DetailsView ID="dvContact" runat="server" AutoGenerateRows="False" DataKeyNames="ContactID"
                                            DefaultMode="Edit" DataSourceID="sqldsLookupTableData" 
                                            Width="100%" Visible="True" CssClass="gview">
                                            <Fields>
                                                <asp:BoundField DataField="ContactID" HeaderText="ID" InsertVisible="False"
                                                    ReadOnly="True" SortExpression="ContactID" Visible="False" />
                                                <asp:TemplateField HeaderText="Contact Name: ">
                                                    <ItemTemplate>
                                                        &nbsp;&nbsp;<asp:TextBox ID="ContactName" Text='<%# Bind("ContactName") %>' runat="server" Width="50%" MaxLength="200"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="First Name: ">
                                                    <ItemTemplate>
                                                     &nbsp;&nbsp;<asp:TextBox ID="FirstName" Text='<%# Bind("FirstName") %>' runat="server" Width="50%" MaxLength="200"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Middle Name: ">
                                                    <ItemTemplate>
                                                     &nbsp;&nbsp;<asp:TextBox ID="MiddleName" Text='<%# Bind("MiddleName") %>' runat="server" Width="50%" MaxLength="200"></asp:TextBox>
                                                   </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                 <asp:TemplateField HeaderText="Last Name: ">
                                                    <ItemTemplate>
                                                     &nbsp;&nbsp;<asp:TextBox ID="LastName" Text='<%# Bind("LastName") %>' runat="server" Width="50%" MaxLength="200"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Date of Birth: ">
                                                    <ItemTemplate>
                                                    <asp:TextBox ID="DateOfBirth" runat="server" 
                                                                Text='<%# Bind("DateOfBirth", "{0:d}") %>' Width="50%"></asp:TextBox>
                                                            <ajaxToolkit:CalendarExtender ID="calDateOfBirth" runat="server" 
                                                                Format="MM/dd/yyyy" PopupButtonID="imgDateInitiatedCalendarIcon" 
                                                                TargetControlID="DateOfBirth" />
                                                            <asp:ImageButton ID="imgDateInitiatedCalendarIcon" runat="Server" 
                                                                AlternateText="Click to show calendar" 
                                                                ImageUrl="~/Images/Calendar_scheduleHS.png" />
                                                     </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Social Security Number: ">
                                                    <ItemTemplate>
                                                      &nbsp;&nbsp;<asp:TextBox ID="SocialSecurityNumber" Text='<%# Bind("SocialSecurityNumber") %>' runat="server" Width="50%" MaxLength="200"></asp:TextBox>
                                                  </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                               <asp:TemplateField HeaderText="Address Line 1: ">
                                                    <ItemTemplate>
                                                       &nbsp;&nbsp;<asp:TextBox ID="Address1" Text='<%# Bind("Address1") %>' runat="server" Width="50%" MaxLength="200"></asp:TextBox>
                                                  </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Address Line 2: ">
                                                    <ItemTemplate>
                                                        &nbsp;&nbsp;<asp:TextBox ID="Address2" Text='<%# Bind("Address2") %>' runat="server" Width="50%" MaxLength="200"></asp:TextBox>
                                                   </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Address Line 3: ">
                                                    <ItemTemplate>
                                                        &nbsp;&nbsp;<asp:TextBox ID="Address3" Text='<%# Bind("Address3") %>' runat="server" Width="50%" MaxLength="200"></asp:TextBox>
                                                   </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="City: ">
                                                    <ItemTemplate>
                                                        &nbsp;&nbsp;<asp:TextBox ID="City" Text='<%# Bind("City") %>' runat="server" Width="50%" MaxLength="200"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="State: ">
                                                    <ItemTemplate>
                                                        <asp:SqlDataSource ID="sqldsStateList" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                                                            SelectCommand="GetStates" SelectCommandType="StoredProcedure">
                                                        </asp:SqlDataSource>&nbsp;
                                                        <asp:DropDownList ID="State" runat="server" DataSourceID="sqldsStateList" SelectedValue='<%# Bind("State") %>' DataTextField="StateDesc" DataValueField="StateCode" AppendDataBoundItems="True"  >
                                                            <asp:ListItem Text="" Value="" ></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Zip Code: ">
                                                    <ItemTemplate>
                                                       &nbsp;&nbsp;<asp:TextBox ID="Zip" Text='<%# Bind("Zip") %>' runat="server" Width="50%" MaxLength="10"></asp:TextBox>
                                                   </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Country: ">
                                                    <ItemTemplate>
                                                      &nbsp;&nbsp;<asp:TextBox ID="Country" Text='<%# Bind("Country") %>' runat="server" Width="50%" MaxLength="200"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                                                             
                                                <asp:TemplateField HeaderText="Phone1: ">
                                                    <ItemTemplate>
                                                       &nbsp;&nbsp;<asp:TextBox ID="Phone1" Text='<%# Bind("Phone1") %>' runat="server" Width="50%" MaxLength="20"></asp:TextBox>
                                              <%--          <ajaxToolkit:MaskedEditExtender ID="mskedWorkPhone" runat="server" TargetControlID="ContactWorkPhone" Mask="999-999-9999" ClearMaskOnLostFocus="false" />
                                             --%>     </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Phone2: ">
                                                    <ItemTemplate>
                                                        &nbsp;&nbsp;<asp:TextBox ID="Phone2" Text='<%# Bind("Phone2") %>' runat="server" Width="50%" MaxLength="20"></asp:TextBox>
                                               <%--         <ajaxToolkit:MaskedEditExtender ID="mskedCellPhone" runat="server" TargetControlID="ContactCellPhone" Mask="999-999-9999" ClearMaskOnLostFocus="false" />
                                              --%>      </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Phone3: ">
                                                    <ItemTemplate>
                                                      &nbsp;&nbsp;<asp:TextBox ID="Phone3" Text='<%# Bind("Phone3") %>' runat="server" Width="50%" MaxLength="20"></asp:TextBox>
                                                     <%--   <ajaxToolkit:MaskedEditExtender ID="mskedHomePhone" runat="server" TargetControlID="ContactHomePhone" Mask="999-999-9999" ClearMaskOnLostFocus="false" />
                                                --%>   </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Email1: ">
                                                    <ItemTemplate>
                                                        &nbsp;&nbsp;<asp:TextBox ID="Email1" Text='<%# Bind("Email1") %>' runat="server" Width="50%" MaxLength="200"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Email2: ">
                                                    <ItemTemplate>
                                                        &nbsp;&nbsp;<asp:TextBox ID="Email2" Text='<%# Bind("Email2") %>' runat="server" Width="50%" MaxLength="200"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Email3: ">
                                                    <ItemTemplate>
                                                       &nbsp;&nbsp;<asp:TextBox ID="Email3" Text='<%# Bind("Email3") %>' runat="server" Width="50%" MaxLength="200"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Gender: ">
                                                    <ItemTemplate>
                                                        &nbsp;&nbsp;<asp:TextBox ID="Gender" Text='<%# Bind("Gender") %>' runat="server" Width="50%" MaxLength="200"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Race: ">
                                                    <ItemTemplate>
                                                        &nbsp;&nbsp;<asp:TextBox ID="Race" Text='<%# Bind("Race") %>' runat="server" Width="50%" MaxLength="200"></asp:TextBox>
                                                   </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                                      <asp:TemplateField HeaderText="Alias Name: ">
                                                    <ItemTemplate>
                                                        &nbsp;&nbsp;<asp:TextBox ID="AliasName" Text='<%# Bind("AliasName") %>' runat="server" Width="50%" MaxLength="200"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>                       
                                                <asp:TemplateField HeaderText="Deleted: ">
                                                    <ItemTemplate>
                                                        &nbsp;
                                                        <asp:DropDownList ID="Deleted" runat="server" SelectedValue='<%# Bind("Deleted") %>'  >
                                                            <asp:ListItem Text="True" Value="True" ></asp:ListItem>
                                                            <asp:ListItem Text="False" Value="False" Selected="True"></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Last Modified On: ">
                                                    <ItemTemplate>
                                                        &nbsp;&nbsp;<asp:Label ID="LastModified" runat="server" Text='<%# Bind("Last_Modified") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="30%" VerticalAlign="Top" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                
                                               
                                            </Fields>
                                        </asp:DetailsView>
                                    
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                
                 <asp:SqlDataSource ID="sqldsLookupTableData" runat="server" ConnectionString="<%$ ConnectionStrings:CaseMgmtConnectionString %>" 
                    SelectCommand="GetContactMaster" SelectCommandType="StoredProcedure" 
                    UpdateCommand="UpdateContact" UpdateCommandType="StoredProcedure">
                    <SelectParameters>
                         <asp:Parameter Name="ContactID" Type="Int32" DefaultValue="" />
                    </SelectParameters>
                    <UpdateParameters>
                         <asp:Parameter Name="ContactID" Type="Int32" />
                         <asp:Parameter Name="ContactName" Type="String" />
                         <asp:Parameter Name="FirstName" Type="String" />
                         <asp:Parameter Name="MiddleName" Type="String" />
                         <asp:Parameter Name="LastName" Type="String" />
                         <asp:Parameter Name="DateOfBirth" Type="String" />
                         <asp:Parameter Name="SocialSecurityNumber" Type="String" />
                         <asp:Parameter Name="Address1" Type="String" />
                         <asp:Parameter Name="Address2" Type="String" />
                         <asp:Parameter Name="Address3" Type="String" />
                         <asp:Parameter Name="City" Type="String" />
                         <asp:Parameter Name="State" Type="String" />
                         <asp:Parameter Name="Zip" Type="String" />
                         <asp:Parameter Name="Country" Type="String" />
                         <asp:Parameter Name="Phone1" Type="String" />
                         <asp:Parameter Name="Phone2" Type="String" />
                         <asp:Parameter Name="Phone3" Type="String" />
                         <asp:Parameter Name="Email1" Type="String" />
                         <asp:Parameter Name="Email2" Type="String" />
                         <asp:Parameter Name="EMail3" Type="String" />
                         <asp:Parameter Name="Gender" Type="String" />
                         <asp:Parameter Name="Race" Type="String" />
                         <asp:Parameter Name="AliasName" Type="String" />
                         <asp:Parameter Name="Deleted" Type="Boolean" />
                         <asp:Parameter Name="UserID" Type="String" />
                        </UpdateParameters>
                </asp:SqlDataSource>
                

</asp:Content>

