using System.Collections.Generic;
using System.Linq;
using CNPM_MyPham.Models;

namespace CNPM_MyPham.Data
{
    public class KhachHangEFContext
    {
        private readonly MyphamDbContext context;
        public KhachHangEFContext(MyphamDbContext context){
            this.context = context;
        }

        public List<KhachHang> KhachHang_getall(){
            return context.KhachHangs.ToList();
        }

        public KhachHang KhachHang_GetByUser(string user){
            return context.KhachHangs.Find(user);
        }
    }
}