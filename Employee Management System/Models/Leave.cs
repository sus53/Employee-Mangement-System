//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Employee_Management_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Leave
    {
        public int leaveID { get; set; }
        public Nullable<int> departmentID { get; set; }
        public Nullable<int> employeeID { get; set; }
        public string subjectOfLeave { get; set; }
        public Nullable<int> leaveOfDuration { get; set; }
        public string remarks { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
