
using IFSPStore.app.Cadastros;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IFSPStore.app.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static IServiceProvider? ServicesProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();
            #region Banco_de_dados
            var strCon = File.ReadAllText("Config/ConfigBanco.txt");

            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(100);
                    opt.EnableRetryOnFailure();
                });
            });

            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            Services.AddScoped<IBaseRepository<Grupo>, BaseRepository<Grupo>>();
            Services.AddScoped<IBaseRepository<Produto>, BaseRepository<Produto>>();
            Services.AddScoped<IBaseRepository<Venda>, BaseRepository<Venda>>();
            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Usuario>, IBaseService<Usuario>>();
            Services.AddScoped<IBaseService<Cidade>, IBaseService<Cidade>>();
            Services.AddScoped<IBaseService<Cliente>, IBaseService<Cliente>>();
            Services.AddScoped<IBaseService<Grupo>, IBaseService<Grupo>>();
            Services.AddScoped<IBaseService<Produto>, IBaseService<Produto>>();
            Services.AddScoped<IBaseService<Venda>, IBaseService<Venda>>();
            #endregion

            #region Formulários
            Services.AddTransient<CadastroCidade, CadastroCidade>();

            #endregion

            ServicesProvider = Services.BuildServiceProvider();
        }

    }
}
