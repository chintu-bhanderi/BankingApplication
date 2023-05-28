<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorHandler.aspx.cs" Inherits="BankingApplication.ErrorHandler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Your Balance is not sufficient to perform this Payment."></asp:Label>
            <br />
        </div>
        <p>
            <asp:Button ID="GoHome" runat="server" Height="46px" OnClick="Click_GoHome" Text="Home" Width="153px" />
        </p>
    </form>
</body>
</html>
