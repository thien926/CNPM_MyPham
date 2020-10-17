using System.Collections.Generic;
using System.Linq;
using CNPM_MyPham.Models;

namespace CNPM_MyPham.Data
{
    public class ThuongHieuEFContext
    {
        private readonly MyphamDbContext context;

        public ThuongHieuEFContext(MyphamDbContext context){
            this.context = context;
        }

        public List<ThuongHieu> ThuongHieu_GetAll(){
            return context.ThuongHieus.ToList();
        }

        public ThuongHieu ThuongHieu_GetById(int id){
            return context.ThuongHieus.Find(id);
        }

        public void ThuongHieu_Add(ThuongHieu TH){
            context.ThuongHieus.Add(TH);
            context.SaveChanges();
        }

        public void ThuongHieu_Update(ThuongHieu TH){
            context.ThuongHieus.Update(TH);
            context.SaveChanges();
        }

        public void ThuongHieu_Remove(ThuongHieu TH){
            context.ThuongHieus.Remove(TH);
            context.SaveChanges();
        }
    }
}