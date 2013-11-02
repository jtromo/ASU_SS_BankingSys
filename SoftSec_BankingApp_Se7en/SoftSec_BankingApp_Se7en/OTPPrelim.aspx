<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OTPPrelim.aspx.cs" Inherits="SoftSec_BankingApp_Se7en.OTPPrelim" %>

<%@ Register assembly="Recaptcha" namespace="Recaptcha" tagprefix="recaptcha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generate" style="height: 26px" />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Verify it" />
    
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Add Admin" />
    
    </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
            <asp:Button ID="addRegUserBT" runat="server" OnClick="addRegUserBT_Click" Text="add regular user" />
        </p>
        <p>
            <asp:Button ID="Button6" runat="server" Text="Button" />
        </p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </form>
</body>
</html>
