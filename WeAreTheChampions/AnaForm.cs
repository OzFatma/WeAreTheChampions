using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class AnaForm : Form
    {
        ChampionsContext db = new ChampionsContext();
        public AnaForm()
        {
            InitializeComponent();
            dgvListe.AutoGenerateColumns = false;
            Listele();
        }

        private void Listele()
        {
            dgvListe.DataSource = db.Maclar.OrderBy(x => x.MacZamani).ToList();
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
    }
}
