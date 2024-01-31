using AutoMapper;
using Fiap.Api.Donation2.Models;
using Fiap.Api.Donation2.Repository.Interface;
using Fiap.Api.Donation2.Services;
using Fiap.Api.Donation2.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Fiap.Api.Donation2.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TrocaController : ControllerBase
    {

        private readonly ITrocaRepository trocaRepository;

        private readonly IProdutoRepository produtoRepository;

        private readonly TrocaService trocaService;

        private readonly IMapper mapper;

        public TrocaController(
            ITrocaRepository _trocaRepository,
            IProdutoRepository _produtoRepository,
            IMapper _mapper
            )
        {
            trocaRepository = _trocaRepository;
            produtoRepository = _produtoRepository;
            mapper = _mapper;

            trocaService = new TrocaService(produtoRepository, trocaRepository);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<TrocaResponseVM>> Get(Guid id)
        {
            var trocaModel = trocaRepository.FindById(id);

            var trocaResponseVM = mapper.Map<TrocaResponseVM>(trocaModel);
            trocaResponseVM.Produto1 = mapper.Map<ProdutoResponseVM>(trocaModel.ProdutoModel1);
            trocaResponseVM.Produto2 = mapper.Map<ProdutoResponseVM>(trocaModel.ProdutoModel2);

            return Ok(trocaResponseVM);
        }


        [HttpPost()]
        public async Task<ActionResult<Guid>> Post(TrocaRequestVM trocaRequestVM)
        {
            try
            {
                var trocaModel = mapper.Map<TrocaModel>(trocaRequestVM);
                trocaModel.UsuarioId = (int)GetUsuarioId();

                var idTroca = await trocaService.TrocarProdutos(trocaModel);

                return Ok(idTroca);
            }
            catch (Exception ex)
            {
                var erro = new
                {
                    ErrorMessage = ex.Message
                };

                return BadRequest(erro);
            }
        }


        private int? GetUsuarioId()
        {
            int? userId = 0;
            
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if ( identity != null )
            {
                var userIdClaim = identity.FindFirst("UsuarioId");
                if (userIdClaim != null && userIdClaim.Value != null)
                {
                    userId = Int16.Parse(userIdClaim.Value);
                }

            }

            return userId;
        }

    }
}
