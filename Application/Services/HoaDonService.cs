using System.Collections.Generic;
using Application.DTOs;
using Application.Mappings;
using Domain.Interfaces;

namespace Application.Services
{
    public class HoaDonService
    {
        private readonly IHoaDonEFContext HDcontext;
        public HoaDonService(IHoaDonEFContext HDcontext){
            this.HDcontext = HDcontext;
        }
        public IEnumerable<HoaDonDto> HoaDon_GetAll(){
            var HDs = HDcontext.HoaDon_GetAll();
            return HDs.MappingHoaDonDtos();
        }
        public HoaDonDto HoaDon_GetById(int id){
            var HD = HDcontext.HoaDon_GetById(id);
            if(HD == null) return null;
            return HD.MappingHoaDonDto();
        }
        public void HoaDon_Add(HoaDonDto U){
            var HD = U.MappingHoaDon();
            HDcontext.HoaDon_Add(HD);
        }

        public void HoaDon_Update(HoaDonDto U){
            var HD = HDcontext.HoaDon_GetById(U.bill_id);
            if(HD == null) return;
            U.MappingHoaDon(HD);
            HDcontext.HoaDon_Update(HD);
        }

        public void HoaDon_Remove(int id){
            var HD = HDcontext.HoaDon_GetById(id);
            if(HD == null) return;
            HDcontext.HoaDon_Remove(HD);
        }
    }
}