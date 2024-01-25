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
            [FromQuery] string dataReferencia, 
            [FromQuery] int tamanho = 5)
        {

            var data = ( string.IsNullOrEmpty(dataReferencia) ) ? DateTime.UtcNow.AddYears(-200) : DateTime.ParseExact(dataReferencia, "yyyy-MM-ddTHH:mm:ss.fffffff", null, System.Globalization.DateTimeStyles.RoundtripKind);

            var produtos =  produtoRepository.FindAll(data, tamanho);
            var novaDataReferencia = produtos.LastOrDefault().DataCadastro.ToString("yyyy-MM-ddTHH:mm:ss.ffffffF");

            var linkProximo = $"/api/produto?dataReferencia={novaDataReferencia}&tamanho={tamanho}";

            if (produtos == null || produtos.Count == 0)
            {
                return NoContent();
            }

            var retorno = new
            {
                produtos,
                linkProximo
            };

            return Ok(retorno);
        }


        //[HttpGet]
        //public ActionResult<IList<dynamic>> GetProdutos(
        //    [FromQuery] int pagina = 0,
        //    [FromQuery] int tamanho = 5)
        //{

        //    var totalGeral = produtoRepository.Count();
        //    var totalPaginas = Convert.ToInt16(Math.Ceiling((double)totalGeral / tamanho));
        //    var linkProxima = (pagina < totalPaginas - 1) ? $"/api/produto?pagina={pagina + 1}&tamanho={tamanho}" : "";
        //    var linkAnterior = (pagina > 0) ? $"/api/produto?pagina={pagina - 1}&tamanho={tamanho}" : "";


        //    if (pagina > totalPaginas)
        //    {
        //        return NotFound();
        //    }

        //    var produtos = produtoRepository.FindAll(pagina, tamanho);
        //    if (produtos == null || produtos.Count == 0)
        //    {
        //        return NoContent();
        //    }

        //    var retorno = new
        //    {
        //        produtos,
        //        totalPaginas,
        //        totalGeral,
        //        linkProxima,
        //        linkAnterior
        //    };

        //    return Ok(retorno);
        //}

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
