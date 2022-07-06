using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Mgt.Models
{
    public class Department
    {
        public Department()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
            Teachers = new List<Teacher>();
        }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int Size { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }

    }
}
