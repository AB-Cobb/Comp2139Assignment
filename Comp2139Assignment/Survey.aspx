<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Survey.aspx.cs" Inherits="Comp2139Assignment.Survey" %>

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
    <table class="auto-style1">
        <tr>
            <td colspan="2" style="text-align:center"><h1>TechKnow Pro - Incident Report Management Software</h1></td>
            <td style="text-align:right">
                <asp:Button ID="btnLogout" runat="server" CausesValidation="False" OnClick="btnLogout_Click" Text="Logout" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><h3>Surveys - Collect feedback from customers</h3></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Customer ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCustomerID" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Select and Incident:</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="ddlIncidentList" runat="server" Height="70px" Width="474px">
                </asp:DropDownList>
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
            <td><h4>Please rate this incident by the following categories:</h4></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Response Time:<asp:RadioButtonList ID="rblResponseTime" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Very Satisfied</asp:ListItem>
                <asp:ListItem>Satisfied</asp:ListItem>
                <asp:ListItem>Average</asp:ListItem>
                <asp:ListItem>Unsatisfied</asp:ListItem>
                <asp:ListItem>Very Unsatisfied</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorResponseTime" runat="server" ControlToValidate="rblResponseTime" Display="Dynamic" ErrorMessage="Please select one of the above options" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Technician Efficiency:<asp:RadioButtonList ID="rblTechnicianEfficiency" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Very Satisfied</asp:ListItem>
                <asp:ListItem>Satisfied</asp:ListItem>
                <asp:ListItem>Average</asp:ListItem>
                <asp:ListItem>Unsatisfied</asp:ListItem>
                <asp:ListItem>Very Unsatisfied</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorTechnicianEfficiency" runat="server" ControlToValidate="rblTechnicianEfficiency" Display="Dynamic" ErrorMessage="Please select one of the above options" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Problem Resolution:<asp:RadioButtonList ID="rblProblemResolution" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Very Satisfied</asp:ListItem>
                <asp:ListItem>Satisfied</asp:ListItem>
                <asp:ListItem>Average</asp:ListItem>
                <asp:ListItem>Unsatisfied</asp:ListItem>
                <asp:ListItem>Very Unsatisfied</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorProblemResolution" runat="server" ControlToValidate="rblProblemResolution" Display="Dynamic" ErrorMessage="Please select one of the above options" ForeColor="Red"></asp:RequiredFieldValidator>
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
            <td>Additional Comments:</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtAdditionalComments" runat="server" Height="119px" TextMode="MultiLine" Width="458px"></asp:TextBox>
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
                <asp:CheckBox ID="chkContactMe" runat="server" AutoPostBack="True" OnCheckedChanged="chkContactMe_CheckedChanged" Text="Please contact me to discuss this incident" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:RadioButtonList ID="rblContactMe" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>Contact Via Email</asp:ListItem>
                    <asp:ListItem>Contact Via Phone</asp:ListItem>
                </asp:RadioButtonList>
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
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit Survey" />
            </td>
            <td>&nbsp;</td>
            <td style="text-align:right">
                <asp:Button ID="btnBack" runat="server" CausesValidation="False" Text="Back" PostBackUrl="~/HomePage.aspx" />
            </td>
        </tr>
    </table>
        <div>
        </div>
    </form>
</body>
</html>
