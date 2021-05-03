using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.Models
{
    public interface ILody
    {
        Lody GetByID(int id);
        IEnumerable<Lody> GetAll();
        Lody AddNew(Lody Lod);
        Lody Edit(Lody EdytowanyLod);
        Lody Delete(Lody UsuwanyLod);
    }
}
