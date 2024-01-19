using Fiap.Api.Donation2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Fiap.Api.Donation2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private static readonly string endpoint = "https://5cb544bd07f233001424ceb8.mockapi.io/fiap/curso";

        [HttpGet]
        public async Task<string> GetAsync()
        {
            #region GET ALL - Obtendo uma lista
            //HttpClient client = new HttpClient();   

            //var resposta = await client.GetAsync(endpoint);

            //if ( resposta != null && resposta.IsSuccessStatusCode) { 
            //    var conteudo = await resposta.Content.ReadAsStringAsync(); // texto Json
            //    var cursos = JsonConvert.DeserializeObject<List<CursoModel>>(conteudo);
            //    Console.WriteLine("Lista de cursos obtida com sucesso: " + cursos.Count());
            //} 
            //else
            //{
            //    Console.WriteLine("Erro - Não foi possível obter os dados dos cursos.");
            //}
            #endregion

            #region GET BY ID
            //HttpClient client = new HttpClient();

            //var idCurso = 1;
            //var resposta = await client.GetAsync($"{endpoint}/{idCurso}");

            //if (resposta != null && resposta.IsSuccessStatusCode)
            //{
            //    var conteudo = await resposta.Content.ReadAsStringAsync(); // texto Json
            //    var curso = JsonConvert.DeserializeObject<CursoModel>(conteudo);
            //}
            #endregion

            #region POST - Cadastrar um curso
            //var curso = new CursoModel() { 
            //    Id = "10",
            //    Nome = "Node JS",
            //    Nivel = "Básico",
            //    Concluido = false,
            //    Conteudo = "Texto sobre o conteúdo do curso",
            //    PercentualConclusao = 10,
            //    Preco = "99.5"
            //};

            //HttpClient client = new HttpClient();

            //var conteudoJson = JsonConvert.SerializeObject(curso);
            //var conteudoJsonString = new StringContent(conteudoJson, Encoding.UTF8, "application/json");

            //var resposta = await client.PostAsync(endpoint, conteudoJsonString);

            //if ( resposta != null && resposta.IsSuccessStatusCode )
            //{
            //    var respostaSucesso = await resposta.Content.ReadAsStringAsync();
            //    var cursoCadastrado = JsonConvert.DeserializeObject<CursoModel>(respostaSucesso);
            //    Console.WriteLine(cursoCadastrado.Id);
            //}

            #endregion

            #region PUT - Cadastrar um curso
            //var curso = new CursoModel()
            //{
            //    Id = "9",
            //    Nome = "Node JS 2",
            //    Nivel = "Básico",
            //    Concluido = false,
            //    Conteudo = "Texto sobre o conteúdo do curso",
            //    PercentualConclusao = 10,
            //    Preco = "1299.5"
            //};

            //HttpClient client = new HttpClient();

            //var conteudoJson = JsonConvert.SerializeObject(curso);
            //var conteudoJsonString = new StringContent(conteudoJson, Encoding.UTF8, "application/json");

            //var resposta = await client.PutAsync( $"{endpoint}/{curso.Id}", conteudoJsonString);

            //if (resposta != null && resposta.IsSuccessStatusCode)
            //{
            //    var respostaSucesso = await resposta.Content.ReadAsStringAsync();
            //    var cursoCadastrado = JsonConvert.DeserializeObject<CursoModel>(respostaSucesso);
            //    Console.WriteLine(cursoCadastrado.Id);
            //}
            #endregion

            #region DELETE
            //HttpClient client = new HttpClient();

            //var idCurso = 9;
            //var resposta = await client.DeleteAsync($"{endpoint}/{idCurso}");

            //if (resposta != null && resposta.IsSuccessStatusCode)
            //{
            //    var conteudo = await resposta.Content.ReadAsStringAsync(); // texto Json
            //    Console.WriteLine(conteudo);    
            //}
            #endregion

            return "GET";
        }



        [HttpGet]
        [Route("get/{p1}/detail/{p2}")]
        public async Task<string> GetAsync(string p1, string p2)
        {
            return $"GET: {p1} - Details: {p2}";
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
