using MongoDB.Driver;
using Msa.Employee.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace Msa.Employee.Infrastructure.Data.Repository
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly IMongoCollection<Domain.Model.Employee> _collection;

        public EmployeeRepository(string connectioString)
        {
            _collection = new MongoClient(connectioString).GetDatabase("HeroAcademy").GetCollection<Domain.Model.Employee>("Employee");
        }

        public async Task<Guid> Insert(Domain.Model.Employee employee)
        {
            await _collection.InsertOneAsync(employee);
            return employee.Id;
        }
    }
}
