using Fiap.Api.Donation2.Models;

namespace Fiap.Api.Donation2.Repository.Interface
{
    public interface ITrocaRepository
    {

        public Guid Insert(Models.TrocaModel trocaModel);

        public TrocaModel FindById(Guid id);


    }
}
