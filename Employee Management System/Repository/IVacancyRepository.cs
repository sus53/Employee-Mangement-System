using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_System.Models;
namespace Employee_Management_System.Respitory
{
    interface IVacancyRepository
    {
        IEnumerable<Vacancy> GetVacancy();
        void AddEditVacancy(Vacancy vacancy);
        void DeleteVacancy(int vacancyID);
        void SaveChanges();
    }
}
