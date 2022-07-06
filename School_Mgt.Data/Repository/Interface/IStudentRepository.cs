using School_Mgt.Models;
using School_Mgt.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Mgt.Repository.Interface
{
    public interface IStudentRepository
    {
        IList<Student> GetAllStudents();
        Student GetStudentById(int? id);
        void Create(Student stu);
        void Update(Student stu);
        void Delete(Student stu);
    }
}
