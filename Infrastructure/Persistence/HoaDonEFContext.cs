using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class HoaDonEFContext : IHoaDonEFContext
    {
        private readonly MyphamDbContext context;
        public HoaDonEFContext(MyphamDbContext context){
            this.context = context;
        }
        public void HoaDon_Add(HoaDon U)
        {
            context.HoaDons.Add(U);
            context.SaveChanges();
        }

        public List<HoaDon> HoaDon_GetAll()
        {
            return context.HoaDons.ToList();
        }

        public HoaDon HoaDon_GetById(int id)
        {
            return context.HoaDons.Find(id);
        }

        public void HoaDon_Remove(HoaDon U)
        {
            context.HoaDons.Remove(U);
            context.SaveChanges();
        }

        public void HoaDon_Update(HoaDon U)
        {
            context.HoaDons.Update(U);
            context.SaveChanges();
        }
    }
}