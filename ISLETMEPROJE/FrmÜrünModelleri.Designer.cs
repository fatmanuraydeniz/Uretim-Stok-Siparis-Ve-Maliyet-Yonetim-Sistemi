namespace ISLETMEPROJE
{
    partial class FrmÜrünModelleri
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
            this.lblİsim = new System.Windows.Forms.Label();
            this.lblAçıklama = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAçıklama = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblÜrünAçıklama = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.dvgModeller = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModelTemizle = new System.Windows.Forms.Button();
            this.btnModelSil = new System.Windows.Forms.Button();
            this.btnModelDüzenle = new System.Windows.Forms.Button();
            this.btnModelEkle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgModeller)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblİsim
            // 
            this.lblİsim.AutoSize = true;
            this.lblİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblİsim.Location = new System.Drawing.Point(45, 25);
            this.lblİsim.Name = "lblİsim";
            this.lblİsim.Size = new System.Drawing.Size(292, 48);
            this.lblİsim.TabIndex = 0;
            this.lblİsim.Text = "Ürün Modelleri";
            // 
            // lblAçıklama
            // 
            this.lblAçıklama.AutoSize = true;
            this.lblAçıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAçıklama.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAçıklama.Location = new System.Drawing.Point(56, 82);
            this.lblAçıklama.Name = "lblAçıklama";
            this.lblAçıklama.Size = new System.Drawing.Size(427, 25);
            this.lblAçıklama.TabIndex = 1;
            this.lblAçıklama.Text = "Ürün modellerini ekleyin, düzenleyin ve listeleyin";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAçıklama);
            this.panel1.Controls.Add(this.txtModel);
            this.panel1.Controls.Add(this.lblÜrünAçıklama);
            this.panel1.Controls.Add(this.lblModel);
            this.panel1.Controls.Add(this.lblİsim);
            this.panel1.Controls.Add(this.lblAçıklama);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 273);
            this.panel1.TabIndex = 2;
            // 
            // txtAçıklama
            // 
            this.txtAçıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAçıklama.Location = new System.Drawing.Point(160, 201);
            this.txtAçıklama.Name = "txtAçıklama";
            this.txtAçıklama.Size = new System.Drawing.Size(776, 30);
            this.txtAçıklama.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtModel.Location = new System.Drawing.Point(160, 143);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(776, 30);
            this.txtModel.TabIndex = 4;
            // 
            // lblÜrünAçıklama
            // 
            this.lblÜrünAçıklama.AutoSize = true;
            this.lblÜrünAçıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblÜrünAçıklama.Location = new System.Drawing.Point(48, 201);
            this.lblÜrünAçıklama.Name = "lblÜrünAçıklama";
            this.lblÜrünAçıklama.Size = new System.Drawing.Size(98, 25);
            this.lblÜrünAçıklama.TabIndex = 3;
            this.lblÜrünAçıklama.Text = "Açıklama:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblModel.Location = new System.Drawing.Point(48, 143);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(106, 25);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model Adı:";
            // 
            // dvgModeller
            // 
            this.dvgModeller.AllowUserToAddRows = false;
            this.dvgModeller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgModeller.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgModeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgModeller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgModeller.GridColor = System.Drawing.Color.LightSlateGray;
            this.dvgModeller.Location = new System.Drawing.Point(0, 273);
            this.dvgModeller.MultiSelect = false;
            this.dvgModeller.Name = "dvgModeller";
            this.dvgModeller.ReadOnly = true;
            this.dvgModeller.RowHeadersVisible = false;
            this.dvgModeller.RowHeadersWidth = 51;
            this.dvgModeller.RowTemplate.Height = 24;
            this.dvgModeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgModeller.Size = new System.Drawing.Size(1276, 529);
            this.dvgModeller.TabIndex = 3;
            this.dvgModeller.SelectionChanged += new System.EventHandler(this.dvgModeller_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnModelTemizle);
            this.panel2.Controls.Add(this.btnModelSil);
            this.panel2.Controls.Add(this.btnModelDüzenle);
            this.panel2.Controls.Add(this.btnModelEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 702);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1276, 100);
            this.panel2.TabIndex = 4;
            // 
            // btnModelTemizle
            // 
            this.btnModelTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnModelTemizle.Location = new System.Drawing.Point(960, 23);
            this.btnModelTemizle.Name = "btnModelTemizle";
            this.btnModelTemizle.Size = new System.Drawing.Size(194, 63);
            this.btnModelTemizle.TabIndex = 3;
            this.btnModelTemizle.Text = "Temizle";
            this.btnModelTemizle.UseVisualStyleBackColor = true;
            this.btnModelTemizle.Click += new System.EventHandler(this.btnModelTemizle_Click);
            // 
            // btnModelSil
            // 
            this.btnModelSil.BackColor = System.Drawing.Color.Crimson;
            this.btnModelSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnModelSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModelSil.Location = new System.Drawing.Point(683, 23);
            this.btnModelSil.Name = "btnModelSil";
            this.btnModelSil.Size = new System.Drawing.Size(194, 63);
            this.btnModelSil.TabIndex = 2;
            this.btnModelSil.Text = "Sil";
            this.btnModelSil.UseVisualStyleBackColor = false;
            this.btnModelSil.Click += new System.EventHandler(this.btnModelSil_Click);
            // 
            // btnModelDüzenle
            // 
            this.btnModelDüzenle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnModelDüzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnModelDüzenle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModelDüzenle.Location = new System.Drawing.Point(367, 23);
            this.btnModelDüzenle.Name = "btnModelDüzenle";
            this.btnModelDüzenle.Size = new System.Drawing.Size(194, 63);
            this.btnModelDüzenle.TabIndex = 1;
            this.btnModelDüzenle.Text = "Düzenle";
            this.btnModelDüzenle.UseVisualStyleBackColor = false;
            this.btnModelDüzenle.Click += new System.EventHandler(this.btnModelDüzenle_Click);
            // 
            // btnModelEkle
            // 
            this.btnModelEkle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModelEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnModelEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModelEkle.Location = new System.Drawing.Point(64, 23);
            this.btnModelEkle.Name = "btnModelEkle";
            this.btnModelEkle.Size = new System.Drawing.Size(194, 63);
            this.btnModelEkle.TabIndex = 0;
            this.btnModelEkle.Text = "Ürün Ekle";
            this.btnModelEkle.UseVisualStyleBackColor = false;
            this.btnModelEkle.Click += new System.EventHandler(this.btnModelEkle_Click);
            // 
            // FrmÜrünModelleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 802);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dvgModeller);
            this.Controls.Add(this.panel1);
            this.Name = "FrmÜrünModelleri";
            this.Text = "FrmÜrünModelleri";
            this.Load += new System.EventHandler(this.FrmÜrünModelleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgModeller)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblİsim;
        private System.Windows.Forms.Label lblAçıklama;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAçıklama;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblÜrünAçıklama;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.DataGridView dvgModeller;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModelTemizle;
        private System.Windows.Forms.Button btnModelSil;
        private System.Windows.Forms.Button btnModelDüzenle;
        private System.Windows.Forms.Button btnModelEkle;
    }
}