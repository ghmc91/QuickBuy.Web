using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);
            
            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder
                .Property(u => u.Sobrenome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.User);



        }
    }
}
