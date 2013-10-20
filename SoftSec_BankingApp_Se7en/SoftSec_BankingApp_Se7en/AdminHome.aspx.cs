using SoftSec_BankingApp_Se7en.Models;
using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftSec_BankingApp_Se7en
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Convert.ToInt16(Session["adminFlag"]) == 1)
                {
                    //Set permission to view logs
                    //normal admin - view only admin level logs
                    //super user - view superuser + admin level logs in the grid view.
                }                
            }
        }

        protected void modifyBT_Modify_Click(object sender, EventArgs e)
        {
            //Confirm this operation using a message box.
            //If YES then continue.
            //Clicking modify will alter the role in the DB and return the success/ failure. 
            //Depending on this the message is displayed and the fields are cleared.
        }

        protected void detailsBT_Modify_Click(object sender, EventArgs e)
        {
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields(userIdTb_Modify.Text.ToString());
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

            }
        }

        protected void detailsBT_Remove_Click(object sender, EventArgs e)
        {
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields(userIdTb_Remove.Text.ToString());
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

            }
        }

        protected void removeBt_Remove_Click(object sender, EventArgs e)
        {
            //Confirm this operation using a message box.
            //If YES then continue.
            //Clicking modify will remove the user in the DB and return the success/ failure. 
            //Depending on this the message is displayed and the user is deleted.
        }

        protected void btn_AddEmp_Click(object sender, EventArgs e)
        {
            bool serverSideValidation1 = false;
            bool serverSideValidation2 = false;
            try
            {
                serverSideValidation1 = validateFromFields(tb_FirstName_Emp.Text.ToString(), tb_MidName_Emp.Text.ToString(), tb_LastName_Emp.Text.ToString()
                    , tb_Email_Emp.Text.ToString(), tb_StreetAddr_Emp.Text.ToString(), tb_City_Emp.Text.ToString(), tb_Phone_Emp.Text.ToString()
                    , tb_Zip_Emp.Text.ToString());
                serverSideValidation2 = validateFromFields(tb_UserName_AddEmp.Text.ToString(), tb_Password_AddEmp.Text.ToString(), tb_ConfPassword_AddEmp.Text.ToString()
                    , tb_SecAns1_AddEmp.Text.ToString(), tb_SecAns2_AddEmp.Text.ToString(), tb_SecAns3_AddEmp.Text.ToString(), tb_SSN_AddEmp.Text.ToString()
                    , tb_sitekeyhint_AddEmp.Text.ToString(), tb_BirthYear_AddEmp.Text.ToString());
                if (serverSideValidation1 && serverSideValidation2)
                {
                    User userForName = new User();
                    userForName = UserModel.GetUser(tb_UserName_AddEmp.Text.ToString());
                    if (userForName != null)
                    {

                        Label1.Visible = true;
                        Label1.Text = "User name already Exists";
                    }
                    else
                    {

                        string passwordForUser = tb_Password_AddEmp.Text.ToString();
                        string confirmPassword = tb_ConfPassword_AddEmp.Text.ToString();
                        if (passwordForUser.Equals(confirmPassword))
                        {
                            User userToCreate = new User();
                            userToCreate.firstName = tb_FirstName_Emp.Text.ToString();
                            userToCreate.middleName = tb_MidName_Emp.Text.ToString();
                            userToCreate.lastName = tb_LastName_Emp.Text.ToString();
                            userToCreate.email = tb_Email_Emp.Text.ToString();
                            userToCreate.departmentId = Convert.ToInt32(DeptDD_AddEmp.SelectedValue);
                            userToCreate.roleId = Convert.ToInt32(RoleDD_AddEmp.SelectedValue);
                            Address addressForUser = new Address();
                            addressForUser.street1 = tb_StreetAddr_Emp.Text.ToString();
                            addressForUser.city = tb_City_Emp.Text.ToString();
                            addressForUser.state = StateDD_Emp.Text.ToString();
                            addressForUser.country = "US";
                            addressForUser.zip = Convert.ToInt32(tb_Zip_Emp.Text);
                            userToCreate.phone = tb_Phone_Emp.Text.ToString();
                            userToCreate.username = tb_UserName_AddEmp.Text.ToString();


                            List<SecurityQuestion> securityQuestionsForUser = new List<SecurityQuestion>();
                            SecurityQuestion securityQuestionForUser1 = new SecurityQuestion();
                            securityQuestionForUser1.questionId = Sec1DD_PersonalInformation_AddEmp.SelectedIndex;
                            securityQuestionForUser1.answer = tb_SecAns1_AddEmp.Text.ToString();
                            securityQuestionsForUser.Add(securityQuestionForUser1);
                            SecurityQuestion securityQuestionForUser2 = new SecurityQuestion();
                            securityQuestionForUser2.questionId = Sec2DD_PersonalInformation_AddEmp.SelectedIndex;
                            securityQuestionForUser2.answer = tb_SecAns2_AddEmp.Text.ToString();
                            securityQuestionsForUser.Add(securityQuestionForUser2);
                            SecurityQuestion securityQuestionForUser3 = new SecurityQuestion();
                            securityQuestionForUser3.questionId = Sec3DD_PersonalInformation_AddEmp.SelectedIndex;
                            securityQuestionForUser3.answer = tb_SecAns3_AddEmp.Text.ToString();
                            securityQuestionsForUser.Add(securityQuestionForUser3);
                            userToCreate.socialSecurityNumber = tb_SSN_AddEmp.Text.ToString();
                           // userToCreate.siteKeyVal = Convert.ToInt32(siteKeySelected);
                            userToCreate.siteKeyString = tb_sitekeyhint_AddEmp.Text.ToString();
                            string userDOB = monthDD_PersonalInformation_AddEmp.Text.ToString() + "/" + dayDD_PersonalInformation_AddEmp.Text.ToString() + "/" + tb_BirthYear_AddEmp.Text.ToString();
                            userToCreate.dateOfBirth = userDOB;
                            bool userCreated = UserModel.CreateEmployee(userToCreate, passwordForUser, addressForUser, securityQuestionsForUser);
                            if (userCreated)
                            {
                                Label1.Visible = true;
                                Label1.Text = "User successfully created";
                            }
                            else
                            {
                                Label1.Visible = true;
                                Label1.Text = "User could Not be created";
                            }
                        }
                        else
                        {
                            Label1.Visible = true;
                            Label1.Text = "Passwords Do Not Match";

                        }

                    }


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


        protected void tabAdmin_ActiveTabChanged(object sender, EventArgs e)
        {
            if (tabAdmin.ActiveTabIndex == 3)
            {
                sysLog_GridView.ShowHeader = true;
            }
        }

        protected void FetchLogsBT_Click(object sender, EventArgs e)
        {
            bool serverSideValidation = false;
            //Fetch the logs, present in the middle of these two dates. Not more than 3 days difference is allowed in the dates.
            try
            {
                serverSideValidation = validateFromFields(startYearTb_SysLog.Text.ToString(),endYearTb_SysLog.Text.ToString());
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
                bool bUserName = fieldValidator.validate_Names(strUserName);
                
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


    }
}