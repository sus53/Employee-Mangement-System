using Employee_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee_Management_System.Respitory
{
    public class EmployeeRespitory : IEmployeeRespitory
    {
        DataContext dataContext;

        public EmployeeRespitory(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public void AddEditEmployee(Employee employee)
        {
            if (employee.employeeID == 0)
            {
                dataContext.Employee.Add(employee);
            }
            else
            {
                dataContext.Entry(employee).State = System.Data.EntityState.Modified;
            }
        }

        public void DeleteEmployee(int employeeID)
        {
            dataContext.Employee.Remove(dataContext.Employee.Where(x => x.employeeID == employeeID).First());
        }

        public IEnumerable<Employee> GetEmployee()
        {
            return dataContext.Employee.ToList();
        }

        public void SaveChanges()
        {
            dataContext.SaveChanges();
        }
    }

}