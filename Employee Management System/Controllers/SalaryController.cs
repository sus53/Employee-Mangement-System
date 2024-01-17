using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee_Management_System.Models;
using Employee_Management_System.Respitory;
using Employee_Management_System.CommonUtilities;

namespace Employee_Management_System.Controllers
{
    public class SalaryController : Controller
    {
        private readonly ISalaryRespitory Func;
        public SalaryController()
        {
            this.Func = new SalaryRespitory(new DataContext());
        }
        public ActionResult Index()
        {
            return View(Func.GetSalary());
        }
        public ActionResult AddEditSalary(Salary salary)
        {
            Func.AddEditSalary(salary);
            Func.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSalary(int salaryID)
        {
            Func.DeleteSalary(salaryID);
            Func.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SalaryForm(Salary salary)
        {
            ViewBag.EmployeeList = Utilities.GetEmployee();
            ViewBag.DepartmentList = Utilities.GetDepartment();
            return View(salary);
        }
    }
}