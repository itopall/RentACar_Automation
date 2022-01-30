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
    public partial class CalısanEkle : BaseAddEdit
    {
        IUserServices userServices = new UserServices();
        public CalısanEkle()
        {
            InitializeComponent();
        }

        private void CalısanEkle_Load(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Çalışan ekleme ekranı";
            dataGridView1.DataSource = userServices.GetAll().ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            UserDto userDto = new UserDto();
            UserTypeDto userTypeDto = new UserTypeDto();
            try
            {
                userTypeDto.Id = Convert.ToInt32(txtUsertypeId.Text.Trim());
                userDto.AdSoyad = txtAdsoyad.Text;
                userDto.Parola = txtParola.Text;
                userDto.Email = txtEmail.Text;
                userDto.Telefon = txtTelefon.Text;
                userDto.Adres = txtAdres.Text;
                userServices.Add(userDto, userTypeDto);
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
