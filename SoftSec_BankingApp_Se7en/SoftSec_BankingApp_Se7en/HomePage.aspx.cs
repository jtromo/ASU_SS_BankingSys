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
            Response.Write(login.LoginUser("jtromo", "newPasword"));

            DebugModel debug = new DebugModel();
            Response.Write(" New user created: " + debug.InsertSampleUsers());

            Response.Write(" Number of sample questions: ");
            Response.Write(debug.NumberOfSecurityQuestions());

            PasswordModel password = new PasswordModel();
            Response.Write(" Password change: ");
            Response.Write(password.ChangePwd("jtromo", "newPasword"));

            Response.Write(" Security qa for user: ");
            SecurityQandA securityQuestions = password.GetSecurityQandA("jtromo");
            if (securityQuestions != null)
            {
                foreach (string question in securityQuestions.questions)
                {
                    Response.Write(" Question: " + question);
                }
                foreach (string answer in securityQuestions.answers)
                {
                    Response.Write(" Answer: " + answer);
                }
            }
            AccountModel accountModel = new AccountModel();
            ICollection<SoftSec_BankingApp_Se7en.Models.Tables.Account> accounts = accountModel.GetAccountsForUser("jtromo");
            Response.Write(" Number of accounts for jtromo: " + accounts.Count());

            ICollection<Transaction> transaction = accountModel.GetTransactionsForAccount("12334123");
            if(transaction !=null)
                Response.Write(" Number of transactions for account 12334123: " + transaction.Count());

            LastNameZipcode lastNameZip = accountModel.GetLastNameAndZipcode("12334123");
            if(lastNameZip != null)
                Response.Write(" Last name and zip for account 12334123: " + lastNameZip.lastName + " " + lastNameZip.zipcode);

            bool testTransferInternal = accountModel.MakeInternalTransfer("12345", "12334123", 0.11, "test internal transfer");
            Response.Write(" Creating test transfer Internal between 12345 and 12334123: " + testTransferInternal);

            bool testTransferExternal = accountModel.MakeExternalTransfer("12345", "12334123", "1231231", 0.11, "test transfer");
            Response.Write(" Creating test transfer External between 12345 and 12334123: " + testTransferExternal);

            Account foundAccount = accountModel.GetAccount("12334123");
            if(foundAccount != null)
                Response.Write(" Retrieving account: 12334123 " + " Account balance: " + foundAccount.balance);

            UserModel userModel = new UserModel();
            User user = userModel.GetUser("jtromo");
            if(user !=null)
                Response.Write(" Retrieving user jtromo: " + user.username);

            Card card = accountModel.GetCardDetails(Convert.ToString(98999999));
            if(card != null)
                Response.Write(" Retrieving card for 98999999: " + card.firstName + " " + card.lastName + " CVV " + card.cvv + " experation: " + card.expirationDate);

            Address newAddress = new Address { firstName = "John", lastName = "Smith", street1 = "Street", city = "City", state = "State", zip = 12345, country = "Country", isActive = true };
            User newUser = new User { roleId = 1, firstName = "John", middleName = "T", lastName = "Smith", username = "john", email = "@gmail.com", phone = "adsfadsf", organization = "adfs", siteKeyVal = 3, isActive = true, UserDepartment = null, Address = newAddress };
            List<string> newAnswers = new List<string>{ "answer1", "answer2" };
            List<string> newQuestions = new List<string>{ "test1", "test2" };
            SecurityQandA newSecurityQandA = new SecurityQandA(newQuestions, newAnswers);
            bool newUserCreated = userModel.CreatUser(newUser, "password", newAddress, newSecurityQandA);
            Response.Write(" New user was created: " + newUserCreated);

            //Sample Script
            Address newAddress1 = new Address { firstName = "uday", lastName = "mac", street1 = "Street 123", city = "Tempe", state = "AZ", zip = 85281, country = "US", isActive = true };
            User newUser1 = new User { roleId = 1, firstName = "uday", middleName = "K", lastName = "Mac", username = "umac18", email = "uday@gmail.com", phone = "1234567890", organization = "ASU", siteKeyVal = 5, isActive = true, UserDepartment = null, Address = newAddress1 };
            List<string> newAnswers1 = new List<string> { "hello", "world" };
            List<string> newQuestions1 = new List<string> { "Questest", "Qsttest" };
            SecurityQandA newSecurityQandA1 = new SecurityQandA(newQuestions1, newAnswers1);
            bool newUserCreated1 = userModel.CreatUser(newUser1, "udayKum1#", newAddress1, newSecurityQandA1);
            Response.Write(" New user was created: " + newUserCreated1);

            Address newAddress2 = new Address { firstName = "manu", lastName = "kaur", street1 = "625 W, 5th st", city = "Phoenix", state = "AZ", zip = 87223, country = "US", isActive = true };
            User newUser2 = new User { roleId = 3, firstName = "manu", middleName = "C", lastName = "Kaur", username = "manu01", email = "manu@gmail.com", phone = "9876543210", organization = "Infy", siteKeyVal = 13, isActive = true, UserDepartment = null, Address = newAddress2 };
            List<string> newAnswers2 = new List<string> { "myanswer", "youranswer" };
            List<string> newQuestions2 = new List<string> { "Anstest", "Anstest" };
            SecurityQandA newSecurityQandA2 = new SecurityQandA(newQuestions2, newAnswers2);
            bool newUserCreated2 = userModel.CreatUser(newUser2, "udayKum2#", newAddress2, newSecurityQandA2);
            Response.Write(" New user was created: " + newUserCreated2);

            Address newAddress3 = new Address { firstName = "manu", lastName = "kaur", street1 = "625 W, 5th st", city = "Phoenix", state = "AZ", zip = 85281, country = "US", isActive = true };
            User newUser3 = new User { roleId = 3, firstName = "manu", middleName = "C", lastName = "Kaur", username = "merchant1", email = "manu@gmail.com", phone = "9876543210", organization = "Infy", siteKeyVal = 13, isActive = true, UserDepartment = null, Address = newAddress2 };
            List<string> newAnswers3 = new List<string> { "merchantans", "secondans" };
            List<string> newQuestions3 = new List<string> { "anstest", "Anstest" };
            SecurityQandA newSecurityQandA3 = new SecurityQandA(newQuestions3, newAnswers3);
            bool newUserCreated3 = userModel.CreatUser(newUser3, "udayKum3#", newAddress3, newSecurityQandA3);
            Response.Write(" New user was created: " + newUserCreated3);

            AccountType accType1 = new AccountType { title = "Savings Account" };
            AccountType accType2 = new AccountType { title = "Checkings Account" };
            AccountType accType3 = new AccountType { title = "Credit Account" };

        }
    }
}