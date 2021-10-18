using Mvc.Dapper.Entity.Data.Repositories.Dapper;
using Mvc.Dapper.Entity.Data.Repositories.EntityFramework;
using Mvc.Dapper.Entity.Domain.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Mvc.Dapper.Entity.IoC
{
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IAutorEFRepository, AutorEFRepository>();
            services.AddScoped<ILivroEFRepository, LivroEFRepository>();
            services.AddScoped<IAutorDapperRepository, AutorDapperRepository>();
            services.AddScoped<ILivroDapperRepository, LivroDapperRepository>();
        }
    }
}
