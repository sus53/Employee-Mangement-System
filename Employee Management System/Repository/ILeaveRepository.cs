using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_System.Models;

namespace Employee_Management_System.Respitory
{
    interface ILeaveRespitory
    {
        IEnumerable<Leave> GetLeave();
        void AddEditLeave(Leave leave);
        void DeleteLeave(int leaveID);
        void SaveChanges();
    }
}
