<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="KpopZtation_GroupB.View.TransactionHistoryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Transaction History</h1>
        <asp:GridView ID="gvTransaction" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="ArtistID" />
                <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="ArtistName" />
                <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" SortExpression="ArtistName" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Image ID="albumImg" runat="server" HeaderText="Album Image" ImageUrl='<%#Eval("AlbumImage")%>' CssClass="imgWidth-250" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="AlbumName" HeaderText="Album Name" SortExpression="AlbumName" />
                <asp:BoundField DataField="Qty" HeaderText="Quantity" SortExpression="Qty" />
                <asp:BoundField DataField="AlbumPrice" HeaderText="Album Price" SortExpression="AlbumPrice" />
            </Columns>

        </asp:GridView>
    </div>
</asp:Content>
