﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect.DAL;

namespace Proiect.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211217183010_AddedCarte")]
    partial class AddedCarte
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proiect.DAL.Entities.Carte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DescriereId")
                        .HasColumnType("int");

                    b.Property<int>("ISBN")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("DescriereId")
                        .IsUnique();

                    b.ToTable("Carti");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.Descriere", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("An_aparitie")
                        .HasColumnType("int");

                    b.Property<string>("Gen_principal")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("Nota")
                        .HasColumnType("decimal(2,1)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int?>("Recomandare")
                        .HasColumnType("int");

                    b.Property<int>("Volum")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Descriere");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.Carte", b =>
                {
                    b.HasOne("Proiect.DAL.Entities.Descriere", "Descriere")
                        .WithOne("Carte")
                        .HasForeignKey("Proiect.DAL.Entities.Carte", "DescriereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Descriere");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.Descriere", b =>
                {
                    b.Navigation("Carte");
                });
#pragma warning restore 612, 618
        }
    }
}