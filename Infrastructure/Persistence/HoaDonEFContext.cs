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

        public IEnumerable<HoaDon> HoaDon_GetByUser(string user)
        {
            var query = context.HoaDons.AsQueryable();
            query = query.Where(m => m.user_kh == user);
            query = query.OrderByDescending(m => m.date_order);
            return query.ToList();
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
        public int HoaDon_GetMaxId(){
            return context.HoaDons.Max(m => m.bill_id);
        }
    }
}