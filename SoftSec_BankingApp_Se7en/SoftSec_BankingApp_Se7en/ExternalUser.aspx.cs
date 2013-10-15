using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftSec_BankingApp_Se7en
{
    public partial class ExternalUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_maketransferoutside_Click(object sender, EventArgs e)
        {
            //Transfer Money to Accounts in other the bank
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields(tb_amountoutside.Text.ToString(), tb_lastnameoutside.Text.ToString(), 
                                            tb_emailoutside.Text.ToString(), tb_usercardno.Text.ToString(), tb_securitycodeoutside.Text.ToString());
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

        protected void btn_maketransinside_Click(object sender, EventArgs e)
        {
            //Transfer Money to Accounts within the bank
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields(tb_amount.Text.ToString(), tb_recepient.Text.ToString(),
                                            tb_lastname.Text.ToString(), tb_zip.Text.ToString(), tb_card.Text.ToString(), tb_securitycode.Text.ToString());
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

        protected void btn_maketransbetween_Click(object sender, EventArgs e)
        {
            //Transfer Money within accounts of the same user.
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields(tb_amountbetween.Text.ToString());
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

        protected void btn_changesettings_profile_Click(object sender, EventArgs e)
        {
            //Edit the user profile information here.
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields_editProfile(tb_emailedit.Text.ToString(), tb_addr_editprofile.Text.ToString(),
                                        tb_city_editProfile.Text.ToString(), tb_zip_editProfile.Text.ToString(), tb_contactedit.Text.ToString(), tb_nicknameedit.Text.ToString());
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

        protected void btn_cardsubmitpayment_Click(object sender, EventArgs e)
        {
            //Make a payment on behalf of the customer
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields(tb_cardnum.Text.ToString(), tb_customername.Text.ToString(), tb_amount_CheckPayment.Text.ToString());
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
        /// Validate the fields in the form while submiting.
        /// </summary>
        /// <param name="strAmount">Amount involved in the transfer</param>
        /// <param name="strAccountNum">Account number of the recepient</param>
        /// <param name="strLName">Last Name of the recepient</param>
        /// <param name="strZipCode">Zip Code of the recepient</param>
        /// <param name="strCardNum">Card number of the initiator</param>
        /// <param name="strSecCode">Security code of the card</param>
        /// <returns>True, if all the fields are validated. Otherwise false</returns>
        private bool validateFromFields(string strAmount, string strAccountNum, string strLName, string strZipCode, string strCardNum, string strSecCode)
        {
            try
            {                
                FieldValidator fieldValidator = new FieldValidator();
                bool bAmt = fieldValidator.validate_Amount(strAmount);
                bool bAccNum = fieldValidator.validate_ZipAccCrdPhn(strAccountNum, 12);
                bool bLName = fieldValidator.validate_Names(strLName);
                bool bZip = fieldValidator.validate_ZipAccCrdPhn(strZipCode, 5);
                bool bCard = fieldValidator.validate_ZipAccCrdPhn(strCardNum, 16);
                bool bSCode = fieldValidator.validate_ZipAccCrdPhn(strSecCode, 3);
                
                if (bAmt && bAccNum && bLName && bZip && bCard && bSCode)
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
        /// Validate the fields in the form while submiting.
        /// </summary>
        /// <param name="strAmount">Amount involved in the transfer</param>
        /// <param name="strLName">Last Name of the recepient</param>
        /// <param name="strEmail">Email of the recepient</param>
        /// <param name="strCardNum">Card number of the initiator</param>
        /// <param name="strSecCode">Security code of the card</param>
        /// <returns>True, if all the fields are validated. Otherwise false</returns>
        /// <returns></returns>
        private bool validateFromFields(string strAmount, string strLName, string strEmail, string strCardNum, string strSecCode)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bAmt = fieldValidator.validate_Amount(strAmount);
                bool bEmail = fieldValidator.validate_Email(strEmail);
                bool bLName = fieldValidator.validate_Names(strLName);               
                bool bCard = fieldValidator.validate_ZipAccCrdPhn(strCardNum, 16);
                bool bSCode = fieldValidator.validate_ZipAccCrdPhn(strSecCode, 3);

                if (bAmt && bEmail && bLName && bCard && bSCode)
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
        /// <param name="strAmount">The amount to be transfered</param>
        /// <returns>True if the amount is valid; else false</returns>
        private bool validateFromFields(string strAmount)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bAmt = fieldValidator.validate_Amount(strAmount);
                
                if (bAmt)
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
        /// Validate the fields in the form while submiting
        /// </summary>
        /// <param name="strEmail">Email of the user</param>
        /// <param name="strStreetAdd">Street address of the user</param>
        /// <param name="strCity">City of the user</param>
        /// <param name="strZipCode">Zip code of the address of the user</param>
        /// <param name="strPhone">Phone number of the user</param>
        /// <param name="strName">Nick name of the user</param>
        /// <returns>True if all the fields are valid, otherwise false</returns>
        private bool validateFromFields_editProfile(string strEmail, string strStreetAdd,string strCity, string strZipCode, string strPhone, string strName)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bEmail = fieldValidator.validate_Email(strEmail);
                bool bStAdd = fieldValidator.validate_streetAddress(strStreetAdd);
                bool bCity = fieldValidator.validate_Names(strCity);
                bool bZip = fieldValidator.validate_ZipAccCrdPhn(strZipCode, 5);
                bool bPhn = fieldValidator.validate_ZipAccCrdPhn(strPhone,10);
                bool bNick = fieldValidator.validate_Names(strName);

                if (bEmail && bStAdd && bPhn && bNick)
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
        /// Validate the fields in the form while submiting
        /// </summary>
        /// <param name="strCardNum">Card number of the customer</param>
        /// <param name="strLName">Name on the Card</param>
        /// <param name="strAmount">The amount to be transfered</param>
        /// <returns></returns>
        private bool validateFromFields(string strCardNum, string strLName, string strAmount)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bAmt = fieldValidator.validate_Amount(strAmount);
                
                bool bLName = fieldValidator.validate_Names(strLName);
                bool bCard = fieldValidator.validate_ZipAccCrdPhn(strCardNum, 16);
                

                if (bAmt && bLName && bCard)
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