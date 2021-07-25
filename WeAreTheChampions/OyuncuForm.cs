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
    public partial class OyuncuForm : Form
    {
        private readonly ChampionsContext _db;
        Oyuncu duzenlenen;

        public OyuncuForm(ChampionsContext db)
        {
            _db = db;
            InitializeComponent();
            dgvOyuncular.AutoGenerateColumns = false; 
            TakimlariYukle();
            Listele();
        }

        private void Listele()
        {
            dgvOyuncular.DataSource = _db.Oyuncular.OrderBy(x => x.OyuncuAd).ToList();
        }

        private void TakimlariYukle()
        {
            cmbTakim.Items.Add("Seçilmedi !");
            cmbTakim.DataSource = _db.Takimlar.OrderBy(x => x.TakimAd).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "")
            {
                MessageBox.Show("Ad ve Soyad alanları boş geçilemez !", "Uyarı !");
                return;
            }

            if (duzenlenen==null)
            {
            Oyuncu oyuncu = new Oyuncu()
            {
                OyuncuAd = txtAd.Text.Trim(),
                OyuncuSoyad = txtSoyad.Text.Trim(),
                Takim = (Takim)cmbTakim.SelectedItem

            };
            _db.Oyuncular.Add(oyuncu);
            }
            else
            {
                duzenlenen.OyuncuAd = txtAd.Text;
                duzenlenen.OyuncuSoyad = txtSoyad.Text;
                duzenlenen.Takim = (Takim)cmbTakim.SelectedItem;
            }

            _db.SaveChanges();
            TakimlariYukle();
            FormuResetle();
            Listele();
        }

        private void FormuResetle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            cmbTakim.SelectedIndex = -1;
            duzenlenen = null;
            btnEkle.Text = "EKLE";
            btnIptal.Hide(); dgvOyuncular.Enabled = true;
            btnSil.Enabled = true;
            btnDuzenle.Enabled = true;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvOyuncular.SelectedRows[0].Index == -1) return;

            Oyuncu oyuncu = (Oyuncu)dgvOyuncular.SelectedRows[0].DataBoundItem;
            _db.Oyuncular.Remove(oyuncu);
            _db.SaveChanges();
            Listele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvOyuncular.SelectedRows.Count < 0) return;

            duzenlenen = (Oyuncu)dgvOyuncular.SelectedRows[0].DataBoundItem;
            txtAd.Text = duzenlenen.OyuncuAd;
            txtSoyad.Text = duzenlenen.OyuncuSoyad;
            cmbTakim.Text = duzenlenen.Takim.TakimAd;
            btnEkle.Text = "KAYDET";
            btnIptal.Show();
            dgvOyuncular.Enabled = false;
            btnSil.Enabled = false;
            btnDuzenle.Enabled = false;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }
    }
}
