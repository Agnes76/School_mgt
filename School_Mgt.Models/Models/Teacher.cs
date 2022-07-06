using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Mgt.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string JobTitle { get; set; }
        public int ReportTo { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Department> Departments{ get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
