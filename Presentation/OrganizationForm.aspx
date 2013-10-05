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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="OrganizationId" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="OrganizationId" HeaderText="OrganizationId" InsertVisible="False" ReadOnly="True" SortExpression="OrganizationId"></asp:BoundField>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                <asp:BoundField DataField="Street" HeaderText="Street" SortExpression="Street"></asp:BoundField>
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City"></asp:BoundField>
                <asp:BoundField DataField="State" HeaderText="State" SortExpression="State"></asp:BoundField>
                <asp:BoundField DataField="Zip" HeaderText="Zip" SortExpression="Zip"></asp:BoundField>
                <asp:BoundField DataField="StartDate" HeaderText="StartDate" SortExpression="StartDate"></asp:BoundField>
                <asp:BoundField DataField="EndDate" HeaderText="EndDate" SortExpression="EndDate"></asp:BoundField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:andy680ConnectionString %>" SelectCommand="SELECT [OrganizationId], [Name], [Street], [City], [State], [Zip], [StartDate], [EndDate] FROM [Organizations]"></asp:SqlDataSource>
        <br />
        <br/></div></form>

        