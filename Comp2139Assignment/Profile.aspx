<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Comp2139Assignment.Profile" %>

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
        <div class="container">
            <h1>TechKnow Pro - Incident Report Management Software</h1>
                <h2>Account Profile</h2>
                    <h4>User Information</h4>
                        <div class="form-row">
                            <label for="txtProfileName" class="col-sm-6 col-form-label">Profile Name: 
                                <asp:TextBox ID="txtProfileName" runat="server" Enabled="False"></asp:TextBox>
                            </label>
                            <label for="txtUsername" class="col-sm-6 col-form-label">Username
                                <asp:TextBox ID="txtUsername" runat="server" TextMode="Email" Enabled="False"></asp:TextBox>
                            </label>
                            <div class="col-sm-12"><asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" runat="server" ControlToValidate="txtUsername" Display="Dynamic" ErrorMessage="You must have a username" ForeColor="Red"></asp:RequiredFieldValidator></div>
                            <div class="col-sm-12"><asp:Button ID="btnUpdatePassword" runat="server" OnClick="btnUpdatePassword_Click" Text="Update password" CausesValidation="False" ValidateRequestMode="Disabled" /></div>

                        </div>
                    <h4>Contact Information</h4>
                        <div class="form-row">
                            <label for="txtFirstName" class="col-sm-12 col-form-label">*First Name:
                                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                            </label>

                            <div class="col-sm-12"><asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="First Name cannot be left blank" ForeColor="Red"></asp:RequiredFieldValidator></div>
                            <div class="col-sm-12"><asp:RegularExpressionValidator ID="RegularExpressionValidatorFirstName" runat="server" ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="First Name must contain only letters" ForeColor="Red" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator></div>
                            
                            <label for="txtLastName" class="col-sm-12 col-form-label">*Last Name:
                                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                            </label>

                            <div class="col-sm-12"><asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server" ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="Last Name cannot be left blank" ForeColor="Red"></asp:RequiredFieldValidator></div>
                            <div class="col-sm-12"><asp:RegularExpressionValidator ID="RegularExpressionValidatorLastName" runat="server" ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="Last Name must contain only letters" ForeColor="Red" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator></div>
                            
                            <label for="txtPosition" class="col-sm-12 col-form-label">Position/Title:
                                <asp:TextBox ID="txtPosition" runat="server"></asp:TextBox>
                            </label>
                            <label for="txtPhoneNum" class="col-sm-12 col-form-label">Phone Number:
                                <asp:TextBox ID="txtPhoneNum" runat="server"></asp:TextBox>
                            </label>
                            <label for="txtAddress" class="col-sm-12 col-form-label">Address:
                                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                            </label>
                            <label for="ddlSecretQuestion" class="col-sm-12 col-form-label">Secret Question:
                                <asp:DropDownList ID="ddlSecretQuestion" runat="server">
                                    <asp:ListItem>What was the name of the first school you attended?</asp:ListItem>
                                    <asp:ListItem>What was the name of your first pet?</asp:ListItem>
                                    <asp:ListItem>What is your favourite food?</asp:ListItem>
                                    <asp:ListItem>What is your favourite day of the year?</asp:ListItem>
                                    <asp:ListItem>What was the best gift you ever recieved?</asp:ListItem>
                                </asp:DropDownList>
                            </label>
                            <label for="txtSecretAwnser" class="col-sm-12 col-form-label">Secret Answer:
                                <asp:TextBox ID="txtSecretAwnser" runat="server"></asp:TextBox>
                            </label>
                            <label for="txtEmail" class="col-sm-12 col-form-label">*Email Address:
                                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
                            </label>
                            <div class="col-md-12"><asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="You must provide an email address" ForeColor="Red"></asp:RequiredFieldValidator></div>
                            <div class="col-md-12"><p>*means a mandatory field</p></div>
                            <div class="col-md-12"><asp:Button ID="btnUpdate" runat="server" Text="Update Profile" OnClick="btnUpdate_Click" /></div>
                        </div>
                        
                        
        </div>
    </form>
</body>
</html>