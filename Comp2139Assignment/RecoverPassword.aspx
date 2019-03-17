<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecoverPassword.aspx.cs" Inherits="Comp2139Assignment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="/Content/bootstrap.css"/>
    <link rel="stylesheet" href="/Content/style.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1 class="text-center">Recover Password</h1>
                <div class="form-group form-row">
                    <label for="txtEmail" class="col-md-12 col-form-label">Email:
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </label>
                    <div class="col-md-12"><asp:Button ID="btnEmail" runat="server" Text="Retrieve Question" OnClick="btnEmail_Click" /></div>
                    <div class="col-md-12"><asp:Label ID="lblQuestion" runat="server"></asp:Label></div>
                    <div class="col-md-12 mt-2"><asp:TextBox ID="txtAnswer" runat="server" CssClass="auto-style1" Enabled="False"></asp:TextBox></div>
                    <div class="col-md-12 text-center">
                        <asp:Button class="btn btn-primary" ID="btnSubmitAns" runat="server" Text="Submit Answer" OnClick="btnSubmit0_Click" Enabled="False" />
                        <asp:Button ID="Button1" class=" btn btn-secondary" runat="server" CausesValidation="False" Text="Go Back" PostBackUrl="~/Login.aspx"/>

                    </div>


                </div>
        </div>
    </form>
</body>
</html>
