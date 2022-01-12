using Dotnet.Api.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotnet.Api.Infra.Data.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("TBL_PRODUTO")
          .HasKey(k => k.Codigo)
          ;
            builder.Property(p => p.Codigo)
                .HasColumnName("")
                .HasMaxLength(4);
        }
    }
}
