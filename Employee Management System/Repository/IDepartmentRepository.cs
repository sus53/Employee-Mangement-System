using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_System.Models;

namespace Employee_Management_System.Respitory
{
    interface IDepartmentRespitory
    {
        IEnumerable<Department> GetDepartment();
        void AddEditDepartment(Department department);
        void DeleteDepartment(int departmentID);
        void SaveChanges();
    }
}
