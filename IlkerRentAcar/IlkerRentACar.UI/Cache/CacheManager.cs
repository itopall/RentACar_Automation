using RentACar.Dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkerRentACar.UI.Cache
{
    public static class CacheManager
    {
        public static UserDto LoginUser { get; set; }
        public static UserDto LoginPassword { get; set; }
    }
}
