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
    public partial class TakimForm : Form
    {
        private readonly ChampionsContext _db;
        Takim takim;
        Takim duzenlenen;
        public TakimForm(ChampionsContext db)
        {
            _db = db;
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            lstTakimlar.DataSource = _db.Takimlar.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == ""/*||cmbRenk.SelectedIndex==-1*/)
            {
                MessageBox.Show("Alanlar boş bırakılamaz!\r\nEklemek istediğiniz takımın adını ve rengini belirtiniz.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (duzenlenen==null)
            {
            takim = new Takim()
            {
                TakimAd = txtAd.Text
            };
            _db.Takimlar.Add(takim);
            }
            else
            {
                duzenlenen.TakimAd = txtAd.Text;
            }
            _db.SaveChanges();
            Listele();
            FormuResetle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstTakimlar.SelectedIndex == -1) return;

            Takim secilen = (Takim)lstTakimlar.SelectedItem;
            _db.Takimlar.Remove(secilen);
            _db.SaveChanges();
            Listele();
            FormuResetle();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }

        private void FormuResetle()
        {
            txtAd.Text = "";
            btnIptal.Hide();
            btnEkle.Text = "EKLE";
            duzenlenen = null;
            lstTakimlar.Enabled = true;
            btnSil.Enabled = true;
            btnDuzenle.Enabled = true;


        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lstTakimlar.SelectedIndex == -1) return;
            duzenlenen = (Takim)lstTakimlar.SelectedItem;
            txtAd.Text = duzenlenen.TakimAd;
            btnIptal.Show();
            btnEkle.Text = "KAYDET";
            lstTakimlar.Enabled = false;
            btnSil.Enabled = false;
            btnDuzenle.Enabled = false;
        }
    }
}
