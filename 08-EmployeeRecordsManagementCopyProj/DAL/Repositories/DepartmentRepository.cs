using _08_EmployeeRecordsManagementCopyProj.DAL.Contracts;
using _08_EmployeeRecordsManagementCopyProj.Data;
using _08_EmployeeRecordsManagementCopyProj.EntityModels;

namespace _08_EmployeeRecordsManagementCopyProj.DAL.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public DepartmentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}
