using _08_EmployeeRecordsManagementCopyProj.EntityModels;

namespace _08_EmployeeRecordsManagementCopyProj.BLL.Contracts
{
    public interface IDepartmentManager
    {
        Task AddAsync(Department department);
        Task<Department?> GetDepartmentByIdAsync(int? id);
        void UpdateDepartment(Department department);
        void RemoveDepartment(Department department);
        Task<IEnumerable<Department>> GetAllAsync();
    }
}
