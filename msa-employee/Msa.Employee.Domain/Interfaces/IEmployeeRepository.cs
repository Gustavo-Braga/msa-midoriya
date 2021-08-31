using System;
using System.Threading.Tasks;

namespace Msa.Employee.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Guid> Insert(Model.Employee employee);
    }
}
