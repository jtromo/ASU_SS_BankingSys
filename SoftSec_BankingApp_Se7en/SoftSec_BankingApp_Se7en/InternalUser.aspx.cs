using SoftSec_BankingApp_Se7en.Models;
using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftSec_BankingApp_Se7en
{
    public partial class InternalUser : System.Web.UI.Page
    {
        protected static String siteKeySelected = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    TabContainer2.Visible = false;
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
                    img_site1_AE.ImageUrl = "./Images/SiteKeys/SiteKey1.jpg";
                    img_site2_AE.ImageUrl = "./Images/SiteKeys/SiteKey2.jpg";
                    img_site3_AE.ImageUrl = "./Images/SiteKeys/SiteKey3.jpg";
                    img_site4_AE.ImageUrl = "./Images/SiteKeys/SiteKey4.jpg";
                    img_site5_AE.ImageUrl = "./Images/SiteKeys/SiteKey5.jpg";
                    img_site6_AE.ImageUrl = "./Images/SiteKeys/SiteKey6.jpg";
                    img_site7_AE.ImageUrl = "./Images/SiteKeys/SiteKey7.jpg";
                    img_site8_AE.ImageUrl = "./Images/SiteKeys/SiteKey8.jpg";
                    img_site9_AE.ImageUrl = "./Images/SiteKeys/SiteKey9.jpg";
                    img_site10_AE.ImageUrl = "./Images/SiteKeys/SiteKey10.jpg";
                    img_site11_AE.ImageUrl = "./Images/SiteKeys/SiteKey11.jpg";
                    img_site12_AE.ImageUrl = "./Images/SiteKeys/SiteKey12.jpg";
                    img_site13_AE.ImageUrl = "./Images/SiteKeys/SiteKey13.jpg";
                    img_site14_AE.ImageUrl = "./Images/SiteKeys/SiteKey14.jpg";
                    img_site15_AE.ImageUrl = "./Images/SiteKeys/SiteKey15.jpg";
                    img_site16_AE.ImageUrl = "./Images/SiteKeys/SiteKey16.jpg";
                    img_site17_AE.ImageUrl = "./Images/SiteKeys/SiteKey17.jpg";
                    img_site18_AE.ImageUrl = "./Images/SiteKeys/SiteKey18.jpg";
                    img_site19_AE.ImageUrl = "./Images/SiteKeys/SiteKey19.jpg";
                    img_site20_AE.ImageUrl = "./Images/SiteKeys/SiteKey20.jpg";
                }
            }
            catch (Exception exp)
            {
                //Log exception here
            }
        }
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
            img_site1_AE.BorderStyle = BorderStyle.None;
            img_site2_AE.BorderStyle = BorderStyle.None;
            img_site3_AE.BorderStyle = BorderStyle.None;
            img_site4_AE.BorderStyle = BorderStyle.None;
            img_site5_AE.BorderStyle = BorderStyle.None;
            img_site6_AE.BorderStyle = BorderStyle.None;
            img_site7_AE.BorderStyle = BorderStyle.None;
            img_site8_AE.BorderStyle = BorderStyle.None;
            img_site9_AE.BorderStyle = BorderStyle.None;
            img_site10_AE.BorderStyle = BorderStyle.None;
            img_site11_AE.BorderStyle = BorderStyle.None;
            img_site12_AE.BorderStyle = BorderStyle.None;
            img_site13_AE.BorderStyle = BorderStyle.None;
            img_site14_AE.BorderStyle = BorderStyle.None;
            img_site15_AE.BorderStyle = BorderStyle.None;
            img_site16_AE.BorderStyle = BorderStyle.None;
            img_site17_AE.BorderStyle = BorderStyle.None;
            img_site18_AE.BorderStyle = BorderStyle.None;
            img_site19_AE.BorderStyle = BorderStyle.None;
            img_site20_AE.BorderStyle = BorderStyle.None;
        }

        protected void img_site1_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "1";
            img_site1.BorderColor = System.Drawing.Color.DarkBlue;
            img_site1.BorderStyle = BorderStyle.Solid;
            img_site1_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site1_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site2_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "2";
            img_site2.BorderColor = System.Drawing.Color.DarkBlue;
            img_site2.BorderStyle = BorderStyle.Solid;
            img_site2_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site2_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site3_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "3";
            img_site3.BorderColor = System.Drawing.Color.DarkBlue;
            img_site3.BorderStyle = BorderStyle.Solid;
            img_site3_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site3_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site4_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "4";
            img_site4.BorderColor = System.Drawing.Color.DarkBlue;
            img_site4.BorderStyle = BorderStyle.Solid;
            img_site4_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site4_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site5_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "5";
            img_site5.BorderColor = System.Drawing.Color.DarkBlue;
            img_site5.BorderStyle = BorderStyle.Solid;
            img_site5_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site5_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site6_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "6";
            img_site6.BorderColor = System.Drawing.Color.DarkBlue;
            img_site6.BorderStyle = BorderStyle.Solid;
            img_site6_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site6_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site7_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "7";
            img_site7.BorderColor = System.Drawing.Color.DarkBlue;
            img_site7.BorderStyle = BorderStyle.Solid;
            img_site7_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site7_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site8_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "8";
            img_site8.BorderColor = System.Drawing.Color.DarkBlue;
            img_site8.BorderStyle = BorderStyle.Solid;
            img_site8_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site8_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site9_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "9";
            img_site9.BorderColor = System.Drawing.Color.DarkBlue;
            img_site9.BorderStyle = BorderStyle.Solid;
            img_site9_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site9_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site10_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "10";
            img_site10.BorderColor = System.Drawing.Color.DarkBlue;
            img_site10.BorderStyle = BorderStyle.Solid;
            img_site10_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site10_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site11_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "11";
            img_site11.BorderColor = System.Drawing.Color.DarkBlue;
            img_site11.BorderStyle = BorderStyle.Solid;
            img_site11_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site11_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site12_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "12";
            img_site12.BorderColor = System.Drawing.Color.DarkBlue;
            img_site12.BorderStyle = BorderStyle.Solid;
            img_site12_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site12_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site13_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "13";
            img_site13.BorderColor = System.Drawing.Color.DarkBlue;
            img_site13.BorderStyle = BorderStyle.Solid;
            img_site13_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site13_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site14_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "14";
            img_site14.BorderColor = System.Drawing.Color.DarkBlue;
            img_site14.BorderStyle = BorderStyle.Solid;
            img_site14_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site14_AE.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site15_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "15";
            img_site15.BorderColor = System.Drawing.Color.DarkBlue;
            img_site15.BorderStyle = BorderStyle.Solid;
            img_site15_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site15_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site16_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "16";
            img_site16.BorderColor = System.Drawing.Color.DarkBlue;
            img_site16.BorderStyle = BorderStyle.Solid;
            img_site16_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site16_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site17_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "17";
            img_site17.BorderColor = System.Drawing.Color.DarkBlue;
            img_site17.BorderStyle = BorderStyle.Solid;
            img_site17_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site17_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site18_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "18";
            img_site18.BorderColor = System.Drawing.Color.DarkBlue;
            img_site18.BorderStyle = BorderStyle.Solid;
            img_site18_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site18_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site19_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "19";
            img_site19.BorderColor = System.Drawing.Color.DarkBlue;
            img_site19.BorderStyle = BorderStyle.Solid;
            img_site19_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site19_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site20_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "20";
            img_site20.BorderColor = System.Drawing.Color.DarkBlue;
            img_site20.BorderStyle = BorderStyle.Solid;
            img_site20_AE.BorderColor = System.Drawing.Color.DarkBlue;
            img_site20_AE.BorderStyle = BorderStyle.Solid;
        }

        protected void btn_maketransinside_Click(object sender, EventArgs e)
        {
            //Transfer Money to Accounts within the bank
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields(tb_amount_IU_Inside.Text.ToString(), tb_recepient_IU_Inside.Text.ToString(),
                                            tb_lastname_IU_Inside.Text.ToString(), tb_zip_IU_Inside.Text.ToString(), tb_card_IU_Inside.Text.ToString(),
                                            tb_securitycode_IU_Inside.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    Models.Tables.Card objCard = new Models.Tables.Card();
                    objCard = AccountModel.GetCardDetails(tb_card_IU_Inside.Text.ToString(), fromAccTypeDD_TransferExistingCust_Inside.SelectedValue.ToString());
                    if (objCard != null)
                    {
                        string sCardExp = string.Empty;
                        sCardExp = monthDD_TransferExistingCust_Inside.SelectedValue.ToString() + yearDD_TransferExistingCust_Inside.SelectedValue.ToString();

                        if (objCard.expirationDate.Equals(sCardExp))
                        {
                            if (objCard.cvv == Convert.ToInt32(tb_securitycode_IU_Inside.Text.ToString()))
                            {
                                LastNameZipcode objLastZip = AccountModel.GetLastNameAndZipcode(tb_recepient_IU_Inside.Text.ToString());
                                if (objLastZip != null)
                                {
                                    if (objLastZip.lastName.ToLower().Equals(tb_lastname_IU_Inside.Text.ToLower()) && objLastZip.zipcode.Equals(tb_zip_IU_Inside.Text.ToString()))
                                    {
                                        string desc = "From : " + fromAccTypeDD_TransferExistingCust_Inside.SelectedValue.ToString() + " To : " + tb_recepient_IU_Inside.Text.ToString() +
                                                                           " Amount : " + tb_amount_IU_Inside.Text.ToString();
                                        bool success = TransactionModel.MakeInternalTransfer(objCard.accountNumber, tb_recepient_IU_Inside.Text.ToString(),
                                                                   Convert.ToDouble(tb_amount_IU_Inside.Text.ToString()), desc);
                                        if (success)
                                        {
                                            lblSuccess_IUInside.Text = "Transaction Successful";
                                            lblSuccess_IUInside.Visible = true;
                                        }
                                        else
                                        {
                                            lblSuccess_IUInside.Text = "Transaction Unsuccessful";
                                            lblSuccess_IUInside.Visible = true;
                                        }
                                    }
                                }
                                else
                                {
                                    //Invalid Zip and Last name combination
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

        protected void btnVerify_Click(object sender, EventArgs e)
        {   
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields(tbCardNumber_IU.Text.ToString(), tbYear_IU.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    User objUser = CardModel.UserForCard(tbCardNumber_IU.Text.ToString());
                    if (objUser != null)
                    {
                        string strDob = MonthDD_ExistingCustomer_Verify.SelectedValue.ToString() + '/' + DayDD_ExistingCustomer_Verify.SelectedValue.ToString()
                            + '/' + tbYear_IU.Text.ToString();
                        if (objUser.dateOfBirth.Equals(strDob))
                        {
                            if(rb_PhotoID.SelectedValue.ToLower().Equals("yes"))
                            {
                                if (objUser.roleId == 3)
                                {
                                    TabContainer2.Visible = true;
                                    TabContainer2.Tabs[0].Visible = true;
                                    TabContainer2.Tabs[1].Visible = true;
                                    TabContainer2.Tabs[2].Visible = true;
                                    TabContainer2.Tabs[3].Visible = true;
                                    TabContainer2.Tabs[4].Visible = true;
                                }
                                else
                                {
                                    TabContainer2.Visible = true;
                                    TabContainer2.Tabs[0].Visible = true;
                                    TabContainer2.Tabs[1].Visible = true;
                                    TabContainer2.Tabs[2].Visible = true;
                                    TabContainer2.Tabs[3].Visible = true;
                                    TabContainer2.Tabs[4].Visible = false;
                                }
                                TabContainer2.ActiveTabIndex = 0;
                                //Fetch all the accounts of the user.
                                ICollection<Models.Tables.Account> objCol = AccountModel.GetAccountsForUser(objUser.username);
                                if (objCol != null)
                                {
                                    List<Models.Tables.Account> lstAcc = objCol.ToList();
                                    foreach (Models.Tables.Account acc in lstAcc)
                                    {
                                        if (acc.accountTypeId == 1)
                                        {
                                            //Savings Account
                                            tb_savings.Text = acc.accountNumber.ToString();
                                            fromAccTypeDD_TransferExistingCust_Inside.Items.Add(acc.accountNumber.ToString());
                                            accTypeDD_TransferExistingCust_Outside.Items.Add(acc.accountNumber.ToString());
                                            fromAccTypeDD_TransferExistingCust_Between.Items.Add(acc.accountNumber.ToString());
                                            toAccTypeDD_TransferExistingCust_Between.Items.Add(acc.accountNumber.ToString());
                                            accTypeDD_TransferExistingCust_Debit.Items.Add(acc.accountNumber.ToString());
                                            accTypeDD_TransferExistingCust_Credit.Items.Add(acc.accountNumber.ToString());
                                            tb_savings.ReadOnly = true;
                                        }
                                        else if (acc.accountTypeId == 2)
                                        {
                                            //checkings account
                                            tb_checking.Text = acc.accountNumber.ToString();
                                            fromAccTypeDD_TransferExistingCust_Inside.Items.Add(acc.accountNumber.ToString());
                                            accTypeDD_TransferExistingCust_Outside.Items.Add(acc.accountNumber.ToString());
                                            fromAccTypeDD_TransferExistingCust_Between.Items.Add(acc.accountNumber.ToString());
                                            toAccTypeDD_TransferExistingCust_Between.Items.Add(acc.accountNumber.ToString());
                                            accTypeDD_TransferExistingCust_Debit.Items.Add(acc.accountNumber.ToString());
                                            accTypeDD_TransferExistingCust_Credit.Items.Add(acc.accountNumber.ToString());
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
                        else
                        {
                            //Invalid DOB.
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

        protected void btn_maketransferoutside_Click(object sender, EventArgs e)
        {
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields_InternalTransfer(tb_amountoutside.Text.ToString(), tb_lastnameoutside.Text.ToString(), tb_emailoutside.Text.ToString(),
                                        tb_usercardno.Text.ToString(), tb_securitycodeoutside.Text.ToString(), tb_AccNumoutside_Intenal.Text.ToString(), tb_toRoutingNum_OutsideBank.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    Models.Tables.Card objCard = new Models.Tables.Card();
                    objCard = AccountModel.GetCardDetails(tb_usercardno.Text.ToString(), accTypeDD_TransferExistingCust_Outside.SelectedValue.ToString());
                    if (objCard != null)
                    {
                        string sCardExp = string.Empty;
                        sCardExp = monthDD_TransferExistingCust_Outside.SelectedValue.ToString() + yearDD_TransferExistingCust_Outside.SelectedValue.ToString();
                        if (objCard.expirationDate.Equals(sCardExp))
                        {
                            if (objCard.cvv == Convert.ToInt32(tb_securitycodeoutside.Text.ToString()))
                            {
                                string desc = "From : " + accTypeDD_TransferExistingCust_Outside.SelectedValue.ToString() + " To : " + tb_AccNumoutside_Intenal.Text.ToString() +
                                                                       " Amount : " + tb_amountoutside.Text.ToString() + " EMAIL : " + tb_emailoutside.Text.ToString();
                                bool success = TransactionModel.MakeExternalTransfer(objCard.accountNumber, objCard.Account.routingNumber, tb_AccNumoutside_Intenal.Text.ToString(),
                                                            tb_toRoutingNum_OutsideBank.Text.ToString(), Convert.ToDouble(tb_amountoutside.Text.ToString()), desc);
                                if (success)
                                {
                                    lblStatus_OutsideBank.Text = "Transaction Successful";

                                    lblStatus_OutsideBank.Visible = true;
                                }
                                else
                                {
                                    lblStatus_OutsideBank.Text = "Transaction Unsuccessful";

                                    lblStatus_OutsideBank.Visible = true;
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
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields(tb_amountoutside.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    string iToAcc = toAccTypeDD_TransferExistingCust_Between.SelectedValue.ToString();
                    string ifromAcc = fromAccTypeDD_TransferExistingCust_Between.SelectedValue.ToString();
                    bool success = TransactionModel.MakeInternalTransfer(ifromAcc, iToAcc, Convert.ToDouble(tb_amountbetween.Text.ToString()),
                                "From : " + fromAccTypeDD_TransferExistingCust_Between.SelectedValue.ToString() +
                                    "To : " + toAccTypeDD_TransferExistingCust_Between.Text.ToString() +
                                        "- Amount : " + tb_amountbetween.Text.ToString());
                    if (success)
                    {
                        lblStatus_Between.Text = "Transaction Successful";
                        lblStatus_Between.Visible = true;
                    }
                    else
                    {
                        lblStatus_Between.Text = "Transaction Unsuccessful";
                        lblStatus_Between.Visible = true;
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


        protected void btn_maketransDebitFunds_Click(object sender, EventArgs e)
        {
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields(tb_card_DebitFunds.Text.ToString(), tb_securitycode_DebitFunds.Text.ToString(),
                                        tb_amountoutside_DebitFunds.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    Models.Tables.Card objCard = new Models.Tables.Card();
                    objCard = AccountModel.GetCardDetails(tb_card_DebitFunds.Text.ToString(), accTypeDD_TransferExistingCust_Debit.SelectedValue.ToString());
                    if (objCard != null)
                    {
                        string sCardExp = string.Empty;
                        sCardExp = monthDD_TransferExistingCust_Debit.SelectedValue.ToString() + yearDD_TransferExistingCust_Debit.SelectedValue.ToString();
                        if (objCard.expirationDate.Equals(sCardExp))
                        {
                            if (objCard.cvv == Convert.ToInt32(tb_securitycode_DebitFunds.Text.ToString()))
                            {                                
                                bool success = TransactionModel.WithdrawFundsFromAccoount(accTypeDD_TransferExistingCust_Debit.SelectedValue.ToString(),
                                                             Convert.ToDouble(tb_amountoutside_DebitFunds.Text.ToString()));
                                if (success)
                                {
                                    lblStatus_DebitFunds.Text = "Transaction Successful";
                                    lblStatus_DebitFunds.Visible = true;
                                }
                                else
                                {
                                    lblStatus_DebitFunds.Text = "Transaction Unsuccessful";
                                    lblStatus_DebitFunds.Visible = true;
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

        protected void btn_maketrans_CreditFunds_Click(object sender, EventArgs e)
        {
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields(tb_card_CreditFunds.Text.ToString(), tb_securitycode_CreditFunds.Text.ToString(),
                                        tb_amountoutside_CreditFunds.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    Models.Tables.Card objCard = new Models.Tables.Card();
                    objCard = AccountModel.GetCardDetails(tb_card_CreditFunds.Text.ToString(), accTypeDD_TransferExistingCust_Credit.SelectedValue.ToString());
                    if (objCard != null)
                    {
                        string sCardExp = string.Empty;
                        sCardExp = monthDD_TransferExistingCust_Credit.SelectedValue.ToString() + yearDD_TransferExistingCust_Credit.SelectedValue.ToString();
                        if (objCard.expirationDate.Equals(sCardExp))
                        {
                            if (objCard.cvv == Convert.ToInt32(tb_securitycode_CreditFunds.Text.ToString()))
                            {
                                bool success = TransactionModel.DepositFundsToAccoount(accTypeDD_TransferExistingCust_Debit.SelectedValue.ToString(),
                                                             Convert.ToDouble(tb_amountoutside_DebitFunds.Text.ToString()));
                                if (success)
                                {
                                    lblStatus_CreditFunds.Text = "Transaction Successful";
                                    lblStatus_CreditFunds.Visible = true;
                                }
                                else
                                {
                                    lblStatus_CreditFunds.Text = "Transaction Unsuccessful";
                                    lblStatus_CreditFunds.Visible = true;
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
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields_editProfile(tb_email_Edit.Text.ToString(), tb_stAddr_Edit.Text.ToString(),tb_city_Edit.Text.ToString(),
                                        tb_zipCode_Edit.Text.ToString(), tb_contact_Edit.Text.ToString(), tb_nickname_Edit.Text.ToString());
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

        protected void btn_changepwd_Internal_Click(object sender, EventArgs e)
        {
            //Make a payment on behalf of the customer
            bool serverSideValidation = false;
            try
            {
                Dictionary<int, string> dictAns = new Dictionary<int, string>();
                dictAns.Add(1, tb_secans1.Text.ToString());
                dictAns.Add(2, tb_secans2.Text.ToString());
                dictAns.Add(3, tb_secans3.Text.ToString());
                serverSideValidation = validateFromFields(tb_oldpwd.Text.ToString(), dictAns, tb_newPassword.Text.ToString(), tb_confrimPassword.Text.ToString());
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
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields(tb_cardnum.Text.ToString(), tb_customername.Text.ToString(),tb_amount_SubmitPayment.Text.ToString());
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

        protected void btn_createcust_Click(object sender, EventArgs e)
        {
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields(tb_FirstName_Cust.Text.ToString(), tb_MiddleName_Cust.Text.ToString(), tb_LastName_Cust.Text.ToString()
                    , tb_Email_Cust.Text.ToString(), tb_StreetAddr_Cust.Text.ToString(), tb_City_Cust.Text.ToString(), tb_Phone_Cust.Text.ToString()
                    , tb_Zip_Cust.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    TabContainer6.ActiveTabIndex = 1;
                    ErrorLabelInNewCustPI.Visible = false;
                }
                else
                {
                    //Update the UI with error message.
                    fieldValidationErrorLabel.Visible = true;
                    fieldValidationErrorLabel.Text = "Please verify the data you have entered";
                }
            }
            catch (Exception exp)
            {
                //Log Exception here
            }

        }

        protected void btn_sumbitcust_Click(object sender, EventArgs e)
        {
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields(tb_UserName_Cust.Text.ToString(), tb_Password_Cust.Text.ToString(), tb_ConfPassword_Cust.Text.ToString()
                       , tb_SecAns1_Cust.Text.ToString(), tb_SecAns2_Cust.Text.ToString(), tb_SecAns3_Cust.Text.ToString(), tb_SSN_Cust.Text.ToString()
                       , tb_sitekeyhint_Cust.Text.ToString(), tb_BirthYear_Cust.Text.ToString());
                if (serverSideValidation)
                {
                    User userForName = new User();
                    userForName = UserModel.GetUser(tb_UserName_Cust.Text.ToString());
                    if (userForName != null)
                    {

                        ErrorLabelInNewCustPI.Visible = true;
                        ErrorLabelInNewCustPI.Text = "User name already Exists";
                    }
                    else
                    {

                        string passwordForUser = tb_Password_Cust.Text.ToString();
                        string confirmPassword = tb_ConfPassword_Cust.Text.ToString();
                        if (passwordForUser.Equals(confirmPassword))
                        {
                            User userToCreate = new User();
                            userToCreate.firstName = tb_FirstName_Cust.Text.ToString();
                            userToCreate.middleName = tb_MiddleName_Cust.Text.ToString();
                            userToCreate.lastName = tb_LastName_Cust.Text.ToString();
                            userToCreate.email = tb_Email_Cust.Text.ToString();
                            userToCreate.roleId = 1;
                            Address addressForUser = new Address();
                            addressForUser.street1 = tb_StreetAddr_Cust.Text.ToString();
                            addressForUser.city = tb_City_Cust.Text.ToString();
                            addressForUser.state = StateDD_Cust.Text.ToString();
                            addressForUser.country = "US";
                            addressForUser.zip = Convert.ToInt32(tb_Zip_Cust.Text);
                            userToCreate.phone = tb_Phone_Cust.Text.ToString();
                            userToCreate.username = tb_UserName_Cust.Text.ToString();
                            string checkingAccountNumber;
                            string savingsAccountNumber;
                            string cardNumber;
                            string routingAccountNumber = "1234056789";
                            string randomNum;
                            int cvvNum;
                            while (true)
                            {
                                if ((randomNum = randomAccountNumberGenerator()) != null)
                                {
                                    checkingAccountNumber = randomNum + randomNum + randomNum;
                                    int ran = Convert.ToInt16(randomNum);
                                    savingsAccountNumber = randomNum + randomNum + (ran + 1).ToString();
                                    cardNumber = randomNum + randomNum + randomNum + (ran + 2).ToString();
                                    cvvNum = ran / 10;
                                    break;
                                }
                            }
                            Card cardForUser = new Card();
                            cardForUser.cardNumber = cardNumber;
                            cardForUser.accountNumber = checkingAccountNumber;
                            cardForUser.cvv = cvvNum;
                            cardForUser.expirationDate = "11/2018";
                            cardForUser.firstName = userToCreate.firstName;
                            cardForUser.middleInitial = userToCreate.middleName;
                            cardForUser.lastName = userToCreate.lastName;
                            List<SecurityQuestion> securityQuestionsForUser = new List<SecurityQuestion>();
                            SecurityQuestion securityQuestionForUser1 = new SecurityQuestion();
                            securityQuestionForUser1.questionId = Sec1DD_PersonalInformation.SelectedIndex;
                            securityQuestionForUser1.answer = tb_SecAns1_Cust.Text.ToString();
                            securityQuestionsForUser.Add(securityQuestionForUser1);
                            SecurityQuestion securityQuestionForUser2 = new SecurityQuestion();
                            securityQuestionForUser2.questionId = Sec2DD_PersonalInformation.SelectedIndex;
                            securityQuestionForUser2.answer = tb_SecAns2_Cust.Text.ToString();
                            securityQuestionsForUser.Add(securityQuestionForUser2);
                            SecurityQuestion securityQuestionForUser3 = new SecurityQuestion();
                            securityQuestionForUser3.questionId = Sec3DD_PersonalInformation.SelectedIndex;
                            securityQuestionForUser3.answer = tb_SecAns3_Cust.Text.ToString();
                            securityQuestionsForUser.Add(securityQuestionForUser3);
                            userToCreate.socialSecurityNumber = tb_SSN_Cust.Text.ToString();
                            userToCreate.siteKeyVal = Convert.ToInt32(siteKeySelected);
                            userToCreate.siteKeyString = tb_sitekeyhint_Cust.Text.ToString();
                            string userDOB = monthDD_PersonalInformation.Text.ToString() + "/" + dayDD_PersonalInformation.Text.ToString() + "/" + tb_BirthYear_Cust.Text.ToString();
                            userToCreate.dateOfBirth = userDOB;
                            bool userCreated = UserModel.CreateUser(userToCreate, passwordForUser, checkingAccountNumber, savingsAccountNumber, routingAccountNumber, cardForUser, addressForUser, securityQuestionsForUser);
                            if (userCreated)
                            {
                                ErrorLabelInNewCustPI.Visible = true;
                                ErrorLabelInNewCustPI.Text = "User successfully created";
                            }
                            else
                            {
                                ErrorLabelInNewCustPI.Visible = true;
                                ErrorLabelInNewCustPI.Text = "User could Not be created";
                            }

                        }
                        else
                        {
                            ErrorLabelInNewCustPI.Visible = true;
                            ErrorLabelInNewCustPI.Text = "Passwords Do Not Match";

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
                            userToCreate.siteKeyVal = Convert.ToInt32(siteKeySelected);
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Account Number generation</returns>
        protected string randomAccountNumberGenerator()
        {
            int myRandomNumber = 0;
            Random myRandomNUmberGenerator = new Random();
            myRandomNumber = myRandomNUmberGenerator.Next(1001, 9996);
            string randocAccNum = myRandomNumber.ToString() + myRandomNumber.ToString() + myRandomNumber.ToString();
            SoftSec_BankingApp_Se7en.Models.Tables.Account checkingforAccount = AccountModel.GetAccount(randocAccNum);
            if (checkingforAccount == null)
            {
                return myRandomNumber.ToString();
            }
            else
            {
                return null;
            }

        }

        protected void btn_ViewDetails_DelEmp_Click(object sender, EventArgs e)
        {
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields_Emp(tb_UserName_DelEmp.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    User userToDel = new User();
                    userToDel = UserModel.GetUser(tb_UserName_DelEmp.Text.ToString());
                    tb_FirstName_DelEmp.Text = userToDel.firstName;
                    tb_MidName_DelEMp.Text = userToDel.middleName;
                    tb_LastName_DelEmp.Text = userToDel.lastName;
                    tb_Email_DelEmp.Text = userToDel.email;
                    tb_Phone_DelEmp.Text = userToDel.phone;
                    DeptDD_DelEmp.SelectedValue = userToDel.departmentId.ToString();
                    RoleDD_DelEmp.SelectedValue = userToDel.roleId.ToString();
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

        protected void btn_ViewDetails_TransEmp_Click(object sender, EventArgs e)
        {
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields_Emp(tb_UserName_transEmp.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    User userToTrans = new User();
                    userToTrans = UserModel.GetUser(tb_UserName_transEmp.Text.ToString());
                    tb_FName_TransEmp.Text = userToTrans.firstName;
                    tb_MName_TransEmp.Text = userToTrans.middleName;
                    tb_LName_TransEmp.Text = userToTrans.lastName;
                    tb_Email_TransEmp.Text = userToTrans.email;
                    tb_Contact_TransEmp.Text = userToTrans.phone;
                    FROM_DeptDD_TransEmp.SelectedValue = userToTrans.departmentId.ToString();
                    RoleDD_TransEmp.SelectedValue = userToTrans.roleId.ToString();
                    
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

        protected void btn_ViewDetails_ViewEmp_Click(object sender, EventArgs e)
        {
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields_Emp(tb_userName_ViewEmp.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    User userToView = new User();
                    userToView = UserModel.GetUser(tb_userName_ViewEmp.Text.ToString());
                    tb_FName_ViewEmp.Text = userToView.firstName;
                    tb_MName_ViewEmp.Text = userToView.middleName;
                    tb_LName_ViewEmp.Text = userToView.lastName;
                    tb_Email_ViewEmp.Text = userToView.email;
                    tb_Phone_ViewEmp.Text = userToView.phone;
                    DeptDD_viewEmp.SelectedValue = userToView.departmentId.ToString();
                    RoleDD_ViewEmp.SelectedValue = userToView.roleId.ToString();
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

        protected void btn_viewtransdetails1_Click(object sender, EventArgs e)
        {
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields_Emp(tb_userName_ViewEmp.Text.ToString());
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

        protected void btn_echecksubmitpayment_Click(object sender, EventArgs e)
        {
            //
            bool serverSideValidation = false;
            try
            {
                serverSideValidation = validateFromFields_ECheck(tb_echeckaccno.Text.ToString(), tb_echeckroutingno.Text.ToString()
                                            , tb_echeckcustomername.Text.ToString(), tbAmount_EcheckPayment.Text.ToString());
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
        
        #region ValidateFormFields
        /// <summary>
        /// Validate the from fields
        /// </summary>
        /// <param name="strCardNum">Validate the card number</param>
        /// <param name="strName">Name on the card</param>
        /// <param name="strAmount">Amount involved in the transaction</param>
        /// <returns>True if the card number is valid, else false</returns>
        private bool validateFromFields_Payments(string strCardNum, string strName, string strAmount)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bCard = fieldValidator.validate_ZipAccCrdPhn(strCardNum, 16);
                bool bName = fieldValidator.validate_Names(strName);
                bool bAmt = fieldValidator.validate_Amount(strAmount);
                if (bCard && bName && bAmt)
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
                //Log Exception Here
                return false;
            }
        }

        /// <summary>
        /// Validate the from fields
        /// </summary>
        /// <param name="strCardNum">Validate the card number</param>
        /// <param name="strYear">Validate the card Expiry Year</param>
        /// <returns>True if the card number is valid, else false</returns>
        private bool validateFromFields(string strCardNum, string StrSecCode,string strAmount)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bCard = fieldValidator.validate_ZipAccCrdPhn(strCardNum, 16);
                bool bSecCode = fieldValidator.validate_ZipAccCrdPhn(StrSecCode, 3);
                bool bAmt = fieldValidator.validate_Amount(strAmount);
                if (bCard && bSecCode && bAmt)
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
        /// Validate the from fields
        /// </summary>
        /// <param name="strAmount">Validate the amount entered</param>
        /// <returns>True if the card number is valid, else false</returns>
        private bool validateFromFields(string strAmount)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bAmount = fieldValidator.validate_Amount(strAmount);
                
                if (bAmount)
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
        /// Validate the from fields
        /// </summary>
        /// <param name="strCardNum">Validate the card number</param>
        /// <param name="strYear">Validate the card Expiry Year</param>
        /// <returns>True if the card number is valid, else false</returns>
        private bool validateFromFields(string strCardNum,string strYear)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bCard = fieldValidator.validate_ZipAccCrdPhn(strCardNum, 16);
                bool bYear = fieldValidator.validate_ZipAccCrdPhn(strYear, 4);
                if (bCard && bYear)
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
        private bool validateFromFields_InternalTransfer(string strAmount, string strLName, string strEmail, string strCardNum, string strSecCode,string strAccNum, string strRouteNum)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bAmt = fieldValidator.validate_Amount(strAmount);
                bool bEmail = fieldValidator.validate_Email(strEmail);
                bool bLName = fieldValidator.validate_Names(strLName);
                bool bCard = fieldValidator.validate_ZipAccCrdPhn(strCardNum, 16);
                bool bSCode = fieldValidator.validate_ZipAccCrdPhn(strSecCode, 3);
                bool bAccnum = fieldValidator.validate_ZipAccCrdPhn(strAccNum, 12);
                bool bRouNum = fieldValidator.validate_ZipAccCrdPhn(strRouteNum, 10);
                if (bAmt && bEmail && bLName && bCard && bSCode && bAccnum && bRouNum)
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
        /// Validate the fields on the form
        /// </summary>
        /// <param name="strFName">Frist Name of Customer</param>
        /// <param name="strMName">Middle Name</param>
        /// <param name="strLName">Last Name</param>
        /// <param name="strEmail">Mail ID of Customer</param>
        /// <param name="strStreetAddr">Street Address</param>
        /// <param name="strCity">City</param>
        /// <param name="strPhone">Phone Number</param>
        /// <param name="strZipCode">Zip Code</param>
        /// <returns>True if all the fields are valid. False otherwise</returns>
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
                string strTemp = strPass.Substring(strPass.IndexOf('_')+1);
                bool bPass = false;
                if (strTemp.Equals("TRUE"))
                    bPass = true;
                string strRePass = fieldValidator.validate_password(strRe_Password);
                strTemp = strRePass.Substring(strRePass.IndexOf('_')+1);
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
        /// Validate the form fields
        /// </summary>
        /// <param name="strTransID">Transaction ID to be validated</param>
        /// <param name="strYear">Year field</param>
        /// <returns>True if all the fields are valid, false otherwise</returns>
        private bool validateFromFields_Emp(string strTransID, string strYear)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bUName = fieldValidator.validate_TransID(strTransID);
                bool bYear = fieldValidator.validate_ZipAccCrdPhn(strYear, 4);
                if (bUName && bYear)
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
        /// Validates if the username is valid input
        /// </summary>
        /// <param name="strUserName">User name of the employee</param>
        /// <returns>True if the input is valid, else false</returns>
        private bool validateFromFields_Emp(string strUserName)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bUName = fieldValidator.validate_UserName(strUserName);
                if (bUName)
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
        /// Validates the Form fields
        /// </summary>
        /// <param name="strFName"> First name of the employee</param>
        /// <param name="strMName"> Middle name of employee</param>
        /// <param name="strLName">Last Name of employee</param>
        /// <param name="strEmail">Mail address of Employee</param>
        /// <param name="strContact"> Phone number</param>
        /// <returns>IF all fields are valid, returns true: false otherwise</returns>
        private bool validateFromFields_Emp(string strFName, string strMName, string strLName, string strEmail, string strContact,string str)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bFName = fieldValidator.validate_Names(strFName);
                bool bMName = fieldValidator.validate_Names(strMName);
                bool bLName = fieldValidator.validate_Names(strLName);
                bool bEmail = fieldValidator.validate_Email(strEmail);
                bool bPhn = fieldValidator.validate_ZipAccCrdPhn(strContact, 10);
                if (bFName && bLName && bMName && bEmail && bPhn)
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
        /// <param name="strAccNum">Account number of recepient</param>
        /// <param name="strRoutingNum">Routing number recepient</param>
        /// <param name="strName">Name of recepient</param>
        /// <param name="strAmount">Amount involved in transaction</param>
        /// <returns></returns>
        private bool validateFromFields_ECheck(string strAccNum, string strRoutingNum, string strName, string strAmount)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bAcc = fieldValidator.validate_ZipAccCrdPhn(strAccNum,12);
                bool bRoute = fieldValidator.validate_ZipAccCrdPhn(strRoutingNum,10);
                bool bName = fieldValidator.validate_Names(strName);
                bool bAmt = fieldValidator.validate_Amount(strAmount);
                
                if (bAcc && bName && bRoute && bAmt)
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
        #endregion

        protected void btn_delEmp_Click(object sender, EventArgs e)
        {
            bool DeleteSuccess = false;
            DeleteSuccess = UserModel.RemoveUser(tb_UserName_DelEmp.Text.ToString());
            if (DeleteSuccess)
            {
                Label2.Text = tb_UserName_DelEmp.Text + "Deleted";
            }
            else
            {
                Label2.Text = "Deleted"; 
            }
        }

        protected void btn_TransEmp_Click(object sender, EventArgs e)
        {
            bool TransferSuccess = false;
            TransferSuccess = UserModel.TransferToDept(tb_UserName_transEmp.Text, Convert.ToInt32(TO_DeptDD_TransDept.SelectedValue));
            if (TransferSuccess)
            {
                Label3.Text = tb_UserName_transEmp.Text + "Transferred to " + TO_DeptDD_TransDept.SelectedValue;
            }
            else
            {
                Label3.Text = "Transfer Phrooo :P ";
            }
        }

    }
}