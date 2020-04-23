using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBuy.Repository.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder
                .Property(p => p.Preco)
                .IsRequired();
        }
    }
}
