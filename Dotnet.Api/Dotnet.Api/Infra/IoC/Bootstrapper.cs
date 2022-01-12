using Dotnet.Api.Application.Interface;
using Dotnet.Api.Application.Service;
using Dotnet.Api.Domain.Interfaces;
using Dotnet.Api.Infra.Data.Repository;

namespace Dotnet.Api.Infra.IoC
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoService, ProdutoService>();

            
            return services;
        }
    }
}
