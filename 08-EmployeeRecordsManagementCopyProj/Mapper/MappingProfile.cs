using _08_EmployeeRecordsManagementCopyProj.EntityModels;
using _08_EmployeeRecordsManagementCopyProj.ViewModels.DepartmentVM;
using _08_EmployeeRecordsManagementCopyProj.ViewModels.EmployeeVM;
using AutoMapper;

namespace _08_EmployeeRecordsManagementCopyProj.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeViewModel, Employee>().ReverseMap();
            CreateMap<DepartmentViewModel, Department>().ReverseMap();
        }
    }
}
