using Domain.Entities;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNPM_MyPham.Models
{
    public class IndexViewShopModel
    {
        public PaginatedList<SanPham> ListSP { get; set; }
        public List<ThuongHieu> ListTH { get; set; }
        public List<LoaiSanPham> ListLSP { get; set; }
        public string Type { get; set; }
        public string NameType { get; set;}
        public string Brand { get; set; }
        public string SearchString { get; set; }
        public decimal pricemax { get; set;}
        public string price{ get; set; }
    }
}
