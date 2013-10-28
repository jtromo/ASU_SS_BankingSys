<%@ Page Title="" Language="C#" MasterPageFile="~/Final.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="SoftSec_BankingApp_Se7en.WebForm2" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<%@ Register assembly="Recaptcha" namespace="Recaptcha" tagprefix="recaptcha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script language="javascript" type="text/javascript">
        function LoadAllowBlockTabProfile() {
            var tabAdmincont = $get('<%=tab_EditProfile.ClientID%>');
            __doPostBack(tabAdmincont, '');
        }
        
        </script>
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="bt_logout" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Small" OnClick="bt_logout_Click">LOG OUT</asp:LinkButton>
            <br />
    <asp:TabContainer ID="tabAdmin" runat="server" ActiveTabIndex="0" Height="1250px" Width="958px"  OnActiveTabChanged="tabAdmin_ActiveTabChanged" BackColor="#BFC5CE" AutoPostBack="True">

        <asp:TabPanel runat="server" HeaderText="Add Employee" ID="addEmpTabPanel" Height="600px" Width="850px">
            <ContentTemplate>
                <br />
                                Employee Details: (You need to have the employee details with you while adding him)<br />
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
        <asp:TabPanel runat="server" HeaderText="Remove Employee" ID="removeEmpTabPanel" Height="600px" Width="850px">
            <ContentTemplate>
                <br />
                &nbsp;<asp:Label ID="userIdLb_Remove" runat="server" Text="User Name"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="userNameTb_Remove" runat="server" Height="15px" style="margin-top: 0px" TabIndex="1" oncopy="return false" onpaste="return false"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="detailsBT_Remove" runat="server" OnClick="detailsBT_Remove_Click" Text="View Details" TabIndex="2" />
                &nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />&nbsp;<asp:Label ID="firstNameLB_Remove" runat="server" Text="First Name"></asp:Label>
                <asp:Label ID="firstNameTextLb_Remove" runat="server" style="margin-left: 63px; margin-right: 0px;" Width="200px"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="errorLabel" runat="server" Width="300px"></asp:Label>
                <br />&nbsp;
                <asp:Label ID="lastNameLb_Remove" runat="server" Text="Last Name"></asp:Label>
                <asp:Label ID="lastNameTextLb_Remove" runat="server" style="margin-left: 64px" Width="200px"></asp:Label>
                &nbsp;
                <br />
                &nbsp;<asp:Label ID="currentRoleLb_Remove" runat="server" Text="Current Role"></asp:Label>
                <asp:Label ID="currentRoleTextLb_Remove" runat="server" Height="18px" style="margin-left: 55px; margin-right: 0px" Width="200px"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="removeBt_Remove" runat="server" OnClick="removeBt_Remove_Click" Text="Remove" TabIndex="3" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </ContentTemplate>
        </asp:TabPanel>
        <asp:TabPanel ID="modifyAccessTabPanel" runat="server" HeaderText="Modify Access level" Height="600px" Width="850px">
            <ContentTemplate>
                <br />
                &nbsp;<asp:Label ID="userIdLabel_Modify" runat="server" Text="User ID"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="userIdTb_Modify" runat="server" Height="15px" style="margin-top: 0px" TabIndex="1" oncopy="return false" onpaste="return false"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="detailsBT_Modify" runat="server" Text="View Details" OnClick="detailsBT_Modify_Click" style="height: 26px" TabIndex="2" />
                &nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />&nbsp;<asp:Label ID="firstNameLB_Modify" runat="server" Text="First Name"></asp:Label>
                <asp:Label ID="firstNameTextLb_Modify" runat="server" Width="200px" style="margin-left: 63px; margin-right: 0px;"></asp:Label>
                &nbsp;<br /> 
                <asp:Label ID="lastNameLb_Modify" runat="server" Text="Last Name"></asp:Label>
                <asp:Label ID="lastNameTextLb_Modify" runat="server" Width="200px" style="margin-left: 64px"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Label ID="errorLbModify" runat="server"></asp:Label>
                <br />&nbsp;<asp:Label ID="currentRoleLb_Modify" runat="server" Text="Current Role"></asp:Label>
                <asp:Label ID="currentRoleTextLb_Modify" runat="server" Height="18px" style="margin-left: 55px; margin-right: 0px" Width="200px"></asp:Label>
                <br />
                <br />
                &nbsp;
                <asp:Label ID="newRoleLb_Modify" runat="server" Text="New Role"></asp:Label>
                &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="4">Internal Regular</asp:ListItem>
                    <asp:ListItem Value="5">Internal Dept. Manager</asp:ListItem>
                    <asp:ListItem Value="6">Higher level Manager</asp:ListItem>
                    <asp:ListItem Value="7">Admin</asp:ListItem>
                </asp:DropDownList>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="modifyBT_Modify" runat="server" Text="Modify" OnClick="modifyBT_Modify_Click" TabIndex="4" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </ContentTemplate>
        </asp:TabPanel>
        <asp:TabPanel ID="LogAccessTabPanel" runat="server" HeaderText="System Log">
            <ContentTemplate>
                <br />
                <asp:Label ID="startDateLB" runat="server" Text="Start Date"></asp:Label>
                &nbsp;&nbsp;
                <asp:DropDownList ID="startMonth_DD" runat="server">
                    <asp:ListItem>MM</asp:ListItem>
                    <asp:ListItem Value="Jan01">01</asp:ListItem>
                    <asp:ListItem Value="Feb02">02</asp:ListItem>
                    <asp:ListItem Value="Mar03">03</asp:ListItem>
                    <asp:ListItem Value="Apr04">04</asp:ListItem>
                    <asp:ListItem Value="May05">05</asp:ListItem>
                    <asp:ListItem Value="Jun06">06</asp:ListItem>
                    <asp:ListItem Value="Jul07">07</asp:ListItem>
                    <asp:ListItem Value="Aug08">08</asp:ListItem>
                    <asp:ListItem Value="Sep09">09</asp:ListItem>
                    <asp:ListItem Value="Oct10">10</asp:ListItem>
                    <asp:ListItem Value="Nov11">11</asp:ListItem>
                    <asp:ListItem Value="Dec12">12</asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;<asp:DropDownList ID="startDay_DD" runat="server">
                    <asp:ListItem>DD</asp:ListItem>
                    <asp:ListItem Value="01">01</asp:ListItem>
                    <asp:ListItem Value="02">02</asp:ListItem>
                    <asp:ListItem Value="03">03</asp:ListItem>
                    <asp:ListItem Value="04">04</asp:ListItem>
                    <asp:ListItem Value="05">05</asp:ListItem>
                    <asp:ListItem Value="06">06</asp:ListItem>
                    <asp:ListItem Value="07">07</asp:ListItem>
                    <asp:ListItem Value="08">08</asp:ListItem>
                    <asp:ListItem Value="09">09</asp:ListItem>
                    <asp:ListItem Value="10">10</asp:ListItem>
                    <asp:ListItem Value="11">11</asp:ListItem>
                    <asp:ListItem Value="12">12</asp:ListItem>
                    <asp:ListItem Value="13">13</asp:ListItem>
                    <asp:ListItem Value="14">14</asp:ListItem>
                    <asp:ListItem Value="15">15</asp:ListItem>
                    <asp:ListItem Value="16">16</asp:ListItem>
                    <asp:ListItem Value="17">17</asp:ListItem>
                    <asp:ListItem Value="18">18</asp:ListItem>
                    <asp:ListItem Value="19">19</asp:ListItem>
                    <asp:ListItem Value="20">20</asp:ListItem>                
                    <asp:ListItem Value="21">21</asp:ListItem>
                    <asp:ListItem Value="22">22</asp:ListItem>
                    <asp:ListItem Value="23">23</asp:ListItem>
                    <asp:ListItem Value="24">24</asp:ListItem>
                    <asp:ListItem Value="25">25</asp:ListItem>
                    <asp:ListItem Value="26">26</asp:ListItem>
                    <asp:ListItem Value="27">27</asp:ListItem>
                    <asp:ListItem Value="28">28</asp:ListItem>
                    <asp:ListItem Value="29">29</asp:ListItem>
                    <asp:ListItem Value="30">30</asp:ListItem>
                    <asp:ListItem Value="31">31</asp:ListItem>
                </asp:DropDownList>
&nbsp;
                <asp:TextBox ID="startYearTb_SysLog" runat="server" Width="35px" TabIndex="2" oncopy="return false" onpaste="return false"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp; End Date&nbsp;&nbsp;<asp:DropDownList ID="endMonth_DD" runat="server">
                    <asp:ListItem>MM</asp:ListItem>
                    <asp:ListItem Value="Jan01">01</asp:ListItem>
                    <asp:ListItem Value="Feb02">02</asp:ListItem>
                    <asp:ListItem Value="Mar03">03</asp:ListItem>
                    <asp:ListItem Value="Apr04">04</asp:ListItem>
                    <asp:ListItem Value="May05">05</asp:ListItem>
                    <asp:ListItem Value="Jun06">06</asp:ListItem>
                    <asp:ListItem Value="Jul07">07</asp:ListItem>
                    <asp:ListItem Value="Aug08">08</asp:ListItem>
                    <asp:ListItem Value="Sep09">09</asp:ListItem>
                    <asp:ListItem Value="Oct10">10</asp:ListItem>
                    <asp:ListItem Value="Nov11">11</asp:ListItem>
                    <asp:ListItem Value="Dec12">12</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;
                <asp:DropDownList ID="endDay_DD" runat="server" >
                    <asp:ListItem>DD</asp:ListItem>
                    <asp:ListItem Value="01">01</asp:ListItem>
                    <asp:ListItem Value="02">02</asp:ListItem>
                    <asp:ListItem Value="03">03</asp:ListItem>
                    <asp:ListItem Value="04">04</asp:ListItem>
                    <asp:ListItem Value="05">05</asp:ListItem>
                    <asp:ListItem Value="06">06</asp:ListItem>
                    <asp:ListItem Value="07">07</asp:ListItem>
                    <asp:ListItem Value="08">08</asp:ListItem>
                    <asp:ListItem Value="09">09</asp:ListItem>
                    <asp:ListItem Value="10">10</asp:ListItem>
                    <asp:ListItem Value="11">11</asp:ListItem>
                    <asp:ListItem Value="12">12</asp:ListItem>
                    <asp:ListItem Value="13">13</asp:ListItem>
                    <asp:ListItem Value="14">14</asp:ListItem>
                    <asp:ListItem Value="15">15</asp:ListItem>
                    <asp:ListItem Value="16">16</asp:ListItem>
                    <asp:ListItem Value="17">17</asp:ListItem>
                    <asp:ListItem Value="18">18</asp:ListItem>
                    <asp:ListItem Value="19">19</asp:ListItem>
                    <asp:ListItem Value="20">20</asp:ListItem>                
                    <asp:ListItem Value="21">21</asp:ListItem>
                    <asp:ListItem Value="22">22</asp:ListItem>
                    <asp:ListItem Value="23">23</asp:ListItem>
                    <asp:ListItem Value="24">24</asp:ListItem>
                    <asp:ListItem Value="25">25</asp:ListItem>
                    <asp:ListItem Value="26">26</asp:ListItem>
                    <asp:ListItem Value="27">27</asp:ListItem>
                    <asp:ListItem Value="28">28</asp:ListItem>
                    <asp:ListItem Value="29">29</asp:ListItem>
                    <asp:ListItem Value="30">30</asp:ListItem>
                    <asp:ListItem Value="31">31</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;
                <asp:TextBox ID="endYearTb_SysLog" runat="server" Width="35px" TabIndex="5" oncopy="return false" onpaste="return false"></asp:TextBox>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="FetchLogsBT" runat="server" OnClick="FetchLogsBT_Click" Text="Fetch Logs" />
                <br />
                <br />
                <asp:GridView ID="sysLog_GridView" runat="server" Width="636px" AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="True" TabIndex="6" >
                    <AlternatingRowStyle BorderStyle="Solid" />
                    <Columns>
                        <asp:DynamicField HeaderText="TimeStamp" NullDisplayText="Empty" />
                        <asp:DynamicField HeaderText="Description" NullDisplayText="Empty" />
                    </Columns>
                </asp:GridView>
            </ContentTemplate>
        </asp:TabPanel>
        <asp:TabPanel ID="RequestTabPanel" runat="server" HeaderText="Requests">
            <ContentTemplate>
                &nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;<asp:Label ID="Label3" runat="server" Text="UserName:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="userNameLookUpTb" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>

                &nbsp;&nbsp;
                <asp:Button ID="UserNameLookUpBT" runat="server" Text="LookUp" OnClick="UserNameLookUpBT_Click" />
                <br />
                <asp:Button ID="btn_ReqAll" runat="server" OnClick="btn_ReqAll_Click" Text="All Pending Requests" />
                <br />
                <asp:GridView ID="RequestsGridV" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridViewItemSelected" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="creationTime" HeaderText="Creation time" />
                        <asp:BoundField DataField="description" HeaderText="Description" />
                        <asp:BoundField DataField="usernameInitiated" HeaderText="Transaction by:" />
                    </Columns>            
                </asp:GridView>

                <br />
                <asp:Label ID="reqErrorLb" runat="server" Height="31px" Width="300px"></asp:Label>
                <br />

                <br />
                <asp:Label ID="EffectedUserLb" runat="server" Text="User Effected:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="effectedUserValueLb" runat="server"></asp:Label>
                <br />
                <asp:Label ID="InitiatorLb" runat="server" Text="Initiator:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="initiatorValueLb" runat="server"></asp:Label>
                <br />
                <asp:Label ID="fromDeptLb" runat="server" Text="From Department:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="fromDeptValueLB" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="toDeptLb" runat="server" Text="To Department:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="toDeptValueLb" runat="server"></asp:Label>
                <br />
                <asp:Label ID="fromRoleLb" runat="server" Text="From Role:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="fromRoleValueLb" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="toRoleLb" runat="server" Text="To Role:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="toRoleValueLb" runat="server"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="approveRequestBT" runat="server" OnClick="approveRequestBT_Click" Text="Approve" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="rejectReqBT" runat="server" OnClick="rejectReqBT_Click" Text="Reject" />
                <br />
                <br />
            </ContentTemplate>
        </asp:TabPanel>        
        <asp:TabPanel ID="panel_EditMyProfile" runat="server" HeaderText="Edit My Profile">

            <ContentTemplate>
                <br />
                <h6>Contact Information&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Account Settings</h6>
                <p>
                    Email:
                    <asp:TextBox ID="tb_emailview" runat="server" Enabled="False" oncopy="return false" onpaste="return false"></asp:TextBox>
                    
                </p>
                <p>
                    Street Address:
                    <asp:TextBox ID="tb_streetAddress" runat="server" Enabled="False" oncopy="return false" onpaste="return false"></asp:TextBox>
                   Username:
                    <asp:TextBox ID="tb_usernameview" runat="server" Enabled="False" oncopy="return false" onpaste="return false"></asp:TextBox>
                </p>
                <p>
                    City: 
                    <asp:TextBox ID="tb_city" runat="server" Enabled="False" oncopy="return false" onpaste="return false"></asp:TextBox>
                    &nbsp;</p>
                <p>
                    State: 
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
                    ZipCode: 
                    <asp:TextBox ID="tb_ZipCode_Profile" runat="server" Enabled="False" oncopy="return false" onpaste="return false"></asp:TextBox>
                </p>
                <p>
                    Contact: 
                    <asp:TextBox ID="tb_contactview" runat="server" Enabled="False" oncopy="return false" onpaste="return false"></asp:TextBox>
                    
                </p>
                <p>
                    <asp:Button ID="btnEditProfile" runat="server" OnClick="btnEditProfile_Click" Text="Edit Profile" />
                </p>
                <p>
                    <asp:TabContainer ID="tab_EditProfile" runat="server" ActiveTabIndex="2" Height="700px"  OnClientActiveTabChanged="LoadAllowBlockTabProfile" OnActiveTabChanged="tab_EditProfile_ActiveTabChanged" Visible="False" Width="900px">
                        <asp:TabPanel ID="tabeditprofile" runat="server" HeaderText="Edit Profile" Height="600px" Width="124px">
                            <ContentTemplate>
                                <br />
                                <h6>Contact Information</h6>
                                <p>
                                    Email Address: 
                                    <asp:TextBox ID="tb_emailedit" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                </p>
                                <p>
                                    Street Address: 
                                    <asp:TextBox ID="tb_addr_editprofile" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                    City: 
                                    <asp:TextBox ID="tb_city_editProfile" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                    
                                </p>
                                <p>
                                    State: 
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
                                    Zip: 
                                    <asp:TextBox ID="tb_zip_editProfile" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                </p>
                                <p>
                                    Contact: 
                                    <asp:TextBox ID="tb_contactedit" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                    
                                </p>
                                <p>
                                   <asp:Label ID="lblChaneProfile" runat="server" Visible="False"></asp:Label>
                                    
                                </p>
                                <p>
                                   <asp:Button ID="btn_changesettings_profile" runat="server" OnClick="btn_changesettings_profile_Click" Text="Edit Contact Info" />
                                </p>
                                <p>
                                    &nbsp;</p>
                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="tabchangepwd" runat="server" HeaderText="Change Password" Height="680px" TabIndex="1" Width="124px">
                            <HeaderTemplate>
                                Change Password
                            </HeaderTemplate>
                            <ContentTemplate>
                                <h6>&nbsp;</h6>
                                <h6>Security Questions</h6>
                                <p>
                                    Old Password: 
                                    <asp:TextBox ID="tb_oldpwd" runat="server" oncopy="return false" onpaste="return false" TextMode="Password"></asp:TextBox>
                                    <asp:PasswordStrength ID="tb_oldpwd_PasswordStrength" runat="server" CalculationWeightings="50;15;15;20" Enabled="True" MinimumLowerCaseCharacters="1" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="1" PreferredPasswordLength="12" RequiresUpperAndLowerCaseCharacters="True" StrengthStyles="TextIndicator_TB_Password_Strength1;TextIndicator_TB_Password_Strength2;TextIndicator_TB_Password_Strength3;TextIndicator_TB_Password_Strength4;TextIndicator_TB_Password_Strength5" TargetControlID="tb_oldpwd" TextStrengthDescriptions="Very Weak;Weak;Average;Strong;Very Strong" TextStrengthDescriptionStyles="TextIndicator_TB_Password_Strength1;TextIndicator_TB_Password_Strength2;TextIndicator_TB_Password_Strength3;TextIndicator_TB_Password_Strength4;TextIndicator_TB_Password_Strength5">
                                    </asp:PasswordStrength>
                                    
                                </p>
                                <p>
                                    New Password: 
                                    <asp:TextBox ID="tb_newPass" runat="server" Height="16px" oncopy="return false" onpaste="return false" TextMode="Password"></asp:TextBox>
                                    <asp:PasswordStrength ID="tb_newPass_PasswordStrength" runat="server" Enabled="True" MinimumLowerCaseCharacters="1" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="1" PreferredPasswordLength="12" RequiresUpperAndLowerCaseCharacters="True" StrengthStyles="TextIndicator_TB_Password_Strength1;TextIndicator_TB_Password_Strength2;TextIndicator_TB_Password_Strength3;TextIndicator_TB_Password_Strength4;TextIndicator_TB_Password_Strength5" TargetControlID="tb_newPass" TextStrengthDescriptions="Very Weak;Weak;Average;Strong;Very Strong" TextStrengthDescriptionStyles="TextIndicator_TB_Password_Strength1;TextIndicator_TB_Password_Strength2;TextIndicator_TB_Password_Strength3;TextIndicator_TB_Password_Strength4;TextIndicator_TB_Password_Strength5">
                                    </asp:PasswordStrength>
                                    Confirm Password: 
                                    <asp:TextBox ID="tb_confrimPass" runat="server" oncopy="return false" onpaste="return false" TextMode="Password"></asp:TextBox>
                                    <asp:PasswordStrength ID="tb_confrimPass_PasswordStrength" runat="server" Enabled="True" MinimumLowerCaseCharacters="1" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="1" PreferredPasswordLength="12" StrengthStyles="TextIndicator_TB_Password_Strength1;TextIndicator_TB_Password_Strength2;TextIndicator_TB_Password_Strength3;TextIndicator_TB_Password_Strength4;TextIndicator_TB_Password_Strength5" TargetControlID="tb_confrimPass" TextStrengthDescriptions="Very Weak;Weak;Average;Strong;Very Strong" TextStrengthDescriptionStyles="TextIndicator_TB_Password_Strength1;TextIndicator_TB_Password_Strength2;TextIndicator_TB_Password_Strength3;TextIndicator_TB_Password_Strength4;TextIndicator_TB_Password_Strength5">
                                    </asp:PasswordStrength>
                                </p>
                                <p>
                                    Sequrity Question 1: 
                                    <asp:DropDownList ID="dd_secque1" runat="server" Enabled="False" EnableTheming="True">
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
                                <p>
                                    Answer: 
                                    <asp:TextBox ID="tb_secans1" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                </p>
                                <p>
                                    Security Question 2: 
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
                                <p>
                                    Answer: 
                                    <asp:TextBox ID="tb_secans2" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                </p>
                                <p>
                                    Security Question 3: 
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
                                <p>
                                    Answer: 
                                    <asp:TextBox ID="tb_secans3" runat="server" Height="16px" oncopy="return false" onpaste="return false" Width="128px"></asp:TextBox>
                                     
                                    <asp:Label ID="lblStatus_ChgPwd" runat="server" Visible="False"></asp:Label>
                                </p>
                                <p>
                                    
                                    <asp:Button ID="btn_changepwd" runat="server" CssClass="auto-style3" OnClick="btn_changepwd_Click" Text="Change Password" />
                                </p>
                                <p>
                                    </p>
                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel2">
                            <HeaderTemplate>
                                SiteKey
                            </HeaderTemplate>
                            <ContentTemplate>
                                <br />
                                Security Question 1:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="Sec1DD_PersonalInformation" runat="server">
                                    <asp:ListItem Selected="True" Value="1">What was your childhood nickname? </asp:ListItem>
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
                                <br />
                                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_SecAns1_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Security Question 2:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="Sec2DD_PersonalInformation" runat="server">
                                    <asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
                                    <asp:ListItem Selected="True" Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
                                    <asp:ListItem Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
                                    <asp:ListItem Value="4">What is your oldest sibling&#39;s middle name?</asp:ListItem>
                                    <asp:ListItem Value="5">In what city does your nearest sibling live? </asp:ListItem>
                                    <asp:ListItem Value="6">In what city or town was your first job?</asp:ListItem>
                                    <asp:ListItem Value="7">What is your maternal grandmother&#39;s maiden name?</asp:ListItem>
                                    <asp:ListItem Value="8">What was your favorite place to visit as a child?</asp:ListItem>
                                    <asp:ListItem Value="9">What is the name of your favorite childhood teacher?</asp:ListItem>
                                    <asp:ListItem Value="10">What was the first concert you attended?</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_SecAns2_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                Security Question 3:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="Sec3DD_PersonalInformation" runat="server">
                                    <asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
                                    <asp:ListItem Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
                                    <asp:ListItem Selected="True" Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
                                    <asp:ListItem Value="4">What is your oldest sibling&#39;s middle name?</asp:ListItem>
                                    <asp:ListItem Value="5">In what city does your nearest sibling live? </asp:ListItem>
                                    <asp:ListItem Value="6">In what city or town was your first job?</asp:ListItem>
                                    <asp:ListItem Value="7">What is your maternal grandmother&#39;s maiden name?</asp:ListItem>
                                    <asp:ListItem Value="8">What was your favorite place to visit as a child?</asp:ListItem>
                                    <asp:ListItem Value="9">What is the name of your favorite childhood teacher?</asp:ListItem>
                                    <asp:ListItem Value="10">What was the first concert you attended?</asp:ListItem>
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
                                <asp:ImageButton ID="img_site1" runat="server" OnClick="img_site1_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site2" runat="server" OnClick="img_site2_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site3" runat="server" OnClick="img_site3_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site4" runat="server" OnClick="img_site4_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site5" runat="server" OnClick="img_site5_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site6" runat="server" OnClick="img_site6_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site7" runat="server" OnClick="img_site7_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site8" runat="server" OnClick="img_site8_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site9" runat="server" OnClick="img_site9_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site10" runat="server" OnClick="img_site10_Click" />
                                &nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:ImageButton ID="img_site11" runat="server" OnClick="img_site11_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site12" runat="server" OnClick="img_site12_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site13" runat="server" OnClick="img_site13_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site14" runat="server" OnClick="img_site14_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site15" runat="server" OnClick="img_site15_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site16" runat="server" OnClick="img_site16_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site17" runat="server" OnClick="img_site17_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site18" runat="server" OnClick="img_site18_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site19" runat="server" OnClick="img_site19_Click" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="img_site20" runat="server" OnClick="img_site20_Click" />
                                &nbsp;<br />Sitekey Hint:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_sitekeyhint_Cust" runat="server" oncopy="return false" onpaste="return false"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Label ID="lblStatus_SiteKey" runat="server" Visible="False"></asp:Label>
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnSetSiteKey" runat="server" OnClick="btnSetSiteKey_Click" Text="Set Password Recovery" />
                            </ContentTemplate>
                        </asp:TabPanel>
                    </asp:TabContainer>
                    <p>
                    </p>
                    <p>
                    </p>
                    <p>
                    </p>
                    <p>
                    </p>
                    <p>
                    </p>
                    <p>
                    </p>
                    <p>
                    </p>
                    <p>
                    </p>
                    <p>
                    </p>
                    <p>
                    </p>
                    <p>
                    </p>
                </p>
            </ContentTemplate>

        </asp:TabPanel>
    </asp:TabContainer>
    <p>
        <br /> 
    </p>
    <p>
        &nbsp;</p>
    <p>
    </p>
 
</asp:Content>
