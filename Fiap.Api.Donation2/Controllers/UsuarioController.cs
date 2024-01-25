using AutoMapper;
using Fiap.Api.Donation2.Models;
using Fiap.Api.Donation2.Repository;
using Fiap.Api.Donation2.Repository.Interface;
using Fiap.Api.Donation2.Services;
using Fiap.Api.Donation2.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.Donation2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioRepository _usuarioRepository;

        private readonly IMapper _mapper;

        public UsuarioController(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IList<UsuarioResponseVM>>> GetAsync()
        {
            var usuarios = await _usuarioRepository.FindAll();

            if( usuarios != null && usuarios.Count > 0 )
            {
                var resposta = _mapper.Map<List<UsuarioResponseVM>>(usuarios);
                return Ok(resposta);
            } else
            {
                return NoContent();
            }

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<UsuarioResponseVM>> GetAsync(int id)
        {
            var usuario = await _usuarioRepository.FindById(id);

            if (usuario != null)
            {
                var resposta = _mapper.Map<UsuarioResponseVM>(usuario);
                return Ok(usuario);
            } else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> Post([FromBody] UsuarioModel usuarioModel)
        {
                
            if ( ! ModelState.IsValid )
            {
                return BadRequest();
            }

            await _usuarioRepository.Insert(usuarioModel);

            var url = Request.GetEncodedUrl().EndsWith("/") ?
                        Request.GetEncodedUrl() : 
                        Request.GetEncodedUrl() + "/";

            url = url + usuarioModel.UsuarioId;
           

            return Created(url, usuarioModel);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put([FromRoute] int id, [FromBody] UsuarioModel usuarioModel)
        {
            if ( (!ModelState.IsValid) || (id != usuarioModel.UsuarioId) )
            {
                return BadRequest();
            } else 
            {
                _usuarioRepository.Update(usuarioModel);
                return NoContent();
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {

            if ( id == 0 )
            {
                return BadRequest();
            }

            var usuario = _usuarioRepository.FindById(id);

            if (usuario == null )
            {
                return NotFound();

            }
            
            _usuarioRepository.Delete(id);
            return NoContent();
            
        }

        
        [HttpPost]
        [Route("Login")]
        
        public async Task<ActionResult<LoginResponseVM>> Login([FromBody] LoginRequestVM loginRequestVM)
        {

            var usuario = await _usuarioRepository.FindByEmailAndSenha(
                loginRequestVM.EmailUsuario,
                loginRequestVM.Senha);

            if ( usuario != null)
            {
                // GERANDO TOKEN DE ACESSO
                var token = AuthenticationService.GetToken(usuario);

                var loginResponseVM = _mapper.Map<LoginResponseVM>(usuario);
                loginResponseVM.Token = token;

                return Ok(loginResponseVM);
            } else
            {
                return NotFound();
            }
            

        }
        


    }
}
