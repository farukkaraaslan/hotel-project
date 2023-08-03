using AutoMapper;
using HotelProject.Dto.UserDto;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelProject.Dto
{
    public class AutoMapperConfig :Profile
    {
        public AutoMapperConfig()
        {
             CreateMap<UserRegisterDto,AppUser>().ReverseMap();
             CreateMap<LoginDto,AppUser>().ReverseMap();
        }
    }
}
