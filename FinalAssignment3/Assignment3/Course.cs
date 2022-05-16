using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }  
        public string CourseName { get; set; }
        public string Fees { get; set; }    
        public DateTime ClassStartDate { get; set; }  
        public int TotalNumberOfClass { get; set; }
        public int CourseTeacherId { get; set; }
        
        //public virtual ICollection<Student> Students { get; set; }
        //public virtual Admin Admin { get; set; }
        

    }
}
