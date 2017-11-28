using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MissionSite.Models
{
    [Table("Missions")]
    public class Missions
    {
        [Key]
        public int missionID { get; set; }

        public string missionName { get; set; }
        public string missionPresident { get; set; }
        public string missionAddress { get; set; }
        public string language { get; set; }
        public string climate { get; set; }
        public string religion { get; set; }
        public string flagReference { get; set; }
    }
}