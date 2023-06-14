<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="KpopZtation_GroupB.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Home</h1>
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
    </div>
    
</asp:Content>
