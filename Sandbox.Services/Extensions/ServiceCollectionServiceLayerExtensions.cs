using Microsoft.Extensions.DependencyInjection;
using Sandbox.Services.ServiceImplementations;
using Sandbox.Services.ServiceInterfaces;
using Sandbox.Repository.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox.Services.Extensions
{
    public static class ServiceCollectionServiceLayerExtensions
    {
        public static IServiceCollection AddServiceLayerServices(this IServiceCollection services)
        {
            services.AddRepoServices();
            services.AddScoped<IQuestionService, QuestionService>();
            return services;
        }
    }
}
