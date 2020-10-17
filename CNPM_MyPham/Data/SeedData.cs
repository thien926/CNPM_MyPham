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

            if(!context.LoaiSanPhams.Any()){
                temp = true;
                context.LoaiSanPhams.AddRange(new List<LoaiSanPham>{
                    new LoaiSanPham{
                        name = "Trang điểm",
                        description = "Gồm set trang điểm mắt, mặt, môi"
                    },
                    new LoaiSanPham{
                        name = "Dưỡng da",
                        description = "Gồm bộ rửa mặt, mặt nạ, dưỡng ẩm, dưỡng môi, chống nắng"
                    },
                    new LoaiSanPham{
                        name = "Cơ thể",
                        description = "Gồm dưỡng thể, sữa tắm"
                    },
                    new LoaiSanPham{
                        name = "Dưỡng tóc",
                        description = "Gồm dầu gội, dầu xả, tạo kiểu, dưỡng tóc"
                    },
                    new LoaiSanPham{
                        name = "Cọ và phụ kiện",
                        description = "Gồm cọ và bọt biển"
                    },
                    new LoaiSanPham{
                        name = "Nước hoa",
                        description = "Gồm những loại nước hoa cao cấp tới trung bình"
                    }
                });
            }

            if(!context.SanPhams.Any()){
                temp = true;
                context.SanPhams.AddRange(new List<SanPham>{
                    new SanPham{
                        product_id = 1,
                        product_type_id = 1,
                        brand_id = 1,
                        name = "Lustre Eyeshadow Base",
                        amount = 50,
                        price = 200000,
                        description = "Sản phẩm kem lót mắt Lustre có kết cấu mỏng, nhẹ, dễ dàng tán đều trên mí mắt. Lustre Eyeshadow Base giúp giữ màu phấn mắt lên màu chuẩn và lâu trôi, đồng thời bảo vệ mắt khỏi hiện tượng bị kích ứng",
                        use = "Bôi một lớp mỏng sản phẩm lên vùng mí mắt bằng ngón tay hoặc cọ có đầu mỏng như Lustre Pro Makeup Brush E103 Eyeshadow Brush.Tán đều sản phẩm, đợi đến khi khô mới sử dụng phấn mắt",
                        img = "~/image/sp0.jpg"
                    }
                });
            }

            if(!context.ThuongHieus.Any()){
                temp = true;
                context.ThuongHieus.AddRange(new List<ThuongHieu>{
                    new ThuongHieu{
                        brand_id = 1,
                        name = "LUSTRE MAKEUP"
                    }
                });
            }

            // if(!context.ThuongHieuAndSanPhams.Any()){
            //     temp = true;
            //     context.ThuongHieuAndSanPhams.AddRange(new List<ThuongHieuAndSanPham>{
            //         new ThuongHieuAndSanPham{
            //             brand_id = 1,
            //             product_id = 1
            //         }
            //     });
            // }

            if(temp){
                context.SaveChanges();
            }

        }
    }
}