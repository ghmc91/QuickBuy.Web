using Microsoft.EntityFrameworkCore;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.ObjetoDeValor;
using QuickBuy.Repository.Config;

namespace QuickBuy.Repository.Context
{
    public class QuickBuyContext : DbContext
    {

        public DbSet<User> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormasPagamentos { get; set; }

        public QuickBuyContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(new FormaPagamento()
                                                { Id = 1, Nome = "Boleto", Descricao = "Forma de pagamento boleto" },
                                                new FormaPagamento()
                                                { Id = 2, Nome = "Cartão de Crédito", Descricao = "Forma de cartão de crédito" });
            base.OnModelCreating(modelBuilder);
        }



    }
}
