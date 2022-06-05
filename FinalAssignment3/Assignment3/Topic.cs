using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; } 
        public string CourseIdName { get; set; }

        //public Course Course { get; set; }
    }
}
