using AutoMapper;
using Msa.Employee.Domain.Dto;

namespace Msa.Employee.Domain.MapperProfile
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<EmployeeRequest, Model.Employee>();
        }
    }
}
