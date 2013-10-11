<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegularUserTransferDiff.aspx.cs" Inherits="SSBank.RegularUserTransferDiff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

    <head>
<title>Transfers</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .auto-style1 {
            height: 143px;
        }
        .auto-style3 {
            width: 279px;
        }
        .auto-style4 {
            margin-left: 1px;
        }
        .auto-style5 {
            width: 386px;
            text-align: center;
        }
        .auto-style6 {
            width: 352px;
            text-align: center;
        }
        .auto-style7 {
            width: 343px
        }
        .auto-style8 {
            text-align: center;
        }
        .auto-style9 {
            text-align: left;
        }
    </style>

</head>
<body id="sub">

    <form id="form1" runat="server">

<div id="wrapper">
	<div id="header">
    	<div id="site_title" class="auto-style3">
            <h1 class="auto-style7"><strong>&nbsp;BANK OF SE7EN </strong></h1>
        </div>
        <div id="menu">
            <ul>
                <li><a href="index.html" class="current">Home</a></li>
                <li><a href="banking.html">Banking</a></li>
                <li><a href="locations.html">Locations</a></li>
                <li><a href="about.html">About Us</a></li>
                <li><a href="contact.html">Contact</a></li>
            </ul>    	
        </div> 
    </div> 
   
    <div id="middle_sub" class="auto-style1">
        <div id="mid_title">Make a Transfer </div>
        <p>Note: Outside Banking System</p>
        	

        </p>
	</div> 
    
     <div id="main">
        <div class="col_w600 float_l">
        	
            <h2 class="auto-style8">Make Transfer</h2>
       
        <p class="auto-style5">From:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style4" Width="124px">
                <asp:ListItem>Checking Account</asp:ListItem>
                <asp:ListItem>Savings Account</asp:ListItem>
            </asp:DropDownList>
            </p>
            <p class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Amount:&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Width="115px"></asp:TextBox>
            </p>
            <p class="auto-style9"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Recepient&#39;s Details:</strong></p>
            <p class="auto-style9"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
            </p>
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
            </p>
            <p><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Your Details (Validation):</strong></p>
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Card Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
            </p>
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Expiry:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList6" runat="server">
                    <asp:ListItem>MM</asp:ListItem>
                    <asp:ListItem>Jan</asp:ListItem>
                    <asp:ListItem>Feb</asp:ListItem>
                    <asp:ListItem>Mar</asp:ListItem>
                    <asp:ListItem>Apr</asp:ListItem>
                    <asp:ListItem>May</asp:ListItem>
                    <asp:ListItem>June</asp:ListItem>
                    <asp:ListItem>Jul</asp:ListItem>
                    <asp:ListItem>Aug</asp:ListItem>
                    <asp:ListItem>Sep</asp:ListItem>
                    <asp:ListItem>Oct</asp:ListItem>
                    <asp:ListItem>Nov</asp:ListItem>
                    <asp:ListItem>Dec</asp:ListItem>
                </asp:DropDownList>
&nbsp;
                <asp:DropDownList ID="DropDownList7" runat="server">
                    <asp:ListItem>YYYY</asp:ListItem>
                    <asp:ListItem>2013</asp:ListItem>
                    <asp:ListItem>2014</asp:ListItem>
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem>2020</asp:ListItem>
                    <asp:ListItem>2021</asp:ListItem>
                    <asp:ListItem>2022</asp:ListItem>
                    <asp:ListItem>2023</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Security Code:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
            </p>
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server"  Text="Make Transfer" />
            </p>
	

             <p>
                 &nbsp;</p>
        </div>
        <div class="col_w300 float_r">
        
            <p>&nbsp;</p>
        
        </div>    
        <div class="cleaner"></div>	
    </div> 
</div> 

<div id="footer_wrapper">
    <div id="footer">
    
    	<div class="col_allw300">
        	<h4>Our Pages    	
            <ul class="footer_list">
            	<li><a href="index.html">Home</a></li>
            </ul>
            <ul class="footer_list">
            	<li>
            <ul class="footer_list">
                <li><a href="banking.html">Banking</a></li>
                <li><a href="locations.html">Locations</a></li>
                <li><a href="about.html">About US</a></li>
                <li><a href="contact.html">Contact</a></li>
            </ul>
                </li>
            </ul>
        </div>
    	<div class="col_allw300">
        	<h4>Our Partners</h4>
            <ul class="footer_list">
                <li><a href="http://www.koflash.com/" target="_parent">Credit Funds</a></li>            
                </ul>
            <ul class="footer_list">
                <li>
            <ul class="footer_list">
            	<li><a href="http://www.flashmo.com/" target="_parent">Debit Funds</a></li>
                <li><a href="http://www.templatemo.com/" target="_parent">Transfer Funds</a></li>
                <li><a href="http://www.flashmo.com/store" target="_parent">Payments</a></li>
                </ul>
                </li>
            </ul>
        </div>
    	<div class="auto-style3">
        	<h4>About Us</h4>
            <p>Bank of Se7en is a <a href="http://www.templatemo.com/" target="_blank">Online secured bank system</a> brought to you by <a href="http://www.templatemo.com/" target="_blank">Software Security - Team 7</a>. </p>
        </div>                
    
        <div class="cleaner"></div>
    
    </div> 
     <div class="cleaner"></div>
</div>


<div id="copyright_wrapper">
    <div id="copyright">
    	
            Designed by Group7@SoftwareSecurity 
        
    </div> 
</div>
    </form>
</body>
</html>

