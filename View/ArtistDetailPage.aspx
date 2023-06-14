<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="ArtistDetailPage.aspx.cs" Inherits="KpopZtation_GroupB.View.ArtistDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Artist Detail</h1>
        <asp:Label ID="Label1" runat="server">Artist Name: </asp:Label>
        <asp:Label ID="nameLb" runat="server"></asp:Label>
        <br />
        <asp:LinkButton ID="insertAlbumLink" runat="server" OnClick="insertAlbumLink_Click">Insert Album</asp:LinkButton>
        <br />
        <asp:Image ID="artistImg" CssClass="imgWidth-500" runat="server"/> 
        
        <asp:GridView ID="gvAlbum" runat="server" AutoGenerateColumns="False" OnRowDeleting="gvAlbum_RowDeleting" OnRowEditing="gvAlbum_RowEditing" OnSelectedIndexChanged="gvAlbum_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="AlbumID" HeaderText="ID" SortExpression="ArtistID" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Image ID="imgId" runat="server" HeaderText="Album Image" ImageUrl='<%#Eval("AlbumImage")%>' CssClass="imgWidth-250"/>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:BoundField DataField="AlbumName" HeaderText="Album Name" SortExpression="AlbumID" />
                <asp:BoundField DataField="AlbumPrice" HeaderText="Album Price" SortExpression="AlbumID" />
                <asp:BoundField DataField="AlbumDescription" HeaderText="Album Description" SortExpression="AlbumID" />
                <asp:CommandField ButtonType="Button" ShowCancelButton="False" ShowDeleteButton="True" ShowSelectButton="True" ShowEditButton="True" SelectText="Album Detail"/>
            </Columns>

        </asp:GridView>
    </div>
</asp:Content>
