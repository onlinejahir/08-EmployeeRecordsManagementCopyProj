using _08_EmployeeRecordsManagementCopyProj.DAL.Contracts;
using _08_EmployeeRecordsManagementCopyProj.Data;
using _08_EmployeeRecordsManagementCopyProj.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace _08_EmployeeRecordsManagementCopyProj.DAL.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public EmployeeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }

        public override IQueryable<Employee> GetAll()
        {
            return _dbContext.Employees
                .Include(e => e.Department).AsQueryable();
        }
    }
}
