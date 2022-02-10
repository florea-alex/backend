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
    [Migration("20211217201158_AddedAngajat")]
    partial class AddedAngajat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proiect.DAL.Entities.Angajat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("MagazinId")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("MagazinId");

                    b.ToTable("Angajati");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Autori");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.Biografie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("An_nastere")
                        .HasColumnType("int");

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<string>("Loc_nastere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationalitate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume_real")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AutorId")
                        .IsUnique();

                    b.ToTable("Biografie");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.Carte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DescriereId")
                        .HasColumnType("int");

                    b.Property<int?>("EdituraId")
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

                    b.HasIndex("EdituraId");

                    b.ToTable("Carti");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.CarteAutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<int>("CarteID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("CarteID");

                    b.ToTable("CarteAutori");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.CarteMagazin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarteId")
                        .HasColumnType("int");

                    b.Property<int>("MagazinId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarteId");

                    b.HasIndex("MagazinId");

                    b.ToTable("CarteMagazine");
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

            modelBuilder.Entity("Proiect.DAL.Entities.Editura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("CarteId")
                        .HasColumnType("int");

                    b.Property<string>("Cod_postal")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Denumire")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Edituri");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.Magazin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("AngajatId")
                        .HasColumnType("int");

                    b.Property<string>("Cod_postal")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Magazine");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.Angajat", b =>
                {
                    b.HasOne("Proiect.DAL.Entities.Magazin", "Magazin")
                        .WithMany("Angajati")
                        .HasForeignKey("MagazinId");

                    b.Navigation("Magazin");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.Biografie", b =>
                {
                    b.HasOne("Proiect.DAL.Entities.Autor", "Autor")
                        .WithOne("Biografie")
                        .HasForeignKey("Proiect.DAL.Entities.Biografie", "AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.Carte", b =>
                {
                    b.HasOne("Proiect.DAL.Entities.Descriere", "Descriere")
                        .WithOne("Carte")
                        .HasForeignKey("Proiect.DAL.Entities.Carte", "DescriereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect.DAL.Entities.Editura", "Editura")
                        .WithMany("Carti")
                        .HasForeignKey("EdituraId");

                    b.Navigation("Descriere");

                    b.Navigation("Editura");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.CarteAutor", b =>
                {
                    b.HasOne("Proiect.DAL.Entities.Carte", "Carte")
                        .WithMany("CarteAutori")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect.DAL.Entities.Autor", "Autor")
                        .WithMany("CarteAutori")
                        .HasForeignKey("CarteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Carte");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.CarteMagazin", b =>
                {
                    b.HasOne("Proiect.DAL.Entities.Magazin", "Magazin")
                        .WithMany("CarteMagazine")
                        .HasForeignKey("CarteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect.DAL.Entities.Carte", "Carte")
                        .WithMany("CarteMagazine")
                        .HasForeignKey("MagazinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carte");

                    b.Navigation("Magazin");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.Autor", b =>
                {
                    b.Navigation("Biografie");

                    b.Navigation("CarteAutori");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.Carte", b =>
                {
                    b.Navigation("CarteAutori");

                    b.Navigation("CarteMagazine");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.Descriere", b =>
                {
                    b.Navigation("Carte");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.Editura", b =>
                {
                    b.Navigation("Carti");
                });

            modelBuilder.Entity("Proiect.DAL.Entities.Magazin", b =>
                {
                    b.Navigation("Angajati");

                    b.Navigation("CarteMagazine");
                });
#pragma warning restore 612, 618
        }
    }
}
