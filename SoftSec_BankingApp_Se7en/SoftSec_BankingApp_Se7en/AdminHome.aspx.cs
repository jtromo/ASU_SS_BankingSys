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

        protected void Add_Click(object sender, EventArgs e)
        {
            bool serverSideValidation = false;
            //Note : If an user ( be it admin / managers / CEO ) is going to create a new user ( Employee of Bank - Any role ),
            //then we will set default username and password, and let the user reset his/her password later.
            try
            {
               serverSideValidation = validateFromFields(firstNameTb_AddEmp.Text.ToString(), MiddleNameTb_AddEmp.Text.ToString(), 
                                        lastNameTb_AddEmp.Text.ToString(),emailTb_AddEmp.Text.ToString(), phoneTb_AddEmp.Text.ToString());
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