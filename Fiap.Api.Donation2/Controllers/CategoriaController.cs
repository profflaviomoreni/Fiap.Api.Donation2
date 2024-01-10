using Fiap.Api.Donation2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.Donation2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        [HttpGet]
        public List<CategoriaModel> Get()
        {
            return new List<CategoriaModel>()
            {
                new CategoriaModel()
                {
                    CategoriaId = 1,
                    Nome = "Celular"
                },
                new CategoriaModel() {
                    CategoriaId = 2,
                    Nome = "Televisor"
                }
            };
        }


        [HttpGet("{id:int}")]
        public CategoriaModel Get([FromRoute] int id)
        {
            return new CategoriaModel()
            {
                CategoriaId = 1,
                Nome = "Celular"
            };
        }

        [HttpDelete("{id:int}")]
        public string Delete([FromRoute] int id)
        {
            return "Categoria removida com sucesso";
        }


        public int Post(CategoriaModel categoriaModel)
        {
            return 1231321;
        }


        public void Put(int id, CategoriaModel categoriaModel)
        {

        }


    }
}
