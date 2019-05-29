using LoginSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginSystem.Controllers
{
    public class HomeController : Controller
    {
        public List<User> Users = new List<User>();

        //The first overload is for rendering the view

        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
            //this displays our view
        }
        
        [HttpPost]
        public ActionResult Login(User u)
        {
            foreach (User us in Users)
            {
                //if they match, store the user in a session
                if (u.UserName == us.Username && u.Password == us.Password)
                {
                    Session["CurrentUser"] = us;
                    return RedirectToAction("Index");
                }
               
            }
            return ViewBag();
        }

        
       //This is for processing the form submission
        [HttpPost]
        public ActionResult Registration(User u)
        {
            Users.Add(u);
            //Session["User"] = u;       not as secure
            return RedirectToAction("Login");
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       // public ActionResult Registration
    }
}