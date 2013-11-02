using SoftSec_BankingApp_Se7en.Models;
using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Net.Mail;
using log4net;

namespace SoftSec_BankingApp_Se7en
{
    public partial class InternalUser : System.Web.UI.Page
    {
        protected static String siteKeySelected = "";
        private static List<SecurityQuestion> lstQandA = null;
        private static string merchant_savingsAccNum = string.Empty;
        private static List<Models.Tables.Transaction> lstTransaction = null;
        private static string fromAccNum_ModTrans = string.Empty;
        private static string toAccNum_ModTrans = string.Empty;
        private static List<Transaction> currentPendingTransReqs;
        private static int currentSelectedReqIndex;
        private static Transaction currentSelectedTransReq;

        private static readonly ILog Elog = LogManager.GetLogger("ExceptionFileAppender");

        protected void Page_Load(object sender, EventArgs e)
        {

            placeReqBT.Visible = false;
            requetAuthLb.Visible = false;
            authorizerDropDown.Visible = false;
            approveReqBT.Visible = false;
            rejectReqBT.Visible = false;
            ErrorLabelInNewCustPI.Visible = false;
            escalateTohigherMangerBT.Visible = false;
            escalateToPeerBT.Visible = false;
            pickAuthlabelinReqTab.Visible = false;
            authorizersDDReqTab.Visible = false;
            placeReqBTinOutside.Visible = false;
            pleaseChooinOutside.Visible = false;
            authorizerDDinOutside.Visible = false;
            ErrorLabelInNewCustPI.Text = "this is where you get errors";

          
             
            try
            {
                string username = Session["userName"].ToString();
                User currentUser = UserModel.GetUser(username);
                Session["roleID"] = currentUser.roleId;
                Session["deptID"] = currentUser.departmentId;
             
                if (!IsPostBack)
                {                    
                    FieldValidator objField = new FieldValidator();
                    if (objField.validate_UserName(Session["userName"].ToString()))
                    {
                        TabContainer2.Visible = false;
                        TabContainer1.Visible = false;
                        TabContainer1.ActiveTabIndex = 0;
                        TabContainer2.ActiveTabIndex = 0;
                        TabContainer3.ActiveTabIndex = 0;
                        TabContainer4.ActiveTabIndex = 0;
                        TabContainer5.ActiveTabIndex = 0;
                        TabContainer6.ActiveTabIndex = 0;
                        TabContainer7.ActiveTabIndex = 0;
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
                        //Edit Profile Panel Images
                        img_site_int1.ImageUrl = "./Images/SiteKeys/SiteKey1.jpg";
                        img_site_int2.ImageUrl = "./Images/SiteKeys/SiteKey2.jpg";
                        img_site_int3.ImageUrl = "./Images/SiteKeys/SiteKey3.jpg";
                        img_site_int4.ImageUrl = "./Images/SiteKeys/SiteKey4.jpg";
                        img_site_int5.ImageUrl = "./Images/SiteKeys/SiteKey5.jpg";
                        img_site_int6.ImageUrl = "./Images/SiteKeys/SiteKey6.jpg";
                        img_site_int7.ImageUrl = "./Images/SiteKeys/SiteKey7.jpg";
                        img_site_int8.ImageUrl = "./Images/SiteKeys/SiteKey8.jpg";
                        img_site_int9.ImageUrl = "./Images/SiteKeys/SiteKey9.jpg";
                        img_site_int10.ImageUrl = "./Images/SiteKeys/SiteKey10.jpg";
                        img_site_int11.ImageUrl = "./Images/SiteKeys/SiteKey11.jpg";
                        img_site_int12.ImageUrl = "./Images/SiteKeys/SiteKey12.jpg";
                        img_site_int13.ImageUrl = "./Images/SiteKeys/SiteKey13.jpg";
                        img_site_int14.ImageUrl = "./Images/SiteKeys/SiteKey14.jpg";
                        img_site_int15.ImageUrl = "./Images/SiteKeys/SiteKey15.jpg";
                        img_site_int16.ImageUrl = "./Images/SiteKeys/SiteKey16.jpg";
                        img_site_int17.ImageUrl = "./Images/SiteKeys/SiteKey17.jpg";
                        img_site_int18.ImageUrl = "./Images/SiteKeys/SiteKey18.jpg";
                        img_site_int19.ImageUrl = "./Images/SiteKeys/SiteKey19.jpg";
                        img_site_int20.ImageUrl = "./Images/SiteKeys/SiteKey20.jpg";

                        //img_site1_AE.ImageUrl = "./Images/SiteKeys/SiteKey1.jpg";
                        //img_site2_AE.ImageUrl = "./Images/SiteKeys/SiteKey2.jpg";
                        //img_site3_AE.ImageUrl = "./Images/SiteKeys/SiteKey3.jpg";
                        //img_site4_AE.ImageUrl = "./Images/SiteKeys/SiteKey4.jpg";
                        //img_site5_AE.ImageUrl = "./Images/SiteKeys/SiteKey5.jpg";
                        //img_site6_AE.ImageUrl = "./Images/SiteKeys/SiteKey6.jpg";
                        //img_site7_AE.ImageUrl = "./Images/SiteKeys/SiteKey7.jpg";
                        //img_site8_AE.ImageUrl = "./Images/SiteKeys/SiteKey8.jpg";
                        //img_site9_AE.ImageUrl = "./Images/SiteKeys/SiteKey9.jpg";
                        //img_site10_AE.ImageUrl = "./Images/SiteKeys/SiteKey10.jpg";
                        //img_site11_AE.ImageUrl = "./Images/SiteKeys/SiteKey11.jpg";
                        //img_site12_AE.ImageUrl = "./Images/SiteKeys/SiteKey12.jpg";
                        //img_site13_AE.ImageUrl = "./Images/SiteKeys/SiteKey13.jpg";
                        //img_site14_AE.ImageUrl = "./Images/SiteKeys/SiteKey14.jpg";
                        //img_site15_AE.ImageUrl = "./Images/SiteKeys/SiteKey15.jpg";
                        //img_site16_AE.ImageUrl = "./Images/SiteKeys/SiteKey16.jpg";
                        //img_site17_AE.ImageUrl = "./Images/SiteKeys/SiteKey17.jpg";
                        //img_site18_AE.ImageUrl = "./Images/SiteKeys/SiteKey18.jpg";
                        //img_site19_AE.ImageUrl = "./Images/SiteKeys/SiteKey19.jpg";
                        //img_site20_AE.ImageUrl = "./Images/SiteKeys/SiteKey20.jpg";

                        int? userRole = UserModel.GetUser(Session["userName"].ToString()).roleId;
                        int? userDept = UserModel.GetUser(Session["userName"].ToString()).departmentId;
                        if (userRole != null)
                        {
                            if (userRole == 4)
                            {
                                //Regular Employee
                                TabContainer1.ActiveTabIndex = 0;
                                TabContainer1.Visible = true;
                                TabContainer1.Tabs[2].Visible = false;
                                TabContainer1.Tabs[3].Visible = false;
                                TabContainer1.Tabs[0].Visible = true;
                                TabContainer1.Tabs[1].Visible = true;
                                TabContainer1.Tabs[4].Visible = true;
                                if (userDept == 5)
                                {
                                    //HR Regular Employee
                                    TabContainer1.Tabs[0].Visible = false;
                                    TabContainer1.Tabs[1].Visible = false;
                                    TabContainer1.Tabs[2].Visible = false;
                                    TabContainer1.Tabs[3].Visible = false;
                                    TabContainer1.Tabs[4].Visible = true;
                                    TabContainer1.Tabs[5].Visible = true;
                                    TabContainer1.ActiveTabIndex = 5;
                                }
                            }
                            else if (userRole == 5)
                            {
                                //Department Manager
                                TabContainer1.ActiveTabIndex = 0;
                                TabContainer1.Visible = true;
                                TabContainer1.Tabs[2].Visible = true;
                                TabContainer1.Tabs[3].Visible = true;
                                TabContainer1.Tabs[0].Visible = true;
                                TabContainer1.Tabs[1].Visible = false;
                                TabContainer1.Tabs[4].Visible = true;
                                if (userDept == 5)
                                {
                                    //HR Department Manager
                                    TabContainer1.Tabs[0].Visible = false;
                                    TabContainer1.Tabs[1].Visible = false;
                                    TabContainer1.Tabs[2].Visible = true;
                                    TabContainer1.Tabs[3].Visible = true;
                                    TabContainer1.Tabs[4].Visible = true;
                                    TabContainer1.Tabs[5].Visible = true;
                                    TabContainer1.ActiveTabIndex = 5;
                                    lblSalesHgrCount.Visible = true;
                                    lblHRHgrCount.Visible = true;
                                    lblITHgrCount.Visible = true;
                                    tbHRHgrCount.Visible = true;
                                    tbITHgrCount.Visible = true;
                                    tbSalesHgrCount.Visible = true;
                                }
                            }
                            else if (userRole == 6)
                            {
                                //Higher Management
                                TabContainer1.ActiveTabIndex = 2;
                                TabContainer1.Visible = true;
                                TabContainer1.Tabs[0].Visible = false;
                                TabContainer1.Tabs[1].Visible = false;
                                TabContainer1.Tabs[2].Visible = true;
                                TabContainer1.Tabs[3].Visible = true;
                                TabContainer1.Tabs[4].Visible = true;
                            }
                            else
                            {
                                //Invalid Role ID
                                //Log Out functionality here
                                Session["userName"] = "";
                                Response.Redirect("ExternalHomePage.aspx", false);
                            }
                        }
                        else
                        {
                            //Invalid Role ID
                            //Log Out functionality here
                            Session["userName"] = "";
                            Response.Redirect("ExternalHomePage.aspx", false);
                        }
                    }
                    else
                    {
                        //Invalid Session Object
                        //Log Out Functionality
                        Session["userName"] = "";
                        Response.Redirect("ExternalHomePage.aspx", false);
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                //Invalid Session Object
                Session["userName"] = "";
                Response.Redirect("ExternalHomePage.aspx", false);
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

            //Edit Tab Images
            img_site_int1.BorderStyle = BorderStyle.None;
            img_site_int2.BorderStyle = BorderStyle.None;
            img_site_int3.BorderStyle = BorderStyle.None;
            img_site_int4.BorderStyle = BorderStyle.None;
            img_site_int5.BorderStyle = BorderStyle.None;
            img_site_int6.BorderStyle = BorderStyle.None;
            img_site_int7.BorderStyle = BorderStyle.None;
            img_site_int8.BorderStyle = BorderStyle.None;
            img_site_int9.BorderStyle = BorderStyle.None;
            img_site_int10.BorderStyle = BorderStyle.None;
            img_site_int11.BorderStyle = BorderStyle.None;
            img_site_int12.BorderStyle = BorderStyle.None;
            img_site_int13.BorderStyle = BorderStyle.None;
            img_site_int14.BorderStyle = BorderStyle.None;
            img_site_int15.BorderStyle = BorderStyle.None;
            img_site_int16.BorderStyle = BorderStyle.None;
            img_site_int17.BorderStyle = BorderStyle.None;
            img_site_int18.BorderStyle = BorderStyle.None;
            img_site_int19.BorderStyle = BorderStyle.None;
            img_site_int20.BorderStyle = BorderStyle.None;
            //img_site1_AE.BorderStyle = BorderStyle.None;
            //img_site2_AE.BorderStyle = BorderStyle.None;
            //img_site3_AE.BorderStyle = BorderStyle.None;
            //img_site4_AE.BorderStyle = BorderStyle.None;
            //img_site5_AE.BorderStyle = BorderStyle.None;
            //img_site6_AE.BorderStyle = BorderStyle.None;
            //img_site7_AE.BorderStyle = BorderStyle.None;
            //img_site8_AE.BorderStyle = BorderStyle.None;
            //img_site9_AE.BorderStyle = BorderStyle.None;
            //img_site10_AE.BorderStyle = BorderStyle.None;
            //img_site11_AE.BorderStyle = BorderStyle.None;
            //img_site12_AE.BorderStyle = BorderStyle.None;
            //img_site13_AE.BorderStyle = BorderStyle.None;
            //img_site14_AE.BorderStyle = BorderStyle.None;
            //img_site15_AE.BorderStyle = BorderStyle.None;
            //img_site16_AE.BorderStyle = BorderStyle.None;
            //img_site17_AE.BorderStyle = BorderStyle.None;
            //img_site18_AE.BorderStyle = BorderStyle.None;
            //img_site19_AE.BorderStyle = BorderStyle.None;
            //img_site20_AE.BorderStyle = BorderStyle.None;
        }

        protected void img_site1_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "1";
            img_site1.BorderColor = System.Drawing.Color.DarkBlue;
            img_site1.BorderStyle = BorderStyle.Solid;
            //img_site1_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site1_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site2_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "2";
            img_site2.BorderColor = System.Drawing.Color.DarkBlue;
            img_site2.BorderStyle = BorderStyle.Solid;
            //img_site2_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site2_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site3_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "3";
            img_site3.BorderColor = System.Drawing.Color.DarkBlue;
            img_site3.BorderStyle = BorderStyle.Solid;
            //img_site3_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site3_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site4_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "4";
            img_site4.BorderColor = System.Drawing.Color.DarkBlue;
            img_site4.BorderStyle = BorderStyle.Solid;
            //img_site4_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site4_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site5_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "5";
            img_site5.BorderColor = System.Drawing.Color.DarkBlue;
            img_site5.BorderStyle = BorderStyle.Solid;
            //img_site5_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site5_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site6_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "6";
            img_site6.BorderColor = System.Drawing.Color.DarkBlue;
            img_site6.BorderStyle = BorderStyle.Solid;
            //img_site6_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site6_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site7_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "7";
            img_site7.BorderColor = System.Drawing.Color.DarkBlue;
            img_site7.BorderStyle = BorderStyle.Solid;
            //img_site7_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site7_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site8_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "8";
            img_site8.BorderColor = System.Drawing.Color.DarkBlue;
            img_site8.BorderStyle = BorderStyle.Solid;
            //img_site8_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site8_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site9_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "9";
            img_site9.BorderColor = System.Drawing.Color.DarkBlue;
            img_site9.BorderStyle = BorderStyle.Solid;
            //img_site9_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site9_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site10_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "10";
            img_site10.BorderColor = System.Drawing.Color.DarkBlue;
            img_site10.BorderStyle = BorderStyle.Solid;
            //img_site10_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site10_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site11_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "11";
            img_site11.BorderColor = System.Drawing.Color.DarkBlue;
            img_site11.BorderStyle = BorderStyle.Solid;
            //img_site11_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site11_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site12_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "12";
            img_site12.BorderColor = System.Drawing.Color.DarkBlue;
            img_site12.BorderStyle = BorderStyle.Solid;
            //img_site12_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site12_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site13_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "13";
            img_site13.BorderColor = System.Drawing.Color.DarkBlue;
            img_site13.BorderStyle = BorderStyle.Solid;
            //img_site13_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site13_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site14_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "14";
            img_site14.BorderColor = System.Drawing.Color.DarkBlue;
            img_site14.BorderStyle = BorderStyle.Solid;
            //img_site14_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site14_AE.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site15_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "15";
            img_site15.BorderColor = System.Drawing.Color.DarkBlue;
            img_site15.BorderStyle = BorderStyle.Solid;
            //img_site15_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site15_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site16_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "16";
            img_site16.BorderColor = System.Drawing.Color.DarkBlue;
            img_site16.BorderStyle = BorderStyle.Solid;
            //img_site16_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site16_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site17_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "17";
            img_site17.BorderColor = System.Drawing.Color.DarkBlue;
            img_site17.BorderStyle = BorderStyle.Solid;
            //img_site17_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site17_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site18_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "18";
            img_site18.BorderColor = System.Drawing.Color.DarkBlue;
            img_site18.BorderStyle = BorderStyle.Solid;
            //img_site18_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site18_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site19_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "19";
            img_site19.BorderColor = System.Drawing.Color.DarkBlue;
            img_site19.BorderStyle = BorderStyle.Solid;
            //img_site19_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site19_AE.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site20_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "20";
            img_site20.BorderColor = System.Drawing.Color.DarkBlue;
            img_site20.BorderStyle = BorderStyle.Solid;
            //img_site20_AE.BorderColor = System.Drawing.Color.DarkBlue;
            //img_site20_AE.BorderStyle = BorderStyle.Solid;
        }

        protected void btn_maketransinside_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx", false);
            }
            else
            {
            //Transfer Money to Accounts within the bank
            bool serverSideValidation = false;
            try
            {
                checkSession();
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
                                    if (objLastZip.lastName.ToLower().Equals(tb_lastname_IU_Inside.Text.ToLower())
                                            && objLastZip.zipcode.ToString().Equals(tb_zip_IU_Inside.Text.ToString()))
                                    {

                                        double amount = Convert.ToDouble(tb_amount_IU_Inside.Text);


                                        if (amount < 1000)
                                        {

                                            string desc = "From : " + fromAccTypeDD_TransferExistingCust_Inside.SelectedValue.ToString() + " To : " + tb_recepient_IU_Inside.Text.ToString() +
                                                                               " Amount : " + tb_amount_IU_Inside.Text.ToString();
                                            int insertedtransID = TransactionModel.MakeInternalTransfer(objCard.accountNumber, tb_recepient_IU_Inside.Text.ToString(),
                                                                       Convert.ToDouble(tb_amount_IU_Inside.Text.ToString()), desc);
                                            if (insertedtransID > 0)
                                            {
                                                lblSuccess_IUInside.Text = "Transaction Successful";
                                                lblSuccess_IUInside.Visible = true;
                                            }
                                            else
                                            {
                                                lblSuccess_IUInside.Text = "Transaction Unsuccessful,Check balance";
                                                lblSuccess_IUInside.Visible = true;
                                            }
                                        }
                                        else if (amount >= 1000 && amount < 30000)
                                        {

                                            string desc = "ctLevel1";
                                            int success = TransactionModel.MakeInternalTransfer(objCard.accountNumber, tb_recepient_IU_Inside.Text.ToString(),
                                                                       Convert.ToDouble(tb_amount_IU_Inside.Text.ToString()), desc);
                                            if (success > 0)
                                            {
                                                bool criticaltranslevel1approved = TransactionModel.ApproveTransaction(success);
                                                if (criticaltranslevel1approved)
                                                {
                                                    lblSuccess_IUInside.Text = "Critical Transaction level 1 successfully approved";
                                                    lblSuccess_IUInside.Visible = true;
                                                }
                                                else
                                                {
                                                    lblSuccess_IUInside.Text = "Critical Transaction level 1 could not be approved";
                                                    lblSuccess_IUInside.Visible = true;
                                                }
                                            }
                                            else
                                            {
                                                lblSuccess_IUInside.Text = "Unable to place and approve level 1 request";
                                                lblSuccess_IUInside.Visible = true;
                                            }
                                        }
                                        else
                                        {

                                            lblSuccess_IUInside.Text = "This is a level 2 critical transaction,please choose an authorizer to initiate processing";
                                            lblSuccess_IUInside.Visible = true;
                                            int DeptID = Convert.ToInt32(Session["deptID"]);
                                            int RoleID = Convert.ToInt32(Session["roleID"]);
                                            List<string> higherAuthorizers = getHigherAuthorizersfor(RoleID, DeptID);
                                            if (higherAuthorizers.Count > 0)
                                            {
                                                authorizerDropDown.DataSource = higherAuthorizers;
                                                authorizerDropDown.DataBind();
                                                authorizerDropDown.Visible = true;
                                                requetAuthLb.Visible = true;
                                                placeReqBT.Visible = true;
                                            }
                                            else
                                            {
                                                lblSuccess_IUInside.Text = "This transcation needs approval,could not find a authorizer";
                                                lblSuccess_IUInside.Visible = true;

                                            }

                                        }
                                    }
                                    else {
                                        lblSuccess_IUInside.Text = "Please check your zip and lastname for the account";
                                        lblSuccess_IUInside.Visible = true;
                                    }
                                }
                                else
                                {
                                    lblSuccess_IUInside.Text = "Please check your zip and lastname for the account";
                                    lblSuccess_IUInside.Visible = true;
                                }
                            }
                            else
                            {
                                lblSuccess_IUInside.Text = "Please check your card Security code details";
                                lblSuccess_IUInside.Visible = true;
                            }
                        }
                        else
                        {
                            lblSuccess_IUInside.Text = "Please check your card expiry details";
                            lblSuccess_IUInside.Visible = true;
                        }
                    }
                    else
                    {
                        lblSuccess_IUInside.Text = "Please check your card details";
                        lblSuccess_IUInside.Visible = true;
                    }
                }
                else
                {
                    lblSuccess_IUInside.Text = "Invalid Entries. Please check the details";
                    lblSuccess_IUInside.Visible = true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                existingCustErrLb.Text = "Could not process your transaction";
                lblSuccess_IUInside.Visible = true;
            }
        }        
        }        

        protected void btnVerify_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx", false);
            }
            else
            {
                bool serverSideValidation = false;
                try
                {
                    checkSession();
                    serverSideValidation = validateFromFields(tbCardNumber_IU.Text.ToString(), tbYear_IU.Text.ToString());
                    if (serverSideValidation)
                    {
                        //Proceed with business logic here
                        User objUser = CardModel.UserForCard(tbCardNumber_IU.Text.ToString());
                        if (objUser != null)
                        {
                            string strDob = MonthDD_ExistingCustomer_Verify.SelectedValue.ToString() + '/' + DayDD_ExistingCustomer_Verify.SelectedValue.ToString()
                                + '/' + tbYear_IU.Text.ToString();
                            if (objUser.VerifyDoB(strDob))
                            {
                                if (rb_PhotoID.SelectedValue.ToLower().Equals("yes"))
                                {
                                    Session["ExistingCustName"] = objUser.username;
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
                                            if (acc.accountTypeId == 3)
                                            {
                                                //Savings Account
                                                tb_savings.Text = acc.accountNumber.ToString();
                                                fromAccTypeDD_TransferExistingCust_Inside.Items.Add(acc.accountNumber.ToString());
                                                accTypeDD_TransferExistingCust_Outside.Items.Add(acc.accountNumber.ToString());
                                                fromAccTypeDD_TransferExistingCust_Between.Items.Add(acc.accountNumber.ToString());
                                                toAccTypeDD_TransferExistingCust_Between.Items.Add(acc.accountNumber.ToString());
                                                accTypeDD_TransferExistingCust_Debit.Items.Add(acc.accountNumber.ToString());
                                                accTypeDD_TransferExistingCust_Credit.Items.Add(acc.accountNumber.ToString());
                                                lblSavingsBalance.Text = Convert.ToString(acc.balance);
                                                tb_savings.ReadOnly = true;
                                                if (objUser.roleId == 3)
                                                {
                                                    merchant_savingsAccNum = acc.accountNumber;
                                                }
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
                                                lblCheckingBalance.Text = Convert.ToString(acc.balance);
                                                tb_checking.ReadOnly = true;
                                            }
                                            else if (acc.accountTypeId == 1)
                                            {
                                                //credit account
                                                //tb_credit.Text = acc.accountNumber.ToString();
                                                //tb_credit.ReadOnly = true;
                                            }
                                            btnVerify0.Enabled = false;
                                            existingCustErrLb.Text = "";
                                        }
                                    }
                                    else
                                    {

                                        existingCustErrLb.Text = "Unable to fetch Accounts";
                                    }

                                }
                                else
                                {
                                    existingCustErrLb.Text = "Please verify the customer's photo ID";
                                    TabContainer2.Visible = false;
                                }
                            }
                            else
                            {
                                existingCustErrLb.Text = "Invalid DOB";
                            }
                        }
                        else
                        {
                            existingCustErrLb.Text = "Card details invalid";
                        }
                    }
                    else
                    {
                        existingCustErrLb.Text = "Input invalid check the details";
                    }
                }
                catch (Exception exp)
                {
                    Elog.Error("Exception occurred: " + exp.Message);
                }
            }
        }

        protected void btn_maketransferoutside_Click(object sender, EventArgs e)
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
                checkSession();
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


                                double amount = Convert.ToDouble(tb_amountoutside.Text);


                                if (amount < 1000)
                                {
                                string desc = "From : " + accTypeDD_TransferExistingCust_Outside.SelectedValue.ToString() + " To : " + tb_AccNumoutside_Intenal.Text.ToString() +
                                                                       " Amount : " + tb_amountoutside.Text.ToString() + " EMAIL : " + tb_emailoutside.Text.ToString();
                                int success = TransactionModel.MakeExternalTransfer(objCard.accountNumber, objCard.Account.routingNumber, tb_AccNumoutside_Intenal.Text.ToString(),
                                                            tb_toRoutingNum_OutsideBank.Text.ToString(), Convert.ToDouble(tb_amountoutside.Text.ToString()), desc);
                                    if (success > 0)
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
                                else if (amount >= 1000 && amount < 30000)
                                {

                                    string desc = "ctLevel1";
                                    int success = TransactionModel.MakeExternalTransfer(objCard.accountNumber, objCard.Account.routingNumber, tb_AccNumoutside_Intenal.Text.ToString(),
                                                            tb_toRoutingNum_OutsideBank.Text.ToString(), Convert.ToDouble(tb_amountoutside.Text.ToString()), desc);
                                    if (success > 0)
                                    {
                                        bool criticaltranslevel1approved = TransactionModel.ApproveTransaction(success);
                                        if (criticaltranslevel1approved)
                                        {
                                            lblStatus_OutsideBank.Text = "Critical Transaction level 1 successfully approved";
                                            lblStatus_OutsideBank.Visible = true;
                                        }
                                        else
                                        {
                                            lblStatus_OutsideBank.Text = "Critical Transaction level 1 could not be approved";
                                            lblStatus_OutsideBank.Visible = true;
                                        }
                                    }
                                    else
                                    {
                                        lblStatus_OutsideBank.Text = "Unable to place and approve level 1 request";
                                        lblStatus_OutsideBank.Visible = true;
                                    }


                                }
                                else
                                {

                                    lblStatus_OutsideBank.Text = "This is a level 2 critical transaction,please choose an authorizer to initiate processing";
                                    lblStatus_OutsideBank.Visible = true;
                                    int DeptID = Convert.ToInt32(Session["deptID"]);
                                    int RoleID = Convert.ToInt32(Session["roleID"]);
                                    List<string> higherAuthorizers = getHigherAuthorizersfor(RoleID, DeptID);
                                    if (higherAuthorizers.Count > 0)
                                    {
                                        authorizerDDinOutside.DataSource = higherAuthorizers;
                                        authorizerDDinOutside.DataBind();
                                        authorizerDDinOutside.Visible = true;
                                        pleaseChooinOutside.Visible = true;
                                        placeReqBTinOutside.Visible = true;
                                    }
                                    else
                                    {
                                        lblSuccess_IUInside.Text = "This transcation needs approval,could not find a authorizer";
                                        lblSuccess_IUInside.Visible = true;

                                    }

                                }
                            
                            }
                            else
                            {
                                lblStatus_OutsideBank.Text = "Invalid card security code details";
                                lblStatus_OutsideBank.Visible = true;
                            }
                        }
                        else
                        {
                            lblStatus_OutsideBank.Text = "Invalid card expiry details";
                            lblStatus_OutsideBank.Visible = true;
                        }
                    }
                    else
                    {
                        lblStatus_OutsideBank.Text = "Invalid card details";
                        lblStatus_OutsideBank.Visible = true;
                    }
                }
                else
                {
                    lblStatus_OutsideBank.Text = "Invalid Entries . Please check the details";
                    lblStatus_OutsideBank.Visible = true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                lblStatus_OutsideBank.Text = "Could not proceed with trans in DB";
                lblStatus_OutsideBank.Visible = true;
            }
        }
        }

        protected void btn_maketransbetween_Click(object sender, EventArgs e)
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
                checkSession();
                serverSideValidation = validateFromFields(tb_amountbetween.Text.ToString());
                if (serverSideValidation)
                {
                    double amount=Convert.ToDouble(tb_amountbetween.Text.ToString());
                    if (amount <= 1000)
                    {
                        //Proceed with business logic here
                        string iToAcc = toAccTypeDD_TransferExistingCust_Between.SelectedValue.ToString();
                        string ifromAcc = fromAccTypeDD_TransferExistingCust_Between.SelectedValue.ToString();
                        int success = TransactionModel.MakeInternalTransfer(ifromAcc, iToAcc, Convert.ToDouble(tb_amountbetween.Text.ToString()),
                                    "From : " + fromAccTypeDD_TransferExistingCust_Between.SelectedValue.ToString() +
                                        "To : " + toAccTypeDD_TransferExistingCust_Between.Text.ToString() +
                                            "- Amount : " + tb_amountbetween.Text.ToString());
                        if (success > 0)
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
                    else {
                        lblStatus_Between.Text = "Cannot transfer more than 1000$ in this mode";
                        lblStatus_Between.Visible = true;
                    }
                }
                else
                {
                    lblStatus_Between.Text = "Please check your inputs";
                    lblStatus_Between.Visible = true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }
        }


        protected void btn_maketransDebitFunds_Click(object sender, EventArgs e)
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
                checkSession();
                serverSideValidation = validateFromFieldsatCredit(tb_card_DebitFunds.Text.ToString(), tb_securitycode_DebitFunds.Text.ToString(),
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
                                double amount = Convert.ToDouble(tb_amountoutside_DebitFunds.Text.ToString());
                                if (amount <= 1000)
                                {

                                    int success = TransactionModel.WithdrawFundsFromAccoount(accTypeDD_TransferExistingCust_Debit.SelectedValue.ToString(),
                                                                 Convert.ToDouble(tb_amountoutside_DebitFunds.Text.ToString()));

                                    if (success > 0)
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

                                    lblStatus_DebitFunds.Text = "You cannot debit more han 1000$ in this mode";
                                    lblStatus_DebitFunds.Visible = true;
                                }
                            }
                            else
                            {
                                lblStatus_DebitFunds.Text = "Invalid card details";
                                lblStatus_DebitFunds.Visible = true;
                            }
                        }
                        else
                        {
                            lblStatus_DebitFunds.Text = "Invalid card details";
                            lblStatus_DebitFunds.Visible = true;
                        }
                    }
                    else {
                        lblStatus_DebitFunds.Text = "Invalid card details";
                        lblStatus_DebitFunds.Visible = true;
                    }
                }
                else
                {
                    lblStatus_DebitFunds.Text = "Please check the details";
                    lblStatus_DebitFunds.Visible = true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                lblStatus_DebitFunds.Text = "Could not proceed with DB changes";
                lblStatus_DebitFunds.Visible = true;
            }
        }
        }

        protected void btn_maketrans_CreditFunds_Click(object sender, EventArgs e)
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
                checkSession();
                serverSideValidation = validateFromFieldsatCredit(tb_card_CreditFunds.Text.ToString(), tb_securitycode_CreditFunds.Text.ToString(),
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
                                double amount = Convert.ToDouble(tb_amountoutside_DebitFunds.Text.ToString());
                                if (amount <= 1000)
                                {
                                    int success = TransactionModel.DepositFundsToAccoount(accTypeDD_TransferExistingCust_Debit.SelectedValue.ToString(),
                                                                 Convert.ToDouble(tb_amountoutside_DebitFunds.Text.ToString()));
                                    if (success > 0)
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

                                    lblStatus_CreditFunds.Text = "You cannot credit more than 1000$ through this method";
                                    lblStatus_CreditFunds.Visible = true;
                                }
                            }
                            else
                            {
                                lblStatus_CreditFunds.Text = "Invalid card details";
                                lblStatus_CreditFunds.Visible = true;
                            }
                        }
                        else
                        {
                            lblStatus_CreditFunds.Text = "Invalid card details";
                            lblStatus_CreditFunds.Visible = true;
                        }
                    }
                    else {
                        lblStatus_CreditFunds.Text = "Invalid card details";
                        lblStatus_CreditFunds.Visible = true;
                    }
                }
                else
                {
                    lblStatus_CreditFunds.Text = "Please check the details";
                    lblStatus_CreditFunds.Visible = true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                lblStatus_CreditFunds.Text = "Could not proceed with DB action";
                lblStatus_CreditFunds.Visible = true;
            }
        }
        }


        protected void btn_changesettings_profile_Click(object sender, EventArgs e)
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
                checkSession();
                    serverSideValidation = validateFromFields_editProfile(tb_email_Edit.Text.ToString(), tb_stAddr_Edit.Text.ToString(), tb_city_Edit.Text.ToString(),
                                        tb_zipCode_Edit.Text.ToString(), tb_contact_Edit.Text.ToString(), tb_nickname_Edit.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    bool success = UserModel.UpdateUser(Session["ExistingCustName"].ToString(), tb_email_Edit.Text.ToString(), tb_stAddr_Edit.Text.ToString(), tb_city_Edit.Text.ToString(),
                                                StateDD_EditProfile.SelectedValue.ToString(), tb_zipCode_Edit.Text.ToString(), tb_contact_Edit.Text.ToString());
                    if (success)
                    {
                        lblStatus_ChangeProf.Text = "Update Successful";
                        lblStatus_ChangeProf.Visible = true;
                    }
                    else
                    {
                        lblStatus_ChangeProf.Text = "Update Unsuccessful";
                        lblStatus_ChangeProf.Visible = true;
                    }
                }
                else
                {
                    lblStatus_ChangeProf.Text = "Please check the inputs";
                    lblStatus_ChangeProf.Visible = true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                lblStatus_ChangeProf.Text = "Could not make DB action";
                lblStatus_ChangeProf.Visible = true;
            }
        }
        }

        protected void btn_changepwd_Internal_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx",false);
            }
            else
            {
            //Make a payment on behalf of the customer
            bool serverSideValidation = false;
            try
            {
                checkSession();
                Dictionary<int, string> dictAns = new Dictionary<int, string>();
                dictAns.Add(1, tb_secans1.Text.ToString());
                dictAns.Add(2, tb_secans2.Text.ToString());
                dictAns.Add(3, tb_secans3.Text.ToString());
                serverSideValidation = validateFromFields(tb_oldpwd.Text.ToString(), dictAns, tb_newPassword.Text.ToString(), tb_confrimPassword.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    if (LoginModel.LoginUser(Session["ExistingCustName"].ToString(), tb_oldpwd.Text.ToString()) > 0)
                    {
                        string strAns1 = (lstQandA.First().answer).ToLower();
                        string strAns2 = (lstQandA.ElementAt(1).answer).ToLower();
                        string strAns3 = (lstQandA.Last().answer).ToLower();

                        if (tb_secans1.Text.ToLower().Equals(strAns1) && tb_secans2.Text.ToLower().Equals(strAns2)
                                && tb_secans3.Text.ToLower().Equals(strAns3))
                        {
                            if (tb_newPassword.Text.Equals(tb_confrimPassword.Text) && !(tb_newPassword.Text.Equals(tb_oldpwd.Text)))
                            {
                                bool success = PasswordModel.ChangePwd(Session["ExistingCustName"].ToString(), tb_newPassword.Text.ToString());
                                if (success)
                                {
                                    lblStatus_ChangePswd.Text = "Password Changed Successfully";
                                    lblStatus_ChangePswd.Visible = true;
                                }
                                else
                                {
                                    lblStatus_ChangePswd.Text = "Password Changed Failed, Please try again";
                                    lblStatus_ChangePswd.Visible = true;
                                }
                            }
                            else
                            {
                                lblStatus_ChangePswd.Text = "Password dont match";
                                lblStatus_ChangePswd.Visible = true;
                            }
                        }
                        else
                        {
                            lblStatus_ChangePswd.Text = "Answers invalid";
                            lblStatus_ChangePswd.Visible = true;
                        }
                    }
                    else
                    {
                        lblStatus_ChangePswd.Text = "Please check old passwords";
                        lblStatus_ChangePswd.Visible = true;
                    }
                }
                else
                {
                    lblStatus_ChangePswd.Text = "Please check inputs";
                    lblStatus_ChangePswd.Visible = true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }
        }

        protected void btn_cardsubmitpayment_Click(object sender, EventArgs e)
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
                checkSession();
                    serverSideValidation = validateFromFields(tb_cardnum.Text.ToString(), tb_customername.Text.ToString(), tb_amount_SubmitPayment.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    //Similar to inside bank transfers
                    Models.Tables.Card objCard = AccountModel.GetCardDetails(tb_cardnum.Text.ToString());
                    if (objCard != null)
                    {
                        string cardName = objCard.firstName + objCard.middleInitial + objCard.lastName;
                        string cardNameUserInput = Regex.Replace(tb_customername.Text.ToString(), @"\s+", "");
                        if (cardName.ToLower().Equals(cardNameUserInput.ToLower()))
                        {
                            string strExpDate = string.Empty;
                            strExpDate = cardExpDD_CardPayment.SelectedValue.ToString() + yearDD_CardPayment.SelectedValue.ToString();
                            if (objCard.expirationDate.Equals(strExpDate))
                            {
                                string sToAcc = merchant_savingsAccNum;
                                string sfromAcc = objCard.accountNumber;
                                int success = TransactionModel.MakeInternalTransfer(sfromAcc, sToAcc, Convert.ToDouble(tb_amount_SubmitPayment.Text.ToString()),
                                            "From : " + sfromAcc + "To : " + sToAcc + "- Amount : " + tb_amount_SubmitPayment.Text.ToString());
                                if (success > 0)
                                {
                                    lblSubmitPayment.Text = "Transaction Successful";
                                    tb_amount_SubmitPayment.Text = "";
                                    lblSubmitPayment.Visible = true;
                                }
                                else
                                {
                                    lblSubmitPayment.Text = "Transaction Unsuccessful";
                                    tb_amount_SubmitPayment.Text = "";
                                    lblSubmitPayment.Visible = true;
                                }
                            }
                            else
                            {
                                lblSubmitPayment.Text = "Invalid expiry date";
                                tb_amount_SubmitPayment.Text = "";
                                cardExpDD_CardPayment.SelectedIndex = 0;
                                yearDD_CardPayment.SelectedIndex = 0;
                                lblSubmitPayment.Visible = true;
                            }
                        }
                        else
                        {
                            lblSubmitPayment.Text = "Invalid card name";
                            tb_amount_SubmitPayment.Text = "";
                            tb_customername.Text = "";
                            lblSubmitPayment.Visible = true;
                        }
                    }
                    else
                    {
                        lblSubmitPayment.Text = "Invalid card";
                        tb_cardnum.Text = "";
                        lblSubmitPayment.Visible = true;
                    }
                }
                else
                {
                    lblSubmitPayment.Text = "Invalid entries. Please enter again.";
                    tb_cardnum.Text = "";
                    tb_customername.Text = "";
                    tb_amount_SubmitPayment.Text = "";
                    cardExpDD_CardPayment.SelectedIndex = 0;
                    yearDD_CardPayment.SelectedIndex = 0;
                    lblSubmitPayment.Visible = true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }
        }

        protected void btn_createcust_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx", false);
            }
            else
            {
                bool serverSideValidation = false;
                try
                {
                    checkSession();
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
                    Elog.Error("Exception occurred: " + exp.Message);
                }
            }
        }

        protected void btn_sumbitcust_Click(object sender, EventArgs e)
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
                checkSession();
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
                            userToCreate.roleId = Convert.ToInt32(DD_Role_NewCustomer.SelectedValue); ;
                            Address addressForUser = new Address();
                            addressForUser.firstName = tb_FirstName_Cust.Text.ToString();
                            addressForUser.lastName = tb_LastName_Cust.Text.ToString();
                            addressForUser.street1 = tb_StreetAddr_Cust.Text.ToString();
                            addressForUser.city = tb_City_Cust.Text.ToString();
                            addressForUser.state = StateDD_Cust.Text.ToString();
                            addressForUser.country = "US";
                            addressForUser.zip = Convert.ToInt32(tb_Zip_Cust.Text);
                            userToCreate.phone = tb_Phone_Cust.Text.ToString();
                            userToCreate.username = tb_UserName_Cust.Text.ToString();
                            string checkingAccountNumber = randomAccountNumberGenerator();
                            string savingsAccountNumber = randomAccountNumberGenerator();
                            string cardNumber = randomCardNumberGenerator();
                            string routingAccountNumber = randomAccountNumberGenerator();
                            int cvvNum =Convert.ToInt32( CVVNumberGenerator());
                            Card ChkcardForUser = new Card();
                            ChkcardForUser.cardNumber = cardNumber;
                            ChkcardForUser.accountNumber = checkingAccountNumber;
                            ChkcardForUser.cvv = cvvNum;
                            ChkcardForUser.expirationDate = "1118";
                            ChkcardForUser.firstName = userToCreate.firstName;
                            ChkcardForUser.middleInitial = userToCreate.middleName;
                            ChkcardForUser.lastName = userToCreate.lastName;
                            Card SavcardForUser = new Card();
                            SavcardForUser.cardNumber = cardNumber;
                            SavcardForUser.accountNumber = savingsAccountNumber;
                            SavcardForUser.cvv = cvvNum;
                            SavcardForUser.expirationDate = "1118";
                            SavcardForUser.firstName = userToCreate.firstName;
                            SavcardForUser.middleInitial = userToCreate.middleName;
                            SavcardForUser.lastName = userToCreate.lastName;
                            List<SecurityQuestion> securityQuestionsForUser = new List<SecurityQuestion>();
                            SecurityQuestion securityQuestionForUser1 = new SecurityQuestion();
                            securityQuestionForUser1.questionId = Convert.ToInt32(Sec1DD_PersonalInformation.SelectedValue);
                            securityQuestionForUser1.answer = tb_SecAns1_Cust.Text.ToString();
                            securityQuestionsForUser.Add(securityQuestionForUser1);
                            SecurityQuestion securityQuestionForUser2 = new SecurityQuestion();
                            securityQuestionForUser2.questionId = Convert.ToInt32(Sec2DD_PersonalInformation.SelectedValue);
                            securityQuestionForUser2.answer = tb_SecAns2_Cust.Text.ToString();
                            securityQuestionsForUser.Add(securityQuestionForUser2);
                            SecurityQuestion securityQuestionForUser3 = new SecurityQuestion();
                            securityQuestionForUser3.questionId = Convert.ToInt32(Sec3DD_PersonalInformation.SelectedValue);
                            securityQuestionForUser3.answer = tb_SecAns3_Cust.Text.ToString();
                            securityQuestionsForUser.Add(securityQuestionForUser3);
                            string socialSecurityNumber = tb_SSN_Cust.Text.ToString();
                            userToCreate.siteKeyVal = Convert.ToInt32(siteKeySelected);
                            userToCreate.siteKeyString = tb_sitekeyhint_Cust.Text.ToString();
                            string userDOB = monthDD_PersonalInformation.Text.ToString() + "/" + dayDD_PersonalInformation.Text.ToString() + "/" + tb_BirthYear_Cust.Text.ToString();
                            bool userCreated = UserModel.CreateUser(userToCreate, passwordForUser, socialSecurityNumber, userDOB, checkingAccountNumber, savingsAccountNumber, routingAccountNumber, ChkcardForUser, SavcardForUser, addressForUser, securityQuestionsForUser);
                            if (userCreated)
                            {
                                Models.Tables.User objNewUsr = UserModel.GetUser(userToCreate.username);
                                string emailstring = "Hi " + tb_FirstName_Cust.Text.ToString() + " your account has been succesfully created" + "<br>" + "Checking acc num :" + checkingAccountNumber + "<br>" + "Savings acc num:" + savingsAccountNumber + "<br>"+"Routing number:"+routingAccountNumber+"<br>" + "Card num:" + cardNumber + "<br>" + "cvv:" + cvvNum +"<br>"+ "Expiry date: Nov 2018" + "<br>" + "Date of birth" + monthDD_PersonalInformation.Text.ToString() + "/" + dayDD_PersonalInformation.Text.ToString() + "/" + tb_BirthYear_Cust.Text.ToString();
                                MailMessage mMailMessage = new MailMessage();

                                // Set the sender address of the mail message
                                mMailMessage.From = new MailAddress("bankse7en@gmail.com");
                                // Set the recepient address of the mail message
                                mMailMessage.To.Add(new MailAddress(tb_Email_Cust.Text.ToString()));


                                mMailMessage.Subject = "Greetings from bankse7en";
                                // Set the body of the mail message
                                mMailMessage.Body = emailstring;

                                if (objNewUsr.roleId == 3)
                                {
                                    string fileNameCert = PkiModel.GetCertificateNameForUsername(userToCreate.username);
                                    Attachment at = new Attachment(@"C:\Windows\SysWOW64\" + fileNameCert + ".pfx");
                                    mMailMessage.Attachments.Add(at);
                                }

                                // Set the format of the mail message body as HTML
                                mMailMessage.IsBodyHtml = true;
                                // Set the priority of the mail message to normal
                                mMailMessage.Priority = MailPriority.Normal;
                                SmtpClient mSmtpClient = new SmtpClient();
                                mSmtpClient.EnableSsl = true;
                                mSmtpClient.Send(mMailMessage);
                     
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
                    ErrorLabelInNewCustPI.Text = "Please verify the data you have entered";
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }
        }


        protected void btn_AddEmp_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx", false);
            }
            else
            {
                bool serverSideValidation1 = false;
                bool serverSideValidation2 = false;
                try
                {
                    checkSession();
                    serverSideValidation1 = validateFromFields(tb_FirstName_Emp.Text.ToString(), tb_MidName_Emp.Text.ToString(), tb_LastName_Emp.Text.ToString()
                        , tb_Email_Emp.Text.ToString(), " ", " ", tb_Phone_Emp.Text.ToString(), tb_Zip_Emp.Text.ToString());
                    FieldValidator fieldValidator = new FieldValidator();
                    serverSideValidation2 = fieldValidator.validate_ZipAccCrdPhn(tb_BirthYear_AddEmp.Text.ToString(), 4);
                    if (serverSideValidation1 && serverSideValidation2)
                    {
                        //Generating Username
                        string usernameGenerated = generateUsername(tb_FirstName_Emp.Text.ToString(), tb_LastName_Emp.Text.ToString());
                        string passwordGenerated = generatePassword();
                        User userForName = new User();
                        userForName = UserModel.GetUser(usernameGenerated);
                        while (userForName != null)
                        {
                            usernameGenerated = generateUsername(tb_FirstName_Emp.Text.ToString(), tb_LastName_Emp.Text.ToString());
                            userForName = UserModel.GetUser(usernameGenerated);
                        }
                        User userToCreate = new User();
                        userToCreate.firstName = tb_FirstName_Emp.Text.ToString();
                        userToCreate.middleName = tb_MidName_Emp.Text.ToString();
                        userToCreate.lastName = tb_LastName_Emp.Text.ToString();
                        userToCreate.email = tb_Email_Emp.Text.ToString();
                        userToCreate.departmentId = Convert.ToInt32(DeptDD_AddEmp.SelectedValue);
                        userToCreate.roleId = Convert.ToInt32(RoleDD_AddEmp.SelectedValue);
                        Address addressForUser = new Address();
                        addressForUser.firstName = userToCreate.firstName;
                        addressForUser.lastName = userToCreate.lastName;
                        addressForUser.country = "US";
                        addressForUser.street1 = tb_StreetAddr_Emp.Text.ToString();
                        addressForUser.city = tb_City_Emp.Text.ToString();
                        addressForUser.state = StateDD_Emp.Text.ToString();
                        addressForUser.zip = Convert.ToInt32(tb_Zip_Emp.Text);
                        userToCreate.phone = tb_Phone_Emp.Text.ToString();
                        userToCreate.username = usernameGenerated;
                        string userDOB = monthDD_PersonalInformation_AddEmp.Text.ToString() + "/" + dayDD_PersonalInformation_AddEmp.Text.ToString() + "/" + tb_BirthYear_AddEmp.Text.ToString();
                        bool userCreated = UserModel.CreateEmployee(userToCreate, passwordGenerated, "", userDOB, addressForUser, null);
                        if (userCreated)
                        {
                            //Mailing employee
                            MailMessage mMailMessage = new MailMessage();
                            mMailMessage.From = new MailAddress("bankse7en@gmail.com");
                            mMailMessage.To.Add(new MailAddress(tb_Email_Emp.Text.ToString()));
                            mMailMessage.Subject = "New Employee information";
                            string bodyOfMail = "You have been added as a New Employee to Bank of Se7en. Following are";
                            bodyOfMail += " your details: <br> Username: " + usernameGenerated + "<br> Password: " + passwordGenerated;
                            bodyOfMail += "<br> Please login to the system and make sure you add security questions and a sitekey.<br>";
                            bodyOfMail += "Regards, <br> BankofSe7en";
                            mMailMessage.Body = bodyOfMail;
                            mMailMessage.IsBodyHtml = true;
                            mMailMessage.Priority = MailPriority.Normal;
                            SmtpClient mSmtpClient = new SmtpClient();
                            mSmtpClient.EnableSsl = true;
                            mSmtpClient.Send(mMailMessage);
                            Label1.Visible = true;
                            Label1.Text = "Employee added successfully\nUsername and Password have been mailed to the Employee";

                            //Posting a Department transaction
                            string deptTransStr = "New employee: " + usernameGenerated + " has been added";
                            DepartmentTransactionModel.MakeDepartmentTransfer(0, Convert.ToInt32(userToCreate.departmentId), Session["userName"].ToString(), usernameGenerated, deptTransStr, 0, "");
                        }
                        else
                        {
                            Label1.Visible = true;
                            Label1.Text = "There was an unfortunate error in processing. Please try again";
                        }
                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Please check the information you entered. It does not seem to be right.";
                    }
                }
                catch (Exception exp)
                {
                    Elog.Error("Exception occurred: " + exp.Message);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Account Number generation</returns>
        protected string randomAccountNumberGenerator()
        {
            try
            {
                int myRandomNumber1 = 0;
                int myRandomNumber2 = 0;
                int myRandomNumber3 = 0;
                string randocAccNum = null;
                while (randocAccNum == null)
                {
                    Random myRandomNUmberGenerator = new Random();
                    myRandomNumber1 = myRandomNUmberGenerator.Next(1001, 9996);
                    myRandomNumber2 = myRandomNUmberGenerator.Next(1001, 9996);
                    myRandomNumber3 = myRandomNUmberGenerator.Next(1001, 9996);
                    randocAccNum = myRandomNumber1.ToString() + myRandomNumber2.ToString() + myRandomNumber3.ToString();
                    SoftSec_BankingApp_Se7en.Models.Tables.Account checkingforAccount = AccountModel.GetAccount(randocAccNum);
                    if (checkingforAccount == null)
                    {
                        break;
                    }
                    else
                    {
                        randocAccNum = null;
                    }
                }
                return randocAccNum;
            }
            catch (Exception exp)
            {
                Elog.Error("Exceptions " + exp.Message);
                return string.Empty;
            }

        }


        protected string randomCardNumberGenerator()
        {
            try
            {
                int myRandomNumber1 = 0;
                int myRandomNumber2 = 0;
                int myRandomNumber3 = 0;
                int myRandomNumber4 = 0;
                string randocAccNum = null;
                while (randocAccNum == null)
                {
                    Random myRandomNUmberGenerator = new Random();
                    myRandomNumber1 = myRandomNUmberGenerator.Next(1001, 9996);
                    myRandomNumber2 = myRandomNUmberGenerator.Next(1001, 9996);
                    myRandomNumber3 = myRandomNUmberGenerator.Next(1001, 9996);
                    myRandomNumber4 = myRandomNUmberGenerator.Next(1001, 9996);
                    randocAccNum = myRandomNumber1.ToString() + myRandomNumber2.ToString() + myRandomNumber3.ToString() + myRandomNumber4.ToString();
                    SoftSec_BankingApp_Se7en.Models.Tables.User checkingforAccount = CardModel.UserForCard(randocAccNum);
                    if (checkingforAccount == null)
                    {
                        break;
                    }
                    else
                    {
                        randocAccNum = null;
                    }
                }
                return randocAccNum;
            }
            catch (Exception exp)
            {
                Elog.Error("Exceptions : " + exp.Message);
                return string.Empty;
            }

        }


        protected string CVVNumberGenerator()
        {
            try
            {
                int myRandomNumber = 0;
                Random myRandomNUmberGenerator = new Random();
                myRandomNumber = myRandomNUmberGenerator.Next(100, 999);
                string randoCVVNum = myRandomNumber.ToString();
                return randoCVVNum;
            }
            catch (Exception exp)
            {
                Elog.Error("Exceptions : " + exp.Message);
                return string.Empty;
            }

        }

        protected void btn_ViewDetails_DelEmp_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx", false);
            }
            else
            {
                bool serverSideValidation = false;
                try
                {
                    checkSession();
                    serverSideValidation = validateFromFields_Emp(tb_UserName_DelEmp.Text.ToString());
                    if (serverSideValidation)
                    {
                        //Proceed with business logic here
                        User userToDel = new User();
                        userToDel = UserModel.GetUser(tb_UserName_DelEmp.Text.ToString());
                        if (userToDel.departmentId == Convert.ToInt32(Session["deptId"]))
                        {
                            if ((userToDel.roleId < Convert.ToInt32(Session["roleId"])) && (userToDel.roleId > 3))
                            {
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
                                lbl_DelEmployee.Text = "You cannot Delete this employee. Go to View Employee tab to view details";
                            }
                        }
                        else
                        {
                            lbl_DelEmployee.Text = "You cannot Delete this employee. Go to View Employee tab to view details"; 
                        }                        
                    }
                    else
                    {
                        lbl_DelEmployee.Text = "Please check the username you have typed in";
                    }
                }
                catch (Exception exp)
                {
                    Elog.Error("Exception occurred: " + exp.Message);
                }
            }
        }

        protected void btn_ViewDetails_TransEmp_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx", false);
            }
            else
            {
                bool serverSideValidation = false;
                try
                {
                    checkSession();
                    serverSideValidation = validateFromFields_Emp(tb_UserName_transEmp.Text.ToString());
                    if (serverSideValidation)
                    {
                        //Proceed with business logic here
                        User userToTrans = new User();
                        userToTrans = UserModel.GetUser(tb_UserName_transEmp.Text.ToString());
                        if (userToTrans.departmentId == Convert.ToInt32(Session["deptId"]))
                        {
                            if ((userToTrans.roleId < Convert.ToInt32(Session["roleId"])) && (userToTrans.roleId > 3))
                            {
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
                                lbl_TransferEmpl.Text = "You cannot transfer this employee. Go to View Employee tab to view details";
                            }
                        }
                        else
                        {
                            lbl_TransferEmpl.Text = "You cannot transfer this employee. Go to View Employee tab to view details";
                        }
                    }
                    else
                    {
                        lbl_TransferEmpl.Text = "Please checked the username you have typed in";
                    }
                }
                catch (Exception exp)
                {
                    Elog.Error("Exception occurred: " + exp.Message);
                }
            }
        }

        protected void btn_ViewDetails_ViewEmp_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx", false);
            }
            else
            {
                bool serverSideValidation = false;
                try
                {
                    checkSession();
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
                    Elog.Error("Exception occurred: " + exp.Message);
                }
            }
        }

        protected void btn_viewtransdetails1_Click(object sender, EventArgs e)
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
                checkSession();
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
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }
        }

        protected void btn_echecksubmitpayment_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx",false);
            }
            else
            {
            //
            bool serverSideValidation = false;
            try
            {
                checkSession();
                serverSideValidation = validateFromFields_ECheck(tb_echeckaccno.Text.ToString(), tb_echeckroutingno.Text.ToString()
                                            , tb_echeckcustomername.Text.ToString(), tbAmount_EcheckPayment.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    Models.Tables.Account objAcc = AccountModel.GetAccount(tb_echeckaccno.Text.ToString());
                    if (objAcc != null)
                    {
                        if (objAcc.routingNumber.Equals(tb_echeckroutingno.Text.ToString()))
                        {
                            Models.Tables.User obUser = UserModel.GetUser(objAcc.userId);
                            string strFullName = obUser.firstName + obUser.middleName + obUser.lastName;
                            string checkUserNameInput = Regex.Replace(tb_echeckcustomername.Text.ToString(), @"\s+", "");
                            if (strFullName.ToLower().Equals(checkUserNameInput.ToLower()))
                            {
                                string sToAcc = merchant_savingsAccNum;
                                string sfromAcc = tb_echeckaccno.Text.ToString();
                                int success = TransactionModel.MakeInternalTransfer(sfromAcc, sToAcc, Convert.ToDouble(tbAmount_EcheckPayment.Text.ToString()),
                                            "From : " + sfromAcc + "To : " + sToAcc + "- Amount : " + tbAmount_EcheckPayment.Text.ToString());
                                    if (success > 0)
                                {
                                    lblEcheckPayment.Text = "Transaction Successful";
                                    tb_echeckaccno.Text = "";
                                    tb_echeckroutingno.Text = "";
                                    tb_echeckcustomername.Text = "";
                                    tbAmount_EcheckPayment.Text = "";
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
                        lblEcheckPayment.Text = "Invalid account details";
                        tb_echeckaccno.Text = "";
                        tb_echeckroutingno.Text = "";
                        lblEcheckPayment.Visible = true;
                    }
                }
                else
                {
                    //Update the UI with error message.
                    lblEcheckPayment.Text = "Invalid entries. Please try again";
                    tb_echeckaccno.Text = "";
                    tb_echeckroutingno.Text = "";
                    tb_echeckcustomername.Text = "";
                    tbAmount_EcheckPayment.Text = "";
                    lblEcheckPayment.Visible = true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
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
                Elog.Error("Exception occurred: " + exp.Message);
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
              //  bool bNick = fieldValidator.validate_Names(strName);

                if (bEmail && bStAdd && bCity && bZip && bPhn )
                    return true;
                else
                    return false;
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        /// <summary>
        /// Validate the from fields
        /// </summary>
        /// <param name="strCardNum">Validate the card number</param>
        /// <param name="strYear">Validate the card Expiry Year</param>
        /// <returns>True if the card number is valid, else false</returns>
        private bool validateFromFields(string strCardNum, string strCustName,string strAmount)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bCard = fieldValidator.validate_ZipAccCrdPhn(strCardNum, 16);
                bool bCustName = fieldValidator.validate_Names(strCustName);
                bool bAmt = fieldValidator.validate_Amount(strAmount);
                if (bCard && bCustName && bAmt)
                    return true;
                else
                    return false;
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        private bool validateFromFieldsatCredit(string strCardNum, string strCVV, string strAmount)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                bool bCard = fieldValidator.validate_ZipAccCrdPhn(strCardNum, 16);
                bool bCVV = fieldValidator.validate_ZipAccCrdPhn(strCVV,3);
                bool bAmt = fieldValidator.validate_Amount(strAmount);
                if (bCard && bCVV && bAmt)
                    return true;
                else
                    return false;
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
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
                Elog.Error("Exception occurred: " + exp.Message);
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
                Elog.Error("Exception occurred: " + exp.Message);
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
                Elog.Error("Exception occurred: " + exp.Message);
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
                bool bRouNum = fieldValidator.validate_ZipAccCrdPhn(strRouteNum, 12);
                if (bAmt && bEmail && bLName && bCard && bSCode && bAccnum && bRouNum)
                    return true;
                else
                    return false;
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
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
                    bool bAns = fieldValidator.validate_UserName(dictAns[i]);
                    if (bAns)
                        iCtr++;
                }
                if (bOldPass && bNewPass && bConfPass && iCtr == 3)
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
                Elog.Error("Exception occurred: " + exp.Message);
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
                if (strMName.Length == 0)
                {
                    strMName = "a";
                } 
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
                Elog.Error("Exception occurred: " + exp.Message);
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
                Elog.Error("Exception occurred: " + exp.Message);
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
                Elog.Error("Exception occurred: " + exp.Message);
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
                Elog.Error("Exception occurred: " + exp.Message);
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
                Elog.Error("Exception occurred: " + exp.Message);
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
                bool bRoute = fieldValidator.validate_ZipAccCrdPhn(strRoutingNum,12);
                bool bName = fieldValidator.validate_Names(strName);
                bool bAmt = fieldValidator.validate_Amount(strAmount);
                
                if (bAcc && bName && bRoute && bAmt)
                    return true;
                else
                    return false;
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }
        #endregion

        protected void btn_delEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                    bool DeleteSuccess = false;
                    User userToDel = new User();
                    userToDel = UserModel.GetUser(tb_UserName_DelEmp.Text.ToString());
                    int deptid = Convert.ToInt32(userToDel.departmentId);
                    if (userToDel.departmentId == Convert.ToInt32(Session["deptId"]))
                    {
                        if ((userToDel.roleId < Convert.ToInt32(Session["roleId"])) && (userToDel.roleId > 3))
                        {
                            DeleteSuccess = UserModel.RemoveUser(tb_UserName_DelEmp.Text.ToString());
                            if (DeleteSuccess)
                            {
                                lbl_DelEmployee.Text = tb_UserName_DelEmp.Text + "has been Deleted";

                                //Posting a Department transaction
                                string deptTransStr = "New employee: " + tb_UserName_DelEmp.Text.ToString() + " has been deleted";
                                DepartmentTransactionModel.MakeDepartmentTransfer(Convert.ToInt32(deptid), 0, Session["username"].ToString(), tb_UserName_DelEmp.Text.ToString(), deptTransStr, 0, "");
                            }
                            else
                            {
                                lbl_DelEmployee.Text = "Deletion failed. Please try again";
                            }
                        }
                        else
                        {
                            lbl_DelEmployee.Text = "This employee is above your role for you to delete";
                        }
                    }
                    else
                    {
                        lbl_DelEmployee.Text = "This employee does not belong to your department for you to delete";
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Excepton " + exp.Message);
            }
        }

        protected void btn_TransEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                    if (RoleDD_TransEmp.SelectedValue == TO_RoleDD_TransEmp.SelectedValue)
                    {
                        if (FROM_DeptDD_TransEmp.SelectedValue == TO_DeptDD_TransDept.SelectedValue)
                        {
                            lbl_TransferEmpl.Text = "The department and role are unchanged for the user";
                        }
                        else
                        {
                            bool TransferSuccess = false;
                            User userToTrans = new User();
                            userToTrans = UserModel.GetUser(tb_UserName_transEmp.Text.ToString());
                            int deptid = Convert.ToInt32(userToTrans.departmentId);
                            if (userToTrans.departmentId == Convert.ToInt32(Session["deptId"]))
                            {
                                if ((userToTrans.roleId < Convert.ToInt32(Session["roleId"])) && (userToTrans.roleId > 3))
                                {
                                    TransferSuccess = UserModel.TransferToDept(tb_UserName_transEmp.Text, Convert.ToInt32(TO_DeptDD_TransDept.SelectedValue));
                                    if (TransferSuccess)
                                    {
                                        lbl_TransferEmpl.Text = tb_UserName_transEmp.Text + "Transferred to " + TO_DeptDD_TransDept.SelectedValue;
                                        //Posting a Department transaction
                                        string deptTransStr = "Employee: " + tb_UserName_transEmp.Text.ToString() + " has been transferred";
                                        DepartmentTransactionModel.MakeDepartmentTransfer(Convert.ToInt32(deptid), Convert.ToInt32(TO_DeptDD_TransDept.SelectedValue), Session["username"].ToString(), tb_UserName_transEmp.Text.ToString(), deptTransStr, 0, "");
                                    }
                                    else
                                    {
                                        lbl_TransferEmpl.Text = "Transfer could not be done. Please try again";
                                    }
                                }
                                else
                                {
                                    lbl_TransferEmpl.Text = "This employee is above your role for you to transfer";
                                }
                            }
                            else
                            {
                                lbl_TransferEmpl.Text = "This employee is not in your department for you to transfer";
                            }
                        }
                    }
                    else
                    {
                        if ((Convert.ToInt32(Session["roleId"])) == 6)
                        {
                            bool TransferSuccess = false;
                            User userToTrans = new User();
                            userToTrans = UserModel.GetUser(tb_UserName_transEmp.Text.ToString());
                            int deptid = Convert.ToInt32(userToTrans.departmentId);
                            if (userToTrans.departmentId == Convert.ToInt32(Session["deptId"]))
                            {
                                if ((userToTrans.roleId < Convert.ToInt32(Session["roleId"])) && (userToTrans.roleId > 3))
                                {
                                    if (FROM_DeptDD_TransEmp.SelectedValue != TO_DeptDD_TransDept.SelectedValue)
                                    {
                                        TransferSuccess = UserModel.TransferToDept(tb_UserName_transEmp.Text, Convert.ToInt32(TO_DeptDD_TransDept.SelectedValue));
                                        if (TransferSuccess)
                                        {
                                            lbl_TransferEmpl.Text = tb_UserName_transEmp.Text + "Transferred to " + TO_DeptDD_TransDept.SelectedValue;
                                            //Posting a Department transaction
                                            string deptTransStr = "Employee: " + tb_UserName_transEmp.Text.ToString() + " to be transferred to " + TO_DeptDD_TransDept.SelectedItem.Text;
                                            DepartmentTransactionModel.MakeDepartmentTransfer(Convert.ToInt32(deptid), Convert.ToInt32(TO_DeptDD_TransDept.SelectedValue), Session["username"].ToString(), tb_UserName_transEmp.Text.ToString(), deptTransStr, 0, "");
                                        }
                                        else
                                        {
                                            lbl_TransferEmpl.Text = "Transfer could not be done. Please try again";
                                        }
                                    }
                                    //Initiate a role change
                                    string roleTransStr = "Employee: " + tb_UserName_transEmp.Text.ToString() + " role to be changed to " + TO_RoleDD_TransEmp.SelectedItem.Text;
                                    DepartmentTransactionModel.MakeRoleEscalation(Session["username"].ToString(), tb_UserName_transEmp.Text.ToString(), Convert.ToInt32(userToTrans.roleId), Convert.ToInt32(TO_RoleDD_TransEmp.SelectedValue), roleTransStr, 1, "admin");
                                    lbl_TransferEmpl.Text += "  Role change for" + tb_UserName_transEmp.Text.ToString() + " has been initiated";
                                }
                                else
                                {
                                    lbl_TransferEmpl.Text = "This employee is above your role for you to transfer";
                                }
                            }
                            else
                            {
                                lbl_TransferEmpl.Text = "This employee is not in your department for you to transfer";
                            }
                        }
                        else
                        {
                            lbl_TransferEmpl.Text = "You do not have permissions to change roles";
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception " + exp.Message);
            }
        }

        protected void btn_checking_Click(object sender, EventArgs e)
        {
            statusDescLb.Text = "";
            statusDescLb.Visible = true;
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx", false);
            }
            else
            {
                try
                {
                    checkSession();
                    List<Models.Tables.Transaction> lstTrans = TransactionModel.GetTransactionsForAccount(tb_checking.Text.ToString());
                    if (lstTrans != null)
                    {
                        grdTransaction.DataSource = lstTrans;
                        grdTransaction.DataBind();
                        statusDescLb.Text = "Status: 1)Processing 2)Approved 3)Rejected";
                        if (!(lstTrans.Count > 0))
                        {
                            statusDescLb.Text = "No transacations";
                        }
                    }
                    else
                    {
                        statusDescLb.Text = "Could not fetch details";
                    }
                }
                catch (Exception exp)
                {
                    Elog.Error("Exception occurred: " + exp.Message);
                    statusDescLb.Text = "Could not fetch details";

                }
            }
        }

        protected void btn_savings_Click(object sender, EventArgs e)
        {
            statusDescLb.Text = "";
            statusDescLb.Visible = true;
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx", false);
            }
            else
            {
            try
            {
                checkSession();
                List<Models.Tables.Transaction> lstTrans = TransactionModel.GetTransactionsForAccount(tb_savings.Text.ToString());
                if (lstTrans != null)
                {
                    grdTransaction.DataSource = lstTrans;
                    grdTransaction.DataBind();
                    statusDescLb.Text = "Status: 1)Processing 2)Approved 3)Rejected";
                    if (!(lstTrans.Count > 0))
                    {
                        statusDescLb.Text = "No transacations";
                    }
                }
                else {
                    statusDescLb.Text = "Could not fetch details";
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                statusDescLb.Text="Could not fetch details";
            }
        }
        }

        protected void TabContainer2_ActiveTabChanged(object sender, EventArgs e)
        {

            try
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                if (TabContainer2.ActiveTabIndex == 2)
                {
                    TabContainer4.Visible = false;
                    Models.Tables.User objUsr = UserModel.GetUser(Session["ExistingCustName"].ToString());
                    if (objUsr != null)
                    {
                        tb_usernameview.Text = Session["ExistingCustName"].ToString();
                        Models.Tables.Address objUsrAddr = objUsr.Address;
                        tb_addrview.Text = objUsrAddr.street1;
                        tb_cityView.Text = objUsrAddr.city;
                        StateDD_View.SelectedValue = objUsrAddr.state;
                        tb_zipView.Text = Convert.ToString(objUsrAddr.zip);
                        tb_contactview.Text = objUsr.phone;
                        tb_emailview.Text = objUsr.email;
                        
                    }
                }
                else if (TabContainer2.ActiveTabIndex == 3)
                {
                    List<Models.Tables.Account> lstAcc = AccountModel.GetAccountsForUser(Session["ExistingCustName"].ToString()).ToList();
                    if (transferDD_ModifyTrans.Items.Count > 0)
                    {
                        transferDD_ModifyTrans.Items.Clear();
                    }
                    transferDD_ModifyTrans.Items.Add("Accounts");
                    foreach (Models.Tables.Account acc in lstAcc)
                    {
                        transferDD_ModifyTrans.Items.Add(acc.accountNumber);
                    }
                    
                }
                else if (TabContainer2.ActiveTabIndex == 4)
                {
                    Models.Tables.User objUsr = UserModel.GetUser(Session["ExistingCustName"].ToString());
                    if (objUsr != null)
                    {   
                        List<Models.Tables.Account> lstAcc = AccountModel.GetAccountsForUser(Session["ExistingCustName"].ToString()).ToList();
                        if (lstAcc != null)
                        {
                            foreach (Models.Tables.Account acc in lstAcc)
                            {
                                if (acc.accountTypeId == 3)
                                {
                                    merchant_savingsAccNum = acc.accountNumber;
                                    break;
                                }
                            }
                        }                        
                    }
                    else
                    {
                        //No such user exists
                    }
                }
            }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }

        protected void btn_editprof_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx", false);
            }
            else
            {
                checkSession();
            TabContainer4.Visible = true;
            try
            {
                tb_email_Edit.Text = tb_emailview.Text;
                tb_stAddr_Edit.Text = tb_addrview.Text;
                tb_city_Edit.Text = tb_cityView.Text;
                tb_zipCode_Edit.Text = tb_zipView.Text;
                tb_contact_Edit.Text = tb_contactview.Text;
                StateDD_EditProfile.SelectedValue = StateDD_View.SelectedValue;
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }
        }

        protected void TabContainer4_ActiveTabChanged(object sender, EventArgs e)
        {
            try
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                if (TabContainer4.ActiveTabIndex == 0)
                {
                    //Reset the fields if required
                }
                else if (TabContainer4.ActiveTabIndex == 1)
                {
                    lstQandA = PasswordModel.GetSecurityQandA(Session["ExistingCustName"].ToString());
                    Sec1DD_ExistingCust_EditProf.SelectedValue = Convert.ToString(lstQandA.First().questionId);
                    Sec2DD_ExistingCust_EditProf.SelectedValue = Convert.ToString(lstQandA.ElementAt(1).questionId);
                    Sec3DD_ExistingCust_EditProf.SelectedValue = Convert.ToString(lstQandA.Last().questionId);
                    Sec1DD_ExistingCust_EditProf.Enabled = false;
                    Sec2DD_ExistingCust_EditProf.Enabled = false;
                    Sec3DD_ExistingCust_EditProf.Enabled = false;
                }
            }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }

        }

        protected void btn_viewtransdetails_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx", false);
            }
            else
            {
            try
            {
                checkSession();
                bool serverSideValidation = false;
                FieldValidator objField = new FieldValidator();
                serverSideValidation = objField.validate_TransID(tb_transID_ModifyTrans.Text.ToString());
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                    
                    Models.Tables.Transaction objTrans = TransactionModel.GetTransaction(tb_transID_ModifyTrans.Text.ToString());
                    if (transferDD_ModifyTrans.SelectedValue.ToString().Equals(objTrans.fromAccountNumber))
                    {
                        btn_modifytrans.Enabled = true;
                        fromAccNum_ModTrans = objTrans.fromAccountNumber;
                        toAccNum_ModTrans = objTrans.toAccountNumber;
                        lblAccount_ModifyTrans.Text = objTrans.toAccountNumber;
                        lblAmount_ModifyTrans.Text = Convert.ToString(objTrans.amount);
                        lblRoutingNum_ModifyTrans.Text = objTrans.toRoutingNumber;
                        lblRoutingNum_ModifyTrans.Visible = true;
                        lblAccount_ModifyTrans.Visible = true;
                        lblAmount_ModifyTrans.Enabled = false;
                        lblAccount_ModifyTrans.Enabled = false;
                        lblAmount_ModifyTrans.Visible = true;
                        tb_AccNum_modifyTrans.Text = objTrans.toAccountNumber;
                        tb_Amount_ModifyTrans.Text = Convert.ToString(objTrans.amount);
                        tb_RoutNum_modifyTrans.Text = objTrans.toRoutingNumber;
                        if (objTrans.toRoutingNumber.Equals(""))
                        {
                            lblRoutingNum_ModifyTrans.Visible = false;
                        }
                        else {
                            lblRoutingNum_ModifyTrans.Visible = true;
                        }
                        //lblType_ModifyTrans.Text = objTrans.type;
                    }
                    else
                    {
                        btn_modifytrans.Enabled = false;
                        lblStatus_ModifyStatus.Text = "Cant modify this transaction";
                        lblStatus_ModifyStatus.Visible = true;
                    }
                }
                else
                { 
                    //Update the UI with error message
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }
        }

        protected void btn_modifytrans_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx", false);
            }
            else
            {
            try
            {
                checkSession();
                bool serverSideValidation = false;
                FieldValidator objField = new FieldValidator();
                serverSideValidation = objField.validate_TransID(tb_transID_ModifyTrans.Text) 
                                && objField.validate_Amount(tb_Amount_ModifyTrans.Text) && objField.validate_ZipAccCrdPhn(tb_AccNum_modifyTrans.Text, 12);
                if (serverSideValidation)
                {
                    Models.Tables.Account objToNewAccount = AccountModel.GetAccount(tb_AccNum_modifyTrans.Text);
                    Models.Tables.Account objFromAccount = AccountModel.GetAccount(fromAccNum_ModTrans);
                    Models.Tables.Account objToOrgAccount = AccountModel.GetAccount(toAccNum_ModTrans);
                    if (transferDD_ModifyTrans.SelectedValue.ToString().Equals(objFromAccount.accountNumber))
                    {
                        if (objToNewAccount != null && objToOrgAccount != null)
                        {
                            //Inside bank transfer
                            if (tb_AccNum_modifyTrans.Text.Equals(lblAccount_ModifyTrans.Text))
                            {
                                //Account numbers are same. Involves 2 accounts only.
                                if (tb_Amount_ModifyTrans.Text.Equals(lblAmount_ModifyTrans.Text))
                                {
                                    //No modification is possible.
                                    lblStatus_ModifyStatus.Text = "The account number and amount are same. No Modification in transaction";
                                    lblStatus_ModifyStatus.Visible = true;
                                }
                                else
                                {
                                    //Amount is different.
                                    if (Convert.ToDouble(lblAmount_ModifyTrans.Text) > Convert.ToDouble(tb_Amount_ModifyTrans.Text))
                                    {
                                        //New amount entered is less than already transfered amount. Thereby returning money to FROMAccount.
                                        double netAmount = Convert.ToDouble(lblAmount_ModifyTrans.Text) - Convert.ToDouble(tb_Amount_ModifyTrans.Text);
                                        string desc = "From :" + objToNewAccount.accountNumber + " To :" + objFromAccount.accountNumber + " Amount :" + tb_Amount_ModifyTrans.Text
                                                        + " Modify Transaction : " + tb_transID_ModifyTrans.Text;
                                        int success = TransactionModel.MakeInternalTransfer(objToNewAccount.accountNumber, objFromAccount.accountNumber, netAmount, desc);
                                            if (success > 0)
                                        {
                                            lblStatus_ModifyStatus.Text = "Modification Successful";
                                            lblStatus_ModifyStatus.Visible = true;
                                            lstTransaction = TransactionModel.GetTransactionsForFromToAccount(transferDD_ModifyTrans.SelectedValue.ToString());
                                            grdTransaction.DataSource = lstTransaction;
                                            grdTransaction.DataBind();
                                        }
                                        else
                                        {
                                            lblStatus_ModifyStatus.Text = "Modification Unsuccessful";
                                            lblStatus_ModifyStatus.Visible = true;
                                        }
                                    }
                                    else
                                    {
                                        //New Amount more than transaction amount. Debiting difference from FROMAccount.
                                        double netAmount = Convert.ToDouble(tb_Amount_ModifyTrans.Text) - Convert.ToDouble(lblAmount_ModifyTrans.Text);
                                        string desc = "From :" + objFromAccount.accountNumber + " To :" + objToNewAccount.accountNumber + " Amount :" + tb_Amount_ModifyTrans.Text
                                                        + " Modify Transaction : " + tb_transID_ModifyTrans.Text;
                                        int success = TransactionModel.MakeInternalTransfer(objFromAccount.accountNumber, objToNewAccount.accountNumber, netAmount, desc);
                                            if (success > 0)
                                        {
                                            lblStatus_ModifyStatus.Text = "Modification Successful";
                                            lblStatus_ModifyStatus.Visible = true;
                                            lstTransaction = TransactionModel.GetTransactionsForFromToAccount(transferDD_ModifyTrans.SelectedValue.ToString());
                                            grdTransaction.DataSource = lstTransaction;
                                            grdTransaction.DataBind();
                                        }
                                        else
                                        {
                                            lblStatus_ModifyStatus.Text = "Modification Unsuccessful";
                                            lblStatus_ModifyStatus.Visible = true;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                //Account numbers are not same. Involves 3 different accounts
                                if (tb_Amount_ModifyTrans.Text.Equals(lblAmount_ModifyTrans.Text))
                                {
                                    //Same amount. Then it involves only 2 accounts.
                                    string desc = "From : " + objToOrgAccount.accountNumber + " To :" + objToNewAccount.accountNumber
                                                    + " Amount :" + tb_Amount_ModifyTrans.Text + " Modify Transaction :" + tb_transID_ModifyTrans.Text;
                                    int success = TransactionModel.MakeInternalTransfer(objToOrgAccount.accountNumber, objToNewAccount.accountNumber,
                                                                                                Convert.ToDouble(tb_Amount_ModifyTrans.Text), desc);
                                        if (success > 0)
                                    {
                                        lblStatus_ModifyStatus.Text = "Modification Successful";
                                        lblStatus_ModifyStatus.Visible = true;
                                        lstTransaction = TransactionModel.GetTransactionsForFromToAccount(transferDD_ModifyTrans.SelectedValue.ToString());
                                        grdTransaction.DataSource = lstTransaction;
                                        grdTransaction.DataBind();
                                    }
                                    else
                                    {
                                        lblStatus_ModifyStatus.Text = "Modification Unsuccessful";
                                        lblStatus_ModifyStatus.Visible = true;
                                    }
                                }
                                else
                                {
                                    //Different Amonunts involved, 3 accounts involved.
                                    //Transfer the previous amount back to FromAccount.
                                    string desc = "From : " + objToOrgAccount.accountNumber + " To :" + objFromAccount.accountNumber
                                                    + " Amount :" + lblAmount_ModifyTrans.Text + " Modify Transaction :" + tb_transID_ModifyTrans.Text;
                                    int firstSuccess = TransactionModel.MakeInternalTransfer(objToOrgAccount.accountNumber, objFromAccount.accountNumber
                                                                                                        , Convert.ToDouble(lblAmount_ModifyTrans.Text), desc);
                                        if (firstSuccess > 0)
                                    {
                                        //Trasfer new amount to new account.
                                        desc = string.Empty;
                                        desc = "From : " + objFromAccount.accountNumber + " To :" + objToNewAccount.accountNumber
                                                    + " Amount :" + tb_Amount_ModifyTrans.Text + " Modify Transaction :" + tb_transID_ModifyTrans.Text;
                                        int secondSuccess = TransactionModel.MakeInternalTransfer(objFromAccount.accountNumber, objToNewAccount.accountNumber,
                                                                                                    Convert.ToDouble(tb_Amount_ModifyTrans.Text), desc);
                                            if (secondSuccess > 0)
                                        {
                                            lblStatus_ModifyStatus.Text = "Modification Successful";
                                            lblStatus_ModifyStatus.Visible = true;
                                            lstTransaction = TransactionModel.GetTransactionsForFromToAccount(transferDD_ModifyTrans.SelectedValue.ToString());
                                            grdTransaction.DataSource = lstTransaction;
                                            grdTransaction.DataBind();
                                        }
                                        else
                                        {
                                            lblStatus_ModifyStatus.Text = "Modification Unsuccessful";
                                            lblStatus_ModifyStatus.Visible = true;
                                        }
                                    }
                                    else
                                    {
                                        lblStatus_ModifyStatus.Text = "Modification Unsuccessful";
                                        lblStatus_ModifyStatus.Visible = true;
                                    }
                                }
                            }
                        }
                        else if (objToOrgAccount != null && objToNewAccount == null)
                        {
                            //Outside bank transfer
                            //Original TOACcount is inside bank, but user wants to make the tranfer to an account outside the bank
                            if (objField.validate_ZipAccCrdPhn(tb_RoutNum_modifyTrans.Text, 10))
                            {
                                //Transfer the previous amount back to FromAccount.
                                string desc = "From : " + objToOrgAccount.accountNumber + " To :" + objFromAccount.accountNumber
                                                + " Amount :" + lblAmount_ModifyTrans.Text + " Modify Transaction :" + tb_transID_ModifyTrans.Text;
                                int firstsuccess = TransactionModel.MakeInternalTransfer(objToOrgAccount.accountNumber, objFromAccount.accountNumber,
                                                                                            Convert.ToDouble(lblAmount_ModifyTrans.Text), desc);
                                    if (firstsuccess > 0)
                                {
                                    desc = string.Empty;
                                    desc = "From : " + objFromAccount.accountNumber + " To : " + tb_AccNum_modifyTrans.Text + " Amount : "
                                                        + tb_Amount_ModifyTrans.Text + " Modify Transaction : " + tb_transID_ModifyTrans.Text;
                                    int secondSuccess = TransactionModel.MakeExternalTransfer(objFromAccount.accountNumber, objFromAccount.routingNumber,
                                                                                tb_AccNum_modifyTrans.Text, tb_RoutNum_modifyTrans.Text, Convert.ToDouble(tb_Amount_ModifyTrans.Text), desc);
                                        if (secondSuccess > 0)
                                    {
                                        lblStatus_ModifyStatus.Text = "Modification Successful";
                                        lblStatus_ModifyStatus.Visible = true;
                                        lstTransaction = TransactionModel.GetTransactionsForFromToAccount(transferDD_ModifyTrans.SelectedValue.ToString());
                                        grdTransaction.DataSource = lstTransaction;
                                        grdTransaction.DataBind();
                                    }
                                    else
                                    {
                                        lblStatus_ModifyStatus.Text = "Modification Unsuccessful";
                                        lblStatus_ModifyStatus.Visible = true;
                                    }
                                }
                                else
                                {
                                    lblStatus_ModifyStatus.Text = "Modification Unsuccessful";
                                    lblStatus_ModifyStatus.Visible = true;
                                }
                            }
                            else
                            {
                                lblStatus_ModifyStatus.Text = "Enter valid routing number";
                                lblStatus_ModifyStatus.Visible = true;
                            }
                        }
                    }
                    else
                    {
                        lblStatus_ModifyStatus.Text = "Cant modify this transaction";
                        lblStatus_ModifyStatus.Visible = true;
                    }                    
                }
                else
                {
                    lblStatus_ModifyStatus.Text = "Enter valid account number/amount";
                    lblStatus_ModifyStatus.Visible = true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }
        }

        protected void transferDD_ModifyTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_transID_ModifyTrans.Text = "";
            tb_AccNum_modifyTrans.Text = "";
            tb_RoutNum_modifyTrans.Text = "";
            tb_Amount_ModifyTrans.Text = "";
            lblStatus_ModifyStatus.Text = "";
            try
            {
                lstTransaction = TransactionModel.GetTransactionsForFromToAccount(transferDD_ModifyTrans.SelectedValue.ToString());
                if (lstTransaction != null)
                {
                    grdTransactions.DataSource = lstTransaction;
                    grdTransactions.DataBind();
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }

        protected void grdTransactions_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                grdTransactions.PageIndex = e.NewPageIndex;
                grdTransactions.DataSource = lstTransaction;
                grdTransactions.DataBind();
            }
            catch(Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }

        protected void btnSignOff_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx", false);
            }
            else
            {
                checkSession();
                try
                {
                    //Hiding the Tab container 2 and re-setting the values of the controls present in it.
                    TabContainer2.Visible = false;
                    tbCardNumber_IU.Text = "";
                    rb_PhotoID.SelectedValue = "No";
                    MonthDD_ExistingCustomer_Verify.SelectedValue = "MM";
                    DayDD_ExistingCustomer_Verify.SelectedValue = "DD";
                    tbYear_IU.Text = "YYYY";
                    tb_checking.Text = "";
                    tb_savings.Text = "";
                    //  tb_credit.Text = "";
                    grdTransaction.DataSource = null;
                    grdTransaction.DataBind();
                    fromAccTypeDD_TransferExistingCust_Inside.Items.Clear();
                    //fromAccTypeDD_TransferExistingCust_Inside.Items.Add("Accounts");
                    tb_amount_IU_Inside.Text = "";
                    tb_recepient_IU_Inside.Text = "";
                    tb_lastname_IU_Inside.Text = "";
                    tb_zip_IU_Inside.Text = "";
                    tb_card_IU_Inside.Text = "";
                    monthDD_TransferExistingCust_Inside.SelectedValue = "MM";
                    yearDD_TransferExistingCust_Inside.SelectedValue = "YYYY";
                    tb_securitycode_IU_Inside.Text = "";
                    accTypeDD_TransferExistingCust_Outside.Items.Clear();
                    //accTypeDD_TransferExistingCust_Outside.Items.Add("Accounts");
                    tb_amountoutside.Text = "";
                    tb_AccNumoutside_Intenal.Text = "";
                    tb_toRoutingNum_OutsideBank.Text = "";
                    tb_lastnameoutside.Text = "";
                    tb_emailoutside.Text = "";
                    tb_usercardno.Text = "";
                    monthDD_TransferExistingCust_Outside.SelectedValue = "MM";
                    yearDD_TransferExistingCust_Outside.SelectedValue = "YYYY";
                    tb_securitycodeoutside.Text = "";
                    lblStatus_OutsideBank.Text = "";
                    fromAccTypeDD_TransferExistingCust_Between.Items.Clear();
                    //fromAccTypeDD_TransferExistingCust_Between.Items.Add("Accounts");
                    toAccTypeDD_TransferExistingCust_Between.Items.Clear();
                    //toAccTypeDD_TransferExistingCust_Between.Items.Add("Accounts");
                    tb_amountbetween.Text = "";
                    lblStatus_Between.Text = "";
                    tb_card_DebitFunds.Text = "";
                    monthDD_TransferExistingCust_Debit.SelectedValue = "MM";
                    yearDD_TransferExistingCust_Debit.SelectedValue = "YYYY";
                    tb_securitycode_DebitFunds.Text = "";
                    accTypeDD_TransferExistingCust_Debit.Items.Clear();
                    //accTypeDD_TransferExistingCust_Debit.Items.Add("Accounts");
                    tb_amountoutside_DebitFunds.Text = "";
                    lblStatus_DebitFunds.Text = "";
                    tb_card_CreditFunds.Text = "";
                    monthDD_TransferExistingCust_Credit.SelectedValue = "MM";
                    yearDD_TransferExistingCust_Credit.SelectedValue = "YYYY";
                    tb_securitycode_CreditFunds.Text = "";
                    accTypeDD_TransferExistingCust_Credit.Items.Clear();
                    //accTypeDD_TransferExistingCust_Credit.Items.Add("Accounts");
                    tb_amountoutside_CreditFunds.Text = "";
                    lblStatus_CreditFunds.Text = "";
                    tb_emailview.Text = "";
                    tb_addrview.Text = "";
                    tb_cityView.Text = "";
                    tb_contactview.Text = "";
                    StateDD_View.SelectedValue = "AL";
                    tb_usernameview.Text = "";
                    tb_zipView.Text = "";
                    tb_nicknameview.Text = "";
                    tb_email_Edit.Text = "";
                    tb_stAddr_Edit.Text = "";
                    tb_city_Edit.Text = "";
                    tb_zipCode_Edit.Text = "";
                    tb_contact_Edit.Text = "";
                    tb_nickname_Edit.Text = "";
                    lblStatus_ChangeProf.Text = "";
                    tb_oldpwd.Text = "";
                    tb_newPassword.Text = "";
                    tb_confrimPassword.Text = "";
                    tb_secans1.Text = "";
                    tb_secans2.Text = "";
                    tb_secans3.Text = "";
                    transferDD_ModifyTrans.Items.Clear();
                    //transferDD_ModifyTrans.Items.Add("Accounts");
                    grdTransactions.DataSource = null;
                    grdTransactions.DataBind();
                    tb_transID_ModifyTrans.Text = "";
                    lblAccount_ModifyTrans.Text = "";
                    lblRoutingNum_ModifyTrans.Text = "";
                    lblAmount_ModifyTrans.Text = "";
                    lblStatus_ModifyStatus.Text = "";
                    tb_AccNum_modifyTrans.Text = "";
                    tb_RoutNum_modifyTrans.Text = "";
                    tb_Amount_ModifyTrans.Text = "";
                    tb_cardnum.Text = "";
                    tb_customername.Text = "";
                    cardExpDD_CardPayment.SelectedValue = "MM";
                    yearDD_CardPayment.SelectedValue = "YY";
                    tb_amount_SubmitPayment.Text = "";
                    lblSubmitPayment.Text = "";
                    tb_echeckaccno.Text = "";
                    tb_echeckroutingno.Text = "";
                    tb_echeckcustomername.Text = "";
                    tbAmount_EcheckPayment.Text = "";
                    lblEcheckPayment.Text = "";
                    btnVerify0.Enabled = true;
                }
                catch (Exception exp)
                {
                    Elog.Error("Exception occurred: " + exp.Message);
                }
            }
        }

        protected void TabContainer1_ActiveTabChanged(object sender, EventArgs e)
        {
            try
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    Models.Tables.User objUsr = UserModel.GetUser(Session["userName"].ToString());                    
                    if (TabContainer1.ActiveTabIndex == 0 || TabContainer1.ActiveTabIndex == 1)
                    {
                        existingCustErrLb.Text = "";
                        if (objUsr != null && (objUsr.roleId == 4 || objUsr.roleId == 5))
                        {
                            TabContainer1.Visible = true;
                        }
                        else
                        {
                            //Call log out function here
                            //Reset Session Variables
                            Session.Abandon();
                            Session["userName"] = "";
                            Response.Redirect("ExternalHomePage.aspx", false);
                        }
                    }
                    else if (TabContainer1.ActiveTabIndex == 2 || TabContainer1.ActiveTabIndex == 3)
                    {
                        if (objUsr != null && (objUsr.roleId == 5 || objUsr.roleId == 6))
                        {
                            TabContainer1.Visible = true;
                        }
                        else
                        {
                            //Call log out function here
                            Session.Abandon();
                            Session["userName"] = "";
                            Response.Redirect("ExternalHomePage.aspx", false);
                        }
                    }
                    else if (TabContainer1.ActiveTabIndex == 4)
                    {
                        
                        if (objUsr != null && (objUsr.roleId == 4 || objUsr.roleId == 5 || objUsr.roleId == 6))
                        {
                            TabContainer1.Visible = true;
                            tb_emailview_int.Text = objUsr.email;
                            tb_streetAddress_int.Text = objUsr.Address.street1;
                            tb_usernameview_int.Text = objUsr.username;
                            tb_city_int.Text = objUsr.Address.city;
                            StateDD_Profile_int.SelectedValue = objUsr.Address.state;
                            tb_ZipCode_Profile_int.Text = Convert.ToString(objUsr.Address.zip);
                            tb_contactview_int.Text = objUsr.phone;
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                Session["userName"] = "";
                Response.Redirect("ExternalHomePage.aspx", false);
            }
        }

        protected void placeReqBT_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx");
            }
            else
            {
            bool serverSideValidation = false;
            try
            {
                checkSession();
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
                                        if (objLastZip.lastName.ToLower().Equals(tb_lastname_IU_Inside.Text.ToLower()) 
                                                && objLastZip.zipcode.ToString().Equals(tb_zip_IU_Inside.Text.ToString()))
                                        {
                                            double amount = Convert.ToDouble( tb_amount_IU_Inside.Text);
                                            if (amount >= 30000)
                                            {

                                                string desc = "crtLevel2ReqInitiated";
                                                int level2ReqiD = TransactionModel.MakeInternalTransfer(objCard.accountNumber, tb_recepient_IU_Inside.Text.ToString(),
                                                                           Convert.ToDouble(tb_amount_IU_Inside.Text.ToString()), desc);

                                                User selectedAuthorizer=UserModel.GetUser(authorizerDropDown.Text.ToString());
                                           
                                               //
                                                if (level2ReqiD > 0)
                                                {
                                                    bool assignedlevel2Trans = TransactionModel.AssignAuthorizationRequestedTransactionToUser(level2ReqiD, selectedAuthorizer.username.ToString(), Convert.ToInt32(selectedAuthorizer.roleId));
                                                    if (assignedlevel2Trans)
                                                    {
                                                        lblSuccess_IUInside.Text = "Request sucesfully escalated to manager";
                                                    lblSuccess_IUInside.Visible = true;
                                                }
                                                    else {
                                                        lblSuccess_IUInside.Text = "Request could not be escalated";
                                                        lblSuccess_IUInside.Visible = true;
                                                    }
                                                
                                                }
                                                else
                                                {
                                                    lblSuccess_IUInside.Text = "Unsuccessful(check balance and details)";
                                                    lblSuccess_IUInside.Visible = true;
                                                }
                                            }
                                            else
                                            {
                                                lblSuccess_IUInside.Text = "This transaction needs no approval,proceed with normal transfer";
                                                lblSuccess_IUInside.Visible = true;
                                                requetAuthLb.Visible = false;
                                                authorizerDropDown.Visible = false;
                                                placeReqBT.Visible = false;
                                            }
                                        
                                        }
                                    }
                                    else
                                    {
                                        //Invalid Zip and Last name combination
                                        lblSuccess_IUInside.Text = "Invalid Zip and Name";
                                        lblSuccess_IUInside.Visible = true;
                                    }
                                }
                                else
                                {
                                    //Invalid Card Details
                                    lblSuccess_IUInside.Text = "Invalid Card Security Code Details.";
                                    lblSuccess_IUInside.Visible = true;
                                }
                            }
                            else
                            {
                                //Invalid Card Expiry Details
                                lblSuccess_IUInside.Text = "Invalid Card Expiry";
                                lblSuccess_IUInside.Visible = true;
                            }
                        }
                        else
                        {
                            //Invalid Card Details
                            lblSuccess_IUInside.Text = "Invalid Card Details. Please check card Number.";
                            lblSuccess_IUInside.Visible = true;
                        }
                    }
                    else
                    {
                        //Update the UI with error message.
                        lblSuccess_IUInside.Text = "Invalid Entries. Please try again.";
                        lblSuccess_IUInside.Visible = true;
                    }
                }
                catch (Exception exp)
                {
                    Elog.Error("Exception occurred: " + exp.Message);
                }
            }
        }

        protected void reGridSelectedRowAtIndex(object sender, EventArgs e)
        {
            try
            {
                currentSelectedReqIndex = reqGridV.SelectedIndex;
                currentSelectedTransReq = currentPendingTransReqs.ElementAt(currentSelectedReqIndex);
                string description = currentSelectedTransReq.description;
                if (description.Equals("crtLevel2ReqInitiated"))
                {
                    //New request, requires peer approval
                    reqResultLB.Text = "This transaction requires peer approval, please authorize and escalate it";
                    List<string> peers = new List<string>();
                    peers = getPeerAuthorizersfor(Convert.ToInt32(Session["roleID"]), Convert.ToInt32(Session["deptID"]));
                    if (peers.Count > 0)
                    {
                        authorizersDDReqTab.DataSource = peers;
                        authorizersDDReqTab.DataBind();
                        authorizersDDReqTab.Visible = true;
                        pickAuthlabelinReqTab.Visible = true;
                        escalateToPeerBT.Visible = true;
                        rejectReqBT.Visible = true;
                    }
                    else
                    {
                        reqResultLB.Text = "This transaction requires peer approval, could not fetch any peers";
                    }
                    escalateToPeerBT.Visible = true;
                }
                else if (description.Equals("peerManagerReq"))
                {
                    //Peer manager Request, Must approve and escalate to higher manager
                    reqResultLB.Text = "This transaction requires higher approval, please authorize and escalate it";
                    List<string> highers = new List<string>();
                    highers = getHigherAuthorizersfor(Convert.ToInt32(Session["roleID"]), Convert.ToInt32(Session["deptID"]));
                    if (highers.Count > 0)
                    {
                        authorizersDDReqTab.DataSource = highers;
                        authorizersDDReqTab.DataBind();
                        authorizersDDReqTab.Visible = true;
                        pickAuthlabelinReqTab.Visible = true;
                        escalateTohigherMangerBT.Visible = true;
                        rejectReqBT.Visible = true;
                    }
                    else
                    {

                        reqResultLB.Text = "This transaction requires higher approval, could not fetch any higher authorizers";
                    }

                }
                else if (description.Equals("HigherManagerReq"))
                { //Higer level manager req, should escalate to higher level peer
                    reqResultLB.Text = "This transaction requires peer approval, please authorize and escalate it";
                    List<string> peers = new List<string>();
                    peers = getPeerAuthorizersfor(Convert.ToInt32(Session["roleID"]), Convert.ToInt32(Session["deptID"]));
                    if (peers.Count > 0)
                    {
                        authorizersDDReqTab.DataSource = peers;
                        authorizersDDReqTab.DataBind();
                        authorizersDDReqTab.Visible = true;
                        pickAuthlabelinReqTab.Visible = true;
                        escalateToPeerBT.Visible = true;
                        rejectReqBT.Visible = true;
                    }
                    else
                    {

                        reqResultLB.Text = "This transaction requires peer approval, could not fetch any peer authorizers";
                    }

                }
                else if (description.Equals("peerHigherReq"))
                {//Got all low level authorizations have to be approved
                    approveReqBT.Visible = true;
                    rejectReqBT.Visible = true;

                }
                else
                {
                    reqResultLB.Text = "Unknown transaction type";
                }
                reqResultLB.Visible = true;

            }
            catch (Exception exp)
            {
                Elog.Error("Exception :" + exp.Message);
            }
           
        }

        protected void reqLookUPBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                    string username = Session["userName"].ToString();
                    currentPendingTransReqs = TransactionModel.GetAuthorizationRequestedTransactionsForUser(username);
                    if (currentPendingTransReqs != null)
                    {
                        if (currentPendingTransReqs.Count > 0)
                        {
                            reqGridV.DataSource = currentPendingTransReqs;
                            reqGridV.DataBind();
                        }
                        else
                        {
                            reqResultLB.Text = "No pending requests";
                        }
                    }
                    else
                    {
                        reqResultLB.Text = "No pending requests";
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception " + exp.Message);
            }
        }

        protected void approveReqBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                    bool approved = TransactionModel.ApproveTransaction(currentSelectedTransReq.id);
                    if (approved)
                    {
                        reqResultLB.Text = "Successfully approved";

                    }
                    else
                    {
                        reqResultLB.Text = "Request could not be approved";
                    }


                }
                refreshReqUI();
            }
            catch (Exception exp)
            {
                Elog.Error("Exception " + exp.Message);
            }
       
        }
        

        protected void rejectReqBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();

                    bool rejected = TransactionModel.RejectTransaction(currentSelectedTransReq.id);
                    if (rejected)
                    {
                        reqResultLB.Text = "Successfully Rejected";

                    }
                    else
                    {
                        reqResultLB.Text = "Request could not be Rejected";
                    }
                }
                refreshReqUI();
            }
            catch (Exception exp)
            {
                Elog.Error("Excption : " + exp.Message);
            }

        }


        protected List<string> getHigherAuthorizersfor(int roleID, int deptID)
        {
            try
            {
                List<User> higherauthorizers = new List<User>();
                List<string> higherUsernames = new List<string>();
                if (roleID >= 4 && roleID <= 6)
                {
                    if (roleID == 4)
                    {
                        //default taking transaction dept managers should change the db entries
                        higherauthorizers = UserModel.GetUsersForDepartmentIdRoleId(4, 5);

                    }
                    else if (roleID == 5)
                    {
                        //get all higher level managers
                        higherauthorizers = UserModel.GetUsersForRoleId(6);

                    }

                }

                foreach (User curU in higherauthorizers)
                {
                    higherUsernames.Add(curU.username);
                }

                return higherUsernames;
            }
            catch (Exception exp)
            {
                Elog.Error("Exception" + exp.Message);
                return null;
            }
        }

        protected void bt_logout_Click(object sender, EventArgs e)
        {
            try
            {
                Session.Abandon();
                Response.Redirect("ExternalHomePage.aspx", false);
            }
            catch (Exception exp)
            {
                Elog.Error("Exception Occured : " + exp.Message);
            }
        }

        protected List<string> getPeerAuthorizersfor(int roleID, int deptID)
        {
            try
            {
                List<User> peerauthorizers = new List<User>();
                List<string> peerUsernames = new List<string>();
                string currentUserName = Session["userName"].ToString();
                if (roleID == 5)
                {
                    peerauthorizers = UserModel.GetUsersForDepartmentIdRoleId(deptID, roleID);
                }
                else if (roleID == 6)
                {
                    peerauthorizers = UserModel.GetUsersForRoleId(6);
                }


                foreach (User curU in peerauthorizers)
                {
                    if (currentUserName != curU.username)
                    {
                        peerUsernames.Add(curU.username);
                    }
                }

                return peerUsernames;
            }
            catch (Exception exp)
            {
                Elog.Error("Exception : " + exp.Message);
                return null;
            }
        }

        protected void escalateToPeerBT_Click(object sender, EventArgs e)
        {

            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx", false);
            }
            else
            {
                checkSession();
                string selectedpeername = authorizersDDReqTab.Text.ToString();
                if (selectedpeername == null || selectedpeername.Equals(""))
                {
                    reqResultLB.Text = "Please choose an authorizer to escalate";
                }
                else
                {
                    if (currentSelectedTransReq != null)
                    {
                        string desc = "";
                        if (Convert.ToInt32(Session["roleID"]) == 5) {
                            desc = "peerManagerReq";
                        }
                        else if (Convert.ToInt32(Session["roleID"]) == 6)
                        {
                            desc = "peerHigherReq";
                        }
                        else { 
                        desc="Unknown case";
                        }
                        bool requestEscalated = TransactionModel.escalateTransaction(currentSelectedTransReq.id, desc, selectedpeername);
                        if(requestEscalated){
                            reqResultLB.Text = "Request succesfully escalated";
                        }else{
                        reqResultLB.Text = "Request could not be made, please verify all the details and try again";
                        
                        }
                    }
                    else {
                        reqResultLB.Text = "Please choose a transcation";
                    }
                }
            }
            refreshReqUI();
        }

        protected void refreshReqUI() { 
        
        approveReqBT.Visible = false;
        escalateToPeerBT.Visible = false;
        escalateTohigherMangerBT.Visible=false;
        rejectReqBT.Visible = false;
        authorizersDDReqTab.Visible = false;
        pickAuthlabelinReqTab.Visible = false;

        string username = Session["userName"].ToString();
        currentPendingTransReqs = TransactionModel.GetAuthorizationRequestedTransactionsForUser(username);
        if (currentPendingTransReqs != null)
        {
            if (currentPendingTransReqs.Count > 0)
            {
                reqGridV.DataSource = currentPendingTransReqs;
                reqGridV.DataBind();
            }
            else
            {
               // reqResultLB.Text = "No pending requests";
            }
        }
        else {
            //reqResultLB.Text = "No pending requests";
            reqGridV.Visible = false;
        }

        }

        protected void escalateTohigherMangerBT_Click(object sender, EventArgs e)
        {

            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx", false);
            }
            else
            {
                checkSession();
                string selectedHighername = authorizersDDReqTab.Text.ToString();
                if (selectedHighername == null || selectedHighername.Equals(""))
                {
                    reqResultLB.Text = "Please choose an authorizer to escalate";
                }
                else
                {
                    if (currentSelectedTransReq != null)
                    {
                        string desc = "";
                        if (Convert.ToInt32(Session["roleID"]) == 5)
                        {
                            desc = "HigherManagerReq";
                        }
                        else if (Convert.ToInt32(Session["roleID"]) == 6)
                        {
                            desc = "should not happen";
                        }
                        else
                        {
                            desc = "Unknown case";
                        }
                        bool requestEscalated = TransactionModel.escalateTransaction(currentSelectedTransReq.id, desc, selectedHighername);
                        if (requestEscalated)
                        {
                            reqResultLB.Text = "Request succesfully escalated";
                        }
                        else
                        {
                            reqResultLB.Text = "Request could not be made, please verify all the details and try again";

                        }
                    }
                    else
                    {
                        reqResultLB.Text = "Please choose a transcation";
                    }
                }
            }
            refreshReqUI();


        }

        protected string generateUsername(string firstName, string lastName)
        {
            string username = "";
            if ((firstName.Length < 2) || (lastName.Length < 5))
            {
                Random rand = new Random();
                username = firstName + lastName + rand.Next(10000000);
            }
            else
            {
                Random rand = new Random();
                username = firstName.Substring(0, 2) + lastName.Substring(0, 5) + rand.Next(1000);
            }
            return username;
        }

        protected string generatePassword()
        {
            Random rand = new Random();
            string password = "Ss" + rand.Next(1000000) + "q" + "#";
            return password;
        }

        protected void deptTabInitialize(object sender, EventArgs e)
        {
            if(Convert.ToInt32(Session["roleID"]) == 5)
            {
                //Initializing Department Tabs for dept Mgr
                DeptDD_AddEmp.SelectedValue = Session["deptID"].ToString();
                DeptDD_AddEmp.Enabled = false;
                RoleDD_AddEmp.SelectedValue = "4";
                RoleDD_AddEmp.Enabled = false;
                TO_RoleDD_TransEmp.Visible = false;
                Label2.Visible = false;
            }
            if (Convert.ToInt32(Session["roleID"]) == 6)
            {
                DeptDD_AddEmp.SelectedValue = Session["deptID"].ToString();
                DeptDD_AddEmp.Enabled = false;
                TO_RoleDD_TransEmp.Visible = true;
                Label2.Visible = true;
            }
        }

        protected void placeReqBTinOutside_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("SessionTimeOut.aspx", false);
            }
            else
            {
                checkSession();
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


                                    double amount = Convert.ToDouble(tb_amountoutside.Text);


                                    if (amount < 30000)
                                    {
                                        lblStatus_OutsideBank.Text = "This trasaction does not require authorization,proceeding with normal transaction";
                                        string desc = "From : " + accTypeDD_TransferExistingCust_Outside.SelectedValue.ToString() + " To : " + tb_AccNumoutside_Intenal.Text.ToString() +
                                                                               " Amount : " + tb_amountoutside.Text.ToString() + " EMAIL : " + tb_emailoutside.Text.ToString();
                                        int success = TransactionModel.MakeExternalTransfer(objCard.accountNumber, objCard.Account.routingNumber, tb_AccNumoutside_Intenal.Text.ToString(),
                                                                    tb_toRoutingNum_OutsideBank.Text.ToString(), Convert.ToDouble(tb_amountoutside.Text.ToString()), desc);
                                        if (success > 0)
                                        {
                                            lblStatus_OutsideBank.Text = "Transaction Successful";

                                            lblStatus_OutsideBank.Visible = true;
                                        }
                                        else
                                        {
                                            lblStatus_OutsideBank.Text = "Transaction Unsuccessful";

                                            lblStatus_OutsideBank.Visible = true;
                                        }
                                        pleaseChooinOutside.Visible = false;
                                        authorizerDDinOutside.Visible = false;
                                        placeReqBTinOutside.Visible = false;
                                    }
                                    else if (amount >= 30000)
                                    {

                                        string desc = "crtLevel2ReqInitiated";
                                        int level2ReqiD = TransactionModel.MakeExternalTransfer(objCard.accountNumber, objCard.Account.routingNumber, tb_AccNumoutside_Intenal.Text.ToString(),
                                                                    tb_toRoutingNum_OutsideBank.Text.ToString(), Convert.ToDouble(tb_amountoutside.Text.ToString()), desc);

                                        User selectedAuthorizer = UserModel.GetUser(authorizerDDinOutside.Text.ToString() );

                                        //
                                        if (level2ReqiD > 0)
                                        {
                                            bool assignedlevel2Trans = TransactionModel.AssignAuthorizationRequestedTransactionToUser(level2ReqiD, selectedAuthorizer.username.ToString(), Convert.ToInt32(selectedAuthorizer.roleId));
                                            if (assignedlevel2Trans)
                                            {
                                                lblStatus_OutsideBank.Text = "Request sucesfully escalated to manager";
                                                lblStatus_OutsideBank.Visible = true;
                                            }
                                            else
                                            {
                                                lblStatus_OutsideBank.Text = "Request could not be escalated";
                                                lblStatus_OutsideBank.Visible = true;
                                            }

                                        }
                                        else
                                        {
                                            lblStatus_OutsideBank.Text = "Unsuccessful(check balance and details)";
                                            lblStatus_OutsideBank.Visible = true;
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
                        //Update the UI with error message.
                    }
                    pleaseChooinOutside.Visible = false;
                    authorizerDDinOutside.Visible = false;
                    placeReqBTinOutside.Visible = false;
                }
                catch (Exception exp)
                {
                    Elog.Error("Exception occurred: " + exp.Message);
                }
            }
        }
        
        protected void btn_ViewDeptTrans_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                    var db = new SSBankDBContext();
                    List<DepartmentTransaction> deptTransactions = db.DepartmentTransactions.SqlQuery("SELECT * FROM dbo.DepartmentTransactions WHERE (fromDepartmentId = @p0 OR toDepartmentId = @p1)", Session["deptId"], Session["deptId"]).ToList();
                    gv_DeptTrans.DataSource = deptTransactions;
                    gv_DeptTrans.DataBind();
                }
            }
            catch (Exception exp)
            {
                 Elog.Error("Exception : " + exp.Message);
            }
        }

        protected void btn_viewtransdetails2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                    var db = new SSBankDBContext();
                    List<DepartmentTransaction> deptTransactions = db.DepartmentTransactions.SqlQuery("SELECT * FROM dbo.DepartmentTransactions").ToList();
                    gv_AllDepTrans.DataSource = deptTransactions;
                    gv_AllDepTrans.DataBind();
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception : " + exp.Message);
            }
        }


        #region EditProfile
        protected void btnEditProfile_int_Click(object sender, EventArgs e)
        {
            try
            {
                tab_EditProfile.Visible = true;
                tab_EditProfile.ActiveTabIndex = 0;
                tb_emailedit_int.Text = tb_emailview_int.Text;
                tb_addr_editprofile_int.Text = tb_streetAddress_int.Text;
                tb_city_editProfile_int.Text = tb_city_int.Text;
                StateDD_EditProfile_int.SelectedValue = StateDD_Profile_int.SelectedValue;
                tb_zip_editProfile_int.Text = tb_ZipCode_Profile_int.Text;
                tb_contactedit_int.Text = tb_contactview_int.Text;

                //Check if the user has set the site key value. IF yes, then dont show the site key tab panel.
                Models.Tables.User objUser = UserModel.GetUser(Session["userName"].ToString());
                if (objUser.siteKeyVal > 0 && (objUser.roleId == 4 || objUser.roleId == 5 || objUser.roleId == 6))
                {
                    tab_EditProfile.ActiveTabIndex = 0;
                    tab_EditProfile.Tabs[2].Visible = false;
                    tab_EditProfile.Tabs[1].Visible = true;
                    lstQandA = PasswordModel.GetSecurityQandA(Session["userName"].ToString());
                    if (lstQandA != null)
                    {
                        dd_secque1_int.SelectedValue = Convert.ToString(lstQandA.First().questionId);
                        dd_secque2_int.SelectedValue = Convert.ToString(lstQandA.ElementAt(1).questionId);
                        dd_secque3_int.SelectedValue = Convert.ToString(lstQandA.Last().questionId);
                    }
                    dd_secque1_int.Enabled = false;
                    dd_secque2_int.Enabled = false;
                    dd_secque3_int.Enabled = false;
                }
                else
                {
                    tab_EditProfile.ActiveTabIndex = 2;
                    tab_EditProfile.Tabs[1].Visible = false;
                    tab_EditProfile.Tabs[2].Visible = true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }

        protected void img_site_int3_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "3";
            img_site_int3.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int3.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int1_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "1";
            img_site_int1.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int1.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int2_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "2";
            img_site_int2.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int2.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int4_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "4";
            img_site_int4.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int4.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int5_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "5";
            img_site_int5.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int5.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int6_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "6";
            img_site_int6.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int6.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int7_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "7";
            img_site_int7.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int7.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int8_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "8";
            img_site_int8.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int8.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int9_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "9";
            img_site_int9.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int9.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int10_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "10";
            img_site_int10.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int10.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int11_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "11";
            img_site_int11.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int11.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int12_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "12";
            img_site_int12.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int12.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int13_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "13";
            img_site_int13.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int13.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int14_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "14";
            img_site_int14.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int14.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int15_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "15";
            img_site_int15.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int15.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int16_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "16";
            img_site_int16.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int16.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int17_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "17";
            img_site_int17.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int17.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int18_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "18";
            img_site_int18.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int18.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int19_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "19";
            img_site_int19.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int19.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site_int20_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "20";
            img_site_int20.BorderColor = System.Drawing.Color.DarkBlue;
            img_site_int20.BorderStyle = BorderStyle.Solid;
        }

        protected void btnSetSiteKey_int_Click(object sender, EventArgs e)
        {
            try
            {
                bool serversideValidation = false;
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                    //Check if the user has set the site key value. IF yes, then dont show the site key tab panel.
                    Models.Tables.User objUser = UserModel.GetUser(Session["userName"].ToString());
                    if (objUser.roleId == 4 || objUser.roleId == 5 || objUser.roleId == 6)
                    {
                        //Check if all the security questions are different.
                        List<Int32> lstSelectedQ = new List<Int32>();
                        lstSelectedQ.Add(Convert.ToInt32(Sec1DD_PersonalInformation_int.SelectedValue));
                        lstSelectedQ.Add(Convert.ToInt32(Sec2DD_PersonalInformation_int.SelectedValue));
                        lstSelectedQ.Add(Convert.ToInt32(Sec3DD_PersonalInformation_int.SelectedValue));
                        if (lstSelectedQ.Distinct().Count() == 3)
                        {
                            Dictionary<int, string> dictAns = new Dictionary<int, string>();
                            dictAns.Add(1, tb_SecAns1_Cust_int.Text.ToString());
                            dictAns.Add(2, tb_SecAns2_Cust_int.Text.ToString());
                            dictAns.Add(3, tb_SecAns3_Cust_int.Text.ToString());
                            serversideValidation = validateFromFields(dictAns, tb_SSN_Cust_int.Text.ToString(), tb_sitekeyhint_Cust_int.Text.ToString());
                            if (serversideValidation)
                            {
                                bool success = UserModel.UpdateUserSiteKeyAndQA(Session["userName"].ToString(), dictAns, tb_SSN_Cust_int.Text.ToString(), siteKeySelected, tb_sitekeyhint_Cust_int.Text.ToString());
                                if (success)
                                {
                                    lblStatus_SiteKey_int.Text = "Values Updated Successfully";
                                    btnSetSiteKey_int.Enabled = false;
                                    lblStatus_SiteKey_int.Visible = true;
                                }
                                else
                                {
                                    //Update Failure
                                    lblStatus_SiteKey_int.Text = "Update Failed. Try Again";
                                    lblStatus_SiteKey_int.Visible = true;
                                }
                            }
                            else
                            {
                                //Invalid Entries.
                                lblStatus_SiteKey_int.Text = "Invalid Entries";
                                lblStatus_SiteKey_int.Visible = true;
                            }
                        }
                        else
                        {
                            //Please select different questions.
                            lblStatus_SiteKey_int.Text = "Please select different questions";
                            lblStatus_SiteKey_int.Visible = true;
                        }
                    }
                    else
                    {
                        //Invalid USer.
                        Response.Redirect("ExternalHomePage.aspx", false);
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
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
        private bool validateFromFields(Dictionary<int, string> dictAns, string strSSN, string strSiteKey)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();

                int iCtr = 0;
                List<int> iKeys = new List<int>(dictAns.Keys);
                foreach (int i in iKeys)
                {
                    bool bAns = fieldValidator.validate_UserName(dictAns[i]);
                    if (bAns)
                        iCtr++;
                }
                bool bssn = fieldValidator.validate_ZipAccCrdPhn(strSSN, 9);
                bool bstrSiteKey = fieldValidator.validate_UserName(strSiteKey);
                if (iCtr == 3 && bssn && bstrSiteKey)
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
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        protected void btn_changepwd_int_Click(object sender, EventArgs e)
        {
            try
            {
                bool serverSideValidation = false;
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                    //Check if the user has set the site key value. IF yes, then dont show the site key tab panel.
                    Models.Tables.User objUser = UserModel.GetUser(Session["userName"].ToString());
                    if (objUser.roleId == 4 || objUser.roleId == 5 || objUser.roleId == 6)
                    {
                        Dictionary<int, string> dictAns = new Dictionary<int, string>();
                        dictAns.Add(1, tb_secans_int1.Text.ToString());
                        dictAns.Add(2, tb_secans_int2.Text.ToString());
                        dictAns.Add(3, tb_secans_int3.Text.ToString());
                        serverSideValidation = validateFromFields(tb_oldpwd_int.Text.ToString(), dictAns, tb_newPass_int.Text.ToString(), tb_confrimPass_int.Text.ToString());
                        if (serverSideValidation)
                        {
                            //Proceed with business logic here
                            if (LoginModel.LoginUser(Session["userName"].ToString(), tb_oldpwd_int.Text.ToString()) > 0)
                            {
                                string strAns1 = (lstQandA.First().answer).ToLower();
                                string strAns2 = (lstQandA.ElementAt(1).answer).ToLower();
                                string strAns3 = (lstQandA.Last().answer).ToLower();

                                if (tb_secans_int1.Text.ToLower().Equals(strAns1) && tb_secans_int2.Text.ToLower().Equals(strAns2)
                                        && tb_secans_int3.Text.ToLower().Equals(strAns3))
                                {
                                    if (tb_newPass_int.Text.Equals(tb_confrimPass_int.Text) && !(tb_newPass_int.Text.Equals(tb_oldpwd_int.Text.ToString())))
                                    {
                                        bool success = PasswordModel.ChangePwd(Session["userName"].ToString(), tb_newPass_int.Text.ToString());
                                        if (success)
                                        {
                                            lblStatus_ChgPwd_int.Text = "Password Changed Successfully";
                                            lblStatus_ChgPwd_int.Visible = true;
                                        }
                                        else
                                        {
                                            lblStatus_ChgPwd_int.Text = "Password Changed Failed, Please try again";
                                            lblStatus_ChgPwd_int.Visible = true;
                                        }
                                    }
                                    else
                                    {
                                        lblStatus_ChgPwd_int.Text = "passwords dont match";
                                        lblStatus_ChgPwd_int.Visible = true;
                                    }
                                }
                                else
                                {
                                    lblStatus_ChgPwd_int.Text = "Answers Dont match";
                                    lblStatus_ChgPwd_int.Visible = true;
                                }
                            }
                            else
                            {
                                lblStatus_ChgPwd_int.Text = "Old password Dont match";
                                lblStatus_ChgPwd_int.Visible = true;
                            }
                        }
                        else
                        {
                            //Update the UI with error message.
                            lblStatus_ChgPwd_int.Text = "Failed to fetch pwd info";
                            lblStatus_ChgPwd_int.Visible = true;
                        }
                    }
                    else
                    {
                        //Invalid user
                        Response.Redirect("ExternalHomePage.aspx", false);
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }

        protected void btn_changesettings_profile_int_Click(object sender, EventArgs e)
        {
            try
            {
                bool serverSideValidation = false;
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                    Models.Tables.User objUser = UserModel.GetUser(Session["userName"].ToString());
                    if (objUser.roleId == 4 || objUser.roleId == 5 || objUser.roleId == 6)
                    {
                        serverSideValidation = validateFromFields_editProfile(tb_emailedit_int.Text.ToString(), tb_addr_editprofile_int.Text.ToString(),
                                            tb_city_editProfile_int.Text.ToString(), tb_zip_editProfile_int.Text.ToString(), tb_contactedit_int.Text.ToString(), "jaffa");
                        if (serverSideValidation)
                        {
                            //Proceed with business logic here
                            bool success = UserModel.UpdateUser(Session["userName"].ToString(), tb_emailedit_int.Text.ToString(), tb_addr_editprofile_int.Text.ToString(),
                                    tb_city_editProfile_int.Text.ToString(), StateDD_EditProfile_int.SelectedValue.ToString(), tb_zip_editProfile_int.Text.ToString(),
                                        tb_contactedit_int.Text.ToString());
                            if (success)
                            {
                                lblChaneProfile_int.Text = "Update Successful";
                                lblChaneProfile_int.Visible = true;
                            }
                            else
                            {
                                lblChaneProfile_int.Text = "Update Unsuccessful";
                                lblChaneProfile_int.Visible = true;
                            }
                        }
                        else
                        {
                            //Update the UI with error message.
                            lblChaneProfile_int.Text = "Invalid Entries";
                            lblChaneProfile_int.Visible = true;
                        }
                    }
                    else
                    {
                        //Invalid User 
                        Response.Redirect("ExternalHomePage.apsx", false);
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }

        protected void tab_EditProfile_ActiveTabChanged(object sender, EventArgs e)
        {
            try
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                    //Check if the user has set the site key value. IF yes, then dont show the site key tab panel.
                    Models.Tables.User objUser = UserModel.GetUser(Session["userName"].ToString());
                    if (objUser.roleId == 4 || objUser.roleId == 5 || objUser.roleId == 6)
                    {
                        if (tab_EditProfile.ActiveTabIndex == 2)
                        {
                            if (objUser.siteKeyVal > 0)
                            {
                                Sec1DD_PersonalInformation_int.Enabled = false;
                                tb_SecAns1_Cust_int.Enabled = false;
                                Sec2DD_PersonalInformation_int.Enabled = false;
                                tb_SecAns2_Cust_int.Enabled = false;
                                Sec3DD_PersonalInformation_int.Enabled = false;
                                tb_SecAns3_Cust_int.Enabled = false;
                                tb_SSN_Cust_int.Enabled = false;
                                tb_sitekeyhint_Cust_int.Enabled = false;
                                btnSetSiteKey_int.Enabled = false;
                            }
                            else
                            {
                                Sec1DD_PersonalInformation_int.Enabled = true;
                                tb_SecAns1_Cust_int.Enabled = true;
                                Sec2DD_PersonalInformation_int.Enabled = true;
                                tb_SecAns2_Cust_int.Enabled = true;
                                Sec3DD_PersonalInformation_int.Enabled = true;
                                tb_SecAns3_Cust_int.Enabled = true;
                                tb_SSN_Cust_int.Enabled = true;
                                tb_sitekeyhint_Cust_int.Enabled = true;
                                btnSetSiteKey_int.Enabled = true;
                            }
                        }
                    }
                    else
                    {
                        //Invalid User
                        Response.Redirect("ExternalHomePage.aspx", false);
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);

            }
        }
        #endregion
        protected void checkSession()
        {
            try
            {
                string session = UserModel.GetUserSessionID(Session["userName"].ToString());
                if (session != Session.SessionID)
                {
                    Session.Abandon();
                    Response.Redirect("ExternalHomePage.aspx",false);
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception :" + exp.Message);
            }

        }

        protected void btnFetchDetailsSummary_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["userName"] == null)
                {
                    //Redirect to Session Time Out Page
                    Response.Redirect("SessionTimeOut.aspx", false);
                }
                else
                {
                    checkSession();
                    //getCount(roleid, departmentid);
                    tbSalesRegCount.Text = "17";
                    tbSalesDeptCount.Text = "6";
                    tbSalesHgrCount.Text = "2";
                    tbITRegCount.Text = "4";
                    tbITDeptCount.Text = "2";
                    tbITHgrCount.Text = "1";
                    tbHRDeptCount.Text = "2";
                    tbHRDeptCount.Text = "2";
                    tbHRDeptCount.Text = "1";                   

                }
            }
            catch(Exception exp)
            {
                Elog.Error("Exception :" + exp.Message);
            }
        }

        private int getCount(string roleId,string deptId)
        {
            try
            {

                return -1;
            }
            catch(Exception exp)
            {
                Elog.Error("Excetpion : " + exp.Message);
                return -1;
            }
        }

        protected void TabContainer5_ActiveTabChanged(object sender, EventArgs e)
        {
            try
            {
                tb_cardnum.Text = "";
                tb_customername.Text = "";
                cardExpDD_CardPayment.SelectedIndex = 0;
                cardExpDD_CardPayment.SelectedIndex = 0;
                yearDD_CardPayment.SelectedIndex = 0;
                tb_amount_SubmitPayment.Text = "";
                tb_echeckaccno.Text = "";
                tb_echeckroutingno.Text = "";
                tb_echeckcustomername.Text = "";
                tbAmount_EcheckPayment.Text = "";
                lblSubmitPayment.Text = "";
                lblEcheckPayment.Text = "";
            }
            catch (Exception exp)
            {
                Elog.Error("Exceptions : " + exp.Message);
            }
        }
    }

}