using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
{
    public class HomeController : Controller
    {
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
            List<SelectListItem> subject = new List<SelectListItem>();
            subject.Add(new SelectListItem { Text = "", Value = "0", Selected = true });
            subject.Add(new SelectListItem { Text = "Question", Value = "1" });
            subject.Add(new SelectListItem { Text = "Comment", Value = "2"});
            subject.Add(new SelectListItem { Text = "Feedback", Value = "3"});
            ViewBag.Subject = subject;

            return View();
        }

        public ViewResult CategoryChosen(string Subject)
        {
            if (Subject.Equals("0"))
                ViewBag.messageString = "";
            else if (Subject.Equals("1"))
                ViewBag.messageString = "Question";
            else if (Subject.Equals("2"))
                ViewBag.messageString = "Comment";
            else if (Subject.Equals("3"))
                ViewBag.messageString = "Feedback";

            return View("CategoryChosen");
        }
    }
}