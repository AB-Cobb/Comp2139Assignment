<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="Comp2139Assignment.Customers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="/Content/bootstrap.css"/>
    <link rel="stylesheet" href="/Content/style.css"/>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <a class="navbar-brand" href="#">Web Applications Assignment 1</a>
            <ul class="nav navbar-nav ml-auto">
                <li><asp:Button ID="Button1" class="nav-link btn btn-link" runat="server" CausesValidation="False" Text="Home" PostBackUrl="~/HomePage.aspx"/></li>
                <li><asp:Button ID="Button2" class="nav-link btn btn-link" runat="server" CausesValidation="False" OnClick="btnLogout_Click" Text="Logout" /></li>
            </ul>
        </nav>
        <div class="container">
                        <h1 class="text-center">TechKnow Pro - Incident Report Management System</h1>
                        <h3 class="text-center">Customer - Search and view your customer contact information</h3>
                        <div class="row text-center">
                            <div class="col-md-12"><p>Select A Customer:</p></div>
                            <div class="col-md-12"><asp:ListBox ID="lstbCustomers" runat="server" AutoPostBack="True" Width="400px" OnSelectedIndexChanged="lstbCustomers_SelectedIndexChanged"></asp:ListBox></div>
                            <div class="col-md-6"><p>Address:</p></div>
                            <div class="col-md-6"><asp:Label ID="lblAddress" runat="server" Text="(Customer Address)"></asp:Label></div>
                            <div class="col-md-6"><p>Phone:</p></div>
                            <div class="col-md-6"><asp:Label ID="lblPhone" runat="server" Text="(Customer Phone)"></asp:Label></div>
                            <div class="col-md-6"><p>Email:</p></div>
                            <div class="col-md-6"><asp:Label ID="lblEmail" runat="server" Text="(Customer Email)"></asp:Label></div>                      
                            <asp:Label ID="lblAddToContactList" runat="server" ForeColor="#009900" Text="Customer Added To Contact List" Visible="False"></asp:Label>
                            <div class="col-md-6"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="lstbCustomers" ErrorMessage="Please Select a Customer"></asp:RequiredFieldValidator></div>
                            <div class="col-md-12 text-center">
                            <asp:Button ID="btnAddToContactList" class="btn btn-primary" runat="server" OnClick="btnAddToContactList_Click" Text="Add To Contact List" />
                            <asp:Button ID="btnDisplayContactList" class="btn btn-secondary" runat="server" OnClick="btnDisplayContactList_Click" Text="Display Contact List" CausesValidation="False"  />
                            </div>
                        </div>
                       
        </div>
    </form>
</body>
</html>
