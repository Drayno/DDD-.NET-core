﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoDDDCore.Infra.Data.Context;

namespace ProjetoDDDCore.Infra.Data.Migrations
{
    [DbContext(typeof(ProjetoContext))]
    partial class ProjetoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoDDDCore.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CL_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnName("CL_DATA_CADASTRO");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("CL_EMAIL")
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("CL_NOME")
                        .HasMaxLength(255);

                    b.Property<string>("SobreNome")
                        .HasColumnName("CL_SOBRENOME")
                        .HasMaxLength(100);

                    b.HasKey("ClienteId");

                    b.ToTable("TB_CLIENTES");
                });

            modelBuilder.Entity("ProjetoDDDCore.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("U_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("U_NOME")
                        .HasMaxLength(100);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("U_SENHA")
                        .HasMaxLength(100);

                    b.HasKey("UsuarioId");

                    b.ToTable("TB_USUARIOS");
                });
#pragma warning restore 612, 618
        }
    }
}