<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Comp2139Assignment.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 1031px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" style="text-align:center">
                <tr>
                    <td class="auto-style2"><h1>Register</h1></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2"><b><u>All</u></b> Fields are Required</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">First Name:&nbsp;&nbsp; <asp:TextBox ID="txtFirstName" runat="server" Width="200px" AutoPostBack="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" Display="Dynamic" ErrorMessage="You must enter a first name" ForeColor="Red" ControlToValidate="txtFirstName"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorFirstName" runat="server" ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="Your first name must only conatin letters" ForeColor="Red" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Last Name:&nbsp;&nbsp;
                        <asp:TextBox ID="txtLastName" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server" ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="You must enter a last name" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorLastName" runat="server" ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="Your last name must only contain letters" ForeColor="Red" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Email Address:&nbsp;
                        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" Width="200px"></asp:TextBox>
&nbsp;&nbsp; (Username)</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmailAddress" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="You must input an email address" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:CustomValidator ID="valEmailInUse" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Already In Use" ForeColor="Red" OnServerValidate="checkEmail"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"><h3>Please make sure your password has the following requirements:</h3></td>
                </tr>
                <tr>
                    <td class="auto-style2">* Between 6 to 12 characters in length</td>
                </tr>
                <tr>
                    <td class="auto-style2">* At least one uppercase character</td>
                </tr>
                <tr>
                    <td class="auto-style2">* At least one special character</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Password:&nbsp;&nbsp;
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">(I have no idea how to make the validation expression for this one)</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="You must enter a valid password" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Confirm Password:&nbsp;&nbsp;
                        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:CompareValidator ID="CompareValidatorConfirmPassword" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" Display="Dynamic" ErrorMessage="The two passwords do not match" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmPassword" runat="server" ControlToValidate="txtConfirmPassword" Display="Dynamic" ErrorMessage="You must enter a valid password" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:CheckBox ID="chkTermsOfService" runat="server" Text="I agree to the Terms Of Service" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:CustomValidator ID="CustomValidatorTermsOfService" runat="server" ErrorMessage="You must agree to the Terms Of Service" ForeColor="Red" OnServerValidate="CustomValidatorTermsOfService_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnRegister" runat="server" Text="Register" Width="100px" OnClick="btnRegister_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnBack" runat="server" Text="Back" PostBackUrl="~/Login.aspx" CausesValidation="False"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
