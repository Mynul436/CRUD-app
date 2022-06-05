using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Student
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Attendance { get; set; }

        public string CourseId { get; set; }

        //public virtual Course Courses { get; set; }
        //public virtual Admin Admin { get; set; }
        

        //public double Cgpa { get; set; }
       // public DateTime DateOfBirth { get; set; }

    }
}
