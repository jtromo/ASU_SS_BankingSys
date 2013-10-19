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
                if (!IsPostBack)
                {
                    TB_UserName.Text = "";
                    TB_ZipCode.Text = "";
                    lblErrorMessage.Visible = false;
                }
            }
            catch (Exception exp)
            {
                //Log Exception here
            }
        }


        protected void Btn_SignIn_Click(object sender, EventArgs e)
        {
            bool serverSideValidation = false;
            try
            {
                lblErrorMessage.Visible = false;
                //Validating user name and zip code
                serverSideValidation = validateFromFields(TB_UserName.Text.ToString(), TB_ZipCode.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    if (LoginModel.UserExists(TB_UserName.Text.ToString(), Convert.ToInt32(TB_ZipCode.Text.ToString())))
                    {
                        Session["userName"] = TB_UserName.Text.ToString();
                        Response.Redirect("AuthorizeUser.aspx",false);
                    }
                    else
                    {
                        //Update UI with appropriate error message
                        TB_UserName.Text = "";
                        TB_ZipCode.Text = "";
                        lblErrorMessage.Text = "Invalid USerName or ZipCode. Please Try again";
                        lblErrorMessage.Visible = true;                        
                    }
                }
                else
                {
                    //Update the UI with error message.
                    TB_UserName.Text = "";
                    TB_ZipCode.Text = "";
                    lblErrorMessage.Text = "Invalid USerName or ZipCode. Please Try again";
                    lblErrorMessage.Visible = true;     
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