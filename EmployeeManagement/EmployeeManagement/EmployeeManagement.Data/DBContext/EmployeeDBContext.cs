using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Data.Tables;

namespace EmployeeManagement.Data.DBContext
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext() { }

        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(
                    "Server=(localdb)\\MSSQLLocalDB;Database=EmployeeDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
