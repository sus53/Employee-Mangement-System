using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_System.Models;

namespace Employee_Management_System.Respitory
{
    interface ISalaryRespitory
    {
        IEnumerable<Salary> GetSalary();
        void AddEditSalary(Salary salary);
        void DeleteSalary(int salaryID);
        void SaveChanges();
    }
}
