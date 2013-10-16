<%@ Page Title="" Language="C#" MasterPageFile="~/Final.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="SoftSec_BankingApp_Se7en.ForgotPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <h6 __designer:mapid="2290">Security Questions</h6>
            <p __designer:mapid="2293">
                Sequrity Question 1:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList runat="server" ID="dd_secque1"><asp:ListItem Value="Default Question">Select Security Question</asp:ListItem>
<asp:ListItem Value="Question1">What was your childhood nickname? </asp:ListItem>
<asp:ListItem Value="Question2">In what city did you meet your spouse/significant other?</asp:ListItem>
<asp:ListItem Value="Question3">What is the name of your favorite childhood friend? </asp:ListItem>
<asp:ListItem Value="Question4">What is your oldest sibling&#39;s middle name?</asp:ListItem>
<asp:ListItem Value="Question5">In what city does your nearest sibling live? </asp:ListItem>
<asp:ListItem Value="Question6">In what city or town was your first job?</asp:ListItem>
<asp:ListItem Value="Question7">What is your maternal grandmother&#39;s maiden name?</asp:ListItem>
<asp:ListItem Value="Question8">What was your favorite place to visit as a child?</asp:ListItem>
<asp:ListItem Value="Question9">What is the name of your favorite childhood teacher?</asp:ListItem>
<asp:ListItem Value="Question10">What was the first concert you attended?</asp:ListItem>
</asp:DropDownList>

            </p>
            <p __designer:mapid="22a0">
                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox runat="server" ID="tb_secans1"></asp:TextBox>

            </p>
            <p __designer:mapid="22a2">
                Security Question 2:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList runat="server" ID="dd_secque2"><asp:ListItem Value="Default Question">Select Security Question</asp:ListItem>
<asp:ListItem Value="Question1">What was your childhood nickname? </asp:ListItem>
<asp:ListItem Value="Question2">In what city did you meet your spouse/significant other?</asp:ListItem>
<asp:ListItem Value="Question3">What is the name of your favorite childhood friend? </asp:ListItem>
<asp:ListItem Value="Question4">What is your oldest sibling&#39;s middle name?</asp:ListItem>
<asp:ListItem Value="Question5">In what city does your nearest sibling live? </asp:ListItem>
<asp:ListItem Value="Question6">In what city or town was your first job?</asp:ListItem>
<asp:ListItem Value="Question7">What is your maternal grandmother&#39;s maiden name?</asp:ListItem>
<asp:ListItem Value="Question8">What was your favorite place to visit as a child?</asp:ListItem>
<asp:ListItem Value="Question9">What is the name of your favorite childhood teacher?</asp:ListItem>
<asp:ListItem Value="Question10">What was the first concert you attended?</asp:ListItem>
</asp:DropDownList>

            </p>
            <p __designer:mapid="22af">
                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox runat="server" ID="tb_secans2"></asp:TextBox>

            </p>
            <p __designer:mapid="22b1">
                Security Question 3:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList runat="server" ID="dd_secque3"><asp:ListItem Value="Default Question">Select Security Question</asp:ListItem>
<asp:ListItem Value="Question1">What was your childhood nickname? </asp:ListItem>
<asp:ListItem Value="Question2">In what city did you meet your spouse/significant other?</asp:ListItem>
<asp:ListItem Value="Question3">What is the name of your favorite childhood friend? </asp:ListItem>
<asp:ListItem Value="Question4">What is your oldest sibling&#39;s middle name?</asp:ListItem>
<asp:ListItem Value="Question5">In what city does your nearest sibling live? </asp:ListItem>
<asp:ListItem Value="Question6">In what city or town was your first job?</asp:ListItem>
<asp:ListItem Value="Question7">What is your maternal grandmother&#39;s maiden name?</asp:ListItem>
<asp:ListItem Value="Question8">What was your favorite place to visit as a child?</asp:ListItem>
<asp:ListItem Value="Question9">What is the name of your favorite childhood teacher?</asp:ListItem>
<asp:ListItem Value="Question10">What was the first concert you attended?</asp:ListItem>
</asp:DropDownList>

            </p>
            <p __designer:mapid="22be">
                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox runat="server" Height="16px" Width="128px" ID="tb_secans3" style="margin-top: 6px"></asp:TextBox>

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
            <p __designer:mapid="22c0">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button runat="server" Text="Change Password" CssClass="auto-style3" ID="btn_changepwd" OnClick="btn_changepwd_Click"></asp:Button>

            </p>
            <p>
                <br />
    </p>
</asp:Content>
