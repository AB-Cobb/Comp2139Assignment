
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PasswordReset.aspx.cs" Inherits="Comp2139Assignment.PasswordReset" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pass Word Reset</title>
    <link rel="stylesheet" href="/Content/bootstrap.css"/>
    <link rel="stylesheet" href="/Content/style.css"/>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div class="container">
            <div class="row">
                 <div class="col-md-12"><h1>Your Password Was reset</h1></div>
                 <div class="col-md-12"><p>Please Check Your Email for your new Password</p></div>
                 <div class="col-md-12"><p>
                <asp:Button ID="Button1" runat="server" Text="Return to Login" class="btn btn-primary" OnClick="Button1_Click" />
                </p></div>
            </div>
        </div>
    </form>
    
</body>
</html>
