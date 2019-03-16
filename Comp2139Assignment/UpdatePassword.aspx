<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePassword.aspx.cs" Inherits="Comp2139Assignment.UpdatePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 49px;
        }
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
            <asp:Label ID="lblQuestion" runat="server" Text="[Secret Question will be displayed here]"></asp:Label>
            <br />
            Answer:
            <asp:TextBox ID="txtAnswer" runat="server" CssClass="auto-style1" Width="166px"></asp:TextBox>
            <br />
            <br />
            New Password:<asp:TextBox ID="txtNewPW" runat="server" CssClass="auto-style2" Width="170px"></asp:TextBox>
            <br />
            Comfirm PW :
            <asp:TextBox ID="txtNewPW0" runat="server" CssClass="auto-style3" Width="167px"></asp:TextBox>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
