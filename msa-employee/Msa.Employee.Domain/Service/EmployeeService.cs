using AutoMapper;
using Msa.Employee.Domain.Dto;
using Msa.Employee.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace Msa.Employee.Domain.Service
{
    public class EmployeeService : IEmployeeService
    {

        private IEmployeeRepository _employeeRepository;
        private IMapper _mapper;
        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }


        public async Task<Guid> Insert(EmployeeRequest employee)
        {
            var model = _mapper.Map<Model.Employee>(employee);
            await _employeeRepository.Insert(model);
            return model.Id;
        }
    }
}
