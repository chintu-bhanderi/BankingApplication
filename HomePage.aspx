<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="BankingApplication.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="PerformTansaction" runat="server" Height="44px" OnClick="Click_PerformTransaction" Text="Perform Transaction" Width="203px" />
        <asp:Button ID="MyDebits" runat="server" Height="45px" OnClick="Click_TransactionShow" Text="TransactionShow" Width="191px" />
        <asp:Button ID="Button1" runat="server" Height="45px" OnClick="Click_MyCredit" Text="MyCredit" Width="196px" />
        <asp:Button ID="MyBalance" runat="server" Height="45px" OnClick="Click_MyBalance" Text="My Balance" Width="175px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="45px" OnClick="Button1_Click" Text="LogOut" Width="106px" />
&nbsp;<p>
            &nbsp;</p>
        <br />
        <br />
        <br />
    </form>
</body>
</html>
