using Lodziarnia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.ViewModel
{
    public class Lody_i_Godziny
    {
        public IEnumerable<Lody> Lody { get; set; }
        public IEnumerable<GodzinyPracy> Godziny { get; set; }

        public GodzinyPracy ReturnHourWork(int index)
        {
            return Godziny.ToArray()[index];
        }
    }
}
