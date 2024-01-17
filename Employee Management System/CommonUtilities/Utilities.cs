using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee_Management_System.Models;

namespace Employee_Management_System.CommonUtilities
{
    public class Utilities
    {
        public static SelectList GetDepartment()
        {
            DataContext db = new DataContext();
            SelectList list = new SelectList(db.Department.ToList(),"departmentID","departmentName");
            return list;
        }
        public static SelectList GetDesignation()
        {
            DataContext db = new DataContext();
            SelectList list = new SelectList(db.Designation.ToList(),"designationID","designationName");
            return list;
        }
        public static SelectList GetEmployee()
        {
            DataContext db = new DataContext();
            SelectList list = new SelectList(db.Employee.ToList(), "employeeID", "employeeName");
            return list;
        }
    }
}