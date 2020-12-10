using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings
{
    public static class MappingChiTietHoaDonProfile
    {
        public static ChiTietHoaDonDto MappingChiTietHoaDonDto(this ChiTietHoaDon hd){
            return new ChiTietHoaDonDto{
                bill_id = hd.bill_id,
                product_id = hd.product_id,
                amount = hd.amount,
                price = hd.price
            };
        }

        public static ChiTietHoaDon MappingChiTietHoaDon(this ChiTietHoaDonDto hddto){
            return new ChiTietHoaDon{
                bill_id = hddto.bill_id,
                product_id = hddto.product_id,
                amount = hddto.amount,
                price = hddto.price
            };
        }

        public static void MappingChiTietHoaDon(this ChiTietHoaDonDto hddto, ChiTietHoaDon hd){
            // hd.bill_id = hddto.bill_id;
            // hd.product_id = hddto.product_id;
            hd.amount = hddto.amount;
            hd.price = hddto.price;
        }

        public static IEnumerable<ChiTietHoaDonDto> MappingChiTietHoaDonDtos(this IEnumerable<ChiTietHoaDon> hds){
            foreach(var hd in hds){
                yield return hd.MappingChiTietHoaDonDto();
            }
        }
    }
}