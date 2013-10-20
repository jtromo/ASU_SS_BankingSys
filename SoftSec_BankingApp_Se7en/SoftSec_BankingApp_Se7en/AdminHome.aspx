<%@ Page Title="" Language="C#" MasterPageFile="~/Final.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="SoftSec_BankingApp_Se7en.WebForm2" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </p>
    <asp:TabContainer ID="tabAdmin" runat="server" ActiveTabIndex="0" Height="800px" Width="858px" OnActiveTabChanged="tabAdmin_ActiveTabChanged">

        <asp:TabPanel runat="server" HeaderText="Add Employee" ID="addEmpTabPanel" Height="600px" Width="850px">
            <ContentTemplate>

                                <br />
                                Employee Details: (You need to have the employee with you while adding him)<br />
                                First Name:&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_FirstName_Emp" runat="server"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp; Middle Name:&nbsp;
                                <asp:TextBox ID="tb_MidName_Emp" runat="server"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp; Last Name:&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_LastName_Emp" runat="server" Height="22px"></asp:TextBox>
                                <br />
                                Street Address:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_StreetAddr_Emp" runat="server"></asp:TextBox>
                                <br />
                                City :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_City_Emp" runat="server"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Zip:
                                <asp:TextBox ID="tb_Zip_Emp" runat="server"></asp:TextBox>
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
                                <asp:TextBox ID="tb_Email_Emp" runat="server"></asp:TextBox>
                                <br />
                                Contact:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_Phone_Emp" runat="server"></asp:TextBox>
                                <br />
                                Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_UserName_AddEmp" runat="server"></asp:TextBox>
                                <br />
                                Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_Password_AddEmp" runat="server"></asp:TextBox>
                                <br />
                                Repeat Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_ConfPassword_AddEmp" runat="server"></asp:TextBox>
                                <br />
                                Security Question 1:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="Sec1DD_PersonalInformation_AddEmp" runat="server">
                                    <asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
                                    <asp:ListItem Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
                                    <asp:ListItem Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_SecAns1_AddEmp" runat="server"></asp:TextBox>
                                <br />
                                Security Question 2:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="Sec2DD_PersonalInformation_AddEmp" runat="server">
                                    <asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
                                    <asp:ListItem Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
                                    <asp:ListItem Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_SecAns2_AddEmp" runat="server"></asp:TextBox>
                                <br />
                                Security Question 3:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="Sec3DD_PersonalInformation_AddEmp" runat="server">
                                    <asp:ListItem Value="1">What was your childhood nickname? </asp:ListItem>
                                    <asp:ListItem Value="2">In what city did you meet your spouse/significant other?</asp:ListItem>
                                    <asp:ListItem Value="3">What is the name of your favorite childhood friend? </asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_SecAns3_AddEmp" runat="server"></asp:TextBox>
                                <br />
                                Social Security Number:&nbsp;
                                <asp:TextBox ID="tb_SSN_AddEmp" runat="server"></asp:TextBox>
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
                                <asp:TextBox ID="tb_sitekeyhint_AddEmp" runat="server"></asp:TextBox>
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
                                <asp:TextBox ID="tb_BirthYear_AddEmp" runat="server" Height="16px" Width="76px">YYYY</asp:TextBox>
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
                &nbsp;<asp:Label ID="userIdLb_Remove" runat="server" Text="User ID"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="userIdTb_Remove" runat="server" Height="15px" style="margin-top: 0px" TabIndex="1"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="detailsBT_Remove" runat="server" OnClick="detailsBT_Remove_Click" Text="View Details" TabIndex="2" />
                &nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />&nbsp;<asp:Label ID="firstNameLB_Remove" runat="server" Text="First Name"></asp:Label>
                <asp:Label ID="firstNameTextLb_Remove" runat="server" style="margin-left: 63px; margin-right: 0px;" Width="200px"></asp:Label>
                &nbsp;<br />&nbsp;
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
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="userIdTb_Modify" runat="server" Height="15px" style="margin-top: 0px" TabIndex="1"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="detailsBT_Modify" runat="server" Text="View Details" OnClick="detailsBT_Modify_Click" style="height: 26px" TabIndex="2" />
                &nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />&nbsp;<asp:Label ID="firstNameLB_Modify" runat="server" Text="First Name"></asp:Label>
                <asp:Label ID="firstNameTextLb_Modify" runat="server" Width="200px" style="margin-left: 63px; margin-right: 0px;"></asp:Label>
                &nbsp;<br /> 
                <asp:Label ID="lastNameLb_Modify" runat="server" Text="Last Name"></asp:Label>
                <asp:Label ID="lastNameTextLb_Modify" runat="server" Width="200px" style="margin-left: 64px"></asp:Label>
                &nbsp;&nbsp;<br />&nbsp;<asp:Label ID="currentRoleLb_Modify" runat="server" Text="Current Role"></asp:Label>
                <asp:Label ID="currentRoleTextLb_Modify" runat="server" Height="18px" style="margin-left: 55px; margin-right: 0px" Width="200px"></asp:Label>
                <br />
                <br />
                &nbsp;
                <asp:Label ID="newRoleLb_Modify" runat="server" Text="New Role"></asp:Label>
                &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="1">Regular</asp:ListItem>
                    <asp:ListItem Value="2">Dept. Manager</asp:ListItem>
                    <asp:ListItem Value="3">Vice President</asp:ListItem>
                    <asp:ListItem Value="4">President</asp:ListItem>
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
                <asp:TextBox ID="startYearTb_SysLog" runat="server" Width="35px" TabIndex="2"></asp:TextBox>
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
                <asp:TextBox ID="endYearTb_SysLog" runat="server" Width="35px" TabIndex="5"></asp:TextBox>
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
    </asp:TabContainer>
    <p>
        <br /> 
    </p>
    <p>
        &nbsp;</p>
    <p>
    </p>
 
</asp:Content>
