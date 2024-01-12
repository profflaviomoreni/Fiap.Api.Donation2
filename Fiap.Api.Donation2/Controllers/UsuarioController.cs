using Fiap.Api.Donation2.Models;
using Fiap.Api.Donation2.Repository;
using Fiap.Api.Donation2.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.Donation2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }


        [HttpGet]
        public IList<UsuarioModel> Get()
        {
            return _usuarioRepository.FindAll();
        }

        [HttpGet("{id:int}")]
        public UsuarioModel Get(int id)
        {
            return _usuarioRepository.FindById(id);
        }

        [HttpPost]
        public int Post([FromBody] UsuarioModel usuarioModel)
        {
            var retorno = _usuarioRepository.Insert(usuarioModel);

            return retorno;
        }

        [HttpPut("{id:int}")]
        public void Post([FromRoute] int id, [FromBody] UsuarioModel usuarioModel)
        {
            _usuarioRepository.Update(usuarioModel);
        }

        [HttpDelete("{id:int}")]
        public void Delete([FromRoute] int id)
        {
            _usuarioRepository.Delete(id);
        }


        [HttpPost]
        [Route("Login")]
        public UsuarioModel Login([FromBody] UsuarioModel usuarioModel)
        {
            return _usuarioRepository.FindByEmailAndSenha(
                usuarioModel.EmailUsuario, 
                usuarioModel.Senha);
        }


    }
}
