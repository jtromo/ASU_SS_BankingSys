<%@ Page Title="" Language="C#" MasterPageFile="~/Final.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="SoftSec_BankingApp_Se7en.WebForm2" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </p>
    <asp:TabContainer ID="tabAdmin" runat="server" ActiveTabIndex="4" Height="800px" Width="858px" OnActiveTabChanged="tabAdmin_ActiveTabChanged">

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
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="userNameTb_Remove" runat="server" Height="15px" style="margin-top: 0px" TabIndex="1"></asp:TextBox>
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
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="userIdTb_Modify" runat="server" Height="15px" style="margin-top: 0px" TabIndex="1"></asp:TextBox>
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
        <asp:TabPanel ID="RequestTabPanel" runat="server" HeaderText="Requests">
            <ContentTemplate>
                &nbsp;<br />
                <asp:Label ID="Label2" runat="server" Text="deptID:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="deptIDlookupTB" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="deptIDLookUpBT" runat="server" Text="LookUp" OnClick="deptIDLookUpBT_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="reqErrorLb" runat="server" Width="300px"></asp:Label>
                <br />
                &nbsp;<asp:Label ID="Label3" runat="server" Text="UserName:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="userNameLookUpTb" runat="server"></asp:TextBox>

                &nbsp;&nbsp;
                <asp:Button ID="UserNameLookUpBT" runat="server" Text="LookUp" OnClick="UserNameLookUpBT_Click" />
                <asp:GridView ID="RequestsGridV" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" Height="145px" Width="840px" OnSelectedIndexChanged="GridViewItemSelected">
                </asp:GridView>

                <br />
                <asp:Label ID="EffectedUserLb" runat="server" Text="User Effected:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="effectedUserValueLb" runat="server"></asp:Label>
                <br />
                <asp:Label ID="InitiatorLb" runat="server" Text="Initiator:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="initiatorValueLb" runat="server"></asp:Label>
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
