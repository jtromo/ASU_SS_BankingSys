using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class PasswordModel
    {
        public SecurityQandA GetSecurityQandA(string username)
        {
            using (var db = new SSBankDBContext())
            {
                List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                if (users.Count() < 1)
                {
                    return null;
                }

                User user = users.First();
                ICollection<SecurityQuestion> securityQuestions = user.SecurityQuestions;

                if (securityQuestions.Count() > 0)
                {
                    return new SecurityQandA(securityQuestions);
                }
                else
                {
                    return null;
                }
            }
        }

        public bool ChangePwd(string username, string password)
        {
            using (var db = new SSBankDBContext())
            {
                List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                if (users.Count() < 1)
                {
                    return false;
                }

                User updatedUser = users.First();
                // JR: warning! need to change this to hash
                updatedUser.hash = password;

                db.Users.Attach(updatedUser);
                var entry = db.Entry(updatedUser);
                entry.Property(e => e.hash).IsModified = true;
                db.SaveChanges();

                return true;
            }
        }
    }
    public class SecurityQandA
    {
        public List<string> questions;
        public List<string> answers;

        public SecurityQandA(ICollection<SecurityQuestion> securityQuestions)
        {
            questions = new List<string>();
            answers = new List<string>();

            foreach (SecurityQuestion securityQuestion in securityQuestions)
            {
                Question question = securityQuestion.Question;
                string question1 = question.question1;
                questions.Add(question1);

                answers.Add(securityQuestion.answer);
            }
        }
    }
}