using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_System.Models;
namespace Employee_Management_System.Respitory
{
    interface IUserRespitory
    {
        void RegisterUser(C_user user);
        void Login(C_user user);
        void SaveChanges();
    }
}
