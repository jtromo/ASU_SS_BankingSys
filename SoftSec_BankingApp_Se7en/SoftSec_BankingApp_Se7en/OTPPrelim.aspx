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
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generate" />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Verify it" />
    
    </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
