<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="InsertArtistPage.aspx.cs" Inherits="KpopZtation_GroupB.View.InsertArtistPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Insert Artist</h1>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Image"></asp:Label>
        <asp:FileUpload ID="imageUpload" runat="server" />
        <br />
        <asp:Label ID="errorMsg" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="insertArtistBtn" runat="server" Text="Insert Artist" OnClick="insertArtistBtn_Click"/>
    </div>
</asp:Content>
