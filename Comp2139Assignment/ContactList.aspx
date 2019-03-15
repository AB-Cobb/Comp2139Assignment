<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactList.aspx.cs" Inherits="Comp2139Assignment.ContactList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            width: 409px;
        }
        .auto-style4 {
            height: 26px;
            width: 409px;
        }
        .auto-style5 {
            width: 688px;
        }
        .auto-style6 {
            height: 26px;
            width: 688px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="2" style="text-align:center"><h1>TechKnow Pro - Incident Report Management System</h1></td>
            <td style="text-align:right">
                <asp:Button ID="btnLogout" runat="server" CausesValidation="False" Text="Logout" OnClick="btnLogout_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"><h3>Contact List - Manage your Contact List</h3></td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Contact List:</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:ListBox ID="lstbContactList" runat="server" AutoPostBack="True" Rows="8" Width="400px" OnSelectedIndexChanged="lstbContactList_SelectedIndexChanged"></asp:ListBox>
            </td>
            <td class="auto-style6">
                <div style="width:160px;">
                    <asp:Button ID="btnRemoveContact" runat="server" Text="Remove Contact" Width="150px" OnClick="btnRemoveContact_Click" />
                    &nbsp;<br />
                    <asp:Button ID="btnClearList" runat="server" Text="Clear List" OnClick="btnClearList_Click" />
                </div>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="lblStatus" runat="server" ForeColor="#009900" Text="(Status)" Visible="False"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="lstbContactList" ErrorMessage="Please Select a Contact"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="btnDisplayContactList" runat="server" CausesValidation="False" Text="Display Contact List" PostBackUrl="~/Customers.aspx" OnClick="btnDisplayContactList_Click"/>
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
