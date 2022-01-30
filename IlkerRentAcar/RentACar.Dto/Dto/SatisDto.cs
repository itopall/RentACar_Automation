using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Dto.Dto
{
    public class SatisDto
    {
        public int Id { get; set; }
        public Nullable<int> MusteriId { get; set; }
        public string MusteriAdi { get; set; }
        public Nullable<int> AracId { get; set; }
        public string AracPlaka { get; set; }
        public Nullable<int> RezervasyonId { get; set; }
        public DateTime RezervasyonTarihi { get; set; }
        public Nullable<int> KiraId { get; set; }
        public DateTime KiraTarihi { get; set; }
        public Nullable<int> UserId { get; set; }
        public string userName { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }

        
    }
}
