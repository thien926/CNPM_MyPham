using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class NhanVienEFContext : INhanVienEFContext
    {
        private readonly MyphamDbContext context;
        public NhanVienEFContext(MyphamDbContext context){
            this.context = context;
        }
        public void NhanVien_Add(NhanVien NV)
        {
            context.NhanViens.Add(NV);
            context.SaveChanges();
        }

        public List<NhanVien> NhanVien_GetAll()
        {
            return context.NhanViens.ToList();
        }

        public NhanVien NhanVien_GetByUser(string user)
        {
            return context.NhanViens.Find(user);
        }

        public void NhanVien_Remove(NhanVien NV)
        {
            context.NhanViens.Remove(NV);
            context.SaveChanges();
        }

        public void NhanVien_Update(NhanVien NV)
        {
            context.NhanViens.Update(NV);
            context.SaveChanges();
        }
    }
}