using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            // This does the same thing as the code below it, but it does it with less lines of code. It accesses that database and pulls all records and displays them from the view model.
            using (NewsletterEntities db = new NewsletterEntities()) // This is our connection string now. It instantiates the NewsletterEntities object that gives us access to the database.
            {
                var signups = db.SignUps.Where(x => x.Removed == null).ToList(); // db.SignUps represents a list of all records in the database. Newsletter.Context.cs has method called Signups which is a Dbset<SignUp> which is a list of records. This only pulls in records that have null value in the removed column.
                //var signups = (from c in db.SignUps where c.Removed == null select c).ToList(); // This is another way to filter records using LINQ (Language Integrated Quiery).
                var signupVms = new List<SignupVm>(); // If the datatype is obvious it doesn't need to be listed twice. Using var instead of List<SignupVM>.
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }
                return View(signupVms);
            }

            //string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber FROM SignUps";
            //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);

            //    connection.Open();

            //    SqlDataReader reader = command.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        var signup = new NewsletterSignUp();
            //        signup.Id = Convert.ToInt32(reader["Id"]);
            //        signup.FirstName = reader["FirstName"].ToString();
            //        signup.LastName = reader["LastName"].ToString();
            //        signup.EmailAddress = reader["EmailAddress"].ToString();
            //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
            //        signups.Add(signup);
            //    }
            //}
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.SignUps.Find(Id); // This finds the record with the Id perameter passed in.
                signup.Removed = DateTime.Now; // This adds the date and time to the removed column when this method is called.
                db.SaveChanges(); // This saves the database.
            }
            return RedirectToAction("Index"); // This redirects the view back to the index view once the using statement is over.
        }
    }
}