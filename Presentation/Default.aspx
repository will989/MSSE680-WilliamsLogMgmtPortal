<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Presentation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h1>Log Management Portal Home Page</h1>
        </div>
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
                You are not logged in. Click the Login link to sign in.&nbsp;
            </AnonymousTemplate>
            <LoggedInTemplate>
                You are logged. Welcome,<asp:LoginName ID="LoginName1" runat="server" />
                &nbsp;
            </LoggedInTemplate>
        </asp:LoginView>
        <p>
            <asp:LoginStatus ID="LoginStatus1" runat="server" />
        </p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminPages/UserForm.aspx">UserForm</asp:HyperLink>
        <p>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/AdminPages/OrganizationForm.aspx">OrganizationForm</asp:HyperLink>
        </p>
    </form>
</body>
</html>
