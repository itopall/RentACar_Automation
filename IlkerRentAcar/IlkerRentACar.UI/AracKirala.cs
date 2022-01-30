using IlkerRentACar.UI.Cache;
using RentACar.Dto.Dto;
using RentACar.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkerRentACar.UI
{
    public partial class AracKirala : BaseDateForm
    {
        IMusteriServices MusteriServices;
        IAracServices AracServices;
        ISatisServices SatisServices;
        IUserServices UserServices;
        MusteriDto musteriDto;
        AracDto aracDto;
        UserDto userDto;
        SatisDto satisDto;
        KiraDto kiraDto;
        RezervasyonDto rezervasyonDto;
        int SatisId = 0;
        
        public AracKirala()
        {
            InitializeComponent();
            MusteriServices = new MusteriServices();
            AracServices = new AracServices();
            SatisServices = new SatisServices();
            UserServices = new UserServices();
            musteriDto = new MusteriDto();
            aracDto = new AracDto();
            userDto = new UserDto();
            satisDto = new SatisDto();
            kiraDto = new KiraDto();
            rezervasyonDto = new RezervasyonDto();

        }
        public AracKirala(int satisId)
        {
            InitializeComponent();
            MusteriServices = new MusteriServices();
            AracServices = new AracServices();
            SatisServices = new SatisServices();
            UserServices = new UserServices();
            musteriDto = new MusteriDto();
            aracDto = new AracDto();
            userDto = new UserDto();
            satisDto = new SatisDto();
            kiraDto = new KiraDto();
            rezervasyonDto = new RezervasyonDto();
            kiraDto.Id = 0;
            SatisId = satisId;
        }
        
        private void AracKirala_Load(object sender, EventArgs e)
        {

            if (SatisId>0)
            {
                txtId.Text = satisDto.Id.ToString();
            }
            lblHeader.Text = "Araç Kiralama Ekranı";
            var musteri = MusteriServices.GetAll().ToList();
            var musteriList = musteri.Select(p => new { p.Id, p.Adi, p.Soyad, p.Tc }).ToList();
            var arac = AracServices.GetAll().ToList();
            var aracList = arac.Select(p => new { p.Id, p.Plaka, p.Marka, p.Model }).ToList();
            var user = UserServices.GetAll().ToList();
            var userList = user.Select(p => new { p.Id, p.AdSoyad }).ToList();
            foreach (var m in musteriList)
            {
                cmbMusteri.Items.Add(m.Adi.ToString().Trim() );
            }
            foreach (var a in aracList)
            {
                var satis =SatisServices.GetAll().Where(p => p.AracPlaka == a.Plaka);
                foreach (var s in satis)
                {
                    if (s.AracPlaka != a.Plaka)
                    {
                        cmbArac.Items.Add(a.Plaka.ToString().Trim());
                    }
                }
            }

            foreach (var u in userList)
            {
                cmbUser.Items.Add(u.AdSoyad.ToString().Trim());
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            
            
        }
        private void Save()
        {
            musteriDto.Adi = cmbMusteri.SelectedItem.ToString();
            var list = MusteriServices.GetAll().Where(p => p.Adi.Trim() == musteriDto.Adi.Trim()).ToList();
            foreach (var mId in list)
            {
                musteriDto.Id = mId.Id;
            }
            aracDto.Plaka = cmbArac.SelectedItem.ToString();
            var list1 = AracServices.GetAll().Where(p => p.Plaka.Trim() == aracDto.Plaka.Trim()).ToList();
            foreach (var aId in list1)
            {
                aracDto.Id = aId.Id;
            }
            userDto.AdSoyad = cmbUser.SelectedItem.ToString();
            var list2 = UserServices.GetAll().Where(p => p.AdSoyad.Trim() == userDto.AdSoyad.Trim()).ToList();
            foreach (var uId in list2)
            {
                userDto.Id = uId.Id;
            }
            kiraDto.Id += kiraDto.Id;
            satisDto.CreatedBy = userDto.AdSoyad;
            satisDto.CreatedDate = dateAlis.Value;
            try
            {

                if (SatisId > 0)
                {
                    //Güncelleme işlemi gerçekleştirilir
                    satisDto.Id = SatisId;
                    SatisServices.Update(satisDto, musteriDto, aracDto, userDto, kiraDto,rezervasyonDto);
                }
                else
                {
                    //Insert işlemi gerçekleştirilir.
                    //Burada satisServices deki add methoduna parametre eklediğimiz için bunları koymuş bulunduk
                    SatisServices.Add(satisDto, musteriDto, aracDto, userDto,kiraDto,rezervasyonDto);
                }

                MessageBox.Show("Kaydetme işlemi başarıyla tamamlandı...");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu! Hata detayı: \r\n" + ex.Message);
            }
        }
    }
}

