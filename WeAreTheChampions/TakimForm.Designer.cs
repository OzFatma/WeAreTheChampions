
namespace WeAreTheChampions
{
    partial class TakimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakimForm));
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRenk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lstTakimlar = new System.Windows.Forms.ListBox();
            this.lstOyuncular = new System.Windows.Forms.ListBox();
            this.btnOyuncuSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(82, 23);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(277, 26);
            this.txtAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı :";
            // 
            // cmbRenk
            // 
            this.cmbRenk.FormattingEnabled = true;
            this.cmbRenk.Location = new System.Drawing.Point(82, 57);
            this.cmbRenk.Name = "cmbRenk";
            this.cmbRenk.Size = new System.Drawing.Size(196, 26);
            this.cmbRenk.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rengi :";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(284, 57);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 26);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(84, 225);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 31);
            this.btnDuzenle.TabIndex = 6;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(280, 225);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 31);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(164, 225);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 31);
            this.btnIptal.TabIndex = 8;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lstTakimlar
            // 
            this.lstTakimlar.DisplayMember = "TakimAd";
            this.lstTakimlar.FormattingEnabled = true;
            this.lstTakimlar.ItemHeight = 18;
            this.lstTakimlar.Location = new System.Drawing.Point(82, 89);
            this.lstTakimlar.Name = "lstTakimlar";
            this.lstTakimlar.Size = new System.Drawing.Size(273, 130);
            this.lstTakimlar.TabIndex = 9;
            this.lstTakimlar.SelectedIndexChanged += new System.EventHandler(this.lstTakimlar_SelectedIndexChanged);
            // 
            // lstOyuncular
            // 
            this.lstOyuncular.FormattingEnabled = true;
            this.lstOyuncular.ItemHeight = 18;
            this.lstOyuncular.Location = new System.Drawing.Point(365, 23);
            this.lstOyuncular.Name = "lstOyuncular";
            this.lstOyuncular.Size = new System.Drawing.Size(246, 202);
            this.lstOyuncular.TabIndex = 10;
            // 
            // btnOyuncuSil
            // 
            this.btnOyuncuSil.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOyuncuSil.Location = new System.Drawing.Point(523, 228);
            this.btnOyuncuSil.Name = "btnOyuncuSil";
            this.btnOyuncuSil.Size = new System.Drawing.Size(88, 25);
            this.btnOyuncuSil.TabIndex = 11;
            this.btnOyuncuSil.Text = "OYUNCU SİL";
            this.btnOyuncuSil.UseVisualStyleBackColor = true;
            this.btnOyuncuSil.Click += new System.EventHandler(this.btnOyuncuSil_Click);
            // 
            // TakimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 269);
            this.Controls.Add(this.btnOyuncuSil);
            this.Controls.Add(this.lstOyuncular);
            this.Controls.Add(this.lstTakimlar);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRenk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TakimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TakimForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRenk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.ListBox lstTakimlar;
        private System.Windows.Forms.ListBox lstOyuncular;
        private System.Windows.Forms.Button btnOyuncuSil;
    }
}