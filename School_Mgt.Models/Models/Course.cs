using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Mgt.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseUnit { get; set; }
        public char Grade { get; set; }
        public int Score { get; set; }
        public int GradeUnit { get; set; }
        public double Cumulative { get; set; }
        public ICollection<Department> Departments { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
