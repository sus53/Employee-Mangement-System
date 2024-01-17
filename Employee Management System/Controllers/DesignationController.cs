using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee_Management_System.Models;
using Employee_Management_System.Respitory;

namespace Employee_Management_System.Controllers
{
    public class DesignationController : Controller
    {
        private readonly IDesignationRespitory Func;
        public DesignationController()
        {
            this.Func = new DesignationRepository(new DataContext());
        }
        public ActionResult Index()
        {
            return View(Func.GetDesignation());
        }
        public ActionResult AddEditDesignation(Designation designation)
        {
            Func.AddEditDesignation(designation);
            Func.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteDesignation(int designationID)
        {
            Func.DeleteDesignation(designationID);
            Func.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DesignationForm(Designation designation)
        {
            return View(designation);
        }
    }
}