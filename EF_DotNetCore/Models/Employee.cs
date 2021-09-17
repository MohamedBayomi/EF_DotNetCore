using System;

namespace EF_DotNetCore.Models
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public DateTime? HireDate { get; set; }
        
        // Navigation Property:
        // To drill down references though standard chained object notation 
        public Department Department { get; set; }
    }
}
