<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="KpopZtation_GroupB.View.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Cart</h1>
        
        <asp:GridView ID="gvCart" runat="server" AutoGenerateColumns="False" OnRowDeleting="gvCart_RowDeleting" >
            <Columns>
                <asp:BoundField DataField="AlbumID" HeaderText="Album ID" SortExpression="AlbumID" />
                <asp:BoundField DataField="AlbumName" HeaderText="Album Name" SortExpression="AlbumName" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Image ID="albumImage" HeaderText="Album Image" runat="server" ImageUrl='<%#Eval("AlbumImage")%>' CssClass="imgWidth-250"/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Qty" HeaderText="Quantity" SortExpression="Qty" />
                <asp:BoundField DataField="AlbumPrice" HeaderText="Album Price" SortExpression="AlbumPrice" />
  
                <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />

            </Columns>
            
        </asp:GridView>
        <asp:Button ID="checkoutBtn" runat="server" Text="Checkout" OnClick="checkoutBtn_Click" />
    </div>

</asp:Content>
