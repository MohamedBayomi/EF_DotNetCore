using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF_DotNetCore.Models
{
    class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> opt) : base(opt)
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
