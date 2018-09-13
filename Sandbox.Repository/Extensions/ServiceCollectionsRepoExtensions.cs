using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sandbox.DataLayer.Extensions;
using Sandbox.Repository.RepositoryImplementations;
using Sandbox.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox.Repository.Extensions
{
    public static class ServiceCollectionsRepoExtensions
    {
        public static IServiceCollection AddRepoServices(this IServiceCollection services)
        {
            services.AddDataService();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            return services;
        }
    }
}
