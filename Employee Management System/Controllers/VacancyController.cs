using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee_Management_System.Models;
using Employee_Management_System.Respitory;

namespace Employee_Management_System.Controllers
{
    public class VacancyController : Controller
    {
        private readonly IVacancyRepository Func;
        public VacancyController()
        {
            this.Func = new VacancyRespitory(new DataContext());
        }
        public ActionResult Index()
        {
            return View(Func.GetVacancy());
        }
        public ActionResult VacancyForm(Vacancy vacancy)
        {
            return View(vacancy);
        }
        public ActionResult AddEditVacancy(Vacancy vacancy)
        {
            Func.AddEditVacancy(vacancy);
            Func.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteVacancy(int vacancyID)
        {
            Func.DeleteVacancy(vacancyID);
            Func.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult VacancyLeave(Vacancy vacancy)
        {
            return View(vacancy);
        }
    }
}