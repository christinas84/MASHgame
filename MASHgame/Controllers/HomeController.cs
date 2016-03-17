using MASHgame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MASHgame.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext(); 
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LiveQ1()
        {
            return View(db.Questions.ToList());
        }
        public ActionResult MarryQ2()
        {
            return View();
        }
        public ActionResult WorkQ3()
        {
            return View();
        }
        public ActionResult KidsQ4()
        {
            return View();
        }
        public ActionResult PetQ5()
        {
            return View();
        }
        public ActionResult CarQ6()
        {
            return View();
        }
        public ActionResult Fortune()
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
    }
}