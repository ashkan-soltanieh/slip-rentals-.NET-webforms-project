<%@ Page Title="Available Slips" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AvailableSlips.aspx.cs" Inherits="CPRG214.Marina.App.AvailableSlips" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron col-md-4">
        <h3>Docks</h3>
        <asp:GridView ID="gvDocks" runat="server" CellPadding="4" CssClass="" ForeColor="#333333" GridLines="None" Width="440px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#C2CBD2" Font-Bold="True" ForeColor="Black" HorizontalAlign="Center" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <div class="col-md-7">
           <table class ="table">
                <tr>
                    <td style="width:150px">Select a Dock:</td>
                    <td>
                        <asp:DropDownList ID="ddlDocks" runat="server" Width="150px" style="margin-left: 3px" AutoPostBack="True" OnSelectedIndexChanged="ddlDocks_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
            </table>
            <h3>Available Slips</h3>
            <asp:GridView ID="gvSlips" runat="server" Width="419px" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#C2CBD2" Font-Bold="True" ForeColor="Black" HorizontalAlign="Center" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center"/>
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                <Columns>

                        <asp:TemplateField >
                            <ItemTemplate>
                                <asp:CheckBox ID="cbSelectSlip" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>

                  </Columns>
            </asp:GridView>
            <br />
            <asp:Button ID="btnLeaseSelected" runat="server" OnClick="btnLeaseSelected_Click" Text="Lease Selected" />
        </div>
    </div>
    

</asp:Content>
