<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegularUserViewTransfer.aspx.cs" Inherits="SSBank.RegularUserViewTransfer" %>

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
        .auto-style7 {
            width: 343px
        }
        .auto-style8 {
            margin-left: 21px;
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
        <div id="mid_title">View Transfers</div>
        <p>&nbsp;</p>
        	

        </p>
	</div> 
    
     <div id="main">
        <div class="col_w600 float_l">
        	
            <h2>History of Transfers to/from your Account:</h2>
       
            <p>Show transfers for:
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Last 30 days and Future Scheduled Transfers</asp:ListItem>
                    <asp:ListItem>Prior 2 months</asp:ListItem>
                    <asp:ListItem>Prior 3 months</asp:ListItem>
                    <asp:ListItem>Prior 6 months</asp:ListItem>
                    <asp:ListItem>All transfers</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="Button1" runat="server" Text="Go!" CssClass="auto-style8" />
            </p>
            
             <p>
                 <asp:Table ID="Table1" runat="server" CellPadding="5" GridLines="horizontal" HorizontalAlign="Center" Width="586px">
                     <asp:TableRow>
                         <asp:TableCell>Date</asp:TableCell>
                         <asp:TableCell>From</asp:TableCell>
                         <asp:TableCell>To</asp:TableCell>
                         <asp:TableCell>Amount</asp:TableCell>
                         <asp:TableCell>Comments</asp:TableCell>
                     </asp:TableRow>
                 </asp:Table>
            </p>
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </p>
	

             <p>
                 &nbsp;</p>
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
            <p>Bank of Se7en is a <a href="http://www.templatemo.com/" target="_blank">Online secured bank system</a> brought to you by <a href="http://www.templatemo.com/" target="_blank">
                </br> Software Security -Team 7</a>. </p>
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