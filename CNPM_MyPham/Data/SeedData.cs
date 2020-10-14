using System.Collections.Generic;
using System.Linq;
using CNPM_MyPham.Models;

namespace CNPM_MyPham.Data
{
    public class SeedData
    {
        public static void Initialize(MyphamDbContext context){
            context.Database.EnsureCreated();
            bool temp = false;
            if(!context.KhachHangs.Any()){
                temp = true;
                context.KhachHangs.AddRange(new List<KhachHang>{
                    new KhachHang{
                        user = "thien",
                        pass = "1234",
                        repass = "1234",
                        full_name = "Nguyễn Ngọc Thiện",
                        phone = "0364117408",
                        mail = "tructruong.070202@gmail.com",
                        address = "Bình Định",
                        sex = "Nam",
                        dateborn = new System.DateTime(2000, 5, 8),
                        status = 1
                    },
                    new KhachHang{
                        user = "thinh",
                        pass = "1234",
                        repass = "1234",
                        full_name = "Nguyễn Ngọc Thịnh",
                        phone = "0364117408",
                        mail = "thinhxamlon@gmail.com",
                        address = "Miền Tây",
                        sex = "Nam",
                        dateborn = new System.DateTime(2000, 5, 8),
                        status = 1
                    },
                    new KhachHang{
                        user = "phat",
                        pass = "1234",
                        repass = "1234",
                        full_name = "Nguyễn Tấn Phát",
                        phone = "0364117408",
                        mail = "phatxam@gmail.com",
                        address = "Bình Dương",
                        sex = "Nam",
                        dateborn = new System.DateTime(2000, 5, 8),
                        status = 1
                    }
                });
            }

            if(temp){
                context.SaveChanges();
            }
        }
    }
}