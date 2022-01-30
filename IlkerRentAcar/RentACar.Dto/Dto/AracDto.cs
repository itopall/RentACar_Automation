using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Dto.Dto
{
    public class AracDto
    {
        public int Id { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public Nullable<System.DateTime> Yil { get; set; }
        public string Yakit { get; set; }
        public string Vites { get; set; }
        public string MotorGucu { get; set; }
        public string SonKm { get; set; }
        public string KapiSayi { get; set; }
        public string KasaTipi { get; set; }
        public string Renk { get; set; }
        public string AirBag { get; set; }
        public string Koltuk { get; set; }
        public string Hasar { get; set; }
        public byte[] Resim { get; set; }
    }
}
