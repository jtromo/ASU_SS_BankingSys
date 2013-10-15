﻿using SoftSec_BankingApp_Se7en.Models;
using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SSBank
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Database test methods
            LoginModel login = new LoginModel();
            Response.Write("Does the user exist?: ");
            Response.Write(login.UserExists("jtromo", 12345));

            Response.Write(" Returned id: ");
            Response.Write(login.LoginUser("jtromo", "adfaf", 12345));

            DebugModel debug = new DebugModel();
            debug.InsertSampleUsers();

            Response.Write(" Number of sample questions: ");
            Response.Write(debug.NumberOfSecurityQuestions());

            PasswordModel password = new PasswordModel();
            Response.Write(" Password change: ");
            Response.Write(password.ChangePwd("jtromo", "newPasword"));

            Response.Write(" Security qa for user: ");
            SecurityQandA securityQuestions = password.GetSecurityQandA("jtromo");
            foreach (string question in securityQuestions.questions)
            {
                Response.Write(" Question: " + question);
            }
            foreach (string answer in securityQuestions.answers)
            {
                Response.Write(" Answer: " + answer);
            }
        }
    }
}