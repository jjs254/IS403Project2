using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MissionSite.Models
{
    public class ResponseHierarchy
    {
        public Missions mission;
        public List<MissionQuestions> missionQuestions;
        public List<MissionAnswers> missionAnswers;
        public int missionQuestionID;
    }
}