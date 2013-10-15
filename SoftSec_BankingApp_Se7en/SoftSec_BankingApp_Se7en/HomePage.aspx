<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="SSBank.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Bank of Se7en</title>
<link href="CSS/style.css" rel="stylesheet" type="text/css" />

<script language="javascript" type="text/javascript">
    function clearText(field) {
        if (field.defaultValue == field.value) field.value = '';
        else if (field.value == '') field.value = field.defaultValue;
    }
</script>

<link rel="stylesheet" type="text/css" href="css/contentslider.css" />
<script type="text/javascript" src="script/contentslider.js">

</script>

    

    <style type="text/css">
        .auto-style1 {
            text-align: justify;
        }
        .auto-style2 {
            text-align: left;
            width: 282px;
        }
    </style>

    

</head>
<body id="home">
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
    
    <div id="middle">
    	<div id="mid_slider"><span></span>
        	<div id="slider1" class="sliderwrapper">

                <div class="contentdiv">
                    <img src="Images/slider/bank0.jpg" alt="Image 00" />
                </div>
    
                <div class="contentdiv">
                    <img src="Images/slider/bank1.jpg" alt="Image 01" />
                </div>            
                
                <div class="contentdiv">
                    <img src="Images/slider/bank3.jpg" alt="Image 02" />
                </div>
                
                <div class="contentdiv">
                    <img src="Images/slider/bank4.jpg" alt="Image 03" />
                </div>
            
            </div>
            
            <div id="paginate-slider1" class="pagination">
            
      </div>
            
            <script type="text/javascript">

                featuredcontentslider.init({
                    id: "slider1",  //id of main slider DIV
                    contentsource: ["inline", ""],  //Valid values: ["inline", ""] or ["ajax", "path_to_file"]
                    toc: "#increment",  //Valid values: "#increment", "markup", ["label1", "label2", etc]
                    nextprev: ["", ""],  //labels for "prev" and "next" links. Set to "" to hide.
                    revealtype: "click", //Behavior of pagination links to reveal the slides: "click" or "mouseover"
                    enablefade: [true, 0.4],  //[true/false, fadedegree]
                    autorotate: [true, 2000],  //[true/false, pausetime]
                    onChange: function (previndex, curindex) {  //event handler fired whenever script changes slide
                        //previndex holds index of last slide viewed b4 current (1=1st slide, 2nd=2nd etc)
                        //curindex holds index of currently shown slide (1=1st slide, 2nd=2nd etc)
                    }
                })

            </script>
        </div>
        <div id="mid_left">
            <div id="mid_title">A Secure Banking System</div>
            <p>This website will facilitate the you to manage your bank accounts, transfers, direct deposits, etc online in a secured way.</p>
            <div id="learn_more"><a href="#">Learn More</a></div>
	  </div>
        <div class="cleaner"></div>
	</div> <!-- end of middle -->
    
     <div id="main">
        <div id="content">
        
        	<div class="col_allw300">
            	<h2>Log In</h2>
                <div class="cleaner">&nbsp;&nbsp; Username:&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1" Height="16px"></asp:TextBox>
                    <br />
                    <br />
&nbsp;&nbsp; Zip Code:&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:TextBox ID="TextBox2" runat="server" Height="17px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="Sign In!" />
                </div>
            </div>
			
			<div class="col_allw300">
            	 <div class="adv_box">
                     <h3>Enroll in Online Banking!</h3>
                    <img src="Images/thumb0.jpg" alt="Image 04" />
                    <div class="news_date">Stay up to date. Manage your accounts from anywhere!
                        <br />
                        100% Secured!</div>
                    
                  <div class="cleaner"></div>
                </div>
                <div class="adv_box">
                    <h3>Online Bill Pay</h3>
                    <img src="Images/thumb1.jpg" alt="Image 05" />
                    <div class="news_date">Pay your bills now Online in a secured online system!</div>
                   
                    <div class="cleaner"></div>
                </div>
                
            </div>
            
            <div class="col_allw300 col_last">
            	<h3>Go Paperless!</h3>
                <div class="adv_box">
                <img src="Images/thumb2.jpg" alt="Image 06" />
                    <div class="news_date">No more paper documents in mails!Get all statements in Email!</div>
                    <div class="cleaner"></div>
                </div> 
                <div class="adv_box">
                     <h3>Savings Accounts</h3>
                    <img src="Images/thumb3.jpg" alt="Image 07" />
                    <div class="news_date">Use your Savings account to plan for your future!</div>
                    
                    <div class="cleaner"></div>
                </div>   
            </div>
    </div> 
</div> 

<div id="footer_wrapper">
    <div id="footer">
    
    	<div class="col_allw300">
        	<h4>Our Pages</h4>
            <ul class="footer_list">
            	<li><a href="index.html">Home</a></li>
                <li><a href="banking.html">Banking</a></li>
                <li><a href="locations.html">Locations</a></li>
                <li><a href="about.html">About US</a></li>
                <li><a href="contact.html">Contact</a></li>
            </ul>
        </div>
    	<div class="col_allw300">
        	<h4>Our Banking Features</h4>
            <ul class="footer_list">
                <li><a href="http://www.koflash.com/" target="_parent">Credit Funds</a></li>            
            	<li><a href="http://www.flashmo.com/" target="_parent">Debit Funds</a></li>
                <li><a href="http://www.templatemo.com/" target="_parent">Transfer Funds</a></li>
                <li><a href="http://www.flashmo.com/store" target="_parent">Payments</a></li>
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
    <p>
        s</p>
</body>
</html>