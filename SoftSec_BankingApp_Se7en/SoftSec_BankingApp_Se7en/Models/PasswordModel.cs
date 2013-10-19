using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class PasswordModel
    {
        public List<SecurityQuestion> GetSecurityQandA(string username)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                    if (users.Count() < 1)
                    {
                        return null;
                    }

                    User user = users.First();
                    List<SecurityQuestion> securityQuestions = user.SecurityQuestions.ToList();

                    if (securityQuestions.Count() > 0)
                    {
                        return securityQuestions;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception exp)
            {
                //Log exception here
                return null;
            }
        }

        public bool ChangePwd(string username, string password)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                    if (users.Count() < 1)
                    {
                        return false;
                    }

                    User updatedUser = users.First();
                    updatedUser.SetHashandSaltForPassword(password);
                    db.Users.Attach(updatedUser);
                    var entry = db.Entry(updatedUser);
                    entry.Property(e => e.hash).IsModified = true;
                    entry.Property(e => e.salt).IsModified = true;
                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception exp)
            {
                //Log exception here
                return false;
            }
        }
    }
    /*
    public class SecurityQandA
    {
        public List<string> questions;
        public List<string> answers;

        ICollection<SecurityQuestion> securityQuestions;

        public SecurityQandA(ICollection<SecurityQuestion> securityQuestions)
        {
            this.securityQuestions = securityQuestions;

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
        
        public SecurityQandA(List<string> questions, List<string> answers)
        {
            List<SecurityQuestion> securityQuest = new List<SecurityQuestion>();

            if (questions.Count() == answers.Count())
            {
                foreach (string answer in answers)
                {
                    SecurityQuestion newQuest = new SecurityQuestion { answer = answer, isActive = true };
                    securityQuest.Add(newQuest);
                }
            }
        }
    }*/
}