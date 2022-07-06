using School_Mgt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Mgt.Repository.Interface
{
    public interface IDepartmentRepository
    {
        IList<Department> GetAllDepts();
        Department GetDeptById(int? id);
        void Create(Department dept);
        void Update(Department dept);
        void Delete(Department dept);
    }
}
