﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Supremo.Models;

namespace Supremo.Migrations
{
    [DbContext(typeof(MyWebAppContext))]
    [Migration("20180925172342_MyWebAppMigration")]
    partial class MyWebAppMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Supremo.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataPedido");

                    b.Property<int?>("PedidoId");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Supremo.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.HasKey("Id");

                    b.ToTable("MyProperty");
                });

            modelBuilder.Entity("Supremo.Util.Entidades.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("Supremo.Models.Pedido", b =>
                {
                    b.HasOne("Supremo.Models.Pedido")
                        .WithMany("Pedidos")
                        .HasForeignKey("PedidoId");
                });

            modelBuilder.Entity("Supremo.Util.Entidades.ItemPedido", b =>
                {
                    b.HasOne("Supremo.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");
                });
#pragma warning restore 612, 618
        }
    }
}
