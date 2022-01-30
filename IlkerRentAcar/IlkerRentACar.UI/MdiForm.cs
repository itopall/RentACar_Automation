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
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
        }

        private void müşteriBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriEkle = new MusteriEkle();
            musteriEkle.MdiParent = this;
            musteriEkle.Show();

        }

        private void MdiForm_Load(object sender, EventArgs e)
        {
           IsMdiContainer = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MusteriListesi musteriListesi = new MusteriListesi();
            musteriListesi.MdiParent = this;
            musteriListesi.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AracEkle aracEkle = new AracEkle();
            aracEkle.MdiParent = this;
            aracEkle.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            AracListesi aracListesi = new AracListesi();
            aracListesi.MdiParent = this;
            aracListesi.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            AracKirala aracKirala = new AracKirala();
            aracKirala.MdiParent = this;
            aracKirala.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.MdiParent = this;
            rezervasyon.Show();
        }

        private void kiraRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiraRaporlari kiraRaporları = new KiraRaporlari();
            kiraRaporları.MdiParent = this;
            kiraRaporları.Show();
        }

        private void rezervasyonRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RezervasyonRaporları rezervasyonRaporları = new RezervasyonRaporları();
            rezervasyonRaporları.MdiParent = this;
            rezervasyonRaporları.Show();
        }

        private void toolStripAyarlar_Click(object sender, EventArgs e)
        {
            CalısanEkle calısanEkle = new CalısanEkle();
            calısanEkle.MdiParent = this;
            calısanEkle.Show();
        }
    }
}
