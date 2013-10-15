using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SoftSec_BankingApp_Se7en.Models;

namespace SoftSec_BankingApp_Se7en
{
    public partial class ExternalHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                TB_UserName.Text = "";
                TB_ZipCode.Text = "";
            }
            catch (Exception exp)
            {
                //Log Exception here
            }
        }

        protected void Btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                TB_UserName.Text = "";
                TB_ZipCode.Text = "";
            }
            catch (Exception exp)
            {
                //Log exception here
            }
        }

        protected void Btn_SignIn_Click(object sender, EventArgs e)
        {
            bool serverSideValidation = false;
            try
            {
                Response.Redirect("AuthorizeUser.aspx");
                //Validating user name and zip code
                serverSideValidation = validateFromFields(TB_UserName.Text.ToString(), TB_ZipCode.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    LoginModel lm = new LoginModel();
                    if (lm.UserExists(TB_UserName.Text, Convert.ToInt32(TB_ZipCode)))
                    {
                        Response.Redirect("ExternalUser.aspx");
                    }
                    else
                    {
                        Response.Redirect("ExternalHomePage.aspx");
                    }
                }
                else
                {
                    //Update the UI with error message.
                }
            }
            catch (Exception Exp)
            {
                //Log Exception here
            }
        }

        /// <summary>
        /// Validate the form fields inputs.
        /// </summary>
        /// <param name="strUserName">User name field text value</param>
        /// <param name="zipCode">Zip Code field text value</param>
        /// <returns>True if the text values are valid, false otherwise</returns>
        private bool validateFromFields(string strUserName, string zipCode)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool buserName = fieldValidator.validate_UserName(strUserName);
                bool bZipCode = fieldValidator.validate_ZipAccCrdPhn(zipCode, 5);
                if (buserName && bZipCode)
                    return true;
                else
                {
                    return false;
                }
            }
            catch(Exception exp){
                //Log Exception Here
                return false;
            }
        }
    }
}