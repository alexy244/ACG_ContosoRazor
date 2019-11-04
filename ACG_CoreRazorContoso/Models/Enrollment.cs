﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACG_CoreRazorContoso.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grades? Grade { get; set; }

        // relationships
        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
    }

    public enum Grades
    {
        A,
        B,
        C,
        D,
        E,
        F,
    }


}
