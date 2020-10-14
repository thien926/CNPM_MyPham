using CNPM_MyPham.Models;
using Microsoft.EntityFrameworkCore;

namespace CNPM_MyPham.Data
{
    public class MyphamDbContext : DbContext
    {
        public MyphamDbContext(DbContextOptions<MyphamDbContext> options) : base(options){

        }

        public DbSet<KhachHang> KhachHangs{get; set;}
    }
}