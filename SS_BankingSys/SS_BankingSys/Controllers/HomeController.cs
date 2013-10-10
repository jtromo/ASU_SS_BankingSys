using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SS_BankingSys.Controllers
{
    public class HomeController : Controller
    {

        BankingContext _db;

        public HomeController()
        {
            _db = new BankingContext();
        }

        public ActionResult Index()
        {
            ViewData.Model = _db.Questions.ToList();

            return View();

            /*
            using (var db = new BankingContext())
            {
                
                
                var user = new User { firstName = "James", middleName = "Tyler", lastName = "Romo", username = "jamestro", email = "jamestromo@gmail.com", salt = "12345", hash = "asdf", phone = "12334", organization = "asdfasf" };
                db.Users.Add(user);
                db.SaveChanges();

                var query = from b in db.Users 
                            orderby b.firstName 
                            select b;

                String databaseString = "All Users in the database:";
                foreach (var item in query)
                {
                    databaseString = databaseString + item.firstName + ", ";
                }

                ViewBag.Message = databaseString;
                 

                var question = new Question { question1 = "What is your mother's maiden name?" };
                db.Questions.Add(question);
                db.SaveChanges();

                var query = from b in db.Questions
                            orderby b.question1
                            select b;

                String databaseString = "All Questions in the database:";
                foreach (var item in query)
                {
                    databaseString = databaseString + item.question1 + ", ";
                }

                ViewBag.Message = databaseString;
            }
            

            return View();
        */
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
