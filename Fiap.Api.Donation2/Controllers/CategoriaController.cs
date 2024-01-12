using Fiap.Api.Donation2.Models;
using Fiap.Api.Donation2.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.Donation2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;      
        }


        [HttpGet]
        public List<CategoriaModel> Get()
        {
            return (List<CategoriaModel>) _categoriaRepository.FindAll();
        }


        [HttpGet("{id:int}")]
        public CategoriaModel Get([FromRoute] int id)
        {
            var categoria = _categoriaRepository.FindById(id);
            return categoria;
        }

        [HttpDelete("{id:int}")]
        public string Delete([FromRoute] int id)
        {
            _categoriaRepository.Delete(id);

            return "Categoria removida com sucesso";
        }

        [HttpPost]
        public int Post([FromBody] CategoriaModel categoriaModel)
        {
            _categoriaRepository.Insert(categoriaModel);
            return categoriaModel.CategoriaId;
        }


        [HttpPut("{id:int}")]
        public bool Put([FromBody] CategoriaModel categoriaModel , [FromRoute] int id)
        {
            if ( id == categoriaModel.CategoriaId )
            {
                _categoriaRepository.Update(categoriaModel);

                return true;
            } else
            {
                return false;
            }
        }


    }
}
