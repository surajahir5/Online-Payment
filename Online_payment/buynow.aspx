<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="buynow.aspx.cs" Inherits="Online_payment.buynow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 57%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 186px;
        }
        .auto-style4 {
            height: 23px;
            width: 186px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Pay Now"></asp:Label>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Name </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="175px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Address</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="174px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Number</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox3" runat="server" Width="169px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Price</td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input type="hidden" runat="server" id="key" name="key" value="gtKFFx"/>
        <input type="hidden" runat="server" id="salt" name="salt" value="eCwWELxi"/>
        <input type="hidden" runat="server" id="hash" name="hash" value="" />
        <input type="hidden" runat="server" id="txnid" name="txnid" value=""/>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Pay" Width="75px" BackColor="#009933" />
    </form>
</body>
</html>
