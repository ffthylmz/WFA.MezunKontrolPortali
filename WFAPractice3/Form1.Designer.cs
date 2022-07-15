namespace WFAPractice3
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.cboxHarfNotu = new System.Windows.Forms.ComboBox();
            this.cboxAkts = new System.Windows.Forms.ComboBox();
            this.cboxDersKredisi = new System.Windows.Forms.ComboBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSecilenDers = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ders Kredisi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "AKTS:";
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.btnSil);
            this.grpBox.Controls.Add(this.btnGuncelle);
            this.grpBox.Controls.Add(this.cboxHarfNotu);
            this.grpBox.Controls.Add(this.cboxAkts);
            this.grpBox.Controls.Add(this.cboxDersKredisi);
            this.grpBox.Controls.Add(this.btnHesapla);
            this.grpBox.Controls.Add(this.txtDersAdi);
            this.grpBox.Controls.Add(this.txtDersKodu);
            this.grpBox.Controls.Add(this.btnEkle);
            this.grpBox.Controls.Add(this.label5);
            this.grpBox.Controls.Add(this.label1);
            this.grpBox.Controls.Add(this.label4);
            this.grpBox.Controls.Add(this.label2);
            this.grpBox.Controls.Add(this.label3);
            this.grpBox.Location = new System.Drawing.Point(12, 61);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(401, 239);
            this.grpBox.TabIndex = 4;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "DERS GİRİŞ EKRANI";
            // 
            // cboxHarfNotu
            // 
            this.cboxHarfNotu.FormattingEnabled = true;
            this.cboxHarfNotu.Items.AddRange(new object[] {
            "AA",
            "BA",
            "BB",
            "CB",
            "CC",
            "DC",
            "DD",
            "FF"});
            this.cboxHarfNotu.Location = new System.Drawing.Point(89, 186);
            this.cboxHarfNotu.Name = "cboxHarfNotu";
            this.cboxHarfNotu.Size = new System.Drawing.Size(155, 21);
            this.cboxHarfNotu.TabIndex = 14;
            // 
            // cboxAkts
            // 
            this.cboxAkts.FormattingEnabled = true;
            this.cboxAkts.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboxAkts.Location = new System.Drawing.Point(89, 152);
            this.cboxAkts.Name = "cboxAkts";
            this.cboxAkts.Size = new System.Drawing.Size(155, 21);
            this.cboxAkts.TabIndex = 13;
            // 
            // cboxDersKredisi
            // 
            this.cboxDersKredisi.FormattingEnabled = true;
            this.cboxDersKredisi.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboxDersKredisi.Location = new System.Drawing.Point(89, 114);
            this.cboxDersKredisi.Name = "cboxDersKredisi";
            this.cboxDersKredisi.Size = new System.Drawing.Size(155, 21);
            this.cboxDersKredisi.TabIndex = 12;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(271, 175);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(114, 41);
            this.btnHesapla.TabIndex = 11;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click_1);
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(89, 81);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(155, 20);
            this.txtDersAdi.TabIndex = 7;
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.Location = new System.Drawing.Point(89, 44);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(155, 20);
            this.txtDersKodu.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(271, 19);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(114, 37);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harf Notu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(258, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(356, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "ORTALAMA HESAPLAMA EKRANI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(434, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 239);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(271, 62);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(114, 41);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(680, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Seçilen Ders:";
            // 
            // lblSecilenDers
            // 
            this.lblSecilenDers.AutoSize = true;
            this.lblSecilenDers.Location = new System.Drawing.Point(756, 31);
            this.lblSecilenDers.Name = "lblSecilenDers";
            this.lblSecilenDers.Size = new System.Drawing.Size(0, 13);
            this.lblSecilenDers.TabIndex = 8;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(271, 109);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(114, 41);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 346);
            this.Controls.Add(this.lblSecilenDers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.TextBox txtDersKodu;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ComboBox cboxHarfNotu;
        private System.Windows.Forms.ComboBox cboxAkts;
        private System.Windows.Forms.ComboBox cboxDersKredisi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSecilenDers;
        private System.Windows.Forms.Button btnSil;
    }
}

