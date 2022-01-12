using Dotnet.Api.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }


        //public async Task
    }
}
