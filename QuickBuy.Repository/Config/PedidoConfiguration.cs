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
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.DataPedido)
                .IsRequired();

            builder
                .Property(p => p.DataPrevisaoEntrega)
                .IsRequired();

            builder
                .Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder
                .Property(p => p.Cidade)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder
                .Property(p => p.Estado)
                .IsRequired()
                .HasColumnType("varchar(15)");

            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasColumnType("varchar(10)");

        }
    }
}
