namespace _08_EmployeeRecordsManagementCopyProj.DAL.Contracts
{
    public interface IUnitRepository : IDisposable, IAsyncDisposable
    {
        IEmployeeRepository employeeRepository { get; }
        IDepartmentRepository departmentRepository { get; }
        Task<bool> SaveChangesAsync();
    }
}
