﻿using _08_EmployeeRecordsManagementCopyProj.BLL.Contracts;
using _08_EmployeeRecordsManagementCopyProj.DAL.Contracts;
using _08_EmployeeRecordsManagementCopyProj.EntityModels;

namespace _08_EmployeeRecordsManagementCopyProj.BLL.Managers
{
    public class DepartmentManager : IDepartmentManager
    {
        private readonly IUnitRepository _unitRepository;
        public DepartmentManager(IUnitRepository unitRepository)
        {
            this._unitRepository = unitRepository;
        }

        public async Task AddAsync(Department department)
        {
            await _unitRepository.departmentRepository.AddAsync(department);
        }

        public async Task<Department?> GetDepartmentByIdAsync(int? id)
        {
            return await _unitRepository.departmentRepository.GetByIdAsync(id);
        }

        public void UpdateDepartment(Department department)
        {
            _unitRepository.departmentRepository.Update(department);
        }

        public void RemoveDepartment(Department department)
        {
            _unitRepository.departmentRepository.Remove(department);
        }

        public async Task<IEnumerable<Department>> GetAllAsync()
        {
            return _unitRepository.departmentRepository.GetAll().ToList();
        }        
    }
}
