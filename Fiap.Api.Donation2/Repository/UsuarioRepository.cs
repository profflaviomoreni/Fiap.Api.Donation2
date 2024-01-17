using Fiap.Api.Donation2.Data;
using Fiap.Api.Donation2.Models;
using Fiap.Api.Donation2.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.Donation2.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly DataContext _dataContext;

        public UsuarioRepository(DataContext ctx)
        {
            _dataContext = ctx;
        }


        public IList<UsuarioModel> FindAll()
        {
            return _dataContext.Usuarios.AsNoTracking().ToList();
        }

        public UsuarioModel FindById(int id)
        {
            var usuario = _dataContext.Usuarios.AsNoTracking().FirstOrDefault(u => u.UsuarioId == id);

            return usuario;
        }

        public void Delete(int id)
        {
            var usuario = new UsuarioModel();
            usuario.UsuarioId = id;

            _dataContext.Usuarios.Remove(usuario);
            _dataContext.SaveChanges();
        }

        public int Insert(UsuarioModel usuarioModel)
        {
            _dataContext.Usuarios.Add(usuarioModel);
            _dataContext.SaveChanges();

            return usuarioModel.UsuarioId;
        }

        public void Update(UsuarioModel usuarioModel)
        {
            _dataContext.Usuarios.Update(usuarioModel);
            _dataContext.SaveChanges();
        }

        public UsuarioModel FindByEmailAndSenha(string email, string senha)
        {
            var usuario = _dataContext.Usuarios.AsNoTracking().FirstOrDefault(
                    u => u.EmailUsuario == email &&
                         u.Senha == senha
                );

            return usuario;
        }
    }
}
