<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MessageForm.aspx.cs" Inherits="Presentation.MessageForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Manage Messages</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <table>
            <tr>
                <td>Correlation Identifier</td>
                <td><asp:TextBox ID="CorrelationId" runat="server"></asp:TextBox></td>
                </tr>
            <tr>
                <td>Sending Organization Id<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:andy680ConnectionString %>" SelectCommand="SELECT [OrganizationId], [Name] FROM [Organizations]"></asp:SqlDataSource>
                    <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="OrganizationId"></asp:ListBox>
                </td>
                <td><asp:TextBox ID="SendingOrgId" runat="server"></asp:TextBox></td>
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
                <td><asp:Calendar ID="TimeStamp" runat="server"></asp:Calendar></td>
            </tr>
           

        </table>
        <br/>
        <br/>
        
        <asp:Button ID="Button1" runat="server" Text="Add Message" OnClick="Button1_Click" />
        
        </div></form>
</body>
</html>
