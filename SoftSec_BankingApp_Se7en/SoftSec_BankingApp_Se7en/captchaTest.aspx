<%@ Page Title="" Language="C#" MasterPageFile="~/Final.Master" AutoEventWireup="true" CodeBehind="captchaTest.aspx.cs" Inherits="SoftSec_BankingApp_Se7en.captchaTest" %>
<%@ Register TagPrefix="recaptcha" Namespace="Recaptcha" Assembly="Recaptcha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        &nbsp;<asp:Label ID="Label1" runat="server" Text="Enter text from captcha here:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="captchaStringTF" runat="server"></asp:TextBox>
    <recaptcha:RecaptchaControl
    ID="recaptcha"
    runat="server"
    PublicKey="6LdqzOgSAAAAAPJVdYTT5sdiTvhy0jvglZWOmaX1"
    PrivateKey="6LdqzOgSAAAAAKRePKZH_6jMLAJlr3uWxc0lOQIX"
    />
       <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" style="height: 26px" />        
    
</asp:Content>
