using Fiap.Api.Donation2.Models;

namespace Fiap.Api.Donation2.ViewModel
{
    public class TrocaResponseVM
    {

        public Guid TrocaId { get; set; }

        public DateTime DataCriacao { get; set; }

        public TrocaStatus Status { get; set; }

        public int UsuarioId { get; set; }

        public ProdutoResponseVM Produto1 { get; set; }

        public ProdutoResponseVM Produto2 { get; set; }
    }
}
