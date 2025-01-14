﻿using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Suppliers.Application.Common.Behaviors;
using System.Reflection;

namespace Suppliers.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) 
        {
            services.AddMediatR(configuration => 
                configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddValidatorsFromAssemblies(new[] { Assembly.GetExecutingAssembly() });
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            return services;
        }
    }
}
