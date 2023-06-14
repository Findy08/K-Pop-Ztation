<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="AlbumDetailPage.aspx.cs" Inherits="KpopZtation_GroupB.View.AlbumDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Album Detail</h1>
        <asp:Label ID="Label5" runat="server" Text="Label">Album Name: </asp:Label>
        <asp:Label ID="nameLb" runat="server" Text="Label"></asp:Label>
        <br />

        <asp:Image ID="albumImg" runat="server" CssClass="imgWidth-500"/>
        <br />

        <asp:Label ID="Label6" runat="server" Text="Label">Album Description: </asp:Label>
        <asp:Label ID="descLb" runat="server" Text="Label"></asp:Label>
        <br />

        <asp:Label ID="Label7" runat="server" Text="Label">Album Price: </asp:Label>
        <asp:Label ID="priceLb" runat="server" Text="Label"></asp:Label>
        <br />

        <asp:Label ID="Label8" runat="server" Text="Label">Album Stock: </asp:Label>
        <asp:Label ID="stockLb" runat="server" Text="Label"></asp:Label>
        <br />

        <h1 class="title">Add to cart</h1>
        <asp:Label ID="Label9" runat="server" Text="Label">Quantity: </asp:Label>
        <asp:TextBox ID="qtyTb" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="addCartBtn" runat="server" Text="Add to Cart" OnClick="addCartBtn_Click"/>

    </div>

</asp:Content>
