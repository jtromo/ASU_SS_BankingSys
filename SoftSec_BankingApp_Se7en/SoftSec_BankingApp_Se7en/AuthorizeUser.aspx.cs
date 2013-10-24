﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SoftSec_BankingApp_Se7en.Models;

namespace SoftSec_BankingApp_Se7en
{
    public partial class AuthorizeUser : System.Web.UI.Page
    {
        private static Models.Tables.User objuser = new Models.Tables.User();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                objuser = UserModel.GetUser(Session["userName"].ToString());
                SiteKey.ImageUrl = "./Images/SiteKeys/SiteKey" + objuser.siteKeyVal + ".jpg";
                lblErrorMessage_Authorize.Visible = false;
            }
        }

        protected void Btn_SignIn_Click(object sender, EventArgs e)
        {
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields(TB_Password.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    //Place the logic for comparing the salts with the password entered
                    // From James: The salt/hash will not be accessable outside the database. Need to Use the login model
                    //if (TB_Password.Text.ToString().Equals(objuser.salt.ToString()))
                    //{
                        //Valid User
                    if (LoginModel.LoginUser(Session["userName"].ToString(), TB_Password.Text.ToString()) > 0)
                    {
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
                        lblErrorMessage_Authorize.Text = "Invalid Password. Please try again (Max 3 Attempts)";
                        TB_Password.Text = "";
                        lblErrorMessage_Authorize.Visible = true;
                    }
                }
                else
                {
                    //Update the UI with error message.
                    lblErrorMessage_Authorize.Text = "Invalid Password. Please try again (Max 3 Attempts)";
                    TB_Password.Text = "";
                    lblErrorMessage_Authorize.Visible = true;
                }
            }
            catch (Exception exp)
            {
                //Log Exception here
                lblErrorMessage_Authorize.Text = "An unknown exception occured, please try again.";
                TB_Password.Text = "";
                lblErrorMessage_Authorize.Visible = true;
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
                //Log Exception Here
                return false;
            }
        }
        
    }
}