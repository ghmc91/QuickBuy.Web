﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuickBuy.Repository.Context;

namespace QuickBuy.Repository.Migrations
{
    [DbContext(typeof(QuickBuyContext))]
    [Migration("20200421153058_CargaFormaPagamento")]
    partial class CargaFormaPagamento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("QuickBuy.Domain.Entities.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("ItensPedidos");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataPrevisaoEntrega")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EnderecoCompleto")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<int>("FormaPagamentoId")
                        .HasColumnType("int");

                    b.Property<int>("NumeroEndereco")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FormaPagamentoId");

                    b.HasIndex("UserId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("QuickBuy.Domain.ObjetoDeValor.FormaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("FormasPagamentos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Forma de pagamento boleto",
                            Nome = "Boleto"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Forma de cartão de crédito",
                            Nome = "Cartão de Crédito"
                        });
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.ItemPedido", b =>
                {
                    b.HasOne("QuickBuy.Domain.Entities.Pedido", null)
                        .WithMany("ItensPedido")
                        .HasForeignKey("PedidoId");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.Pedido", b =>
                {
                    b.HasOne("QuickBuy.Domain.ObjetoDeValor.FormaPagamento", "FormaPagamento")
                        .WithMany()
                        .HasForeignKey("FormaPagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuickBuy.Domain.Entities.User", "User")
                        .WithMany("Pedidos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
