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
            Response.Write("Does the user exist?: ");
            Response.Write(LoginModel.UserExists("jtromo", 12345));

            Response.Write(" Returned id: ");
            Response.Write(LoginModel.LoginUser("jtromo", "newPasword"));

            Response.Write(" New user created: " + DebugModel.InsertSampleUsers());

            Response.Write(" Number of sample questions: ");
            Response.Write(DebugModel.NumberOfSecurityQuestions());

            Response.Write(" Password change: ");
            Response.Write(PasswordModel.ChangePwd("jtromo", "newPasword"));

            Response.Write(" Security qa for user: ");
            List<SecurityQuestion> securityQuestions = PasswordModel.GetSecurityQandA("jtromo");
            if (securityQuestions != null)
            {
                foreach (SecurityQuestion question in securityQuestions)
                {
                    Response.Write(" QuestionId: " + question.questionId + " Answer: " + question.answer);
                }
            }
            else
                Response.Write(" Null. Please fix");

            ICollection<SoftSec_BankingApp_Se7en.Models.Tables.Account> accounts = AccountModel.GetAccountsForUser("jtromo");
            if(accounts != null)
                Response.Write(" Number of accounts for jtromo: " + accounts.Count());
            else
                Response.Write(" Null. Please fix");

            List<Transaction> transaction = TransactionModel.GetTransactionsForAccount("12334123");
            if(transaction !=null)
                Response.Write(" Number of transactions for account 12334123: " + transaction.Count());
            else
                Response.Write(" Null. Please fix");

            LastNameZipcode lastNameZip = AccountModel.GetLastNameAndZipcode("12334123");
            if(lastNameZip != null)
                Response.Write(" Last name and zip for account 12334123: " + lastNameZip.lastName + " " + lastNameZip.zipcode);
            else
                Response.Write(" Null. Please fix");

            int testTransferInternal = TransactionModel.MakeInternalTransfer("12345", "12334123", 0.11, "test internal transfer");
            Response.Write(" Creating test transfer Internal between 12345 and 12334123: rowId " + testTransferInternal);

            int testTransferExternal = TransactionModel.MakeExternalTransfer("12345", "fromRoute", "12334123", "1231231", 0.11, "test transfer");
            Response.Write(" Creating test transfer External between 12345 and 12334123: rowId " + testTransferExternal);

            Account foundAccount = AccountModel.GetAccount("12334123");
            if(foundAccount != null)
                Response.Write(" Retrieving account: 12334123 " + " Account balance: " + foundAccount.balance);
            else
                Response.Write(" Null. Please fix");

            User user = UserModel.GetUser("jtromo");
            if(user !=null)
                Response.Write(" Retrieving user jtromo: " + user.username);
            else
                Response.Write(" Null. Please fix");

            Card card = AccountModel.GetCardDetails(Convert.ToString(98999999));
            if(card != null)
                Response.Write(" Retrieving card for 98999999: " + card.firstName + " " + card.lastName + " CVV " + card.cvv + " experation: " + card.expirationDate);
            else
                Response.Write(" Null. Please fix");

            Address newAddress = new Address { firstName = "John", lastName = "Smith", street1 = "Street", city = "City", state = "State", zip = 12345, country = "Country", isActive = true };
            User newUser = new User { roleId = 1, firstName = "John", middleName = "T", lastName = "Smith", username = "john", email = "johnn@gmail.com", phone = "adsfadsf", organization = "adfs", siteKeyVal = 3, siteKeyString = "describe3", isActive = true, departmentId = null, Address = newAddress };
            SecurityQuestion question1 = new SecurityQuestion { answer = "Speedy", questionId = 1 };
            SecurityQuestion question2 = new SecurityQuestion { answer = "John", questionId = 2 };
            SecurityQuestion question3 = new SecurityQuestion { answer = "School", questionId = 3 };
            List<SecurityQuestion> newQuestions = new List<SecurityQuestion> { question1, question2, question3 };
            Card newCard = new Card { cardNumber = "12345678910", cvv=1234, expirationDate="09/15", firstName="John", middleInitial="T", lastName="Smith" };
            bool newUserCreated = UserModel.CreateUser(newUser, "password", "412-31-9999", "07/08/1994", "12345678910", "10987654321", "123456", newCard,newCard, newAddress, newQuestions);
            Response.Write(" New user was created: " + newUserCreated);

            //Sample Script
            Address newAddress1 = new Address { firstName = "uday", lastName = "mac", street1 = "Street 123", city = "Tempe", state = "AZ", zip = 85281, country = "US", isActive = true };
            User newUser1 = new User { roleId = 1, firstName = "uday", middleName = "K", lastName = "Mac", username = "umac18", email = "uday@gmail.com", phone = "1234567890", organization = "ASU", siteKeyVal = 5, siteKeyString = "describe5", isActive = true, departmentId = null, Address = newAddress1 };
            SecurityQuestion newQuestion11 = new SecurityQuestion { answer = "Speedy1", questionId = 1 };
            SecurityQuestion newQuestion21 = new SecurityQuestion { answer = "John1", questionId = 2 };
            SecurityQuestion newQuestion31 = new SecurityQuestion { answer = "School1", questionId = 3 };
            List<SecurityQuestion> newQuestions1 = new List<SecurityQuestion> { newQuestion11, newQuestion21, newQuestion31 };
            Card newCard1 = new Card { cardNumber = "12345678910", cvv = 1234, expirationDate = "09/15", firstName = "uday", middleInitial = "k", lastName = "mac" };
            bool newUserCreated1 = UserModel.CreateUser(newUser1, "udayKum1", "634-31-9999", "05/03/1993", "12345678910", "10987654321", "123456", newCard1,newCard, newAddress1, newQuestions1);
            Response.Write(" New user was created: " + newUserCreated1);

            Address newAddress2 = new Address { firstName = "manu", lastName = "kaur", street1 = "625 W, 5th st", city = "Phoenix", state = "AZ", zip = 87223, country = "US", isActive = true };
            User newUser2 = new User { roleId = 3, firstName = "manu", middleName = "C", lastName = "Kaur", username = "manu01", email = "manu@gmail.com", phone = "9876543210", organization = "Infy", siteKeyVal = 13, siteKeyString = "describe13", isActive = true, departmentId = null, Address = newAddress2 };
            SecurityQuestion newQuestion12 = new SecurityQuestion { answer = "Speedy1", questionId = 1 };
            SecurityQuestion newQuestion22 = new SecurityQuestion { answer = "John1", questionId = 2 };
            SecurityQuestion newQuestion32 = new SecurityQuestion { answer = "School1", questionId = 3 };
            List<SecurityQuestion> newQuestions2 = new List<SecurityQuestion> { newQuestion12, newQuestion22, newQuestion32 };
            Card newCard2 = new Card { cardNumber = "12345678910", cvv = 1234, expirationDate = "09/15", firstName = "udayKum2", middleInitial = "k", lastName = "mac" };
            bool newUserCreated2 = UserModel.CreateUser(newUser2, "udayKum2", "243-31-9999", "02/08/1991", "12345678910", "10987654321", "123456", newCard1,newCard2, newAddress2, newQuestions2);
            Response.Write(" New user was created: " + newUserCreated2);

            Address newAddress3 = new Address { firstName = "manu", lastName = "kaur", street1 = "625 W, 5th st", city = "Phoenix", state = "AZ", zip = 85281, country = "US", isActive = true };
            User newUser3 = new User { roleId = 3, firstName = "manu", middleName = "C", lastName = "Kaur", username = "merchant1", email = "manu@gmail.com", phone = "9876543210", organization = "Infy", siteKeyVal = 13, siteKeyString = "describe13", isActive = true, departmentId = null, Address = newAddress3 };
            SecurityQuestion newQuestion13 = new SecurityQuestion { answer = "Speedy1", questionId = 1 };
            SecurityQuestion newQuestion23 = new SecurityQuestion { answer = "John1", questionId = 2 };
            SecurityQuestion newQuestion33 = new SecurityQuestion { answer = "School1", questionId = 3 };
            List<SecurityQuestion> newQuestions3 = new List<SecurityQuestion> { newQuestion13, newQuestion23, newQuestion33 };
            Card newCard3 = new Card { cardNumber = "12345678910", cvv = 1234, expirationDate = "09/15", firstName = "udayKum3#", middleInitial = "k", lastName = "mac" };
            bool newUserCreated3 = UserModel.CreateUser(newUser3, "udayKum3#", "342-31-9999", "01/08/1991", "12345678910", "10987654321", "123456", newCard1,newCard3, newAddress3, newQuestions3);
            Response.Write(" New user was created: " + newUserCreated3);

            Address newAddress4 = new Address { firstName = "manu", lastName = "kaur", street1 = "625 W, 5th st", city = "Phoenix", state = "AZ", zip = 85281, country = "US", isActive = true };
            User newEmployee = new User { roleId = 4, firstName = "Emplyee", middleName = "The", lastName = "Man", username = "employee1", email = "employee@gmail.com", phone = "9876543210", organization = "employee", siteKeyVal = 13, siteKeyString="describe13", isActive = true, departmentId = 2, Address = newAddress2 };
            SecurityQuestion newQuestion14 = new SecurityQuestion { answer = "Speedy1", questionId = 1 };
            SecurityQuestion newQuestion24 = new SecurityQuestion { answer = "John1", questionId = 2 };
            SecurityQuestion newQuestion34 = new SecurityQuestion { answer = "School1", questionId = 3 };
            List<SecurityQuestion> newQuestions4 = new List<SecurityQuestion> { newQuestion14, newQuestion24, newQuestion34 };
            bool newEmployeeCreated1 = UserModel.CreateEmployee(newEmployee, "udayKum3#", "555-31-9999", "05/08/1991", newAddress4, newQuestions4);
            Response.Write(" New employee was created: " + newEmployeeCreated1);
            
            User cardUser = CardModel.UserForCard("98999999");
            if(cardUser != null)
                Response.Write(" Card found for user: " + cardUser.username + " Card: 98999999");
            else
                Response.Write(" Null. Please fix");

            bool regularAccessFalse = UserModel.CheckRegularAccess("jtromo", 2);
            Response.Write(" Check access for jtromo, should not have access: " + regularAccessFalse);

            bool regularAccessTrue = UserModel.CheckRegularAccess("employee1", 2);
            Response.Write(" Check access for employee1, should have access: " + regularAccessTrue);

            List<Transaction> userTransactions = TransactionModel.GetTransactionsForUser("jtromo");
            if (userTransactions != null)
                Response.Write(" Number of transactions for jtromo: " + userTransactions.Count());
            else
                Response.Write(" Null. Please fix");

            bool userRemoved = UserModel.RemoveUser("jtromo1");
            if (userRemoved)
                Response.Write(" User jtromo1 successfully removed");
            else
                Response.Write(" User jtromo1 failed to be removed");

            int departmentTransferId = DepartmentTransactionModel.MakeDepartmentTransfer(2, 3, "employee1", "employee1", "Test Department Change", 0, "admin");
            if (departmentTransferId > -1)
                Response.Write(" User employee1 has been requested to be transfered to department 3");
            else
                Response.Write(" Department transfer failed");

            int roleEscalationId = DepartmentTransactionModel.MakeRoleEscalation("employee1", "employee1", 3, 4, "Test Department Change", 0, "admin");
            if (roleEscalationId > -1)
                Response.Write(" Employee1 has been requested to change role from 3 to 4");
            else
                Response.Write(" Role escalation failed");

            List<int> userLists = UserModel.GetUserCount();
            
            if (userLists != null)
            {
                Response.Write(" User List counts:");
                foreach (int list in userLists)
                {
                    Response.Write(" List Count: " + list);
                }
            }
            else
            {
                Response.Write(" User list count failed");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}