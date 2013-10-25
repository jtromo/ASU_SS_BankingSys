<%@ Page Title="" Language="C#" MasterPageFile="~/Final.Master" AutoEventWireup="true" CodeBehind="InternalUser.aspx.cs" Inherits="SoftSec_BankingApp_Se7en.InternalUser" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register assembly="Recaptcha" namespace="Recaptcha" tagprefix="recaptcha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/PasswordStyle.css" rel="stylesheet" type="text/css" />
    <div style="height:800px";>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="3" Width="949px" AutoPostBack="True" OnActiveTabChanged="TabContainer1_ActiveTabChanged">
            <asp:TabPanel runat="server" HeaderText="Customer Account Access" ID="tab_ExistingCust" TabIndex="0">
                <HeaderTemplate>
                    Existing Customer Account Access
                </HeaderTemplate>
                <ContentTemplate>

                    <br />
                    Customer Details:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnSignOff" runat="server" OnClick="btnSignOff_Click" Text="Sign Off" />
                    <br />Card Number:&nbsp;
                    <asp:TextBox ID="tbCardNumber_IU" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Date of Birth:&nbsp;
                    <asp:DropDownList ID="MonthDD_ExistingCustomer_Verify" runat="server">
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
                    &nbsp;<asp:DropDownList ID="DayDD_ExistingCustomer_Verify" runat="server">
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
                    &nbsp;<asp:TextBox ID="tbYear_IU" runat="server" Height="16px" Width="76px" oncopy="return false" onpaste="return false">YYYY</asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnVerify0" runat="server" OnClick="btnVerify_Click" Text="Verify" />
                    <br />
                    Photo Identification Verification<asp:RadioButtonList ID="rb_PhotoID" runat="server" Width="55px">
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem Selected="True">No</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:TabContainer ID="TabContainer2" runat="server" ActiveTabIndex="1" Width="925px" AutoPostBack="True" Visible="False" OnActiveTabChanged="TabContainer2_ActiveTabChanged">
                        <asp:TabPanel runat="server" HeaderText="Accounts" ID="tab_accounts">
                <ContentTemplate>
                    <br>
                    <br></br>
                    Checking Account:
                    <asp:TextBox ID="tb_checking" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:Button ID="btn_checking" runat="server" OnClick="btn_checking_Click" Text="View Summary" />
                    <br />
                    Savings Account:&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_savings" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:Button ID="btn_savings" runat="server" OnClick="btn_savings_Click" Text="View Summary" />
                    <br />
                    Credit Account:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_credit" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:Button ID="btn_credit" runat="server" Text="View Summary" />
                    <br />
                    <br />
                    <br>
                    <br>
                    <asp:GridView ID="grdTransaction" runat="server">
                    </asp:GridView>
                    <br></br>
                    <br>
                    <br>
                    <br></br>
                    <br></br>
                    <br></br>
                    </br>
                    </br>
                    </br>
                    </br>
                    </br>
                </ContentTemplate>
            </asp:TabPanel>
                        <asp:TabPanel runat="server" HeaderText="Transfers" ID="tab_transfers" TabIndex="1">
                            <ContentTemplate>
                                <br />
                                Please select the transfer type.<br /> <asp:TabContainer ID="TabContainer3" runat="server" ActiveTabIndex="0" Height="515px" Width="850px">
                                    <asp:TabPanel ID="tab_trans_inside" runat="server" HeaderText="Inside Bank">
                                        <ContentTemplate>
                                            <p>
                                                &nbsp;</p>
                                            <p>
                                                From:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:DropDownList ID="fromAccTypeDD_TransferExistingCust_Inside" runat="server" CssClass="auto-style4" Width="124px">
                                                    <asp:ListItem>Account</asp:ListItem>
                                                </asp:DropDownList>
                                            </p>
                                            <p class="auto-style6">
                                                Amount:&nbsp;&nbsp;&nbsp;
                                                <asp:TextBox ID="tb_amount_IU_Inside" runat="server" Width="115px" oncopy="return false" onpaste="return false"></asp:TextBox>
                                            </p>
                                            <p>
                                                <strong>Recepient&#39;s Details:</strong></p>
                                            <p>
                                                &nbsp;Account Number:&nbsp;&nbsp;
                                                <asp:TextBox ID="tb_recepient_IU_Inside" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:TextBox ID="reqAuthDeptIDTB" runat="server"></asp:TextBox>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:TextBox ID="reqAuthRoleIDTB" runat="server"></asp:TextBox>
                                            </p>
                                            <p>
                                                Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:TextBox ID="tb_lastname_IU_Inside" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                            </p>
                                            <p>
                                                Zip Code:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:TextBox ID="tb_zip_IU_Inside" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                            </p>
                                            <p>
                                                <strong>Your Details (Validation):</strong></p>
                                            <p>
                                                Card Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:TextBox ID="tb_card_IU_Inside" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Label ID="requetAuthLb" runat="server" Text="Pleae choose an authorizer" Width="100px"></asp:Label>
                                                &nbsp;&nbsp;
                                                <asp:DropDownList ID="authorizerDropDown" runat="server" Width="100px">
                                                </asp:DropDownList>
                                            </p>
                                            <p>
                                                Expiry:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:DropDownList ID="monthDD_TransferExistingCust_Inside" runat="server">
                                                    <asp:ListItem>MM</asp:ListItem>
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
                                                <asp:DropDownList ID="yearDD_TransferExistingCust_Inside" runat="server">
                                                    <asp:ListItem>YYYY</asp:ListItem>
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
                                                <asp:TextBox ID="tb_securitycode_IU_Inside" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="placeReqBT" runat="server" OnClick="placeReqBT_Click" Text="PlaceRequest" />
                                            </p>
                                            <p>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Label ID="lblSuccess_IUInside" runat="server" Visible="False"></asp:Label>
                                            </p>
                                            <p>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="btn_maketransinside" runat="server" OnClick="btn_maketransinside_Click" Text="Make Transfer" />
                                            </p>
                                            <p>
                                                &nbsp;</p>
                                        </ContentTemplate>
                                    </asp:TabPanel>
                                    <asp:TabPanel ID="tab_trans_outside" runat="server" HeaderText="Outside Bank">
                                        <ContentTemplate>
                                            <p class="auto-style5">
                                                &nbsp;</p>
                                            <p class="auto-style5">
                                                From:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:DropDownList ID="accTypeDD_TransferExistingCust_Outside" runat="server" CssClass="auto-style4" Width="124px">
                                                    <asp:ListItem>Account</asp:ListItem>
                                                </asp:DropDownList>
                                            </p>
                                            <p class="auto-style5">
                                                Amount:&nbsp;&nbsp;&nbsp;
                                                <asp:TextBox ID="tb_amountoutside" runat="server" Width="115px" oncopy="return false" onpaste="return false"></asp:TextBox>
                                            </p>
                                            <p class="auto-style5">
                                                <strong>Recepient&#39;s Details:</strong></p>
                                            <p class="auto-style5">
                                                Account Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:TextBox ID="tb_AccNumoutside_Intenal" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                            </p>
                                            <p class="auto-style9">
                                                Routing Number :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:TextBox ID="tb_toRoutingNum_OutsideBank" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                            </p>
                                            <p class="auto-style5">
                                                Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                                <asp:TextBox ID="tb_lastnameoutside" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                            </p>
                                            <p class="auto-style9">
                                                Email ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:TextBox ID="tb_emailoutside" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                            </p>
                                            <p class="auto-style9">
                                                <strong>Your Details (Validation):</strong></p>
                                            <p class="auto-style9">
                                                Card Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:TextBox ID="tb_usercardno" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                            </p>
                                            <p>
                                                &nbsp;Expiry:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:DropDownList ID="monthDD_TransferExistingCust_Outside" runat="server">
                                                    <asp:ListItem>MM</asp:ListItem>
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
                                                <asp:DropDownList ID="yearDD_TransferExistingCust_Outside" runat="server">
                                                    <asp:ListItem>YYYY</asp:ListItem>
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
                                            <p>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Label ID="lblStatus_OutsideBank" runat="server" Visible="False"></asp:Label>
                                            </p>
                                            <p>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="btn_maketransferoutside" runat="server" OnClick="btn_maketransferoutside_Click" Text="Make Transfer" />
                                            </p>
                                            <p>
                                                &nbsp;</p>
                                        </ContentTemplate>
                                    </asp:TabPanel>
                                    <asp:TabPanel ID="tab_trans_between" runat="server" HeaderText="Between Your Accounts">
                                        <ContentTemplate>
                                            <p class="auto-style5">
                                                &nbsp;</p>
                                            <p class="auto-style5">
                                                From:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:DropDownList ID="fromAccTypeDD_TransferExistingCust_Between" runat="server" CssClass="auto-style4" Width="124px">
                                                    <asp:ListItem>Account</asp:ListItem>
                                                </asp:DropDownList>
                                            </p>
                                            <p class="auto-style5">
                                                To:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:DropDownList ID="toAccTypeDD_TransferExistingCust_Between" runat="server" CssClass="auto-style4" Width="124px">
                                                    <asp:ListItem>Account</asp:ListItem>
                                                </asp:DropDownList>
                                            </p>
                                            <p class="auto-style5">
                                                Amount:&nbsp;&nbsp;&nbsp;
                                                <asp:TextBox ID="tb_amountbetween" runat="server" Width="115px" oncopy="return false" onpaste="return false"></asp:TextBox>
                                                <asp:Label ID="lblStatus_Between" runat="server" Visible="False"></asp:Label>
                                            </p>
                                            <p class="auto-style5">
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="btn_maketransbetween" runat="server" OnClick="btn_maketransbetween_Click" Text="Make Transfer" />
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
                                                <asp:TextBox ID="tb_card_DebitFunds" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                            </p>
                                            <p>
                                                Expiry:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:DropDownList ID="monthDD_TransferExistingCust_Debit" runat="server">
                                                    <asp:ListItem>MM</asp:ListItem>
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
                                                <asp:DropDownList ID="yearDD_TransferExistingCust_Debit" runat="server">
                                                    <asp:ListItem>YYYY</asp:ListItem>
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
                                                <asp:TextBox ID="tb_securitycode_DebitFunds" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                            </p>
                                            <p class="auto-style5">
                                                From:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:DropDownList ID="accTypeDD_TransferExistingCust_Debit" runat="server" CssClass="auto-style4" Width="124px">
                                                    <asp:ListItem>Accounts</asp:ListItem>
                                                </asp:DropDownList>
                                            </p>
                                            <p class="auto-style5">
                                                Amount:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:TextBox ID="tb_amountoutside_DebitFunds" runat="server" Width="115px" oncopy="return false" onpaste="return false"></asp:TextBox>
                                            </p>
                                            <p class="auto-style5">
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Label ID="lblStatus_DebitFunds" runat="server" Visible="False"></asp:Label>
                                            </p>
                                            <p class="auto-style5">
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btn_maketransDebitFunds" runat="server" OnClick="btn_maketransDebitFunds_Click" Text="Debit Funds" />
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
                                                <asp:TextBox ID="tb_card_CreditFunds" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                            </p>
                                            <p>
                                                Expiry:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:DropDownList ID="monthDD_TransferExistingCust_Credit" runat="server">
                                                    <asp:ListItem>MM</asp:ListItem>
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
                                                <asp:DropDownList ID="yearDD_TransferExistingCust_Credit" runat="server">
                                                    <asp:ListItem>YYYY</asp:ListItem>
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
                                                <asp:TextBox ID="tb_securitycode_CreditFunds" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                            </p>
                                            <p class="auto-style5">
                                                To:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="accTypeDD_TransferExistingCust_Credit" runat="server" CssClass="auto-style4" Width="124px">
                                                    <asp:ListItem>Accounts</asp:ListItem>
                                                </asp:DropDownList>
                                            </p>
                                            <p class="auto-style5">
                                                Amount:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:TextBox ID="tb_amountoutside_CreditFunds" runat="server" Width="115px" oncopy="return false" onpaste="return false"></asp:TextBox>
                                            </p>
                                            <p class="auto-style5">
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Label ID="lblStatus_CreditFunds" runat="server" Visible="False"></asp:Label>
                                            </p>
                                            <p class="auto-style5">
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btn_maketrans_CreditFunds" runat="server" OnClick="btn_maketrans_CreditFunds_Click" Text="Credit Funds" />
                                            </p>
                                        </ContentTemplate>
                                    </asp:TabPanel>
                                </asp:TabContainer>
                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="tab_profile" runat="server" HeaderText="Profile" TabIndex="2">
                <ContentTemplate>

                    <br />
                    <h6>Contact Information&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Account Settings</h6>
  
                     <p>Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                         <asp:TextBox ID="tb_emailview" runat="server" ReadOnly="True" oncopy="return false" onpaste="return false"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password (last updated):
                         <asp:TextBox ID="tb_pwdlastview" runat="server" ReadOnly="True" oncopy="return false" onpaste="return false"></asp:TextBox>
                    </p>
                     <p>Street&nbsp; Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                         <asp:TextBox ID="tb_addrview" runat="server" ReadOnly="True" oncopy="return false" onpaste="return false"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:TextBox ID="tb_usernameview" runat="server" ReadOnly="True" oncopy="return false" onpaste="return false"></asp:TextBox>
                    </p>
                     <p>
                         City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:TextBox ID="tb_cityView" runat="server" ReadOnly="True" oncopy="return false" onpaste="return false"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp; State&nbsp;&nbsp;
                         <asp:DropDownList ID="StateDD_View" runat="server" Enabled="False">
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
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Zip&nbsp;
                         <asp:TextBox ID="tb_zipView" runat="server" ReadOnly="True" oncopy="return false" onpaste="return false"></asp:TextBox>
                    </p>
                     <p>Contact:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:TextBox ID="tb_contactview" runat="server" ReadOnly="True" oncopy="return false" onpaste="return false"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nickname:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:TextBox ID="tb_nicknameview" runat="server" ReadOnly="True" oncopy="return false" onpaste="return false"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </p>
                     <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btn_editprof" runat="server" Text="Edit Profile" OnClick="btn_editprof_Click" />
                    </p>
                    <asp:TabContainer ID="TabContainer4" runat="server" ActiveTabIndex="1" Height="369px" Width="837px" AutoPostBack="True" OnActiveTabChanged="TabContainer4_ActiveTabChanged" Visible="False">
                        <asp:TabPanel ID="tabeditprofile" runat="server" HeaderText="Edit Profile" Height="600px" Width="124px">
                            <ContentTemplate>

                                <br />
                                <h6>Contact Information</h6>
                                <p>
                                    Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : &nbsp;
                                    <asp:TextBox ID="tb_email_Edit" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                </p>
                                <p>
                                    Street Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
                                    <asp:TextBox ID="tb_stAddr_Edit" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                    &nbsp;&nbsp;&nbsp; City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
                                    <asp:TextBox ID="tb_city_Edit" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                    &nbsp;
                                </p>
                                <p>
                                    State&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;
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
                                    &nbsp; ZipCode&nbsp; :
                                    <asp:TextBox ID="tb_zipCode_Edit" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                </p>
                                <p>
                                    Contact&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;
                                    <asp:TextBox ID="tb_contact_Edit" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                    &nbsp;&nbsp;&nbsp;</p>
                                <p>
                                    Nickname&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;
                                    <asp:TextBox ID="tb_nickname_Edit" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="lblStatus_ChangeProf" runat="server" Visible="False"></asp:Label>
                                </p>
                                <p>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btn_changesettings_profile" runat="server" Text="Change Profile Settings" OnClick="btn_changesettings_profile_Click" />
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
            <p>Old Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_oldpwd" runat="server" TextMode="Password" oncopy="return false" onpaste="return false"></asp:TextBox>
                <asp:PasswordStrength ID="tb_oldpwd_PasswordStrength" runat="server" MinimumLowerCaseCharacters="1" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="1" PreferredPasswordLength="12" RequiresUpperAndLowerCaseCharacters="True" TargetControlID="tb_oldpwd" TextStrengthDescriptions="Very Weak;Weak;Average;Strong;Very Strong" TextStrengthDescriptionStyles="TextIndicator_TB_Password_Strength4">
                </asp:PasswordStrength>
                &nbsp;</p>
                            <p>
                                New Password :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_newPassword" runat="server" TextMode="Password" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <asp:PasswordStrength ID="tb_newPassword_PasswordStrength" runat="server" MinimumLowerCaseCharacters="1" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="1" PreferredPasswordLength="12" RequiresUpperAndLowerCaseCharacters="True" TargetControlID="tb_newPassword" TextStrengthDescriptions="Very Weak;Weak;Average;Strong;Very Strong" TextStrengthDescriptionStyles="TextIndicator_TB_Password_Strength4">
                                </asp:PasswordStrength>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Confirm Password :
                                <asp:TextBox ID="tb_confrimPassword" runat="server" TextMode="Password" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <asp:PasswordStrength ID="tb_confrimPassword_PasswordStrength" runat="server" MinimumLowerCaseCharacters="1" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" PreferredPasswordLength="12" TargetControlID="tb_confrimPassword" TextStrengthDescriptions="Very Weak;Weak;Average;Strong;Very Strong" TextStrengthDescriptionStyles="TextIndicator_TB_Password_Strength4">
                                </asp:PasswordStrength>
                            </p>
            <p>Sequrity Question 1:&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="Sec1DD_ExistingCust_EditProf" runat="server">
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
                <asp:DropDownList ID="Sec2DD_ExistingCust_EditProf" runat="server">
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
                <asp:DropDownList ID="Sec3DD_ExistingCust_EditProf" runat="server">
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
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblStatus_ChangePswd" runat="server" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btn_changepwd_Internal" runat="server" CssClass="auto-style3" Text="Change Password" OnClick="btn_changepwd_Internal_Click" />

                            <p>
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
                        <asp:TabPanel ID="tab_modtrans" runat="server" HeaderText="Modify Transactions" TabIndex="3">
                <ContentTemplate>
                    <br />

                    <br />
                    Show transfers for:
                    <asp:DropDownList ID="transferDD_ModifyTrans" runat="server" AutoPostBack="True" OnSelectedIndexChanged="transferDD_ModifyTrans_SelectedIndexChanged">
                        <asp:ListItem>Accounts</asp:ListItem>
                    </asp:DropDownList>
                    <br></br>
                    <br />
                    <asp:GridView ID="grdTransactions" runat="server" AllowPaging="True" OnPageIndexChanging="grdTransactions_PageIndexChanging" PageSize="3">
                    </asp:GridView>
                    <br />
                    <br />
                    <br />
                    Transaction ID:
                    <asp:TextBox ID="tb_transID_ModifyTrans" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btn_viewtransdetails" runat="server" OnClick="btn_viewtransdetails_Click" Text="View Details" />
                    <br />
                    <br />
                    <br />
                    Account Number:<asp:Label ID="lblAccount_ModifyTrans" runat="server" Visible="False"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Account Number
                    <asp:TextBox ID="tb_AccNum_modifyTrans" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                    <br />
                    Routing Number:
                    <asp:Label ID="lblRoutingNum_ModifyTrans" runat="server" Visible="False"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Routing Number&nbsp;
                    <asp:TextBox ID="tb_RoutNum_modifyTrans" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                    <br />
                    Amount:&nbsp;<asp:Label ID="lblAmount_ModifyTrans" runat="server" Visible="False"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Amount &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="tb_Amount_ModifyTrans" runat="server"></asp:TextBox>
                    <br />
                    Status :&nbsp;<asp:Label ID="lblStatus_ModifyStatus" runat="server" Visible="False"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btn_modifytrans" runat="server" OnClick="btn_modifytrans_Click" Text="Modify" />
                    &nbsp;&nbsp;
                    
                    </br>

                    </Contenttemplate>

                    </asp:TabPanel>           
                        <asp:TabPanel ID="tab_billpayment" runat="server" HeaderText="Submit Payment" TabIndex="4">
                            <ContentTemplate>
                                <br />
                                <br />
                                <asp:TabContainer ID="TabContainer5" runat="server" ActiveTabIndex="0" Height="556px" Width="835px" style="margin-right: 709px">
                                    <asp:TabPanel ID="tab_cardpay" runat="server" HeaderText="Card Payment" Height="600px" Width="124px">
                                        <ContentTemplate>
                                             <br />
                                            Card Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:DropDownList ID="cardTypeDD_CardPayment" runat="server">
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
                                            <asp:DropDownList ID="cardExpDD_CardPayment" runat="server">
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
                                            <asp:DropDownList ID="yearDD_CardPayment" runat="server">
                                                <asp:ListItem>YY</asp:ListItem>
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
                                             <asp:TextBox ID="tb_amount_SubmitPayment" runat="server" Width="118px" oncopy="return false" onpaste="return false" ></asp:TextBox>
                                             <br />
                                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                             <asp:Label ID="lblSubmitPayment" runat="server" Visible="False"></asp:Label>
                                             <br />
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
                                            <asp:TextBox ID="tbAmount_EcheckPayment" runat="server" Width="118px" oncopy="return false" onpaste="return false"></asp:TextBox>
                                            <br />
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Label ID="lblEcheckPayment" runat="server" Visible="False"></asp:Label>
                                            <br />
                                            <br />
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Button ID="btn_echecksubmitpayment" runat="server" Text="Submit Payment" OnClick="btn_echecksubmitpayment_Click" />
                                            </ContentTemplate>
                                    </asp:TabPanel>
                                </asp:TabContainer>
                            </ContentTemplate>
                        </asp:TabPanel>

                    </asp:TabContainer>
                    <br />

                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="tab_newcustomer" runat="server" HeaderText="New Customer" TabIndex="1">
                <ContentTemplate>
                    <br />
                                       <asp:TabContainer ID="TabContainer6" runat="server" ActiveTabIndex="1" Width="918px">
                        <asp:TabPanel ID="tab_employee" runat="server" HeaderText="Employee">

                            <HeaderTemplate>
                                Customer Details
                            </HeaderTemplate>

                            <ContentTemplate>
                                <br />
                                First Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_FirstName_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Middle Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_MiddleName_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:TextBox ID="tb_LastName_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Email ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_Email_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Street Address:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_StreetAddr_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                City :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_City_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                State :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="StateDD_Cust" runat="server">
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
                                <br />
                                Contact:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_Phone_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Zip Code:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_Zip_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
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
                                <asp:Button ID="btn_createcust" runat="server" Text="Create" OnClick="btn_createcust_Click" />
                                <br />
                                <br />
                                <asp:Label ID="fieldValidationErrorLabel" runat="server" Text="Label" Width="300px"></asp:Label>
                            </ContentTemplate>

                        </asp:TabPanel>
                        <asp:TabPanel ID="tab_customer" runat="server" HeaderText="Customer">
                            <HeaderTemplate>
                                Personal Information
                            </HeaderTemplate>
                            <ContentTemplate>
                                <br />
                                Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_UserName_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_Password_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Repeat Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_ConfPassword_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Security Question 1:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="Sec1DD_PersonalInformation" runat="server">
                                    <asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
                                    <asp:ListItem Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
                                    <asp:ListItem Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_SecAns1_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Security Question 2:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="Sec2DD_PersonalInformation" runat="server">
                                    <asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
                                    <asp:ListItem Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
                                    <asp:ListItem Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_SecAns2_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Security Question 3:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="Sec3DD_PersonalInformation" runat="server">
                                    <asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
                                    <asp:ListItem Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
                                    <asp:ListItem Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_SecAns3_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Social Security Number:&nbsp;
                                <asp:TextBox ID="tb_SSN_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
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
                                <asp:ImageButton ID="img_site10" runat="server" OnClick="img_site10_Click" />&nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:ImageButton ID="img_site11" runat="server" OnClick="img_site11_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site12" runat="server" OnClick="img_site12_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site13" runat="server" OnClick="img_site13_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site14" runat="server" OnClick="img_site14_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site15" runat="server" OnClick="img_site15_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site16" runat="server" OnClick="img_site16_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site17" runat="server" OnClick="img_site17_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site18" runat="server" OnClick="img_site18_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site19" runat="server" OnClick="img_site19_Click" />&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site20" runat="server" OnClick="img_site20_Click" />&nbsp;<br />Sitekey Hint:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_sitekeyhint_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Date of Birth:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="monthDD_PersonalInformation" runat="server">
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
                                <asp:DropDownList ID="dayDD_PersonalInformation" runat="server">
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
                                <asp:TextBox ID="tb_BirthYear_Cust" runat="server" Height="16px" Width="76px" oncopy="return false" onpaste="return false">YYYY</asp:TextBox>
                                <br />
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btn_sumbitcust" runat="server" Text="Submit" OnClick="btn_sumbitcust_Click" />
                                <br />
                                <br />
                                <asp:Label ID="ErrorLabelInNewCustPI" runat="server" Text="Label" Width="300px"></asp:Label>
                            </ContentTemplate>
                        </asp:TabPanel>
                    </asp:TabContainer>
                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="tab_dept" runat="server" HeaderText="Department" TabIndex="2">
                <HeaderTemplate>
                    Department
                </HeaderTemplate>
                <ContentTemplate>
                    <br />
                    <asp:TabContainer ID="TabContainer7" runat="server" ActiveTabIndex="2" Width="917px">
                        <asp:TabPanel ID="tab_addemp" runat="server" HeaderText="Add Employee">
                            <ContentTemplate>

                                <br />
                                Employee Details: (You need to have the employee with you while adding him)<br />
                                First Name:&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_FirstName_Emp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp; Middle Name:&nbsp;
                                <asp:TextBox ID="tb_MidName_Emp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp; Last Name:&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_LastName_Emp" runat="server" Height="22px" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Street Address:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_StreetAddr_Emp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                City :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_City_Emp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Zip:
                                <asp:TextBox ID="tb_Zip_Emp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                State :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="StateDD_Emp" runat="server">
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
                                <br />
                                Department:&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DeptDD_AddEmp" runat="server">
                                     <asp:ListItem Value="1">Unknown</asp:ListItem>
                                     <asp:ListItem Value="2">Sales</asp:ListItem>
                                     <asp:ListItem Value="3">IT Tech Support</asp:ListItem>
                                     <asp:ListItem Value="4">Transactions</asp:ListItem>
                                     <asp:ListItem Value="5">Human Resources</asp:ListItem>
                                     <asp:ListItem Value="6">Company Management</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Role:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="RoleDD_AddEmp" runat="server">
                                     <asp:ListItem Value="4">Regular Employee</asp:ListItem>
                                     <asp:ListItem Value="5">Department Manager</asp:ListItem>
                                     <asp:ListItem Value="6">Company Official</asp:ListItem>
                                     <asp:ListItem Value="7">Admin</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Email ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_Email_Emp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Contact:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_Phone_Emp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_UserName_AddEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_Password_AddEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Repeat Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_ConfPassword_AddEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Security Question 1:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="Sec1DD_PersonalInformation_AddEmp" runat="server">
                                    <asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
                                    <asp:ListItem Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
                                    <asp:ListItem Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_SecAns1_AddEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Security Question 2:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="Sec2DD_PersonalInformation_AddEmp" runat="server">
                                    <asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
                                    <asp:ListItem Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
                                    <asp:ListItem Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_SecAns2_AddEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Security Question 3:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="Sec3DD_PersonalInformation_AddEmp" runat="server">
                                    <asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
                                    <asp:ListItem Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
                                    <asp:ListItem Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_SecAns3_AddEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Social Security Number:&nbsp;
                                <asp:TextBox ID="tb_SSN_AddEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                <br />
                                SiteKey:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:ImageButton ID="img_site1_AE" runat="server" OnClick="img_site1_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site2_AE" runat="server" OnClick="img_site2_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site3_AE" runat="server" OnClick="img_site3_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site4_AE" runat="server" OnClick="img_site4_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site5_AE" runat="server" OnClick="img_site5_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site6_AE" runat="server" OnClick="img_site6_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site7_AE" runat="server" OnClick="img_site7_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site8_AE" runat="server" OnClick="img_site8_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site9_AE" runat="server" OnClick="img_site9_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site10_AE" runat="server" OnClick="img_site10_Click" />
                                &nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:ImageButton ID="img_site11_AE" runat="server" OnClick="img_site11_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site12_AE" runat="server" OnClick="img_site12_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site13_AE" runat="server" OnClick="img_site13_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site14_AE" runat="server" OnClick="img_site14_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site15_AE" runat="server" OnClick="img_site15_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site16_AE" runat="server" OnClick="img_site16_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site17_AE" runat="server" OnClick="img_site17_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site18_AE" runat="server" OnClick="img_site18_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site19_AE" runat="server" OnClick="img_site19_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site20_AE" runat="server" OnClick="img_site20_Click" />
                                &nbsp;<br /> Sitekey Hint:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_sitekeyhint_AddEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Date of Birth:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="monthDD_PersonalInformation_AddEmp" runat="server">
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
                                <asp:DropDownList ID="dayDD_PersonalInformation_AddEmp" runat="server">
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
                                <asp:TextBox ID="tb_BirthYear_AddEmp" runat="server" Height="16px" Width="76px" oncopy="return false" onpaste="return false">YYYY</asp:TextBox>
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btn_AddEmp" runat="server" Text="Add Employee" OnClick="btn_AddEmp_Click" />
                                <br />

                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="tab_delemp" runat="server" HeaderText="Delete Employee">
                            <ContentTemplate>

                                <br />
                                Employee ID:&nbsp;&nbsp;
                                <asp:TextBox ID="tb_UserName_DelEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnViewEmpDetails_delEmp" runat="server" Text="View Details" OnClick="btn_ViewDetails_DelEmp_Click" />
                                <br />
                                <br />
                                Employee Details:
                                <br />
                                First Name:&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_FirstName_DelEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Middle Name:&nbsp;
                                <asp:TextBox ID="tb_MidName_DelEMp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Last Name:&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:TextBox ID="tb_LastName_DelEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Department:&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DeptDD_DelEmp" runat="server">
                                    <asp:ListItem Value="1">Unknown</asp:ListItem>
                                     <asp:ListItem Value="2">Sales</asp:ListItem>
                                     <asp:ListItem Value="3">IT Tech Support</asp:ListItem>
                                     <asp:ListItem Value="4">Transactions</asp:ListItem>
                                     <asp:ListItem Value="5">Human Resources</asp:ListItem>
                                     <asp:ListItem Value="6">Company Management</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Role:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="RoleDD_DelEmp" runat="server">
                                    <asp:ListItem Value="4">Regular Employee</asp:ListItem>
                                     <asp:ListItem Value="5">Department Manager</asp:ListItem>
                                     <asp:ListItem Value="6">Company Official</asp:ListItem>
                                     <asp:ListItem Value="7">Admin</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Email ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_Email_DelEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Contact:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_Phone_DelEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btn_delEmp" runat="server" Text="Delete Employee" OnClick="btn_delEmp_Click" />

                                <br />
                                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="tab_transemp" runat="server" HeaderText="Transfer Employee">
                            <ContentTemplate>

                                <br />
                                Employee ID:&nbsp;&nbsp;
                                <asp:TextBox ID="tb_UserName_transEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btn_ViewDetails_TransEmp" runat="server" Text="View Details" OnClick="btn_ViewDetails_TransEmp_Click" />
                                <br />
                                <br />
                                Employee Details:
                                <br />
                                First Name:&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_FName_TransEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Middle Name:&nbsp;
                                <asp:TextBox ID="tb_MName_TransEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Last Name:&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:TextBox ID="tb_LName_TransEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Department:&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="FROM_DeptDD_TransEmp" runat="server">
                                    <asp:ListItem Value="1">Unknown</asp:ListItem>
                                     <asp:ListItem Value="2">Sales</asp:ListItem>
                                     <asp:ListItem Value="3">IT Tech Support</asp:ListItem>
                                     <asp:ListItem Value="4">Transactions</asp:ListItem>
                                     <asp:ListItem Value="5">Human Resources</asp:ListItem>
                                     <asp:ListItem Value="6">Company Management</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Role:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="RoleDD_TransEmp" runat="server">
                                    <asp:ListItem Value="4">Regular Employee</asp:ListItem>
                                     <asp:ListItem Value="5">Department Manager</asp:ListItem>
                                     <asp:ListItem Value="6">Company Official</asp:ListItem>
                                     <asp:ListItem Value="7">Admin</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Email ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_Email_TransEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Contact:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_Contact_TransEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                <br />
                                Transfer To Details:<br />Department:&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="TO_DeptDD_TransDept" runat="server">
                                    <asp:ListItem Value="1">Unknown</asp:ListItem>
                                     <asp:ListItem Value="2">Sales</asp:ListItem>
                                     <asp:ListItem Value="3">IT Tech Support</asp:ListItem>
                                     <asp:ListItem Value="4">Transactions</asp:ListItem>
                                     <asp:ListItem Value="5">Human Resources</asp:ListItem>
                                     <asp:ListItem Value="6">Company Management</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btn_TransEmp" runat="server" Text="Transfer Employee" OnClick="btn_TransEmp_Click" />

                                <br />
                                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>

                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="tab_viewemp" runat="server" HeaderText="View Employee Details">
                            <ContentTemplate>

                                <br />
                                Employee ID:&nbsp;&nbsp;
                                <asp:TextBox ID="tb_userName_ViewEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btn_ViewDetails_ViewEmp" runat="server" Text="View Details" OnClick="btn_ViewDetails_ViewEmp_Click" />
                                <br />
                                <br />
                                Employee Details:
                                <br />
                                First Name:&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_FName_ViewEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Middle Name:&nbsp;
                                <asp:TextBox ID="tb_MName_ViewEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Last Name:&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:TextBox ID="tb_LName_ViewEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Department:&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DeptDD_viewEmp" runat="server">
                                    <asp:ListItem Value="1">Unknown</asp:ListItem>
                                     <asp:ListItem Value="2">Sales</asp:ListItem>
                                     <asp:ListItem Value="3">IT Tech Support</asp:ListItem>
                                     <asp:ListItem Value="4">Transactions</asp:ListItem>
                                     <asp:ListItem Value="5">Human Resources</asp:ListItem>
                                     <asp:ListItem Value="6">Company Management</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Role:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="RoleDD_ViewEmp" runat="server">
                                    <asp:ListItem Value="4">Regular Employee</asp:ListItem>
                                     <asp:ListItem Value="5">Department Manager</asp:ListItem>
                                     <asp:ListItem Value="6">Company Official</asp:ListItem>
                                     <asp:ListItem Value="7">Admin</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Email ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_Email_ViewEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Contact:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_Phone_ViewEmp" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="tab_viewdepttrans" runat="server" HeaderText="View Department Transaction">
                            <ContentTemplate>

                                <br />
                                Show transfers for:
                                <asp:DropDownList ID="DeptTransfersDD_ViewTrans" runat="server">
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
                                <asp:TextBox ID="tbTransID_ViewDeptTrans" runat="server" Height="22px" oncopy="return false" onpaste="return false"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Date :&nbsp;
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
                                &nbsp;<asp:TextBox ID="tb_Year_ViewDeptTrans" runat="server" Height="16px" Width="76px" oncopy="return false" onpaste="return false">YYYY</asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btn_viewtransdetails1" runat="server" Text="View Details" OnClick="btn_viewtransdetails1_Click" />
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
            <asp:TabPanel ID="tab_tobeauthorized" runat="server" HeaderText="To Be Authorized" TabIndex="3">
                <ContentTemplate>
                    <asp:TextBox ID="lookUPUserNameTF" runat="server"></asp:TextBox>
                    <asp:Button ID="reqLookUPBT" runat="server" OnClick="reqLookUPBT_Click" Text="Look Up" />
                    <br />
                    <br />
                    <asp:Label ID="reqResultLB" runat="server"></asp:Label>
                    <br />
                    &nbsp;<asp:GridView ID="reqGridV" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" OnSelectedIndexChanged="reGridSelectedRowAtIndex" Width="878px">
                    </asp:GridView>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="approveReqBT" runat="server" OnClick="approveReqBT_Click" Text="Approve" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="rejectReqBT" runat="server" OnClick="rejectReqBT_Click" Text="Reject" />
                    <br />
                </ContentTemplate>
            </asp:TabPanel>
        </asp:TabContainer>
    </div>
</asp:Content>
