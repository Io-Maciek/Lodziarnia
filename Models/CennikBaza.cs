using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.Models
{
    public class CennikBaza : ICennik
    {
        private readonly AppDbContext context;
        public CennikBaza(AppDbContext context)
        {
            this.context = context;
        }
        public AppDbContext Context { get; }
        public Cennik Edit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cennik> GetCennik()
        {
            throw new NotImplementedException();
        }
    }
}
