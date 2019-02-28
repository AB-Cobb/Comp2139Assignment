<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SurveySuccess.aspx.cs" Inherits="Comp2139Assignment.SurveySuccess" %>

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
            <table class="auto-style1">
                <tr>
                    <td colspan="2" style="text-align:center"><h1>TechKnow Pro - Incident Report Management System</h1></td>
                    <td style="text-align:right">
                        <asp:Button ID="btnLogout" runat="server" CausesValidation="False" Text="Logout" OnClick="btnLogout_Click" />
                    </td>
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
                        <asp:Button ID="btnHome" runat="server" CausesValidation="False" OnClick="btnHome_Click" Text="Home" />
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
