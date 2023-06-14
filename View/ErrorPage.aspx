<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="KpopZtation_GroupB.View.ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Error</title>
</head>
<body>
    <style>
        * {
            background-color: #660000;
        }

        h1 {
            color: white;
        }

        h5 {
            color: white;
        }
        .white-text {
            color: white;
        }
    </style>
    <h1>Oh no! It's a Forbidden Page</h1>
    <h5>You should not access this page because you are logged in with wrong role!</h5>
    <h1>(ㆆ _ ㆆ)</h1>
    <asp:HyperLink ID="loginLink" runat="server" NavigateUrl="~/View/LoginPage.aspx" CssClass="white-text">Please login with correct account!</asp:HyperLink>
    
</body>
</html>
