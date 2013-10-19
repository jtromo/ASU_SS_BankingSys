using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class Question
    {
        public Question()
        {
            //this.SecurityQuestions = new HashSet<SecurityQuestion>();
        }
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string question1 { get; set; }

        //public virtual ICollection<SecurityQuestion> SecurityQuestions { get; set; }
    }
}