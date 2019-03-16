<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateIncident.aspx.cs" Inherits="Comp2139Assignment.CreateIncident" %>

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
        .auto-style3 {
            width: 539px;
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
                <h1 class="text-center">TechKnow Pro - Incident Report Management Software</h1>
                <h3 class="text-center">Incident Report Page</h3>

                <div class="row">
                    <div class="input-group col-md-12">
                        <div class="input-group-prepend">
                        <label class="input-group-text" for="inputGroupSelect01">Select a Customer</label>
                        </div>
                    <asp:DropDownList class="custom-select" ID="ddlCustomers" runat="server" AutoPostBack="True" Width="200px" OnSelectedIndexChanged="ddlCustomers_SelectedIndexChanged">
                        <asp:ListItem>--</asp:ListItem>
                    </asp:DropDownList>
                    </div>
                    <div class="col-md-6"><p>Report Date and Time:</p></div>
                    <div class="col-md-6"><asp:TextBox ID="txtReportDateAndTime" runat="server" ReadOnly="True" Width="200px"></asp:TextBox></div>
                    <div class="col-md-12"><asp:RequiredFieldValidator ID="RequiredFieldValidatorCustomer" runat="server" ControlToValidate="ddlCustomers" Display="Dynamic" ErrorMessage="You must select a customer" ForeColor="Red" InitialValue="--"></asp:RequiredFieldValidator></div>
                    <div class="col-md-6"><p>Incident Number:</p></div>
                    <div class="col-md-6"><asp:TextBox ID="txtIncidentNumber" runat="server" ReadOnly="True"></asp:TextBox></div>
                    <div class="col-md-6"><p>Customer ID:</p></div>
                    <div class="col-md-6"><asp:TextBox ID="txtCustomerID" runat="server" CausesValidation="True" ReadOnly="True"></asp:TextBox></div>
                    <div class="col-md-6"><p>Status:</p></div>
                    <div class="col-md-6"><asp:DropDownList ID="ddlStatus" runat="server" Width="100px">
                    <asp:ListItem>New</asp:ListItem>
                    <asp:ListItem>In Progress</asp:ListItem>
                    <asp:ListItem>Closed</asp:ListItem>
                </asp:DropDownList></div>
                </div>

                <div class="row">
                    <div class="col-md-12"><p>Description of problem</p></div>
                    <div class="col-md-12"><asp:TextBox ID="txtDescription" runat="server" Height="150px" Width="600px" TextMode="MultiLine"></asp:TextBox></div>
                    <div class="col-md-12"><asp:RequiredFieldValidator ID="RequiredFieldValidatorDescription" runat="server" ControlToValidate="txtDescription" Display="Dynamic" EnableTheming="False" ErrorMessage="You must add a description of the incident" ForeColor="Red"></asp:RequiredFieldValidator></div>
                    <div class="col-md-12"><p>Method of Contact:></p></div>
                    <div class="col-md-12 form-check form-check-inline">                    
                        <asp:RadioButtonList class="form-check-input" ID="rblMethodOfContact" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Email</asp:ListItem>
                        <asp:ListItem >Phone</asp:ListItem>
                        <asp:ListItem>In Person</asp:ListItem>
                    </asp:RadioButtonList></div>
                    <div class="col-md-12"><asp:RequiredFieldValidator ID="RequiredFieldValidatorMethodOfContact" runat="server" ControlToValidate="rblMethodOfContact" Display="Dynamic" ErrorMessage="You must select a method of contact" ForeColor="Red"></asp:RequiredFieldValidator></div>
                    <div class="col-md-12"><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></div>
                </div>
        </div>
    </form>
</body>
</html>
