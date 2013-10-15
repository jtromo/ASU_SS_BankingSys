<%@ Page Title="" Language="C#" MasterPageFile="~/Final.Master" AutoEventWireup="true" CodeBehind="InternalUser.aspx.cs" Inherits="SoftSec_BankingApp_Se7en.InternalUser" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register assembly="Recaptcha" namespace="Recaptcha" tagprefix="recaptcha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height:800px";>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Width="949px">
            <asp:TabPanel runat="server" HeaderText="Customer Account Access" ID="TabPanel1">
                <HeaderTemplate>
                    Existing Customer Account Access
                </HeaderTemplate>
                <ContentTemplate>

                    <br />
                    Customer Details:<br />Card Number:&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Date of Birth:&nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>MM</asp:ListItem>
                        <asp:ListItem>01</asp:ListItem>
                        <asp:ListItem>02</asp:ListItem>
                        <asp:ListItem>03</asp:ListItem>
                        <asp:ListItem>04</asp:ListItem>
                        <asp:ListItem>05</asp:ListItem>
                        <asp:ListItem>06</asp:ListItem>
                        <asp:ListItem>07</asp:ListItem>
                        <asp:ListItem>08</asp:ListItem>
                        <asp:ListItem>09</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>DD</asp:ListItem>
                        <asp:ListItem>01</asp:ListItem>
                        <asp:ListItem>02</asp:ListItem>
                        <asp:ListItem>03</asp:ListItem>
                        <asp:ListItem>04</asp:ListItem>
                        <asp:ListItem>05</asp:ListItem>
                        <asp:ListItem>06</asp:ListItem>
                        <asp:ListItem>07</asp:ListItem>
                        <asp:ListItem>08</asp:ListItem>
                        <asp:ListItem>09</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>
                        <asp:ListItem>26</asp:ListItem>
                        <asp:ListItem>27</asp:ListItem>
                        <asp:ListItem>28</asp:ListItem>
                        <asp:ListItem>29</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                        <asp:ListItem>31</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="76px">YYYY</asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    Photo Identification Verification<asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="55px">
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:TabContainer ID="TabContainer2" runat="server" ActiveTabIndex="0" Width="925px">
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
                    <asp:TabContainer ID="TabContainer3" runat="server" ActiveTabIndex="4" Height="515px" Width="850px">
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
            <p class="auto-style5"><strong>Recepient&#39;s Details:</strong></p>
              <p class="auto-style5">
                  Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:TextBox ID="tb_lastnameoutside" runat="server"></asp:TextBox>
              </p>
            <p class="auto-style9">Email ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_emailoutside" runat="server"></asp:TextBox>
              </p>
            <p class="auto-style9"><strong>Your Details (Validation):</strong></p>
              <p class="auto-style9">
                  Card Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:TextBox ID="tb_usercardno" runat="server"></asp:TextBox>
              </p>
            <p>
                &nbsp;Expiry:
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
            </p>
	

              <p>
                  Security Code:&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:TextBox ID="tb_securitycodeoutside" runat="server"></asp:TextBox>
              </p>
	

            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
                        <asp:TabPanel ID="tab_debitfunds" runat="server" HeaderText="Debit Funds">
                            <ContentTemplate>

                                <br />
                                <br />
                                <p>
                                    Card Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:TextBox ID="tb_card0" runat="server"></asp:TextBox>
                                </p>
                                <p>
                                    Expiry:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:DropDownList ID="dd_month0" runat="server">
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
                                    <asp:DropDownList ID="dd_year0" runat="server">
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
                                <p>
                                    Security Code:&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:TextBox ID="tb_securitycode0" runat="server"></asp:TextBox>
                                </p>
                                <p class="auto-style5">
                                    To:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:DropDownList ID="dd_acctypeoutside0" runat="server" CssClass="auto-style4" Width="124px">
                                        <asp:ListItem>Checking Account</asp:ListItem>
                                        <asp:ListItem>Savings Account</asp:ListItem>
                                    </asp:DropDownList>
                                </p>
                                <p class="auto-style5">
                                    Amount:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:TextBox ID="tb_amountoutside0" runat="server" Width="115px"></asp:TextBox>
                                </p>
                                <p class="auto-style5">
                                    &nbsp;
                                </p>
                                <p class="auto-style5">
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btn_maketransinside0" runat="server" Text="Debit Funds" />
                                </p>
                                <p>
                                    &nbsp;</p>

                            </ContentTemplate>
                        </asp:TabPanel>
                         <asp:TabPanel ID="TabPanel4" runat="server" HeaderText="Debit Funds">
                             <HeaderTemplate>
                                 Credit Funds
                             </HeaderTemplate>
                            <ContentTemplate>

                                <br />
                                <p>
                                    Card Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:TextBox ID="tb_card1" runat="server"></asp:TextBox>
                                </p>
                                <p>
                                    Expiry:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:DropDownList ID="dd_month1" runat="server">
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
                                    <asp:DropDownList ID="dd_year1" runat="server">
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
                                <p>
                                    Security Code:&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:TextBox ID="tb_securitycode1" runat="server"></asp:TextBox>
                                </p>
                                <p class="auto-style5">
                                    From:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="dd_acctypeoutside1" runat="server" CssClass="auto-style4" Width="124px">
                                        <asp:ListItem>Checking Account</asp:ListItem>
                                        <asp:ListItem>Savings Account</asp:ListItem>
                                    </asp:DropDownList>
                                </p>
                                <p class="auto-style5">
                                    Amount:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:TextBox ID="tb_amountoutside1" runat="server" Width="115px"></asp:TextBox>
                                </p>
                                <p class="auto-style5">
                                    &nbsp;
                                </p>
                                <p class="auto-style5">
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btn_maketransinside1" runat="server" Text="Credit Funds" />
                                </p>

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
                     <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btn_editprof" runat="server" Text="Edit Profile" />
                    </p>
                     <p>
                    </p>
                    <asp:TabContainer ID="TabContainer4" runat="server" ActiveTabIndex="1" Height="369px" Width="837px">
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
                        <asp:TabPanel ID="tab_modtrans" runat="server" HeaderText="Modify Transactions">
                <ContentTemplate>
                    <br />

                    <br />
                    Show transfers for:
                    <asp:DropDownList ID="DropDownList3" runat="server">
                        <asp:ListItem>Last 30 days and Future Scheduled Transfers</asp:ListItem>
                        <asp:ListItem>Prior 2 months</asp:ListItem>
                        <asp:ListItem>Prior 3 months</asp:ListItem>
                        <asp:ListItem>Prior 6 months</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    //display transfers in grid view<br />
                    <br />
                    <br />
                    Transaction ID:
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Date of Birth:&nbsp;
                    <asp:DropDownList ID="DropDownList4" runat="server">
                        <asp:ListItem>MM</asp:ListItem>
                        <asp:ListItem>01</asp:ListItem>
                        <asp:ListItem>02</asp:ListItem>
                        <asp:ListItem>03</asp:ListItem>
                        <asp:ListItem>04</asp:ListItem>
                        <asp:ListItem>05</asp:ListItem>
                        <asp:ListItem>06</asp:ListItem>
                        <asp:ListItem>07</asp:ListItem>
                        <asp:ListItem>08</asp:ListItem>
                        <asp:ListItem>09</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:DropDownList ID="DropDownList5" runat="server">
                        <asp:ListItem>DD</asp:ListItem>
                        <asp:ListItem>01</asp:ListItem>
                        <asp:ListItem>02</asp:ListItem>
                        <asp:ListItem>03</asp:ListItem>
                        <asp:ListItem>04</asp:ListItem>
                        <asp:ListItem>05</asp:ListItem>
                        <asp:ListItem>06</asp:ListItem>
                        <asp:ListItem>07</asp:ListItem>
                        <asp:ListItem>08</asp:ListItem>
                        <asp:ListItem>09</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>
                        <asp:ListItem>26</asp:ListItem>
                        <asp:ListItem>27</asp:ListItem>
                        <asp:ListItem>28</asp:ListItem>
                        <asp:ListItem>29</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                        <asp:ListItem>31</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="76px">YYYY</asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btn_viewtransdetails" runat="server" Text="View Details" />
                    <br />
                    <br />
                    <br />
                    Account Number: [AccNum]&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Account Number:
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    <br />
                    Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; [Type]&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    <br />
                    Status:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; [Status]&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Status:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    <br />
                    Amount:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; [Amount]&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Amount:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btn_modifytrans" runat="server" Text="Modify!" />
                    &nbsp;&nbsp;
                    <asp:Button ID="btn_deltrans" runat="server" Text="Delete" />

                    </Contenttemplate>

                    </asp:TabPanel>
           
            <asp:TabPanel ID="tab_billpayment" runat="server" HeaderText="Submit Payment">
                <ContentTemplate>
                    <br />
                    <br />
                    <asp:TabContainer ID="TabContainer5" runat="server" ActiveTabIndex="0" Height="556px" Width="835px" style="margin-right: 709px">
                        <asp:TabPanel ID="tab_cardpay" runat="server" HeaderText="Card Payment" Height="600px" Width="124px">
                            <ContentTemplate>
                                 <br />
                                Card Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="dd_cardtype" runat="server">
                                    <asp:ListItem>Select a Card Type</asp:ListItem>
                                    <asp:ListItem>Visa</asp:ListItem>
                                    <asp:ListItem>MasterCard</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Card Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_cardnum" runat="server"></asp:TextBox>
                                <br />
                                Account Holder&#39;s Name:&nbsp;&nbsp;
                                <asp:TextBox ID="tb_customername" runat="server" Width="118px"></asp:TextBox>
                                <br />
                                (as printed on the card)<br />Expiry Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="dd_cardexpm" runat="server">
                                    <asp:ListItem>MM</asp:ListItem>
                                    <asp:ListItem>01</asp:ListItem>
                                    <asp:ListItem>02</asp:ListItem>
                                    <asp:ListItem>03</asp:ListItem>
                                    <asp:ListItem>04</asp:ListItem>
                                    <asp:ListItem>05</asp:ListItem>
                                    <asp:ListItem>06</asp:ListItem>
                                    <asp:ListItem>07</asp:ListItem>
                                    <asp:ListItem>08</asp:ListItem>
                                    <asp:ListItem>09</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                    <asp:ListItem>11</asp:ListItem>
                                    <asp:ListItem>12</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;
                                <asp:DropDownList ID="dd_cardexpy" runat="server">
                                    <asp:ListItem>YY</asp:ListItem>
                                    <asp:ListItem>13</asp:ListItem>
                                    <asp:ListItem>17</asp:ListItem>
                                    <asp:ListItem>14</asp:ListItem>
                                    <asp:ListItem>18</asp:ListItem>
                                    <asp:ListItem>19</asp:ListItem>
                                    <asp:ListItem>20</asp:ListItem>
                                    <asp:ListItem>16</asp:ListItem>
                                    <asp:ListItem>15</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;<br /> Amount:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                 <asp:TextBox ID="tb_amount3" runat="server" Width="118px"></asp:TextBox>
                                 <br />
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btn_cardsubmitpayment" runat="server" Text="Submit Payment" />
                                <br />
                                &nbsp;&nbsp;&nbsp;
                           
                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="tab_echeckpay" runat="server" HeaderText="ECheck Payment" Height="600px" Width="124px">
                            <ContentTemplate>
                                <br />
                                Account Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="tb_echeckaccno" runat="server"></asp:TextBox>
                                <br />
                                Routing Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="tb_echeckroutingno" runat="server"></asp:TextBox>
                                <br />
                                Account Holder&#39;s Name:&nbsp;&nbsp;<asp:TextBox ID="tb_echeckcustomername" runat="server" Width="118px"></asp:TextBox>
                                <br />
                                Amount:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_amount4" runat="server" Width="118px"></asp:TextBox>
                                <br />
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btn_echecksubmitpayment" runat="server" Text="Submit Payment" />
                                </ContentTemplate>
                        </asp:TabPanel>
                    </asp:TabContainer>
                </ContentTemplate>
            </asp:TabPanel>

                    </asp:TabContainer>
                    <br />

                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="tab_newcustomer" runat="server" HeaderText="New Customer">
                <ContentTemplate>
                    <br />
                                       <asp:TabContainer ID="TabContainer6" runat="server" ActiveTabIndex="0" Width="918px">
                        <asp:TabPanel ID="tab_employee" runat="server" HeaderText="Employee">

                            <ContentTemplate>
                                <br />
                                First Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                                <br />
                                Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                                <br />
                                Email ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                                <br />
                                Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                                <br />
                                Contact:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                                <br />
                                Zip Code:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                Account Types:&nbsp;&nbsp;
                                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                                    <asp:ListItem>Checking Account</asp:ListItem>
                                    <asp:ListItem>Savings Account</asp:ListItem>
                                    <asp:ListItem>Credit Account</asp:ListItem>
                                </asp:CheckBoxList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btn_createcust" runat="server" Text="Create" />
                                <br />
                                <br />
                            </ContentTemplate>

                        </asp:TabPanel>
                        <asp:TabPanel ID="tab_customer" runat="server" HeaderText="Customer">
                            <ContentTemplate>
                                <br />
                                Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                                <br />
                                Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                                <br />
                                Repeat Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                                <br />
                                Security Question 1:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList9" runat="server">
                                </asp:DropDownList>
                                <br />
                                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                                <br />
                                Security Question 2:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList10" runat="server">
                                </asp:DropDownList>
                                <br />
                                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
                                <br />
                                Security Question 3:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList11" runat="server">
                                </asp:DropDownList>
                                <br />
                                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
                                <br />
                                Social Security Number:&nbsp;
                                <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                SiteKey:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                
                                <asp:ImageButton ID="img_site1" runat="server" OnClick="img_site1_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site2" runat="server" OnClick="img_site2_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site3" runat="server" OnClick="img_site3_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site4" runat="server" OnClick="img_site4_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site5" runat="server" OnClick="img_site5_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site6" runat="server" OnClick="img_site6_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site7" runat="server" OnClick="img_site7_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site8" runat="server" OnClick="img_site8_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site9" runat="server" OnClick="img_site9_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site10" runat="server" OnClick="img_site10_Click" />&nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:ImageButton ID="img_site11" runat="server" OnClick="img_site11_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site12" runat="server" OnClick="img_site12_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site13" runat="server" OnClick="img_site13_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site14" runat="server" OnClick="img_site14_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site15" runat="server" OnClick="img_site15_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site16" runat="server" OnClick="img_site16_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site17" runat="server" OnClick="img_site17_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site18" runat="server" OnClick="img_site18_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site19" runat="server" OnClick="img_site19_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site20" runat="server" OnClick="img_site20_Click" />&nbsp;<br /> Sitekey Hint:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_sitekeyhint" runat="server"></asp:TextBox>
                                <br />
                                Date of Birth:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList6" runat="server">
                                    <asp:ListItem>MM</asp:ListItem>
                                    <asp:ListItem>01</asp:ListItem>
                                    <asp:ListItem>02</asp:ListItem>
                                    <asp:ListItem>03</asp:ListItem>
                                    <asp:ListItem>04</asp:ListItem>
                                    <asp:ListItem>05</asp:ListItem>
                                    <asp:ListItem>06</asp:ListItem>
                                    <asp:ListItem>07</asp:ListItem>
                                    <asp:ListItem>08</asp:ListItem>
                                    <asp:ListItem>09</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                    <asp:ListItem>11</asp:ListItem>
                                    <asp:ListItem>12</asp:ListItem>
                                </asp:DropDownList>
                                <asp:DropDownList ID="DropDownList7" runat="server">
                                    <asp:ListItem>DD</asp:ListItem>
                                    <asp:ListItem>01</asp:ListItem>
                                    <asp:ListItem>02</asp:ListItem>
                                    <asp:ListItem>03</asp:ListItem>
                                    <asp:ListItem>04</asp:ListItem>
                                    <asp:ListItem>05</asp:ListItem>
                                    <asp:ListItem>06</asp:ListItem>
                                    <asp:ListItem>07</asp:ListItem>
                                    <asp:ListItem>08</asp:ListItem>
                                    <asp:ListItem>09</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                    <asp:ListItem>11</asp:ListItem>
                                    <asp:ListItem>12</asp:ListItem>
                                    <asp:ListItem>13</asp:ListItem>
                                    <asp:ListItem>14</asp:ListItem>
                                    <asp:ListItem>15</asp:ListItem>
                                    <asp:ListItem>16</asp:ListItem>
                                    <asp:ListItem>17</asp:ListItem>
                                    <asp:ListItem>18</asp:ListItem>
                                    <asp:ListItem>19</asp:ListItem>
                                    <asp:ListItem>20</asp:ListItem>
                                    <asp:ListItem>21</asp:ListItem>
                                    <asp:ListItem>22</asp:ListItem>
                                    <asp:ListItem>23</asp:ListItem>
                                    <asp:ListItem>24</asp:ListItem>
                                    <asp:ListItem>25</asp:ListItem>
                                    <asp:ListItem>26</asp:ListItem>
                                    <asp:ListItem>27</asp:ListItem>
                                    <asp:ListItem>28</asp:ListItem>
                                    <asp:ListItem>29</asp:ListItem>
                                    <asp:ListItem>30</asp:ListItem>
                                    <asp:ListItem>31</asp:ListItem>
                                </asp:DropDownList>
                                <asp:TextBox ID="TextBox16" runat="server" Height="16px" Width="76px">YYYY</asp:TextBox>
                                <br />
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btn_sumbitcust" runat="server" Text="Submit" />
                            </ContentTemplate>
                        </asp:TabPanel>
                    </asp:TabContainer>
                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="tab_dept" runat="server" HeaderText="Department">
                <ContentTemplate>
                    <br />
                    <asp:TabContainer ID="TabContainer7" runat="server" ActiveTabIndex="0" Width="917px">
                        <asp:TabPanel ID="tab_addemp" runat="server" HeaderText="Add Employee">
                            <ContentTemplate>

                                <br />
                                Employee Details:
                                <br />
                                First Name:&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox25" runat="server"></asp:TextBox>
                                <br />
                                Middle Name:&nbsp;
                                <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox>
                                <br />
                                Last Name:&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox>
                                <br />
                                Department:&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList12" runat="server">
                                </asp:DropDownList>
                                <br />
                                Role:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList13" runat="server">
                                </asp:DropDownList>
                                <br />
                                Email ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox28" runat="server"></asp:TextBox>
                                <br />
                                Contact:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox29" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button1" runat="server" Text="Add" />
                                <br />

                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="tab_delemp" runat="server" HeaderText="Delete Employee">
                            <ContentTemplate>

                                <br />
                                Employee ID:&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox35" runat="server"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button7" runat="server" Text="View Details" />
                                <br />
                                <br />
                                Employee Details:
                                <br />
                                First Name:&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox30" runat="server"></asp:TextBox>
                                <br />
                                Middle Name:&nbsp;
                                <asp:TextBox ID="TextBox31" runat="server"></asp:TextBox>
                                <br />
                                Last Name:&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:TextBox ID="TextBox32" runat="server"></asp:TextBox>
                                <br />
                                Department:&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList14" runat="server">
                                </asp:DropDownList>
                                <br />
                                Role:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList15" runat="server">
                                </asp:DropDownList>
                                <br />
                                Email ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox33" runat="server"></asp:TextBox>
                                <br />
                                Contact:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox34" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button2" runat="server" Text="Delete" />

                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="tab_transemp" runat="server" HeaderText="Transfer Employee">
                            <ContentTemplate>

                                <br />
                                Employee ID:&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox36" runat="server"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button5" runat="server" Text="View Details" />
                                <br />
                                <br />
                                Employee Details:
                                <br />
                                First Name:&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox37" runat="server"></asp:TextBox>
                                <br />
                                Middle Name:&nbsp;
                                <asp:TextBox ID="TextBox38" runat="server"></asp:TextBox>
                                <br />
                                Last Name:&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:TextBox ID="TextBox39" runat="server"></asp:TextBox>
                                <br />
                                Department:&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList16" runat="server">
                                </asp:DropDownList>
                                <br />
                                Role:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList17" runat="server">
                                </asp:DropDownList>
                                <br />
                                Email ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox40" runat="server"></asp:TextBox>
                                <br />
                                Contact:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox41" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                Transfer To Details:<br />Department:&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList18" runat="server">
                                </asp:DropDownList>
                                <br />
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button3" runat="server" Text="Transfer" />

                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="tab_viewemp" runat="server" HeaderText="View Employee Details">
                            <ContentTemplate>

                                <br />
                                Employee ID:&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox42" runat="server"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button6" runat="server" Text="View Details" />
                                <br />
                                <br />
                                Employee Details:
                                <br />
                                First Name:&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox43" runat="server"></asp:TextBox>
                                <br />
                                Middle Name:&nbsp;
                                <asp:TextBox ID="TextBox44" runat="server"></asp:TextBox>
                                <br />
                                Last Name:&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:TextBox ID="TextBox45" runat="server"></asp:TextBox>
                                <br />
                                Department:&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList19" runat="server">
                                </asp:DropDownList>
                                <br />
                                Role:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList20" runat="server">
                                </asp:DropDownList>
                                <br />
                                Email ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox46" runat="server"></asp:TextBox>
                                <br />
                                Contact:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox47" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                Transfer To Details:<br />Department:&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList21" runat="server">
                                </asp:DropDownList>
                                <br />
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button4" runat="server" Text="Transfer" />

                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="tab_viewdepttrans" runat="server" HeaderText="View Department Transaction">
                            <ContentTemplate>

                                <br />
                                Show transfers for:
                                <asp:DropDownList ID="DropDownList26" runat="server">
                                    <asp:ListItem>Last 30 days and Future Scheduled Transfers</asp:ListItem>
                                    <asp:ListItem>Prior 2 months</asp:ListItem>
                                    <asp:ListItem>Prior 3 months</asp:ListItem>
                                    <asp:ListItem>Prior 6 months</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                <br />
                                //display transfers in grid view<br />
                                <br />
                                <br />
                                Transaction ID:
                                <asp:TextBox ID="TextBox50" runat="server"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Date of Birth:&nbsp;
                                <asp:DropDownList ID="DropDownList27" runat="server">
                                    <asp:ListItem>MM</asp:ListItem>
                                    <asp:ListItem>01</asp:ListItem>
                                    <asp:ListItem>02</asp:ListItem>
                                    <asp:ListItem>03</asp:ListItem>
                                    <asp:ListItem>04</asp:ListItem>
                                    <asp:ListItem>05</asp:ListItem>
                                    <asp:ListItem>06</asp:ListItem>
                                    <asp:ListItem>07</asp:ListItem>
                                    <asp:ListItem>08</asp:ListItem>
                                    <asp:ListItem>09</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                    <asp:ListItem>11</asp:ListItem>
                                    <asp:ListItem>12</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;<asp:DropDownList ID="DropDownList28" runat="server">
                                    <asp:ListItem>DD</asp:ListItem>
                                    <asp:ListItem>01</asp:ListItem>
                                    <asp:ListItem>02</asp:ListItem>
                                    <asp:ListItem>03</asp:ListItem>
                                    <asp:ListItem>04</asp:ListItem>
                                    <asp:ListItem>05</asp:ListItem>
                                    <asp:ListItem>06</asp:ListItem>
                                    <asp:ListItem>07</asp:ListItem>
                                    <asp:ListItem>08</asp:ListItem>
                                    <asp:ListItem>09</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                    <asp:ListItem>11</asp:ListItem>
                                    <asp:ListItem>12</asp:ListItem>
                                    <asp:ListItem>13</asp:ListItem>
                                    <asp:ListItem>14</asp:ListItem>
                                    <asp:ListItem>15</asp:ListItem>
                                    <asp:ListItem>16</asp:ListItem>
                                    <asp:ListItem>17</asp:ListItem>
                                    <asp:ListItem>18</asp:ListItem>
                                    <asp:ListItem>19</asp:ListItem>
                                    <asp:ListItem>20</asp:ListItem>
                                    <asp:ListItem>21</asp:ListItem>
                                    <asp:ListItem>22</asp:ListItem>
                                    <asp:ListItem>23</asp:ListItem>
                                    <asp:ListItem>24</asp:ListItem>
                                    <asp:ListItem>25</asp:ListItem>
                                    <asp:ListItem>26</asp:ListItem>
                                    <asp:ListItem>27</asp:ListItem>
                                    <asp:ListItem>28</asp:ListItem>
                                    <asp:ListItem>29</asp:ListItem>
                                    <asp:ListItem>30</asp:ListItem>
                                    <asp:ListItem>31</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;<asp:TextBox ID="TextBox51" runat="server" Height="16px" Width="76px">YYYY</asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btn_viewtransdetails1" runat="server" Text="View Details" />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                &nbsp;

                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="tab_viewalldepttrans" runat="server" HeaderText="View All Department Transactions">
                            <ContentTemplate>

                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="btn_viewtransdetails2" runat="server" Text="View All Details" />
                                <br />

                            </ContentTemplate>
                        </asp:TabPanel>
                    </asp:TabContainer>
                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="tab_tobeauthorized" runat="server" HeaderText="To Be Authorized">
                <ContentTemplate>
                    <br />
                    //add to be authorized critical transactions
                </ContentTemplate>
            </asp:TabPanel>
        </asp:TabContainer>
    </div>
</asp:Content>
