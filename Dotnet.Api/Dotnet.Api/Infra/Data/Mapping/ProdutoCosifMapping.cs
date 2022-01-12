using Dotnet.Api.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotnet.Api.Infra.Data.Mapping
{
    public class ProdutoCosifMapping : IEntityTypeConfiguration<ProdutoCosif>
    {
        public void Configure(EntityTypeBuilder<ProdutoCosif> builder)
        {
            throw new NotImplementedException();
        }
    }
}
