<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="KpopZtation_GroupB.View.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Register</h1>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Gender"></asp:Label>
        <asp:RadioButtonList ID="genderRb" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="addressTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="passwordTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="errorMsg" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click"/>
    </div>
</asp:Content>
