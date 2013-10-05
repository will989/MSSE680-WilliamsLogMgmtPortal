<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MessageForm.aspx.cs" Inherits="Presentation.MessageForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Manage Messages</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <table style="height: 278px; width: 524px">
            <tr>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="CorrelationId" Display="Dynamic" ErrorMessage="Correlation Id is required.">*</asp:RequiredFieldValidator>
                    Correlation Identifier</td>
                <td><asp:TextBox ID="CorrelationId" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="CorrelationId" Display="Dynamic" ErrorMessage="Correlation Id must be an integer" ValidationExpression="\d+">Must be an integer.</asp:RegularExpressionValidator>
                </td>
                </tr>
            <tr>
                <td>Sending Organization Id<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:andy680ConnectionString %>" SelectCommand="SELECT [OrganizationId], [Name] FROM [Organizations]"></asp:SqlDataSource>
                    <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="OrganizationId"></asp:ListBox>
                </td>
                <td><asp:TextBox ID="SendingOrgId" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="SendingOrgId" Display="Dynamic" ErrorMessage="Sending Organization Id is required.">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="SendingOrgId" Display="Dynamic" ErrorMessage="Sending Organization Id must be an integer" ValidationExpression="\d+">Must be an integer.</asp:RegularExpressionValidator>
                </td>
                </tr>
            <tr>
                <td>Receiving Organization Id</td>
                <td><asp:TextBox ID="ReceivingOrgId" runat="server" ></asp:TextBox></td>
                </tr>
               <tr>
                <td>Severity</td>
                <td><asp:TextBox ID="Severity" runat="server" ></asp:TextBox></td>
                </tr>
            <tr>
                <td>Organization Message</td>
                <td><asp:TextBox ID="Message" runat="server" ></asp:TextBox></td>
            </tr>
            <tr>
                <td>TimeStamp</td>
                <td>(This is auto-assigned when Add Message is clicked)</td>
            </tr>
           

        </table>
        <br/>
        <asp:Button ID="Button2" runat="server" Text="Add SendingOrgId" OnClick="Button2_Click" />
        <br/>
        
        <br/>
        </div>
        <p>
        
        <asp:Button ID="Button1" runat="server" Text="Add Message" OnClick="Button1_Click" />
        </p>
        <p>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
