﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiIgreja;

namespace WebApiIgreja.Migrations
{
    [DbContext(typeof(MyWebAppContext))]
    partial class MyWebAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApiIgreja.AcessoDados.Entidades.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnoFilme");

                    b.Property<double>("Classificacao");

                    b.Property<string>("Descricao");

                    b.Property<string>("Diretor");

                    b.Property<string>("Genero");

                    b.Property<string>("Imagem");

                    b.Property<string>("Nome");

                    b.Property<string>("Trailer");

                    b.HasKey("Id");

                    b.ToTable("Filmes");
                });
#pragma warning restore 612, 618
        }
    }
}
