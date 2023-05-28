<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SuccesfulTransaction.aspx.cs" Inherits="BankingApplication.SuccesfulTransaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="MyDebits" runat="server" Height="45px" OnClick="Click_TransactionShow" Text="TransactionShow" Width="191px" />
        <asp:Button ID="MyBalance" runat="server" Height="45px" OnClick="Click_MyBalance" Text="My Balance" Width="175px" />
        <asp:Button ID="GoHome" runat="server" Height="46px" OnClick="Click_GoHome" Text="Home" Width="153px" />
    </form>
</body>
</html>
