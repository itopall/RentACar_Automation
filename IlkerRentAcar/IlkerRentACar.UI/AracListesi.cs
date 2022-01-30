using RentACar.Dto.Dto;
using RentACar.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkerRentACar.UI
{
    public partial class AracListesi : BaseList
    {
        public AracListesi()
        {
            InitializeComponent();
        }

        private void AracListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentACarDataSet.Arac' table. You can move, or remove it, as needed.
           
            lblPageHeader.Text = "Araç Listesi";
            grdMusaitAraclar.AutoGenerateColumns = true;
            LoadList();
        }

        private void LoadList()
        {
            IAracServices aracServices = new AracServices();
            ISatisServices satisServices = new SatisServices();
            
            var satis = satisServices.GetAll().Where(p => p.CreatedDate <= DateTime.Now).ToList();
            foreach (var s in satis)
            {
                if (s.CreatedDate <= DateTime.Now)
                {
                    grdKiradakiAraclar.DataSource = aracServices.GetAll();
                }
                else
                {
                    grdMusaitAraclar.DataSource = aracServices.GetAll();
                }
            }
            
          
            
            
            
            

            
        }

        

       

        
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                var returnImage = Image.FromStream(ms);

                return returnImage;
            }
        }

       

        private void grdMusaitAraclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int aracId = Convert.ToInt32(grdMusaitAraclar.Rows[e.RowIndex].Cells["Id"].Value);
            if (grdMusaitAraclar.Columns[e.ColumnIndex] is DataGridViewColumn && e.RowIndex >= 0)
            {   
                btnUpdate.Click += (senders, args) => { AracEdit(aracId); AracListesi arac = new AracListesi(); arac.Show(); } ;
                
                btnSil.Click += (senders, args) => { AracDelete(aracId); AracListesi arac = new AracListesi(); arac.Show(); };
                
            }
            

        }

        private void AracDelete(int aracId)
        {
            DialogResult dialogResult = MessageBox.Show(aracId + " id'li araç silinecek devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    IAracServices aracServices = new AracServices();
                    aracServices.Delete(aracId);

                    LoadList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu! Hata detayı: \r\ne" + ex.InnerException.InnerException.Message);
                }
            }
            Close();
        }

        private void AracEdit(int aracId)
        {
            AracEkle form = new AracEkle(aracId);
            form.ShowDialog();
            LoadList();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int aracId = Convert.ToInt32(grdMusaitAraclar.Rows[0].Cells["Id"].Value);
            int cellCount = grdMusaitAraclar.Rows.Count;
            for (int i = 0; i < cellCount; i++)
            {
                if (grdMusaitAraclar.SelectedRows.Contains(grdMusaitAraclar.Rows[i]))
                {
                    AracEdit(aracId);
                    
                }
            }
            Close();

        }
    }

}
