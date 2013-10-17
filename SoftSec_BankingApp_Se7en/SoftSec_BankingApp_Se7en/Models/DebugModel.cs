using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class DebugModel
    {
        public bool InsertSampleUsers()
        {
            UserModel userModel = new UserModel();

            Address newAddress = new Address { firstName = "James", lastName = "Romo", street1 = "Street", city = "City", state = "State", zip = 12345, country = "Country", isActive = true };
            User newUser = new User { roleId = 1, firstName = "James", middleName = "T", lastName = "Romo", username = "jtromo", email = "@gmail.com", salt = "adfa", hash = "adfaf", phone = "adsfadsf", organization = "adfs", siteKeyVal = 3, isActive = true, UserDepartment = null, Address = newAddress };
            List<string> newAnswers = new List<string> { "answer1", "answer2" };
            List<string> newQuestions = new List<string> { "test1", "test2" };
            SecurityQandA newSecurityQandA = new SecurityQandA(newQuestions, newAnswers);
            bool newUserCreated = userModel.creatUser(newUser, newAddress, newSecurityQandA);

            return newUserCreated;
        }

        // Return the count of number of questions
        public int NumberOfSecurityQuestions()
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

        public bool InsertSecurityQuestionsForUser(string username)
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