using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class QuyenEFContext : IQuyenEFContext
    {
        private readonly MyphamDbContext context;

        public QuyenEFContext(MyphamDbContext context){
            this.context = context;
        }
        public void Quyen_Add(Quyen Q)
        {
            context.Quyens.Add(Q);
            context.SaveChanges();
        }

        public List<Quyen> Quyen_GetAll()
        {
            return context.Quyens.ToList();
        }

        public Quyen Quyen_GetById(int id)
        {
            return context.Quyens.Find(id);
        }

        public void Quyen_Remove(Quyen Q)
        {
            context.Quyens.Remove(Q);
            context.SaveChanges();
        }

        public void Quyen_Update(Quyen Q)
        {
            context.Quyens.Update(Q);
            context.SaveChanges();
        }
    }
}