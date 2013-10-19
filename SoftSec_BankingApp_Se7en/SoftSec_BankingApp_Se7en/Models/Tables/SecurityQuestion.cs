using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class SecurityQuestion
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int questionId { get; set; }
        public string answer { get; set; }
        private Question _question;
        [NotMapped]
        public virtual Question Question
        {
            get
            {
                using (var db = new SSBankDBContext())
                {
                    ICollection<Question> questions = db.Questions.SqlQuery("SELECT * FROM dbo.Questions WHERE id = @p0", userId).ToList();
                    if (questions.Count() < 1)
                    {
                        return null;

                    }
                    return questions.First();
                }
            }
            set
            {
                _question = value;
            }
        }
        public virtual User User { get; set; }
    }
}