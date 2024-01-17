using Employee_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee_Management_System.Respitory
{
    public class DepartmentRepository : IDepartmentRespitory
    {
        DataContext dataContext;
        public DepartmentRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void AddEditDepartment(Department department)
        {
            if (department.departmentID == 0)
            {
                dataContext.Department.Add(department);
            }
            else
            {
                dataContext.Entry(department).State = System.Data.EntityState.Modified;
            }
        }

        public void DeleteDepartment(int departmentID)
        {
            dataContext.Department.Remove(dataContext.Department.Where(x => x.departmentID == departmentID).First());
        }

        public IEnumerable<Department> GetDepartment()
        {
            return (dataContext.Department.ToList());
        }

        public void SaveChanges()
        {
            dataContext.SaveChanges();
        }
    }

}