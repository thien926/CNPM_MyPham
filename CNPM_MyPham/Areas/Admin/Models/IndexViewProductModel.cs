using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNPM_MyPham.Areas.Admin.Models
{
    public class IndexViewProductModel
    {
        public IEnumerable<SanPhamDto> ListSP { get; set; }
        public SanPhamDto SP { get; set; }
        public IEnumerable<ThuongHieuDto> ListTH { get; set; }
        public IEnumerable<LoaiSanPhamDto> ListLSP { get; set; }
    }
}
