using SoftSec_BankingApp_Se7en.Models;
using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftSec_BankingApp_Se7en
{
    public partial class WebForm2 : System.Web.UI.Page
    {
       static  List<DepartmentTransaction> currentDTransBeingDisplayed;
       static  DepartmentTransaction currentSlectedTrans;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx");
            }
            else
            {
                hideRequestUI();

                if (!IsPostBack)
                {
                    FieldValidator objField = new FieldValidator();
                    if (objField.validate_UserName(Session["userName"].ToString()))
                    {
                        if (Convert.ToInt16(Session["adminFlag"]) == 1)
                        {
                            //Set permission to view logs
                            //normal admin - view only admin level logs
                            //super user - view superuser + admin level logs in the grid view.
                        }
                    }                    
                }
            }
        }

        protected void modifyBT_Modify_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx");
            }
            else
            {
                User checkforUSer = UserModel.GetUser(userIdTb_Modify.Text.ToString());
                if (checkforUSer != null)
                {
                    int newRoleID = Convert.ToInt32(DropDownList1.SelectedValue);
                    string deptTransDesc = "Admin escalted" + checkforUSer.username + "from role" + checkforUSer.roleId.ToString() + "to role" + newRoleID.ToString();
                    int roleEscalationReqPlacedasTransaction = -1;
                    roleEscalationReqPlacedasTransaction = DepartmentTransactionModel.MakeRoleEscalation("Admin", checkforUSer.username, Convert.ToInt32(checkforUSer.roleId), newRoleID, deptTransDesc, 0, "");
                    if (roleEscalationReqPlacedasTransaction != -1)
                    {
                        bool roleModified = DepartmentTransactionModel.AcceptDepartmentTransaction(roleEscalationReqPlacedasTransaction);
                        if (roleModified)
                        {
                            errorLbModify.Text = "User access level succesfully modified";
                        }
                        else
                        {
                            errorLbModify.Text = "Could not modify user level";
                        }

                    }
                    else
                    {

                        errorLbModify.Text = "Could not place modify request";
                    }
                }
                else
                {

                    errorLbModify.Text = "No user exists";
                }
            }

        }


        protected void detailsBT_Modify_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx");
            }
            else
            {
                bool serverSideValidation = false;
                try
                {
                    serverSideValidation = validateFromFields(userIdTb_Modify.Text.ToString());
                    if (serverSideValidation)
                    {
                        User checkforUSer = UserModel.GetUser(userIdTb_Modify.Text.ToString());
                        if (checkforUSer != null)
                        {
                            if (checkforUSer.roleId > 3)
                            {

                                errorLbModify.Text = "has access";
                                firstNameTextLb_Modify.Text = checkforUSer.firstName;
                                lastNameTextLb_Modify.Text = checkforUSer.lastName;

                                int userrole = Convert.ToInt32(checkforUSer.roleId);
                                switch (userrole)
                                {
                                    case 2: currentRoleTextLb_Modify.Text = "External Individual";
                                        break;
                                    case 3: currentRoleTextLb_Modify.Text = "External Merchant";
                                        break;
                                    case 4: currentRoleTextLb_Modify.Text = "Internal Regular";
                                        break;
                                    case 5: currentRoleTextLb_Modify.Text = "Internal Dept Mgr";
                                        break;
                                    case 6: currentRoleTextLb_Modify.Text = "Internal Higher Mgr";
                                        break;
                                    case 7: currentRoleTextLb_Modify.Text = "Admin";
                                        break;
                                    case 8: currentRoleTextLb_Modify.Text = "Super User";
                                        break;
                                    default: currentRoleTextLb_Modify.Text = "Invalid Role";
                                        break;


                                }
                            }
                            else
                            {
                                errorLbModify.Text = "You do not have access for this user";
                            }

                        }
                        else
                        {

                            errorLbModify.Text = "User does not exist";
                        }
                    }
                    else
                    {
                        errorLbModify.Text = "Please check what you have entered";
                    }
                }
                catch (Exception exp)
                {

                }
            }
        }

        protected void detailsBT_Remove_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx");
            }
            else
            {
                bool serverSideValidation = false;
                try
                {
                    serverSideValidation = validateFromFields(userNameTb_Remove.Text.ToString());
                    if (serverSideValidation)
                    {

                        User checkforUSer = UserModel.GetUser(userNameTb_Remove.Text.ToString());
                        if (checkforUSer != null)
                        {
                            if (checkforUSer.roleId > 3)
                            {
                                errorLabel.Text = "User Details:";
                                firstNameTextLb_Remove.Text = checkforUSer.firstName;
                                lastNameTextLb_Remove.Text = checkforUSer.lastName;
                                int userrole = Convert.ToInt32(checkforUSer.roleId);
                                switch (userrole)
                                {
                                    case 2: currentRoleTextLb_Remove.Text = "External Individual";
                                        break;
                                    case 3: currentRoleTextLb_Remove.Text = "External Merchant";
                                        break;
                                    case 4: currentRoleTextLb_Remove.Text = "Internal Regular Employee";
                                        break;
                                    case 5: currentRoleTextLb_Remove.Text = "Internal Department Manager";
                                        break;
                                    case 6: currentRoleTextLb_Remove.Text = "Internal Higher Manager";
                                        break;
                                    case 7: currentRoleTextLb_Remove.Text = "Admin";
                                        break;
                                    case 8: currentRoleTextLb_Remove.Text = "Super User";
                                        break;
                                    default: currentRoleTextLb_Remove.Text = "Invalid Role";
                                        break;
                                }
                            }
                            else
                            {
                                errorLabel.Text = "You do not have access for this user";
                            }

                        }
                        else
                        {

                            errorLabel.Text = "Please check the username you typed in.";
                        }
                    }
                    else
                    {
                        //Update the UI with error message.
                        errorLabel.Text = "Please check the username you typed in.";
                    }
                }
                catch (Exception exp)
                {

                }
            }
        }

        protected void removeBt_Remove_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx");
            }
            else
            {
                bool userRemoved = false;
                userRemoved = UserModel.RemoveUser(userNameTb_Remove.Text.ToString());
                if (userRemoved == true)
                {
                    errorLabel.Text = "User succesfully Removed";
                }
                else
                {
                    errorLabel.Text = "User could not be removed";
                }
            }
        }

        protected void btn_AddEmp_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx");
            }
            else
            {
                bool serverSideValidation1 = false;
                bool serverSideValidation2 = false;
                try
                {
                    serverSideValidation1 = validateFromFields(tb_FirstName_Emp.Text.ToString(), tb_MidName_Emp.Text.ToString(), tb_LastName_Emp.Text.ToString()
                        , tb_Email_Emp.Text.ToString(), " ", " ", tb_Phone_Emp.Text.ToString() , tb_Zip_Emp.Text.ToString());
                    FieldValidator fieldValidator = new FieldValidator();
                    serverSideValidation2 = fieldValidator.validate_ZipAccCrdPhn(tb_BirthYear_AddEmp.Text.ToString(), 4);
                    if (serverSideValidation1 && serverSideValidation2)
                    {
                        //Generating Username
                        string usernameGenerated = generateUsername(tb_FirstName_Emp.Text.ToString(), tb_LastName_Emp.Text.ToString());
                        string passwordGenerated = generatePassword();
                        User userForName = new User();
                        userForName = UserModel.GetUser(usernameGenerated);
                        while (userForName != null)
                        {
                            usernameGenerated = generateUsername(tb_FirstName_Emp.Text.ToString(), tb_LastName_Emp.Text.ToString());
                            userForName = UserModel.GetUser(usernameGenerated);
                        }
                        User userToCreate = new User();
                        userToCreate.firstName = tb_FirstName_Emp.Text.ToString();
                        userToCreate.middleName = tb_MidName_Emp.Text.ToString();
                        userToCreate.lastName = tb_LastName_Emp.Text.ToString();
                        userToCreate.email = tb_Email_Emp.Text.ToString();
                        userToCreate.departmentId = Convert.ToInt32(DeptDD_AddEmp.SelectedValue);
                        userToCreate.roleId = Convert.ToInt32(RoleDD_AddEmp.SelectedValue);
                        userToCreate.isActive = true;
                        Address addressForUser = new Address();
                        addressForUser.firstName = userToCreate.firstName;
                        addressForUser.lastName = userToCreate.lastName;
                        addressForUser.country = "US";
                        addressForUser.street1 = tb_StreetAddr_Emp.Text.ToString();
                        addressForUser.city = tb_City_Emp.Text.ToString();
                        addressForUser.state = StateDD_Emp.Text.ToString();
                        addressForUser.zip = Convert.ToInt32(tb_Zip_Emp.Text);                            
                        userToCreate.phone = tb_Phone_Emp.Text.ToString();
                        userToCreate.username = usernameGenerated;
                        string userDOB = monthDD_PersonalInformation_AddEmp.Text.ToString() + "/" + dayDD_PersonalInformation_AddEmp.Text.ToString() + "/" + tb_BirthYear_AddEmp.Text.ToString();
                        bool userCreated = UserModel.CreateEmployee(userToCreate, passwordGenerated, "", userDOB, addressForUser, null);
                        if (userCreated)
                        {
                            //Mailing employee
                            MailMessage mMailMessage = new MailMessage();
                            mMailMessage.From = new MailAddress("bankse7en@gmail.com");
                            mMailMessage.To.Add(new MailAddress(tb_Email_Emp.Text.ToString()));
                            mMailMessage.Subject = "New Employee information";
                            string bodyOfMail = "You have been added as a New Employee to Bank of Se7en. Following are";
                            bodyOfMail += " your details: <br> Username: " + usernameGenerated + "<br> Password: " + passwordGenerated;
                            bodyOfMail += "<br> Please login to the system and make sure you add security questions and a sitekey.<br>";
                            bodyOfMail += "Regards, <br> BankofSe7en";                              
                            mMailMessage.Body = bodyOfMail;
                            mMailMessage.IsBodyHtml = true;
                            mMailMessage.Priority = MailPriority.Normal;
                            SmtpClient mSmtpClient = new SmtpClient();
                            mSmtpClient.EnableSsl = true;
                            mSmtpClient.Send(mMailMessage);
                            Label1.Visible = true;
                            Label1.Text = "Employee added successfully\nUsername and Password have been mailed to the Employee";                            
                        }
                        else
                        {
                            Label1.Visible = true;
                            Label1.Text = "There was an unfortunate error in processing. Please try again";
                        }
                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Please check the information you entered. It does not seem to be right.";
                    }
                }
                catch (Exception exp)
                {
                    //Log Exception here
                }
            }
        }

        protected void tabAdmin_ActiveTabChanged(object sender, EventArgs e)
        {
            if (tabAdmin.ActiveTabIndex == 3)
            {
                sysLog_GridView.ShowHeader = true;
            }
        }

        protected void FetchLogsBT_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx");
            }
            else
            {
                bool serverSideValidation = false;
                //Fetch the logs, present in the middle of these two dates. Not more than 3 days difference is allowed in the dates.
                try
                {
                    serverSideValidation = validateFromFields(startYearTb_SysLog.Text.ToString(), endYearTb_SysLog.Text.ToString());
                    if (serverSideValidation)
                    {
                        //Proceed with business logic here
                    }
                    else
                    {
                        //Update the UI with error message.
                    }
                }
                catch (Exception exp)
                {
                    //Log Exception here
                }
            }

        }

        /// <summary>
        /// Validate the form fields
        /// </summary>
        /// <param name="strFName">First Name of Employee</param>
        /// <param name="strMName">Middle Name of Employee</param>
        /// <param name="strLName">Last Name of Employee</param>
        /// <param name="strEmail">Mail ID</param>
        /// <param name="strPhone">Phone Number</param>
        /// <returns>True, if all the fields are valid</returns>
        private bool validateFromFields(string strFName,string strMName, string strLName, string strEmail,string strPhone)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bFName = fieldValidator.validate_Names(strFName);
                bool bMName = fieldValidator.validate_Names(strMName);
                bool bLName = fieldValidator.validate_Names(strLName);
                bool bEmail = fieldValidator.validate_Email(strEmail);
                bool bPhone = fieldValidator.validate_ZipAccCrdPhn(strPhone, 10);

                if (bFName && bMName && bLName 
                        && bEmail && bPhone)
                    return true;
                else                
                    return false;
                
            }
            catch (Exception exp)
            {
                //Log Exception Here
                return false;
            }
        }

        /// <summary>
        /// Validate the form fields
        /// </summary>
        /// <param name="strUserName">User Name of Employee</param>
        /// <returns>True, if the fields are valid; otherwise false</returns>
        private bool validateFromFields(string strUserName)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bUserName = fieldValidator.validate_UserName(strUserName);
                
                if (bUserName)
                    return true;
                else
                    return false;
            }
            catch (Exception exp)
            {
                //Log Exception Here
                return false;
            }
        }

        /// <summary>
        /// Validate the form fields
        /// </summary>
        /// <param name="strUserName">User Name</param>
        /// <param name="strPassword">Password</param>
        /// <param name="strRe_Password">Re- Enter Password</param>
        /// <param name="strSecAns1">First Security question's answer</param>
        /// <param name="strSecAns2">Second Security question's answer</param>
        /// <param name="strSecAns3">Third Security question's answer</param>
        /// <param name="strSSN">SSN of user</param>
        /// <param name="strSiteKey">Site Key chosen by user</param>
        /// <param name="strBirthYear">Birth Year of user</param>
        /// <returns>True if all the fields are valid, false otherwise</returns>
        private bool validateFromFields(string strUserName, string strPassword, string strRe_Password, string strSecAns1,
                                            string strSecAns2, string strSecAns3, string strSSN, string strSiteKey, string strBirthYear)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bUName = fieldValidator.validate_UserName(strUserName);
                string strPass = fieldValidator.validate_password(strPassword);
                string strTemp = strPass.Substring(strPass.IndexOf('_') + 1);
                bool bPass = false;
                if (strTemp.Equals("TRUE"))
                    bPass = true;
                string strRePass = fieldValidator.validate_password(strRe_Password);
                strTemp = strRePass.Substring(strRePass.IndexOf('_') + 1);
                bool bRePass = false;
                if (strTemp.Equals("TRUE"))
                    bRePass = true;

                bool bSec1 = fieldValidator.validate_Names(strSecAns1);
                bool bSec2 = fieldValidator.validate_Names(strSecAns2);
                bool bSec3 = fieldValidator.validate_Names(strSecAns3);
                bool bSSN = fieldValidator.validate_ZipAccCrdPhn(strSSN, 9);
                bool bSiteKey = fieldValidator.validate_UserName(strSiteKey);
                bool bbirthYear = fieldValidator.validate_ZipAccCrdPhn(strBirthYear, 4);

                if (bUName && bPass && bRePass && bSec1 && bSec2 && bSec3 && bSSN && bSiteKey && bbirthYear)
                    return true;
                else
                    return false;
            }
            catch (Exception exp)
            {
                //Log Exception Here
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strFName"></param>
        /// <param name="strMName"></param>
        /// <param name="strLName"></param>
        /// <param name="strEmail"></param>
        /// <param name="strStreetAddr"></param>
        /// <param name="strCity"></param>
        /// <param name="strPhone"></param>
        /// <param name="strZipCode"></param>
        /// <returns></returns>
        private bool validateFromFields(string strFName, string strMName, string strLName, string strEmail,
                                            string strStreetAddr, string strCity, string strPhone, string strZipCode)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bFName = fieldValidator.validate_Names(strFName);
                bool bMName = fieldValidator.validate_Names(strMName);
                bool bLName = fieldValidator.validate_Names(strLName);
                bool bEmail = fieldValidator.validate_Email(strEmail);
                bool bStrAdd = fieldValidator.validate_streetAddress(strStreetAddr);
                bool bCity = fieldValidator.validate_Names(strCity);
                bool bPhn = fieldValidator.validate_ZipAccCrdPhn(strPhone, 10);
                bool bZip = fieldValidator.validate_ZipAccCrdPhn(strZipCode, 5);
                if (bFName && bMName && bLName && bEmail && bStrAdd && bCity && bPhn && bZip)
                    return true;
                else
                    return false;
            }
            catch (Exception exp)
            {
                //Log Exception Here
                return false;
            }
        }


        /// <summary>
        /// Validate the form fields
        /// </summary>
        /// <param name="strStartYear">Start year value</param>
        /// <param name="strEndYear">End year value</param>
        /// <returns>True, if the years entered are valid : otherwise false</returns>
        private bool validateFromFields(string strStartYear,string strEndYear)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bStartYear = fieldValidator.validate_ZipAccCrdPhn(strStartYear,4);
                bool bEndYear = fieldValidator.validate_ZipAccCrdPhn(strEndYear, 4);
                if (bStartYear && bEndYear)
                    return true;
                else
                    return false;
            }
            catch (Exception exp)
            {
                //Log Exception Here
                return false;
            }
        }

        private bool validateUserNameField(string username)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool userNamevalidation = fieldValidator.validate_UserName(username);
                if (userNamevalidation)
                {
                    return true;
                }
                else {
                    return false;
                }
                
            }
            catch (Exception exp)
            {
                //Log Exception Here
                return false;
            }
        }

        private bool validateDeptField(string deptID)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool deptValidation = fieldValidator.validate_TransID(deptID);
                if (deptValidation)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception exp)
            {
                //Log Exception Here
                return false;
            }
        }

        protected void deptIDLookUpBT_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx");
            }
            else
            {
                string deptID = deptIDlookupTB.Text.ToString();
                if (validateDeptField(deptID))
                {
                    currentDTransBeingDisplayed = DepartmentTransactionModel.GetTransactionsForDepartment(Convert.ToInt32(deptID));
                    if (currentDTransBeingDisplayed.Count > 0)
                    {

                        RequestsGridV.DataSource = currentDTransBeingDisplayed;
                        RequestsGridV.DataBind();

                    }
                    else
                    {

                        reqErrorLb.Text = "No transactions on this dept";
                    }
                }
                else
                {
                    reqErrorLb.Text = "please check the dept ID you have entered";
                }
            }
        }

        protected void UserNameLookUpBT_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx");
            }
            else
            {
                string username = userNameLookUpTb.Text.ToString();
                if (validateUserNameField(username))
                {
                    currentDTransBeingDisplayed = DepartmentTransactionModel.GetDepartmentTransactionsForUser(username);
                    if (currentDTransBeingDisplayed.Count > 0)
                    {

                        RequestsGridV.DataSource = currentDTransBeingDisplayed;
                        RequestsGridV.DataBind();

                    }
                    else
                    {

                        reqErrorLb.Text = "No transactions for this user";
                    }
                }
                else
                {
                    reqErrorLb.Text = "please check the User name you have entered";
                }
            }
        }

        protected void GridViewItemSelected(object sender, EventArgs e)
        {   
            int selectedIndex = RequestsGridV.SelectedIndex;
            currentSlectedTrans = currentDTransBeingDisplayed.ElementAt(selectedIndex);
            hideRequestUI();
            if (currentSlectedTrans.type == 1) {
                //Role escalation Req
                effectedUserValueLb.Text = currentSlectedTrans.usernameEffected;
                initiatorValueLb.Text = currentSlectedTrans.usernameInitiated;
                fromRoleValueLb.Text = currentSlectedTrans.roleOld.ToString();
                toRoleValueLb.Text = currentSlectedTrans.roleNew.ToString();
                showRoleReqUI();

            }
            else if (currentSlectedTrans.type == 2) { 
            //Dept change Req
                effectedUserValueLb.Text = currentSlectedTrans.usernameEffected;
                initiatorValueLb.Text = currentSlectedTrans.usernameInitiated;
                fromDeptValueLB.Text = currentSlectedTrans.fromDepartmentId.ToString();
                toDeptValueLb.Text = currentSlectedTrans.toDepartmentId.ToString();
                showDeptChangeReqUI();
            }

        }

        protected void hideRequestUI() { 
        EffectedUserLb.Visible=false;
        effectedUserValueLb.Visible = false;
        InitiatorLb.Visible = false;
        initiatorValueLb.Visible = false;
        toDeptLb.Visible = false;
        toDeptValueLb.Visible = false;
        fromDeptLb.Visible = false;
        fromDeptValueLB.Visible = false;
        fromRoleLb.Visible = false;
        fromRoleValueLb.Visible = false;
        toRoleLb.Visible = false;
        toRoleValueLb.Visible = false;
        approveRequestBT.Visible = false;
        rejectReqBT.Visible = false;


        }

        protected void showRoleReqUI() {
            EffectedUserLb.Visible = true;
            effectedUserValueLb.Visible = true;
            InitiatorLb.Visible = true;
            initiatorValueLb.Visible = true;
            toDeptLb.Visible = false;
            toDeptValueLb.Visible = false;
            fromDeptLb.Visible = false;
            fromDeptValueLB.Visible = false;
            fromRoleLb.Visible = true;
            fromDeptValueLB.Visible = true;
            toRoleLb.Visible = true;
            toRoleValueLb.Visible = true;
            approveRequestBT.Visible = true;
            rejectReqBT.Visible = true;
        
        }

        protected void showDeptChangeReqUI()
        {
            EffectedUserLb.Visible = true;
            effectedUserValueLb.Visible = true;
            InitiatorLb.Visible = true;
            initiatorValueLb.Visible = true;
            toDeptLb.Visible = true;
            toDeptValueLb.Visible = true;
            fromDeptLb.Visible = true;
            fromDeptValueLB.Visible = true;
            fromRoleLb.Visible = false;
            fromDeptValueLB.Visible = false;
            toRoleLb.Visible = false;
            toRoleValueLb.Visible = false;
            approveRequestBT.Visible = true;
            rejectReqBT.Visible = true;

        }

        protected void approveRequestBT_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx");
            }
            else
            {
                int currentTransID = currentSlectedTrans.id;
                if (currentSlectedTrans.status == 1)
                {
                    bool isapproved = DepartmentTransactionModel.AcceptDepartmentTransaction(currentTransID);
                    if (isapproved)
                    {
                        reqErrorLb.Text = "Request succesfully approved";
                    }
                    else
                    {
                        reqErrorLb.Text = "Request could not be approved";
                    }
                }
                else
                {
                    reqErrorLb.Text = "Decision already made";
                }
            }
        }

        protected void rejectReqBT_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx");
            }
            else
            {
                int currentTransID = currentSlectedTrans.id;
                if (currentSlectedTrans.status == 1)
                {
                    bool isrejected = DepartmentTransactionModel.RejectDepartmentTransaction(currentTransID);
                    if (isrejected)
                    {
                        reqErrorLb.Text = "Request succesfully rejected";
                    }
                    else
                    {
                        reqErrorLb.Text = "Request could not be rejected";
                    }
                }
                else
                {
                    reqErrorLb.Text = "Decision already made";
                }
            }
        }

        protected string generateUsername(string firstName,string lastName)
        {
            string username = "";
            if ((firstName.Length < 2) || (lastName.Length < 5))
            {
                Random rand = new Random();
                username = firstName + lastName + rand.Next(10000000); 
            }
            else 
            {
                Random rand = new Random();
                username = firstName.Substring(0, 2) + lastName.Substring(0, 5) + rand.Next(1000);
            }
            return username;
        }

        protected string generatePassword()
        {
            Random rand = new Random();
            string password = "Ss" + rand.Next(1000000) + "q" + "#";
            return password;
        }
    }
}