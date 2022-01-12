using Dotnet.Api.Application.Interface;
using Dotnet.Api.Domain.Entity;
using Dotnet.Api.Domain.Interfaces;

namespace Dotnet.Api.Application.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<IList<Produto>> GetProdutos()
        {
            return await _produtoRepository.GetAll();
        }
    }
}
