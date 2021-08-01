
namespace WeAreTheChampions
{
    partial class RenkForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.nudR = new System.Windows.Forms.NumericUpDown();
            this.btnSec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudG = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblRenk = new System.Windows.Forms.Label();
            this.cdRenkler = new System.Windows.Forms.ColorDialog();
            this.lstRenkler = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRenkSil = new System.Windows.Forms.Button();
            this.lstTakimRenkleri = new System.Windows.Forms.ListBox();
            this.btnAta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRenkler = new System.Windows.Forms.ComboBox();
            this.cmbTakimlar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Renk Ad :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(87, 25);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(112, 26);
            this.txtAd.TabIndex = 0;
            // 
            // nudR
            // 
            this.nudR.Location = new System.Drawing.Point(87, 81);
            this.nudR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudR.Name = "nudR";
            this.nudR.Size = new System.Drawing.Size(112, 26);
            this.nudR.TabIndex = 1;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(12, 20);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(79, 59);
            this.btnSec.TabIndex = 0;
            this.btnSec.Text = "Renk Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "R :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "G :";
            // 
            // nudG
            // 
            this.nudG.Location = new System.Drawing.Point(87, 128);
            this.nudG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudG.Name = "nudG";
            this.nudG.Size = new System.Drawing.Size(112, 26);
            this.nudG.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "B :";
            // 
            // nudB
            // 
            this.nudB.Location = new System.Drawing.Point(87, 174);
            this.nudB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(112, 26);
            this.nudB.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudB);
            this.groupBox1.Controls.Add(this.nudR);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(216, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 221);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renk Düzenle";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(359, 239);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(79, 35);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 239);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(79, 35);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblRenk
            // 
            this.lblRenk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRenk.Location = new System.Drawing.Point(114, 20);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(81, 59);
            this.lblRenk.TabIndex = 1;
            this.lblRenk.Text = "Renk";
            this.lblRenk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstRenkler
            // 
            this.lstRenkler.FormattingEnabled = true;
            this.lstRenkler.ItemHeight = 18;
            this.lstRenkler.Location = new System.Drawing.Point(12, 85);
            this.lstRenkler.Name = "lstRenkler";
            this.lstRenkler.Size = new System.Drawing.Size(183, 148);
            this.lstRenkler.TabIndex = 2;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(114, 239);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(79, 35);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRenkSil);
            this.groupBox2.Controls.Add(this.lstTakimRenkleri);
            this.groupBox2.Controls.Add(this.btnAta);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbRenkler);
            this.groupBox2.Controls.Add(this.cmbTakimlar);
            this.groupBox2.Location = new System.Drawing.Point(12, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 144);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renk Atama ";
            // 
            // btnRenkSil
            // 
            this.btnRenkSil.Location = new System.Drawing.Point(158, 107);
            this.btnRenkSil.Name = "btnRenkSil";
            this.btnRenkSil.Size = new System.Drawing.Size(79, 27);
            this.btnRenkSil.TabIndex = 3;
            this.btnRenkSil.Text = "Kaldır";
            this.btnRenkSil.UseVisualStyleBackColor = true;
            this.btnRenkSil.Click += new System.EventHandler(this.btnRenkSil_Click);
            // 
            // lstTakimRenkleri
            // 
            this.lstTakimRenkleri.FormattingEnabled = true;
            this.lstTakimRenkleri.ItemHeight = 18;
            this.lstTakimRenkleri.Location = new System.Drawing.Point(243, 22);
            this.lstTakimRenkleri.Name = "lstTakimRenkleri";
            this.lstTakimRenkleri.Size = new System.Drawing.Size(160, 112);
            this.lstTakimRenkleri.TabIndex = 14;
            // 
            // btnAta
            // 
            this.btnAta.Location = new System.Drawing.Point(68, 107);
            this.btnAta.Name = "btnAta";
            this.btnAta.Size = new System.Drawing.Size(79, 27);
            this.btnAta.TabIndex = 2;
            this.btnAta.Text = "Renk Ata";
            this.btnAta.UseVisualStyleBackColor = true;
            this.btnAta.Click += new System.EventHandler(this.btnAta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Renk :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Takım :";
            // 
            // cmbRenkler
            // 
            this.cmbRenkler.FormattingEnabled = true;
            this.cmbRenkler.Location = new System.Drawing.Point(68, 66);
            this.cmbRenkler.Name = "cmbRenkler";
            this.cmbRenkler.Size = new System.Drawing.Size(169, 26);
            this.cmbRenkler.TabIndex = 1;
            // 
            // cmbTakimlar
            // 
            this.cmbTakimlar.FormattingEnabled = true;
            this.cmbTakimlar.Location = new System.Drawing.Point(68, 25);
            this.cmbTakimlar.Name = "cmbTakimlar";
            this.cmbTakimlar.Size = new System.Drawing.Size(169, 26);
            this.cmbTakimlar.TabIndex = 0;
            this.cmbTakimlar.SelectedIndexChanged += new System.EventHandler(this.cmbTakimlar_SelectedIndexChanged);
            // 
            // RenkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(456, 436);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstRenkler);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSec);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RenkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RenkForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.NumericUpDown nudR;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.ColorDialog cdRenkler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstRenkler;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstTakimRenkleri;
        private System.Windows.Forms.Button btnAta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRenkler;
        private System.Windows.Forms.ComboBox cmbTakimlar;
        private System.Windows.Forms.Button btnRenkSil;
    }
}