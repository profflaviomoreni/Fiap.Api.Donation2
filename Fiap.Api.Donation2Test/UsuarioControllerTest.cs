using Fiap.Api.Donation2.Controllers;
using Fiap.Api.Donation2.Models;
using Fiap.Api.Donation2.Repository.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Fiap.Api.Donation2Test
{
    public class UsuarioControllerTest
    {
        [Fact]
        public async Task GetUsuarioResultOkWithUsuarios()
        {
            var usuarios = new List<UsuarioModel>() {
                new UsuarioModel()
            };
            var mockRepository = new Mock<IUsuarioRepository>();
            mockRepository.Setup(r => r.FindAll()).ReturnsAsync(usuarios);

            var controller = new UsuarioController(mockRepository.Object);

            var result = await controller.GetAsync();

            var resultType = Assert.IsType<OkObjectResult>(result.Result);
            var resultValue = Assert.IsType<List<UsuarioModel>>(resultType.Value);
            
            Assert.Single(resultValue);
            Assert.Equal(1, resultValue.Count);
        }
        
        [Fact]
        public async Task GetUsuarioResultOkWith3Usuarios()
        {
            var usuarios = new List<UsuarioModel>() {
                new UsuarioModel(),
                new UsuarioModel(),
                new UsuarioModel()
            };
            var mockRepository = new Mock<IUsuarioRepository>();
            mockRepository.Setup(r => r.FindAll()).ReturnsAsync(usuarios);

            var controller = new UsuarioController(mockRepository.Object);

            var result = await controller.GetAsync();

            var resultType = Assert.IsType<OkObjectResult>(result.Result);
            var resultValue = Assert.IsType<List<UsuarioModel>>(resultType.Value);
            
            Assert.Equal(3, resultValue.Count);
        }

        [Fact]
        public async Task GetUsuarioResultNoContent()
        {
            var mockRepository = new Mock<IUsuarioRepository>();
            mockRepository.Setup(r => r.FindAll()).ReturnsAsync(new List<UsuarioModel>());

            var controller = new UsuarioController(mockRepository.Object);

            var result = await controller.GetAsync();

            Assert.IsType<NoContentResult>(result.Result);

        }

    }
}