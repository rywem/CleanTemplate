using Clean.ApplicationCore.Interfaces;
using Clean.ApplicationCore.Services;
using Clean.Domain.Interfaces;
using Clean.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services )
        {
            // Application Layer
            services.AddScoped<ICourseService, CourseService>();

            // Infrastructure.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();

        }
    }
}
