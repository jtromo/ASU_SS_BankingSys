<%@ Page Title="" Language="C#" MasterPageFile="~/Final.Master" AutoEventWireup="true" CodeBehind="InvalidUserRole.aspx.cs" Inherits="SoftSec_BankingApp_Se7en.InvalidUserRole" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style1" style="text-align: center">
        &nbsp;</p>
    <p class="auto-style1" style="text-align: center">
        <span style="font-size: x-large; color: #003399">You do not have access to this Page!</p>
    <p class="auto-style1" style="text-align: center">
        &nbsp;</p>
    <p class="auto-style1" style="text-align: center">
        <asp:Image ID="img_invalidrole" runat="server" Height="175px" Width="144px" />
    </p>
    <p class="auto-style1" style="text-align: center">
        &nbsp;</p>
    <p class="auto-style1" style="text-align: center">
        </span>
    </p>
<p style="font-size: large; color: #003399; text-align: center">
    Here are some pages that might help you to get on your way!</p>
    <p style="font-size: large; color: #003399; text-align: center">
       <p style="font-size: large; color: #003399; text-align: center"><asp:HyperLink ID="homelink" NavigateUrl="~/ExternalHomePage.aspx" runat="server" style="font-size: large">Home Page</asp:HyperLink></p>
    <p>
        <br />
    </p>
</asp:Content>
