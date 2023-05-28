<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home1.aspx.cs" Inherits="BankingApplication.Home1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 873px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button2" runat="server" CssClass="auto-style1" Height="45px" OnClick="SignIn_Click" Text="SignIn" Width="112px" />
        <asp:Button ID="Button1" runat="server" Height="45px" OnClick="SignUp_Click" Text="SignUp" Width="114px" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Height="45px" Enabled="False" ForeColor="Blue" Text="Welcome To Our Side.."></asp:Label>
    </form>
</body>
</html>
