using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TeeBox.Application.Services;
using TeeBox.Application.Services.Interfaces;

namespace TeeBox.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<IMapService, MapService>();
            services.AddScoped<ICourseService, CourseService>();

            return services;
        }
    }
}
