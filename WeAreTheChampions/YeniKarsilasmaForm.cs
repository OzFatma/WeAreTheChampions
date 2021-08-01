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
    public partial class YeniKarsilasmaForm : Form
    {
        public event EventHandler ListeGuncellendi;
       

        private readonly ChampionsContext _db;
        Mac duzenlenen;


        public YeniKarsilasmaForm(ChampionsContext db)
        {
            _db = db;
            InitializeComponent();
            TakimlariYukle();
            SonuclariYukle();
            FormuResetle();
            
        }


        private void SonuclariYukle()
        {
            cmbSonuc.Items.Add(Sonuc.Beraberlik);
            cmbSonuc.Items.Add(Sonuc.Grup_A);
            cmbSonuc.Items.Add(Sonuc.Grup_B);

        }

        private void TakimlariYukle()
        {
            cmbTakimA.DataSource = _db.Takimlar.OrderBy(x => x.TakimAd).ToList();
            cmbTakimB.DataSource = _db.Takimlar.OrderBy(x => x.TakimAd).ToList();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (cmbTakimA.SelectedIndex==-1||cmbTakimB.SelectedIndex==-1)
            {
                MessageBox.Show("İlgili maçın takımlarını seçiniz.");
                return;
            }
            Mac mac = new Mac()
            {
                MacZamani = dtpMacTarih.Value,
                TakimA_Id = cmbTakimA.SelectedIndex,
                TakimB_Id = cmbTakimB.SelectedIndex,
                TakimAAd = cmbTakimA.Text,
                TakimBAd = cmbTakimB.Text,
                SkorA = (int)nudSkorA.Value,
                SkorB = (int)nudSkorB.Value,
                Sonuc = (Sonuc?)cmbSonuc.SelectedItem
            };
            _db.Maclar.Add(mac);
            _db.SaveChanges();
            GuncellemeVar(EventArgs.Empty);
            FormuResetle();
        }

        private void GuncellemeVar(EventArgs args)
        {
            if (ListeGuncellendi != null)
                ListeGuncellendi(this, args);
        }

        private void FormuResetle()
        {
            cmbTakimA.SelectedIndex = -1;
            cmbTakimB.SelectedIndex = -1;
        }
    }
}
