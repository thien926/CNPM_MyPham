using System.Collections.Generic;
using System.Linq;
using Domain.Entities;

namespace Infrastructure.Persistence
{
    public class KhachHangEFContext
    {
        private readonly MyphamDbContext context;
        public KhachHangEFContext(MyphamDbContext context){
            this.context = context;
        }

        public List<KhachHang> KhachHang_GetAll(){
            return context.KhachHangs.ToList();
        }

        public KhachHang KhachHang_GetByUser(string user){
            return context.KhachHangs.Find(user);
        }

        public void KhachHang_Add(KhachHang U){
            context.KhachHangs.Add(U);
            context.SaveChanges();
        }

        public void KhachHang_Update(KhachHang U){
            context.KhachHangs.Update(U);
            context.SaveChanges();
        }

        public void KhachHang_Remove(KhachHang U){
            context.KhachHangs.Remove(U);
            context.SaveChanges();
        }
    }
}