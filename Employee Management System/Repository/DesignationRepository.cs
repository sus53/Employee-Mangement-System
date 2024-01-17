using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Employee_Management_System.Models;

namespace Employee_Management_System.Respitory
{
    public class DesignationRepository:IDesignationRespitory
    {
        DataContext dataContext;
        public DesignationRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<Designation> GetDesignation()
        {
            return (dataContext.Designation.ToList());
        }
        public void AddEditDesignation(Designation designation)
        {
            if (designation.designationID == 0)
            {
                dataContext.Designation.Add(designation);
            }
            else
            {
                dataContext.Entry(designation).State = System.Data.EntityState.Modified;
            }
        }
        public void DeleteDesignation( int designationID)
        {
            dataContext.Designation.Remove(dataContext.Designation.Where(x => x.designationID == designationID).First());
        }
        public void SaveChanges()
        {
            dataContext.SaveChanges();
        }

    }
}