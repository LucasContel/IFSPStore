
using AutoMapper;
using IFSPStore.app.Base;
using IFSPStore.app.Cadastros;
using IFSPStore.app.Models;
using IFSPStore.app.Outros;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Services;
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
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            Services.AddScoped<IBaseService<Grupo>, BaseService<Grupo>>();
            Services.AddScoped<IBaseService<Produto>, BaseService<Produto>>();
            Services.AddScoped<IBaseService<Venda>, BaseService<Venda>>();
            #endregion

            #region Formulários
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroCliente, CadastroCliente>();
            Services.AddTransient<CadastroGrupo, CadastroGrupo>();
            Services.AddTransient<CadastroProduto, CadastroProduto>();
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            Services.AddTransient<CadastroVenda, CadastroVenda>();
            Services.AddTransient<Login, Login>();

            #endregion

            #region Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {

                config.CreateMap<Cidade, CidadeModel>()
                .ForMember(c => c.NomeEstado, c => c.MapFrom(x => $"{x.Nome}/{x.Estado}"));

                config.CreateMap<Cliente, ClienteModel>()
                .ForMember(c => c.Cidade, c => c.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                .ForMember(c => c.IdCidade, c => c.MapFrom(x => x.Cidade!.Id));

                config.CreateMap<Grupo, GrupoModel>();

                config.CreateMap<Produto, ProdutoModel>()
                .ForMember(c => c.Grupo, c => c.MapFrom(x => x.Grupo!.Nome))
                .ForMember(c => c.IdGrupo, c => c.MapFrom(x => x.Grupo!.Id));

                config.CreateMap<Usuario, UsuarioModel>();
                

            }).CreateMapper());
            #endregion

            ServicesProvider = Services.BuildServiceProvider();
        }

    }
}
