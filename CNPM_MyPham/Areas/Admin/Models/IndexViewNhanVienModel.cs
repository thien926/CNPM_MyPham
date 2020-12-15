using System.Collections.Generic;
using Application.DTOs;

namespace CNPM_MyPham.Areas.Admin.Models
{
    public class IndexViewNhanVienModel
    {
        public IEnumerable<NhanVienDto> ListNV { get; set; }
        public NhanVienDto NV { get; set; }
    }
}