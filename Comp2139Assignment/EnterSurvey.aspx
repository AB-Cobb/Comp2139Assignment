<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnterSurvey.aspx.cs" Inherits="Comp2139Assignment.EnterSurvey" %>

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
                <h1 class="text-center">TechKnow Pro - Incident Report Management Software</h1>
                <h3 class="text-center">Surveys - Collect feedback from customers</h3>
                    <div class="form-row">
                        <label for="txtCustomerID" class="col-sm-6 col-form-label">Customer ID: 
                            <asp:TextBox ID="txtCustomerID" runat="server" ReadOnly="True" Enabled="False"></asp:TextBox>
                        </label>
                        <label for="ddlIncidentList" class="col-sm-6 col-form-label">Select an Incident: 
                            <asp:DropDownList ID="ddlIncidentList" runat="server"></asp:DropDownList>
                        </label>
                        <div class="col-sm-12"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlIncidentList" ErrorMessage="Please Select an Incident" ForeColor="Red"></asp:RequiredFieldValidator></div>
                    </div>
                <h4 class="text-center">Please rate this incident by the following categories:</h4>
                    <div class="form-row">
                        <label for="rblResponseTime" class="col-md-12 col-form-label">Response Time</label>                       
                        <div class="col-md-12">
                            <asp:RadioButtonList class="form-check form-check-inline" ID="rblResponseTime" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Very Satisfied</asp:ListItem>
                            <asp:ListItem>Satisfied</asp:ListItem>
                            <asp:ListItem>Average</asp:ListItem>
                            <asp:ListItem>Unsatisfied</asp:ListItem>
                            <asp:ListItem>Very Unsatisfied</asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                        <div class="col-md-12"><asp:RequiredFieldValidator ID="RequiredFieldValidatorResponseTime" runat="server" ControlToValidate="rblResponseTime" Display="Dynamic" ErrorMessage="Please select one of the above options" ForeColor="Red"></asp:RequiredFieldValidator></div>
                    </div>
                    <div class="form-row">
                        <label for="rblTechnicianEfficiency" class="col-md-12 col-form-label">Technician Efficiency</label> 
                        <div class="col-md-12">
                            <asp:RadioButtonList class="form-check form-check-inline" ID="rblTechnicianEfficiency" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Very Satisfied</asp:ListItem>
                            <asp:ListItem>Satisfied</asp:ListItem>
                            <asp:ListItem>Average</asp:ListItem>
                            <asp:ListItem>Unsatisfied</asp:ListItem>
                            <asp:ListItem>Very Unsatisfied</asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                        <div class="col-md-12"><asp:RequiredFieldValidator ID="RequiredFieldValidatorTechnicianEfficiency" runat="server" ControlToValidate="rblTechnicianEfficiency" Display="Dynamic" ErrorMessage="Please select one of the above options" ForeColor="Red"></asp:RequiredFieldValidator></div>
                    </div>
                    <div class="form-row">
                        <label for="rblProblemResolution" class="col-md-12 col-form-label">Problem Resolution</label> 
                        <div class="col-md-12">
                            <asp:RadioButtonList class="form-check form-check-inline" ID="rblProblemResolution" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Very Satisfied</asp:ListItem>
                            <asp:ListItem>Satisfied</asp:ListItem>
                            <asp:ListItem>Average</asp:ListItem>
                            <asp:ListItem>Unsatisfied</asp:ListItem>
                            <asp:ListItem>Very Unsatisfied</asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                        <div class="col-md-12"><asp:RequiredFieldValidator ID="RequiredFieldValidatorProblemResolution" runat="server" ControlToValidate="rblProblemResolution" Display="Dynamic" ErrorMessage="Please select one of the above options" ForeColor="Red"></asp:RequiredFieldValidator></div>
                    </div>
                    <div class="form-row">
                        <label for="txtAdditionalComments" class="col-md-12 col-form-label">Additional Comments</label> 
                        <div class="col-md-12"><asp:TextBox class="form-control" ID="txtAdditionalComments" runat="server" TextMode="MultiLine"></asp:TextBox></div>
                    </div>
                <asp:CheckBox ID="chkContactMe" runat="server" OnCheckedChanged="chkContactMe_CheckedChanged" Text="Please contact me to discuss this incident" />
                <asp:RadioButtonList ID="rblContactMe" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>Contact Via Email</asp:ListItem>
                    <asp:ListItem>Contact Via Phone</asp:ListItem>
                </asp:RadioButtonList>
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit Survey" />
        
        <div/>
    </form>
</body>
</html>
