<%@ Page Title="" Language="C#" MasterPageFile="~/Final.Master" AutoEventWireup="true" CodeBehind="captchaTest.aspx.cs" Inherits="SoftSec_BankingApp_Se7en.captchaTest" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <p>
        &nbsp;<asp:Label ID="Label1" runat="server" Text="Enter text from captcha here:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="captchaStringTF" runat="server"></asp:TextBox>

<cc1:CaptchaControl ID="Captcha1" runat="server"
 CaptchaBackgroundNoise="Low" CaptchaLength="5"
 CaptchaHeight="60" CaptchaWidth="200"
 CaptchaLineNoise="None" CaptchaMinTimeout="5"
 CaptchaMaxTimeout="240" FontColor = "#529E00" />
        
    
</asp:Content>
