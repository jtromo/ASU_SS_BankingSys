using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    
    public class LoginModel
    {
        // Returns: True false if the user information exists
        public bool UserExists(String username, int zip)
        {
            using (var db = new SSBankDBContext())
            {
                //var users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE id = @p0", 1).ToList();
                //List<Question> questions = db.Questions.SqlQuery("SELECT * FROM dbo.Questions WHERE id = @p0", 1).ToList();

                //if (questions.Count() > 0)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}

                List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE id = @p0", 1).ToList();

                if (users.Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                //User user = db.Users.Find(username);
                //Question user = db.Questions.Find(2);
            }
        }

        // Returns:
        // -1 if login fails
        // the row id if login success (UserId)
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