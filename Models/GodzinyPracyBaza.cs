using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.Models
{
    public class GodzinyPracyBaza : IGodzinyPracy
    {
        private readonly AppDbContext context;
        public GodzinyPracyBaza(AppDbContext context)
        {
            this.context = context;
        }
        public AppDbContext Context { get; }

        public GodzinyPracy Edit(GodzinyPracy EditedGodziny)
        {
            var time = context.GodzinyPracy.Attach(EditedGodziny);
            time.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return EditedGodziny;
        }

        public IEnumerable<GodzinyPracy> GetAll()
        {
            return context.GodzinyPracy;
        }

        public GodzinyPracy GetOne(Dzien dzien)
        {
            return context.GodzinyPracy.Find(dzien);
        }
    }
}
