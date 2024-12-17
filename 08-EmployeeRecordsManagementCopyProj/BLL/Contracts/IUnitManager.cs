namespace _08_EmployeeRecordsManagementCopyProj.BLL.Contracts
{
    public interface IUnitManager : IDisposable, IAsyncDisposable
    {
        IEmployeeManager employeeManager { get; }
        IDepartmentManager departmentManager { get; }
        Task<bool> SaveChangesAsync();
    }
}
