using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee_Management_System.Respitory;
using Employee_Management_System.Models;
using Employee_Management_System.CommonUtilities;
namespace Employee_Management_System.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRespitory Func;
        public EmployeeController()
        {
            this.Func = new EmployeeRespitory(new DataContext());
        }
        public ActionResult Index()
        {
            return View(Func.GetEmployee());
        }
        
        public ActionResult EmployeeForm(Employee employee)
        {
            ViewBag.DepartmentList = Utilities.GetDepartment();
            ViewBag.DesignationList = Utilities.GetDesignation();
            return View(employee);
        }

        public ActionResult AddEditEmployee(Employee employee)
        {
            Func.AddEditEmployee(employee);
            Func.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteEmployee(int employeeID)
        {
            Func.DeleteEmployee(employeeID);
            Func.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}