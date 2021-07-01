using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeeBox.Infrastructure.Services;
using TeeBox.Infrastructure.Services.Interfaces;
using TeeBox.Infrastructure.Services.Options;

namespace TeeBox.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddFileService(this IServiceCollection services)
        {
            services.AddOptions<FileServiceOptions>().Configure<IConfiguration>(
               (settings, configuration) =>
               {
                   configuration.GetSection(FileServiceOptions.FileService).Bind(settings);
               });

            services.AddScoped<IFileService, FileService>();

            return services;
        }
    }
}
