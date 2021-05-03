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
    [Migration("20210304142636_1.0v")]
    partial class _10v
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
                            GodzinaEnd = 0,
                            GodzinaStart = 0,
                            MinutaEnd = 0,
                            MinutaStart = 0
                        },
                        new
                        {
                            DzienID = 1,
                            GodzinaEnd = 0,
                            GodzinaStart = 0,
                            MinutaEnd = 0,
                            MinutaStart = 0
                        },
                        new
                        {
                            DzienID = 2,
                            GodzinaEnd = 0,
                            GodzinaStart = 0,
                            MinutaEnd = 0,
                            MinutaStart = 0
                        },
                        new
                        {
                            DzienID = 3,
                            GodzinaEnd = 0,
                            GodzinaStart = 0,
                            MinutaEnd = 0,
                            MinutaStart = 0
                        },
                        new
                        {
                            DzienID = 4,
                            GodzinaEnd = 0,
                            GodzinaStart = 0,
                            MinutaEnd = 0,
                            MinutaStart = 0
                        },
                        new
                        {
                            DzienID = 5,
                            GodzinaEnd = 0,
                            GodzinaStart = 0,
                            MinutaEnd = 0,
                            MinutaStart = 0
                        },
                        new
                        {
                            DzienID = 6,
                            GodzinaEnd = 0,
                            GodzinaStart = 0,
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
