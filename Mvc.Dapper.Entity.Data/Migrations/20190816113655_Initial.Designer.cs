﻿// <auto-generated />
using Mvc.Dapper.Entity.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mvc.Dapper.Entity.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190816113655_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mvc.Dapper.Entity.Domain.Entities.Autor", b =>
                {
                    b.Property<int>("ID");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Autor");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Nome = "Eric Evans"
                        },
                        new
                        {
                            ID = 2,
                            Nome = "Robert C. Martin"
                        },
                        new
                        {
                            ID = 3,
                            Nome = "Vaughn Vernon"
                        },
                        new
                        {
                            ID = 4,
                            Nome = "Scott Millet"
                        },
                        new
                        {
                            ID = 5,
                            Nome = "Martin Fowler"
                        });
                });

            modelBuilder.Entity("Mvc.Dapper.Entity.Domain.Entities.Livro", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnoPublicacao");

                    b.Property<int>("AutorID");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("AutorID");

                    b.ToTable("Livro");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AnoPublicacao = 2003,
                            AutorID = 1,
                            Titulo = "Domain-Driven Design: Tackling Complexity in the Heart of Software"
                        },
                        new
                        {
                            ID = 2,
                            AnoPublicacao = 2006,
                            AutorID = 2,
                            Titulo = "Agile Principles, Patterns, and Practices in C#"
                        },
                        new
                        {
                            ID = 3,
                            AnoPublicacao = 2008,
                            AutorID = 2,
                            Titulo = "Clean Code: A Handbook of Agile Software Craftsmanship"
                        },
                        new
                        {
                            ID = 4,
                            AnoPublicacao = 2013,
                            AutorID = 3,
                            Titulo = "Implementing Domain-Driven Design"
                        },
                        new
                        {
                            ID = 5,
                            AnoPublicacao = 2015,
                            AutorID = 4,
                            Titulo = "Patterns, Principles, and Practices of Domain-Driven Design"
                        },
                        new
                        {
                            ID = 6,
                            AnoPublicacao = 2012,
                            AutorID = 5,
                            Titulo = "Refactoring: Improving the Design of Existing Code "
                        });
                });

            modelBuilder.Entity("Mvc.Dapper.Entity.Domain.Entities.Livro", b =>
                {
                    b.HasOne("Mvc.Dapper.Entity.Domain.Entities.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("AutorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
