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
            List<SecurityQuestion> securityQuestions = password.GetSecurityQandA("jtromo");
            if (securityQuestions != null)
            {
                foreach (SecurityQuestion question in securityQuestions)
                {
                    Response.Write(" QuestionId: " + question.questionId + " Answer: " + question.answer);
                }
            }
            else
                Response.Write(" Null. Please fix");

            AccountModel accountModel = new AccountModel();
            ICollection<SoftSec_BankingApp_Se7en.Models.Tables.Account> accounts = accountModel.GetAccountsForUser("jtromo");
            if(accounts != null)
                Response.Write(" Number of accounts for jtromo: " + accounts.Count());
            else
                Response.Write(" Null. Please fix");

            ICollection<Transaction> transaction = accountModel.GetTransactionsForAccount("12334123");
            if(transaction !=null)
                Response.Write(" Number of transactions for account 12334123: " + transaction.Count());
            else
                Response.Write(" Null. Please fix");

            LastNameZipcode lastNameZip = accountModel.GetLastNameAndZipcode("12334123");
            if(lastNameZip != null)
                Response.Write(" Last name and zip for account 12334123: " + lastNameZip.lastName + " " + lastNameZip.zipcode);
            else
                Response.Write(" Null. Please fix");

            bool testTransferInternal = accountModel.MakeInternalTransfer("12345", "12334123", 0.11, "test internal transfer");
            Response.Write(" Creating test transfer Internal between 12345 and 12334123: " + testTransferInternal);

            bool testTransferExternal = accountModel.MakeExternalTransfer("12345", "12334123", "1231231", 0.11, "test transfer");
            Response.Write(" Creating test transfer External between 12345 and 12334123: " + testTransferExternal);

            Account foundAccount = accountModel.GetAccount("12334123");
            if(foundAccount != null)
                Response.Write(" Retrieving account: 12334123 " + " Account balance: " + foundAccount.balance);
            else
                Response.Write(" Null. Please fix");

            UserModel userModel = new UserModel();
            User user = userModel.GetUser("jtromo");
            if(user !=null)
                Response.Write(" Retrieving user jtromo: " + user.username);
            else
                Response.Write(" Null. Please fix");

            Card card = accountModel.GetCardDetails(Convert.ToString(98999999));
            if(card != null)
                Response.Write(" Retrieving card for 98999999: " + card.firstName + " " + card.lastName + " CVV " + card.cvv + " experation: " + card.expirationDate);
            else
                Response.Write(" Null. Please fix");

            Address newAddress = new Address { firstName = "John", lastName = "Smith", street1 = "Street", city = "City", state = "State", zip = 12345, country = "Country", isActive = true };
            User newUser = new User { roleId = 1, firstName = "John", middleName = "T", lastName = "Smith", username = "john", email = "johnn@gmail.com", phone = "adsfadsf", organization = "adfs", siteKeyVal = 3, siteKeyString = "describe3", isActive = true, departmentId = null, Address = newAddress, dateOfBirth = "07/08/1994", socialSecurityNumber = "412-31-9999" };
            SecurityQuestion question1 = new SecurityQuestion { answer = "Speedy", questionId = 1 };
            SecurityQuestion question2 = new SecurityQuestion { answer = "John", questionId = 2 };
            SecurityQuestion question3 = new SecurityQuestion { answer = "School", questionId = 3 };
            List<SecurityQuestion> newQuestions = new List<SecurityQuestion> { question1, question2, question3 };
            Card newCard = new Card { cardNumber = "12345678910", cvv=1234, expirationDate="09/15", firstName="John", middleInitial="T", lastName="Smith" };
            bool newUserCreated = userModel.CreateUser(newUser, "password", "12345678910", "10987654321", "123456", newCard, newAddress, newQuestions);
            Response.Write(" New user was created: " + newUserCreated);

            //Sample Script
            Address newAddress1 = new Address { firstName = "uday", lastName = "mac", street1 = "Street 123", city = "Tempe", state = "AZ", zip = 85281, country = "US", isActive = true };
            User newUser1 = new User { roleId = 1, firstName = "uday", middleName = "K", lastName = "Mac", username = "umac18", email = "uday@gmail.com", phone = "1234567890", organization = "ASU", siteKeyVal = 5, siteKeyString = "describe5", isActive = true, departmentId = null, Address = newAddress1, dateOfBirth = "05/03/1993", socialSecurityNumber = "634-31-9999" };
            SecurityQuestion newQuestion11 = new SecurityQuestion { answer = "Speedy1", questionId = 1 };
            SecurityQuestion newQuestion21 = new SecurityQuestion { answer = "John1", questionId = 2 };
            SecurityQuestion newQuestion31 = new SecurityQuestion { answer = "School1", questionId = 3 };
            List<SecurityQuestion> newQuestions1 = new List<SecurityQuestion> { newQuestion11, newQuestion21, newQuestion31 };
            Card newCard1 = new Card { cardNumber = "12345678910", cvv = 1234, expirationDate = "09/15", firstName = "uday", middleInitial = "k", lastName = "mac" };
            bool newUserCreated1 = userModel.CreateUser(newUser1, "udayKum1", "12345678910", "10987654321", "123456", newCard1, newAddress1, newQuestions1);
            Response.Write(" New user was created: " + newUserCreated1);

            Address newAddress2 = new Address { firstName = "manu", lastName = "kaur", street1 = "625 W, 5th st", city = "Phoenix", state = "AZ", zip = 87223, country = "US", isActive = true };
            User newUser2 = new User { roleId = 3, firstName = "manu", middleName = "C", lastName = "Kaur", username = "manu01", email = "manu@gmail.com", phone = "9876543210", organization = "Infy", siteKeyVal = 13, siteKeyString = "describe13", isActive = true, departmentId = null, Address = newAddress2, dateOfBirth = "02/08/1991", socialSecurityNumber = "243-31-9999" };
            SecurityQuestion newQuestion12 = new SecurityQuestion { answer = "Speedy1", questionId = 1 };
            SecurityQuestion newQuestion22 = new SecurityQuestion { answer = "John1", questionId = 2 };
            SecurityQuestion newQuestion32 = new SecurityQuestion { answer = "School1", questionId = 3 };
            List<SecurityQuestion> newQuestions2 = new List<SecurityQuestion> { newQuestion12, newQuestion22, newQuestion32 };
            Card newCard2 = new Card { cardNumber = "12345678910", cvv = 1234, expirationDate = "09/15", firstName = "udayKum2", middleInitial = "k", lastName = "mac" };
            bool newUserCreated2 = userModel.CreateUser(newUser2, "udayKum2", "12345678910", "10987654321", "123456", newCard1, newAddress2, newQuestions2);
            Response.Write(" New user was created: " + newUserCreated2);

            Address newAddress3 = new Address { firstName = "manu", lastName = "kaur", street1 = "625 W, 5th st", city = "Phoenix", state = "AZ", zip = 85281, country = "US", isActive = true };
            User newUser3 = new User { roleId = 3, firstName = "manu", middleName = "C", lastName = "Kaur", username = "merchant1", email = "manu@gmail.com", phone = "9876543210", organization = "Infy", siteKeyVal = 13, siteKeyString = "describe13", isActive = true, departmentId = null, Address = newAddress3, dateOfBirth = "01/08/1991", socialSecurityNumber = "342-31-9999" };
            SecurityQuestion newQuestion13 = new SecurityQuestion { answer = "Speedy1", questionId = 1 };
            SecurityQuestion newQuestion23 = new SecurityQuestion { answer = "John1", questionId = 2 };
            SecurityQuestion newQuestion33 = new SecurityQuestion { answer = "School1", questionId = 3 };
            List<SecurityQuestion> newQuestions3 = new List<SecurityQuestion> { newQuestion13, newQuestion23, newQuestion33 };
            Card newCard3 = new Card { cardNumber = "12345678910", cvv = 1234, expirationDate = "09/15", firstName = "udayKum3#", middleInitial = "k", lastName = "mac" };
            bool newUserCreated3 = userModel.CreateUser(newUser3, "udayKum3#", "12345678910", "10987654321", "123456", newCard1, newAddress3, newQuestions3);
            Response.Write(" New user was created: " + newUserCreated3);


            Address newAddress4 = new Address { firstName = "manu", lastName = "kaur", street1 = "625 W, 5th st", city = "Phoenix", state = "AZ", zip = 85281, country = "US", isActive = true };
            User newEmployee = new User { roleId = 4, firstName = "Emplyee", middleName = "The", lastName = "Man", username = "employee1", email = "employee@gmail.com", phone = "9876543210", organization = "employee", siteKeyVal = 13, siteKeyString="describe13", isActive = true, departmentId = 2, Address = newAddress2, dateOfBirth = "05/08/1991", socialSecurityNumber = "555-31-9999" };
            SecurityQuestion newQuestion14 = new SecurityQuestion { answer = "Speedy1", questionId = 1 };
            SecurityQuestion newQuestion24 = new SecurityQuestion { answer = "John1", questionId = 2 };
            SecurityQuestion newQuestion34 = new SecurityQuestion { answer = "School1", questionId = 3 };
            List<SecurityQuestion> newQuestions4 = new List<SecurityQuestion> { newQuestion14, newQuestion24, newQuestion34 };

            bool newEmployeeCreated1 = userModel.CreateEmployee(newEmployee, "udayKum3#", newAddress4, newQuestions4);
            Response.Write(" New employee was created: " + newEmployeeCreated1);
            

            CardModel cardModel = new CardModel();
            User cardUser = cardModel.UserForCard("98999999");
            if(cardUser != null)
                Response.Write(" Card found for user: " + cardUser.username + " Card: 98999999");
            else
                Response.Write(" Null. Please fix");

        }
    }
}