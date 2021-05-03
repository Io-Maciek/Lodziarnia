using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.Models
{
    public interface IGodzinyPracy
    {
        IEnumerable<GodzinyPracy> GetAll();
        GodzinyPracy GetOne(Dzien dzien);
        GodzinyPracy Edit(GodzinyPracy EditedGodziny);

    }
}
