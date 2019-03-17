<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewIncident.aspx.cs" Inherits="Comp2139Assignment.ViewIncident" %>

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
                <li><asp:Button ID="btnBack" class="nav-link btn btn-link" runat="server" CausesValidation="False" Text="Home" PostBackUrl="~/HomePage.aspx"/></li>
                <li><asp:Button ID="btnLogout" class="nav-link btn btn-link" runat="server" CausesValidation="False" OnClick="btnLogout_Click" Text="Logout" /></li>
            </ul>
        </nav>
        <div class="container pb-2">
                        <h1 class="text-center">TechKnow Pro - Incident Report Management System</h1>
                        <h3 class="text-center">View Incident</h3>
                        <div class="row text-center">
                            <div class="col-md-12"><p>Select a customer:</p></div>
                            <div class="col-md-6"><p>Incident List:</p></div>
                            <div class="col-md-6"><asp:DropDownList ID="ddlCustomer" runat="server" AutoPostBack="True" Width="200px" OnSelectedIndexChanged="ddlCustomer_SelectedIndexChanged"></asp:DropDownList></div>
                        <div class="col-md-12"><asp:ListBox ID="lstbIncident" runat="server" Width="600px" OnSelectedIndexChanged="lstbIncident_SelectedIndexChanged"></asp:ListBox></div>
                        <div class="col-md-12"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="lstbIncident" Display="None" ErrorMessage="Please Select an Incident"></asp:RequiredFieldValidator></div>
                            <div class="col-md-12 text-center mt-2">
                                <asp:Button ID="btnCreateIncident" class="btn btn-primary" runat="server" CausesValidation="False" Text="Create Incident" OnClick="btnCreateIncident_Click" />
                                <asp:Button ID="btnRetrieve" class="btn btn-secondary" runat="server" Text="Retrieve" OnClick="btnRetrieve_Click" />              
                            </div>
                        </div>          
                        <div class="row text-center">
                            <div class="col-md-6"><p>Customer ID:</p></div>
                            <div class="col-md-6"><asp:Label ID="lblCustomerID" runat="server" Text="(Customer ID)"></asp:Label></div>
                            <div class="col-md-6"><p>Report Date and Time:</p></div>
                            <div class="col-md-6"><asp:Label ID="lblReportDateAndTime" runat="server" Text="(Date and Time)"></asp:Label></div>
                            <div class="col-md-6"><p>Incident #:</p></div>
                            <div class="col-md-6"><asp:Label ID="lblIncidentNumber" runat="server" Text="(Incident Number)"></asp:Label></div>
                        </div>
                        <div class="row text-center">
                            <div class="col-md-12">
                            <asp:Label ID="Status" runat="server" Text="(Open or Closed)"></asp:Label></div>
                            <div class="col-md-12"><asp:TextBox ID="txtDescription" runat="server" Height="218px" ReadOnly="True" Width="553px" TextMode="MultiLine"></asp:TextBox></div>
                        </div>
                       
        </div>
    </form>
</body>
</html>
