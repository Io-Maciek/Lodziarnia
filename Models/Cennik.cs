using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.Models
{
    
    public class Cennik
    {
        public KategoriaLoda KategoriaLoda { get; set; }
        public string RodzajLoda { get; set; }
        public double Cena { get; set; }

        public ICollection<LodKategoria> LodKategoria { get; set; }

    }
}
