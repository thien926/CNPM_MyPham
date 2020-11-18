using System.Collections.Generic;
using System.Linq;
using Domain.Entities;

namespace Infrastructure.Persistence
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
                    },
                    new SanPham{
                        product_id = 2,
                        product_type_id = 1,
                        brand_id = 2,
                        name = "GOLDEN ROSE EYESHADOW PRIMER",
                        amount = 50,
                        price = 167000,
                        description = "Golden Rose là một nhãn hiệu của tập đoàn Erkul Cosmetics đến từ Thổ Nhĩ Kỳ. Đây là một trong những tập đoàn mỹ phẩm lớn tại Châu Âu và nổi tiếng trên thế giới, chuyên cung cấp các loại mỹ phẩm chăm sóc mặt, mắt, môi, nails, tóc…. Erkul Cosmetics cũng nằm trong số 5 nhà sản xuất các sản phẩm sơn móng tay lớn nhất thế giới và đã vươn tầm thành công ra khỏi biên giới khi xuất khẩu sản phẩm này đến hơn 90 quốc giá trong 5 chậu lục bao gồm: Châu Mỹ, Bắc Phi, Trung Đông, Cộng Đồng Các Quốc Gia Độc Lập, Balkans và Châu Âu.",
                        use = "Sử dụng trước khi make-up mắt, tán trực tiếp lên da - Sau khi được thoa lên mắt, kem primer sẽ mau chóng khô lại tạo finish trong mờ, vì vậy bạn đừng lo ngại mí mắt sẽ trở nên trơn bóng",
                        img = "~/image/sp1.jpg"
                    },
                    new SanPham{
                        product_id = 3,
                        product_type_id = 1,
                        brand_id = 3,
                        name = "Smashbox Cosmetics",
                        amount = 50,
                        price =255000 ,
                        description = "Smashbox Cosmetics là kem lót dành cho mắt thách thức mọi phong cách trang điểm mắt từ nhẹ nhàng, đơn giản đến ombre, màu khói cầu kỳ quyến rũ, sản phẩm vẫn giữ nguyên màu mắt đẹp của bạn suốt ngày dài. Kết cấu dạng kem mịn, có độ bám cao và dễ tán đều trên da.",
                        use = "Sau khi dưỡng ẩm, lấy một lượng kem vừa đủ tán đều khắp bầu mắt trước khi sử dụng phấn mắt.",
                        img = "~/image/sp2.jpg"
                    },
                    new SanPham{
                        product_id = 4,
                        product_type_id = 1,
                        brand_id = 4,
                        name = "Nars Smudge Proof Eyeshadow",
                        amount = 50,
                        price = 510000,
                        description = "Thiết kế vỏ hộp là tông đen và sản phẩm có thiết kế cũng khá đơn giản với tông trắng đen chủ đạo nhưng rất dễ nhìn ra đặc trưng nhờ sự nổi bật của Logo NARS.Có nhiều tone màu lựa chọn chứa ít nhũ nhẹ. Kết cấu của kem lót khá mịn, như kiểu kem dưỡng.",
                        use = "Dùng cọ lấy lượng phấn mắt vừa đủ và đánh lên bầu mắt",
                        img = "~/image/sp3.jpg"
                    },
                    new SanPham{
                        product_id = 5,
                        product_type_id = 1,
                        brand_id = 5,
                        name = "BH Cosmetics Solar Flare",
                        amount = 50,
                        price =688000 ,
                        description = "Bảng phấn mắt BH Cosmetics Solar Flare là một trong ba bảng màu mắt chủ đề Vũ trụ của BH Cosmetics. Bộ sưu tập các gam màu vũ trụ lung linh, ấm áp giúp cho đôi mắt của bạn thêm tỏa sáng rực rỡ. Bảng màu nhiều sắc thái từ màu nude lì đến những gam màu nhũ nóng bỏng tạo chiều sâu cho đôi mắt, thích hợp cho ngày đi làm nhẹ nhàng và những buổi party thật chất.",
                        use = "Dùng cọ lấy lượng phấn mắt vừa đủ và đánh lên bầu mắt. Có thể làm ẩm cọ trước khi lấy phấn để màu lên đậm hơn.Có thể pha trộn màu để tạo nên màu mắt thật khác biệt.",
                        img = "~/image/sp4.jpg"
                    },
                    new SanPham{
                        product_id = 6,
                        product_type_id = 1,
                        brand_id = 5,
                        name = "BH Cosmetics Mini Zodiac",
                        amount = 50,
                        price = 437000,
                        description = "BH Cosmetics Mini Zodiac Aquarius là bảng màu mắt lấy cảm hứng từ cung Bào Bình trong 12 cung hoàng đạo. 9 tông màu khác nhau với một loạt các sắc màu như nâu, nâu đậm, xanh...đến tông màu trắng ánh bạc giúp khơi gợi nên sự quyến rũ độc đáo của riêng bạn.",
                        use = " Dùng cọ lấy lượng phấn mắt vừa đủ và đánh lên bầu mắt.Có thể làm ẩm cọ trước khi lấy phấn để màu lên đậm hơn.Có thể pha trộn màu để tạo nên màu mắt thật khác biệt.",
                        img = "~/image/sp5.jpg"
                    },
                    new SanPham{
                        product_id = 7,
                        product_type_id = 1,
                        brand_id =5 ,
                        name = "BH Cosmetics Blushing In Bali",
                        amount = 50,
                        price = 669000,
                        description = "BH Cosmetics Blushing in Bali là bảng phấn má hồng và tạo khối lấy cảm hứng từ những hòn đảo đầy nắng của Bali. 6 màu phấn hồng và tạo khối của BH Cosmetic cho bạn tất cả những gam màu bạn tìm kiếm. Gồm 2 ô phấn má hồng tươi tắn dễ phối màu và 4 ô tạo khối & bắt sáng giúp tạo nét hài hoà, thanh thoát và thon gọn cho gương mặt.",
                        use = "Chỉ lấy một lượng vừa đủ bám trên bề mặt lông của cọ dùng để đánh má hồng.Bắt đầu bằng cách đặt phấn má lên điểm cao nhất của gò má. Sau đó mỉm cười và quét cọ từ đỉnh ngoài của gò má (phía gần mũi) nhẹ nhàng kéo hướng về phía thái dương. Dùng cọ tán đều phấn má hồng về hướng chân tóc.",
                        img = "~/image/sp6.jpg"
                    },
                    new SanPham{
                        product_id = 8,
                        product_type_id = 1,
                        brand_id = 5,
                        name = "BH Cosmetics Zodiac Love Signs",
                        amount = 50,
                        price = 714000,
                        description = "Bảng phấn mắt BH Cosmetics Zodiac Love Signs với 25 màu bao gồm 12 màu phấn mắt lì mịn, 12 màu phấn nhũ và 1 màu highlight sáng sẽ giúp đôi mắt bạn trông rực rỡ và sống động hơn bao giờ hết. 24 màu mắt trải dài từ các gam màu nóng đến lạnh và các màu thuộc dải ngân hà như màu vàng rựa lửa của mặt trời, màu lục và tím...",
                        use = "Dùng cọ lấy lượng phấn mắt vừa đủ và đánh lên bầu mắt.Có thể làm ẩm cọ trước khi lấy phấn để màu lên đậm hơn.Có thể pha trộn màu để tạo nên màu mắt thật khác biệt.",
                        img = "~/image/sp7.jpg"
                    },
                    new SanPham{
                        product_id = 9,
                        product_type_id = 1,
                        brand_id = 5,
                        name = "BH Cosmetics Foil Eyes",
                        amount = 50,
                        price = 386000,
                        description = "Bảng màu mắt BH Cosmetics Foil Eyes gồm 28 gam màu metallic (kim loại); đây là một bộ sưu tập của sự hoàn hảo; đa chiều và đa sắc tố kim loại. Nó là sự kết hợp của tone neutrals và các loại đá ngọc trai, đá thạch anh lấp lánh đến màu ánh khói đem đến cho người dùng sự choáng ngợp khi trải nghiệm với các tông màu đầy sống động.",
                        use = "Dùng cọ lấy lượng phấn mắt vừa đủ và đánh lên bầu mắt.Có thể làm ẩm cọ trước khi lấy phấn để màu lên đậm hơn.Có thể pha trộn màu để tạo nên màu mắt thật khác biệt.",
                        img = "~/image/sp8.jpg"
                    },
                    new SanPham{
                        product_id = 10,
                        product_type_id = 1,
                        brand_id = 6,
                        name = "M.A.C EYE SHADOW X 15",
                        amount = 50,
                        price = 3088000,
                        description = "M.A.C EYE SHADOW X 15 là bảng màu mắt gồm các tông màu bán chạy nhất của MAC gồm 15 ô màu full size với chất phấn vô cùng mịn mượt cho khả năng lên màu chuẩn, cực dễ tán trên da và có độ bám màu lên đến 12 tiếng.Thiết kế sang trọng, các tone màu dễ sử dụng cho các phong cách trang điểm từ đơn giản hằng ngày đến các bữa tiệc cầu kì, vì thế sản phẩm này là một sản phẩm cần có đối với các cô nàng là tín đồ makeup.",
                        use = "Nên dùng kem lót mắt trước khi sử dụng phấn mắt.Tán đều nhẹ nhàng, khéo léo bằng cọ trang điểm mắt.Sử dụng các tông màu từ sáng đến đậm để tạo khối và tạo điểm nổi bật.Bảo quản nơi khô ráo, thoáng mát. Tránh ánh nắng trực tiếp và nhiệt độ cao",
                        img = "~/image/sp9.jpg"
                    },
                    new SanPham{
                        product_id = 11,
                        product_type_id = 1,
                        brand_id = 7,
                        name = "MISSHA Signature Velvet Art",
                        amount = 50,
                        price = 544000,
                        description = "Phấn mắt MISSHA Signature Velvet Art với tông màu cổ điển, là sự lựa chọn tuyệt vời cho các cô nàng theo phong cách retro.Tính năng làm đẹp của loại phẩn này rất hiệu quả. Sử dụng sản phẩm để trang điểm cho đôi mắt sẽ đem lại cho bạn cảm giác mềm mại, mịn màng khi sử dụng.Màu phấn có độ bền cao, bám rất lâu và khó bị trôi. Màu phần còn chứa bột ngọc trai giúp cho đôi mắt lấp lánh tự nhiên ở mọi góc nhìn.Phấn mắt được sắp xếp một cách hợp lí, hài hòa về độ bóng và màu sắc (highlight, màu nhạt, màu đậm, viền mắt) giúp cho thao tác trang điểm mắt trở nên thuận tiện và dễ dàng.",
                        use = "Màu phấn nền được dùng đầu tiên, các bạn phủ đều phấn mắt nền lên rộng gấp 2 lần mí mắt.Màu phấn chính (nhấn) được dùng tiếp theo, loại phấn này chỉ nên vẽ khoảng môt nửa mí mắt để tạo điểm nhấn chính cho đôi mắt. Màu phấn viền thì chỉ để vẽ viền mắt theo một đường thẳng từ trong ra ngoài đuôi mắt.Màu phấn highlight sẽ được dùng cuối cùng, phủ lên toàn bộ lớp phấn trước để đôi mắt thêm long lanh.",
                        img = "~/image/sp10.jpg"
                    },
                    new SanPham{
                        product_id = 12,
                        product_type_id = 1,
                        brand_id = 1,
                        name = "LUSTRE PRO Volume Waterproof",
                        amount = 50,
                        price = 240000,
                        description = "LUSTRE PRO Volume Waterproof sử dụng công nghệ đột phá Micro Fiber, giúp bao phủ từng sợi mi. Chỉ với một lần chuốt nhẹ, MLUSTRE PRO Volume Waterproof sẽ khiến hàng mi dày và cong vút tự nhiên. LUSTRE PRO Volume Waterproof không gây cảm giác nặng trĩu và cộm mắt.",
                        use = " Lăn chai giữa 2 lòng bàn tay để làm ấm Mascara (giúp Mascara ít bị vón cục khi sử dụng).Lấy cọ ra khỏi chai và lau bớt phần Mascara dư bằng khăn giấy.Chải cọ theo đường Ziczac từ chân mi đến ngọn mi.Sau khi chuốt qua một lượt, đợi khoảng 10 giây cho khô lớp đầu tiên, chuốt tiếp lớp thứ hai, đợi thêm 10 giây nữa rồi chuốt tiếp lần thứ ba",
                        img = "~/image/sp11.jpg"
                    },
                    new SanPham{
                        product_id = 13,
                        product_type_id = 1,
                        brand_id = 8,
                        name = "Innisfree Skinny Longlongcar",
                        amount = 50,
                        price = 190000,
                        description = "Innisfree Skinny Longlongcar với đầu chải mi được thiết kế đặc biệt hình tam giác cực nhỏ chỉ có 2.5mm, giúp chổi chạm đến từng sợi mi nhỏ và ngắn nhất, chuốt tận được sâu trong chân mi. Nhờ thiết kế độc đáo này mà khi chuốt mi ít bị vón và dính các sợi mi lại với nhau, giúp kéo dài mi hơn, tạo cho bạn cảm giác như mới được nối mi. Đầu chải mi nhỏ dễ điều khiển cực kì phù hợp để chuốt hàng mi dưới – vốn rất ngắn và dễ bị lem nếu thao tác bằng các đầu chải mi to thông thường khác",
                        use = "Chải từ phía gốc mi theo hướng đi lên theo đường ziczac.Dựng đứng đầu chải và chải thêm phần mi ngắn ở đầu và đuôi mắt.Chải thêm phần lông mi dưới giúp mắt trông to và quyến rũ hơn",
                        img = "~/image/sp12.jpg"
                    },
                    new SanPham{
                        product_id = 14,
                        product_type_id = 1,
                        brand_id = 9,
                        name = " Sisley So Intense Mascara Deep",
                        amount = 50,
                        price = 1359000,
                        description = "Sisley So Intense Mascara Deep mang đến cho bạn một hàng mi dày và dài trông thấy với hiệu quả ngay tức thì. Công thức độc đáo được bổ sung các peptide giàu vitamin giúp mi dày, dài và chắc khỏe hơn qua từng ngày. Các sắc tố màu siêu tinh khiết cung cấp một màu sắc đen tuyền và độ bền màu lâu cho hàng mi. Khả năng làm tơi mi nhanh chóng cho từng sợi mi được phủ đều mascara.",
                        use = "Nên bâm mi trước để có hàng mi cong đẹp tự nhiên. Ấn nhẹ đầu chải vào gốc lông mi và nhẹ nhàng chuốt về phía ngọn, lặp lại động tác cho đến khi có được màu mascara bạn muốn.",
                        img = "~/image/sp13.jpg"
                    },
                    new SanPham{
                        product_id = 15,
                        product_type_id = 1,
                        brand_id = 10,
                        name = "Arcancil Paris Lash Hysteria",
                        amount = 50,
                        price = 395000,
                        description = "Arcancil Paris Lash Hysteria là sản phẩm trang điểm được ưa chuộng của Arcancil Paris với đầu cọ 360 độ cùng với nhiều dưỡng chất tốt giúp cho mỗi sợi lông mi đều được bao phủ bởi lớp mascara mà không bị vón cục, khô mi khi trang điểm trong thời gian dài. Bên cạnh đó còn có khả năng chống thấm nước, chống trôi tốt và hiệu quả làm dày, dài, cong mi rất tự nhiên.",
                        use = "Chải Mascara bằng cách xoay cọ từ gốc đến đầu lông mi, bắt đầu từ góc bên trong đến góc ngoài của mắt. Áp dụng nhiều lớp đến khối lượng mong muốn: một lớp kem duy nhất cho một kết quả tự nhiên, nhiều lớp kem cho khối lượng tối đa và hiệu ứng lông mi dày cực kỳ quyến rũ.",
                        img = "~/image/sp14.jpg"
                    },
                    new SanPham{
                        product_id = 16,
                        product_type_id = 1,
                        brand_id = 7,
                        name = "MISSHA THE STYLE 4D MASCARA",
                        amount = 50,
                        price = 153000,
                        description = "Thành phần chủ yếu là Botanical wax giúp bạn dễ dàng có hàng mi cong, đầy quyến rũ mà không hề có cảm giác cộm, bết dính hay vón cục. Đồng thời, cung cấp các dưỡng chất giúp bảo vệ làn mi luôn khỏe mạnh.Cây chải mi được thiết kế rất đặc biệt và tinh tế với các sợi cọ đều giúp dễ dàng trong việc tạo ra một làn mi mỏng, đều và đầy ấn tượng. Ngoài ra, thiết kế nhỏ gọn kết hợp với màu đen chủ đạo mang đến cho bạn sự sang trọng và vô cùng tiện dụng khi sử dụng và mang theo sản phẩm.Có khả năng chống trôi rất tốt, có thể giữ cho làn mi luôn cong, đẹp và đầy quyến rũ trong vòng từ 8-9 giờ ngay cả khi gặp trời mưa, mồ hôi hoặc khói bụi.",
                        use = "Lăn Chải mi The Style 4D Missha giữa 2 lòng bàn tay để làm ấm mascara để mascara ít bị vón cục khi sử dụng.Kẹp mi tạo dáng mi.Dùng mascara lấy đầu chổi, chải nhẹ nhàng lớp thứ nhất để khô.Có thể tiếp tục dùng kẹp mí tạo dáng lần 2, chải mascara lần 2, lặp lại 2-3 lần bạn có bờ mi dày dài như mong muốn.",
                        img = "~/image/sp15.jpg"
                    },
                    new SanPham{
                        product_id = 17,
                        product_type_id = 1,
                        brand_id = 1,
                        name = "Lustre PRO Eyelash Curler",
                        amount = 50,
                        price = 200000,
                        description = "Kẹp mi Lustre uốn cong mi mắt mà không làm gãy/rụng mi. Chất liệu thép không gỉ và cao su mềm giúp kẹp mi hoạt động lâu dài và không làm gãy mi.",
                        use = "Mở kẹp mi, đặt vào mí mắt theo đường cong tự nhiên của mí mắt sao cho lông mi nằm trên phần cao su của kẹp. Bấm nhẹ nhàng từ 2-3 lần. Bỏ kẹp mi, chuốt mascara. Lặp lại cho tới khi mi đạt độ cong mong muốn.",
                        img = "~/image/sp16.jpg"
                    },
                    new SanPham{
                        product_id = 18,
                        product_type_id = 1,
                        brand_id = 11,
                        name = "Buxom Lash Mascara",
                        amount = 50,
                        price = 408000,
                        description = "Công thức giàu vitamin, giúp nuôi dưỡng từng sợi lông mi sâu tới tận gốc và chống vón cục. Thêm một điểm mạnh không thể không nhắc tới nữa là về thiết kế: Phần đầu cọ của Mascara Buxom Lash lõm vào giữa tương tự như chiếc đồng hồ cát giúp cho bạn có thể dễ dàng chuốt và bao phủ từng sợi lông mi. Chất mascara mịn và đậm màu từ chân tới ngọn.",
                        use = "Dùng đầu cọ chuốt nhẹ chuốt mi Buxom Lash lên hai hàng lông mi ở hai bên mắt. Những sợi lông mi có cấu tạo dày hơn ở phần chân lông và mỏng dần về ngọn. Vì thế bạn có thể dùng đầu cọ để chuốt dày cho phần ngọn này trước. Đợi cho phần mascara đầu tiên khô thì ta tiếp tục dùng cọ chuốt đều lớp tiếp theo. Để đạt được độ dày mong muốn thì các bạn có thể chuốt mascara thành nhiều lớp tùy ý. Bảo quản mascara ở nơi khô ráo, thoáng mát, tránh để nắng mặt trời chiếu trực tiếp vào mascara. Để tránh xa tầm tay trẻ em.",
                        img = "~/image/sp17.jpg"
                    },
                    new SanPham{
                        product_id = 19,
                        product_type_id = 1,
                        brand_id = 12,
                        name = "Isehan Kiss Me Heroine Long",
                        amount = 50,
                        price = 396000,
                        description = "Mascara Isehan Heroine Kiss Me Long có khả năng làm dày và dài mi cho những bạn có lông mi dày nhưng bị thẳng, khó làm cong mi.Luôn nằm trong top đầu các sản phẩm mascara được ưa thích nhất do người tiêu dùng bình chọn tại Nhật Bản. Sản phẩm Mascara Isehan phù hợp với mọi dạng lông mi, giúp bạn tạo một hàng mi dài gấp 1,5 lần hàng mi vốn có. Khả năng chống nước và thành phần chiết xuất từ hoa cúc tác dụng giữ ẩm và dầu hoa trà làm mềm giúp bờ mi trông sẽ không bị khô hay làm cứng mi như các sản phẩm mascara thông thường khác.",
                        use = "Chải từ phía gốc mi theo hướng đi lên theo đường ziczac.Dựng đứng đầu chải và chải thêm phần mi ngắn ở đầu và đuôi mắt.Chải thêm phần lông mi dưới giúp mắt trông to và quyến rũ hơn.Cuối ngày, tẩy trang với Speedy mascara remove, dùng bông tẩy trang thấm sản phẩm sau đó nhẹ nhàng tẩy đi vùng mi mắt.",
                        img = "~/image/sp18.jpg"
                    },
                    new SanPham{
                        product_id = 20,
                        product_type_id = 1,
                        brand_id = 6,
                        name = "M.A.C Brushstroke Liner",
                        amount = 50,
                        price = 669000,
                        description = "M.A.C Brushstroke Liner - Brushblack là bút kẻ mắt màu đen tuyền với đầu nhọn cực mảnh cùng khả năng giữ màu siêu đỉnh lên đến 24 giờ. Sản phẩm chứa công thức chống trôi cho bạn đôi mắt đẹp suốt ngày dài. Mặc dù chứa công thức chống trôi nhưng bạn vẫn có thể tẩy rửa dễ dàng với nước ấm.Sản phẩm đã được kiềm nghiệm nhãn khoa an toàn cho mắt, phù hợp cả với những coi nàng thường xuyên sử dụng kính áp tròng.",
                        use = "Bạn kẻ một đường từ giữa mắt đến đuôi mắt.Kẻ thêm một đường từ khóe mắt nối với đường ban đầu. Bước này giúp mắt bạn to tròn hơn.Kẻ vành trong của mắt. Bước này sẽ tạo hiệu ứng giúp lông mi dày hơn. Bạn đưa đầu bút xuống phần vành trong của mắt và kẻ một đường chạy từ đầu mi mắt tới đuôi mi mắt. Tuy nhiên với những bạn có cặp mắt hơi nhỏ thì không nên áp dụng bước này vì nó có thể làm cho mắt bạn nhỏ hơn nữa.Kẻ đường cánh. Bước này giúp bạn tạo điểm nhấn ở đuôi mắt. Từ đuôi mắt chúng ta kẻ một đường xéo đi lên. Bạn cũng có thể đi theo đường viền dưới. Mắt bạn sẽ có nét nữ tính, điệu đà và gợi cảm.",
                        img = "~/image/sp19.jpg"
                    },
                    new SanPham{
                        product_id = 21,
                        product_type_id = 1,
                        brand_id = 34,
                        name = "Dior Diorshow Pro Liner Bevel",
                        amount = 50,
                        price = 775000,
                        description = "Kẻ mắt Dior Diorshow Pro Liner Bevel chính là một trong những niềm tự hào của thương hiệu Dior. Ưu điểm dễ nhận thấy nhất là phần đầu bút được thiết kế theo dạng xiên, trên nhọn dưới tù giúp cho người dùng có thể diều chỉnh động tác dễ dàng. Chúng cũng tạo nên những đường kẻ mắt sắc sảo như được vẽ bởi nghệ nhân trang điểm thực thụ. Sở hữu thành phần lành mạnh, không sử dụng paraben gây kích ứng, không có các chất sulfate gây ung thư,…hoàn toàn đảm bảo an toàn. Ngoài ra sản phẩm còn chứa công thức chống thấm nước giúp giữ nguyên đôi mắt đẹp khỏi tình trạng lem nhem gây ra bởi nước, mồ hôi,…",
                        use = "Sử dụng ngón tay căng nhẹ da phần mi mắt để kẻ dễ dàng hơn.Tay kia cầm bút kẻ một đường sát chân mi và hơi chếch lên ở phần đuôi mắt.Có thể tô thêm cho đến khi đạt được đường nét theo ý thích.Bảo quản sản phẩm ở nơi khô ráo, thoáng mát. Ta nên tránh để ánh nắng trực tiếp chiếu vào sản phẩm. Nắp bút luôn luôn phải đóng chặt.",
                        img = "~/image/sp20.jpg"
                    },
                    new SanPham{
                        product_id = 22,
                        product_type_id = 1,
                        brand_id = 9,
                        name = "Sisley Phyto Khol Star Eyeliner 3",
                        amount = 50,
                        price = 1081000,
                        description = "Sisley Phyto Khol Star Eyeliner 3 là chì kẻ mắt được đúc độc đáo có thể chứa các tinh thể ngọc trai tối đa, tăng cường độ bắt sáng của sản phẩm, tô điểm cho đôi mắt thêm lung linh huyền bí. Thành phần chứa tỷ lệ cao các loại dầu và sáp cho cảm giác lướt nhẹ trên da, giúp cho việc thao tác trở nên nhanh chóng và dễ dàng.",
                        use = "Kẻ sát viền mi để có một đôi mắt sắc nét.",
                        img = "~/image/sp21.jpg"
                    },
                    new SanPham{
                        product_id = 23,
                        product_type_id = 1,
                        brand_id = 9,
                        name = "Sisley Phyto-Khol Perfect Eyeliner 8",
                        amount = 50,
                        price = 1081000,
                        description = "Sisley Phyto Khol Star Eyeliner 8 là chì kẻ mắt được đúc độc đáo có thể chứa các tinh thể ngọc trai tối đa, tăng cường độ bắt sáng của sản phẩm, tô điểm cho đôi mắt thêm lung linh huyền bí. Thành phần chứa tỷ lệ cao các loại dầu và sáp cho cảm giác lướt nhẹ trên da, giúp cho việc thao tác trở nên nhanh chóng và dễ dàng.",
                        use = "Kẻ sát viền mi để có một đôi mắt sắc nét.",
                        img = "~/image/sp22.jpg"
                    },
                    new SanPham{
                        product_id = 24,
                        product_type_id = 1,
                        brand_id = 13,
                        name = "MACQUEEN WATERPROOF PEN EYELINER",
                        amount = 50,
                        price = 221000,
                        description = "Bút Kẻ Mắt MACQUEEN WATERPROOF PEN EYELINER với đầu cọ bút lông dễ điều chỉnh cho các đường kẻ mắt thật mỏng tự nhiên và sắc nét cá tính, đem đến đôi mắt to tròn, sắc nét làm nổi bật khuôn mặt bạn. Sản phẩm không bị trôi khi gặp nước, hoàn hảo cho việc sử dụng ở mọi hoàn cảnh đi làm, đi chơi, đi biển. Công thức độc đáo giúp giữ màu lâu, tạo điểm nhấn cho đôi mắt thêm đẹp quyến rũ, long lanh hơn.",
                        use = "Dùng bút kẻ, đi nét viền ngoài mắt để tô lên vẻ đẹp của đôi mắt bạn. Bảo quản nơi khô ráo, thoáng mát, tránh ánh nắng trực tiếp và nhiệt độ cao",
                        img = "~/image/sp23.jpg"
                    },
                    new SanPham{
                        product_id = 25,
                        product_type_id = 1,
                        brand_id = 14,
                        name = "ECLIPSE- EYELINER LIGNE DIVINE",
                        amount = 50,
                        price = 311000,
                        description = "Eclipse Colours là hãng mỹ phẩm cao cấp tại Pháp đã cho ra đời nhiều dòng mỹ phẩm trang điểm và các sản phẩm làm đẹp dành cho móng tay, móng chân... giúp tô điểm thêm vẻ đẹp của phái nữ. ECLIPSE - EYELINER LIGNE DIVINE: Bút chì kẻ mắt Eclipse chứa sáp làm mềm da tự nhiên và màu sắc bền rõ nét. Với thiết kế đầu bút nhỏ giúp bạn dễ dàng vẽ những đường kẻ sắc sảo như ý muốn.",
                        use = "Dùng bút chì kẻ mặt kẻ theo đường viền mắt. Sao cho mỏng dần về phía cuối đuôi mắt để mang lại đôi mắt tinh tế và dịu dàng. Nếu muốn mắt to hơn, hãy dùng chì kẻ mắt kẻ 2/3 mi dưới, nếu viền cả mi trên và mi dưới sẽ làm cho mắt sắc nét hơn. Bảo quản nơi khô ráo thoáng mát, tránh ánh nắng trực tiếp và nhiệt độ cao.",
                        img = "~/image/sp24.jpg"
                    },
                    new SanPham{
                        product_id = 26,
                        product_type_id = 1,
                        brand_id = 1,
                        name = "Lustre Ultimate Eyeliner Professional Line",
                        amount = 50,
                        price = 208000,
                        description = "Chì kẻ mắt của Lustre với đầu bút sáp mềm, dễ dàng trượt lên da cho đường kẻ mắt rõ nét và tự nhiên, đồng thời có nhiều lựa chọn về màu sắc, cho bạn thoả sức sáng tạo.",
                        use = "Bạn kẻ một đường từ giữa mắt đến đuôi mắt.Kẻ thêm một đường từ khóe mắt nối với đường ban đầu. Bước này giúp mắt bạn to tròn hơn.Kẻ vành trong của mắt. Bước này sẽ tạo hiệu ứng giúp lông mi dày hơn. Bạn đưa chì xuống phần vành trong của mắt và kẻ một đường chạy từ đầu mi mắt tới đuôi mi mắt. Tuy nhiên với những bạn có cặp mắt hơi nhỏ thì không nên áp dụng bước này vì nó có thể làm cho mắt bạn nhỏ hơn nữa.Kẻ đường cánh. Bước này giúp bạn tạo điểm nhấn ở đuôi mắt. Từ đuôi mắt chúng ta kẻ một đường xéo đi lên. Bạn cũng có thể đi theo đường viền dưới. Mắt bạn sẽ có nét nữ tính, điệu đà và gợi cảm.Kiểu chiếc lá. Từ đuôi cánh kẻ 1 đường nối liền với giữa mắt. Kiểu chiếc lá này rất thông dụng và thích hợp với nhiều loại mắt khác nhau.Đường kẻ đôi. Ban kẻ đường đối xứng với chiếc lá tạo một chút tinh nghịch và sáng tạo cho đôi mắt, đôi mắt trong cũng rất dễ thương. Bước này dành cho bạn nào muốn thể hiện cá tính và tạo sự khác biệt.",
                        img = "~/image/sp25.jpg"
                    },
                    new SanPham{
                        product_id =27 ,
                        product_type_id = 1,
                        brand_id = 1,
                        name = "Lustre Ultimate Eyeliner Professional Line Mini - Black",
                        amount =50 ,
                        price = 160000 ,
                        description = "Lustre Ultimate Eyeliner Professional Line Mini - Black - Chì kẻ mắt của Lustre với đầu bút sáp mềm, dễ dàng trượt lên da cho đường kẻ mắt rõ nét và tự nhiên.Với tông màu đen dễ dàng phối hợp cùng các kiểu makeup khác nhau sẽ tạo điểm nhấn cho đôi mắt.Ngoài tinh dầu Jojoba nuôi dưỡng mi, chất chì của Lustre rất mềm và dễ kẻ. Đặc biệt, Lustre có cả đầu chuốt đi kèm rất tiện dụng",
                        use = "Bạn kẻ một đường từ giữa mắt đến đuôi mắt.Kẻ thêm một đường từ khóe mắt nối với đường ban đầu. Bước này giúp mắt bạn to tròn hơn.Kẻ vành trong của mắt. Bước này sẽ tạo hiệu ứng giúp lông mi dày hơn. Bạn đưa chì xuống phần vành trong của mắt và kẻ một đường chạy từ đầu mi mắt tới đuôi mi mắt. Tuy nhiên với những bạn có cặp mắt hơi nhỏ thì không nên áp dụng bước này vì nó có thể làm cho mắt bạn nhỏ hơn nữa.Kẻ đường cánh. Bước này giúp bạn tạo điểm nhấn ở đuôi mắt. Từ đuôi mắt chúng ta kẻ một đường xéo đi lên. Bạn cũng có thể đi theo đường viền dưới. Mắt bạn sẽ có nét nữ tính, điệu đà và gợi cảm.",
                        img = "~/image/sp26.jpg"
                    },
                    new SanPham{
                        product_id = 28,
                        product_type_id = 1,
                        brand_id = 6,
                        name = "M.A.C Great Brows Brow Kit - TAUPE",
                        amount = 50,
                        price = 1152000,
                        description = "Bột sẽ bám phủ vào lông mày cho đôi lông mày có màu sắc đẹp tự nhiên. Đường nét mềm mại, rõ ràng thay đổi toàn diện khuôn mặt.Sản phẩm có thành phần lành tính, an toàn cho da. Hạn chế gây kích ứng, bảo vệ và chăm sóc hàng chân mày hoàn hảo, thích hợp với mọi loại da.Hạn chế được tình trạng tiết bã nhờn và mồ hôi trên da. Màu sắc của phấn kẻ chân mày MAC Eyebrows Brow của rất phù hợp đối với người Châu Á. Đem đến cho bạn một diện mạo khác hẳn.Bột cũng rất hữu dụng cho các trường hợp đã trót lỡ phun, xăm chân mày. Nhưng làm đôi mắt quá sắc nét, thiếu tự nhiên hoặc màu mực đã bắt đầu xuống màu.",
                        use = "Dùng cọ kèm theo chải đều chân mày rồi lấy cọ tán màu vẽ nhạt dần theo khuôn chân mày, bạn có thể chọn dùng 1 màu, hoặc cũng có thể phối hợp cả 3 màu với nhau (chia màu cho đầu mày và đường cong đuôi mày) rồi dùng ngón tay mix lại lần nữa để tạo hiệu ứng thật tự nhiên.",
                        img = "~/image/sp27.jpg"
                    },
                    new SanPham{
                        product_id = 29,
                        product_type_id = 1,
                        brand_id = 6,
                        name = "M.A.C VELUXE BROW LINER",
                        amount = 50,
                        price = 669000,
                        description = "Chì kẻ chân mày M.A.C VELUXE BROW LINER được thiết kế nhỏ gọn, rất tiện dụng để mang đi khi đi học, đi làm hay đi du lịch. Bột phấn có màu sắc nhẹ nhàng tạo nên sự tự nhiên cho khuôn mặt khi sử dụng. Mặt khác, kẻ mày MAC Veluxe Brow Liner còn cò khả năng giữ màu lâu, không trôi và không thấm nước, giúp bạn luôn tươi tắn suốt cả ngày.",
                        use = "Xác định điểm đầu, đỉnh và đuôi chân mày. Đỉnh chân mày nằm trên 1 đường thẳng với khóe mũi và đầu mắt.Đỉnh chân mày được xác đinh là vị trí ở 2/3 chiều dài chân mày tính từ điểm đầu chân mày. Đuôi chân mày nằm trên cùng đường thẳng với khóe mũi và đuôi mắt.Dùng chì kẻ mày vẽ thật nhẹ nhàng bắt đầu từ đỉnh chân mày hướng về đầu chân mày và từ đỉnh chân mày hướng về đuôi chân mày dọc theo viền mắt, hơi xếch lên ở đuôi mắt để đôi mắt trông to và rạng rỡ hơn để có đôi chân mày thật tự nhiên",
                        img = "~/image/sp28.jpg"
                    },
                    new SanPham{
                        product_id = 30,
                        product_type_id = 1,
                        brand_id = 15,
                        name = "PETITE LAEL EYE BROW #EB008",
                        amount = 50,
                        price = 102000,
                        description = "Petite Lael là dòng mỹ phẩm mới toanh đến từ Hàn Quốc vừa ra mắt đã khiến bao trái tim mê làm đẹp phải đổ liêu xiêu vì vẻ ngoài vô cùng đáng yêu, khác biệt với những màu sắc và thiết kế độc đáo. Nhỏ gọn, trẻ trung, dễ thương, Petite Lael còn ghi điểm với những màu sắc độc đáo: kẻ mắt màu rượu đỏ hoặc xanh biển, mascara cam,... cho bạn thỏa sức sáng tạo những makeup look siêu cá tính.PETITE LAEL EYE BROW #EB008 là sản phẩm kẻ mày giúp bạn dễ dàng kẻ được hàng chân mày đẹp như ý với thiết kế nhỏ gọn, tiện lợi, dễ dàng mang theo bên mình.",
                        use = "Dùng đầu cọ kẻ khuôn chân mày như ý sau đó tô đều vào những khoảng trống để có hàng chân mày đẹp sắc sảo.",
                        img = "~/image/sp29.jpg"
                    },
                    new SanPham{
                        product_id = 31,
                        product_type_id = 1,
                        brand_id = 1,
                        name = "Lustre Brow Pomade Professional Line - Poised Taupe",
                        amount = 50,
                        price = 184000,
                        description = "Sản phẩm Kẻ Chân Mày dạng gel pomade giúp dễ dàng tạo hình cặp chân mày cùng với khả năng chống trôi và chống lem. Công thức đặc biệt lý tưởng cho da dầu cũng như trong thời tiết nhiệt đới.Màu Poised Taupe - Nâu Tự Nhiên trẻ trung phù hợp với đa số màu tóc",
                        use = "Dùng đầu cọ Lustre Pro Makeup Brush E105 Brow Brush chấm nhẹ nhàng để lấy sản phẩm.Định hình khung chân mày và tán đều đường viền về đuôi chân mày",
                        img = "~/image/sp30.jpg"
                    },
                    new SanPham{
                        product_id = 32,
                        product_type_id = 1,
                        brand_id = 16,
                        name = "The BrowGal Eyebrow Pencil - Blond",
                        amount = 50,
                        price = 621000,
                        description = "Được thiết kế và tạo hình cẩn thận để mô phỏng vẻ ngoài của tóc thật, Bút chì kẻ lông mày của BrowGal luôn trông tự nhiên và không nhúc nhích. Những cây bút chì có thể pha trộn này được làm từ gỗ tuyết tùng cho một cây chì cứng hơn mang lại hiệu ứng giống như tóc hơn. Với một loạt các sắc thái pha trộn tùy chỉnh độc đáo, có một kết hợp hoàn hảo cho mọi màu tóc.",
                        use = "Chuốt nhọn để dễ dàng phẩy sợi , tạo khuôn chân mày, kết hợp với bột tán chân màu để có hiệu quả tốt nhất.",
                        img = "~/image/sp31.jpg"
                    },
                    new SanPham{
                        product_id = 33,
                        product_type_id = 1,
                        brand_id = 1 ,
                        name = "Lustre Brow Defining Professional Line - Dark Taupe",
                        amount = 50,
                        price = 208000,
                        description = "Lustre là thương hiệu xuất xứ từ Mỹ chuyên về các dòng trang điểm chuyên nghiệp với giá thành hợp lý cho những người yêu makeup. Sản xuất tại Hàn Quốc với công nghệ vượt trội, chì kẻ mày đầu tam giác của Lustre vô cùng dễ sử dụng kể cả cho những người mới bắt đầu. Cây chì cho phép bạn dễ dàng tạo dáng ngang dễ thương kiểu Hàn Quốc, hay dáng cong phương Tây quyến rũ. Màu sắc ra đều và mượt mà, cho nét mày tự nhiên",
                        use = "Dùng đầu cọ xoắn chuốt lông mày vào nếp.Dùng đầu chì phẩy từng sợi lông mày theo khuôn và hướng có sẵn. Nhẹ tay (nhạt màu) ở đầu lông mày, đậm dần về đuôi lông mày. Phẩy đuôi lông mày nhọn mảnh.",
                        img = "~/image/sp32.jpg"
                    },
                    new SanPham{
                        product_id = 34,
                        product_type_id = 1,
                        brand_id = 17,
                        name = "SPRING HEART EYEBROW PENCIL",
                        amount = 50,
                        price = 225000,
                        description = "Ưu điểm của chì kẻ mày SPRING HEART EYEBROW PENCIL là bạn có thể tạo nên những đường kẻ thanh mảnh và sắc nét với chất chì mềm mịn, mà không làm tổn hại đến làn da. Ngoài ra, sản phẩm với khả năng kháng nước sẽ bảo vệ chân mày bạn không bị trôi bởi bã nhờn trên da, bụi bẩn hoặc sức nóng ngoài trời. Sản phẩm còn được kèm theo đầu chuốt để tiện lợi hơn cho bạn.",
                        use = "Xác định dáng chân mày hợp với khuôn mặt sau đó kẻ khuôn và tô đều cho chân mày.",
                        img = "~/image/sp33.jpg"
                    },
                    new SanPham{
                        product_id = 35,
                        product_type_id = 1,
                        brand_id = 18,
                        name = "Muji Mild Eye Make Up Remover",
                        amount = 50,
                        price = 388000,
                        description = "Muji Mild Eye Make Up Remover nhẹ nhàng loại bỏ trang điểm mắt trên da nhạy cảm như mắt và môi mà không có cảm giác dính. Sản phẩm có thành phần chính là dầu ô liu, chiết xuất Chamomile, chiết xuất lá đào, thành phần dưỡng ẩm tự nhiên và thành phần dưỡng ẩm axit hyaluronic. Ngoài hiệu quả làm sạch sản phẩm còn bổ sung thêm các dưỡng chất để dưỡng da mềm mại. Sau khi tẩy trang bạn không hề có cảm giác khô da như các dòng sản phẩm khác. Tẩy trang dịu nhẹ không tác động quá mạnh để tránh làm da bị khô hay hư tổn.",
                        use = "Lắc đều trước khi sử dụng.Cho một lượng sản phẩm cỡ đồng xu lên cotton pad, áp trên vùng trang điểm mắt và môi trong vài giây rồi lau nhẹ nhàng.",
                        img = "~/image/sp34.jpg"
                    },
                    new SanPham{
                        product_id = 36,
                        product_type_id = 1,
                        brand_id = 19,
                        name = "Lashfood Conditioning Collagen Lash Primer",
                        amount = 50,
                        price =230000 ,
                        description = "...",
                        use = "Bôi lên mặt",
                        img = "~/image/sp35.jpg"
                    },
                    new SanPham{
                        product_id =37 ,
                        product_type_id = 1,
                        brand_id = 20,
                        name = "Milk Hydra Grip Primer",
                        amount = 50,
                        price = 150000 ,
                        description = "Kem lót cấp ẩm MILK MAKEUP Hydro Grip Primer là một sản phẩm kem lót không chứa silicone - thành phần dễ gây nên tắc nghẽn lỗ chân lông, kem dạng gel trong đầy dưỡng chất sẽ giúp da ẩm mịn hơn trông thấy.Kem lót đem lại cảm giác như bạn đang sử dụng một loại serum cấp ẩm nào đó chứ không phải là loại kem lót gây cảm giác nặng mặt hay quá bóng bẩy. Kem có chiết xuất từ trà xanh, nước lô hội ngọc trai để giúp làn da trở nên sáng mịn và rạng rỡ hơn.",
                        use = "Bôi lên mặt",
                        img = "~/image/sp36.jpg"
                    },
                    new SanPham{
                        product_id = 38,
                        product_type_id = 1,
                        brand_id = 7,
                        name = "MISSHA VELVET FINISH CUSHION",
                        amount = 50,
                        price =261000 ,
                        description = "Khi thoa lên da, phấn có lớp mỏng nhẹ tự nhiên không bệt dính khó chịu trong quá trình dùng. Không tạo độ bóng dầu sau khi sử dụng. Tạo cho bạn sự thoải mái khí sử dụng điện thoại mà không còn dấu dính lại.MISSHA VELVET FINISH CUSHION ẽ là lớp màng bảo vệ cho làn da mỏng manh của bạn khỏi tác hại của tia UV, giảm sự tổn thương từ nhiệt độ ánh sáng mặt trời gây lên bề mặt da. Bảo vệ da lên đến 5-6 giờ đồng hồ ngoài nắng.",
                        use = "Lấy 1 lượng vừa vủ, dùng bông tẩy trang đánh đều lên bề mặt da.",
                        img = "~/image/sp37.jpg"
                    },
                    new SanPham{
                        product_id = 39,
                        product_type_id = 1,
                        brand_id = 8,
                        name = "Innisfree My To Go Cushion",
                        amount = 50,
                        price = 554000,
                        description = "Chứa chiết xuất từ bột tro núi lửa đảo Jeju, hoa atiso và axit hyaluronic giúp tăng cường độ ẩm cho da.Chỉ số chống nắng cao với SPF35 PA++, mang đến cho người sử dụng cảm giác an toàn trong khi tham gia vào những hoạt động ngoài trời.Có độ che phủ tốt lấp đi khuyết điểm về sắc da xạm đen, lỗ chân lông to nhưng lớp nền lại vô cùng mỏng nhẹ và tự nhiên, thoải mái không gây cảm giác nặng mặt.",
                        use = "Ấn nút lấy sản phẩm ở rìa hộp cho đến khi lấy được lượng sản phẩm cần dùng, dùng bông cushion phân bổ đều phấn nước trên dĩa tán rồi bắt đầu dặm phấn nước lên mặt.Dặm nhẹ nhàng phấn từ phần má rồi di chuyển đến vùng trung tâm mặt.Gấp đôi bông cushion lại và bắt đầu dặm những khu vực góc cạnh như khóe mắt, khóe mũi.",
                        img = "~/image/sp38.jpg"
                    },
                    new SanPham{
                        product_id = 40,
                        product_type_id = 1,
                        brand_id = 21,
                        name = "Laneige Layering Cover Cushion",
                        amount = 50,
                        price = 665000,
                        description = "Độ che phủ cao và hiệu quả bền màu.Mang lại làn da đều màu và sáng hồng tự nhiên.Có thể điều chỉnh lớp nền lì hoặc sáng bóng tùy theo sở thích của bạn.Sản phẩm mang lại cảm giác ẩm mượt, không gây cảm giác khô, căng da.Chức năng kép: Kem che khuyết điểm: Có khả năng giúp bảo vệ làn da dưới tác hại của tia UV. Phấn nước: Giúp bảo vệ làn da dưới tác hại của tia UV và có khả năng giúp dưỡng trắng da",
                        use = "Sử dụng kem che khuyết điểm để che phủ những vùng da không hoàn hảo.Giúp gương mặt trở nên tươi sáng và hồng hào hơn khi dử dụng LANEIGE Layering Cover Cushion lên toàn bộ gương mặt",
                        img = "~/image/sp39.jpg"
                    },
                    new SanPham{
                        product_id = 41,
                        product_type_id = 1,
                        brand_id = 22,
                        name = "Guerlain Lingerie De Peau Liquid",
                        amount = 50,
                        price = 1729000,
                        description = "Guerlain Lingerie De Peau Liquid là kem nền có khả năng che phủ hoàn hảo với chất kem lỏng dễ dàng lướt và tán đều trên da, công thức nhẹ nhàng cho lớp che phủ trông tự nhiên như làn da thứ hai, hòa quyện hoàn hảo với làn da bạn. Sản phẩm mang trong mình những cải tiến tối ưu. Đặc biệt là độ bền cực lâu lên đến 24h. Nhờ đó, bạn vẫn có thể hoạt động cả ngày, đêm mà không lo làn da bị bí bách.",
                        use = "Trước khi dùng kem nền, bạn nên thoa một loại kem lót.Khi thoa kem nền, dùng mũi làm trọng tâm, thoa từ trong ra ngoài. Thoa vùng rộng trước, vùng hẹp sau. Sau đó, thoa thật nhẹ nhàng cho vùng mắt và môi.Nên thoa kem mỏng ở những vùng da quanh mắt và miệng. Thoa kem thật kỹ ở vùng trán và mũi, vì kem ở những vùng này dễ trôi.Khi kết thúc nên sử dụng phấn phủ màu sáng nhấn ở vùng chữ T, màu tối phủ vùng chữ U như thái dương, xương gò má, quai hàm và hai bên gò má.",
                        img = "~/image/sp40.jpg"
                    },
                    new SanPham{
                        product_id =42 ,
                        product_type_id = 1,
                        brand_id =23 ,
                        name = "Flawless Finish Everyday Perfection Bouncy Makeup",
                        amount = 50,
                        price = 1270000,
                        description = "Đánh thức làn da hoàn hảo và tràn đầy sức sống với hộp phấn nén Elizabeth Arden với chất phấn nhẹ như không, nhanh chóng cung cấp năng lượng để trẻ hóa và phục hồi làn da tuổi thanh xuân của bạn. Các chất làm mát có trong sản phẩm giúp xoa dịu những làn da mệt mỏi, xỉn màu và thiếu sức sống với công thúc bouncy-gel giúp làm đều màu da, hoàn thiện kết cấu của da cho lớp phấn trông tự nhiên nhất có thể. Hãng đã sử dụng công thức nén độc đáo tạo thành kết cấu phấn đàn hồi như gel giúp bám da tốt, duy trì khả năng che phủ hoàn hảo trong nhiều giờ, mang đến cho bạn làn da sáng mịn, tự nhiên.",
                        use = "Dùng bông lấy một lượng phấn vừa đủ và nhẹ nhàng tán đều lên mặt từ giữa ra xung quanh.Có thể dặm thêm ở các vùng cần che phủ nhiều hơn.Bảo quản nơi khô ráo, thoáng mát, tránh ánh nắng trực tiếp và nhiệt độ cao",
                        img = "~/image/sp41.jpg"
                    },
                    new SanPham{
                        product_id =43 ,
                        product_type_id = 1,
                        brand_id = 9,
                        name = "Sisley Phyto Teint Expert",
                        amount = 50,
                        price = 781000,
                        description = "Sisley Phyto Teint Expert là kem nền giúp da trắng sáng, đều màu, che khuyết điểm hiệu quả và giữ màu suốt 12h. Hơn nữa, sản phẩm còn có tinh chất dưỡng ẩm, chống lão hóa, mang lại làn da mềm mại, mịn màng hơn. Kem không chứa dầu, không gây nhờn dính, phù hợp cho mọi loại da, ngay cả với làn da mụn.",
                        use = "Lấy một lượng vừa đủ ra tay, thoa nhẹ lên vùng da và cổ. Sử dụng sau các bước làm sạch da",
                        img = "~/image/sp42.jpg"
                    },
                    new SanPham{
                        product_id = 44,
                        product_type_id = 1,
                        brand_id = 9,
                        name = "Sisley Phyto-Fluid Foundation Oil",
                        amount = 50,
                        price = 731000,
                        description = "Sisley Phyto-Fluid Foundation Oil là loại kem nền lâu trôi giúp da trắng sáng, đều màu, che khuyết điểm hiệu quả. Hơn nữa, sản phẩm còn có tinh chất dưỡng ẩm, chống lão hóa, mang lại làn da mềm mại, mịn màng hơn. Kem không chứa dầu, không gây nhờn dính, phù hợp cho mọi loại da, ngay cả với làn da mụn. Thành phần chiết xuất cây sơn trà, cây gỗ và hoa Linden, mang lại cảm giác như làn da đang được ngậm nước đầy ẩm mượt và mềm mịn.",
                        use = "Lấy một lượng vừa đủ ra tay, thoa nhẹ lên vùng da và cổ. Sử dụng sau các bước làm sạch da",
                        img = "~/image/sp43.jpg"
                    },
                    new SanPham{
                        product_id =45 ,
                        product_type_id = 1,
                        brand_id = 24,
                        name = "L'OREAL INFALLIBLE Total Cover Foundation",
                        amount = 50,
                        price = 270000,
                        description = "Sản phẩm có kết cấu dạng mouse mềm mịn, khi lên da sẽ tạo cảm giác nhẹ nhàng và vô cùng mượt mà vừa mỏng nhẹ lại thoải mái. Có khả năng che phủ và bền màu lên đến 24h, phù hợp với những người bận rộn không có thời gian dặm lại nhiều lần. Bổ sung chất dưỡng ẩm để giữ cho lớp nền bền lâu, tuy nhiên nếu là da khô thì vẫn nên lưu ý về việc dưỡng ẩm trước khi sử dụng.",
                        use = "Nhẹ nhàng tán đều kem nền lên da bằng mút hoặc cọ nền, tập trung vào vùng chữ T.",
                        img = "~/image/sp44.jpg"
                    },
                    new SanPham{
                        product_id = 46,
                        product_type_id = 1,
                        brand_id = 25,
                        name = "Eglips Apple Fit Blusher",
                        amount = 50,
                        price = 171000,
                        description = "Eglips Apple Fit Blusher là phấn má hồng dạng nén khi đánh không bị vón cục cho bạn một màu má hồng thật đẹp. Hạt phấn siêu mịn có khả năng hấp thụ bã nhờn và hút mồ hôi đồng thời còn giúp che phủ khuyết điểm như lỗ chân lông to, da thiếu sức sống.., với màu sắc nổi trội bạn có thể cảm nhận được màu sắc rạng rỡ và sống động trên đôi má của mình. Eglips Apple Fit Blusher ngoài việc sử dụng làm phấn má thì còn có thể sử dụng như phấn mắt, đánh highlight và làm phấn phủ.",
                        use = "Chỉ đánh vùng tròn giữa má tạo đôi má hồng dễ thương.Đánh phấn hơi xếch lên tạo gương mặt cô gái cá tính",
                        img = "~/image/sp45.jpg"
                    },
                    new SanPham{
                        product_id = 47,
                        product_type_id = 1,
                        brand_id = 25,
                        name = "Eglips Oil Cut Powder Pact",
                        amount = 50,
                        price = 289000,
                        description = "Eglips Oil Cut Powder Pact là phấn phủ dạng nén với những hạt phấn sáng lấp lánh tạo một lớp phủ mịn màng cho khuôn mặt. Sản phẩm có khả năng kiểm soát dầu nhờn hiệu quả, mang lại làn da sạch mịn và duy trì lớp nền mịn nhẹ tự nhiên suốt cả ngày. Chiết xuất các thành phần tự nhiên như hoa oải hương, hương thảo, húng tây, bạc hà,.. giúp nhẹ nhàng nuôi dưỡng làn da đồng thời giảm thiểu khả năng gây ích ứng da và làm dịu da. Màu beige natural phù hợp với mọi tông da. Hộp phấn nhỏ gọn tiện lợi giúp bạn dễ dàng mang theo bên mình, kèm theo đó là thiết kế bông phấn cao cấp siêu mềm giúp lớp phủ bám dính hoàn hảo và đều màu.",
                        use = "Sử dụng phấn nén phủ ở bước cuối cùng để hoàn tất lớp trang điểm, chú ý phủ kỹ ở những vùng bị dầu nhiều, tạo lớp trang điểm nhẹ nhàng hàng ngày.Bạn có thể xịt một lớp xịt khoáng trang điểm để lớp nền được bền màu khi hoạt động lâu ở ngoài trời.Bảo quản : Nơi khô thoáng, tránh ánh nắng trực tiếp",
                        img = "~/image/sp46.jpg"
                    },
                    new SanPham{
                        product_id =48 ,
                        product_type_id = 1,
                        brand_id = 25,
                        name = "Eglips Glow Powder Pact",
                        amount = 50,
                        price = 209000 ,
                        description = "Eglips Glow Powder Pact là phấn phủ dạng nén với những hạt phấn sáng lấp lánh tạo một lớp phủ mịn màng cho khuôn mặt. Sản phẩm có khả năng kiểm soát dầu nhờn hiệu quả, mang lại làn da sạch mịn và duy trì lớp nền mịn nhẹ tự nhiên suốt cả ngày, đồng thời làm da sáng rạng rỡ, lấp lánh và đầy nổi bật. Chiết xuất các thành phần tự nhiên như hoa oải hương, hương thảo, húng tây, bạc hà,.. giúp nhẹ nhàng nuôi dưỡng làn da, giảm thiểu khả năng gây ích ứng da và làm dịu da. Màu pitch pink với các hạt phấn chứa ngọc trai làm trắng da hiệu quả, tạo độ căng bóng hồng hào cho làn da.",
                        use = "Sử dụng phấn nén phủ ở bước cuối cùng để hoàn tất lớp trang điểm, chú ý phủ kỹ ở những vùng bị dầu nhiều, tạo lớp trang điểm nhẹ nhàng hàng ngày.Bạn có thể xịt một lớp xịt khoáng trang điểm để lớp nền được bền màu khi hoạt động lâu ở ngoài trời.Bảo quản : Nơi khô thoáng, tránh ánh nắng trực tiếp.",
                        img = "~/image/sp47.jpg"
                    },
                    new SanPham{
                        product_id = 49,
                        product_type_id = 1,
                        brand_id = 5,
                        name = "Eglips Blur Powder Pact",
                        amount = 50,
                        price = 209000,
                        description = "Phấn nén tự nhiên có màu, kềm dầu giúp che khuyết điểm và nhẹ nhàng làm tan biến những nỗi lo về da như nếp nhăn, lỗ chân lông to, da sần sùi, mang lại làn da láng mịn làm bạn cứ muốn chạm vào mãi. Công thức lecithin coating với độ bám dính phù hợp giúp da láng mịn một cách tự nhiên, cùng với các hạt phấn mịn giúp che phủ tốt những khuyết điểm trên da. Thành phần chứa thạch anh tím, bột ngọc trai phản xạ ánh sáng giúp da rạng rỡ tươi tắn.",
                        use = "Sử dụng phấn nén phủ ở bước cuối cùng để hoàn tất lớp trang điểm, chú ý phủ kỹ ở những vùng bị dầu nhiều, tạo lớp trang điểm nhẹ nhàng hàng ngày. Bạn có thể xịt một lớp xịt khoáng trang điểm để lớp nền được bền màu khi hoạt động lâu ở ngoài trời. Bảo quản : Nơi khô thoáng, tránh ánh nắng trực tiếp.",
                        img = "~/image/sp48.jpg"
                    },
                    new SanPham{
                        product_id = 50,
                        product_type_id = 1,
                        brand_id = 8,
                        name = "Innisfree No-Sebum Blur Powder",
                        amount = 50,
                        price =153000 ,
                        description = "Phấn phủ kiềm dầu, che khuyết điểm Innisfree No-sebum Blur Powder thuộc dòng mĩ phẩm hỗ trợ việc trang điểm, được thiết kế đặc biệt dành cho da nhạy cảm, da tiết quá nhiều dầu hoặc gặp rắc rối về mụn. Hướng đến đối tượng sử dụng là những người có làn da nhạy cảm, nhiều dầu nhờn, phấn phủ kiềm dầu, che khuyết điểm Innisfree No-sebum Blur Powder được bào chế từ các thành phần tự nhiên như muối khoáng, tinh chất trà xanh, tinh chất bạc hà… nên hoàn toàn lành tính, hạn chế gây kích ứng da. Thêm vào đó, sản phẩm còn được bổ sung vitamin và khoáng chất giúp nuôi dưỡng da khỏe mạnh, bảo vệ trước tác động nguy hại từ môi trường.",
                        use = "Dùng ở bước trang điểm cuối cùng hoặc khi da bóng nhờn. Dùng bông phấn lấy lượng vừa đủ và nhẹ nhàng tán đều lên da, cho đến khi phấn bao phủ hết khuôn mặt.",
                        img = "~/image/sp49.jpg"
                    }
                });
            }

            if(!context.ThuongHieus.Any()){
                temp = true;
                context.ThuongHieus.AddRange(new List<ThuongHieu>{
                    new ThuongHieu{
                        brand_id = 1,
                        name = "LUSTRE MAKEUP"
                    },
                    new ThuongHieu{
                        brand_id = 2,
                        name = "Golden Rose"
                    },
                    new ThuongHieu{
                        brand_id = 3,
                        name = "SmashBox"
                    },
                    new ThuongHieu{
                        brand_id = 4,
                        name = "Medium"
                    },
                    new ThuongHieu{
                        brand_id = 5,
                        name = "BH Cosmetics"
                    },
                    new ThuongHieu{
                        brand_id = 6,
                        name = "M.A.C Cosmetics"
                    },
                    new ThuongHieu{
                        brand_id = 7,
                        name = "Missha"
                    },
                    new ThuongHieu{
                        brand_id = 8,
                        name = "Innisfree"
                    },
                    new ThuongHieu{
                        brand_id = 9,
                        name = "Sisley Paris"
                    },
                    new ThuongHieu{
                        brand_id = 10,
                        name = "ARCANCIL PARIS"
                    },
                    new ThuongHieu{
                        brand_id = 11,
                        name = "Buxom Cosmetics"
                    },
                    new ThuongHieu{
                        brand_id = 12,
                        name = "Isehan"
                    },
                    new ThuongHieu{
                        brand_id = 13,
                        name = "MacQueen"
                    },
                    new ThuongHieu{
                        brand_id = 14,
                        name = "Eclipse Colours"
                    },
                    new ThuongHieu{
                        brand_id = 15,
                        name = "PETITE LAEL"
                    },
                    new ThuongHieu{
                        brand_id = 16,
                        name = "THE BROWGAL"
                    },
                    new ThuongHieu{
                        brand_id = 17,
                        name = "Dolly Wink"
                    },
                    new ThuongHieu{
                        brand_id = 18,
                        name = "Muji"
                    },
                    new ThuongHieu{
                        brand_id = 19,
                        name = "United States"
                    },
                    new ThuongHieu{
                        brand_id = 20,
                        name = "Milk"
                    },
                    new ThuongHieu{
                        brand_id = 21,
                        name = "Laneige"
                    },
                    new ThuongHieu{
                        brand_id = 22,
                        name = "Guerlain"
                    },
                    new ThuongHieu{
                        brand_id = 23,
                        name = "Elizabeth Arden"
                    },
                    new ThuongHieu{
                        brand_id = 24,
                        name = "L’oreal"
                    },
                    new ThuongHieu{
                        brand_id = 25,
                        name = "Eglips"
                    },
                    new ThuongHieu{
                        brand_id = 26,
                        name = "SILKYGIRL"
                    },
                    new ThuongHieu{
                        brand_id = 27,
                        name = "STATISFY"
                    },
                    new ThuongHieu{
                        brand_id = 28,
                        name = "Aritaum"
                    },
                    new ThuongHieu{
                        brand_id = 29,
                        name = "3CE"
                    },
                    new ThuongHieu{
                        brand_id = 30,
                        name = "Kaleido Cosmetics"
                    },
                    new ThuongHieu{
                        brand_id = 31,
                        name = "Stila Cosmetics"
                    },
                    new ThuongHieu{
                        brand_id = 32,
                        name = "Cover Fx"
                    },
                    new ThuongHieu{
                        brand_id = 33,
                        name = "Anastasia Beverly Hills"
                    },
                    new ThuongHieu{
                        brand_id = 34,
                        name = "Dior"
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