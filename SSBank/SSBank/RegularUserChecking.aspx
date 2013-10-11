<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegularUserChecking.aspx.cs" Inherits="SSBank.RegularUserChecking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Personal Accounts</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .auto-style1 {
            height: 143px;
        }
        .auto-style3 {
            width: 279px;
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
        <div id="mid_title">Checking Account</div>
        <p>Summary:</p>
        <p>Available balance: </p>
	

        </p>
	</div> 
    
     <div id="main">
        <div class="col_w600 float_l">
        	
            <h2>Accounts Balance History</h2>
       
             <p>
                 <asp:Table ID="Table1" runat="server" Width="586px" CellPadding="5" GridLines="horizontal" HorizontalAlign="Center">
                    <asp:TableRow>
                     <asp:TableCell>Date</asp:TableCell>
                     <asp:TableCell>Description</asp:TableCell>
                     <asp:TableCell>Amount</asp:TableCell>
                     <asp:TableCell>Balance Available</asp:TableCell>
                     <asp:TableCell>Statement Balance</asp:TableCell>
                   </asp:TableRow>
                 </asp:Table>
            </p>
        </div>
        <div class="col_w300 float_r">
        
            <h2>Account Information</h2>
            
             <p>Account Type: Checking Account</p>
            <p>Account Number:</p>
            <p>Routing Number:</p>
            <p>&nbsp;</p>
        
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

