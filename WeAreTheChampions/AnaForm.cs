using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Enums;
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class AnaForm : Form
    {
        ChampionsContext db = new ChampionsContext();
        Mac secilen = new Mac();
        public AnaForm()
        {
            InitializeComponent();
            dgvListe.AutoGenerateColumns = false;
            Listele();
        }

        private void Listele()
        {
            IQueryable<Mac> sorgu = db.Maclar;
            
            if (chkOynananGizle.Checked)
            {
                sorgu = sorgu.Where(x => !x.Sonuc.HasValue );
            }

            dgvListe.DataSource = sorgu.OrderByDescending(x => x.MacZamani).ToList();
        }

        private void tsmTakimEkle_Click(object sender, EventArgs e)
        {
            TakimForm frm = new TakimForm(db);
            DialogResult dr = frm.ShowDialog();
            
        }

        private void btnYeniKarsilasma_Click(object sender, EventArgs e)
        {
            YeniKarsilasmaForm frm = new YeniKarsilasmaForm(db);
            frm.ListeGuncellendi += Frm_ListeGuncellendi;
            DialogResult dr = frm.ShowDialog();
        }

        private void Frm_ListeGuncellendi(object sender, EventArgs e)
        {
            Listele();
        }

        private void tsmRenkEkle_Click(object sender, EventArgs e)
        {
            RenkForm frm = new RenkForm(db);
            DialogResult dr = frm.ShowDialog();
        }

        private void tsmOyuncuEkle_Click(object sender, EventArgs e)
        {
            OyuncuForm frm = new OyuncuForm(db);
            DialogResult dr = frm.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Mac secilen = (Mac)dgvListe.SelectedRows[0].DataBoundItem;
            db.Maclar.Remove(secilen);
            db.SaveChanges();
            Listele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = (Mac)dgvListe.SelectedRows[0].DataBoundItem;
            if (secilen!=null)
            {
                KarsilasmaDuzenleForm frm = new KarsilasmaDuzenleForm(db,secilen);
                frm.ListeGuncellendi += Frm_ListeGuncellendi1;
                DialogResult dr = frm.ShowDialog();

            }
        }

        private void Frm_ListeGuncellendi1(object sender, EventArgs e)
        {
            Listele();
        }

        private void chkOynananGizle_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
