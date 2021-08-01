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
    public partial class RenkForm : Form
    {
        private readonly ChampionsContext _db;
        Renk secilen;

        public RenkForm(ChampionsContext db)
        {
            _db = db;
            InitializeComponent();
            TakimlariYukle();
            RenkleriYukle();
            Listele();
        }

        private void RenkleriYukle()
        {
            cmbRenkler.DataSource = _db.Renkler.ToList();
        }

        private void TakimlariYukle()
        {
            cmbTakimlar.DataSource = _db.Takimlar.ToList();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            lblRenk.BackColor = cd.Color;
            lblRenk.Text = "";
            txtAd.Text = cd.Color.Name;
            nudR.Value = cd.Color.R;
            nudG.Value = cd.Color.G;
            nudB.Value = cd.Color.B;
            RenkDuzenlePasif();
        }


        private void Listele()
        {
            lstRenkler.DisplayMember = "RenkAd";
            lstRenkler.DataSource = _db.Renkler.OrderBy(x => x.RenkAd).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string renkAd = txtAd.Text.Trim();
            if (renkAd == string.Empty)
            {
                MessageBox.Show("Lütfen bir renk seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (secilen==null)
            {
            secilen = new Renk()
            {
                RenkAd = renkAd,
                Red = (byte)nudR.Value,
                Green = (byte)nudG.Value,
                Blue = (byte)nudB.Value
            };
            _db.Renkler.Add(secilen);

            }
            else
            {
                secilen.RenkAd = txtAd.Text;
                secilen.Red = (byte)nudR.Value;
                secilen.Green = (byte)nudG.Value;
                secilen.Blue = (byte)nudB.Value;
            }

            _db.SaveChanges();
            RenkDuzenlePasif();
            Listele();
            Temizle();
        }

        private void RenkDuzenlePasif()
        {
            txtAd.Enabled = false;
            nudR.Enabled = false;
            nudG.Enabled = false;
            nudB.Enabled = false;
            btnEkle.Text = "Ekle";
            secilen = null;
        }

        private void Temizle()
        {
            lblRenk.BackColor = default;
            txtAd.Text = default;
            nudR.Value = default;
            nudG.Value = default;
            nudB.Value = default;
        }

        private void RenkDuzenleAktif()
        {
            txtAd.Enabled = true;
            nudR.Enabled = true;
            nudG.Enabled = true;
            nudB.Enabled = true;
            btnEkle.Text = "Kaydet";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Renk secilen = (Renk)lstRenkler.SelectedItem;
            _db.Renkler.Remove(secilen);
            _db.SaveChanges();
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstRenkler.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                secilen = (Renk)lstRenkler.SelectedItem;
                lblRenk.BackColor = Color.FromArgb(secilen.Red, secilen.Green, secilen.Blue);
                txtAd.Text = secilen.RenkAd;
                nudR.Value = secilen.Red;
                nudG.Value = secilen.Green;
                nudB.Value = secilen.Blue;
                RenkDuzenleAktif();
            }

        }

        private void btnAta_Click(object sender, EventArgs e)
        {
            Takim takim = (Takim)cmbTakimlar.SelectedItem;
            Renk renk = (Renk)cmbRenkler.SelectedItem;
            if (takim==null||renk==null)
            {
                MessageBox.Show("Takim ve renk alanları boş geçilemez.");
                return;
            }
            takim.Renkler.Add(renk);
            _db.SaveChanges();
        }

        private void TakimRenkleriniListele()
        {
            Takim takim = (Takim)cmbTakimlar.SelectedItem;
            lstTakimRenkleri.DataSource = takim.Renkler.ToList();

        }

        private void cmbTakimlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            TakimRenkleriniListele();
        }

        private void btnRenkSil_Click(object sender, EventArgs e)
        {
            Takim takim = (Takim)cmbTakimlar.SelectedItem;
            Renk renk = (Renk)cmbRenkler.SelectedItem;
            takim.Renkler.Remove(renk);
            _db.SaveChanges();
            TakimRenkleriniListele();

        }
    }
}
