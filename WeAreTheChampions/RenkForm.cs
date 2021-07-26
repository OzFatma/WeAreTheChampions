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

        public RenkForm(ChampionsContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            
            lblRenk.BackColor = cd.Color;
            lblRenk.Text = cd.Color.Name;
            _db.SaveChanges();
        }
    }
}
