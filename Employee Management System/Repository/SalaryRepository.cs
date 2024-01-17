using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Employee_Management_System.Models;

namespace Employee_Management_System.Respitory
{
    public class SalaryRespitory:ISalaryRespitory
    {
        DataContext dataContext;
        public SalaryRespitory(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<Salary> GetSalary()
        {
            return (dataContext.Salary.ToList());
        }
        public void AddEditSalary(Salary salary)
        {
            if (salary.salaryID == 0)
            {
                dataContext.Salary.Add(salary);
            }
            else
            {
                dataContext.Entry(salary).State = System.Data.EntityState.Modified;
            }
        }
        public void DeleteSalary(int salaryID)
        {
            dataContext.Salary.Remove(dataContext.Salary.Where(x => x.salaryID == salaryID).First());
        }
        public void SaveChanges()
        {
            dataContext.SaveChanges();
        }
    }
}