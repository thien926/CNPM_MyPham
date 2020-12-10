using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class NCCEFContext : INCCEFContext
    {
        private readonly MyphamDbContext context;
        public NCCEFContext(MyphamDbContext context){
            this.context = context;
        }
        public void NCC_Add(NCC ncc)
        {
            context.NCCs.Add(ncc);
            context.SaveChanges();
        }

        public List<NCC> NCC_GetAll()
        {
            return context.NCCs.ToList();
        }

        public NCC NCC_GetById(int id)
        {
            return context.NCCs.Find(id);
        }

        public void NCC_Remove(NCC ncc)
        {
            context.NCCs.Remove(ncc);
            context.SaveChanges();
        }

        public void NCC_Update(NCC ncc)
        {
            context.NCCs.Update(ncc);
            context.SaveChanges();
        }
    }
}