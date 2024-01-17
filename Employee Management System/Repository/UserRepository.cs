using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Employee_Management_System.Models;
using Employee_Management_System.Respitory;

namespace Employee_Management_System.Respitory
{
    public class UserRepository : IUserRespitory
    {
        DataContext dataContext;
        public void Login(C_user user)
        {
            if (true)
            {

            }   
        }

        public void RegisterUser(C_user user)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}