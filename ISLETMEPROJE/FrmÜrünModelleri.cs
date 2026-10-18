using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISLETMEPROJE
{
    public partial class FrmÜrünModelleri : Form
    {
        private int seciliModelId = 0;
        private bool listeYukleniyor = false;

        private readonly string bağlanti =@"Data Source=localhost;Initial Catalog=AydenizDB;Integrated Security=True;Connect Timeout=5;";
        public FrmÜrünModelleri()
        {
            InitializeComponent();
        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            
        {
            string modelAdi = txtModel.Text.Trim();
            string aciklama = txtAçıklama.Text.Trim();

            if (string.IsNullOrWhiteSpace(modelAdi))
            {
                MessageBox.Show(
                    "Lütfen model adını girin.",  "Eksik Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning );

                txtModel.Focus();
                return;
            }

            try
            {
                using (SqlConnection baglanti =new SqlConnection(bağlanti))
                {
                    string sorgu = @"INSERT INTO UrunModelleri(ModelAdi, Aciklama) VALUES
                    (@ModelAdi, @Aciklama)";
                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.Add( "@ModelAdi", SqlDbType.NVarChar, 150 ).Value = modelAdi;

                        komut.Parameters.Add( "@Aciklama", SqlDbType.NVarChar, 500).Value = aciklama;

                        baglanti.Open();
                        komut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Ürün modeli eklendi.","AYDENİZ",MessageBoxButtons.OK,MessageBoxIcon.Information
                );

                ModelleriListele();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show(
                        "Bu isimde bir ürün modeli zaten kayıtlı."
                    );
                }
                else
                {
                    MessageBox.Show( "Model eklenemedi.\n" + ex.Message
                    );
                }
            }
        }
        }

        private void FrmÜrünModelleri_Load(object sender, EventArgs e)
        {
            ModelleriListele();
        }

        private void btnModelTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
            txtModel.Focus();
        }

        private void btnModelDüzenle_Click(object sender, EventArgs e)
        {
         
        
            if (seciliModelId == 0)
            {
                MessageBox.Show(
                    "Düzenlemek için tablodan bir model seçin."
                );

                return;
            }

            string modelAdi = txtModel.Text.Trim();
            string aciklama = txtAçıklama.Text.Trim();

            if (string.IsNullOrWhiteSpace(modelAdi))
            {
                MessageBox.Show("Model adı boş bırakılamaz.");
                txtModel.Focus();
                return;
            }

            try
            {
                int etkilenenKayit;

                using (SqlConnection baglanti = new SqlConnection(bağlanti))
                {
                    string sorgu = @" UPDATE UrunModelleri SET ModelAdi = @ModelAdi, Aciklama = @Aciklama  WHERE ModelId = @ModelId";

                    using (SqlCommand komut =new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.Add("@ModelId",SqlDbType.Int ).Value = seciliModelId;

                        komut.Parameters.Add("@ModelAdi",SqlDbType.NVarChar,150).Value = modelAdi;

                        komut.Parameters.Add( "@Aciklama", SqlDbType.NVarChar, 50 ).Value = aciklama;

                        baglanti.Open();
                        etkilenenKayit = komut.ExecuteNonQuery();
                    }
                }

                if (etkilenenKayit > 0)
                {
                    MessageBox.Show("Ürün modeli güncellendi.");
                }
                else
                {
                    MessageBox.Show(
                        "Seçilen kayıt bulunamadı. Liste yenilenecek."
                    );
                }

                ModelleriListele();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show(
                        "Bu isim başka bir ürün modelinde kullanılıyor."
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Model güncellenemedi.\n" + ex.Message
                    );
                }
            }
        }

        private void btnModelSil_Click(object sender, EventArgs e)
        {
        
            if (seciliModelId == 0)
            {
                MessageBox.Show(
                    "Silmek için tablodan bir model seçin."
                );

                return;
            }

            DialogResult sonuc = MessageBox.Show( "Seçili ürün modelini silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );

            if (sonuc != DialogResult.Yes)
                return;

            try
            {
                int etkilenenKayit;

                using (SqlConnection baglanti =
                       new SqlConnection(bağlanti))
                {
                    string sorgu = @" DELETE FROM UrunModelleri WHERE ModelId = @ModelId";

                    using (SqlCommand komut =new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.Add( "@ModelId", SqlDbType.Int).Value = seciliModelId;

                        baglanti.Open();
                        etkilenenKayit = komut.ExecuteNonQuery();
                    }
                }

                if (etkilenenKayit > 0)
                {
                    MessageBox.Show("Ürün modeli silindi.");
                }
                else
                {
                    MessageBox.Show("Kayıt zaten silinmiş. Liste yenilenecek."  );
                }

                ModelleriListele();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show( "Bu model başka kayıtlarda kullanıldığı için silinemez." );
                }
                else
                {
                    MessageBox.Show( "Model silinemedi.\n" + ex.Message );
                }
            }
        }
        private void ModelleriListele()
        {
            listeYukleniyor = true;

            try
            {
                using (SqlConnection baglanti = new SqlConnection(bağlanti))
                {
                    string sorgu = @"SELECT ModelId, ModelAdi, Aciklama FROM UrunModelleri ORDER BY ModelAdi";

                    using (SqlDataAdapter adapter =new SqlDataAdapter(sorgu, baglanti))
                    {
                        DataTable tablo = new DataTable();

                        adapter.Fill(tablo);
                        dvgModeller.DataSource = tablo;
                        dvgModeller.Columns["ModelId"].Visible = false;
                        dvgModeller.Columns["ModelId"].HeaderText = "Model No";
                        dvgModeller.Columns["ModelAdi"].HeaderText = "Ürün Modeli";
                        dvgModeller.Columns["Aciklama"].HeaderText = "Açıklama";
                    }
                }
             AlanlariTemizle();
            }
            catch (SqlException ex)
            {
                MessageBox.Show( "Modeller listelenemedi.\n" + ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error  );
            }
            finally
            {
                listeYukleniyor = false;
            }
        }
        private void AlanlariTemizle()
        {
            seciliModelId = 0;

            txtModel.Clear();
            txtAçıklama.Clear();

            dvgModeller.ClearSelection();

            btnModelDüzenle.Enabled = false;
            btnModelSil.Enabled = false;
        }

        private void dvgModeller_SelectionChanged(object sender, EventArgs e)
        {
   
        
            if (listeYukleniyor)
                return;

            if (dvgModeller.SelectedRows.Count == 0)
            {
                seciliModelId = 0;
                btnModelDüzenle.Enabled = false;
                btnModelSil.Enabled = false;
                return;
            }

            DataGridViewRow satir = dvgModeller.SelectedRows[0];

            seciliModelId =Convert.ToInt32(satir.Cells["ModelId"].Value);

            txtModel.Text = Convert.ToString(satir.Cells["ModelAdi"].Value);

            txtAçıklama.Text =Convert.ToString(satir.Cells["Aciklama"].Value);

            btnModelDüzenle.Enabled = true;
            btnModelSil.Enabled = true;
        }
    }
    }
    
    


