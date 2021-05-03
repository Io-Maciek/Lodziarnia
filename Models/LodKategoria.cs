using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.Models
{
    public class LodKategoria
    {
        public int SmakID { get; set; }
        public Lody lody { get; set; }
        public string RodzajLoda { get; set; }
        public Cennik cennik { get; set; }


    }
}
