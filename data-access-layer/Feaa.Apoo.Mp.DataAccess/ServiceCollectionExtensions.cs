using Feaa.Apoo.Mp.DataAccess.Interfaces;
using Feaa.Apoo.Mp.DataAccess.Repositories;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Feaa.Apoo.Mp.DataAccess
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDataAccess(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<MpDbContext>(options => options.UseSqlServer(connectionString));
            serviceCollection.AddScoped<IProjectRepository, ProjectRepository>();
        }
    }
}