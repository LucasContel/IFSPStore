
using IFSPStore.Domain.Entities;

namespace IFSPStore.app.Models
{
    public class ClienteModel
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Documento { get; set; }
        public string Bairro { get; set; }
        public int IdCidade { get; set; }
        public string Cidade { get; set; }

        
    }
}
