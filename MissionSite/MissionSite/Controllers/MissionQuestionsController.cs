using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MissionSite.DAL;
using MissionSite.Models;
using Microsoft.AspNet.Identity;

namespace MissionSite.Controllers
{
    public class MissionQuestionsController : Controller
    {
        private MissionContext db = new MissionContext();

        // GET: MissionQuestions/Create
        [Authorize]
        public ActionResult Create()
        {
            //ViewBag.userID = new SelectList(db.MissionQuestions, "userID", "Email");
            ViewBag.userID = User.Identity.GetUserName();
            ViewBag.missionID = new SelectList(db.Missions, "missionID", "missionName");
            return View();
        }

        // POST: MissionQuestions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "missionQuestionID,missionQuestion,userID,missionID")] MissionQuestions missionQuestions)
        {
            if (ModelState.IsValid)
            {
                db.MissionQuestions.Add(missionQuestions);
                db.SaveChanges();
                return RedirectToAction("Index", "Home", null);
            }

            ViewBag.userID = User.Identity.GetUserName();
            ViewBag.missionID = new SelectList(db.Missions, "missionID", "missionName", missionQuestions.missionID);
            return View(missionQuestions);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
