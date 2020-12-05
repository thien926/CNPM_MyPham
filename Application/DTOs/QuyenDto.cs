using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.DTOs
{
    public class QuyenDto
    {
        [Key]
        [Required(ErrorMessage = "Mã quyền là bắt buộc")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int permission_id { get; set;}

        [Required(ErrorMessage = "Tên quyền là bắt buộc")]
        public string name { get; set; }

        [Required(ErrorMessage = "Chi tiết quyền là bắt buộc")]
        public string details { get; set;}

        public ICollection<NhanVienDto> NhanViens {get; set;}
    }
}