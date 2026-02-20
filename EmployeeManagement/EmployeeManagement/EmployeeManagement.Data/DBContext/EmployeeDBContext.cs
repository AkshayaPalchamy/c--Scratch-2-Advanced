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
    "Server=localhost;Database=EmployeeDB;Trusted_Connection=True;Encrypt=False");
            }

            using (var Context = new EmployeeDBContext()) 
            {
                var Employee = new Employee()
                {
                    EmployeeName = "Akshaya",
                    EmployeeEmail = "akshayapalchamy@gmail.com",
                    DeparmentID = 1
                };
                Context.Employees.Add(Employee);
                Context.SaveChanges();
            }

            using (var Context = new EmployeeDBContext()) 
            {
                var emp = Context.Employees.FirstOrDefault();

                var devs = Context.Employees.Where(r => r.DeparmentID == 1).ToList();
            }
        }
    }
}
