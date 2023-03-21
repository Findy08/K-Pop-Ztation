<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="InsertAlbumPage.aspx.cs" Inherits="KpopZtation_GroupB.View.InsertAlbumPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Insert Album</h1>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
        <asp:TextBox ID="descriptionTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="priceTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Stock"></asp:Label>
        <asp:TextBox ID="stockTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Image"></asp:Label>
        <asp:FileUpload ID="imageUpload" runat="server" />
        <br />
        <asp:Label ID="errorMsg" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="insertAlbumBtn" runat="server" Text="Insert Album" OnClick="insertAlbumBtn_Click"/>
    </div>
</asp:Content>
