using Msa.Employee.Domain.Interfaces;
using Newtonsoft.Json;
using System;

namespace Msa.Employee.Domain.Service
{
    public class EmployeeService : IEmployeeService
    {
        public int Insert(int id)
        {

            string teste = JsonConvert.SerializeObject(new { Id= id, Teste = "testado"});

            return new Random().Next(0, 300);
        }
    }
}
