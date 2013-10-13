<%@ Page Title="" Language="C#" MasterPageFile="~/Final.Master" AutoEventWireup="true" CodeBehind="InternalUser.aspx.cs" Inherits="SoftSec_BankingApp_Se7en.InternalUser" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height:800px";>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Height="641px" Width="874px">
            <asp:TabPanel runat="server" HeaderText="Accounts" ID="tab_accounts">
                <ContentTemplate>
                    Checking Account:
                    <asp:TextBox ID="tb_checking" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:Button ID="btn_checking" runat="server"  Text="View Summary" />
                    <br />
                    Savings Account:&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_savings" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:Button ID="btn_savings" runat="server"  Text="View Summary" />
                    <br />
                    Credit Account:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_credit" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:Button ID="btn_credit" runat="server"  Text="View Summary" />
                    <br />
                    <br />
                    //display account summary<br></br>
                    <br>
                    </br>
                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel runat="server" HeaderText="Transfers" ID="tab_transfers">
                <ContentTemplate>
                    <br />
                    Please select the transfer type.<br />
                    <asp:TabContainer ID="TabContainer2" runat="server" ActiveTabIndex="0" Height="515px" Width="850px">
                        <asp:TabPanel ID="tab_trans_inside" runat="server" HeaderText="Inside Bank">
                            <ContentTemplate>
                                <p>&nbsp;</p>
                                <p>
                                    From:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:DropDownList ID="dd_acctype" runat="server" CssClass="auto-style4" Width="124px">
                                        <asp:ListItem>Checking Account</asp:ListItem>
                                        <asp:ListItem>Savings Account</asp:ListItem>
                                    </asp:DropDownList>
                                </p>
                                <p class="auto-style6">Amount:&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_amount" runat="server" Width="115px"></asp:TextBox>
            </p>
            <p><strong>Recepient&#39;s Details:</strong></p>
            <p>&nbsp;Account Number:&nbsp;&nbsp;
                <asp:TextBox ID="tb_recepient" runat="server"></asp:TextBox>
            </p>
            
             <p>Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tb_lastname" runat="server"></asp:TextBox>
            </p>
            <p>Zip Code:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_zip" runat="server"></asp:TextBox>
            </p>
            <p><strong>Your Details (Validation):</strong></p>
            <p>Card Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tb_card" runat="server"></asp:TextBox>
            </p>
            <p>Expiry:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="dd_month" runat="server">
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
                <asp:DropDownList ID="dd_year" runat="server">
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
            <p>Security Code:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_securitycode" runat="server"></asp:TextBox>
            </p>
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_maketransinside" runat="server" Text="Make Transfer" />
            </p>
            <p>&nbsp;</p>
        </ContentTemplate>
     </asp:TabPanel>
     <asp:TabPanel ID="tab_trans_outside" runat="server" HeaderText="Outside Bank">
          <ContentTemplate>
              <p class="auto-style5">&nbsp;</p>
            <p class="auto-style5">From:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="dd_acctypeoutside" runat="server" CssClass="auto-style4" Width="124px">
                    <asp:ListItem>Checking Account</asp:ListItem>
                    <asp:ListItem>Savings Account</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p class="auto-style5">Amount:&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_amountoutside" runat="server" Width="115px"></asp:TextBox>
              </p>
            <p class="auto-style5"><strong>Recepient&#39;s Details:</strong>Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tb_lastnameoutside" runat="server"></asp:TextBox>
            </p>
            <p class="auto-style9">
            </p>
            <p class="auto-style9">Email ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_emailoutside" runat="server"></asp:TextBox>
              </p>
            <p class="auto-style9"><strong>Your Details (Validation):</strong>Card Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
            </p>
            <p>
            </p>
            <p>
                <asp:DropDownList ID="dd_monthoutside" runat="server">
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
                <asp:DropDownList ID="dd_yearoutside" runat="server">
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
                Security Code:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_securitycodeoutside" runat="server"></asp:TextBox>
            </p>
	

            <p>Expiry:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
              <p>
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Button ID="btn_maketransferoutside" runat="server" Text="Make Transfer" />
              </p>
	

             <p>
                 &nbsp;</p>
          </ContentTemplate>
      
     </asp:TabPanel>
     <asp:TabPanel ID="tab_trans_between" runat="server" HeaderText="Between Your Accounts">
     <ContentTemplate>
            <p class="auto-style5">&nbsp;</p>
            <p class="auto-style5">
            From:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="dd_acctypebetween1" runat="server" CssClass="auto-style4" Width="124px">
            <asp:ListItem>Checking Account</asp:ListItem>
            <asp:ListItem>Savings Account</asp:ListItem>
            </asp:DropDownList>
                                 </p>
            <p class="auto-style5">To:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="dd_acctypebetween2" runat="server" CssClass="auto-style4" Width="124px">
                    <asp:ListItem>Checking Account</asp:ListItem>
                    <asp:ListItem>Savings Account</asp:ListItem>
                    <asp:ListItem>Credit Account</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p class="auto-style5">Amount:&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_amountbetween" runat="server" Width="115px"></asp:TextBox>
            </p>
	

             <p class="auto-style5">
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="btn_maketransbetween" runat="server" Text="Make Transfer" />
            </p>
	

             <p>
                 &nbsp;</p>

                            </ContentTemplate>
                            </asp:TabPanel>
                    </asp:TabContainer>
                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="tab_profile" runat="server" HeaderText="Profile">
                <ContentTemplate>

                    <br />
                    <h6>Contact Information&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Account Settings</h6>
  
                     <p>Email Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:TextBox ID="tb_emailview" runat="server"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password (last updated):
                         <asp:TextBox ID="tb_pwdlastview" runat="server"></asp:TextBox>
                    </p>
                     <p>Residential Address:&nbsp;&nbsp;
                         <asp:TextBox ID="tb_addrview" runat="server"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:TextBox ID="tb_usernameview" runat="server"></asp:TextBox>
                    </p>
                     <p>Contact:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:TextBox ID="tb_contactview" runat="server"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nickname:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:TextBox ID="tb_nicknameview" runat="server"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </p>
                     <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" Text="Edit Profile" />
                    </p>
                     <p>
                    </p>
                    <asp:TabContainer ID="TabContainer3" runat="server" ActiveTabIndex="1" Height="369px" Width="837px">
                        <asp:TabPanel ID="tabeditprofile" runat="server" HeaderText="Edit Profile" Height="600px" Width="124px">
                            <ContentTemplate>

                                <br />
                                <h6>Contact Information</h6>
                                <p>
                                    Email Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:TextBox ID="tb_emailedit" runat="server"></asp:TextBox>
                                </p>
                                <p>
                                    Residential Address:&nbsp;&nbsp;
                                    <asp:TextBox ID="tb_addredit" runat="server"></asp:TextBox>
                                </p>
                                <p>
                                    Contact:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:TextBox ID="tb_contactedit" runat="server"></asp:TextBox>
                                    &nbsp;&nbsp;&nbsp;</p>
                                <p>
                                    Nickname:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:TextBox ID="tb_nicknameedit" runat="server"></asp:TextBox>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </p>
                                <p>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btn_changesettings_profile" runat="server" Text="Change Profile Settings" />
                                </p>
                                <p>
                                    &nbsp;</p>

                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="tabchangepwd" runat="server" HeaderText="Change Password" Height="680px" Width="124px">
                            <HeaderTemplate>
                                Change Password
                            </HeaderTemplate>
                        <ContentTemplate>
                            <h6>&nbsp;</h6>
                            <h6>Security Questions</h6>
            <p>Old Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_oldpwd" runat="server"></asp:TextBox>
            </p>
            <p>Sequrity Question 1:&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="dd_secque1" runat="server">
                    <asp:ListItem Value="Default Question">Select Security Question</asp:ListItem>
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
            <p>Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tb_secans1" runat="server"></asp:TextBox>
            </p>
            <p>Security Question 2:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="dd_secque2" runat="server">
                    <asp:ListItem Value="Default Question">Select Security Question</asp:ListItem>
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
            <p>Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_secans2" runat="server"></asp:TextBox>
            </p>
            <p>Security Question 3:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="dd_secque3" runat="server">
                    <asp:ListItem Value="Default Question">Select Security Question</asp:ListItem>
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
            <p>Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_secans3" runat="server" Height="22px" Width="128px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
                            <p>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btn_changepwd" runat="server" CssClass="auto-style3" Text="Change Password" />
                            </p>
                            <p>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
                        </ContentTemplate>
                        </asp:TabPanel>
                        </asp:TabContainer>
                    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </p>
                    <p>&nbsp;</p>
                    <p>&nbsp;</p>

                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="tab_billpayment" runat="server" HeaderText="Bill Payment">
                <ContentTemplate>
                    <br />
                </ContentTemplate>
            </asp:TabPanel>
        </asp:TabContainer>
    </div>
</asp:Content>
