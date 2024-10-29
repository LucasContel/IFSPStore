using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IFSPStore.Test
{
    [TestClass]
    public class UnitTestRepository
    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Cidade> Cidades { get; set; }
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Grupo> Grupos { get; set; }
            public DbSet<Produto> Produtos { get; set; }
            public DbSet<Venda> Vendas { get; set; }
            public DbSet<VendaItem> VendaItens { get; set; }
            public MyDbContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPStore";
                var username = "root";
                var password = "ifsp";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";
                if(!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]
        public void TestInsertCidades()
        {

            using (var context = new MyDbContext())
            {


                var cidade = new Cidade
                {
                    Nome = "Birigui",
                    Estado = "SP"
                };

                context.Cidades.Add(cidade);

                cidade = new Cidade {
                    Nome = "Araçatuba",
                    Estado = "SP"
                };
                context.Cidades.Add(cidade);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListCidades()
        {
            using (var context = new MyDbContext())
            {
                foreach (var cidade in context.Cidades)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cidade));
                }
            }
        }

        [TestMethod]
        public void TestInsertClientes()
        {
            using (var context = new MyDbContext())
            {

                var cidade = context.Cidades.FirstOrDefault(c => c.Id==1);

                var cliente = new Cliente
                {
                    Nome = "Murilo Varges",
                    Endereco = "Pedro Cavalo, 709",
                    Documento = "60.104.569-85",
                    Bairro = "Residencial Portal da Pérola II",
                    Cidade = cidade
                };

                context.Clientes.Add(cliente);
                cidade = context.Cidades.FirstOrDefault(c => c.Id == 2);

                cliente = new Cliente
                {
                    Nome = "Lucas Henrique",
                    Endereco = "Severo Xavier Soares, 563",
                    Documento = "59.104.504-85",
                    Bairro = "Parque das Nações",
                    Cidade= cidade
                };

                context.Clientes.Add(cliente);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListClientes()
        {
            using (var context = new MyDbContext())
            {
                foreach (var cliente in context.Clientes)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cliente));
                }
            }
        }

        [TestMethod]
        public void TestInsertGrupo()
        {
            using (var context = new MyDbContext())
            {
                var grupo = new Grupo
                {
                    Nome = "Eletrônicos"
                };

                context.Grupos.Add(grupo);

                grupo = new Grupo
                {
                    Nome = "Utilitários"
                };

                context.Grupos.Add(grupo);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListGrupos()
        {
            using (var context = new MyDbContext())
            {
                foreach (var grupo in context.Grupos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(grupo));
                }
            }
        }

        [TestMethod]
        public void TestInsertProduto()
        {
            using (var context = new MyDbContext())
            {

                var grupo = context.Grupos.FirstOrDefault(c => c.Id == 1);

                var produto = new Produto
                {
                    Nome = "TV 40''",
                    Preco = 2500.00f,
                    Quantidade = 1,
                    DataCompra = DateTime.Parse("2024-10-29 09:30:00"),
                    UnidadeVenda = "Unidade",
                    Grupo = grupo

                };

                context.Produtos.Add(produto);
                grupo = context.Grupos.FirstOrDefault(c => c.Id == 2);

                produto = new Produto
                {
                    Nome = "Cadeira",
                    Preco = 500.00f,
                    Quantidade = 2,
                    DataCompra = DateTime.Parse("2024-10-29 08:00:00"),
                    UnidadeVenda = "Unidade",
                    Grupo = grupo
                };

                context.Produtos.Add(produto);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListProdutos()
        {
            using (var context = new MyDbContext())
            {
                foreach (var produto in context.Produtos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(produto));
                }
            }
        }

        [TestMethod]
        public void TestInsertUsuarios()
        {
            using (var context = new MyDbContext())
            {
                var Usuario = new Usuario
                {
                    Nome = "Lucas Contel",
                    Senha = "123",
                    Login = "lucas",
                    Email = "l.contel@aluno.ifsp.edu.br",
                    DataCadastro = DateTime.Parse("2024-10-28 08:00:00"),
                    DataLogin = DateTime.Now,
                    Ativo = true
                };

                context.Usuarios.Add(Usuario);

                Usuario = new Usuario
                {
                    Nome = "Matheus Mendes",
                    Senha = "321",
                    Login = "matheus",
                    Email = "matheusmendes@gmail.com",
                    DataCadastro = DateTime.Parse("2024-10-28 08:00:00"),
                    DataLogin = DateTime.Now,
                    Ativo = true
                };

                context.Usuarios.Add(Usuario);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListUsuarios()
        {
            using (var context = new MyDbContext())
            {
                foreach (var usuario in context.Usuarios)
                {
                    Console.WriteLine(JsonSerializer.Serialize(usuario));
                }
            }
        }



        [TestMethod]
        public void TestInsertVendas()
        {
            

            using (var context = new MyDbContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(c => c.Id == 1);
                var cliente = context.Clientes.FirstOrDefault(c => c.Id == 1);
                var produto = context.Produtos.FirstOrDefault(c => c.Id == 1);


                var Venda = new Venda
                {
                    Data = DateTime.Parse("2024-10-29 10:00:00"),
                    ValorTotal = 2500.00f,
                    Usuario = usuario,
                    Cliente = cliente,
                    Itens = new List<VendaItem>()
                };

                var VendaItem = new VendaItem
                {
                    Quantidade = 1,
                    ValorUnitario = produto.Preco,
                    ValorTotal = produto.Preco * 1,
                    Venda = Venda,
                    Produto = produto
                };
                
                Venda.Itens.Add(VendaItem);

                context.Vendas.Add(Venda);

                usuario = context.Usuarios.FirstOrDefault(c => c.Id == 2);
                cliente = context.Clientes.FirstOrDefault(c => c.Id == 2);
                produto = context.Produtos.FirstOrDefault(c => c.Id == 2);

                Venda = new Venda
                {
                    Data = DateTime.Parse("2024-10-29 11:00:00"),
                    ValorTotal = 1000f,
                    Usuario = usuario,
                    Cliente = cliente,
                    Itens = new List<VendaItem>()
                };


                VendaItem = new VendaItem
                {
                    Quantidade = 2,
                    ValorUnitario = produto.Preco,
                    ValorTotal = produto.Preco * 2,
                    Venda = Venda,
                    Produto = produto
                };

                Venda.Itens.Add(VendaItem);
                

                context.Vendas.Add(Venda);

                context.SaveChanges();
            }

            
        }

        [TestMethod]
        public void TestListVenda()
        {
            using (var context = new MyDbContext())
            {
                foreach (var venda in context.Vendas)
                {
                    Console.WriteLine(JsonSerializer.Serialize(venda));
                }
            }
        }

        [TestMethod]
        public void TestListVendaItens()
        {
            using (var context = new MyDbContext())
            {
                foreach (var vendaItens in context.VendaItens)
                {
                    Console.WriteLine(JsonSerializer.Serialize(vendaItens));
                }
            }
        }
    }
}
