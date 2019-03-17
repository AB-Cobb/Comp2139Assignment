﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Comp2139Assignment.Profile" %>

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
        .auto-style3 {
            margin-left: 12px;
        }
        .auto-style4 {
            margin-left: 10px;
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
        <div class="container mx-auto">
            <h1 class="text-center">TechKnow Pro - Incident Report Management Software</h1>
                <h2>Account Profile</h2>
                    <h4 >User Information</h4>
                        <div class="form-row">
                            <label for="txtProfileName" class="col-sm-2 col-form-label">Profile Name:  </label>
                            <div class="col-sm-10"><asp:TextBox ID="txtProfileName" runat="server" Enabled="False"></asp:TextBox></div>
                            <label for="txtUsername" class="col-sm-2 col-form-label">Username</label>
                            <div class="col-sm-10"><asp:TextBox ID="txtUsername" runat="server" TextMode="Email" Enabled="False"></asp:TextBox></div>
                            <div class="col-sm-12"><asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" runat="server" ControlToValidate="txtUsername" Display="Dynamic" ErrorMessage="You must have a username" ForeColor="Red"></asp:RequiredFieldValidator></div>
                            <div class="col-sm-12"><asp:Button class="btn btn-primary" ID="btnUpdatePassword" runat="server" OnClick="btnUpdatePassword_Click" Text="Update password" CausesValidation="False" ValidateRequestMode="Disabled" /></div>

                        </div>
                    <h4>Contact Information</h4>
                        <div class="form-row">
                            <label for="txtFirstName" class="col-sm-2 col-form-label">First Name*</label>
                            <div class="col-sm-10"><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></div>
                            <div class="col-sm-12"><asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="First Name cannot be left blank" ForeColor="Red"></asp:RequiredFieldValidator></div>
                            <div class="col-sm-12"><asp:RegularExpressionValidator ID="RegularExpressionValidatorFirstName" runat="server" ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="First Name must contain only letters" ForeColor="Red" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator></div>
                            
                            <label for="txtLastName" class="col-sm-2 col-form-label">Last Name*</label>
                            <div class="col-sm-10"><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></div>
                            <div class="col-sm-12"><asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server" ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="Last Name cannot be left blank" ForeColor="Red"></asp:RequiredFieldValidator></div>
                            <div class="col-sm-12"><asp:RegularExpressionValidator ID="RegularExpressionValidatorLastName" runat="server" ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="Last Name must contain only letters" ForeColor="Red" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator></div>
                            
                            <label for="txtPosition" class="col-sm-2 col-form-label">Position/Title</label>
                            <div class="col-sm-10"><asp:TextBox ID="txtPosition" runat="server"></asp:TextBox></div>
                            <label for="txtPhoneNum" class="col-sm-2 col-form-label">Phone Number</label>
                            <div class="col-sm-10"><asp:TextBox ID="txtPhoneNum" runat="server"></asp:TextBox></div>

                            <label for="txtAddress" class="col-sm-2 col-form-label">Address:</label>
                            <div class="col-sm-10"><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></div>

                            <label for="ddlSecretQuestion" class="col-sm-2 col-form-label">Secret Question</label>
                            <div class="col-sm-10">                                
                                <asp:DropDownList ID="ddlSecretQuestion" runat="server">
                                    <asp:ListItem>What was the name of the first school you attended?</asp:ListItem>
                                    <asp:ListItem>What was the name of your first pet?</asp:ListItem>
                                    <asp:ListItem>What is your favourite food?</asp:ListItem>
                                    <asp:ListItem>What is your favourite day of the year?</asp:ListItem>
                                    <asp:ListItem>What was the best gift you ever recieved?</asp:ListItem>
                                </asp:DropDownList>

                            </div>

                            <label for="txtSecretAwnser" class="col-sm-2 col-form-label">Secret Answer</label>
                            <div class="col-sm-10"><asp:TextBox ID="txtSecretAwnser" runat="server"></asp:TextBox></div>
                            <div class="col-md-12"><asp:RequiredFieldValidator ID="RequiredFieldValidatorSecret" runat="server" ControlToValidate="txtSecretAwnser" Display="Dynamic" ErrorMessage="You must provide an answer" ForeColor="Red"></asp:RequiredFieldValidator></div>
                            <label for="txtEmail" class="col-sm-2 col-form-label">Email Address*: </label>
                            <div class="col-sm-10"><asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox></div>
                            <div class="col-md-12"><asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="You must provide an email address" ForeColor="Red"></asp:RequiredFieldValidator></div>
                            <div class="col-md-12"><p>* Means a mandatory field</p></div>
                            <div class="col-md-12"><asp:Button class="btn btn-primary" ID="btnUpdate" runat="server" Text="Update Profile" OnClick="btnUpdate_Click" /></div>
                        </div>
                        
                        
        </div>
    </form>
</body>
</html>