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
        // GET: Mission
        public ActionResult Mission()
        {
            return View();
        }

        //This line changes the SiteMapTitle to the missionName to be used with the breadcrumb
        [SiteMapTitle("missionName")]
        public ActionResult MissionFAQ(string missionName, int questionID = 0)
        {
            Models.Missions missions = new Models.Missions();

            ViewBag.question1 = "What were some of your favorite foods?";
            ViewBag.question2 = "What do you like about the people?";
            ViewBag.question3 = "What were your favorite areas?";
            ViewBag.question4 = "What items should you pack?";
            ViewBag.question5 = "What was your favorite experience?";
            ViewBag.questionID = questionID;

            if (missionName == "Japan Sendai")
            {
                missions.missionName = missionName;
                missions.MissionPresident = "Osamu Sekiguchi";
                missions.MissionAddress = "3-1-5 Yagiyama Minami Taihaiku-ku Sendai - Shi Miyagi - Ken Japan 982 - 0807";
                missions.Language = "Japanese";
                missions.Climate = "Humid subtropical";
                missions.Religion = "Buddism";
                missions.Flag = "../../Content/images/japan.jpg";
                missions.Answer1 = "Ramen!! It is so good!";
                missions.Answer2 = "They are very humble and polite. For the most part they all want to do good.";
                missions.Answer3 = "I loved Misawa, Aomori, Yokote, and Akita. They presented different challenges, but there were so many great relationships made there.";
                missions.Answer4 = "Make sure to bring a nice rain coat along with a winter coat and boots";
                missions.Answer5 = "My favorite experience was when I was able to teach a young family in Yokote who eventually was baptized. I loved seeing how the gospel made such a big impact in their lives.";
                ViewBag.handler = "@anderson";
            }
            else if (missionName == "Mexico City West")
            {
                missions.missionName = missionName;
                missions.MissionPresident = "Carl Duane Grossen";
                missions.MissionAddress = "Av. Fuente de las Pirámides No.1, Piso 1 Lomas de Tecamachalco 53950 Naucalpan, Estado de Mexico Mexico";
                missions.Language = "Spanish";
                missions.Climate = "Cold and rainy";
                missions.Religion = "Catholicism";
                missions.Flag = "../../Content/images/mexico.jpg";
                missions.Answer1 = "Some of my favorite foods included Tacos Al' Pastor, Pazole, and Torta de Tamale.";
                missions.Answer2 = "They are very giving, humble, and loving.";
                missions.Answer3 = "My favorite ares were Tejupilco, Zitacuaro, and Santiago Tianguistanco.";
                missions.Answer4 = "You shold definitely pack a large warm coat, rain jacket, umbrella, and good shoes.";
                missions.Answer5 = "My favorite experiences were being able to see how the gosple changed lives. I was able to see how many families grew closer as they worked to come closer to the Lord.";
                ViewBag.handler = "@brylezzz";
            }
            else if (missionName == "Adriatic North")
            {
                missions.missionName = missionName;
                missions.MissionPresident = "David M. Melonakos";
                missions.MissionAddress = "Svacicev Trg 3/1 10000 Zagreb, Croatia";
                missions.Language = "Serbo-Croatian";
                missions.Climate = "cool, rainy winters and hot, dry summers";
                missions.Religion = "Eastern Orthodoxy, Catholicism and Islam";
                missions.Flag = "../../Content/images/serbia.jpg";
                missions.Answer1 = "Giros, burek or sarma! I can't decide";
                missions.Answer2 = "They are very hospitable and always have food or drink when you visit someones house";
                missions.Answer3 = "Podgorica in Montenegro was my all around favoirite place, but I loved Novi Sad in Serbia and Zagreb in Croatia as well!";
                missions.Answer4 = "Shoes you can take anywher! There are so many places to visit and see!";
                missions.Answer5 = "I loved meeting new people everyday! Every baptism I attended were such special occasions. I also loved being a part of the celebration of Kresimir Cosic!";
                ViewBag.handler = "@haris";
            }
            return View(missions);
        }
    }
}