using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ocit.Exezrcies.Emds.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocit.Exezrcies.Emds.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services)
        {
            var connectionString = "Host=localhost;Port=5432;Database=postgres;Username=root;Password=root;";
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });

            services.AddScoped<IAppDbContext, AppDbContext>();

            return services;
        }
    }
}
