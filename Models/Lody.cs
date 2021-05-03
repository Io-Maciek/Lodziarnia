 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.Models
{
    public class Lody
    {
        [Key]
        public int SmakID { get; set; }
        public string SmakNazwa { get; set; }
        public string SmakOpis { get; set; }
        public bool SmakDostepny { get; set; }
        public bool SmakAlkohol { get; set; }
        public string SciezkaZdjecia { get; set; }

        public KategoriaLoda kategoriaLoda { get; set; }

        public ICollection<LodKategoria> LodKategoria { get; set; }

        public Lody()
        {

        }
        public Lody(string nazwa, string opis, bool dostepnosc, bool zawieraAlkohol
            , string sciezkazdjecie, KategoriaLoda kategoriaLoda)
        {
            SmakNazwa = nazwa;
            SmakOpis = opis;
            SmakDostepny = dostepnosc;
            SmakAlkohol = zawieraAlkohol;
            SciezkaZdjecia = sciezkazdjecie;
            this.kategoriaLoda = kategoriaLoda;
        }
    }
}
