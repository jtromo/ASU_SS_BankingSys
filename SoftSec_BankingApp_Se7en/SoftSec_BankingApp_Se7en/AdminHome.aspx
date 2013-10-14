<%@ Page Title="" Language="C#" MasterPageFile="~/Final.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="SoftSec_BankingApp_Se7en.WebForm2" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </p>
    <asp:TabContainer ID="tabAdmin" runat="server" ActiveTabIndex="2" Height="400px" Width="858px" OnActiveTabChanged="tabAdmin_ActiveTabChanged">

        <asp:TabPanel runat="server" HeaderText="Add Employee" ID="addEmpTabPanel" Height="600px" Width="850px">
            <ContentTemplate>
                <br />
                <asp:Label ID="firstnameLB" runat="server" Text="First Name"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="firstNameTb_AddEmp" runat="server" TabIndex="1"></asp:TextBox>
                <br />
                <asp:Label ID="lastnameLB" runat="server" Text="Last Name"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="lastNameTb_AddEmp" runat="server" TabIndex="2"></asp:TextBox>
                <br />
                <asp:Label ID="MiddlenameLB" runat="server" Text="Middle Name"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="MiddleNameTb_AddEmp" runat="server" TabIndex="3"></asp:TextBox>
                <br />
                <asp:Label ID="emailLB" runat="server" Text="EMAIL"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:TextBox ID="emailTb_AddEmp" runat="server" TabIndex="4"></asp:TextBox>
                <br />
                <asp:Label ID="phoneLB" runat="server" Text="Phone #"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox ID="phoneTb_AddEmp" runat="server" TabIndex="5"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="AddEmployeeBt" runat="server" OnClick="Add_Click" Text="Add" TabIndex="6" />
                <br />
                <br />
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
                &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                <asp:TextBox ID="newRoleTb_Modify" runat="server" Height="15px" style="margin-left: 40px" TabIndex="3"></asp:TextBox>
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
