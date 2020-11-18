using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using Domain.Entities;

namespace Infrastructure.Persistence
{
    public class SanPhamEFContext
    {
        private readonly MyphamDbContext context;

        public SanPhamEFContext(MyphamDbContext context){
            this.context = context;
        }

        public List<SanPham> SanPham_GetAll(){
            return context.SanPhams.ToList();
        }

        public SanPham SanPham_GetById(int id){
            return context.SanPhams.Find(id);
        }

        public void SanPham_Add(SanPham SP){
            context.SanPhams.Add(SP);
            context.SaveChanges();
        }

        public void SanPham_Update(SanPham SP){
            context.SanPhams.Update(SP);
            context.SaveChanges();
        }

        public void SanPham_Remove(SanPham SP){
            context.SanPhams.Remove(SP);
            context.SaveChanges();
        }

        public List<SanPham> SanPham_Filter(string Type, string Brand, string SearchString, int pageIndex, int pageSize, out int count, out decimal pricemax, string price)
        {
            var query = context.SanPhams.AsQueryable();
            // Lấy dữ liệu theo thương hiệu
            if (!string.IsNullOrEmpty(Brand))
            {
                Brand = Brand.Trim('-');
                string[] arrList = Brand.Split('-');
                string s = "";
                int i = 0;
                for (i = 0; i < arrList.Length - 1; ++i)
                {
                    if (!string.IsNullOrEmpty(arrList[i])){
                        s += "m.brand_id == " + arrList[i] + " || ";
                    }
                }
                if (!string.IsNullOrEmpty(arrList[i])){
                    s += "m.brand_id == " + arrList[i];
                }
                s = "m => " + s;
                query = query.Where(@s);
            }
            // Lấy dữ liệu theo loại sản phẩm
            if (!string.IsNullOrEmpty(Type)){
                int type = int.Parse(Type);
                query = query.Where(m => m.product_type_id == type);
            }
            else{
                // Lấy dữ liệu theo từ khóa tìm kiếm
                if (!string.IsNullOrEmpty(SearchString))
                {
                    SearchString = SearchString.ToLower();
                    query = query.Where(m => m.name.ToLower().Contains(SearchString));
                }
            }
            // Lấy dữ liệu theo giá
            if(!string.IsNullOrEmpty(price)){
                var arrprice = price.Split('-');
                decimal pricefrom = decimal.Parse(arrprice[0]);
                decimal priceto = decimal.Parse(arrprice[1]);
                query = query.Where(m => m.price >= pricefrom && m.price <= priceto);
            }
            count = query.Count();
            pricemax = 0;
            foreach(var q in query.ToList()){
                if(pricemax <= q.price){
                    pricemax = q.price;
                }
            }
            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }
    }
}