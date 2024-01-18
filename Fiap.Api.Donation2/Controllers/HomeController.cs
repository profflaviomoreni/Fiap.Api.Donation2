using Fiap.Api.Donation2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.Donation2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public async Task<string> GetAsync()
        {
            return "GET";
        }

        [HttpPost]
        public string Post()
        {
            return "POST";
        }


        [HttpPut]
        public string Put()
        {
            return "PUT";
        }


        [HttpDelete]
        public string Delete()
        {
            return "DELETE";
        }


    }
}
