using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_System.Models;
namespace Employee_Management_System.Respitory
{
    interface IEmployeeRespitory
    {
        IEnumerable<Employee> GetEmployee();
        void AddEditEmployee(Employee employee);
        void DeleteEmployee(int employeeID);
        void SaveChanges();
    }
}
