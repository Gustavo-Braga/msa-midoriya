using Msa.Employee.Domain.Dto;
using System;
using System.Threading.Tasks;

namespace Msa.Employee.Domain.Interfaces
{
    public interface IEmployeeService
    {
        Task<Guid> Insert(EmployeeRequest employee);
    }
    
}
