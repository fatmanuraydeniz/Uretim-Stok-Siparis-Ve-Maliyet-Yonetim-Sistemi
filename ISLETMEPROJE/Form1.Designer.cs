namespace ISLETMEPROJE
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hglabel = new System.Windows.Forms.Label();
            this.girişlabel = new System.Windows.Forms.Label();
            this.kadilabel = new System.Windows.Forms.Label();
            this.sifrelabel = new System.Windows.Forms.Label();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.sifrecb = new System.Windows.Forms.CheckBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblaçıklama3 = new System.Windows.Forms.Label();
            this.lblaıklama2 = new System.Windows.Forms.Label();
            this.açıklamalbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHata = new System.Windows.Forms.Label();
            this.tmrKilit = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hglabel
            // 
            this.hglabel.AutoSize = true;
            this.hglabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hglabel.Location = new System.Drawing.Point(632, 64);
            this.hglabel.Name = "hglabel";
            this.hglabel.Size = new System.Drawing.Size(270, 48);
            this.hglabel.TabIndex = 0;
            this.hglabel.Text = "Hoş Geldiniz";
            // 
            // girişlabel
            // 
            this.girişlabel.AutoSize = true;
            this.girişlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.girişlabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.girişlabel.Location = new System.Drawing.Point(637, 137);
            this.girişlabel.Name = "girişlabel";
            this.girişlabel.Size = new System.Drawing.Size(309, 20);
            this.girişlabel.TabIndex = 1;
            this.girişlabel.Text = "Devam etmek için hesabınıza giriş yapın";
            // 
            // kadilabel
            // 
            this.kadilabel.AutoSize = true;
            this.kadilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kadilabel.Location = new System.Drawing.Point(635, 204);
            this.kadilabel.Name = "kadilabel";
            this.kadilabel.Size = new System.Drawing.Size(119, 25);
            this.kadilabel.TabIndex = 2;
            this.kadilabel.Text = "Kullanıcı Adı";
            // 
            // sifrelabel
            // 
            this.sifrelabel.AutoSize = true;
            this.sifrelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sifrelabel.Location = new System.Drawing.Point(636, 307);
            this.sifrelabel.Name = "sifrelabel";
            this.sifrelabel.Size = new System.Drawing.Size(68, 25);
            this.sifrelabel.TabIndex = 3;
            this.sifrelabel.Text = "Parola";
            // 
            // txtKadi
            // 
            this.txtKadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKadi.Location = new System.Drawing.Point(642, 255);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(387, 30);
            this.txtKadi.TabIndex = 4;
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtsifre.Location = new System.Drawing.Point(642, 351);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(387, 30);
            this.txtsifre.TabIndex = 5;
            // 
            // sifrecb
            // 
            this.sifrecb.AutoSize = true;
            this.sifrecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sifrecb.Location = new System.Drawing.Point(641, 415);
            this.sifrecb.Name = "sifrecb";
            this.sifrecb.Size = new System.Drawing.Size(147, 24);
            this.sifrecb.TabIndex = 6;
            this.sifrecb.Text = "Parolayı Göster";
            this.sifrecb.UseVisualStyleBackColor = true;
            this.sifrecb.CheckedChanged += new System.EventHandler(this.sifrecb_CheckedChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGiris.Location = new System.Drawing.Point(641, 486);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(397, 50);
            this.btnGiris.TabIndex = 7;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblaçıklama3);
            this.panel1.Controls.Add(this.lblaıklama2);
            this.panel1.Controls.Add(this.açıklamalbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 643);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aydeniz İşletme Yönetim Sistemleri";
            // 
            // lblaçıklama3
            // 
            this.lblaçıklama3.AutoSize = true;
            this.lblaçıklama3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblaçıklama3.ForeColor = System.Drawing.Color.LightGray;
            this.lblaçıklama3.Location = new System.Drawing.Point(65, 413);
            this.lblaçıklama3.Name = "lblaçıklama3";
            this.lblaçıklama3.Size = new System.Drawing.Size(343, 29);
            this.lblaçıklama3.TabIndex = 3;
            this.lblaçıklama3.Text = "aynı akışta, güvenle bir arada";
            // 
            // lblaıklama2
            // 
            this.lblaıklama2.AutoSize = true;
            this.lblaıklama2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblaıklama2.ForeColor = System.Drawing.Color.LightGray;
            this.lblaıklama2.Location = new System.Drawing.Point(35, 367);
            this.lblaıklama2.Name = "lblaıklama2";
            this.lblaıklama2.Size = new System.Drawing.Size(331, 29);
            this.lblaıklama2.TabIndex = 2;
            this.lblaıklama2.Text = "Üretim ,stok ve siparişleriniz";
            // 
            // açıklamalbl
            // 
            this.açıklamalbl.AutoSize = true;
            this.açıklamalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.açıklamalbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.açıklamalbl.Location = new System.Drawing.Point(9, 253);
            this.açıklamalbl.Name = "açıklamalbl";
            this.açıklamalbl.Size = new System.Drawing.Size(527, 48);
            this.açıklamalbl.TabIndex = 1;
            this.açıklamalbl.Text = "İşletmenize yeni bir bakış.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ISLETMEPROJE.Properties.Resources.ChatGPT_Görseli_11_Eki_2026_15_00_58;
            this.pictureBox1.Location = new System.Drawing.Point(17, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHata.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHata.Location = new System.Drawing.Point(664, 558);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(64, 25);
            this.lblHata.TabIndex = 9;
            this.lblHata.Text = "label2";
            this.lblHata.Visible = false;
            // 
            // tmrKilit
            // 
            this.tmrKilit.Tick += new System.EventHandler(this.btnGiris_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 667);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.sifrecb);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.sifrelabel);
            this.Controls.Add(this.kadilabel);
            this.Controls.Add(this.girişlabel);
            this.Controls.Add(this.hglabel);
            this.Name = "FrmGiris";
            this.Text = "GİRİŞ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hglabel;
        private System.Windows.Forms.Label girişlabel;
        private System.Windows.Forms.Label kadilabel;
        private System.Windows.Forms.Label sifrelabel;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.CheckBox sifrecb;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label açıklamalbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblaçıklama3;
        private System.Windows.Forms.Label lblaıklama2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.Timer tmrKilit;
    }
}

