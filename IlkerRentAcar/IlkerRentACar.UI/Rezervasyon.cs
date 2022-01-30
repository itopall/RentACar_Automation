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
    public partial class Rezervasyon : BaseDateForm
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
        public Rezervasyon()
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
        public Rezervasyon(int satisId)
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
            rezervasyonDto.Id = 0;
            SatisId = satisId;
        }
        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            if (SatisId > 0)
            {
                txtId.Text = satisDto.Id.ToString();
            }
            lblHeader.Text = "Araç Rezervasyon Ekranı";
            var musteri = MusteriServices.GetAll().ToList();
            var musteriList = musteri.Select(p => new { p.Id, p.Adi, p.Soyad, p.Tc }).ToList();
            var arac = AracServices.GetAll().ToList();
            var aracList = arac.Select(p => new { p.Id, p.Plaka, p.Marka, p.Model }).ToList();
            var user = UserServices.GetAll().ToList();
            var userList = user.Select(p => new { p.Id, p.AdSoyad }).ToList();
            foreach (var m in musteriList)
            {
                cmbMusteri.Items.Add(m.Id.ToString().Trim()/* + " " + m.Adi.Trim() + " " + m.Soyad.Trim() + " " + m.Tc*/);
            }
            foreach (var a in aracList)
            {
                cmbArac.Items.Add(a.Id.ToString().Trim()/* + "-" + a.Plaka.Trim() + "-" + a.Marka.Trim() + "-" + a.Model*/);
            }

            foreach (var u in userList)
            {
                cmbUser.Items.Add(u.Id.ToString().Trim() /*+ "-" + a.Plaka.Trim() + "-" + a.Marka.Trim() + "-" + a.Model*/);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Save()
        {
            musteriDto.Id = Convert.ToInt32(cmbMusteri.SelectedItem);
            aracDto.Id = Convert.ToInt32(cmbArac.SelectedItem);
            userDto.Id = Convert.ToInt32(cmbUser.SelectedItem);
            rezervasyonDto.Id += rezervasyonDto.Id;
            satisDto.CreatedBy = userDto.AdSoyad;
            satisDto.CreatedDate = dateAlis.Value;
            try
            {

                if (SatisId > 0)
                {
                    //Güncelleme işlemi gerçekleştirilir
                    satisDto.Id = SatisId;
                    SatisServices.Update(satisDto, musteriDto, aracDto, userDto, kiraDto, rezervasyonDto);
                }
                else
                {
                    //Insert işlemi gerçekleştirilir.
                    //Burada satisServices deki add methoduna parametre eklediğimiz için bunları koymuş bulunduk
                    SatisServices.Add(satisDto, musteriDto, aracDto, userDto, kiraDto, rezervasyonDto);
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
