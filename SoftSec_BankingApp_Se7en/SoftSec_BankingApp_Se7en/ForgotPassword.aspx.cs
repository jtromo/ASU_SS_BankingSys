using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SoftSec_BankingApp_Se7en.Models;
using SoftSec_BankingApp_Se7en.Models.Tables;

namespace SoftSec_BankingApp_Se7en
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
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
                //Log exceptions here
            }
        }

        protected void btn_changepwd_Click(object sender, EventArgs e)
        {
            //Check if the answers are valid inputs
            bool serverSideValidation = false;
            Dictionary<int, string> dictAns = new Dictionary<int, string>();
            try
            {
                dictAns.Add(1, tb_secans1.Text.ToString());
                dictAns.Add(2, tb_secans2.Text.ToString());
                dictAns.Add(3, tb_secans3.Text.ToString());

                serverSideValidation = validateFromFields_forgotPwd(dictAns, tb_newpwd.Text, tb_newpwd2.Text);
                if (serverSideValidation)
                {
                    string strAns1 = (lstQandA.First().answer).ToLower();
                    string strAns2 = (lstQandA.ElementAt(1).answer).ToLower();
                    string strAns3 = (lstQandA.Last().answer).ToLower();

                    if (tb_secans1.Text.ToLower().Equals(strAns1) && tb_secans2.Text.ToLower().Equals(strAns2)
                            && tb_secans3.Text.ToLower().Equals(strAns3))
                    {
                        if (tb_newpwd.Text.Equals(tb_newpwd2.Text))
                        {
                            bool success = PasswordModel.ChangePwd(Session["userName"].ToString(), tb_newpwd.Text.ToString());
                            if (success)
                            {
                                lblStatus_ForgotPassword.Text = "Password Changed Successfully";
                                lblStatus_ForgotPassword.Visible = true;
                            }
                            else
                            {
                                lblStatus_ForgotPassword.Text = "Password Changed Failed, Please try again";
                                lblStatus_ForgotPassword.Visible = true;
                            }
                        }
                        else
                        {
                            //New Passwords Dont match
                            lblStatus_ForgotPassword.Text = "Passwords don't match, Please try again";
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
                //Log Exception here
            }
        }

        private bool validateFromFields_forgotPwd(Dictionary<int, string> dictAns, string newPass, string confirmPass)
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
                string strTemp = string.Empty;
                string strNewPass = objField.validate_password(newPass);
                strTemp = strNewPass.Substring(strNewPass.IndexOf('_') + 1);
                bool bNewPass = false;
                if (strTemp.Equals("TRUE"))
                {
                    bNewPass = true;
                }
                string strConfirmPass = objField.validate_password(confirmPass);
                strTemp = strConfirmPass.Substring(strConfirmPass.IndexOf('_') + 1);
                bool bConfPass = false;
                if (strTemp.Equals("TRUE"))
                {
                    bConfPass = true;
                }
                if (bNewPass && bConfPass && iCtr == 3)
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
                //Log Exception Here
                return false;
            }
        }
    }
}