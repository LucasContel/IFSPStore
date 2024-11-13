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
using static IFSPStore.Test.UnitTestRepository;

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
            services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();

            services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();

            services.AddScoped<IBaseRepository<Grupo>, BaseRepository<Grupo>>();
            services.AddScoped<IBaseService<Grupo>, BaseService<Grupo>>();

            services.AddScoped<IBaseRepository<Produto>, BaseRepository<Produto>>();
            services.AddScoped<IBaseService<Produto>, BaseService<Produto>>();

            services.AddScoped<IBaseRepository<VendaItem>, BaseRepository<VendaItem>>();
            services.AddScoped<IBaseService<VendaItem>, BaseService<VendaItem>>();

            services.AddScoped<IBaseRepository<Venda>, BaseRepository<Venda>>();
            services.AddScoped<IBaseService<Venda>, BaseService<Venda>>();

            services.AddSingleton(new MapperConfiguration(config =>
                {
                    
                    //config.CreateMap<Usuario, Usuario>();
                    //config.CreateMap<Cidade, Cidade>();
                    //config.CreateMap<Cliente, Cliente>();
                    //config.CreateMap<Grupo, Grupo>();
                    //config.CreateMap<Produto, Produto>();
                    //config.CreateMap<VendaItem, VendaItem>();
                    //config.CreateMap<Venda, Venda>();
                    
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

        [TestMethod]
        public void TestCidade()
        {
            var sp = ConfigureServices();

            var CidadeService = sp.GetService<IBaseService<Cidade>>();
            var cidade = new Cidade
            {
                Nome = "Birigui",
                Estado = "SP"
            };

            var result = CidadeService.Add<Cidade, Cidade, CidadeValidator>(cidade);

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectCidade()
        {
            var sp = ConfigureServices();

            var CidadeService = sp.GetService<IBaseService<Cidade>>();

            var result = CidadeService.Get<Cidade>();

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestCliente()
        {
            var sp = ConfigureServices();

            var CidadeService = sp.GetService<IBaseService<Cidade>>();

            var ClienteService = sp.GetService<IBaseService<Cliente>>();

            var cidade = CidadeService?.Get<Cidade>().FirstOrDefault(c => c.Id == 1);

            var cliente = new Cliente
            {
                Nome = "Nome Teste Cliente",
                Endereco = "Endereco Teste Cliente",
                Documento = "Documento Teste Cliente",
                Bairro = "Bairro Teste Cliente",
                Cidade = cidade
            };

            var result = ClienteService.Add<Cliente, Cliente, ClienteValidator>(cliente);

            Console.Write(JsonSerializer.Serialize(result));
            
        }

        [TestMethod]
        public void TestSelectCliente()
        {
            var sp = ConfigureServices();
            var ClienteService = sp.GetService<IBaseService<Cliente>>();

            var result = ClienteService.Get<Cliente>();

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestGrupo()
        {
            var sp = ConfigureServices();

            var GrupoService = sp.GetService<IBaseService<Grupo>>();
            var grupo = new Grupo
            {
                Nome = "Eletronicos",
            };

            var result = GrupoService.Add<Grupo, Grupo, GrupoValidator>(grupo);

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectGrupo()
        {
            var sp = ConfigureServices();

            var GrupoService = sp.GetService<IBaseService<Grupo>>();

            var result = GrupoService.Get<Grupo>();

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestProduto()
        {
            var sp = ConfigureServices();

            var ProdutoService = sp.GetService<IBaseService<Produto>>();

            var GrupoService = sp.GetService<IBaseService<Grupo>>();

            var grupo = GrupoService?.Get<Grupo>().FirstOrDefault(c => c.Id == 1);


            var produto = new Produto
            {
                Nome = "Teste Produto",
                Preco = 22.99f,
                Quantidade = 6,
                DataCompra = DateTime.Now,
                UnidadeVenda = "UND",
                Grupo = grupo
            };

            var result = ProdutoService.Add<Produto, Produto, ProdutoValidator>(produto);

            Console.Write(JsonSerializer.Serialize(result));

        }

        [TestMethod]
        public void TestSelectProduto()
        {
            var sp = ConfigureServices();
            var ProdutoService = sp.GetService<IBaseService<Produto>>();

            var result = ProdutoService.Get<Produto>();

            Console.Write(JsonSerializer.Serialize(result));
        }


        [TestMethod]
        public void TestVenda()
        {
            var sp = ConfigureServices();

            var ClienteService = sp.GetService<IBaseService<Cliente>>();

            var UsuarioService = sp.GetService<IBaseService<Usuario>>();

            var ProdutoService = sp.GetService<IBaseService<Produto>>();

            var VendaService = sp.GetService<IBaseService<Venda>>();

            var VendaItemService = sp.GetService<IBaseService<VendaItem>>();

            var cliente = ClienteService?.Get<Cliente>().FirstOrDefault(c => c.Id == 1);

            var usuario = UsuarioService?.Get<Usuario>().FirstOrDefault(c => c.Id == 1);

            var produto = ProdutoService?.Get<Produto>().FirstOrDefault(c => c.Id == 1);

            var venda = new Venda
            {
                Data = DateTime.Now,
                ValorTotal = 99f,
                Usuario = usuario,
                Cliente = cliente,
                Itens = new List<VendaItem>()
            };

            var vendaItem = new VendaItem
            {
                Quantidade = 1,
                ValorUnitario = produto.Preco,
                ValorTotal = produto.Preco * 1,
                Venda = venda,
                Produto = produto
            };

            venda.Itens.Add(vendaItem);

            sp.GetService<MySqlContext>().Entry(venda).State = EntityState.Added;
            var resultVenda = VendaService.Add<Venda, Venda, VendaValidator>(venda);

            var resultItem = VendaItemService.Add<VendaItem, VendaItem, VendaItemValidator>(vendaItem);
            


            Console.Write(JsonSerializer.Serialize(resultVenda));

            

            Console.Write(JsonSerializer.Serialize(resultItem));

        }

        [TestMethod]
        public void TestSelectVendaItem()
        {
            var sp = ConfigureServices();

            var VendaItemService = sp.GetService<IBaseService<VendaItem>>();

            var result = VendaItemService.Get<VendaItem>();

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectVenda()
        {
            var sp = ConfigureServices();
            var VendaService = sp.GetService<IBaseService<Venda>>();

            var result = VendaService.Get<Venda>();

            Console.Write(JsonSerializer.Serialize(result));
        }

    }
}
