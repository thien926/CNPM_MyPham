using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class KhachHangEFContext : IKhachHangEFcontext
    {
        private readonly MyphamDbContext context;
        public KhachHangEFContext(MyphamDbContext context){
            this.context = context;
        }

        public List<KhachHang> KhachHang_GetAll(){
            return context.KhachHangs.ToList();
        }

        public KhachHang KhachHang_GetByUser(string user){
            return context.KhachHangs.Find(user);
        }

        public void KhachHang_Add(KhachHang U){
            context.KhachHangs.Add(U);
            context.SaveChanges();
        }

        public void KhachHang_Update(KhachHang U){
            context.KhachHangs.Update(U);
            context.SaveChanges();
        }

        public void KhachHang_Remove(KhachHang U){
            context.KhachHangs.Remove(U);
            context.SaveChanges();
        }
        public List<KhachHang> KhachHang_AdminTimKiem(string type, string input){
            var query = context.KhachHangs.AsQueryable();
            switch(type){
                case "all": {
                    input = input.Trim().ToLower();
                    if(input == ""){
                        return KhachHang_GetAll();
                    }
                    query = query.Where(m => m.user.ToLower().Contains(input) || m.full_name.ToLower().Contains(input) ||
                    m.phone.ToLower().Contains(input) || m.mail.ToLower().Contains(input) || m.address.ToLower().Contains(input));
                    break;
                }
                case "user": {
                    input = input.Trim().ToLower();
                    query = query.Where(m => m.user.ToLower().Contains(input));
                    break;
                }
                case "full_name": {
                    input = input.Trim().ToLower();
                    query = query.Where(m => m.full_name.ToLower().Contains(input));
                    break;
                }
                case "phone":{
                    input = input.Trim().ToLower();
                    query = query.Where(m => m.phone.ToLower().Contains(input));
                    break;
                }
                case "mail":{
                    input = input.Trim().ToLower();
                    query = query.Where(m => m.mail.ToLower().Contains(input));
                    break;
                }
                case "address":{
                    input = input.Trim().ToLower();
                    query = query.Where(m => m.address.ToLower().Contains(input));
                    break;
                }
                default: break;
            }
            return query.ToList();
        }
    }
}