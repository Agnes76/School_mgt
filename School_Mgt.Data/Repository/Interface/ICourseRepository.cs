using School_Mgt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Mgt.Repository.Interface
{
    public interface ICourseRepository
    {
        IList<Course> GetAllCourses();
        Course GetCourseById(int? id);
        void Create(Course course);
        void Update(Course course);
        void Delete(Course course);
    }
}
