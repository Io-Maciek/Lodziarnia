using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Lody> Lody { get; set; }
        public DbSet<GodzinyPracy> GodzinyPracy { get; set; }
        public DbSet<Cennik> Cennik { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cennik>().HasKey(prop => prop.RodzajLoda);
                


            modelBuilder.Entity<LodKategoria>()
                .HasKey(bc => new { bc.SmakID, bc.RodzajLoda });
            modelBuilder.Entity<LodKategoria>()
                .HasOne(cl => cl.cennik)
                .WithMany(c => c.LodKategoria)
                .HasForeignKey(cl => cl.RodzajLoda);
            modelBuilder.Entity<LodKategoria>()
                .HasOne(cl => cl.lody)
                .WithMany(c => c.LodKategoria)
                .HasForeignKey(cl => cl.SmakID);



            modelBuilder.Entity<Cennik>().HasData(
                new Cennik { KategoriaLoda = KategoriaLoda.Gałkowy, RodzajLoda = "gałka", Cena = 3.00 },
                 new Cennik { KategoriaLoda = KategoriaLoda.Włoski, RodzajLoda = "mały", Cena = 3.00 },
                 new Cennik { KategoriaLoda = KategoriaLoda.Włoski, RodzajLoda = "średni", Cena = 3.50 },
                 new Cennik { KategoriaLoda = KategoriaLoda.Włoski, RodzajLoda = "duży", Cena = 4.50 }
                 );


            modelBuilder.Entity<Lody>().HasData(
                new Lody { SmakNazwa = "Truskawkowy", SmakOpis = "Sorbet z soczystych polskich truskawek!", SmakID = 1, SmakAlkohol = false, SmakDostepny = true, kategoriaLoda = KategoriaLoda.Gałkowy },
                new Lody { SmakNazwa = "Smerfowy", SmakOpis = "Gargamel by się cieszył!", SmakID = 2, SmakAlkohol = false, SmakDostepny = true, kategoriaLoda = KategoriaLoda.Gałkowy }
                );

            modelBuilder.Entity<GodzinyPracy>().HasData(
                new GodzinyPracy { DzienID=Dzien.Poniedziałek, GodzinaStart=0,MinutaStart=0,GodzinaEnd=0,MinutaEnd=0},
                new GodzinyPracy { DzienID = Dzien.Wtorek, GodzinaStart = 0, MinutaStart = 0, GodzinaEnd = 0, MinutaEnd = 0 },
                new GodzinyPracy { DzienID = Dzien.Środa, GodzinaStart = 0, MinutaStart = 0, GodzinaEnd = 0, MinutaEnd = 0 },
                new GodzinyPracy { DzienID = Dzien.Czwartek, GodzinaStart = 0, MinutaStart = 0, GodzinaEnd = 0, MinutaEnd = 0 },
                new GodzinyPracy { DzienID = Dzien.Piątek, GodzinaStart = 0, MinutaStart = 0, GodzinaEnd = 0, MinutaEnd = 0 },
                new GodzinyPracy { DzienID = Dzien.Sobota, GodzinaStart = 0, MinutaStart = 0, GodzinaEnd = 0, MinutaEnd = 0 },
                new GodzinyPracy { DzienID = Dzien.Niedziela, GodzinaStart = 0, MinutaStart = 0, GodzinaEnd = 0, MinutaEnd = 0 }
                );
        }

        // wiele do wielu

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.EnableSensitiveDataLogging();
        //}


    }
}