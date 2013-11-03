<%@ Page Title="" Language="C#" MasterPageFile="~/Final.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="SoftSec_BankingApp_Se7en.ForgotPassword" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<%@ Register TagPrefix="recaptcha" Namespace="Recaptcha" Assembly="Recaptcha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <h6 __designer:mapid="2290">Security Questions</h6>
            <p __designer:mapid="2293">
                Sequrity Question 1:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList runat="server" ID="dd_secque1" Enabled="False"><asp:ListItem Value="Default Question">Select Security Question</asp:ListItem>
<asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
<asp:ListItem Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
<asp:ListItem Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
<asp:ListItem Value="4">What is your oldest sibling&#39;s middle name?</asp:ListItem>
<asp:ListItem Value="5">In what city does your nearest sibling live? </asp:ListItem>
<asp:ListItem Value="6">In what city or town was your first job?</asp:ListItem>
<asp:ListItem Value="7">What is your maternal grandmother&#39;s maiden name?</asp:ListItem>
<asp:ListItem Value="8">What was your favorite place to visit as a child?</asp:ListItem>
<asp:ListItem Value="9">What is the name of your favorite childhood teacher?</asp:ListItem>
<asp:ListItem Value="10">What was the first concert you attended?</asp:ListItem>
</asp:DropDownList>

            </p>
            <p __designer:mapid="22a0">
                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox runat="server" ID="tb_secans1" oncopy="return false" onpaste="return false"></asp:TextBox>

            </p>
            <p __designer:mapid="22a2">
                Security Question 2:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList runat="server" ID="dd_secque2" Enabled="False"><asp:ListItem Value="Default Question">Select Security Question</asp:ListItem>
<asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
<asp:ListItem Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
<asp:ListItem Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
<asp:ListItem Value="4">What is your oldest sibling&#39;s middle name?</asp:ListItem>
<asp:ListItem Value="5">In what city does your nearest sibling live? </asp:ListItem>
<asp:ListItem Value="6">In what city or town was your first job?</asp:ListItem>
<asp:ListItem Value="7">What is your maternal grandmother&#39;s maiden name?</asp:ListItem>
<asp:ListItem Value="8">What was your favorite place to visit as a child?</asp:ListItem>
<asp:ListItem Value="9">What is the name of your favorite childhood teacher?</asp:ListItem>
<asp:ListItem Value="10">What was the first concert you attended?</asp:ListItem>
</asp:DropDownList>

            </p>
            <p __designer:mapid="22af">
                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox runat="server" ID="tb_secans2" oncopy="return false" onpaste="return false"></asp:TextBox>

            </p>
            <p __designer:mapid="22b1">
                Security Question 3:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList runat="server" ID="dd_secque3" Enabled="False"><asp:ListItem Value="Default Question">Select Security Question</asp:ListItem>
<asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
<asp:ListItem Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
<asp:ListItem Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
<asp:ListItem Value="4">What is your oldest sibling&#39;s middle name?</asp:ListItem>
<asp:ListItem Value="5">In what city does your nearest sibling live? </asp:ListItem>
<asp:ListItem Value="6">In what city or town was your first job?</asp:ListItem>
<asp:ListItem Value="7">What is your maternal grandmother&#39;s maiden name?</asp:ListItem>
<asp:ListItem Value="8">What was your favorite place to visit as a child?</asp:ListItem>
<asp:ListItem Value="9">What is the name of your favorite childhood teacher?</asp:ListItem>
<asp:ListItem Value="10">What was the first concert you attended?</asp:ListItem>
</asp:DropDownList>
            </p>
            <p __designer:mapid="22be">
                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox runat="server" Height="16px" Width="128px" ID="tb_secans3" style="margin-top: 6px" oncopy="return false" onpaste="return false"></asp:TextBox>

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
    <recaptcha:RecaptchaControl
    ID="recaptcha"
    runat="server"
    PublicKey="6LdqzOgSAAAAAPJVdYTT5sdiTvhy0jvglZWOmaX1"
    PrivateKey="6LdqzOgSAAAAAKRePKZH_6jMLAJlr3uWxc0lOQIX"
    />
            <p __designer:mapid="22be">
                &nbsp;</p>
            <p __designer:mapid="22be">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblStatus_ForgotPassword" runat="server" Visible="False"></asp:Label>
            </p>
            <p __designer:mapid="22c0">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button runat="server" Text="Change Password" CssClass="auto-style3" ID="btn_changepwd" OnClick="btn_changepwd_Click"></asp:Button>

            </p>
            <p>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <br />
    </p>
</asp:Content>
