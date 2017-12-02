using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using MissionSite.Models;

namespace MissionSite.Models
{
    [Table("MissionQuestions")]
    public class MissionQuestions
    {
        [Key]
        public int missionQuestionID { get; set; }

        public string missionQuestion { get; set; }

        //public string userID { get; set; }

        [ForeignKey("ApplicationUser")]
        public string userID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("Missions")]
        public virtual int missionID { get; set; }
        public virtual Missions Missions { get; set; }
    }
}