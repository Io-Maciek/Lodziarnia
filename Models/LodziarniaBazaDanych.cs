using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.Models
{
    public class LodziarniaBazaDanych : ILody
    {
        private readonly AppDbContext context;
        public LodziarniaBazaDanych(AppDbContext context)
        {
            this.context = context;
        }
        public AppDbContext Context { get; }

        public Lody AddNew(Lody Lod)
        {
            context.Lody.Add(Lod);
            context.SaveChanges();
            return Lod;
        }

        public Lody Delete(Lody UsuwanyLod)
        {
            throw new NotImplementedException();
        }

        public Lody Edit(Lody EdytowanyLod)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lody> GetAll()
        {
            return context.Lody;
        }

        public Lody GetByID(int id)
        {
            return context.Lody.Find(id);
        }
    }
}
