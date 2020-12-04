﻿// <auto-generated />
using System;
using Desafio_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Desafio_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201201171755_AddVendaProduto")]
    partial class AddVendaProduto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Desafio_API.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Documento")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Desafio_API.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CNPJ")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("Desafio_API.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Categoria")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Codigo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<string>("Imagem")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Promocao")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.Property<double>("ValorPromocao")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Desafio_API.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<double>("TotalCompra")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Desafio_API.Models.VendaProduto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("VendaId")
                        .HasColumnType("int");

                    b.HasKey("ProdutoId", "VendaId");

                    b.HasIndex("VendaId");

                    b.ToTable("VendasProdutos");
                });

            modelBuilder.Entity("Desafio_API.Models.Produto", b =>
                {
                    b.HasOne("Desafio_API.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId");
                });

            modelBuilder.Entity("Desafio_API.Models.Venda", b =>
                {
                    b.HasOne("Desafio_API.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Desafio_API.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId");
                });

            modelBuilder.Entity("Desafio_API.Models.VendaProduto", b =>
                {
                    b.HasOne("Desafio_API.Models.Produto", "Produtos")
                        .WithMany("VendaProdutos")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Desafio_API.Models.Venda", "Vendas")
                        .WithMany("VendaProdutos")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
