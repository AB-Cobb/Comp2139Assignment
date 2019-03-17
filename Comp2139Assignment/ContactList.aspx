<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactList.aspx.cs" Inherits="Comp2139Assignment.ContactList" %>

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
            <h3 class="text-center">Contact List - Manage your Contact List</h3>
            <div class="row text-center">
                <div class="col-md-12"><p>Contact List:</p></div>
                <div class="col-md-12"><asp:ListBox ID="lstbContactList" runat="server" AutoPostBack="True" Rows="8" Width="400px" OnSelectedIndexChanged="lstbContactList_SelectedIndexChanged"></asp:ListBox></div>
                <div class="col-md-12 text-center mt-2">
                    <asp:Button ID="btnRemoveContact" class="btn btn-primary" runat="server" Text="Remove Contact" Width="150px" OnClick="btnRemoveContact_Click" />
                    <asp:Button ID="btnClearList" class="btn btn-secondary" runat="server" Text="Clear List" OnClick="btnClearList_Click" CausesValidation="False" />
                </div>
                <div class="col-md-6 text-center"><asp:Label ID="lblStatus" runat="server" ForeColor="#009900" Text="(Status)" Visible="False"></asp:Label></div>
                <div class="col-md-6"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="lstbContactList" ErrorMessage="Please Select a Contact"></asp:RequiredFieldValidator></div>
                <div class="col-md-12"><asp:Button class="btn btn-info" ID="btnBackToCustomers" runat="server" CausesValidation="False" Text="Back" PostBackUrl="~/Customers.aspx" OnClick="btnDisplayContactList_Click"/></div>
            </div>
        </div>
    </form>
</body>
</html>
