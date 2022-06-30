using System;
using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BaseProjct.Api.Application.Extencions;

public static class Registration
{
    public static IServiceCollection AddApplicationRegistration(this IServiceCollection services) 
    {

        var assembly = Assembly.GetExecutingAssembly();

        services.AddMediatR(assembly);

        return services;    
    }

}
