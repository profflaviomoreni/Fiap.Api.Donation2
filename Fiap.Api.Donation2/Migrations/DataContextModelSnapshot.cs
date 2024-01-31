﻿// <auto-generated />
using System;
using Fiap.Api.Donation2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fiap.Api.Donation2.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fiap.Api.Donation2.Models.CategoriaModel", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Fiap.Api.Donation2.Models.ProdutoModel", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdutoId"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataExpiracao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SugestaoTroca")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("ProdutoId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("DataCadastro");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            ProdutoId = 1,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1919),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1921),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 1",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 2,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1934),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1934),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 2",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 3,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1937),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1938),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 3",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 4,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1940),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1941),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 4",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 5,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1943),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1944),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 5",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 6,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1946),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1946),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 6",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 7,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1948),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1949),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 7",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 8,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1951),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1951),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 8",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 9,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1953),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1953),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 9",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 10,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1955),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1956),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 10",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 11,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1957),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1958),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 11",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 12,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1960),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1960),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 12",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 13,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1962),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1963),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 13",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 14,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1964),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1965),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 14",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 15,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1967),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1967),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 15",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 16,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1969),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1969),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 16",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 17,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1971),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1972),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 17",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 18,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1973),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1974),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 18",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 19,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1976),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1976),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 19",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 20,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1978),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1979),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 20",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 21,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1980),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1981),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 21",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 22,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1983),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1983),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 22",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 23,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1985),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1986),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 23",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 24,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1987),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1988),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 24",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 25,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1990),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1990),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 25",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 26,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1992),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1992),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 26",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 27,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1994),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1995),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 27",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 28,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1996),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1997),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 28",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 29,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1999),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1999),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 29",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 30,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(2047),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(2048),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 30",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        },
                        new
                        {
                            ProdutoId = 31,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(2050),
                            DataExpiracao = new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(2051),
                            Descricao = "Descrição",
                            Disponivel = true,
                            Nome = "Produto 31",
                            SugestaoTroca = "Sugestão de troca",
                            UsuarioId = 1,
                            Valor = 1.0
                        });
                });

            modelBuilder.Entity("Fiap.Api.Donation2.Models.TrocaModel", b =>
                {
                    b.Property<Guid>("TrocaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProdutoId1")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId2")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("TrocaId");

                    b.HasIndex("ProdutoId1");

                    b.HasIndex("ProdutoId2");

                    b.ToTable("Troca");
                });

            modelBuilder.Entity("Fiap.Api.Donation2.Models.UsuarioModel", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Regra")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Fiap.Api.Donation2.Models.ProdutoModel", b =>
                {
                    b.HasOne("Fiap.Api.Donation2.Models.CategoriaModel", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fiap.Api.Donation2.Models.UsuarioModel", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Fiap.Api.Donation2.Models.TrocaModel", b =>
                {
                    b.HasOne("Fiap.Api.Donation2.Models.ProdutoModel", "ProdutoModel1")
                        .WithMany()
                        .HasForeignKey("ProdutoId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fiap.Api.Donation2.Models.ProdutoModel", "ProdutoModel2")
                        .WithMany()
                        .HasForeignKey("ProdutoId2")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProdutoModel1");

                    b.Navigation("ProdutoModel2");
                });
#pragma warning restore 612, 618
        }
    }
}
