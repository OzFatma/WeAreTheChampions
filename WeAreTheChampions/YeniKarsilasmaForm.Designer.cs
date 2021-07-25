
namespace WeAreTheChampions
{
    partial class YeniKarsilasmaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniKarsilasmaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTakimA = new System.Windows.Forms.ComboBox();
            this.cmbTakimB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpMacTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudSkorA = new System.Windows.Forms.NumericUpDown();
            this.nudSkorB = new System.Windows.Forms.NumericUpDown();
            this.cmbSonuc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkorA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkorB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Takım A :";
            // 
            // cmbTakimA
            // 
            this.cmbTakimA.FormattingEnabled = true;
            this.cmbTakimA.Location = new System.Drawing.Point(98, 108);
            this.cmbTakimA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbTakimA.Name = "cmbTakimA";
            this.cmbTakimA.Size = new System.Drawing.Size(100, 26);
            this.cmbTakimA.TabIndex = 2;
            // 
            // cmbTakimB
            // 
            this.cmbTakimB.FormattingEnabled = true;
            this.cmbTakimB.Location = new System.Drawing.Point(98, 151);
            this.cmbTakimB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbTakimB.Name = "cmbTakimB";
            this.cmbTakimB.Size = new System.Drawing.Size(100, 26);
            this.cmbTakimB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Takım B :";
            // 
            // dtpMacTarih
            // 
            this.dtpMacTarih.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpMacTarih.Location = new System.Drawing.Point(98, 12);
            this.dtpMacTarih.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpMacTarih.Name = "dtpMacTarih";
            this.dtpMacTarih.Size = new System.Drawing.Size(238, 25);
            this.dtpMacTarih.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Maç Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maç Saati :";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.Location = new System.Drawing.Point(98, 243);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(100, 36);
            this.btnOlustur.TabIndex = 9;
            this.btnOlustur.Text = "OLUŞTUR";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(98, 50);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(100, 26);
            this.mskSaat.TabIndex = 10;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Skor B :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Skor A :";
            // 
            // nudSkorA
            // 
            this.nudSkorA.Location = new System.Drawing.Point(285, 108);
            this.nudSkorA.Name = "nudSkorA";
            this.nudSkorA.Size = new System.Drawing.Size(51, 26);
            this.nudSkorA.TabIndex = 13;
            // 
            // nudSkorB
            // 
            this.nudSkorB.Location = new System.Drawing.Point(285, 151);
            this.nudSkorB.Name = "nudSkorB";
            this.nudSkorB.Size = new System.Drawing.Size(51, 26);
            this.nudSkorB.TabIndex = 14;
            // 
            // cmbSonuc
            // 
            this.cmbSonuc.FormattingEnabled = true;
            this.cmbSonuc.Location = new System.Drawing.Point(98, 194);
            this.cmbSonuc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbSonuc.Name = "cmbSonuc";
            this.cmbSonuc.Size = new System.Drawing.Size(100, 26);
            this.cmbSonuc.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 197);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sonuç :";
            // 
            // YeniKarsilasmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 305);
            this.Controls.Add(this.cmbSonuc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudSkorB);
            this.Controls.Add(this.nudSkorA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskSaat);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpMacTarih);
            this.Controls.Add(this.cmbTakimB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTakimA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YeniKarsilasmaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YeniKarsilasmaForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudSkorA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkorB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTakimA;
        private System.Windows.Forms.ComboBox cmbTakimB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpMacTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudSkorA;
        private System.Windows.Forms.NumericUpDown nudSkorB;
        private System.Windows.Forms.ComboBox cmbSonuc;
        private System.Windows.Forms.Label label7;
    }
}