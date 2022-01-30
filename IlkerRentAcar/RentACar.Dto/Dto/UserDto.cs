using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Dto.Dto
{
    public class UserDto
    {
        public int Id { get; set; }
        public Nullable<int> UsertypeId { get; set; }
        public string AdSoyad { get; set; }
        public string Parola { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
    }
}
