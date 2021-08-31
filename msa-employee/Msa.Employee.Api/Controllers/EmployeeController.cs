using Microsoft.AspNetCore.Mvc;
using Msa.Employee.Domain.Dto;
using Msa.Employee.Domain.Interfaces;
using System.Threading.Tasks;

namespace Msa.Employee.Api.Controllers
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        public async Task<IActionResult> Get([FromBody] EmployeeRequest request)
        {
            await Task.CompletedTask;
            return Ok(await _employeeService.Insert(request));
        }
    }
}
