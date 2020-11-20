using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class LoaiSanPhamEFContext : ILoaiSanPhamEFContext
    {
        private readonly MyphamDbContext context;

        public LoaiSanPhamEFContext(MyphamDbContext context){
            this.context = context;
        }

        public List<LoaiSanPham> LoaiSanPham_GetAll(){
            return context.LoaiSanPhams.ToList();
        }

        public LoaiSanPham LoaiSanPham_GetById(int id){
            return context.LoaiSanPhams.Find(id);
        }

        public void LoaiSanPham_Add(LoaiSanPham LSP){
            context.LoaiSanPhams.Add(LSP);
            context.SaveChanges();
        }

        public void SanPham_Update(LoaiSanPham LSP){
            context.LoaiSanPhams.Update(LSP);
            context.SaveChanges();
        }

        public void LoaiSanPham_Remove(LoaiSanPham LSP){
            context.LoaiSanPhams.Remove(LSP);
            context.SaveChanges();
        }
    }
}