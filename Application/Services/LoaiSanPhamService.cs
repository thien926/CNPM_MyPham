using System.Collections.Generic;
using Application.DTOs;
using Application.Mappings;
using Domain.Interfaces;

namespace Application.Services
{
    public class LoaiSanPhamService
    {
        private readonly ILoaiSanPhamEFContext LSPcontext;
        public LoaiSanPhamService(ILoaiSanPhamEFContext LSPcontext){
            this.LSPcontext = LSPcontext;
        }
        public IEnumerable<LoaiSanPhamDto> LoaiSanPham_GetAll(){
            var lsps = LSPcontext.LoaiSanPham_GetAll();
            return lsps.MappingLoaiSanPhamDtos();
        }

        public LoaiSanPhamDto LoaiSanPham_GetById(int id){
            var lsp = LSPcontext.LoaiSanPham_GetById(id);
            if(lsp == null) return null;
            return lsp.MappingLoaiSanPhamDto();
        }

        public void LoaiSanPham_Add(LoaiSanPhamDto LSPdto){
            var lsp = LSPdto.MappingLoaiSanPham();
            LSPcontext.LoaiSanPham_Add(lsp);
        }

        public void SanPham_Update(LoaiSanPhamDto LSPdto){
            var lsp = LSPcontext.LoaiSanPham_GetById(LSPdto.product_type_id);
            if(lsp == null) return;
            LSPdto.MappingLoaiSanPham(lsp);
            LSPcontext.SanPham_Update(lsp);
        }

        public void LoaiSanPham_Remove(int product_type_id){
            var lsp = LSPcontext.LoaiSanPham_GetById(product_type_id);
            if(lsp == null) return;
            LSPcontext.LoaiSanPham_Remove(lsp);
        }
    }
}