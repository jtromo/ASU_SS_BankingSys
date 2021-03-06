﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SoftSec_BankingApp_Se7en.Models;
using SoftSec_BankingApp_Se7en.Models.Tables;
using log4net;
using System.Net.Mail;

namespace SoftSec_BankingApp_Se7en
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        private static readonly ILog Elog = LogManager.GetLogger("ExceptionFileAppender");

        private static List<SecurityQuestion> lstQandA = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    lblStatus_ForgotPassword.Visible = false;
                    lstQandA = PasswordModel.GetSecurityQandA(Session["userName"].ToString());
                    dd_secque1.SelectedValue = Convert.ToString(lstQandA.First().questionId);
                    dd_secque2.SelectedValue = Convert.ToString(lstQandA.ElementAt(1).questionId);
                    dd_secque3.SelectedValue = Convert.ToString(lstQandA.Last().questionId);
                    dd_secque1.Enabled = false;
                    dd_secque2.Enabled = false;
                    dd_secque3.Enabled = false;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
            }
        }

        protected void btn_changepwd_Click(object sender, EventArgs e)
        {
            //Check if the answers are valid inputs
            if (Page.IsValid)
            {
                bool serverSideValidation = false;
                Dictionary<int, string> dictAns = new Dictionary<int, string>();
                try
                {
                    dictAns.Add(1, tb_secans1.Text.ToString());
                    dictAns.Add(2, tb_secans2.Text.ToString());
                    dictAns.Add(3, tb_secans3.Text.ToString());

                    serverSideValidation = validateFromFields_forgotPwd(dictAns);
                    if (serverSideValidation)
                    {
                        string strAns1 = (lstQandA.First().answer).ToLower();
                        string strAns2 = (lstQandA.ElementAt(1).answer).ToLower();
                        string strAns3 = (lstQandA.Last().answer).ToLower();

                        if (tb_secans1.Text.ToLower().Equals(strAns1) && tb_secans2.Text.ToLower().Equals(strAns2)
                                && tb_secans3.Text.ToLower().Equals(strAns3))
                        {
                            string sucPass = PasswordModel.MailPwd(Session["userName"].ToString());
                            if (sucPass.Length == 14)
                            {
                                lblStatus_ForgotPassword.Text = "Password Changed Successfully. It has been sent to your Registered Email";
                                lblStatus_ForgotPassword.Visible = true;
                                MailMessage mMailMessage = new MailMessage();
                                mMailMessage.From = new MailAddress("bankse7en@gmail.com");
                                mMailMessage.To.Add(new MailAddress(UserModel.GetUser(Session["userName"].ToString()).email));
                                mMailMessage.Subject = "Password Generation";
                                string bodyOfMail = "Your Password has been changed. Please Find below the passowrd.";
                                bodyOfMail += " Password : " + sucPass;
                                bodyOfMail += "<br> Please login to the system and make sure you change the password.<br>";
                                bodyOfMail += "Regards, <br> BankofSe7en";
                                mMailMessage.Body = bodyOfMail;
                                mMailMessage.IsBodyHtml = true;
                                mMailMessage.Priority = MailPriority.Normal;
                                SmtpClient mSmtpClient = new SmtpClient();
                                mSmtpClient.EnableSsl = true;
                                mSmtpClient.Send(mMailMessage);
                                resetFields();
                            }
                            else
                            {
                                lblStatus_ForgotPassword.Text = "Password Changed Failed, Please try again";
                                lblStatus_ForgotPassword.Visible = true;
                            }
                        }
                        else
                        {
                            //Invalid Answers
                            lblStatus_ForgotPassword.Text = "Invalid answers, Please try again";
                            lblStatus_ForgotPassword.Visible = true;
                        }
                    }
                    else
                    {
                        //Update the UI with error message.
                        lblStatus_ForgotPassword.Text = "Invalid Entries, Please try again";
                        lblStatus_ForgotPassword.Visible = true;
                    }
                }
                catch (Exception exp)
                {
                    Elog.Error("Exception occurred: " + exp.Message);
                }
            }
            else {
                lblStatus_ForgotPassword.Text = "check captcha";
                lblStatus_ForgotPassword.Visible = true;
            }
        }
        private void resetFields()
        {
            tb_secans1.Text = "";
            tb_secans2.Text = "";
            tb_secans3.Text = "";
            
        }

        private bool validateFromFields_forgotPwd(Dictionary<int, string> dictAns)
        {
            try
            {
                FieldValidator objField = new FieldValidator();
                int iCtr = 0;
                List<int> iKeys = new List<int>(dictAns.Keys);
                foreach (int i in iKeys)
                {
                    bool bAns = objField.validate_UserName(dictAns[i]);
                    if (bAns)
                        iCtr++;
                }
               
                if (iCtr == 3)
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
        /// Validate the answers entered by the user
        /// </summary>
        /// <param name="dictAns">Contains the answers and question number mapped to each other</param>
        /// <returns>True if all the answers entered are valid. False otherwise</returns>
        private bool validateFromFields(Dictionary<int, string> dictAns)
        {
            try
            {
                FieldValidator fieldValidator = new FieldValidator();
                int iCtr = 0;
                List<int> iKeys = new List<int>(dictAns.Keys);
                foreach (int i in iKeys)
                {
                    bool bAns = fieldValidator.validate_Names(dictAns[i]);
                    if (bAns)
                        iCtr++;
                }
                if (iCtr == 2)
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
    }
}