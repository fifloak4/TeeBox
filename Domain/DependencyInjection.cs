using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TeeBox.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
