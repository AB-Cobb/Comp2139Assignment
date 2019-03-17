<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePassword.aspx.cs" Inherits="Comp2139Assignment.UpdatePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            margin-left: 6px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            New Password:<asp:TextBox ID="txtNewPW" runat="server" CssClass="auto-style2" Width="170px"></asp:TextBox>
            <br />
            Comfirm PW :
            <asp:TextBox ID="txtNewPWConfirm" runat="server" CssClass="auto-style3" Width="167px"></asp:TextBox>
            <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ControlToValidate="txtNewPW" Display="Dynamic" ErrorMessage="You must enter a valid password" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                        <asp:CompareValidator ID="CompareValidatorConfirmPassword" runat="server" ControlToCompare="txtNewPW" ControlToValidate="txtNewPWConfirm" Display="Dynamic" ErrorMessage="The two passwords do not match" ForeColor="Red"></asp:CompareValidator>
                    <br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtNewPW" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="(?=.*[A-Z])(?=.*[a-z])(?=.*[!@#$%&amp;]).{8,12}">Password must be 8-12 Charectors in length, contain atlest 1 Uppercase, contain atleast 1 Special Character</asp:RegularExpressionValidator>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Update Password" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
