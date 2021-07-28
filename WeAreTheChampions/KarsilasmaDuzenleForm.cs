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
    public partial class KarsilasmaDuzenleForm : Form
    {
        private readonly ChampionsContext _db;
        private readonly Mac _secilen;
        public event EventHandler ListeGuncellendi;

        public KarsilasmaDuzenleForm(ChampionsContext db, Mac secilen)
        {
            _db = db;
            _secilen = secilen;
            InitializeComponent();
            DuzenleneniGetir();
            SonuclariYukle();
        }
        private void SonuclariYukle()
        {
            cmbSonuc.Items.Add(Sonuc.Beraberlik);
            cmbSonuc.Items.Add(Sonuc.TakimA);
            cmbSonuc.Items.Add(Sonuc.TakimB);

        }

        private void DuzenleneniGetir()
        {
            dtpMacTarih.Value = (DateTime)_secilen.MacZamani;
            cmbTakimA.Text = _secilen.TakimAAd;
            cmbTakimB.Text = _secilen.TakimBAd;
            nudSkorA.Value = (int)_secilen.SkorA;
            nudSkorB.Value = (int)_secilen.SkorB;
            //cmbSonuc.Items.Add(_secilen.Sonuc);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _secilen.MacZamani = dtpMacTarih.Value;
            _secilen.TakimAAd = cmbTakimA.Text;
            _secilen.TakimBAd = cmbTakimB.Text;
            _secilen.SkorA = (int)nudSkorA.Value;
            _secilen.SkorB = (int)nudSkorB.Value;
            _secilen.Sonuc = (Sonuc?)cmbSonuc.SelectedItem;
            _db.SaveChanges();
            GuncellemeVar(EventArgs.Empty);
        }

        private void GuncellemeVar(EventArgs args)
        {
            if (ListeGuncellendi != null)
            {
                ListeGuncellendi(this, args);
            }
        }
    }
}
