using _08_EmployeeRecordsManagementCopyProj.EntityModels;
using System.ComponentModel.DataAnnotations;

namespace _08_EmployeeRecordsManagementCopyProj.ViewModels.DepartmentVM
{
    public class DepartmentViewModel
    {
        [Display(Name ="ID")]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Department name is required"), Display(Name = "Department Name")]
        [StringLength(100)]
        public string DepartmentName { get; set; }
    }
}
