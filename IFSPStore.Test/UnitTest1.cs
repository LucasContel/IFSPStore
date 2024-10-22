using IFSPStore.Domain.Entities;
using System.Diagnostics;
using System.Text.Json;

namespace IFSPStore.Test
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestCidade()
        {
            Cidade cidade = new Cidade(1, "Birigui", "SP");

            Debug.WriteLine(JsonSerializer.Serialize(cidade));

            Assert.AreEqual(cidade.Nome, "Birigui");
            Assert.AreEqual(cidade.Estado, "SP");
        }

        [TestMethod]
        public void TestCliente()
        {
            Cidade cidade = new Cidade(1, "Birigui", "SP");

            
            Cliente cliente = new Cliente(1, "Nome", "Endereco", "Documento", "Bairro", cidade);

            Debug.WriteLine(JsonSerializer.Serialize(cliente));

            Assert.AreEqual(cliente.Nome, "Nome");
            Assert.AreEqual(cliente.Endereco, "Endereco");
            Assert.AreEqual(cliente.Documento, "Documento");
            Assert.AreEqual(cliente.Bairro, "Bairro");
            Assert.AreEqual(cliente.Cidade, cidade);


        }


    }
}