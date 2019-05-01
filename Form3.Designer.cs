namespace hamburgerOtomasyon
{
    partial class Form3
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
            this.txtEkstraAd = new System.Windows.Forms.TextBox();
            this.txtEkstraFiyat = new System.Windows.Forms.TextBox();
            this.btnEkstraEkleme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ekstra Fiyat:";
            // 
            // txtEkstraAd
            // 
            this.txtEkstraAd.Location = new System.Drawing.Point(114, 109);
            this.txtEkstraAd.Name = "txtEkstraAd";
            this.txtEkstraAd.Size = new System.Drawing.Size(100, 20);
            this.txtEkstraAd.TabIndex = 2;
            // 
            // txtEkstraFiyat
            // 
            this.txtEkstraFiyat.Location = new System.Drawing.Point(114, 149);
            this.txtEkstraFiyat.Name = "txtEkstraFiyat";
            this.txtEkstraFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtEkstraFiyat.TabIndex = 3;
            // 
            // btnEkstraEkleme
            // 
            this.btnEkstraEkleme.Location = new System.Drawing.Point(148, 208);
            this.btnEkstraEkleme.Name = "btnEkstraEkleme";
            this.btnEkstraEkleme.Size = new System.Drawing.Size(75, 23);
            this.btnEkstraEkleme.TabIndex = 4;
            this.btnEkstraEkleme.Text = "ekstra Ekle";
            this.btnEkstraEkleme.UseVisualStyleBackColor = true;
            this.btnEkstraEkleme.Click += new System.EventHandler(this.btnEkstraEkleme_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEkstraEkleme);
            this.Controls.Add(this.txtEkstraFiyat);
            this.Controls.Add(this.txtEkstraAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEkstraAd;
        private System.Windows.Forms.TextBox txtEkstraFiyat;
        private System.Windows.Forms.Button btnEkstraEkleme;
    }
}