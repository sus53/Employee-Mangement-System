using Employee_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Employee_Management_System.Respitory;

namespace Employee_Management_System.Respitory
{
    public class VacancyRespitory : IVacancyRepository
    {
        DataContext dataContext;
        public VacancyRespitory(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public void AddEditVacancy(Vacancy vacancy)
        {
            if (vacancy.vacancyID == 0)
            {
                dataContext.Vacancy.Add(vacancy);
            }
            else
            {
                dataContext.Entry(vacancy).State = System.Data.EntityState.Modified;
            }
        }

        public void DeleteVacancy(int vacancyID)
        {
            dataContext.Vacancy.Remove(dataContext.Vacancy.Where(x => x.vacancyID == vacancyID).First());
        }

        public IEnumerable<Vacancy> GetVacancy()
        {
            return (dataContext.Vacancy.ToList());
        }

        public void SaveChanges()
        {
            dataContext.SaveChanges();
        }
    }
}