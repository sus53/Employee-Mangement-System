using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee_Management_System.Models;
using Employee_Management_System.Respitory;

namespace Employee_Management_System.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRespitory Func;
        public DepartmentController()
        {
            this.Func = new DepartmentRepository(new DataContext());
        }
        public ActionResult Index()
        {
            return View(Func.GetDepartment());
        }
        public ActionResult DepartmentForm(Department department)
        {
            return View();
        }
        public ActionResult AddEditDepartment(Department department)
        {
            Func.AddEditDepartment(department);
            Func.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteDepartment(int departmentID)
        {
            Func.DeleteDepartment(departmentID);
            Func.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}