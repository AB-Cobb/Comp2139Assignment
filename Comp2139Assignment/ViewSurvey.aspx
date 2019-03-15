<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewSurvey.aspx.cs" Inherits="Comp2139Assignment.ViewSurvey" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 541px;
        }
        .auto-style4 {
            height: 23px;
            width: 541px;
        }
        .auto-style5 {
            width: 557px;
        }
        .auto-style6 {
            height: 23px;
            width: 557px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="2" style="text-align:center"><h1>TechKnow Pro - Incident Report Management System</h1></td>
            <td style="text-align:right">
                <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" CausesValidation="False" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"><h3>View Survey</h3></td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Select A Customer:&nbsp;&nbsp;
                <asp:DropDownList ID="ddlCustomers" runat="server" AutoPostBack="True" Width="200px" OnSelectedIndexChanged="ddlCustomers_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="auto-style6">Customer ID:&nbsp;&nbsp;
                <asp:TextBox ID="txtCustomer" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Survey Listing:</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:ListBox ID="lstbSurvey" runat="server" Rows="8" Width="600px" OnSelectedIndexChanged="lstbSurvey_SelectedIndexChanged"></asp:ListBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="btnRetrieveSurveyDetails" runat="server" Text="Retrieve Survey Details" OnClick="btnRetrieveSurveyDetails_Click" />
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
            <td class="auto-style3"><h3>Customer Rating</h3></td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Respose Time:<asp:Label ID="lblResponseTime" runat="server"></asp:Label>
            </td>
            <td class="auto-style6">Contact to Discuss Incident:</td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Techician Efficiency: 
                <asp:Label ID="lblTechEfficientcy" runat="server"></asp:Label>
            </td>
            <td class="auto-style5">Preferred Contact Method: </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Problem Resolution: 
                <asp:Label ID="lblProbResolution" runat="server"></asp:Label>
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
            <td class="auto-style4">Additional Comments:</td>
            <td class="auto-style6"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:TextBox ID="txtAdditionalComments" runat="server" Height="100px" ReadOnly="True" Width="400px" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td class="auto-style6"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="btnHome" runat="server" CausesValidation="False" Text="Home" PostBackUrl="~/HomePage.aspx"/>
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
