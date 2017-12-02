using MissionSite.DAL;
using MissionSite.Models;
using MvcSiteMapProvider.Web.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace MissionSite.Controllers
{
    public class MissionController : Controller
    {
        private MissionContext MissionContext = new MissionContext();

        // GET: Mission
        public ActionResult Mission()
        {
            return View();
        }

        //This line changes the SiteMapTitle to the missionName to be used with the breadcrumb
        [SiteMapTitle("missionName")]
        [Authorize]
        public ActionResult MissionFAQ(int missionKey, int questionID = 0)
        {
            Missions mission = new Missions();
            mission = MissionContext.Missions.Find(missionKey);
            IEnumerable<MissionQuestions> missionQuestions = MissionContext.Database.SqlQuery<MissionQuestions>("SELECT * FROM MissionQuestions WHERE missionID = " + missionKey);
            IEnumerable<MissionAnswers> missionAnswers = MissionContext.Database.SqlQuery<MissionAnswers>("SELECT * FROM MissionAnswers WHERE missionQuestionID = " + questionID);
            ResponseHierarchy hierarchy = new ResponseHierarchy();
            hierarchy.mission = mission;
            hierarchy.missionQuestions = missionQuestions.ToList();
            hierarchy.missionAnswers = missionAnswers.ToList();
            hierarchy.missionQuestionID = questionID;
            return View(hierarchy);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MissionFAQ(FormCollection form, int missionKey)
        {
            String formType = form["formType"].ToString();
            if (formType == "Question")
            {
                String question = form["NewQuestion"].ToString();
                MissionQuestions newQuestion = new MissionQuestions();
                newQuestion.missionQuestion = question;
                newQuestion.userID = User.Identity.GetUserName();
                newQuestion.missionID = missionKey;
                if (ModelState.IsValid)
                {
                    MissionContext.MissionQuestions.Add(newQuestion);
                    MissionContext.SaveChanges();
                    return RedirectToAction("MissionFAQ", "Mission", new { missionKey = newQuestion.missionID, questionID = newQuestion.missionQuestionID });
                }

            }
            else
            {
                int missionQuestionID = Convert.ToInt32(form["missionQuestionID"]);
                MissionAnswers newAnswer = new MissionAnswers();
                newAnswer.answer = form["NewComment"].ToString();
                newAnswer.missionQuestionID = missionQuestionID;
                IEnumerable<string> handler = MissionContext.Database.SqlQuery<String>("SELECT Handler FROM AspNetUsers WHERE UserName = @p0", User.Identity.GetUserName());
                newAnswer.handler = "@" + handler.ToList()[0]; //there will only be one
               if (ModelState.IsValid)
                {
                    MissionContext.MissionAnswers.Add(newAnswer);
                    MissionContext.SaveChanges();
                    return RedirectToAction("MissionFAQ", "Mission", new { missionKey = missionKey, questionID = missionQuestionID });
                }
            }
            return RedirectToAction("MissionFAQ", "Mission", new { missionKey = missionKey });
        }
    }
}
