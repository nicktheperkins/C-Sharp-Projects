using MVCTutorial_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\Nick\Documents\GitHub\C-Sharp-Projects\Basic_C#_Programs\logs\mvclog.txt", text); // Everytime someone goes to Home/Index this will write Hello inside the text file.

            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //if (num > 20000)
            //{
            //    return View("About"); // This sends the action to the about method. This will not change the url it will still look like it is at Home/Index.
            //}

            //return Content("Hello"); // This returns only the content that is written. If nothing is written then it returns nothing.

            //return RedirectToAction("Contact"); // This sends the action down to the contact method. This does change the url to Home/Contact.

            //List<string> names = new List<string>
            //{
            //    "Nick",
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};
            //return View(names);

            User user = new User();
            user.Id = 1;
            user.FirstName = "Nick";
            user.LastName = "Perkins";
            user.Age = 26;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid page"); // This should throw an exception to the page, but it didn't work for me. It might have to do with the "Invalid page" parameter.

            //return View();
        }

        public ActionResult Contact(int id=0) // How to pass the id parameter would be through the url Home/Contact/10.
        {
            ViewBag.Message = id;

            return View();
        }
    }
}