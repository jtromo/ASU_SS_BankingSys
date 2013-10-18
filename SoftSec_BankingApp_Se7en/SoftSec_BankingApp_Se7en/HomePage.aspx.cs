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
            Response.Write(" New user created: " + debug.InsertSampleUsers());

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

            AccountModel accountModel = new AccountModel();
            ICollection<SoftSec_BankingApp_Se7en.Models.Tables.Account> accounts = accountModel.GetAccountsForUser("jtromo");
            Response.Write(" Number of accounts for jtromo: " + accounts.Count());

            ICollection<Transaction> transaction = accountModel.GetTransactionsForAccount(12334123);
            Response.Write(" Number of transactions for account 12334123: " + transaction.Count());

            LastNameZipcode lastNameZip = accountModel.GetLastNameAndZipcode(12334123);
            Response.Write(" Last name and zip for account 12334123: " + lastNameZip.lastName + " " + lastNameZip.zipcode);

            bool testTransferInternal = accountModel.MakeInternalTransfer(12345, 12334123, 0.11, "test internal transfer");
            Response.Write(" Creating test transfer Internal between 12345 and 12334123: " + testTransferInternal);

            bool testTransferExternal = accountModel.MakeExternalTransfer(12345, 12334123, 1231231, 0.11, "test transfer");
            Response.Write(" Creating test transfer External between 12345 and 12334123: " + testTransferExternal);

            Account foundAccount = accountModel.GetAccount(12334123);
            Response.Write(" Retrieving account: 12334123 " + " Account balance: " + foundAccount.balance);

            UserModel userModel = new UserModel();
            User user = userModel.GetUser("jtromo");
            Response.Write(" Retrieving user jtromo: " + user.username + " " + user.hash);

            Card card = accountModel.GetCardDetails(98999999);
            Response.Write(" Retrieving card for 98999999: " + card.firstName + " " + card.lastName + " CVV " + card.cvv + " experation: " + card.expirationDate);

            Address newAddress = new Address { firstName = "John", lastName = "Smith", street1 = "Street", city = "City", state = "State", zip = 12345, country = "Country", isActive = true };
            User newUser = new User { roleId = 1, firstName = "John", middleName = "T", lastName = "Smith", username = "john", email = "@gmail.com", salt = "adfa", hash = "adfaf", phone = "adsfadsf", organization = "adfs", siteKeyVal = 3, isActive = true, UserDepartment = null, Address = newAddress };
            List<string> newAnswers = new List<string>{ "answer1", "answer2" };
            List<string> newQuestions = new List<string>{ "test1", "test2" };
            SecurityQandA newSecurityQandA = new SecurityQandA(newQuestions, newAnswers);
            bool newUserCreated = userModel.creatUser(newUser, newAddress, newSecurityQandA);
            Response.Write(" New user was created: " + newUserCreated);
        }
    }
}