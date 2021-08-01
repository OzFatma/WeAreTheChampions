
namespace WeAreTheChampions
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmTakimlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTakimEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRenkler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRenkEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOyuncular = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOyuncuEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnYeniKarsilasma = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.lblTakimA = new System.Windows.Forms.Label();
            this.lblTakimB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkOynananGizle = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTakimlar,
            this.tsmRenkler,
            this.tsmOyuncular});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmTakimlar
            // 
            this.tsmTakimlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTakimEkle});
            this.tsmTakimlar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsmTakimlar.Name = "tsmTakimlar";
            this.tsmTakimlar.Size = new System.Drawing.Size(66, 20);
            this.tsmTakimlar.Text = "Takımlar";
            // 
            // tsmTakimEkle
            // 
            this.tsmTakimEkle.Name = "tsmTakimEkle";
            this.tsmTakimEkle.Size = new System.Drawing.Size(133, 22);
            this.tsmTakimEkle.Text = "Takım Ekle";
            this.tsmTakimEkle.Click += new System.EventHandler(this.tsmTakimEkle_Click);
            // 
            // tsmRenkler
            // 
            this.tsmRenkler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRenkEkle});
            this.tsmRenkler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsmRenkler.Name = "tsmRenkler";
            this.tsmRenkler.Size = new System.Drawing.Size(63, 20);
            this.tsmRenkler.Text = "Renkler";
            // 
            // tsmRenkEkle
            // 
            this.tsmRenkEkle.Name = "tsmRenkEkle";
            this.tsmRenkEkle.Size = new System.Drawing.Size(129, 22);
            this.tsmRenkEkle.Text = "Renk Ekle";
            this.tsmRenkEkle.Click += new System.EventHandler(this.tsmRenkEkle_Click);
            // 
            // tsmOyuncular
            // 
            this.tsmOyuncular.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOyuncuEkle});
            this.tsmOyuncular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsmOyuncular.Name = "tsmOyuncular";
            this.tsmOyuncular.Size = new System.Drawing.Size(75, 20);
            this.tsmOyuncular.Text = "Oyuncular";
            // 
            // tsmOyuncuEkle
            // 
            this.tsmOyuncuEkle.Name = "tsmOyuncuEkle";
            this.tsmOyuncuEkle.Size = new System.Drawing.Size(142, 22);
            this.tsmOyuncuEkle.Text = "Oyuncu Ekle";
            this.tsmOyuncuEkle.Click += new System.EventHandler(this.tsmOyuncuEkle_Click);
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvListe.Location = new System.Drawing.Point(10, 156);
            this.dgvListe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvListe.MultiSelect = false;
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.RowHeadersVisible = false;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(916, 283);
            this.dgvListe.TabIndex = 2;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MacZamani";
            this.Column3.HeaderText = "Tarih";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TakimAAd";
            this.Column1.HeaderText = "Takım (A Grubu)";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TakimBAd";
            this.Column2.HeaderText = "Takım (B Grubu)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SkorA";
            this.Column5.HeaderText = "Skor (A Grubu)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SkorB";
            this.Column6.HeaderText = "Skor (B Grubu)";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Sonuc";
            this.Column7.HeaderText = "Kazanan";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // btnYeniKarsilasma
            // 
            this.btnYeniKarsilasma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnYeniKarsilasma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKarsilasma.Location = new System.Drawing.Point(10, 445);
            this.btnYeniKarsilasma.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnYeniKarsilasma.Name = "btnYeniKarsilasma";
            this.btnYeniKarsilasma.Size = new System.Drawing.Size(126, 29);
            this.btnYeniKarsilasma.TabIndex = 3;
            this.btnYeniKarsilasma.Text = "Yeni Karşılaşma";
            this.btnYeniKarsilasma.UseVisualStyleBackColor = true;
            this.btnYeniKarsilasma.Click += new System.EventHandler(this.btnYeniKarsilasma_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(836, 445);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 29);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(742, 445);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(90, 29);
            this.btnDuzenle.TabIndex = 5;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // lblTakimA
            // 
            this.lblTakimA.AutoSize = true;
            this.lblTakimA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTakimA.Location = new System.Drawing.Point(2, 4);
            this.lblTakimA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTakimA.Name = "lblTakimA";
            this.lblTakimA.Size = new System.Drawing.Size(57, 18);
            this.lblTakimA.TabIndex = 6;
            this.lblTakimA.Text = "TakımA";
            // 
            // lblTakimB
            // 
            this.lblTakimB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTakimB.AutoSize = true;
            this.lblTakimB.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTakimB.Location = new System.Drawing.Point(569, 4);
            this.lblTakimB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTakimB.Name = "lblTakimB";
            this.lblTakimB.Size = new System.Drawing.Size(57, 18);
            this.lblTakimB.TabIndex = 7;
            this.lblTakimB.Text = "TakımB";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTakimA);
            this.panel1.Controls.Add(this.lblTakimB);
            this.panel1.Location = new System.Drawing.Point(10, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 81);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackgroundImage = global::WeAreTheChampions.Properties.Resources.vs_versus_icon_logo_battle_fight_game_212005_461;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(391, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 52);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(572, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "TakımBRenk";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "TakımARenk";
            // 
            // chkOynananGizle
            // 
            this.chkOynananGizle.AutoSize = true;
            this.chkOynananGizle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkOynananGizle.Location = new System.Drawing.Point(752, 130);
            this.chkOynananGizle.Name = "chkOynananGizle";
            this.chkOynananGizle.Size = new System.Drawing.Size(163, 21);
            this.chkOynananGizle.TabIndex = 9;
            this.chkOynananGizle.Text = "Oynanmış maçları gizle";
            this.chkOynananGizle.UseVisualStyleBackColor = true;
            this.chkOynananGizle.CheckedChanged += new System.EventHandler(this.chkOynananGizle_CheckedChanged);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 486);
            this.Controls.Add(this.chkOynananGizle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeniKarsilasma);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "We Are The Champions !";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmTakimlar;
        private System.Windows.Forms.ToolStripMenuItem tsmRenkler;
        private System.Windows.Forms.ToolStripMenuItem tsmOyuncular;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Button btnYeniKarsilasma;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.ToolStripMenuItem tsmTakimEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmRenkEkle;
        private System.Windows.Forms.Label lblTakimA;
        private System.Windows.Forms.Label lblTakimB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem tsmOyuncuEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.CheckBox chkOynananGizle;
    }
}

