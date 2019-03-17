<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePassword.aspx.cs" Inherits="Comp2139Assignment.UpdatePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="/Content/bootstrap.css"/>
    <link rel="stylesheet" href="/Content/style.css"/>
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
        <div class="container">
            <h1 class="text-center">Update Password</h1>
            <div class="form-group form-row">
                <label for="txtNewPW" class="col-md-12 col-form-label">New Password:
                    <asp:TextBox ID="txtNewPW" class=" form-control" runat="server"></asp:TextBox>
                </label>
                <label for="txtNewPWConfirm" class="col-md-12 col-form-label">Comfirm PW:
                    <asp:TextBox ID="txtNewPWConfirm" class="form-control" runat="server"></asp:TextBox>
                </label>
                <div class="col-md-12"><asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ControlToValidate="txtNewPW" Display="Dynamic" ErrorMessage="You must enter a valid password" ForeColor="Red"></asp:RequiredFieldValidator></div>
                <div class="col-md-12"><asp:CompareValidator ID="CompareValidatorConfirmPassword" runat="server" ControlToCompare="txtNewPW" ControlToValidate="txtNewPWConfirm" Display="Dynamic" ErrorMessage="The two passwords do not match" ForeColor="Red"></asp:CompareValidator></div>
                <div class="col-md-12"><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtNewPW" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="(?=.*[A-Z])(?=.*[a-z])(?=.*[!@#$%&amp;]).{8,12}">Password must be 8-12 Charectors in length, contain atlest 1 Uppercase, contain atleast 1 Special Character</asp:RegularExpressionValidator></div>
                <div class="col-md-12 btn-group">
                    <asp:Button ID="btnSubmit" class="btn btn-primary" runat="server" Text="Update Password" OnClick="btnSubmit_Click" />
                    <asp:Button ID="Button1" class=" btn btn-secondary" runat="server" CausesValidation="False" Text="Go Back" PostBackUrl="~/Profile.aspx"/>
                </div>

            </div>
        </div>
    </form>
</body>
</html>
