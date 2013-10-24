<%@ Page Title="" Language="C#" MasterPageFile="~/Final.Master" AutoEventWireup="true" CodeBehind="ExternalUser.aspx.cs" Inherits="SoftSec_BankingApp_Se7en.ExternalUser" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/PasswordStyle.css" rel="stylesheet" type="text/css" />
        <div style="height:800px";>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

        <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Height="711px" Width="1074px" OnActiveTabChanged="TabContainer1_ActiveTabChanged" TabIndex="0" AutoPostBack="True" Visible="False">
            <asp:TabPanel runat="server" HeaderText="Accounts" ID="tab_accounts" TabIndex="1">
                <ContentTemplate>
                    Checking Account:
                    <asp:TextBox ID="tb_checking" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:Button ID="btn_checking" runat="server"  Text="View Summary" OnClick="btn_checking_Click" />
                    <br />
                    Savings Account:&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_savings" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:Button ID="btn_savings" runat="server"  Text="View Summary" OnClick="btn_savings_Click" />
                    <br />
                    Credit Account:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_credit" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:Button ID="btn_credit" runat="server"  Text="View Summary" />
                    <br />
                    <br />
                    <br /> <br>
                    <asp:GridView ID="grdTransactions" runat="server" BorderStyle="Solid" EmptyDataText="No Transactions available" Font-Italic="True" HorizontalAlign="Justify">
                        <AlternatingRowStyle BorderStyle="Solid" />
                    </asp:GridView>
                    <br>
                    <br>
                    <br>
                    <br></br>
                    <br></br>
                    <br>
                    <br>
                    <br>
                    <br>
                    <br></br>
                    <br></br>
                    <br>
                    <br>
                    <br></br>
                    <br></br>
                    <br>
                    <br>
                    <br></br>
                    <br></br>
                    <br>
                    <br></br>
                    <br></br>
                    <br>
                    <br></br>
                    <br></br>
                    <br>
                    <br></br>
                    <br></br>
                    <br>
                    <br></br>
                    <br></br>
                    <br></br>
                    <br></br>
                    <br></br>
                    <br></br>
                    <br></br>
                    <br></br>
                    <br></br>
                    <br></br>
                    <br></br>
                    <br></br>
                    <br></br>
                    <br></br>
                    <br></br>
                    <br></br>
                    <br></br>
                    <br></br>
                    </br>
                    </br>
                    </br>
                    </br>
                    </br>
                    </br>
                    </br>
                    </br>
                    </br>
                    </br>
                    </br>
                    </br>
                    </br>
                    </br>
                    </br>
                    </br>
                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel runat="server" HeaderText="Transfers" ID="tab_transfers" TabIndex="2">
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
                <asp:TextBox ID="tb_amount" runat="server" Width="115px" oncopy="return false" onpaste="return false"></asp:TextBox>
            </p>
            <p><strong>Recepient&#39;s Details:</strong></p>
            <p>&nbsp;Account Number:&nbsp;&nbsp;
                <asp:TextBox ID="tb_recepient" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
            </p>
            
             <p>Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tb_lastname" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
            </p>
            <p>Zip Code:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_zip" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
            </p>
            <p><strong>Your Details (Validation):</strong></p>
            <p>Card Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tb_card" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
            </p>
            <p>Expiry:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="dd_month" runat="server">
                    <asp:ListItem Value="00">MM</asp:ListItem>
                    <asp:ListItem Value="01">Jan</asp:ListItem>
                    <asp:ListItem Value="02">Feb</asp:ListItem>
                    <asp:ListItem Value="03">Mar</asp:ListItem>
                    <asp:ListItem Value="04">Apr</asp:ListItem>
                    <asp:ListItem Value="05">May</asp:ListItem>
                    <asp:ListItem Value="06">June</asp:ListItem>
                    <asp:ListItem Value="07">Jul</asp:ListItem>
                    <asp:ListItem Value="08">Aug</asp:ListItem>
                    <asp:ListItem Value="09">Sep</asp:ListItem>
                    <asp:ListItem Value="10">Oct</asp:ListItem>
                    <asp:ListItem Value="11">Nov</asp:ListItem>
                    <asp:ListItem Value="12">Dec</asp:ListItem>
                </asp:DropDownList>
&nbsp;
                <asp:DropDownList ID="dd_year" runat="server">
                    <asp:ListItem Value="0000">YYYY</asp:ListItem>
                    <asp:ListItem Value="13">2013</asp:ListItem>
                    <asp:ListItem Value="14">2014</asp:ListItem>
                    <asp:ListItem Value="15">2015</asp:ListItem>
                    <asp:ListItem Value="16">2016</asp:ListItem>
                    <asp:ListItem Value="17">2017</asp:ListItem>
                    <asp:ListItem Value="18">2018</asp:ListItem>
                    <asp:ListItem Value="19">2019</asp:ListItem>
                    <asp:ListItem Value="20">2020</asp:ListItem>
                    <asp:ListItem Value="21">2021</asp:ListItem>
                    <asp:ListItem Value="22">2022</asp:ListItem>
                    <asp:ListItem Value="23">2023</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>Security Code:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_securitycode" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
            </p>
                                <p>
                                    <asp:Label ID="lblTransStatus_IB" runat="server" Visible="False"></asp:Label>
                                </p>
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_maketransinside" runat="server" Text="Make Transfer" OnClick="btn_maketransinside_Click" />
            </p>
            <p>
                &nbsp;</p>
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
                <asp:TextBox ID="tb_amountoutside" runat="server" Width="115px" oncopy="return false" onpaste="return false"></asp:TextBox>
              </p>
            <p class="auto-style5"><strong>Recepient&#39;s Details:</strong></p>
              <p class="auto-style5">
                  Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:TextBox ID="tb_lastnameoutside" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
              </p>
            <p class="auto-style9">
                Account Number :
                <asp:TextBox ID="tb_toAccNum_OutsideBank" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
              </p>
              <p class="auto-style9">
                  Routing Number :
                  <asp:TextBox ID="tb_toRoutingNumber" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
              </p>
            <p class="auto-style9">Email ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_emailoutside" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
              </p>
            <p class="auto-style9"><strong>Your Details (Validation):</strong></p>
              <p class="auto-style9">
                  Card Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:TextBox ID="tb_usercardno" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
              </p>
            <p>
                &nbsp;</p>
            <p>
                Expiry:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="dd_monthoutside" runat="server">
                    <asp:ListItem Value="00">MM</asp:ListItem>
                    <asp:ListItem Value="01">Jan</asp:ListItem>
                    <asp:ListItem Value="02">Feb</asp:ListItem>
                    <asp:ListItem Value="03">Mar</asp:ListItem>
                    <asp:ListItem Value="04">Apr</asp:ListItem>
                    <asp:ListItem Value="05">May</asp:ListItem>
                    <asp:ListItem Value="06">June</asp:ListItem>
                    <asp:ListItem Value="07">Jul</asp:ListItem>
                    <asp:ListItem Value="08">Aug</asp:ListItem>
                    <asp:ListItem Value="09">Sep</asp:ListItem>
                    <asp:ListItem Value="10">Oct</asp:ListItem>
                    <asp:ListItem Value="11">Nov</asp:ListItem>
                    <asp:ListItem Value="12">Dec</asp:ListItem>
                </asp:DropDownList>
                &nbsp;
                <asp:DropDownList ID="dd_yearoutside" runat="server">
                    <asp:ListItem Value="0000">YYYY</asp:ListItem>
                    <asp:ListItem Value="13">2013</asp:ListItem>
                    <asp:ListItem Value="14">2014</asp:ListItem>
                    <asp:ListItem Value="15">2015</asp:ListItem>
                    <asp:ListItem Value="16">2016</asp:ListItem>
                    <asp:ListItem Value="17">2017</asp:ListItem>
                    <asp:ListItem Value="18">2018</asp:ListItem>
                    <asp:ListItem Value="19">2019</asp:ListItem>
                    <asp:ListItem Value="20">2020</asp:ListItem>
                    <asp:ListItem Value="21">2021</asp:ListItem>
                    <asp:ListItem Value="22">2022</asp:ListItem>
                    <asp:ListItem Value="23">2023</asp:ListItem>
                </asp:DropDownList>
            </p>
	

              <p>
                  Security Code:&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:TextBox ID="tb_securitycodeoutside" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
              </p>
	

            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblTranStatus" runat="server" Visible="False"></asp:Label>
            </p>
              <p>
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Button ID="btn_maketransferoutside" runat="server" Text="Make Transfer" OnClick="btn_maketransferoutside_Click" />
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
            <asp:DropDownList ID="dd_acctypebetween_From" runat="server" CssClass="auto-style4" Width="124px" OnSelectedIndexChanged="dd_acctypebetween1_SelectedIndexChanged">
            <asp:ListItem>Checking Account</asp:ListItem>
            <asp:ListItem>Savings Account</asp:ListItem>
            </asp:DropDownList>
                                 </p>
            <p class="auto-style5">To:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="dd_acctypebetween_To" runat="server" CssClass="auto-style4" Width="124px">
                    <asp:ListItem>Checking Account</asp:ListItem>
                    <asp:ListItem>Savings Account</asp:ListItem>
                    <asp:ListItem>Credit Account</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p class="auto-style5">Amount:&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_amountbetween" runat="server" Width="115px" oncopy="return false" onpaste="return false"></asp:TextBox>
            </p>
	

             <p class="auto-style5">
                 <asp:Label ID="lblTransStatus_Between" runat="server" Visible="False"></asp:Label>
            </p>
	

             <p class="auto-style5">
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="btn_maketransbetween" runat="server" Text="Make Transfer" OnClick="btn_maketransbetween_Click" />
            </p>
	

             <p>
                 &nbsp;</p>

                            </ContentTemplate>
                            </asp:TabPanel>
                    </asp:TabContainer>
                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="tab_profile" runat="server" HeaderText="Profile" TabIndex="3">
                <ContentTemplate>

                    <br />
                    <h6>Contact Information&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Account Settings</h6>
  
                     <p>Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;
                         <asp:TextBox ID="tb_emailview" runat="server" Enabled="False" oncopy="return false" onpaste="return false"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password (last updated):
                         <asp:TextBox ID="tb_pwdlastview" runat="server" Enabled="False" oncopy="return false" onpaste="return false"></asp:TextBox>
                    </p>
                     <p>Street Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;
                         <asp:TextBox ID="tb_streetAddress" runat="server" Enabled="False" oncopy="return false" onpaste="return false"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:TextBox ID="tb_usernameview" runat="server" Enabled="False" oncopy="return false" onpaste="return false" ></asp:TextBox>
                    </p>
                     <p>
                         City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;
                         <asp:TextBox ID="tb_city" runat="server" Enabled="False" oncopy="return false" onpaste="return false"></asp:TextBox>
                         &nbsp;</p>
                     <p>
                         State&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;
                         <asp:DropDownList ID="StateDD_Profile" runat="server" Enabled="False">
                             <asp:ListItem Value="AL">Alabama</asp:ListItem>
                             <asp:ListItem Value="AK">Alaska</asp:ListItem>
                             <asp:ListItem Value="AZ">Arizona</asp:ListItem>
                             <asp:ListItem Value="AR">Arkansas</asp:ListItem>
                             <asp:ListItem Value="CA">California</asp:ListItem>
                             <asp:ListItem Value="CO">Colorado</asp:ListItem>
                             <asp:ListItem Value="CT">Connecticut</asp:ListItem>
                             <asp:ListItem Value="DC">District of Columbia</asp:ListItem>
                             <asp:ListItem Value="DE">Delaware</asp:ListItem>
                             <asp:ListItem Value="FL">Florida</asp:ListItem>
                             <asp:ListItem Value="GA">Georgia</asp:ListItem>
                             <asp:ListItem Value="HI">Hawaii</asp:ListItem>
                             <asp:ListItem Value="ID">Idaho</asp:ListItem>
                             <asp:ListItem Value="IL">Illinois</asp:ListItem>
                             <asp:ListItem Value="IN">Indiana</asp:ListItem>
                             <asp:ListItem Value="IA">Iowa</asp:ListItem>
                             <asp:ListItem Value="KS">Kansas</asp:ListItem>
                             <asp:ListItem Value="KY">Kentucky</asp:ListItem>
                             <asp:ListItem Value="LA">Louisiana</asp:ListItem>
                             <asp:ListItem Value="ME">Maine</asp:ListItem>
                             <asp:ListItem Value="MD">Maryland</asp:ListItem>
                             <asp:ListItem Value="MA">Massachusetts</asp:ListItem>
                             <asp:ListItem Value="MI">Michigan</asp:ListItem>
                             <asp:ListItem Value="MN">Minnesota</asp:ListItem>
                             <asp:ListItem Value="MS">Mississippi</asp:ListItem>
                             <asp:ListItem Value="MO">Missouri</asp:ListItem>
                             <asp:ListItem Value="MT">Montana</asp:ListItem>
                             <asp:ListItem Value="NE">Nebraska</asp:ListItem>
                             <asp:ListItem Value="NV">Nevada</asp:ListItem>
                             <asp:ListItem Value="NH">New Hampshire</asp:ListItem>
                             <asp:ListItem Value="NJ">New Jersey</asp:ListItem>
                             <asp:ListItem Value="NM">New Mexico</asp:ListItem>
                             <asp:ListItem Value="NY">New York</asp:ListItem>
                             <asp:ListItem Value="NC">North Carolina</asp:ListItem>
                             <asp:ListItem Value="ND">North Dakota</asp:ListItem>
                             <asp:ListItem Value="OH">Ohio</asp:ListItem>
                             <asp:ListItem Value="OK">Oklahoma</asp:ListItem>
                             <asp:ListItem Value="OR">Oregon</asp:ListItem>
                             <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>
                             <asp:ListItem Value="RI">Rhode Island</asp:ListItem>
                             <asp:ListItem Value="SC">South Carolina</asp:ListItem>
                             <asp:ListItem Value="SD">South Dakota</asp:ListItem>
                             <asp:ListItem Value="TN">Tennessee</asp:ListItem>
                             <asp:ListItem Value="TX">Texas</asp:ListItem>
                             <asp:ListItem Value="UT">Utah</asp:ListItem>
                             <asp:ListItem Value="VT">Vermont</asp:ListItem>
                             <asp:ListItem Value="VA">Virginia</asp:ListItem>
                             <asp:ListItem Value="WA">Washington</asp:ListItem>
                             <asp:ListItem Value="WV">West Virginia</asp:ListItem>
                             <asp:ListItem Value="WI">Wisconsin</asp:ListItem>
                             <asp:ListItem Value="WY">Wyoming</asp:ListItem>
                         </asp:DropDownList>
                    </p>
                    <p>
                        ZipCode&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;
                        <asp:TextBox ID="tb_ZipCode_Profile" runat="server" Enabled="False" oncopy="return false" onpaste="return false"></asp:TextBox>
                    </p>
                     <p>Contact:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;
                         <asp:TextBox ID="tb_contactview" runat="server" Enabled="False" oncopy="return false" onpaste="return false"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nickname:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:TextBox ID="tb_nicknameview" runat="server" Enabled="False" oncopy="return false" onpaste="return false"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </p>
                     <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnEditProfile" runat="server" Text="Edit Profile" OnClick="btnEditProfile_Click" />
                    </p>
                     <p>
                    </p>
                    <asp:TabContainer ID="TabContainer3" runat="server" ActiveTabIndex="0" Height="362px" Width="837px" Visible="False" OnActiveTabChanged="TabContainer3_ActiveTabChanged" AutoPostBack="True">
                        <asp:TabPanel ID="tabeditprofile" runat="server" HeaderText="Edit Profile" Height="600px" Width="124px">
                            <ContentTemplate>

                                <br />
                                <h6>Contact Information</h6>
                                <p>
                                    Email Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
                                    <asp:TextBox ID="tb_emailedit" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                </p>
                                <p>
                                    Street Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
                                    <asp:TextBox ID="tb_addr_editprofile" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                    &nbsp;&nbsp; City&nbsp; :
                                    <asp:TextBox ID="tb_city_editProfile" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                    &nbsp;
                                </p>
                                <p>
                                    &nbsp;State&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:DropDownList ID="StateDD_EditProfile" runat="server">
                                        <asp:ListItem Value="AL">Alabama</asp:ListItem>
                                        <asp:ListItem Value="AK">Alaska</asp:ListItem>
                                        <asp:ListItem Value="AZ">Arizona</asp:ListItem>
                                        <asp:ListItem Value="AR">Arkansas</asp:ListItem>
                                        <asp:ListItem Value="CA">California</asp:ListItem>
                                        <asp:ListItem Value="CO">Colorado</asp:ListItem>
                                        <asp:ListItem Value="CT">Connecticut</asp:ListItem>
                                        <asp:ListItem Value="DC">District of Columbia</asp:ListItem>
                                        <asp:ListItem Value="DE">Delaware</asp:ListItem>
                                        <asp:ListItem Value="FL">Florida</asp:ListItem>
                                        <asp:ListItem Value="GA">Georgia</asp:ListItem>
                                        <asp:ListItem Value="HI">Hawaii</asp:ListItem>
                                        <asp:ListItem Value="ID">Idaho</asp:ListItem>
                                        <asp:ListItem Value="IL">Illinois</asp:ListItem>
                                        <asp:ListItem Value="IN">Indiana</asp:ListItem>
                                        <asp:ListItem Value="IA">Iowa</asp:ListItem>
                                        <asp:ListItem Value="KS">Kansas</asp:ListItem>
                                        <asp:ListItem Value="KY">Kentucky</asp:ListItem>
                                        <asp:ListItem Value="LA">Louisiana</asp:ListItem>
                                        <asp:ListItem Value="ME">Maine</asp:ListItem>
                                        <asp:ListItem Value="MD">Maryland</asp:ListItem>
                                        <asp:ListItem Value="MA">Massachusetts</asp:ListItem>
                                        <asp:ListItem Value="MI">Michigan</asp:ListItem>
                                        <asp:ListItem Value="MN">Minnesota</asp:ListItem>
                                        <asp:ListItem Value="MS">Mississippi</asp:ListItem>
                                        <asp:ListItem Value="MO">Missouri</asp:ListItem>
                                        <asp:ListItem Value="MT">Montana</asp:ListItem>
                                        <asp:ListItem Value="NE">Nebraska</asp:ListItem>
                                        <asp:ListItem Value="NV">Nevada</asp:ListItem>
                                        <asp:ListItem Value="NH">New Hampshire</asp:ListItem>
                                        <asp:ListItem Value="NJ">New Jersey</asp:ListItem>
                                        <asp:ListItem Value="NM">New Mexico</asp:ListItem>
                                        <asp:ListItem Value="NY">New York</asp:ListItem>
                                        <asp:ListItem Value="NC">North Carolina</asp:ListItem>
                                        <asp:ListItem Value="ND">North Dakota</asp:ListItem>
                                        <asp:ListItem Value="OH">Ohio</asp:ListItem>
                                        <asp:ListItem Value="OK">Oklahoma</asp:ListItem>
                                        <asp:ListItem Value="OR">Oregon</asp:ListItem>
                                        <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>
                                        <asp:ListItem Value="RI">Rhode Island</asp:ListItem>
                                        <asp:ListItem Value="SC">South Carolina</asp:ListItem>
                                        <asp:ListItem Value="SD">South Dakota</asp:ListItem>
                                        <asp:ListItem Value="TN">Tennessee</asp:ListItem>
                                        <asp:ListItem Value="TX">Texas</asp:ListItem>
                                        <asp:ListItem Value="UT">Utah</asp:ListItem>
                                        <asp:ListItem Value="VT">Vermont</asp:ListItem>
                                        <asp:ListItem Value="VA">Virginia</asp:ListItem>
                                        <asp:ListItem Value="WA">Washington</asp:ListItem>
                                        <asp:ListItem Value="WV">West Virginia</asp:ListItem>
                                        <asp:ListItem Value="WI">Wisconsin</asp:ListItem>
                                        <asp:ListItem Value="WY">Wyoming</asp:ListItem>
                                    </asp:DropDownList>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Zip&nbsp; :
                                    <asp:TextBox ID="tb_zip_editProfile" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                </p>
                                <p>
                                    Contact&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;
                                    <asp:TextBox ID="tb_contactedit" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                    &nbsp;&nbsp;&nbsp;</p>
                                <p>
                                    Nickname&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;
                                    <asp:TextBox ID="tb_nicknameedit" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </p>
                                <p>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblChaneProfile" runat="server" Visible="False"></asp:Label>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </p>
                                <p>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btn_changesettings_profile" runat="server" OnClick="btn_changesettings_profile_Click" Text="Change Profile Settings" />
                                </p>
                                <p>
                                    &nbsp;</p>

                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="tabchangepwd" runat="server" HeaderText="Change Password" Height="680px" Width="124px" TabIndex="1">
                            <HeaderTemplate>
                                Change Password
                            </HeaderTemplate>
                        <ContentTemplate>
                            <h6>&nbsp;</h6>
                            <h6>Security Questions</h6>
            <p>Old Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_oldpwd" runat="server" TextMode="Password" oncopy="return false" onpaste="return false"></asp:TextBox>
                <asp:PasswordStrength ID="tb_oldpwd_PasswordStrength" runat="server" CalculationWeightings="50;15;15;20" MinimumLowerCaseCharacters="1" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="1" PreferredPasswordLength="12" RequiresUpperAndLowerCaseCharacters="True" TargetControlID="tb_oldpwd" TextStrengthDescriptions="Very Weak;Weak;Average;Strong;Very Strong" TextStrengthDescriptionStyles="TextIndicator_TB_Password_Strength1;TextIndicator_TB_Password_Strength2;TextIndicator_TB_Password_Strength3;TextIndicator_TB_Password_Strength4;TextIndicator_TB_Password_Strength5" Enabled="True" StrengthStyles="TextIndicator_TB_Password_Strength1;TextIndicator_TB_Password_Strength2;TextIndicator_TB_Password_Strength3;TextIndicator_TB_Password_Strength4;TextIndicator_TB_Password_Strength5">
                </asp:PasswordStrength>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
                            <p>
                                New Password :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_newPass" runat="server" Height="16px" TextMode="Password" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <asp:PasswordStrength ID="tb_newPass_PasswordStrength" runat="server" MinimumLowerCaseCharacters="1" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="1" PreferredPasswordLength="12" RequiresUpperAndLowerCaseCharacters="True" TargetControlID="tb_newPass" TextStrengthDescriptions="Very Weak;Weak;Average;Strong;Very Strong" TextStrengthDescriptionStyles="TextIndicator_TB_Password_Strength1;TextIndicator_TB_Password_Strength2;TextIndicator_TB_Password_Strength3;TextIndicator_TB_Password_Strength4;TextIndicator_TB_Password_Strength5" Enabled="True" StrengthStyles="TextIndicator_TB_Password_Strength1;TextIndicator_TB_Password_Strength2;TextIndicator_TB_Password_Strength3;TextIndicator_TB_Password_Strength4;TextIndicator_TB_Password_Strength5">
                                </asp:PasswordStrength>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Confirm Password :
                                <asp:TextBox ID="tb_confrimPass" runat="server" TextMode="Password" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <asp:PasswordStrength ID="tb_confrimPass_PasswordStrength" runat="server" MinimumLowerCaseCharacters="1" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="1" PreferredPasswordLength="12" TargetControlID="tb_confrimPass" TextStrengthDescriptions="Very Weak;Weak;Average;Strong;Very Strong" TextStrengthDescriptionStyles="TextIndicator_TB_Password_Strength1;TextIndicator_TB_Password_Strength2;TextIndicator_TB_Password_Strength3;TextIndicator_TB_Password_Strength4;TextIndicator_TB_Password_Strength5" Enabled="True" StrengthStyles="TextIndicator_TB_Password_Strength1;TextIndicator_TB_Password_Strength2;TextIndicator_TB_Password_Strength3;TextIndicator_TB_Password_Strength4;TextIndicator_TB_Password_Strength5">
                                </asp:PasswordStrength>
                            </p>
            <p>Sequrity Question 1:&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="dd_secque1" runat="server" Enabled="False" EnableTheming="True">
                    <asp:ListItem Value="Default Question">Select Security Question</asp:ListItem>
                    <asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
                    <asp:ListItem Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
                    <asp:ListItem Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
                    <asp:ListItem Value="4">What is your oldest sibling&#39;s middle name?</asp:ListItem>
                    <asp:ListItem Value="5">In what city does your nearest sibling live? </asp:ListItem>
                    <asp:ListItem Value="6">In what city or town was your first job?</asp:ListItem>
                    <asp:ListItem Value="7">What is your maternal grandmother&#39;s maiden name?</asp:ListItem>
                    <asp:ListItem Value="8">What was your favorite place to visit as a child?</asp:ListItem>
                    <asp:ListItem Value="9">What is the name of your favorite childhood teacher?</asp:ListItem>
                    <asp:ListItem Value="10">What was the first concert you attended?</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tb_secans1" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
            </p>
            <p>Security Question 2:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="dd_secque2" runat="server" Enabled="False">
                    <asp:ListItem Value="Default Question">Select Security Question</asp:ListItem>
                    <asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
                    <asp:ListItem Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
                    <asp:ListItem Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
                    <asp:ListItem Value="4">What is your oldest sibling&#39;s middle name?</asp:ListItem>
                    <asp:ListItem Value="5">In what city does your nearest sibling live? </asp:ListItem>
                    <asp:ListItem Value="6">In what city or town was your first job?</asp:ListItem>
                    <asp:ListItem Value="7">What is your maternal grandmother&#39;s maiden name?</asp:ListItem>
                    <asp:ListItem Value="8">What was your favorite place to visit as a child?</asp:ListItem>
                    <asp:ListItem Value="9">What is the name of your favorite childhood teacher?</asp:ListItem>
                    <asp:ListItem Value="10">What was the first concert you attended?</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_secans2" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
            </p>
            <p>Security Question 3:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="dd_secque3" runat="server" Enabled="False">
                    <asp:ListItem Value="Default Question">Select Security Question</asp:ListItem>
                    <asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
                    <asp:ListItem Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
                    <asp:ListItem Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
                    <asp:ListItem Value="4">What is your oldest sibling&#39;s middle name?</asp:ListItem>
                    <asp:ListItem Value="5">In what city does your nearest sibling live? </asp:ListItem>
                    <asp:ListItem Value="6">In what city or town was your first job?</asp:ListItem>
                    <asp:ListItem Value="7">What is your maternal grandmother&#39;s maiden name?</asp:ListItem>
                    <asp:ListItem Value="8">What was your favorite place to visit as a child?</asp:ListItem>
                    <asp:ListItem Value="9">What is the name of your favorite childhood teacher?</asp:ListItem>
                    <asp:ListItem Value="10">What was the first concert you attended?</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_secans3" runat="server" Height="16px" Width="128px" oncopy="return false" onpaste="return false"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblStatus_ChgPwd" runat="server" Visible="False"></asp:Label>
            </p>
                            <p>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btn_changepwd" runat="server" CssClass="auto-style3" Text="Change Password" OnClick="btn_changepwd_Click" />
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
            <asp:TabPanel ID="tab_billpayment" runat="server" HeaderText="Submit Payment" TabIndex="4" Visible =" false">
                <ContentTemplate>
                    <br />
                    <br />
                    <asp:TabContainer ID="TabContainer4" runat="server" ActiveTabIndex="1" Height="556px" Width="835px" style="margin-right: 709px">
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
                                <asp:TextBox ID="tb_cardnum" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Account Holder&#39;s Name:&nbsp;&nbsp;
                                <asp:TextBox ID="tb_customername" runat="server" Width="118px" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                (as printed on the card)<br />Expiry Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="dd_cardexpm" runat="server">
                                    <asp:ListItem Value="00">MM</asp:ListItem>
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
                                    <asp:ListItem Value="00">YY</asp:ListItem>
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
                                </asp:DropDownList>
                                &nbsp;<br />Amount:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                 <asp:TextBox ID="tb_amount_CardPayment" runat="server" Width="118px" oncopy="return false" onpaste="return false"></asp:TextBox>
                                 <br />
                                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                 <asp:Label ID="lblSubmitPayment" runat="server" Visible="False"></asp:Label>
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btn_cardsubmitpayment" runat="server" Text="Submit Payment" OnClick="btn_cardsubmitpayment_Click" />
                                <br />
                                &nbsp;&nbsp;&nbsp;
                           
                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="tab_echeckpay" runat="server" HeaderText="ECheck Payment" Height="600px" Width="124px">
                            <ContentTemplate>
                                <br />
                                Account Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="tb_echeckaccno" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Routing Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="tb_echeckroutingno" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Account Holder&#39;s Name:&nbsp;&nbsp;<asp:TextBox ID="tb_echeckcustomername" runat="server" Width="118px" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Amount:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_amountECheck" runat="server" Width="118px" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="lblEcheckPayment" runat="server" Visible="False"></asp:Label>
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btn_echecksubmitpayment" runat="server" Text="Submit Payment" OnClick="btn_echecksubmitpayment_Click" />
                                </ContentTemplate>
                        </asp:TabPanel>
                    </asp:TabContainer>
                </ContentTemplate>
            </asp:TabPanel>
        </asp:TabContainer>
    </div>
</asp:Content>
