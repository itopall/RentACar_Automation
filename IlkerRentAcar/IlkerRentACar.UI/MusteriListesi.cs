
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
    public partial class MusteriListesi : BaseList
    {
        IMusteriServices musteriServices = new MusteriServices();
        public MusteriListesi()
        {
            InitializeComponent();
        }
        private void MusteriListesi_Load(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Müşteri Listesi";
            LoadList();

        }
        private void LoadList()
        {
            grdMusteriList.DataSource = musteriServices.GetAll();
        }
        private void grdMusteriList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int musteriId = Convert.ToInt32(grdMusteriList.Rows[e.RowIndex].Cells["Id"].Value);
            if (grdMusteriList.Columns[e.ColumnIndex] is DataGridViewColumn && e.RowIndex >=0)
            {
                btnUpdate.Click += (senders, args) => { MusteriEkle(musteriId); MusteriListesi mList = new MusteriListesi(); mList.Show(); };

                btnSil.Click += (senders, args) => { MusteriDelete(musteriId); MusteriListesi mList = new MusteriListesi(); mList.Show(); };
            }
        }
        private void MusteriDelete(int musteriId)
        {
            DialogResult dialogResult = MessageBox.Show(musteriId + " id'li kategori silinecek! Devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    IMusteriServices musteriServices = new MusteriServices();
                    musteriServices.Delete(musteriId);

                    LoadList();
                    MessageBox.Show("Silme işlemi başarıyla tamamlandı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu! Hata detayı: \r\ne" + ex.InnerException.InnerException.Message);

                }
            }
            Close();
        }
        private void MusteriEkle(int musteriId)
        {
            MusteriEkle form = new MusteriEkle(musteriId);
            form.ShowDialog();

            LoadList();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int musteriId = Convert.ToInt32(grdMusteriList.Rows[0].Cells["Id"].Value);
            int cellcount = grdMusteriList.Rows.Count;

            for (int i = 0; i < cellcount; i++)
            {
                if (grdMusteriList.SelectedRows.Contains(grdMusteriList.Rows[i]))
                {
                    MusteriEkle(musteriId);
                }
            }
            Close();
        }
        private void btnTcAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTcAra.Text))
                LoadList();
            else
            {
                var list = musteriServices.GetByName(txtTcAra.Text);
                grdMusteriList.DataSource = list;
            };
            
           
        }
        private void btnIsimAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIsimAra.Text))
                LoadList();
            else
            {
                var list = musteriServices.GetByName(txtIsimAra.Text);
                grdMusteriList.DataSource = list;
            }
        }
        private void btnMailAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMailAra.Text))
                LoadList();
            else
            {
                var list = musteriServices.GetByName(txtMailAra.Text);
                grdMusteriList.DataSource = list;
            }

        }
        




       
    }
}
