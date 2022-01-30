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
    public partial class MusteriEkle : BaseAddEdit
    {
        int MusteriId = 0;
        IMusteriServices musteriServices;
        public MusteriEkle()
        {
            InitializeComponent();
            musteriServices = new MusteriServices();
        }
        public MusteriEkle(int musteriId)
        {
            InitializeComponent();
            musteriServices = new MusteriServices();
            MusteriId = musteriId;
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Müşteri Ekleme/Güncelleme Ekranı";
            if (MusteriId > 0)
            {
                LoadMusteri();
            }
        }

        private void LoadMusteri()
        {
            var musteriDto = musteriServices.GetById(MusteriId);
            if (musteriDto != null)
            {
                txtId.Text = musteriDto.Id.ToString(); ;
                txtAd.Text = musteriDto.Adi;
                txtSoyad.Text = musteriDto.Soyad;
                txtTc.Text = musteriDto.Tc;
                dateDogumTarihi.Value = musteriDto.DogumTarihi.Value;
                cmbCinsiyet.Text = musteriDto.Cinsiyet;
                txtMeslek.Text = musteriDto.Meslek;
                txtCepTel.Text = musteriDto.CepTel;
                txtIsTel.Text = musteriDto.IsTel;
                txtEmail.Text = musteriDto.Email;
                txtSehir.Text = musteriDto.Sehir;
                txtAdres.Text = musteriDto.Adres;
                txtEhliyetNo.Text = musteriDto.EhliyetNo;
                txtEhliyetTur.Text = musteriDto.EhliyetTur;
                dateAlisTarihi.Value = musteriDto.EhliyetAlisTarih.Value;
                txtNotlar.Text = musteriDto.Notlar;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            MusteriDto musteriDto = new MusteriDto();
            musteriDto.Adi = txtAd.Text;
            musteriDto.Soyad = txtSoyad.Text;
            musteriDto.Tc = txtTc.Text;
            musteriDto.DogumTarihi = dateDogumTarihi.Value;
            musteriDto.Cinsiyet = cmbCinsiyet.Text;
            musteriDto.Meslek = txtMeslek.Text;
            musteriDto.CepTel = txtCepTel.Text;
            musteriDto.IsTel = txtIsTel.Text;
            musteriDto.Email = txtEmail.Text;
            musteriDto.Sehir = txtSehir.Text;
            musteriDto.Adres = txtAdres.Text;
            musteriDto.EhliyetNo = txtEhliyetNo.Text;
            musteriDto.EhliyetTur = txtEhliyetTur.Text;
            musteriDto.EhliyetAlisTarih = dateAlisTarihi.Value;
            musteriDto.Notlar = txtNotlar.Text;
            try
            {
                if (MusteriId > 0)
                {
                    musteriDto.Id = MusteriId;
                    musteriServices.Update(musteriDto);
                }
                else
                {
                    musteriServices.Add(musteriDto);
                }
                MessageBox.Show("Kaydetme işlemi başarıyla gereçleşti..");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu! Hata detayı: \r\n" + ex.Message);
            }
        }
    }
}
