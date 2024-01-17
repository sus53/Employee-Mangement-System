using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_System.Models;

namespace Employee_Management_System.Respitory
{
    interface IDesignationRespitory
    {
        IEnumerable<Designation> GetDesignation();
        void AddEditDesignation(Designation designation);
        void DeleteDesignation(int designationID);
        void SaveChanges();
    }
}
