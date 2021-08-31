using Microsoft.Extensions.DependencyInjection;
using Msa.Employee.Domain.Interfaces;
using Msa.Employee.Domain.Service;
using Msa.Employee.Infrastructure.Data.Repository;
using System.Configuration;

namespace Msa.Employee.CrossCutting.Ioc
{
    public static class DependencyInjection
    {
        public static void Inject(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Domain.MapperProfile.AutoMapper));
            services.AddScoped<IEmployeeService, EmployeeService>();

            services.AddScoped<IEmployeeRepository, EmployeeRepository>(x=> new EmployeeRepository(AppSettings.GetValue("ConnectionStrings:MongoDb")));
        }
    }
}
