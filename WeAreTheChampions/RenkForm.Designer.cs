
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
            this.cmbTakimlar = new System.Windows.Forms.ComboBox();
            this.cmbRenkler = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAta = new System.Windows.Forms.Button();
            this.lstTakimRenkleri = new System.Windows.Forms.ListBox();
            this.btnRenkSil = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renk Ad :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(93, 25);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(83, 26);
            this.txtAd.TabIndex = 1;
            // 
            // nudR
            // 
            this.nudR.Location = new System.Drawing.Point(93, 71);
            this.nudR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudR.Name = "nudR";
            this.nudR.Size = new System.Drawing.Size(83, 26);
            this.nudR.TabIndex = 2;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(12, 20);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(79, 59);
            this.btnSec.TabIndex = 3;
            this.btnSec.Text = "Renk Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "R :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "G :";
            // 
            // nudG
            // 
            this.nudG.Location = new System.Drawing.Point(93, 103);
            this.nudG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudG.Name = "nudG";
            this.nudG.Size = new System.Drawing.Size(83, 26);
            this.nudG.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "B :";
            // 
            // nudB
            // 
            this.nudB.Location = new System.Drawing.Point(93, 142);
            this.nudB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(83, 26);
            this.nudB.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudB);
            this.groupBox1.Controls.Add(this.nudR);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(179, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 266);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renk Düzenle";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(9, 231);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(79, 27);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 243);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(79, 27);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblRenk
            // 
            this.lblRenk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRenk.Location = new System.Drawing.Point(97, 20);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(76, 59);
            this.lblRenk.TabIndex = 10;
            this.lblRenk.Text = "Renk";
            this.lblRenk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstRenkler
            // 
            this.lstRenkler.FormattingEnabled = true;
            this.lstRenkler.ItemHeight = 18;
            this.lstRenkler.Location = new System.Drawing.Point(12, 85);
            this.lstRenkler.Name = "lstRenkler";
            this.lstRenkler.Size = new System.Drawing.Size(161, 148);
            this.lstRenkler.TabIndex = 11;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(94, 243);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(79, 27);
            this.btnSil.TabIndex = 12;
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
            this.groupBox2.Location = new System.Drawing.Point(12, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 124);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renk Atama ";
            // 
            // cmbTakimlar
            // 
            this.cmbTakimlar.FormattingEnabled = true;
            this.cmbTakimlar.Location = new System.Drawing.Point(62, 25);
            this.cmbTakimlar.Name = "cmbTakimlar";
            this.cmbTakimlar.Size = new System.Drawing.Size(99, 26);
            this.cmbTakimlar.TabIndex = 0;
            this.cmbTakimlar.SelectedIndexChanged += new System.EventHandler(this.cmbTakimlar_SelectedIndexChanged);
            // 
            // cmbRenkler
            // 
            this.cmbRenkler.FormattingEnabled = true;
            this.cmbRenkler.Location = new System.Drawing.Point(62, 57);
            this.cmbRenkler.Name = "cmbRenkler";
            this.cmbRenkler.Size = new System.Drawing.Size(99, 26);
            this.cmbRenkler.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Takım :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Renk :";
            // 
            // btnAta
            // 
            this.btnAta.Location = new System.Drawing.Point(6, 89);
            this.btnAta.Name = "btnAta";
            this.btnAta.Size = new System.Drawing.Size(79, 27);
            this.btnAta.TabIndex = 14;
            this.btnAta.Text = "Renk Ata";
            this.btnAta.UseVisualStyleBackColor = true;
            this.btnAta.Click += new System.EventHandler(this.btnAta_Click);
            // 
            // lstTakimRenkleri
            // 
            this.lstTakimRenkleri.FormattingEnabled = true;
            this.lstTakimRenkleri.ItemHeight = 18;
            this.lstTakimRenkleri.Location = new System.Drawing.Point(176, 22);
            this.lstTakimRenkleri.Name = "lstTakimRenkleri";
            this.lstTakimRenkleri.Size = new System.Drawing.Size(167, 94);
            this.lstTakimRenkleri.TabIndex = 14;
            // 
            // btnRenkSil
            // 
            this.btnRenkSil.Location = new System.Drawing.Point(91, 89);
            this.btnRenkSil.Name = "btnRenkSil";
            this.btnRenkSil.Size = new System.Drawing.Size(79, 27);
            this.btnRenkSil.TabIndex = 16;
            this.btnRenkSil.Text = "Kaldır";
            this.btnRenkSil.UseVisualStyleBackColor = true;
            this.btnRenkSil.Click += new System.EventHandler(this.btnRenkSil_Click);
            // 
            // RenkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstRenkler);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSec);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RenkForm";
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