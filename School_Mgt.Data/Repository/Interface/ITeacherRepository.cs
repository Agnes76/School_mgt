using School_Mgt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Mgt.Repository.Interface
{
    public interface ITeacherRepository
    {
        IList<Teacher> GetAllTeachers();
        Teacher GetTeacherById(int? id);
        void Create(Teacher teach);
        void Update(Teacher teach);
        void Delete(Teacher teach);
    }
}
