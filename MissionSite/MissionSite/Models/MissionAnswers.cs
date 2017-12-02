using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MissionSite.Models
{
    [Table("MissionAnswers")]
    public class MissionAnswers
    {
        [Key]
        public int missionAnswerID { get; set; }

        public string answer { get; set; }

        public string handler { get; set; }

        [ForeignKey("MissionQuestions")]
        public virtual int missionQuestionID { get; set; }
        public virtual MissionQuestions MissionQuestions { get; set; }
    }
}