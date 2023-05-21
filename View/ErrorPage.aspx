<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="KpopZtation_GroupB.View.ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Error</title>
</head>
<body>
    <h1>Whoopsy Daisy! It's a Forbidden Page</h1>
    <h5>You should not access this page because wrong role!</h5>
    <p>
        Enter if you dare, the forbidden page awaits, <br />
        A curse befalls those who venture, eternal pop-ups and broken links shall be your fate.
    </p>
    <asp:HyperLink ID="loginLink" runat="server" NavigateUrl="~/View/LoginPage.aspx">Please login with correct account!</asp:HyperLink>
    
</body>
</html>
