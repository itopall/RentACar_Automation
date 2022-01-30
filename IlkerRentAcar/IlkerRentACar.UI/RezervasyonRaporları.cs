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
    public partial class RezervasyonRaporları : BaseReport
    {
        public RezervasyonRaporları()
        {
            InitializeComponent();
        }

        private void RezervasyonRaporları_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            ISatisServices satis = new SatisServices();
            grdRezRapor.DataSource = satis.GetAll().ToList();
        }

        private void grdRezRapor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satisID = Convert.ToInt32(grdRezRapor.Rows[e.RowIndex].Cells["Id"].Value);
            if (grdRezRapor.Columns[e.ColumnIndex] is DataGridViewColumn && e.RowIndex >= 0)
            {
                

                btnSil.Click += (senders, args) => { SatisDelete(satisID); KiraRaporlari kira = new KiraRaporlari(); kira.Show(); };

            }
        }
        private void SatisDelete(int satisId)
        {
            DialogResult dialogResult = MessageBox.Show(satisId + " id'li araç silinecek devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    ISatisServices satisServices = new SatisServices();
                    satisServices.Delete(satisId);

                    LoadList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu! Hata detayı: \r\ne" + ex.InnerException.InnerException.Message);
                }
            }
            Close();
        }
    }
}
