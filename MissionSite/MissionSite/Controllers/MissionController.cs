using MissionSite.DAL;
using MissionSite.Models;
using MvcSiteMapProvider.Web.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return View(hierarchy);
        }
    }
}
