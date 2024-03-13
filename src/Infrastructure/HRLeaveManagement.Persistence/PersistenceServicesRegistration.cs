using HRLeaveManagement.Application.Contracts.Persistence;
using HRLeaveManagement.Persistence.DatabaseContext;
using HRLeaveManagement.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContext<HRDatabaseContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("HRDatabaseSqlConnection"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}
