using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftSec_BankingApp_Se7en
{
    public partial class AuthorizeUser : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            SiteKey.ImageUrl = "./Images/SiteKeys/SiteKey1.jpg";
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

        protected void Btn_ForgotPassword_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("ForgotPassword.aspx");
            }
            catch (Exception exp)
            {
                //Log Exception here
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
                string strTemp = strUserName.Substring(strUserName.IndexOf('_'));
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