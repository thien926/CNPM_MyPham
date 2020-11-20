using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ISanPhamEFContext
    {
        List<SanPham> SanPham_GetAll();
        SanPham SanPham_GetById(int id);
        void SanPham_Add(SanPham SP);
        void SanPham_Update(SanPham SP);
        void SanPham_Remove(SanPham SP);
        List<SanPham> SanPham_Filter(string Type, string Brand, string SearchString, string sort, int pageIndex, int pageSize, out int count, out decimal pricemax, string price);
    }
}