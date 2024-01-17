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
    public class LeaveController : Controller
    {
        private readonly ILeaveRespitory Func;
        public LeaveController()
        {
            this.Func = new LeaveRespitory(new DataContext());
        }
        public ActionResult Index()
        {
            return View(Func.GetLeave());
        }
        public ActionResult LeaveForm(Leave leave)
        {
            ViewBag.DepartmentList = Utilities.GetDepartment();
            ViewBag.EmployeeList = Utilities.GetEmployee();
            return View(leave);
        }
        public ActionResult AddEditLeave(Leave leave)
        {
            Func.AddEditLeave(leave);
            Func.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteLeave(int leaveID) 
        {
            Func.DeleteLeave(leaveID);
            Func.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}