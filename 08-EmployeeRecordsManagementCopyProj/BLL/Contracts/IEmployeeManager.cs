using _08_EmployeeRecordsManagementCopyProj.EntityModels;

namespace _08_EmployeeRecordsManagementCopyProj.BLL.Contracts
{
    public interface IEmployeeManager
    {
        Task AddEmployeeAsync(Employee employee);
        Task<Employee?> GetEmployeeByIdAsync(int? id);
        void UpdateEmployee(Employee employee);
        void RemoveEmployee(Employee employee);
        IQueryable<Employee> GetAll();
        IQueryable<Employee> SearchEmployeeResult(string searchString);
    }
}
