using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.Models
{
    public interface ICennik
    {
        IEnumerable<Cennik> GetCennik();
        Cennik Edit();
    }
}
