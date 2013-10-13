using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    // Returns:
    // -1 if login fails
    // the row id if login success (UserId)
    public class LoginModel
    {
        public int LoginUser(String username, String password, int zip)
        {
            // James Test DB Actions
            using (var db = new SSBankDBContext())
            {
                var question = new Question { question1 = "What is your mother's maiden name?" };
                db.Questions.Add(question);
                db.SaveChanges();

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
    }
}