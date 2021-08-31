using Microsoft.Extensions.DependencyInjection;
using Msa.Employee.Domain.Interfaces;
using Msa.Employee.Domain.Service;

namespace Msa.Employee.CrossCutting.Ioc
{
    public static class DependencyInjection
    {
        public static void Inject(IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
        }
    }
}
