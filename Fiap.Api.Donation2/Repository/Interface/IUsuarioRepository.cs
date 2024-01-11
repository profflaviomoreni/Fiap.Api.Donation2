using Fiap.Api.Donation2.Models;

namespace Fiap.Api.Donation2.Repository.Interface
{
    public interface IUsuarioRepository
    {

        public IList<UsuarioModel> FindAll();

        public IList<UsuarioModel> FindByName(string nomeParcial);

        public UsuarioModel FindById(int id);
        
        public int Insert(UsuarioModel usuarioModel);
        public void Update(UsuarioModel usuarioModel);
        public void Delete(int id);



    }
}
