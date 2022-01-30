using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Dto.Dto
{
    public class MusteriDto
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Meslek { get; set; }
        public string CepTel { get; set; }
        public string IsTel { get; set; }
        public string Email { get; set; }
        public string Sehir { get; set; }
        public string Adres { get; set; }
        public string EhliyetNo { get; set; }
        public string EhliyetTur { get; set; }
        public Nullable<System.DateTime> EhliyetAlisTarih { get; set; }
        public string Notlar { get; set; }
    }
}
