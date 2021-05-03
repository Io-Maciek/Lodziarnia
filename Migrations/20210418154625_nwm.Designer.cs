﻿// <auto-generated />
using System;
using Lodziarnia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lodziarnia.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210418154625_nwm")]
    partial class nwm
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lodziarnia.Models.Cennik", b =>
                {
                    b.Property<string>("RodzajLoda")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Cena")
                        .HasColumnType("float");

                    b.Property<int>("KategoriaLoda")
                        .HasColumnType("int");

                    b.HasKey("RodzajLoda");

                    b.ToTable("Cennik");
                });

            modelBuilder.Entity("Lodziarnia.Models.GodzinyPracy", b =>
                {
                    b.Property<int>("DzienID")
                        .HasColumnType("int");

                    b.Property<int>("GodzinaEnd")
                        .HasColumnType("int");

                    b.Property<int>("GodzinaStart")
                        .HasColumnType("int");

                    b.Property<int>("MinutaEnd")
                        .HasColumnType("int");

                    b.Property<int>("MinutaStart")
                        .HasColumnType("int");

                    b.HasKey("DzienID");

                    b.ToTable("GodzinyPracy");
                });

            modelBuilder.Entity("Lodziarnia.Models.LodKategoria", b =>
                {
                    b.Property<int>("SmakID")
                        .HasColumnType("int");

                    b.Property<int>("KategoriaLodaCENNIK")
                        .HasColumnType("int");

                    b.Property<string>("cennikRodzajLoda")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("lodySmakID")
                        .HasColumnType("int");

                    b.HasKey("SmakID", "KategoriaLodaCENNIK");

                    b.HasIndex("cennikRodzajLoda");

                    b.HasIndex("lodySmakID");

                    b.ToTable("LodKategoria");
                });

            modelBuilder.Entity("Lodziarnia.Models.Lody", b =>
                {
                    b.Property<int>("SmakID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SciezkaZdjecia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SmakAlkohol")
                        .HasColumnType("bit");

                    b.Property<bool>("SmakDostepny")
                        .HasColumnType("bit");

                    b.Property<string>("SmakNazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SmakOpis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("kategoriaLoda")
                        .HasColumnType("int");

                    b.HasKey("SmakID");

                    b.ToTable("Lody");

                    b.HasData(
                        new
                        {
                            SmakID = 1,
                            SmakAlkohol = false,
                            SmakDostepny = true,
                            SmakNazwa = "Truskawkowy",
                            SmakOpis = "Sorbet z soczystych polskich truskawek!",
                            kategoriaLoda = 1
                        },
                        new
                        {
                            SmakID = 2,
                            SmakAlkohol = false,
                            SmakDostepny = true,
                            SmakNazwa = "Smerfowy",
                            SmakOpis = "Gargamel by się cieszył!",
                            kategoriaLoda = 1
                        });
                });

            modelBuilder.Entity("Lodziarnia.Models.LodKategoria", b =>
                {
                    b.HasOne("Lodziarnia.Models.Cennik", "cennik")
                        .WithMany("LodKategoria")
                        .HasForeignKey("cennikRodzajLoda");

                    b.HasOne("Lodziarnia.Models.Lody", "lody")
                        .WithMany("LodKategoria")
                        .HasForeignKey("lodySmakID");

                    b.Navigation("cennik");

                    b.Navigation("lody");
                });

            modelBuilder.Entity("Lodziarnia.Models.Cennik", b =>
                {
                    b.Navigation("LodKategoria");
                });

            modelBuilder.Entity("Lodziarnia.Models.Lody", b =>
                {
                    b.Navigation("LodKategoria");
                });
#pragma warning restore 612, 618
        }
    }
}
