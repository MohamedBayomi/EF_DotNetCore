using System.Collections.Generic;

namespace EF_DotNetCore.Models
{
    class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
