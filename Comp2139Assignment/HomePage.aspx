<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Comp2139Assignment.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="/Content/bootstrap.css"/>
    <link rel="stylesheet" href="/Content/style.css"/>
    <title></title>
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
                <li ><asp:Button ID="btnLogout" class="nav-link btn btn-link" runat="server" Text="Logout" OnClick="btnLogout_Click" CausesValidation="False" /></li>
            </ul>
        </nav>
        <div class="container mt-2">
            <h1 class="text-center">TechKnow Pro - Incident Report Management Software</h1>
                <h3 class="text-center">Welcome to the TechKnow Pro Support Portal</h3>
                    <h4>Getting Started:</h4>
                        <ul>
                            <li><asp:HyperLink ID="hplIncidentsPage" runat="server" NavigateUrl="~/ViewIncident.aspx">Go to Incidents to search, review and create client incident reports</asp:HyperLink></li>
                            <li><asp:HyperLink ID="hplCustomersPage" runat="server" NavigateUrl="~/Customers.aspx">Go to Customers to search customer information</asp:HyperLink></li>
                            <li><asp:HyperLink ID="hplProfilePage" runat="server" NavigateUrl="~/Profile.aspx">Go to Profile to update your profile and customer information</asp:HyperLink></li>

                        </ul>
                        <asp:Label ID="lblSurvey" runat="server" Text="Surveys"></asp:Label>
                        <ul>
                            <li><asp:HyperLink ID="hplSurveyPage" runat="server" NavigateUrl="~/EnterSurvey.aspx">Submit a Survey to provide feedback for any support we have provided on your recent activity</asp:HyperLink></li>
                            <li><asp:HyperLink ID="hplViewSurveysPage" runat="server" NavigateUrl="~/ViewSurvey.aspx">View the Surveys that customers have completed</asp:HyperLink></li>
                        </ul>
            <h4> Group Members:</h4>            
            <ul>
                <li>Giuseppe Ragusa - 101109502</li>
                <li>Andrew Cobb - 101142044</li>
                <li>Arsalan Farooqui - Arsalan Farooqui</li>
            </ul>
           
        </div>
    </form>
</body>
</html>
