<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewSurvey.aspx.cs" Inherits="Comp2139Assignment.ViewSurvey" %>

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
            width: 541px;
        }
        .auto-style4 {
            height: 23px;
            width: 541px;
        }
        .auto-style5 {
            width: 557px;
        }
        .auto-style6 {
            height: 23px;
            width: 557px;
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
            <h3 class="text-center">View Survey</h3>
                <div class="form-row">
                    <label for="ddlCustomers" class="col-sm-6 col-form-label">Select a Customer
                    <asp:DropDownList class="form-control" ID="ddlCustomers" runat="server" AutoPostBack="True" Width="200px" OnSelectedIndexChanged="ddlCustomers_SelectedIndexChanged"></asp:DropDownList>
                    </label>
                    <label for="txtCustomer" class="col-sm-6 col-form-label">Customer ID
                    <asp:TextBox class="form-control" ID="txtCustomer" runat="server" ReadOnly="True"></asp:TextBox>
                    </label>
                </div>

                <div class="row">
                    <div class="col-md-12"><p>Survey Listing</p></div>
                    <div class="col-md-12"><asp:ListBox class="form-control" ID="lstbSurvey" runat="server" Rows="8" OnSelectedIndexChanged="lstbSurvey_SelectedIndexChanged"></asp:ListBox></div>
                    <div class="col-md-12"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="lstbSurvey" ErrorMessage="Please Select a Survey"></asp:RequiredFieldValidator></div>
                    <div class="col-md-12"><asp:Button ID="btnRetrieveSurveyDetails" runat="server" Text="Retrieve Survey Details" OnClick="btnRetrieveSurveyDetails_Click" /></div>
                </div>
            <h3 class="text-center">Customer Rating</h3>

                <div class="form-row">
                    <label for="lblResponseTime" class="col-sm-6 col-form-label">Response Time: 
                        <asp:Label ID="lblResponseTime" runat="server"></asp:Label>
                    </label>
                    <label for="lblResponseTime" class="col-sm-6 col-form-label">Contact to Discuss Incident: 
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </label>
                    <label for="lblTechEfficientcy" class="col-sm-6 col-form-label">Techician Efficiency: 
                        <asp:Label ID="lblTechEfficientcy" runat="server"></asp:Label>
                    </label>
                    <label for="Label2" class="col-sm-6 col-form-label">Preferred Contact Method: 
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </label>
                    <label for="lblProbResolution" class="col-sm-12 col-form-label">Problem Resolution: 
                        <asp:Label ID="lblProbResolution" runat="server"></asp:Label>
                    </label>
                </div>

                <div class="row">
                    <div class="col-md-12"><p>Additional Comments</p></div>
                    <div class="col-md-12"><asp:TextBox class="form-control" ID="txtAdditionalComments" runat="server" Height="100px" ReadOnly="True" Width="400px" TextMode="MultiLine"></asp:TextBox></div>
                </div>                
     </div>
    </form>
</body>
</html>
