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
    public partial class KiraRaporlari : BaseReport
    {
        public KiraRaporlari()
        {
            InitializeComponent();
        }

        private void KiraRaporlari_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int satisId = Convert.ToInt32(grdKiralananAraclar.Rows[0].Cells["Id"].Value);
            int cellCount = grdKiralananAraclar.Rows.Count;
            for (int i = 0; i < cellCount; i++)
            {
                if (grdKiralananAraclar.SelectedRows.Contains(grdKiralananAraclar.Rows[i]))
                {
                    SatisEdit(satisId);

                }
            }
            Close();
        }

        private void SatisEdit(int satisId)
        {
            AracKirala form = new AracKirala(satisId);
            form.ShowDialog();
            LoadList();
        }

        private void LoadList()
        {
            ISatisServices satis = new SatisServices();
            grdKiralananAraclar.DataSource = satis.GetAll().ToList();
        }

        private void grdKiralananAraclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satisID = Convert.ToInt32(grdKiralananAraclar.Rows[e.RowIndex].Cells["Id"].Value);
            if (grdKiralananAraclar.Columns[e.ColumnIndex] is DataGridViewColumn && e.RowIndex >= 0)
            {
                btnGuncelle.Click += (senders, args) => { SatisEdit(satisID); KiraRaporlari kira = new KiraRaporlari(); kira.Show(); };

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
