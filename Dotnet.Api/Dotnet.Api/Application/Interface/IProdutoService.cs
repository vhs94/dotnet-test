using Dotnet.Api.Domain.Entity;

namespace Dotnet.Api.Application.Interface
{
    public interface IProdutoService
    {
        Task<IList<Produto>> GetProdutos();
    }
}
