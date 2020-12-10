using System.Collections.Generic;

namespace Application.DTOs.CurrentUserDTO
{
    public class DonHangDto
    {
        public List<SPForDonHangDto> ListSP { get; set;}
        public DonHangDto(){
            ListSP = new List<SPForDonHangDto>();
        }
        public int search(int idsp, int soluong){
            foreach(var q in ListSP){
                if(q.SP.product_id == idsp){
                    // Nếu sản phẩm đã có trong giỏ hàng và số lượng giống nhau thì return 1
                    if(q.soluong == soluong){
                        return 1;
                    }
                    else{
                        // Nếu sản phẩm đã có trong giỏ hàng và số lượng != thì return 0, r sau đó thay đổi số lượng
                        return 0;
                    }
                }
            }
            // Nếu không tìm thấy sản phẩm trong giỏ hàng thì return -1
            return -1;
        }

        public void thaydoisoluongforsanpham(int idsp, int soluong){
            foreach(var q in ListSP){
                if(q.SP.product_id == idsp){
                    q.soluong = soluong;
                }
            }
        }

        public void removeSPfromID(int idsp){
            var q = SpfromID(idsp);
            if(q != null){
                ListSP.Remove(q);
            }
        }

        public SPForDonHangDto SpfromID(int idsp){
            foreach(var q in ListSP){
                if(q.SP.product_id == idsp){
                    return q;
                }
            }
            return null;
        }
    }
}