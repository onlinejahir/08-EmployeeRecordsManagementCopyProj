using _08_EmployeeRecordsManagementCopyProj.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace _08_EmployeeRecordsManagementCopyProj.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
