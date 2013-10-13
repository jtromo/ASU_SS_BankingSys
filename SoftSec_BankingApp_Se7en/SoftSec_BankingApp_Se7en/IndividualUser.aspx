<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndividualUser.aspx.cs" Inherits="SoftSec_BankingApp_Se7en.IndividualUser" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Height="209px" Width="874px">
            <asp:TabPanel runat="server" HeaderText="TabPanel1" ID="TabPanel1">
                <ContentTemplate>
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel runat="server" HeaderText="TabPanel2" ID="TabPanel2">
            </asp:TabPanel>
            <asp:TabPanel ID="TabPanel3" runat="server" HeaderText="TabPanel3">
            </asp:TabPanel>
            <asp:TabPanel ID="TabPanel4" runat="server" HeaderText="TabPanel4">
            </asp:TabPanel>
        </asp:TabContainer>
    </form>
</body>
</html>
