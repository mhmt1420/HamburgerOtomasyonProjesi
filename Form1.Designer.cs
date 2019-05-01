namespace hamburgerOtomasyon
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
            this.cbMenuler = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbBoyut = new System.Windows.Forms.GroupBox();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnMenuEkle = new System.Windows.Forms.Button();
            this.btnEkstraEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Seçin:";
            // 
            // cbMenuler
            // 
            this.cbMenuler.FormattingEnabled = true;
            this.cbMenuler.Location = new System.Drawing.Point(15, 160);
            this.cbMenuler.Name = "cbMenuler";
            this.cbMenuler.Size = new System.Drawing.Size(236, 21);
            this.cbMenuler.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 103);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // gbBoyut
            // 
            this.gbBoyut.Controls.Add(this.rbBuyuk);
            this.gbBoyut.Controls.Add(this.rbKucuk);
            this.gbBoyut.Controls.Add(this.rbOrta);
            this.gbBoyut.Location = new System.Drawing.Point(15, 204);
            this.gbBoyut.Name = "gbBoyut";
            this.gbBoyut.Size = new System.Drawing.Size(111, 111);
            this.gbBoyut.TabIndex = 3;
            this.gbBoyut.TabStop = false;
            this.gbBoyut.Text = "Boyut Seçin";
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(6, 19);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(55, 17);
            this.rbBuyuk.TabIndex = 4;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Location = new System.Drawing.Point(6, 65);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(56, 17);
            this.rbKucuk.TabIndex = 5;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(6, 42);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(45, 17);
            this.rbOrta.TabIndex = 6;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(144, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ekstralar Malzemeler";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(147, 232);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 98);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adet:";
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(51, 336);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(120, 20);
            this.nmrAdet.TabIndex = 7;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(229, 372);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSiparisEkle.TabIndex = 8;
            this.btnSiparisEkle.TabStop = false;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.Location = new System.Drawing.Point(336, 12);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(474, 186);
            this.lstSiparisler.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(552, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Toplam Tutar:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(668, 246);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(52, 17);
            this.lblTutar.TabIndex = 11;
            this.lblTutar.Text = "label5";
            // 
            // btnSiparis
            // 
            this.btnSiparis.Location = new System.Drawing.Point(403, 372);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(110, 23);
            this.btnSiparis.TabIndex = 12;
            this.btnSiparis.Text = "Siparişi Tamamla";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // btnMenuEkle
            // 
            this.btnMenuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEkle.Location = new System.Drawing.Point(575, 372);
            this.btnMenuEkle.Name = "btnMenuEkle";
            this.btnMenuEkle.Size = new System.Drawing.Size(75, 23);
            this.btnMenuEkle.TabIndex = 13;
            this.btnMenuEkle.Text = "Menü Ekle";
            this.btnMenuEkle.UseVisualStyleBackColor = true;
            this.btnMenuEkle.Click += new System.EventHandler(this.btnMenuEkle_Click);
            // 
            // btnEkstraEkle
            // 
            this.btnEkstraEkle.Location = new System.Drawing.Point(688, 372);
            this.btnEkstraEkle.Name = "btnEkstraEkle";
            this.btnEkstraEkle.Size = new System.Drawing.Size(103, 23);
            this.btnEkstraEkle.TabIndex = 14;
            this.btnEkstraEkle.Text = "Ekstra Ekleme";
            this.btnEkstraEkle.UseVisualStyleBackColor = true;
            this.btnEkstraEkle.Click += new System.EventHandler(this.btnEkstraEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 421);
            this.Controls.Add(this.btnEkstraEkle);
            this.Controls.Add(this.btnMenuEkle);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbBoyut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbMenuler);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbBoyut.ResumeLayout(false);
            this.gbBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbBoyut;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSiparis;
        public System.Windows.Forms.ComboBox cbMenuler;
        private System.Windows.Forms.Button btnMenuEkle;
        private System.Windows.Forms.Button btnEkstraEkle;
    }
}

