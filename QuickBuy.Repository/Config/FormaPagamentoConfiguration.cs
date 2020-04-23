using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.ObjetoDeValor;

namespace QuickBuy.Repository.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder
                .HasKey(f => f.Id);

            builder
                .Property(f => f.Nome)
                .IsRequired()
                .HasColumnType("varchar(20)");
        }
    }
}
