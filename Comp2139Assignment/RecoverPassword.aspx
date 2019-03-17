<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecoverPassword.aspx.cs" Inherits="Comp2139Assignment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Email:<br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:Button ID="btnEmail" runat="server" Text="Okay" OnClick="btnEmail_Click" />
            <br />
            <asp:Label ID="lblQuestion" runat="server"></asp:Label>
            <br />
            Answer:
            <asp:TextBox ID="txtAnswer" runat="server" CssClass="auto-style1" Width="166px" Enabled="False"></asp:TextBox>
            <br />
            <asp:Button ID="btnSubmitAns" runat="server" Text="Submit Answer" OnClick="btnSubmit0_Click" Enabled="False" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
