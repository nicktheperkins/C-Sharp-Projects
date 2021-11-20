using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// CTRL + M + O : Collapses all methods
// CTRL + SHIFT + B : Builds the app

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        // To get the connection string I had to open the SQL Server Object Explorer right click my database, go to properties, look for and copy the Connection String, and paste into the line below.
        //private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost] // This tag should be included above any post method. It's not necessary but it is good practice as post methods carry changes to the database inside of them.
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress)) // If any of the paramethers are null of empty throw an error.
            {
                return View("~/Views/Shared/Error.cshtml"); // The tilda sign (~) means that it is relative path or root. This returns and error page.
            }
            else
            {   // This does that same thing as the code below it but with less lines. It adds new signups to the database.
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new SignUp(); // These lines map all the properties we want for this object to the parameters that came in.
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.SignUps.Add(signup); // This adds the new signup to the SignUps list of records.
                    db.SaveChanges(); // This saves the changes made to the database.
                }

                //string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES (@FirstName, @LastName, @EmailAddress)";

                //using (SqlConnection connection = new SqlConnection(connectionString)) // Connections to databases should be wrapped in a Using statement to help prevent SQL injections.
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);
                //    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                //    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                //    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                //    command.Parameters["@FirstName"].Value = firstName;
                //    command.Parameters["@LastName"].Value = lastName;
                //    command.Parameters["@EmailAddress"].Value = emailAddress;

                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close();
                //}
                    return View("Success");
            }    
        }
    }
}