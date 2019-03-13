<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateIncident.aspx.cs" Inherits="Comp2139Assignment.CreateIncident" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 556px;
        }
        .auto-style3 {
            width: 539px;
        }
        .auto-style4 {
            width: 556px;
            height: 23px;
        }
        .auto-style5 {
            width: 539px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="2" style="text-align:center"><h1>TechKnow Pro - Incident Report Management Software</h1></td>
            <td style="text-align:right">
                <asp:Button ID="btnLogout" runat="server" CausesValidation="False" OnClick="btnLogout_Click" Text="Logout" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"><h3>Incident Report Page</h3></td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style5"></td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style2">Select a customer:&nbsp;&nbsp;
                <asp:DropDownList ID="ddlCustomers" runat="server" AutoPostBack="True" Width="200px" OnSelectedIndexChanged="ddlCustomers_SelectedIndexChanged">
                    <asp:ListItem>--</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style3">Report Date and Time:&nbsp;&nbsp; <asp:TextBox ID="txtReportDateAndTime" runat="server" ReadOnly="True" Width="200px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorCustomer" runat="server" ControlToValidate="ddlCustomers" Display="Dynamic" ErrorMessage="You must select a customer" ForeColor="Red" InitialValue="--"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style5">Incident Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtIncidentNumber" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style2">Customer ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCustomerID" runat="server" CausesValidation="True" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style3">Status:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlStatus" runat="server" Width="100px">
                    <asp:ListItem>New</asp:ListItem>
                    <asp:ListItem>In Progress</asp:ListItem>
                    <asp:ListItem>Closed</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Description of Problem:</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:TextBox ID="txtDescription" runat="server" Height="150px" Width="600px" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorDescription" runat="server" ControlToValidate="txtDescription" Display="Dynamic" EnableTheming="False" ErrorMessage="You must add a description of the incident" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Method of Contact:<asp:RadioButtonList ID="rblMethodOfContact" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Email</asp:ListItem>
                <asp:ListItem>Phone</asp:ListItem>
                <asp:ListItem>In Person</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorMethodOfContact" runat="server" ControlToValidate="rblMethodOfContact" Display="Dynamic" ErrorMessage="You must select a method of contact" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td style="text-align:right">
                <asp:Button ID="btnBack" runat="server" PostBackUrl="~/ViewIncident.aspx" Text="Back" CausesValidation="False" />
            </td>
        </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
