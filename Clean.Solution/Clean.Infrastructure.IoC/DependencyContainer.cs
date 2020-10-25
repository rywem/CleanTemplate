using Clean.ApplicationCore.Interfaces;
using Clean.ApplicationCore.Services;
using Clean.Domain.CommandHandlers;
using Clean.Domain.Commands;
using Clean.Domain.Core.Bus;
using Clean.Domain.Interfaces;
using Clean.Infrastructure.Bus;
using Clean.Infrastructure.Data.Context;
using Clean.Infrastructure.Data.Repository;
using MediatR;
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
            // Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Domain handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            // Application Layer
            services.AddScoped<ICourseService, CourseService>();
            // Infrastructure.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<SqlDbContext>();

        }
    }
}
