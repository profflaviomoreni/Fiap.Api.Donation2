using Fiap.Api.Donation2.Models;
using Fiap.Api.Donation2.Repository.Interface;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.Donation2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository produtoRepository;

        public ProdutoController(IProdutoRepository _produtoRepository)
        {
            produtoRepository = _produtoRepository;
        }

        

        [HttpGet]
        public ActionResult<IList<dynamic>> GetProdutos( 
            [FromQuery] int pagina = 0, 
            [FromQuery] int tamanho = 5)
        {
            var produtos =  produtoRepository.FindAll();
            if (produtos == null || produtos.Count == 0)
            {
                return NoContent();
            }

            var retorno = new
            {
                produtos = produtos,
                totalPaginas = 0,
                totalGeral = 0,
                linkProxima = "proximo",
                linkAnterior = "anterior",
                pagina = pagina,
                tamanho = tamanho
            };

            return Ok(retorno);
        }


        //[HttpGet]
        //public ActionResult<IList<ProdutoModel>> GetProdutos()
        //{
        //    var produtos = produtoRepository.FindAll();
        //    if (produtos == null || produtos.Count == 0)
        //    {
        //        return NoContent();
        //    }

        //    return Ok(produtos);
        //}


        [HttpGet("{id}")]
        public ActionResult<ProdutoModel> GetProdutoModel(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            else
            {
                var prod =  produtoRepository.FindById(id);

                if (prod == null)
                {
                    return NotFound(id);
                }
                else
                {
                    return Ok(prod);
                }
            }
        }

        [HttpPut("{id}")]
        public IActionResult PutProdutoModel(int id, ProdutoModel produtoModel)
        {
            if (id != produtoModel.ProdutoId)
            {
                return BadRequest();
            }
            else
            {
                var produtoConsulta = produtoRepository.FindById(id);

                if (produtoConsulta == null)
                {
                    return NotFound();
                }
                else
                {
                    produtoRepository.Update(produtoModel);
                    return NoContent();
                }
            }
        }

        [HttpPost]
        public ActionResult<ProdutoModel> PostProdutoModel(ProdutoModel produtoModel)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            try
            {

                 produtoRepository.Insert(produtoModel);

                var url = Request.GetEncodedUrl().EndsWith("/") ?
                                                Request.GetEncodedUrl() :
                                                Request.GetEncodedUrl() + "/";

                var location = new Uri(url + produtoModel.ProdutoId);

                return Created(location, produtoModel);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Produto/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProdutoModel(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var produto =  produtoRepository.FindById(id);

            if (produto == null)
            {
                return NotFound();
            }
            else
            {
                produtoRepository.Delete(id);
                return NoContent();
            }
        }


    }
}
