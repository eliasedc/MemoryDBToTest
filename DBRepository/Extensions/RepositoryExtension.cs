using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepository.Extensions
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddDependencyInjectionRepository(this IServiceCollection services) =>
            services.AddScoped<IDBRepository, DBRepository>();
    }
}
