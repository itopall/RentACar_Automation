using RentACar.Dto.Dto;
using RentACar.Services.Services;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkerRentACar.UI
{
    public partial class AracEkle : BaseAddEdit
    {
        int AracId = 0;
        IAracServices aracServices; 
        public AracEkle()
        {
            InitializeComponent();
            aracServices = new AracServices();
        }
        public AracEkle(int aracId)
        {
            InitializeComponent();

            AracId = aracId;
            aracServices = new AracServices();
        }


        private void AracEkle_Load(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Araç Ekleme/Güncelleme";
            //AracId 0'dan büyükse update işlemi gerçekleşecek
            if (AracId > 0)
            {
                LoadArac();
            }
        }

        private void LoadArac()
        {
            var aracDto = aracServices.GetById(AracId);
            if (aracDto != null)
            {
                txtId.Text = aracDto.Id.ToString(); 
                txtPlaka.Text = aracDto.Plaka;
                txtMarka.Text = aracDto.Marka;
                txtModel.Text = aracDto.Model;
                dateYil.Value = aracDto.Yil.Value;
                txtYakit.Text = aracDto.Yakit;
                txtVites.Text = aracDto.Vites;
                txtMotorGucu.Text = aracDto.MotorGucu;
                txtKasaTipi.Text = aracDto.KasaTipi;
                txtKapiSayisi.Text = aracDto.KapiSayi;
                txtRenk.Text = aracDto.Renk;
                txtAirbag.Text = aracDto.AirBag;
                txtKoltuk.Text = aracDto.Koltuk;
                txtSonkm.Text = aracDto.SonKm;
                cmbHasar.Text = aracDto.Hasar;
                picResimSec.Image = byteArrayToImage(aracDto.Resim);
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "jpeg files (*.jpeg)|*.jpeg|png files (*.png)|*.png| All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picResimSec.Image = new Bitmap(dialog.FileName);
            }

        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {

                imageIn.Save(ms, imageIn.RawFormat);

                return ms.ToArray();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            AracDto aracDto = new AracDto();
            aracDto.Plaka = txtPlaka.Text.ToUpper();
            aracDto.Marka = txtMarka.Text;
            aracDto.Model = txtModel.Text;
            aracDto.Yil = dateYil.Value;
            aracDto.Yakit = txtYakit.Text;
            aracDto.Vites = txtVites.Text;
            aracDto.MotorGucu = txtMotorGucu.Text;
            aracDto.KasaTipi = txtKasaTipi.Text;
            aracDto.KapiSayi = txtKapiSayisi.Text;
            aracDto.Renk = txtRenk.Text;
            aracDto.AirBag = txtAirbag.Text;
            aracDto.Koltuk = txtKoltuk.Text;
            aracDto.SonKm = txtSonkm.Text;
            aracDto.Hasar = cmbHasar.Text;
            aracDto.Resim = ImageToByteArray(picResimSec.Image);


            try
            {
                if (AracId > 0)
                {
                    aracDto.Id = AracId;
                    aracServices.Update(aracDto);
                }
                else
                {
                    aracServices.Add(aracDto);
                }
                MessageBox.Show("Kaydetme işlemi başarıyla gerçekleşti..");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında hata oluştu! Hata Detayı: \r\n" + ex.Message);
                throw;
            }
        }
    }
}
