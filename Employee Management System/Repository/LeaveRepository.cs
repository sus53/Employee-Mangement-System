using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Employee_Management_System.Models;

namespace Employee_Management_System.Respitory
{
    public class LeaveRespitory:ILeaveRespitory
    {
        DataContext dataContext;
        public LeaveRespitory(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<Leave> GetLeave()
        {
            return (dataContext.Leave.ToList());
        }
        public void AddEditLeave(Leave leave)
        {
            if (leave.leaveID == 0)
            {
                dataContext.Leave.Add(leave);
            }
            else
            {
                dataContext.Entry(leave).State = System.Data.EntityState.Modified;
            }
        }
        public void DeleteLeave(int leaveID)
        {
            dataContext.Leave.Remove(dataContext.Leave.Where(x => x.leaveID == leaveID).First());
        }
        public void SaveChanges()
        {
            dataContext.SaveChanges();
        }
    }
}