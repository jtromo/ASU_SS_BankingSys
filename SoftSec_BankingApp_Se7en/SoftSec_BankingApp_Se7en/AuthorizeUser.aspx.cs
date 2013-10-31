using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SoftSec_BankingApp_Se7en.Models;
using log4net;

namespace SoftSec_BankingApp_Se7en
{
    public partial class AuthorizeUser : System.Web.UI.Page
    {
        private static readonly ILog Elog = LogManager.GetLogger("ExceptionFileAppender");

        private static Models.Tables.User objuser = new Models.Tables.User();
        private static int noAttempts = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx",false);
            }
            else
            {
                if (!IsPostBack)
                {
                    objuser = UserModel.GetUser(Session["userName"].ToString());
                    if (objuser.siteKeyVal == 0)
                    {
                        lblSiteKeyText.Text = "Please set your site key";
                        lblSiteKeyText.Visible = true;
                    }
                    else
                    {
                        SiteKey.ImageUrl = "./Images/SiteKeys/SiteKey" + objuser.siteKeyVal + ".jpg";
                        lblSiteKeyText.Text = objuser.siteKeyString;
                        lblSiteKeyText.Visible = true;
                    }
                    lblErrorMessage_Authorize.Visible = false;
                    Session["NoAttempts"] = 0;
                }
            }
        }

        protected void Btn_SignIn_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx",false);
            }
            else
            {
                bool serverSideValidation = false;
                try
                {
                    if (TB_Password.Text.ToString().Length > 0)
                    {
                        serverSideValidation = validateFromFields(TB_Password.Text.ToString());
                        if (serverSideValidation)
                        {
                            //Proceed with business logic here
                            objuser = UserModel.GetUser(Session["userName"].ToString());
                            if (objuser.lockoutTime.Value != null)
                            {
                                lblErrorMessage_Authorize.Text = "The User Account has been locked. Kindly try after 1 hour";
                                TB_Password.Text = "";
                                lblErrorMessage_Authorize.Visible = true;
                            }
                            else
                            {
                                //Valid User
                                if (LoginModel.LoginUser(Session["userName"].ToString(), TB_Password.Text.ToString()) > 0)
                                {
                                    bool status = UserModel.GetUserStatus(Session["userName"].ToString());
                                    string session = UserModel.GetUserSessionID(Session["userName"].ToString());

                                    if (!status || String.IsNullOrEmpty(session))
                                    {
                                        UserModel.UpdateUserActiveStatus(Session["userName"].ToString(), true);
                                        UserModel.UpdateUserSessionID(Session["userName"].ToString(), Session.SessionID.ToString());

                                    }
                                    else
                                    {
                                        if (session != Session.SessionID)
                                        {
                                            UserModel.UpdateUserSessionID(Session["userName"].ToString(), Session.SessionID.ToString());
                                        }
                                    }

                                    if (objuser.roleId == 2)
                                    {
                                        //External Individual

                                        Response.Redirect("ExternalUser.aspx", false);
                                    }
                                    else if (objuser.roleId == 3)
                                    {
                                        //External Merchant
                                        Response.Redirect("ExternalUser.aspx", false);
                                    }
                                    else if (objuser.roleId == 4)
                                    {
                                        //Internal_Regular
                                        Response.Redirect("InternalUser.aspx", false);
                                    }
                                    else if (objuser.roleId == 5)
                                    {
                                        //Internal_DeptManager
                                        Response.Redirect("InternalUser.aspx", false);
                                    }
                                    else if (objuser.roleId == 6)
                                    {
                                        //Internal_HigherManager
                                        Response.Redirect("InternalUser.aspx", false);
                                    }
                                    else if (objuser.roleId == 7 || objuser.roleId == 8)
                                    {
                                        //Internal_Admin || Superuser
                                        if (objuser.roleId == 7)
                                            Session["adminFlag"] = 1;
                                        else if (objuser.roleId == 8)
                                            Session["adminFlag"] = 0;
                                        else
                                            Session["adminFlag"] = -1;
                                        lblErrorMessage_Authorize.Visible = false;
                                        Response.Redirect("AdminHome.aspx", false);
                                    }
                                }
                                else
                                {
                                    //Check the number of attempts using the session object.
                                    if (Convert.ToInt32(Session["NoAttempts"].ToString()) >= 2)
                                    {
                                        //Lock User
                                        bool block = UserModel.UpdateUser(Session["userName"].ToString());
                                        if (block)
                                        {
                                            lblErrorMessage_Authorize.Text = "The User Account has been locked. Kindly try after 1 hour";
                                            TB_Password.Text = "";
                                            lblErrorMessage_Authorize.Visible = true;
                                        }
                                    }
                                    else
                                    {
                                        lblErrorMessage_Authorize.Text = "Invalid Password. Please try again (Max 3 Attempts)";
                                        TB_Password.Text = "";
                                        lblErrorMessage_Authorize.Visible = true;
                                        Session["NoAttempts"] = ++noAttempts;
                                    }
                                }
                            }
                        }
                        else
                        {
                            //Update the UI with error message.
                            //Check the number of attempts using the session object.
                            if (Convert.ToInt32(Session["NoAttempts"].ToString()) >= 2)
                            {
                                //Lock User
                                bool block = UserModel.UpdateUser(Session["userName"].ToString());
                                if (block)
                                {
                                    lblErrorMessage_Authorize.Text = "The User Account has been locked. Kindly try after 1 hour";
                                    TB_Password.Text = "";
                                    lblErrorMessage_Authorize.Visible = true;
                                }
                            }
                            else
                            {
                                lblErrorMessage_Authorize.Text = "Invalid Password. Please try again (Max 3 Attempts)";
                                TB_Password.Text = "";
                                lblErrorMessage_Authorize.Visible = true;
                                Session["NoAttempts"] = ++noAttempts;
                            }
                        }
                    }
                    else
                    {
                        lblErrorMessage_Authorize.Text = "Please enter the password";
                        TB_Password.Text = "";
                        lblErrorMessage_Authorize.Visible = true;
                    }

                }
                catch (Exception exp)
                {
                    Elog.Error("Exception occurred: " + exp.Message);
                    lblErrorMessage_Authorize.Text = "An unknown exception occured, please try again.";
                    TB_Password.Text = "";
                    lblErrorMessage_Authorize.Visible = true;
                }
            }
        }

        /// <summary>
        /// Validate the form fields inputs.
        /// </summary>
        /// <param name="strPassword">User password field text value</param>
        /// <returns>True if the text values are valid, false otherwise</returns>
        private bool validateFromFields(string strPassword)
        {
            try
            {
                bool bUserName = false;
                FieldValidator fieldValidator = new FieldValidator();
                string strUserName = fieldValidator.validate_password(strPassword);
                string strTemp = strUserName.Substring(strUserName.IndexOf('_')+1);
                string strPasswordStrength = strUserName.Substring(0, 1);
                if (strTemp.Equals("TRUE"))
                    bUserName = true;
                else
                    bUserName = false;
                if (bUserName)
                    return true;
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
        
    }
}