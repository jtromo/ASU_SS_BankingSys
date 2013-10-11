<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegularUserHome.aspx.cs" Inherits="SSBank.WebForm2" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Personal Accounts</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />

    
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
        .auto-style2 {
            text-align: left;
            width: 287px;
        }
    </style>

    
</head>
<body id="sub">

    <form id="form1" runat="server">

<<div id="wrapper">
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
        <div id="mid_title">Welcome, User!</div>
	</div> 
    
     <div id="main">
        <div class="col_w600 float_l">
        	
            <h2>Personal Accounts</h2>
       
             <p></p>
            <asp:BulletedList ID="BulletedList1" runat="server">
                <asp:ListItem>Checking Account</asp:ListItem>
                <asp:ListItem>Savings Account</asp:ListItem>
                <asp:ListItem>Credit Account</asp:ListItem>
            </asp:BulletedList>
        	
            <h2>Transfers</h2>
       
            <p>
                &nbsp;<asp:BulletedList ID="BulletedList2" runat="server" >
                <asp:ListItem>Make a Transfer to Same Banking Account</asp:ListItem>
                <asp:ListItem>Make a Transfer to Different Banking Account</asp:ListItem>
                <asp:ListItem>Debit Funds</asp:ListItem>
                <asp:ListItem>Credit Funds</asp:ListItem>
                <asp:ListItem>View Transfers</asp:ListItem>
            </asp:BulletedList>
            </p>
        </div>
        <div class="col_w300 float_r">
        
            <h2>Account Details</h2>
            
             <asp:BulletedList ID="BulletedList3" runat="server">
                <asp:ListItem>View Account Details</asp:ListItem>
                <asp:ListItem>Update Account Details</asp:ListItem>
            </asp:BulletedList>
        
        </div>    
        <div class="cleaner"></div>	
    </div> 
</div> 

<div id="footer_wrapper">
    <div id="footer">
    
    	<div class="col_allw300">
        	<h4>Our Pages</h4>
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
    	<div class="col_allw300 col_last">
        	<h4>About Us</h4>
            <p class="auto-style2">Bank of Se7en is a <a href="http://www.templatemo.com/" target="_blank">Online secured bank system</a> brought to you by <a href="http://www.templatemo.com/" target="_blank">Software Security - Team 7</a>. </p>
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
