<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="KpopZtation_GroupB.View.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Cart</h1>
        <asp:GridView ID="gvCart" runat="server" AutoGenerateColumns="false" OnRowCommand="gvCart_RowCommand">
            <Columns>
                
                <asp:BoundField DataField="AlbumName" HeaderText="Album Name" SortExpression="AlbumName" />
                <asp:BoundField DataField="Qty" HeaderText="Quantity" SortExpression="Qty" />
                <asp:BoundField DataField="AlbumPrice" HeaderText="Album Price" SortExpression="AlbumPrice" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Image ID="albumImage" HeaderText="Album Image" runat="server" />
                        <asp:Button ID="deleteBtn" runat="server" Text="Remove" CommandName="Remove" CommandArgument='<%# Eval("AlbumID") %>'/>
                        <asp:Button ID="checkoutBtn" runat="server" Text="Checkout" CommandName="Checkout" CommandArgument='<%# Eval("AlbumID") %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

        </asp:GridView>
    </div>

</asp:Content>
