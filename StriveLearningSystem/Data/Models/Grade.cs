﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Grade
    {
        [Key]
        public int GradeID { get; set; }
        public int AssignmentID { get; set; }
        public int UserID { get; set; }
        public int Score { get; set; }        
        public DateTime DateTurnedIn { get; set; }
        public DateTime DateGraded { get; set; }
        public Boolean IsGraded { get; set;}
    }
}
