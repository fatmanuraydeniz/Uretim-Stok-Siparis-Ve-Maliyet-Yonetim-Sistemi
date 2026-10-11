using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISLETMEPROJE
{
    public partial class FrmGiris : Form
    {
        private int kalanGirisHakki = 5;
        private bool girisKilitli = false;

        private readonly Stopwatch kilitSayaci = new Stopwatch();
        private readonly TimeSpan kilitSuresi = TimeSpan.FromMinutes(5);

        private readonly string bağlanti = @"Data Source=localhost;Initial Catalog=AydenizDB;Integrated Security=True;Connect Timeout=5;";
        public FrmGiris()
        {
            InitializeComponent();
            txtsifre.UseSystemPasswordChar = true;
            sifrecb.CheckedChanged += sifrecb_CheckedChanged;

            lblHata.ForeColor = Color.Red;
            lblHata.Text = "Kalan giriş hakkı=5";
            tmrKilit.Interval = 1000;
            tmrKilit.Enabled = false;
            tmrKilit.Tick += tmrKilit_Tick;
            AcceptButton = btnGiris;
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (girisKilitli)
                return;

            string kullaniciAdi = txtKadi.Text.Trim();
            string parola = txtsifre.Text;

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrEmpty(parola))
            {
                lblHata.Text = "Kullanıcı adı ve şifreyi girin.\n" + "Kalan giriş hakkı: " + kalanGirisHakki;

                return;
            }

            btnGiris.Enabled = false;

            try
            {
                string kayitliParola;

                using (SqlConnection baglanti = new SqlConnection(bağlanti))
                {
                    baglanti.Open();

                    string sorgu = @" SELECT Parola FROM dbo.Kullanicilar WHERE KullaniciAdi = @KullaniciAdi";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar, 50).Value = kullaniciAdi;

                        using (SqlDataReader dr = komut.ExecuteReader())
                        {
                            if (!dr.Read())
                            {
                                BasarisizGiris("Kullanıcı bulunamadı.");
                                return;
                            }

                            if (dr.IsDBNull(0))
                            {
                                lblHata.Text =
                                    "Bu kullanıcı için henüz şifre belirlenmemiş.\n" +
                                    "Kalan giriş hakkı: " + kalanGirisHakki;

                                return;
                            }

                            kayitliParola = dr.GetString(0);
                        }
                    }
                }

                if (!string.Equals(parola,kayitliParola,StringComparison.Ordinal))
                {
                    BasarisizGiris("Şifre hatalı.");

                    txtsifre.Clear();
                    txtsifre.Focus();

                    return;
                }

                kalanGirisHakki = 5;
                lblHata.Text = "";
                txtsifre.Clear();

                FrmAnaEkran anaEkran = new FrmAnaEkran();

                anaEkran.FormClosed += (s, args) => this.Close();

                anaEkran.Show();
                this.Hide();
            }
            catch (SqlException)
            {
                lblHata.Text ="Veritabanı bağlantısı veya sorgusu başarısız.\n" + "Kalan giriş hakkı: " + kalanGirisHakki;
            }
            catch (Exception)
            {
                lblHata.Text = "Giriş sırasında bir hata oluştu.\n" + "Kalan giriş hakkı: " + kalanGirisHakki;
            }
            finally
            {
                btnGiris.Enabled = !girisKilitli;
            }
        }
        
        private void BasarisizGiris(string hataMesaji)
        {
            kalanGirisHakki--;

            lblHata.ForeColor = Color.Red;
            lblHata.Visible = true;

            if (kalanGirisHakki > 0)
            {
                lblHata.Text =hataMesaji + "\n" +"Kalan giriş hakkı: " + kalanGirisHakki;

                return;
            }

            girisKilitli = true;
            btnGiris.Enabled = false;

            kilitSayaci.Restart();
            tmrKilit.Start();

            lblHata.Text = hataMesaji + " Kalan giriş hakkı: 0.\n" + "Giriş kilitlendi. Kalan süre: 05:00 dakika";
        }

        private void tmrKilit_Tick(object sender, EventArgs e)
        {
            TimeSpan kalanSure = kilitSuresi - kilitSayaci.Elapsed;

            if (kalanSure <= TimeSpan.Zero)
            {
                tmrKilit.Stop();
                kilitSayaci.Reset();

                girisKilitli = false;
                kalanGirisHakki = 5;

                btnGiris.Enabled = true;
                txtsifre.Clear();

                lblHata.Text = "Kilit süresi sona erdi. Tekrar deneyebilirsiniz.\n" + "Kalan giriş hakkı: 5";

                txtsifre.Focus();
                return;
            }

            int toplamSaniye = (int)Math.Ceiling(kalanSure.TotalSeconds);

            int dakika = toplamSaniye / 60;
            int saniye = toplamSaniye % 60;

            lblHata.Text = "Kalan giriş hakkı: 0. Giriş kilitli.\n" + "Kalan süre: " + dakika.ToString("00") + ":" + saniye.ToString("00");
        }

        private void sifrecb_CheckedChanged(object sender, EventArgs e)
        {


            if (sifrecb.Checked)
            {
                txtsifre.UseSystemPasswordChar =false ;
            }
            else
            {
                txtsifre.UseSystemPasswordChar=true;
            }
        }
    }
}
