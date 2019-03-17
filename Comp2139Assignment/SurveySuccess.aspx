<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SurveySuccess.aspx.cs" Inherits="Comp2139Assignment.SurveySuccess" %>

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
        <div>
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <a class="navbar-brand" href="#">Web Applications Assignment 1</a>
            <ul class="nav navbar-nav ml-auto">
                <li><asp:Button ID="Button1" class="nav-link btn btn-link" runat="server" CausesValidation="False" Text="Home" PostBackUrl="~/HomePage.aspx"/></li>
                <li><asp:Button ID="Button2" class="nav-link btn btn-link" runat="server" CausesValidation="False" OnClick="btnLogout_Click" Text="Logout" /></li>
            </ul>
        </nav>
            <table class="auto-style1">
                <tr>
                    <td colspan="2" style="text-align:center"><h1>TechKnow Pro - Incident Report Management System</h1></td>
                    <td style="text-align:right">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td><h3>Survey Complete</h3></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Thank you for your feedback!</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblText" runat="server" Text="A customer service representative will contact you within 24 hours"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnReturnToSurvey" runat="server" CausesValidation="False" OnClick="btnReturnToSurvey_Click" Text="Return To Survey" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
