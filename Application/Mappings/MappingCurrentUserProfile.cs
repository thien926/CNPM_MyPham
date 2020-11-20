using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings
{
    public static class MappingCurrentUserProfile
    {
        public static CurrentUserDto MappingCurrentUserDto(this CurrentUser currentuser){
            var khdto = currentuser.KhachHang.MappingKhachHangDto();
            return new CurrentUserDto
            {
                KhachHangDto = khdto
            };
        }
        public static CurrentUser MappingCurrentUser(this CurrentUserDto currentuserdto){
            var kh = currentuserdto.KhachHangDto.MappingKhachHang();
            return new CurrentUser
            {
                KhachHang = kh
            };
        }

        public static void MappingCurrentUser(this CurrentUserDto currentUserDto, CurrentUser currentuser){
            var kh = currentUserDto.KhachHangDto.MappingKhachHang();
            currentuser.KhachHang = kh;
        }

    }
}