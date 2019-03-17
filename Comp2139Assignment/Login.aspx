<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Comp2139Assignment.Login" %>

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
        <div class="container">
            <table class="auto-style1" style="text-align:center">
                <tr>
                    <td><h1 style="text-align:center">Login Page</h1></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblInvalidPassword" runat="server" ForeColor="Red" Text="Invalid Username / Password" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Username:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtUsername" runat="server" TextMode="Email" Text="example@email.com" Width="200px">example@email.com</asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" runat="server" ControlToValidate="txtUsername" Display="Dynamic" InitialValue="example@email.com" ForeColor="Red" ErrorMessage="You must input a valid email address in this format: example@email.com"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Password:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ErrorMessage="Password cannot be left blank" ForeColor="Red" Display="Dynamic" ControlToValidate="txtPassword"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnLogin" class="btn btn-primary" runat="server" Text="Login" Width="100px" OnClick="btnLogin_Click"/>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnRegister" class="btn btn-secondary" runat="server" Text="Register" Width="100px" CausesValidation="False" OnClick="btnRegister_Click"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnForgotPassword" class="btn btn-info" runat="server" CausesValidation="False" Text="Forgot Password?" OnClick="btnForgotPassword_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
