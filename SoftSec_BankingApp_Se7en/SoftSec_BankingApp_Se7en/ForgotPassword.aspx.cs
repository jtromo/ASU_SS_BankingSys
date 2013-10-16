using SoftSec_BankingApp_Se7en.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftSec_BankingApp_Se7en
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

                serverSideValidation = validateFromFields(dictAns);
                if (serverSideValidation)
                {
                    //Proceed with business logic here
                }
                else
                {
                    //Update the UI with error message.
                }
                double bal = 0.0;
                
                AccountModel acm = new AccountModel();
                List<SoftSec_BankingApp_Se7en.Models.Tables.Account> lst = acm.GetAccountsForUser("sma").ToList();
                foreach (SoftSec_BankingApp_Se7en.Models.Tables.Account acc in lst)
                {
                    bal = acc.balance;
                    break;
                }
                tb_secans3.Text = bal.ToString();
            }
            catch (Exception exp)
            {
                //Log Exception here
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