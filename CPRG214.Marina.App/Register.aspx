<%@ Page Title="Registration" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CPRG214.Marina.App.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="jumbotron col-md-4">
    <h3>Registration</h3>
    <table class="table">
        <tr>
            <td style="width:150px">First Name:</td>
            <td>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Please enter your first name" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Last Name:</td>
            <td>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ErrorMessage="Please enter your last name" ForeColor="Red" ControlToValidate="txtLastName">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>City:</td>
            <td>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvCity" runat="server" ErrorMessage="Please enter city name" ForeColor="Red" ControlToValidate="txtCity">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Phone Number:</td>
            <td>
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ErrorMessage="Please enter your phone number" ForeColor="Red" ControlToValidate="txtPhone">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <%--<asp:Label ID="lblSuccess" runat="server" ForeColor="Green"></asp:Label>--%>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            </td>
        </tr>
    </table>
</div>
</asp:Content>

