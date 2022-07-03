using System;
using BaseProjct.Api.Application.Helpers;
using BaseProjct.Api.Application.Interfaces.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace BaseProject.Infrastructure.Persistance.Extensions
{
    public static class Registration
    {
        public static IServiceCollection AddInfrastructureRegistration (this IServiceCollection services)
        {
            services.AddScoped<IMathHelper, MathHelper>();
            return services;
        }
        
    }
}

