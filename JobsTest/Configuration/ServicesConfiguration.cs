using JobHiring.Services;
using JobHiring.Services.Impl;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHiring.Configuration
{
    public static class ServicesConfiguration
    {
        public static void JobServices(this IServiceCollection services)
        {
            services.AddScoped<IJobService, JobService>();
            services.AddTransient<IJobService, JobService>();
        }
    }
}
