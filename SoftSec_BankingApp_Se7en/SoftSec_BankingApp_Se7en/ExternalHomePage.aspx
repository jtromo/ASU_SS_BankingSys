<%@ Page Title="" Language="C#" MasterPageFile="~/Final.Master" AutoEventWireup="true" CodeBehind="ExternalHomePage.aspx.cs" Inherits="SoftSec_BankingApp_Se7en.ExternalHomePage" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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

    

    <div style="height:600px";>
        <div>
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
	</div>
            <div id="main">
        <div id="content">
        
        	<div class="col_allw300">
            	<h2>Log In</h2>
                <div class="cleaner">&nbsp;&nbsp; Username:&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TB_UserName" runat="server" oncopy="return false" onpaste="return false" MaxLength="20"></asp:TextBox>
        <asp:FilteredTextBoxExtender ID="TB_UserName_FilteredTextBoxExtender" runat="server" Enabled="True" InvalidChars=".&lt;&gt;/:+=;'&quot;?,@#$%^&amp;*()" TargetControlID="TB_UserName" FilterInterval="50" FilterMode="InvalidChars">
        </asp:FilteredTextBoxExtender>
        <br />
                    <br />
&nbsp;&nbsp; Zip Code:&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:TextBox ID="TB_ZipCode" runat="server" MaxLength="5" oncopy="return false" onpaste="return false"></asp:TextBox>&nbsp;
        <asp:FilteredTextBoxExtender ID="TB_ZipCode_FilteredTextBoxExtender" runat="server" Enabled="True" FilterInterval="50" FilterType="Numbers" TargetControlID="TB_ZipCode">
        </asp:FilteredTextBoxExtender>
        
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Btn_SignIn" runat="server" Text="Sign In" OnClick="Btn_SignIn_Click" style="height: 26px" />
                    <br />
&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblErrorMessage" runat="server" Text="Label"></asp:Label>
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

        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
