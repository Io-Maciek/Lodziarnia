using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.Models
{
    public class GodzinyPracyEditAllArray
    {
        public IEnumerable<GodzinyPracy> GodzinyAll { get; set; }
        public GodzinyPracyEditAllArray(IEnumerable<GodzinyPracy> WszystkieGodziny_ARRAY)
        {
            GodzinyAll = WszystkieGodziny_ARRAY;
        }
        public IEnumerable<GodzinyPracy> ReturnAll()
        {
            return GodzinyAll;
        }
    }
}
