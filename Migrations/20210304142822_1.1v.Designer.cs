﻿// <auto-generated />
using Lodziarnia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lodziarnia.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210304142822_1.1v")]
    partial class _11v
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
                    b.Property<int>("UseLessKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Duzy")
                        .HasColumnType("float");

                    b.Property<double>("Galka")
                        .HasColumnType("float");

                    b.Property<double>("Maly")
                        .HasColumnType("float");

                    b.Property<double>("Sredni")
                        .HasColumnType("float");

                    b.HasKey("UseLessKey");

                    b.ToTable("Cennik");

                    b.HasData(
                        new
                        {
                            UseLessKey = 1,
                            Duzy = 5.0,
                            Galka = 3.5,
                            Maly = 3.5,
                            Sredni = 4.5
                        });
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

                    b.HasData(
                        new
                        {
                            DzienID = 0,
                            GodzinaEnd = 16,
                            GodzinaStart = 10,
                            MinutaEnd = 30,
                            MinutaStart = 0
                        },
                        new
                        {
                            DzienID = 1,
                            GodzinaEnd = 13,
                            GodzinaStart = 9,
                            MinutaEnd = 50,
                            MinutaStart = 45
                        },
                        new
                        {
                            DzienID = 2,
                            GodzinaEnd = 23,
                            GodzinaStart = 17,
                            MinutaEnd = 30,
                            MinutaStart = 0
                        },
                        new
                        {
                            DzienID = 3,
                            GodzinaEnd = 23,
                            GodzinaStart = 12,
                            MinutaEnd = 0,
                            MinutaStart = 30
                        },
                        new
                        {
                            DzienID = 4,
                            GodzinaEnd = 20,
                            GodzinaStart = 18,
                            MinutaEnd = 0,
                            MinutaStart = 12
                        },
                        new
                        {
                            DzienID = 5,
                            GodzinaEnd = 23,
                            GodzinaStart = 8,
                            MinutaEnd = 0,
                            MinutaStart = 2
                        },
                        new
                        {
                            DzienID = 6,
                            GodzinaEnd = 21,
                            GodzinaStart = 15,
                            MinutaEnd = 0,
                            MinutaStart = 0
                        });
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

                    b.HasKey("SmakID");

                    b.ToTable("Lody");

                    b.HasData(
                        new
                        {
                            SmakID = 1,
                            SmakAlkohol = false,
                            SmakDostepny = true,
                            SmakNazwa = "Truskawkowy",
                            SmakOpis = "Sorbet z soczystych polskich truskawek!"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
