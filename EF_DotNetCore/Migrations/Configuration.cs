using EF_DotNetCore.Models;
using System.Linq;

namespace EF_DotNetCore.Migrations
{
    class Configuration
    {
        private readonly AppDBContext _context;

        public Configuration(AppDBContext context)
        {
            _context = context;
        }
        public void SeedData()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country { ID = 1, Name = "Egypt" });
                _context.Countries.Add(new Country { ID = 2, Name = "USA" });
                _context.Countries.Add(new Country { ID = 3, Name = "UK" });
            }

            if (!_context.Departments.Any())
            {
                _context.Departments.Add(new Department { ID = 1, Name = "Management" });
                _context.Departments.Add(new Department { ID = 2, Name = "HR" });
                _context.Departments.Add(new Department { ID = 3, Name = "Sales" });
                _context.Departments.Add(new Department { ID = 4, Name = "Marketing" });
                _context.Departments.Add(new Department { ID = 5, Name = "IT" });
            }

            _context.SaveChanges();
        }
    }
}
