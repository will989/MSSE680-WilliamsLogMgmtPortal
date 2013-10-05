<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrganizationForm.aspx.cs" Inherits="Presentation.OrganizationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Organizations</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <table>
            <tr>
                <td>Organization Name</td>
                <td><asp:TextBox ID="OrgName" runat="server"></asp:TextBox></td>
                </tr>
            <tr>
                <td>Street Address</td>
                <td><asp:TextBox ID="Street" runat="server"></asp:TextBox></td>
                </tr>
            <tr>
                <td>City</td>
                <td><asp:TextBox ID="City" runat="server" ></asp:TextBox></td>
                </tr>
               <tr>
                <td>State</td>
                <td><asp:TextBox ID="State" runat="server" ></asp:TextBox></td>
                </tr>
            <tr>
                <td>Zip Code</td>
                <td><asp:TextBox ID="Zip" runat="server" ></asp:TextBox></td>
            </tr>
            <tr>
                <td>Start Date</td>
                <td><asp:Calendar ID="StartDate" runat="server"></asp:Calendar></td>
            </tr>
            
            <tr>
                <td>End Date</td>
                <td><asp:Calendar ID="EndDate" runat="server" ></asp:Calendar></td>
            </tr>
            

        </table>
        <br/>
        <br/>
        
        <asp:Button ID="Button1" runat="server" Text="Add Organization" OnClick="Button1_Click" />
        
        <br/>
        <br />
        <br />
        <asp:LinqDataSource ID="LinqDataSource1" runat="server">
        </asp:LinqDataSource>
        <br/></div></form>

        