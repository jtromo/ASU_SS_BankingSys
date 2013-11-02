using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class DebugModel
    {
        public static bool InsertSampleUsers()
        {
            Address newAddress = new Address { firstName = "James", lastName = "Romo", street1 = "Street", city = "City", state = "State", zip = 12345, country = "Country", isActive = true };
            User newUser = new User { roleId = 1, firstName = "James", middleName = "T", lastName = "Romo", username = "jtromo", email = "@gmail.com", phone = "adsfadsf", organization = "adfs", siteKeyVal = 3, siteKeyString = "describe3", isActive = true, departmentId = null, Address = newAddress };
            SecurityQuestion question1 = new SecurityQuestion { answer="Speedy", questionId=1 };
            SecurityQuestion question2 = new SecurityQuestion { answer="John", questionId=2 };
            SecurityQuestion question3 = new SecurityQuestion { answer="School", questionId=3 };
            List<SecurityQuestion> questions = new List<SecurityQuestion> { question1, question2, question3 };
            Card newCard = new Card { cardNumber = "1111111111", cvv = 1234, expirationDate = "09/15", firstName = "James", middleInitial = "T", lastName = "Romo" };
            bool newUserCreated = UserModel.CreateUser(newUser, "password", "730-31-9999", "07/08/1991", "2222222222", "3333333333", "444444", newCard,newCard, newAddress, questions);

            return newUserCreated;
        }

        // Return the count of number of questions
        public static int NumberOfSecurityQuestions()
        {
            using (var db = new SSBankDBContext())
            {
                /*var question = new Question { question1 = "What is your mother's maiden name?" };
                db.Questions.Add(question);
                db.SaveChanges();
                */
                var query = from b in db.Questions
                            orderby b.question1
                            select b;

                String databaseString = "All Questions in the database:";
                int count = 0;
                foreach (var item in query)
                {
                    count++;
                    databaseString = databaseString + item.question1 + ", ";
                }
                // Response.Write(databaseString);
                return count;
            }
        }

        public static bool InsertSecurityQuestionsForUser(string username)
        {
            using (var db = new SSBankDBContext())
            {
                /*var question = new Question { question1 = "What is your mother's maiden name?" };
                db.Questions.Add(question);
                db.SaveChanges();
                */
                var query = from b in db.Questions
                            orderby b.question1
                            select b;

                String databaseString = "All Questions in the database:";
                int count = 0;
                foreach (var item in query)
                {
                    count++;
                    databaseString = databaseString + item.question1 + ", ";
                }
                // Response.Write(databaseString);
                return false;
            }
        }
    }
}