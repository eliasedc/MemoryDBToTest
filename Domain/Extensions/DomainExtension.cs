using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Extensions
{
    public static class DomainExtension
    {
        public static IServiceCollection AddDependencyInjectionDomain(this IServiceCollection services) =>
            services.AddScoped<IDomain, Domain>();
    }
}
