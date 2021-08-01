
namespace WeAreTheChampions
{
    partial class KarsilasmaDuzenleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KarsilasmaDuzenleForm));
            this.cmbSonuc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudSkorB = new System.Windows.Forms.NumericUpDown();
            this.nudSkorA = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpMacTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbTakimB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTakimA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkorA)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSonuc
            // 
            this.cmbSonuc.FormattingEnabled = true;
            this.cmbSonuc.Location = new System.Drawing.Point(107, 145);
            this.cmbSonuc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbSonuc.Name = "cmbSonuc";
            this.cmbSonuc.Size = new System.Drawing.Size(164, 27);
            this.cmbSonuc.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sonuç :";
            // 
            // nudSkorB
            // 
            this.nudSkorB.Location = new System.Drawing.Point(349, 103);
            this.nudSkorB.Name = "nudSkorB";
            this.nudSkorB.Size = new System.Drawing.Size(51, 27);
            this.nudSkorB.TabIndex = 4;
            // 
            // nudSkorA
            // 
            this.nudSkorA.Location = new System.Drawing.Point(349, 60);
            this.nudSkorA.Name = "nudSkorA";
            this.nudSkorA.Size = new System.Drawing.Size(51, 27);
            this.nudSkorA.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Skor B :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Skor A :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(171, 195);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 36);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maç Tarihi :";
            // 
            // dtpMacTarih
            // 
            this.dtpMacTarih.CustomFormat = "    dd.MM.yyyy - HH:mm";
            this.dtpMacTarih.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpMacTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMacTarih.Location = new System.Drawing.Point(107, 13);
            this.dtpMacTarih.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpMacTarih.Name = "dtpMacTarih";
            this.dtpMacTarih.Size = new System.Drawing.Size(293, 27);
            this.dtpMacTarih.TabIndex = 6;
            // 
            // cmbTakimB
            // 
            this.cmbTakimB.DisplayMember = "TakimAd";
            this.cmbTakimB.FormattingEnabled = true;
            this.cmbTakimB.Location = new System.Drawing.Point(107, 102);
            this.cmbTakimB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbTakimB.Name = "cmbTakimB";
            this.cmbTakimB.Size = new System.Drawing.Size(164, 27);
            this.cmbTakimB.TabIndex = 1;
            this.cmbTakimB.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Takım B :";
            // 
            // cmbTakimA
            // 
            this.cmbTakimA.DisplayMember = "TakimAd";
            this.cmbTakimA.FormattingEnabled = true;
            this.cmbTakimA.Location = new System.Drawing.Point(107, 59);
            this.cmbTakimA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbTakimA.Name = "cmbTakimA";
            this.cmbTakimA.Size = new System.Drawing.Size(164, 27);
            this.cmbTakimA.TabIndex = 0;
            this.cmbTakimA.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Takım A :";
            // 
            // KarsilasmaDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(427, 243);
            this.Controls.Add(this.dtpMacTarih);
            this.Controls.Add(this.cmbSonuc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudSkorB);
            this.Controls.Add(this.nudSkorA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTakimB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTakimA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "KarsilasmaDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KarsilasmaDuzenleForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudSkorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkorA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSonuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudSkorB;
        private System.Windows.Forms.NumericUpDown nudSkorA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpMacTarih;
        private System.Windows.Forms.ComboBox cmbTakimB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTakimA;
        private System.Windows.Forms.Label label1;
    }
}