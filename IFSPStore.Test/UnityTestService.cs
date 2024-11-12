using Microsoft.Extensions.DependencyInjection;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Services;
using IFSPStore.Service.Validators;
using AutoMapper;
using System.Text.Json;

namespace IFSPStore.Test
{
    [TestClass]
    public class UnityTestService
    {
        private ServiceCollection? services;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPStore";
                var username = "root";
                var password = "ifsp";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(100);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            services.AddSingleton(new MapperConfiguration(config =>
                {
                    config.CreateMap<Usuario, Usuario>();
                }).CreateMapper());

            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestUsuario()
        {
            var sp = ConfigureServices();

            var usuarioService = sp.GetService<IBaseService<Usuario>>();
            var usuario = new Usuario
            {
                Nome = "Murilo",
                Login = "mvs",
                Email = "murilo@gmal.com",
                Senha = "123Ab!Teste",
                DataCadastro = DateTime.Now
            };

            var result = usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectUsuario()
        {
            var sp = ConfigureServices();
            var UsuarioService = sp.GetService<IBaseService<Usuario>>();

            var result = UsuarioService.Get<Usuario>();

            Console.Write(JsonSerializer.Serialize(result));

        }
    }
}
