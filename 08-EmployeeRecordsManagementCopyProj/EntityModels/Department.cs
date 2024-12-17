using System.ComponentModel.DataAnnotations;

namespace _08_EmployeeRecordsManagementCopyProj.EntityModels
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        //Relationship with employees
        public ICollection<Employee> Employees { get; set; } //Collection navigation property
    }
}
