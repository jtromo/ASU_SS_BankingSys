using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SoftSec_BankingApp_Se7en.Models;

namespace SoftSec_BankingApp_Se7en
{
    public partial class ExternalUser : System.Web.UI.Page
    {
        private static AccountModel objAccMod = new AccountModel();
        private static Models.Tables.Account objAcc = new Models.Tables.Account();
        private static UserModel objUser = new UserModel();
        private string merchant_savingsAccNum = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {            
            try
            {
                if (!IsPostBack)
                {                    
                    lblTranStatus.Visible = false;
                    if (objUser.GetUser(Session["userName"].ToString()).roleId == 3)
                    {
                        TabContainer1.Visible = true;
                        TabContainer1.Tabs[0].Visible = true;
                        TabContainer1.Tabs[1].Visible = true;
                        TabContainer1.Tabs[2].Visible = true;
                        TabContainer1.Tabs[3].Visible = true;
                    }
                    else
                    {
                        TabContainer1.Visible = true;
                        TabContainer1.Tabs[0].Visible = true;
                        TabContainer1.Tabs[1].Visible = true;
                        TabContainer1.Tabs[2].Visible = true;
                        TabContainer1.Tabs[3].Visible = false;
                    }
                    TabContainer1.ActiveTabIndex = 0;
                    //Fetch all the accounts of the user.
                    ICollection<Models.Tables.Account> objCol = objAccMod.GetAccountsForUser(Session["userName"].ToString());
                    if (objCol != null)
                    {
                        List<Models.Tables.Account> lstAcc = objCol.ToList();
                        foreach (Models.Tables.Account acc in lstAcc)
                        {
                            if (acc.accountTypeId == 1)
                            {
                                //Savings Account
                                tb_savings.Text = acc.accountNumber.ToString();
                                dd_acctype.Items.Add(acc.accountNumber.ToString());
                                dd_acctypeoutside.Items.Add(acc.accountNumber.ToString());
                                dd_acctypebetween_From.Items.Add(acc.accountNumber.ToString());
                                dd_acctypebetween_To.Items.Add(acc.accountNumber.ToString());
                                tb_savings.ReadOnly = true;                                
                            }
                            else if (acc.accountTypeId == 2)
                            {
                                //checkings account
                                tb_checking.Text = acc.accountNumber.ToString();
                                dd_acctype.Items.Add(acc.accountNumber.ToString());
                                dd_acctypeoutside.Items.Add(acc.accountNumber.ToString());
                                dd_acctypebetween_From.Items.Add(acc.accountNumber.ToString());
                                dd_acctypebetween_To.Items.Add(acc.accountNumber.ToString());
                                tb_checking.ReadOnly = true;
                            }
                            else if (acc.accountTypeId == 3)
                            {
                                //credit account
                                tb_credit.Text = acc.accountNumber.ToString();
                                tb_credit.ReadOnly = true;
                            }
                        }
                        
                    }
                }
            }
            catch(Exception exp)
            {
                //Log Exceptions here
            }
        }

        protected void btn_maketransferoutside_Click(object sender, EventArgs e)
        {
            //Transfer Money to Accounts in other the bank
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields(tb_amountoutside.Text.ToString(), tb_lastnameoutside.Text.ToString(), 
                                            tb_emailoutside.Text.ToString(), tb_usercardno.Text.ToString(), 
                                                tb_securitycodeoutside.Text.ToString(),tb_toAccNum_OutsideBank.Text.ToString(),tb_toRoutingNumber.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    Models.Tables.Card objCard = new Models.Tables.Card();
                    objCard = objAccMod.GetCardDetails(tb_usercardno.Text.ToString());
                    if (objCard != null)
                    {
                        if (objCard.accountNumber.Equals(dd_acctypeoutside.SelectedValue.ToString()))
                        {
                            string sCardExp = string.Empty;
                            sCardExp = dd_month.SelectedValue.ToString() + dd_year.SelectedValue.ToString();
                            if (objCard.expirationDate.Equals(sCardExp))
                            {
                                if (objCard.cvv == Convert.ToInt32(tb_securitycodeoutside.Text.ToString()))
                                {
                                    string desc = "From : " + dd_acctypeoutside.SelectedValue.ToString() + " To : " + tb_toAccNum_OutsideBank.Text.ToString() +
                                                                           " Amount : " + tb_amountoutside.Text.ToString() + " EMAIL : " + tb_emailoutside.Text.ToString();
                                    bool success = objAccMod.MakeExternalTransfer(objCard.accountNumber, tb_toAccNum_OutsideBank.Text.ToString(),
                                                                tb_toRoutingNumber.Text.ToString(), Convert.ToDouble(tb_amountoutside.Text.ToString()), desc);
                                    if (success)
                                    {
                                        lblTranStatus.Text = "Transaction Successful";
                                        tb_toRoutingNumber.Text = "";
                                        tb_toAccNum_OutsideBank.Text = "";
                                        lblTranStatus.Visible = true;
                                    }
                                    else
                                    {
                                        lblTranStatus.Text = "Transaction Unsuccessful";
                                        tb_toRoutingNumber.Text = "";
                                        tb_toAccNum_OutsideBank.Text = "";
                                        lblTranStatus.Visible = true;
                                    }
                                }
                                else
                                {
                                    //Invalid Card Details
                                }
                            }
                            else
                            {
                                //Invalid Card Details
                            }
                        }
                        else
                        {
                            //Invalid Card Details
                        }
                    }
                    else
                    {
                        //Invalid Card Details
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
                    Models.Tables.Card objCard = new Models.Tables.Card();
                    objCard = objAccMod.GetCardDetails(tb_card.Text.ToString());
                    if (objCard != null)
                    {
                        if (objCard.accountNumber.Equals(dd_acctype.SelectedValue.ToString()))
                        {
                            string sCardExp = string.Empty;
                            sCardExp = dd_month.SelectedValue.ToString() + dd_year.SelectedValue.ToString();
                            
                            if (objCard.expirationDate.Equals(sCardExp))
                            {
                                if (objCard.cvv == Convert.ToInt32(tb_securitycode.Text.ToString()))
                                {
                                    LastNameZipcode objLastZip = objAccMod.GetLastNameAndZipcode(tb_recepient.Text.ToString());
                                    if (objLastZip.lastName.Equals(tb_lastname.Text.ToString()) && objLastZip.zipcode.Equals(tb_zip.Text.ToString()))
                                    {
                                        string desc = "From : " + dd_acctype.SelectedValue.ToString() + " To : " + tb_recepient.Text.ToString() +
                                                                           " Amount : " + tb_amount.Text.ToString();
                                        bool success = objAccMod.MakeInternalTransfer(objCard.accountNumber, tb_recepient.Text.ToString(),
                                                                   Convert.ToDouble(tb_amount.Text.ToString()), desc);
                                        if (success)
                                        {
                                            lblTransStatus_IB.Text = "Transaction Successful";
                                            tb_toRoutingNumber.Text = "";
                                            tb_toAccNum_OutsideBank.Text = "";
                                            lblTransStatus_IB.Visible = true;
                                        }
                                        else
                                        {
                                            lblTransStatus_IB.Text = "Transaction Unsuccessful";
                                            tb_toRoutingNumber.Text = "";
                                            tb_toAccNum_OutsideBank.Text = "";
                                            lblTransStatus_IB.Visible = true;
                                        }
                                    }                                    
                                }
                                else
                                {
                                    //Invalid Card Details
                                }
                            }
                            else
                            {
                                //Invalid Card Details
                            }
                        }
                        else
                        {
                            //Invalid Card Details
                        }
                    }
                    else
                    {
                        //Invalid Card Details
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
                    string iToAcc = dd_acctypebetween_To.SelectedValue.ToString();
                    string ifromAcc = dd_acctypebetween_From.SelectedValue.ToString();
                    bool success = objAccMod.MakeInternalTransfer(ifromAcc, iToAcc, Convert.ToDouble(tb_amountbetween.Text.ToString()),
                                "From : " + dd_acctypebetween_From.SelectedValue.ToString() +
                                    "To : " + dd_acctypebetween_To.Text.ToString() +
                                        "- Amount : " + tb_amountbetween.Text.ToString());
                    if (success)
                    {
                        lblTransStatus_Between.Text = "Transaction Successful";
                        lblTransStatus_Between.Visible = true;
                    }
                    else
                    {
                        lblTransStatus_Between.Text = "Transaction Unsuccessful";
                        lblTransStatus_Between.Visible = true;
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
                    bool success = objUser.updateUser(Session["userName"].ToString(), tb_emailedit.Text.ToString(), tb_addr_editprofile.Text.ToString(), tb_city_editProfile.Text.ToString(), StateDD_EditProfile.SelectedValue.ToString(), tb_zip_editProfile.Text.ToString(), tb_contactedit.Text.ToString());
                    if (success)
                    {
                        lblChaneProfile.Text = "Update Successful";
                        lblChaneProfile.Visible = false;
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
                serverSideValidation = validateFromFields(tb_cardnum.Text.ToString(), tb_customername.Text.ToString(), tb_amount_CardPayment.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    //Similar to inside bank transfers
                    
                    Models.Tables.Card objCard = objAccMod.GetCardDetails(tb_cardnum.Text.ToString());
                    if (objCard != null)
                    {
                        string cardName = objCard.firstName + objCard.middleInitial + objCard.lastName;
                        string cardNameUserInput = Regex.Replace(tb_customername.Text.ToString(), @"\s+", "");
                        if (cardName.ToLower().Equals(cardNameUserInput.ToLower()))
                        {
                            string strExpDate = string.Empty;
                            strExpDate = dd_cardexpm.SelectedValue.ToString() + dd_cardexpy.SelectedValue.ToString();
                            if (objCard.expirationDate.Equals(strExpDate))
                            {
                                string sToAcc = merchant_savingsAccNum;
                                string sfromAcc = objCard.accountNumber;
                                bool success = objAccMod.MakeInternalTransfer(sfromAcc, sToAcc, Convert.ToDouble(tb_amount_CardPayment.Text.ToString()),
                                            "From : " + sfromAcc + "To : " + sToAcc + "- Amount : " + tb_amount_CardPayment.Text.ToString());
                                if (success)
                                {
                                    lblSubmitPayment.Text = "Transaction Successful";
                                    lblSubmitPayment.Visible = true;
                                }
                                else
                                {
                                    lblSubmitPayment.Text = "Transaction Unsuccessful";
                                    lblSubmitPayment.Visible = true;
                                }
                            }
                        }
                        else
                        {
                            //Update UI with error messages
                        }
                    }
                    else
                    {
                        //Update UI with error messages
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

        protected void btn_changepwd_Click(object sender, EventArgs e)
        {
            //Make a payment on behalf of the customer
            bool serverSideValidation = false;
            try
            {
                Dictionary<int, string> dictAns = new Dictionary<int, string>();
                dictAns.Add(1, tb_secans1.Text.ToString());
                dictAns.Add(2, tb_secans2.Text.ToString());
                dictAns.Add(3, tb_secans3.Text.ToString());
                serverSideValidation = validateFromFields(tb_oldpwd.Text.ToString(), dictAns ,tb_newPass.Text.ToString(), tb_confrimPass.Text.ToString());
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
        /// Validate the fields in the form while submiting
        /// </summary>
        /// <param name="strOldPassword">Old Password of the user</param>
        /// <param name="dictAns">Dictonary of user questions and answers</param>
        /// <param name="strNewPassword">New Password of the user</param>
        /// <param name="strConfrimPassword">Re-Confirm the new password</param>
        /// <returns></returns>
        private bool validateFromFields(string strOldPassword, Dictionary<int,string> dictAns, string strNewPassword, string strConfrimPassword)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                string strOldPass = fieldValidator.validate_password(strOldPassword);
                string strTemp = strOldPass.Substring(strOldPass.IndexOf('_')+1);
                bool bOldPass = false;
                if (strTemp.Equals("TRUE"))
                {
                    bOldPass = true;
                }
                string strNewPass = fieldValidator.validate_password(strNewPassword);
                strTemp = strNewPass.Substring(strNewPass.IndexOf('_')+1);
                bool bNewPass = false;
                if (strTemp.Equals("TRUE"))
                {
                    bNewPass = true;
                }
                string strConfirmPass = fieldValidator.validate_password(strConfrimPassword);
                strTemp = strConfirmPass.Substring(strConfirmPass.IndexOf('_')+1);
                bool bConfPass = false;
                if (strTemp.Equals("TRUE"))
                {
                    bConfPass = true;
                }
                int iCtr = 0;
                List<int> iKeys = new List<int>(dictAns.Keys);
                foreach (int i in iKeys)
                {
                    bool bAns = fieldValidator.validate_Names(dictAns[i]);
                    if (bAns)
                        iCtr++;
                }
                if (bOldPass && bNewPass && bConfPass && iCtr == 2)
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
        private bool validateFromFields(string strAmount, string strLName, string strEmail, string strCardNum, string strSecCode, string toAccNum, string toRoutingNum)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bAmt = fieldValidator.validate_Amount(strAmount);
                bool bEmail = fieldValidator.validate_Email(strEmail);
                bool bLName = fieldValidator.validate_Names(strLName);               
                bool bCard = fieldValidator.validate_ZipAccCrdPhn(strCardNum, 16);
                bool bSCode = fieldValidator.validate_ZipAccCrdPhn(strSecCode, 3);
                bool bToAcc = fieldValidator.validate_ZipAccCrdPhn(toAccNum, 12);
                bool bToRou = fieldValidator.validate_ZipAccCrdPhn(toRoutingNum, 12);
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

        protected void dd_acctypebetween1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TabContainer1_ActiveTabChanged(object sender, EventArgs e)
        {
            try
            {                
                if (TabContainer1.ActiveTabIndex == 2)
                {
                    Models.Tables.User objUsr = objUser.GetUser(Session["userName"].ToString());
                    if (objUsr != null)
                    {
                        tb_usernameview.Text = Session["userName"].ToString();
                        Models.Tables.Address objUsrAddr = objUsr.Address;
                        tb_streetAddress.Text = objUsrAddr.street1;
                        tb_city.Text = objUsrAddr.city;                        
                        StateDD_Profile.SelectedValue = objUsrAddr.state;
                        tb_ZipCode_Profile.Text = Convert.ToString(objUsrAddr.zip);
                        tb_contactview.Text = objUsr.phone;
                        tb_emailview.Text = objUsr.email;
                        //Add Nick Name to DB 
                        //Do we require to show the user last password modified time ??
                        //tb_nicknameview.Text = objUsr.nickName;
                    }
                }
                else if (TabContainer1.ActiveTabIndex == 3)
                {
                    Models.Tables.User objUsr = objUser.GetUser(Session["userName"].ToString());
                    if (objUsr != null)
                    {
                        
                        AccountModel objAccMod = new AccountModel();
                        List<Models.Tables.Account> lstAcc = objAccMod.GetAccountsForUser(Session["userName"].ToString()).ToList();
                        foreach (Models.Tables.Account acc in lstAcc)
                        {
                            if (acc.accountTypeId == 3)
                            {
                                merchant_savingsAccNum = acc.accountNumber;
                                break;
                            }
                        }
                    }
                    else
                    {
                        //No such user exists
                    }
                }
            }
            catch (Exception exp)
            {
                //Log exception here
            }
        }

        protected void btnEditProfile_Click(object sender, EventArgs e)
        {
            TabContainer3.Visible = true;
            try
            {
                tb_emailedit.Text = tb_emailview.Text;
                tb_addr_editprofile.Text = tb_streetAddress.Text;
                tb_city_editProfile.Text = tb_city.Text;
                tb_zip_editProfile.Text = tb_ZipCode_Profile.Text;
                tb_contactedit.Text = tb_contactview.Text;
                StateDD_EditProfile.SelectedValue = StateDD_Profile.SelectedValue;
            }
            catch (Exception exp)
            {
                //Log Exception here
            }
        }

        protected void btn_echecksubmitpayment_Click(object sender, EventArgs e)
        {
            try
            {
                bool serverSideValidation = false;
                serverSideValidation = validateFromFields_echeck(tb_echeckaccno.Text.ToString(), tb_echeckroutingno.Text.ToString(),
                                        tb_echeckcustomername.Text.ToString(), tb_amountECheck.Text.ToString());
                if (serverSideValidation)
                {
                    Models.Tables.Account objAcc = objAccMod.GetAccount(tb_echeckaccno.Text.ToString());
                    if (objAcc != null)
                    {
                        if (objAcc.routingNumber.Equals(tb_echeckroutingno.Text.ToString()))
                        {
                            Models.Tables.User obUser = objUser.GetUser(objAcc.userId);
                            string strFullName = obUser.firstName + obUser.middleName + obUser.lastName;
                            string checkUserNameInput = Regex.Replace(tb_echeckcustomername.Text.ToString(), @"\s+", "");
                            if (strFullName.Equals(checkUserNameInput))
                            {
                                string sToAcc = merchant_savingsAccNum;
                                string sfromAcc = tb_echeckaccno.Text.ToString();
                                bool success = objAccMod.MakeInternalTransfer(sfromAcc, sToAcc, Convert.ToDouble(tb_amountECheck.Text.ToString()),
                                            "From : " + sfromAcc + "To : " + sToAcc + "- Amount : " + tb_amountECheck.Text.ToString());
                                if (success)
                                {
                                    lblEcheckPayment.Text = "Transaction Successful";
                                    lblEcheckPayment.Visible = true;
                                }
                                else
                                {
                                    lblEcheckPayment.Text = "Transaction Unsuccessful";
                                    lblEcheckPayment.Visible = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        //Update the UI with Error Message
                    }
                }
                else
                {
                    //Update UI with error message
                }
            }
            catch (Exception exp)
            {
                //Log Exception here
            }
        }

        private bool validateFromFields_echeck(string strAccNum, string strRoutingNum, string strAccName, string  strAmount)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bAcc = fieldValidator.validate_ZipAccCrdPhn(strAccNum, 12);
                bool bRoute = fieldValidator.validate_ZipAccCrdPhn(strRoutingNum, 10);
                bool bName = fieldValidator.validate_Names(strAccName);
                bool bAmount = fieldValidator.validate_Amount(strAmount);
                if (bAcc && bRoute && bName && bAmount)
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
                //Log exceptions here
                return false;
            }
        }

    }
}