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
    
    public partial class Designation
    {
        public Designation()
        {
            this.Employee = new HashSet<Employee>();
        }
    
        public int designationID { get; set; }
        public string designationName { get; set; }
        public string remarks { get; set; }
    
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
