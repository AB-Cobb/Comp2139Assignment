﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterSuccess.aspx.cs" Inherits="Comp2139Assignment.RegisterSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" style="text-align:center">
                <tr>
                    <td><h1>Registration Successful!</h1></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblTextOne" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblTextTwo" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Click the button below to return to the Login Page</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnReturnToLogin" runat="server" CausesValidation="False" OnClick="btnReturnToLogin_Click" Text="Return to Login" />
                    </td>
                </tr>
                <tr>
                    <td>(Btw a requirement for this page is apparently to actually EMAIL the specified email account with an containing their first and last name, and a link redirecting them to the login page.)</td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
