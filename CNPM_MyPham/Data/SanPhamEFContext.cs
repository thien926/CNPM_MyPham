using System.Collections.Generic;
using System.Linq;
using CNPM_MyPham.Models;

namespace CNPM_MyPham.Data
{
    public class SanPhamEFContext
    {
        private readonly MyphamDbContext context;

        public SanPhamEFContext(MyphamDbContext context){
            this.context = context;
        }

        public List<SanPham> SanPham_GetAll(){
            return context.SanPhams.ToList();
        }

        public SanPham SanPham_GetById(int id){
            return context.SanPhams.Find(id);
        }

        public void SanPham_Add(SanPham SP){
            context.SanPhams.Add(SP);
            context.SaveChanges();
        }

        public void SanPham_Update(SanPham SP){
            context.SanPhams.Update(SP);
            context.SaveChanges();
        }

        public void SanPham_Remove(SanPham SP){
            context.SanPhams.Remove(SP);
            context.SaveChanges();
        }
    }
}