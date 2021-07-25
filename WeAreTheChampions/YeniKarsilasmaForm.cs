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
        private readonly ChampionsContext _db;
        Mac mac;
        

        public YeniKarsilasmaForm(ChampionsContext db)
        {
            _db = db;
            InitializeComponent();
            TakimlariYukle();
            SonuclariYukle();
        }

        private void SonuclariYukle()
        {
            cmbSonuc.Items.Add(Sonuc.Beraberlik);
            cmbSonuc.Items.Add(Sonuc.TakimA);
            cmbSonuc.Items.Add(Sonuc.TakimB);

        }

        private void TakimlariYukle()
        {
            cmbTakimA.DataSource = _db.Takimlar.OrderBy(x => x.TakimAd).ToList();
            cmbTakimB.DataSource = _db.Takimlar.OrderBy(x => x.TakimAd).ToList();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            _db.Maclar.Add(new Mac()
            {
                MacZamani = dtpMacTarih.Value,
                MacSaati = Convert.ToDateTime(mskSaat.Text),
                
            });
                
            _db.SaveChanges();
            FormuResetle();
        }

        private void FormuResetle()
        {
            mskSaat.Text = "";
            cmbTakimA.SelectedIndex = -1;
            cmbTakimB.SelectedIndex = -1;
        }
    }
}
