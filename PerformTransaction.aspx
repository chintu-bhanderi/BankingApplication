<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PerformTransaction.aspx.cs" Inherits="BankingApplication.PerformTransaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 349px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
            width: 329px;
        }
        .auto-style6 {
            width: 329px;
        }
        .auto-style7 {
            height: 48px;
            width: 329px;
        }
        .auto-style8 {
            height: 48px;
        }
        .auto-style9 {
            height: 29px;
            width: 329px;
        }
        .auto-style10 {
            height: 29px;
        }
        .auto-style11 {
            height: 29px;
            width: 323px;
        }
        .auto-style12 {
            height: 26px;
            width: 323px;
        }
        .auto-style13 {
            height: 48px;
            width: 323px;
        }
        .auto-style14 {
            width: 323px;
        }
        .auto-style15 {
            height: 49px;
            width: 329px;
        }
        .auto-style16 {
            height: 49px;
            width: 323px;
        }
        .auto-style17 {
            height: 49px;
        }
        .auto-style18 {
            margin-left: 2px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="payAcNo" runat="server" Text="Payee Account No."></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:DropDownList ID="ddlAcNo" runat="server" Height="27px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="169px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style10">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="PayName" runat="server" Text="Payee Name"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="TbName" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredPayName" runat="server" ControlToValidate="TbName" ErrorMessage="Name is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td id="PayAmount" class="auto-style7">
                        <asp:Label ID="PayAmount" runat="server" Text="Amount"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="TbAmount" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:CompareValidator ID="ComparePayAmount" runat="server" ControlToValidate="TbAmount" ErrorMessage="Amount must be more than 0." ForeColor="Red" Operator="GreaterThan" Type="Integer" ValueToCompare="0"></asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="RequiredPayAmount" runat="server" ControlToValidate="TbAmount" ErrorMessage="Amount is Required." ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td id="PayRemark" class="auto-style6">
                        <asp:Label ID="PayRemark" runat="server" Text="Remark"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <asp:TextBox ID="TbRemark" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredPayRemark" runat="server" ControlToValidate="TbRemark" ErrorMessage="Remark is Required." ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15"></td>
                    <td class="auto-style16">
                        <asp:Button ID="BtnPay" runat="server" OnClick="btnPay_Submit" Text="Payment" CssClass="auto-style18" Height="31px" Width="81px" />
                        <asp:Button ID="Button1" runat="server" Height="31px" OnClick="Click_Cancel" Text="Cancel" Width="82px" />
                    </td>
                    <td class="auto-style17"></td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style14"></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
