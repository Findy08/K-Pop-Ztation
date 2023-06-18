<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="KpopZtation_GroupB.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Home</h1>
        <asp:Label ID="Label1" runat="server" Text="Label">Hello, </asp:Label>
        <asp:Label ID="userNameLb" runat="server" Text="Guest"></asp:Label>
        <br />
        <%if (role == "A")
            { %>
        <asp:LinkButton ID="insertArtistLink" runat="server" OnClick="insertArtistLink_Click">Insert Artist</asp:LinkButton>
        <br />
        <asp:GridView ID="gvArtist" runat="server" AutoGenerateColumns="False" OnRowDeleting="gvArtist_RowDeleting" OnRowEditing="gvArtist_RowEditing" OnSelectedIndexChanged="gvArtist_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField DataField="ArtistID" HeaderText="ID" SortExpression="ArtistID" />
                <asp:BoundField DataField="ArtistName" HeaderText="Artist Name" SortExpression="ArtistName" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Image ID="imgId" runat="server" HeaderText="Artist Image" ImageUrl='<%#Eval("ArtistImage")%>' CssClass="imgWidth-250" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" SelectText="Artist Detail" />
            </Columns>

        </asp:GridView>
        <%}
            else
            { %>
        <br />
        <asp:GridView ID="gvArtist2" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvArtist2_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField DataField="ArtistID" HeaderText="ID" SortExpression="ArtistID" />
                <asp:BoundField DataField="ArtistName" HeaderText="Artist Name" SortExpression="ArtistName" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Image ID="imgId" runat="server" HeaderText="Artist Image" ImageUrl='<%#Eval("ArtistImage")%>' CssClass="imgWidth-250" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" SelectText="Artist Detail" />
            </Columns>

        </asp:GridView>
        <%} %>
        
    </div>
    
</asp:Content>
