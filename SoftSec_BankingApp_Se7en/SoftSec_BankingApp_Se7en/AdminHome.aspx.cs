using log4net;
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
        private static readonly ILog Elog = LogManager.GetLogger("ExceptionFileAppender");

       static  List<DepartmentTransaction> currentDTransBeingDisplayed;
       static  DepartmentTransaction currentSlectedTrans;
       private static List<SecurityQuestion> lstQandA = null;
       private static String siteKeySelected = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                    hideRequestUI();

                    if (!IsPostBack)
                    {
                        tabAdmin.ActiveTabIndex = 0;
                        Models.Tables.User objUser = UserModel.GetUser(Session["userName"].ToString());
                        if (objUser.roleId == 7 || objUser.roleId == 8)
                        {
                            
                            img_site1.ImageUrl = "./Images/SiteKeys/SiteKey1.jpg";
                            img_site2.ImageUrl = "./Images/SiteKeys/SiteKey2.jpg";
                            img_site3.ImageUrl = "./Images/SiteKeys/SiteKey3.jpg";
                            img_site4.ImageUrl = "./Images/SiteKeys/SiteKey4.jpg";
                            img_site5.ImageUrl = "./Images/SiteKeys/SiteKey5.jpg";
                            img_site6.ImageUrl = "./Images/SiteKeys/SiteKey6.jpg";
                            img_site7.ImageUrl = "./Images/SiteKeys/SiteKey7.jpg";
                            img_site8.ImageUrl = "./Images/SiteKeys/SiteKey8.jpg";
                            img_site9.ImageUrl = "./Images/SiteKeys/SiteKey9.jpg";
                            img_site10.ImageUrl = "./Images/SiteKeys/SiteKey10.jpg";
                            img_site11.ImageUrl = "./Images/SiteKeys/SiteKey11.jpg";
                            img_site12.ImageUrl = "./Images/SiteKeys/SiteKey12.jpg";
                            img_site13.ImageUrl = "./Images/SiteKeys/SiteKey13.jpg";
                            img_site14.ImageUrl = "./Images/SiteKeys/SiteKey14.jpg";
                            img_site15.ImageUrl = "./Images/SiteKeys/SiteKey15.jpg";
                            img_site16.ImageUrl = "./Images/SiteKeys/SiteKey16.jpg";
                            img_site17.ImageUrl = "./Images/SiteKeys/SiteKey17.jpg";
                            img_site18.ImageUrl = "./Images/SiteKeys/SiteKey18.jpg";
                            img_site19.ImageUrl = "./Images/SiteKeys/SiteKey19.jpg";
                            img_site20.ImageUrl = "./Images/SiteKeys/SiteKey20.jpg";
                            if (Convert.ToInt16(Session["adminFlag"]) == 1)
                            {
                                //Set permission to view logs
                                //normal admin - view only admin level logs
                                //super user - view superuser + admin level logs in the grid view.
                            }
                        }
                        else
                        {
                            //Invalid User.
                            Response.Redirect("ExternalHomePage.aspx", false);
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }

        protected void modifyBT_Modify_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
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
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }

        }


        protected void detailsBT_Modify_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx",false);
            }
            else
            {
                checkSession();
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
                Response.Redirect("SessionTimeOut.aspx",false);
            }
            else
            {
                checkSession();
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
                Response.Redirect("SessionTimeOut.aspx",false);
            }
            else
            {
                checkSession();
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
                Response.Redirect("SessionTimeOut.aspx",false);
            }
            else
            {
                bool serverSideValidation1 = false;
                bool serverSideValidation2 = false;
                try
                {
                    checkSession();
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
                    Elog.Error("Exception occurred: " + exp.Message);
                }
            }
        }

        protected void tabAdmin_ActiveTabChanged(object sender, EventArgs e)
        {
            cleanFields();
            try
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx",false);
                }
                else
                {
                    checkSession();                    
                    if (tabAdmin.ActiveTabIndex == 3)
                    {
                       
                    }
                    else if (tabAdmin.ActiveTabIndex == 5)
                    {
                        //Check if the role has persmissions.
                        Models.Tables.User objUser = UserModel.GetUser(Session["userName"].ToString());
                        if (objUser.roleId == 7 || objUser.roleId == 8)
                        {
                            tb_emailview.Text = objUser.email;
                            tb_streetAddress.Text = objUser.Address.street1;
                            tb_city.Text = objUser.Address.city;
                            StateDD_Profile.SelectedValue = objUser.Address.state;
                            tb_ZipCode_Profile.Text = Convert.ToString(objUser.Address.zip);
                            tb_contactview.Text = objUser.phone;
                            tb_usernameview.Text = objUser.username;

                        }
                        else
                        {
                            //Invalid User.
                            //Redirect to the home page.
                            Response.Redirect("ExternalHomePage.aspx", false);
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }

        protected void cleanFields()
        {
            tb_FirstName_Emp.Text = "";
            tb_MidName_Emp.Text = "";
            tb_LastName_Emp.Text = "";
            tb_addr_editprofile.Text = "";
            tb_BirthYear_AddEmp.Text = "";
            tb_city.Text = "";
            tb_city_editProfile.Text = "";
            tb_City_Emp.Text = "";
            tb_confrimPass.Text = "";
            tb_contactedit.Text = "";
            tb_contactview.Text = "";
            tb_Email_Emp.Text = "";
            tb_emailedit.Text = "";
            tb_emailview.Text = "";
            tb_newPass.Text = "";
            tb_oldpwd.Text = "";
            tb_Phone_Emp.Text = "";
            tb_secans1.Text = "";
            tb_SecAns1_Cust.Text = "";
            tb_secans2.Text = "";
            tb_SecAns2_Cust.Text = "";
            tb_SecAns2_Cust.Text = "";
            tb_secans3.Text = "";
            tb_SecAns3_Cust.Text = "";
            tb_sitekeyhint_Cust.Text = "";
            tb_SSN_Cust.Text = "";
            tb_StreetAddr_Emp.Text = "";
            tb_streetAddress.Text = "";
            tb_usernameview.Text = "";
            tb_zip_editProfile.Text = "";
            tb_Zip_Emp.Text = "";
            tb_ZipCode_Profile.Text = "";
            userIdTb_Modify.Text = "";
            userNameLookUpTb.Text = "";
            userNameTb_Remove.Text = "";
            firstNameTextLb_Modify.Text = "";
            firstNameTextLb_Remove.Text = "";
            lastNameTextLb_Modify.Text = "";
            lastNameTextLb_Remove.Text = "";
            currentRoleTextLb_Modify.Text = "";
            currentRoleTextLb_Remove.Text = "";
            errorLabel.Text = "";
            errorLbModify.Text = "";
            Label1.Text = "";
            lbl_Logs.Text = "";
            reqErrorLb.Text = "";
            effectedUserValueLb.Text = "";
            initiatorValueLb.Text = "";
            fromDeptLb.Text = "";
            fromDeptValueLB.Text = "";
            toDeptLb.Text = "";
            toDeptValueLb.Text = "";
            lblStatus_SiteKey.Text = "";
            lblStatus_ChgPwd.Text = "";
            lblChaneProfile.Text = "";
            tab_EditProfile.Visible = false;
        }

        protected void FetchLogsBT_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx",false);
            }
            else
            {
                checkSession();
                bool serverSideValidation = false;
                //Fetch the logs, present in the middle of these two dates. Not more than 3 days difference is allowed in the dates.
                try
                {
                    serverSideValidation = true;
                    if (serverSideValidation)
                    {
                        //Proceed with business logic here
                        MailMessage mMailMessage = new MailMessage();
                        mMailMessage.From = new MailAddress("bankse7en@gmail.com");
                        mMailMessage.To.Add(new MailAddress("ushakanthkvp@gmail.com"));
                        mMailMessage.Subject = "System Logs" + DateTime.Now;
                        mMailMessage.Body = "PFA the System Logs you have requested.";
                        //Attachment at = new Attachment(Server.MapPath("~/Uploaded/txt.doc"));
                        Attachment at = new Attachment(Server.MapPath("~/Logs/Transactions.log"));
                        Attachment at1 = new Attachment(Server.MapPath("~/Logs/Exception.log"));
                        mMailMessage.Attachments.Add(at);
                        mMailMessage.Attachments.Add(at1);
                        mMailMessage.IsBodyHtml = true;
                        mMailMessage.Priority = MailPriority.High;
                        SmtpClient mSmtpClient = new SmtpClient();
                        mSmtpClient.EnableSsl = true;
                        mSmtpClient.Send(mMailMessage);
                        lbl_Logs.Text = "Logs have been sent to your email";
                    }
                    else
                    {
                        lbl_Logs.Text = "Please check the details you have keyed in";
                    }
                }
                catch (Exception exp)
                {
                    lbl_Logs.Text = "An unknown error has occured. Please try again in a few minutes.";
                    Elog.Error("Exception occurred: " + exp.Message);
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
                Elog.Error("Exception occurred: " + exp.Message);
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
                Elog.Error("Exception occurred: " + exp.Message);
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
                Elog.Error("Exception occurred: " + exp.Message);
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
                if (strMName.Length == 0)
                {
                    strMName = " ";
                }
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
                Elog.Error("Exception occurred: " + exp.Message);
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
                Elog.Error("Exception occurred: " + exp.Message);
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
                Elog.Error("Exception occurred: " + exp.Message);
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
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }
        
        protected void UserNameLookUpBT_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx",false);
            }
            else
            {
                checkSession();
                string username = userNameLookUpTb.Text.ToString();
                if (validateUserNameField(username))
                {
                    currentDTransBeingDisplayed = DepartmentTransactionModel.GetDepartmentTransactionsForUser(username);
                    if (currentDTransBeingDisplayed != null)
                    {
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
                        reqErrorLb.Text = "No transactions for this user";
                    }
                }
                else
                {
                    reqErrorLb.Text = "Please check the User name you have entered";
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
                if(currentSlectedTrans.roleOld == 4)
                    fromRoleValueLb.Text = "Regular Employee";
                if (currentSlectedTrans.roleOld == 5)
                    fromRoleValueLb.Text = "Department Manager";
                if (currentSlectedTrans.roleOld == 6)
                    fromRoleValueLb.Text = "Company Official";
                if (currentSlectedTrans.roleNew == 4)
                    toRoleValueLb.Text = "Regular Employee";
                if (currentSlectedTrans.roleNew == 5)
                    toRoleValueLb.Text = "Department Manager";
                if (currentSlectedTrans.roleNew == 6)
                    toRoleValueLb.Text = "Company Official";
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
                Response.Redirect("SessionTimeOut.aspx",false);
            }
            else
            {
                checkSession();
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
                Response.Redirect("SessionTimeOut.aspx",false);
            }
            else
            {
                checkSession();
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

        protected void bt_logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("ExternalHomePage.aspx");
        }

        protected void btnEditProfile_Click(object sender, EventArgs e)
        {
            try
            {
                tab_EditProfile.Visible = true;
                tab_EditProfile.ActiveTabIndex = 0;                
                tb_emailedit.Text = tb_emailview.Text;
                tb_addr_editprofile.Text = tb_streetAddress.Text;
                tb_city_editProfile.Text = tb_city.Text;
                StateDD_EditProfile.SelectedValue = StateDD_Profile.SelectedValue;
                tb_zip_editProfile.Text = tb_ZipCode_Profile.Text;
                tb_contactedit.Text = tb_contactview.Text;

                //Check if the user has set the site key value. IF yes, then dont show the site key tab panel.
                Models.Tables.User objUser = UserModel.GetUser(Session["userName"].ToString());               
                if (objUser.siteKeyVal > 0)
                {
                    tab_EditProfile.ActiveTabIndex = 0;
                    tab_EditProfile.Tabs[2].Visible = false;
                    tab_EditProfile.Tabs[1].Visible = true;
                    lstQandA = PasswordModel.GetSecurityQandA(Session["userName"].ToString());
                    dd_secque1.SelectedValue = Convert.ToString(lstQandA.First().questionId);
                    dd_secque2.SelectedValue = Convert.ToString(lstQandA.ElementAt(1).questionId);
                    dd_secque3.SelectedValue = Convert.ToString(lstQandA.Last().questionId);
                    dd_secque1.Enabled = false;
                    dd_secque2.Enabled = false;
                    dd_secque3.Enabled = false;
                }
                else
                {
                    tab_EditProfile.ActiveTabIndex = 2;
                    tab_EditProfile.Tabs[1].Visible = false;
                    tab_EditProfile.Tabs[2].Visible = true;                    
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }

        protected void btn_changesettings_profile_Click(object sender, EventArgs e)
        {
            try
            {
                bool serverSideValidation = false;
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                    Models.Tables.User objUser = UserModel.GetUser(Session["userName"].ToString());
                    if (objUser.roleId == 7 || objUser.roleId == 8)
                    {
                        serverSideValidation = validateFromFields_editProfile(tb_emailedit.Text.ToString(), tb_addr_editprofile.Text.ToString(),
                                            tb_city_editProfile.Text.ToString(), tb_zip_editProfile.Text.ToString(), tb_contactedit.Text.ToString(), "jaffa");
                        if (serverSideValidation)
                        {
                            //Proceed with business logic here
                            bool success = UserModel.UpdateUser(Session["userName"].ToString(), tb_emailedit.Text.ToString(), tb_addr_editprofile.Text.ToString(), 
                                    tb_city_editProfile.Text.ToString(), StateDD_EditProfile.SelectedValue.ToString(), tb_zip_editProfile.Text.ToString(), 
                                        tb_contactedit.Text.ToString());
                            if (success)
                            {
                                lblChaneProfile.Text = "Update Successful";
                                lblChaneProfile.Visible = true;
                            }
                            else
                            {
                                lblChaneProfile.Text = "Update Unsuccessful";
                                lblChaneProfile.Visible = true;
                            }
                        }
                        else
                        {
                            //Update the UI with error message.
                            lblChaneProfile.Text = "Invalid Entries";
                            lblChaneProfile.Visible = true;
                        }
                    }
                    else
                    {
                        //Invalid User 
                        Response.Redirect("ExternalHomePage.apsx", false);
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }

        /// <summary>
        /// Validate the fields in the form while submiting
        /// </summary>
        /// <param name="strEmail">Email of the user</param>
        /// <param name="strStreetAdd">Street address of the user</param>
        /// <param name="strCity">City of the user</param>
        /// <param name="strZipCode">Zip code of the address of the user</param>
        /// <param name="strPhone">Phone number of the user</param>
        /// <param name="strName">Nick name of the user</param>
        /// <returns>True if all the fields are valid, otherwise false</returns>
        private bool validateFromFields_editProfile(string strEmail, string strStreetAdd, string strCity, string strZipCode, string strPhone, string strName)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bEmail = fieldValidator.validate_Email(strEmail);
                bool bStAdd = fieldValidator.validate_streetAddress(strStreetAdd);
                bool bCity = fieldValidator.validate_Names(strCity);
                bool bZip = fieldValidator.validate_ZipAccCrdPhn(strZipCode, 5);
                bool bPhn = fieldValidator.validate_ZipAccCrdPhn(strPhone, 10);
                bool bNick = fieldValidator.validate_Names(strName);

                if (bEmail && bStAdd && bPhn && bNick)
                    return true;
                else
                    return false;
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        protected void btn_changepwd_Click(object sender, EventArgs e)
        {
            try
            {
                bool serverSideValidation = false;
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                    //Check if the user has set the site key value. IF yes, then dont show the site key tab panel.
                    Models.Tables.User objUser = UserModel.GetUser(Session["userName"].ToString());
                    if (objUser.roleId == 7 || objUser.roleId == 8)
                    {
                        Dictionary<int, string> dictAns = new Dictionary<int, string>();
                        dictAns.Add(1, tb_secans1.Text.ToString());
                        dictAns.Add(2, tb_secans2.Text.ToString());
                        dictAns.Add(3, tb_secans3.Text.ToString());
                        serverSideValidation = validateFromFields(tb_oldpwd.Text.ToString(), dictAns, tb_newPass.Text.ToString(), tb_confrimPass.Text.ToString());
                        if (serverSideValidation)
                        {
                            //Proceed with business logic here
                            if (LoginModel.LoginUser(Session["userName"].ToString(), tb_oldpwd.Text.ToString()) > 0)
                            {
                                string strAns1 = (lstQandA.First().answer).ToLower();
                                string strAns2 = (lstQandA.ElementAt(1).answer).ToLower();
                                string strAns3 = (lstQandA.Last().answer).ToLower();

                                if (tb_secans1.Text.ToLower().Equals(strAns1) && tb_secans2.Text.ToLower().Equals(strAns2)
                                        && tb_secans3.Text.ToLower().Equals(strAns3))
                                {
                                    if (tb_newPass.Text.Equals(tb_confrimPass.Text) && !(tb_newPass.Text.Equals(tb_oldpwd.Text.ToString())))
                                    {
                                        bool success = PasswordModel.ChangePwd(Session["userName"].ToString(), tb_newPass.Text.ToString());
                                        if (success)
                                        {
                                            lblStatus_ChgPwd.Text = "Password Changed Successfully";
                                            lblStatus_ChgPwd.Visible = true;
                                        }
                                        else
                                        {
                                            lblStatus_ChgPwd.Text = "Password Changed Failed, Please try again";
                                            lblStatus_ChgPwd.Visible = true;
                                        }
                                    }
                                    else
                                    {
                                        lblStatus_ChgPwd.Text = "passwords dont match";
                                        lblStatus_ChgPwd.Visible = true;
                                    }
                                }
                                else
                                {
                                    lblStatus_ChgPwd.Text = "Answers Dont match";
                                    lblStatus_ChgPwd.Visible = true;
                                }
                            }
                            else
                            {
                                lblStatus_ChgPwd.Text = "Old password Dont match";
                                lblStatus_ChgPwd.Visible = true;
                            }
                        }
                        else
                        {
                            //Update the UI with error message.
                            lblStatus_ChgPwd.Text = "Failed to fetch pwd info";
                            lblStatus_ChgPwd.Visible = true;
                        }
                    }
                    else
                    {
                        //Invalid user
                        Response.Redirect("ExternalHomePage.aspx", false);
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }

        /// <summary>
        /// Validate the fields in the form while submiting
        /// </summary>
        /// <param name="strOldPassword">Old Password of the user</param>
        /// <param name="dictAns">Dictonary of user questions and answers</param>
        /// <param name="strNewPassword">New Password of the user</param>
        /// <param name="strConfrimPassword">Re-Confirm the new password</param>
        /// <returns></returns>
        private bool validateFromFields(string strOldPassword, Dictionary<int, string> dictAns, string strNewPassword, string strConfrimPassword)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                string strOldPass = fieldValidator.validate_password(strOldPassword);
                string strTemp = strOldPass.Substring(strOldPass.IndexOf('_') + 1);
                bool bOldPass = false;
                if (strTemp.Equals("TRUE"))
                {
                    bOldPass = true;
                }
                string strNewPass = fieldValidator.validate_password(strNewPassword);
                strTemp = strNewPass.Substring(strNewPass.IndexOf('_') + 1);
                bool bNewPass = false;
                if (strTemp.Equals("TRUE"))
                {
                    bNewPass = true;
                }
                string strConfirmPass = fieldValidator.validate_password(strConfrimPassword);
                strTemp = strConfirmPass.Substring(strConfirmPass.IndexOf('_') + 1);
                bool bConfPass = false;
                if (strTemp.Equals("TRUE"))
                {
                    bConfPass = true;
                }
                int iCtr = 0;
                List<int> iKeys = new List<int>(dictAns.Keys);
                foreach (int i in iKeys)
                {
                    bool bAns = fieldValidator.validate_UserName(dictAns[i]);
                    if (bAns)
                        iCtr++;
                }
                if (bOldPass && bNewPass && bConfPass && iCtr == 3)
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
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }


        protected void tab_EditProfile_ActiveTabChanged(object sender, EventArgs e)
        {
            try
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                    //Check if the user has set the site key value. IF yes, then dont show the site key tab panel.
                    Models.Tables.User objUser = UserModel.GetUser(Session["userName"].ToString());
                    if (objUser.roleId == 7 || objUser.roleId == 8)
                    {
                        if (tab_EditProfile.ActiveTabIndex == 2)
                        {
                            if (objUser.siteKeyVal > 0)
                            {
                                Sec1DD_PersonalInformation.Enabled = false;
                                tb_SecAns1_Cust.Enabled = false;
                                Sec2DD_PersonalInformation.Enabled = false;
                                tb_SecAns2_Cust.Enabled = false;
                                Sec3DD_PersonalInformation.Enabled = false;
                                tb_SecAns3_Cust.Enabled = false;
                                tb_SSN_Cust.Enabled = false;
                                tb_sitekeyhint_Cust.Enabled = false;
                                btnSetSiteKey.Enabled = false;
                            }
                            else
                            {
                                Sec1DD_PersonalInformation.Enabled = true;
                                tb_SecAns1_Cust.Enabled = true;
                                Sec2DD_PersonalInformation.Enabled = true;
                                tb_SecAns2_Cust.Enabled = true;
                                Sec3DD_PersonalInformation.Enabled = true;
                                tb_SecAns3_Cust.Enabled = true;
                                tb_SSN_Cust.Enabled = true;
                                tb_sitekeyhint_Cust.Enabled = true;
                                btnSetSiteKey.Enabled = true;
                            }
                        }
                    }
                    else
                    {
                        //Invalid User
                        Response.Redirect("ExternalHomePage.aspx",false);
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                
            }
        }

        #region Images
        protected void deselect_All_Images()
        {
            siteKeySelected = "";
            img_site1.BorderStyle = BorderStyle.None;
            img_site2.BorderStyle = BorderStyle.None;
            img_site3.BorderStyle = BorderStyle.None;
            img_site4.BorderStyle = BorderStyle.None;
            img_site5.BorderStyle = BorderStyle.None;
            img_site6.BorderStyle = BorderStyle.None;
            img_site7.BorderStyle = BorderStyle.None;
            img_site8.BorderStyle = BorderStyle.None;
            img_site9.BorderStyle = BorderStyle.None;
            img_site10.BorderStyle = BorderStyle.None;
            img_site11.BorderStyle = BorderStyle.None;
            img_site12.BorderStyle = BorderStyle.None;
            img_site13.BorderStyle = BorderStyle.None;
            img_site14.BorderStyle = BorderStyle.None;
            img_site15.BorderStyle = BorderStyle.None;
            img_site16.BorderStyle = BorderStyle.None;
            img_site17.BorderStyle = BorderStyle.None;
            img_site18.BorderStyle = BorderStyle.None;
            img_site19.BorderStyle = BorderStyle.None;
            img_site20.BorderStyle = BorderStyle.None;            
        }

        protected void img_site1_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "1";
            img_site1.BorderColor = System.Drawing.Color.DarkBlue;
            img_site1.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site2_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "2";
            img_site2.BorderColor = System.Drawing.Color.DarkBlue;
            img_site2.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site3_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "3";
            img_site3.BorderColor = System.Drawing.Color.DarkBlue;
            img_site3.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site4_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "4";
            img_site4.BorderColor = System.Drawing.Color.DarkBlue;
            img_site4.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site5_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "5";
            img_site5.BorderColor = System.Drawing.Color.DarkBlue;
            img_site5.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site6_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "6";
            img_site6.BorderColor = System.Drawing.Color.DarkBlue;
            img_site6.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site7_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "1";
            img_site1.BorderColor = System.Drawing.Color.DarkBlue;
            img_site1.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site8_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "8";
            img_site8.BorderColor = System.Drawing.Color.DarkBlue;
            img_site8.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site9_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "9";
            img_site9.BorderColor = System.Drawing.Color.DarkBlue;
            img_site9.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site10_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "10";
            img_site10.BorderColor = System.Drawing.Color.DarkBlue;
            img_site10.BorderStyle = BorderStyle.Solid;
        }       

        protected void img_site11_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "11";
            img_site11.BorderColor = System.Drawing.Color.DarkBlue;
            img_site11.BorderStyle = BorderStyle.Solid;
        }        

        protected void img_site12_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "12";
            img_site12.BorderColor = System.Drawing.Color.DarkBlue;
            img_site12.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site13_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "13";
            img_site13.BorderColor = System.Drawing.Color.DarkBlue;
            img_site13.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site14_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "14";
            img_site14.BorderColor = System.Drawing.Color.DarkBlue;
            img_site14.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site15_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "15";
            img_site15.BorderColor = System.Drawing.Color.DarkBlue;
            img_site15.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site16_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "16";
            img_site16.BorderColor = System.Drawing.Color.DarkBlue;
            img_site16.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site17_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "17";
            img_site17.BorderColor = System.Drawing.Color.DarkBlue;
            img_site17.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site18_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "18";
            img_site18.BorderColor = System.Drawing.Color.DarkBlue;
            img_site18.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site19_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "19";
            img_site19.BorderColor = System.Drawing.Color.DarkBlue;
            img_site19.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site20_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "20";
            img_site20.BorderColor = System.Drawing.Color.DarkBlue;
            img_site20.BorderStyle = BorderStyle.Solid;
        }
        #endregion

        protected void btnSetSiteKey_Click(object sender, EventArgs e)
        {
            try
            {
                bool serversideValidation = false;
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                    //Check if the user has set the site key value. IF yes, then dont show the site key tab panel.
                    Models.Tables.User objUser = UserModel.GetUser(Session["userName"].ToString());
                    if (objUser.roleId == 7 || objUser.roleId == 8)
                    {                        
                        //Check if all the security questions are different.
                        List<Int32> lstSelectedQ = new List<Int32>();
                        lstSelectedQ.Add(Convert.ToInt32(Sec1DD_PersonalInformation.SelectedValue));
                        lstSelectedQ.Add(Convert.ToInt32(Sec2DD_PersonalInformation.SelectedValue));
                        lstSelectedQ.Add(Convert.ToInt32(Sec3DD_PersonalInformation.SelectedValue));
                        if (lstSelectedQ.Distinct().Count() == 3)
                        {
                            Dictionary<int, string> dictAns = new Dictionary<int, string>();
                            dictAns.Add(1, tb_SecAns1_Cust.Text.ToString());
                            dictAns.Add(2, tb_SecAns2_Cust.Text.ToString());
                            dictAns.Add(3, tb_SecAns3_Cust.Text.ToString());
                            serversideValidation = validateFromFields(dictAns, tb_SSN_Cust.Text.ToString(), tb_sitekeyhint_Cust.Text.ToString());
                            if (serversideValidation)
                            {
                                bool success= UserModel.UpdateUserSiteKeyAndQA(Session["userName"].ToString(), dictAns, tb_SSN_Cust.Text.ToString(), siteKeySelected, tb_sitekeyhint_Cust.Text.ToString());
                                if (success)
                                {
                                    lblStatus_SiteKey.Text = "Values Updated Successfully";
                                    btnSetSiteKey.Enabled = false;
                                    lblStatus_SiteKey.Visible = true;
                                }
                                else
                                {
                                    //Update Failure
                                    lblStatus_SiteKey.Text = "Update Failed. Try Again";
                                    lblStatus_SiteKey.Visible = true;
                                }
                            }
                            else
                            {
                                //Invalid Entries.
                                lblStatus_SiteKey.Text = "Invalid Entries";
                                lblStatus_SiteKey.Visible = true;
                            }
                        }
                        else
                        {
                            //Please select different questions.
                            lblStatus_SiteKey.Text = "Please select different questions";
                            lblStatus_SiteKey.Visible = true;
                        }
                    }
                    else
                    {
                        //Invalid USer.
                        Response.Redirect("ExternalHomePage.aspx", false);
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }

        /// <summary>
        /// Validate the fields in the form while submiting
        /// </summary>
        /// <param name="strOldPassword">Old Password of the user</param>
        /// <param name="dictAns">Dictonary of user questions and answers</param>
        /// <param name="strNewPassword">New Password of the user</param>
        /// <param name="strConfrimPassword">Re-Confirm the new password</param>
        /// <returns></returns>
        private bool validateFromFields(Dictionary<int, string> dictAns, string strSSN, string strSiteKey)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                
                int iCtr = 0;
                List<int> iKeys = new List<int>(dictAns.Keys);
                foreach (int i in iKeys)
                {
                    bool bAns = fieldValidator.validate_UserName(dictAns[i]);
                    if (bAns)
                        iCtr++;
                }
                bool bssn = fieldValidator.validate_ZipAccCrdPhn(strSSN, 9);
                bool bstrSiteKey = fieldValidator.validate_UserName(strSiteKey);
                if (iCtr == 3 && bssn && bstrSiteKey)
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
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        protected void btn_ReqAll_Click(object sender, EventArgs e)
        {
            currentDTransBeingDisplayed = DepartmentTransactionModel.AllRequests();
            if (currentDTransBeingDisplayed == null)
            {
                reqErrorLb.Text = "No Pending Requests";
            }
            else
            {
                RequestsGridV.DataSource = currentDTransBeingDisplayed;
                RequestsGridV.DataBind();
            }
        }
        protected void checkSession()
        {
            string session = UserModel.GetUserSessionID(Session["userName"].ToString());
            if (session != Session.SessionID)
            {
                Session.Abandon();
                Response.Redirect("ExternalHomePage.aspx");
            }

        }

        protected void RoleDD_AddEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoleDD_AddEmp.SelectedItem.Text == "Admin")
            {
                DeptDD_AddEmp.SelectedIndex = 0;
                DeptDD_AddEmp.Enabled = false;
            }
            else
            {
                DeptDD_AddEmp.Enabled = true;
            }
        }
        
    }
}