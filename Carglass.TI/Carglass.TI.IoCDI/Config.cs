using Carglass.TI.Data.EF.Repositories;
using Carglass.TI.Data.EF;
using Carglass.TI.Domain.Contracts.Infra;
using Carglass.TI.Domain.Contracts.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Carglass.TI.IoCDI
{
    public static class Config
    {

        public static void Setup(this IServiceCollection services) 
        {
            services.AddScoped<StoreDataContext>();
            services.AddTransient<IVeiculoRepository, VeiculoEFRepository>();
            services.AddTransient<IMarcaRepository, MarcaEFRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioEFRepository>();
            services.AddTransient<IPerfilRepository, PerfilEFRepository>();
            services.AddTransient<IUnitOfWork, EFUnitOfWork>();
        }
    }
}
