using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISLETMEPROJE
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
            pnlIcerik.Visible = true;
            pnlIcerik.BringToFront();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            MenuSec(btnAnaEkran);
        }
        private void FormAc(Form acilacakForm)
        {
            pnlIcerik.Visible = false;

            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == acilacakForm.GetType())
                {
                    acilacakForm.Dispose();

                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                    return;
                }
            }

            acilacakForm.MdiParent = this;
            acilacakForm.FormBorderStyle = FormBorderStyle.None;
            acilacakForm.Show();
            acilacakForm.WindowState = FormWindowState.Maximized;
        }


        private void btnUrunModelleri_Click(object sender, EventArgs e)
        {
            FormAc(new FrmÜrünModelleri());
            MenuSec(btnUrunModelleri);
        }

        private void btnStokBilgileri_Click(object sender, EventArgs e)
        {
            FormAc(new FrmStokBilgileri());
            MenuSec(btnStokBilgileri);
        }

        private void btnMalzemler_Click(object sender, EventArgs e)
        {
            FormAc(new FrmMalzemeler());
            MenuSec(btnMalzemeler);
        }

        private void btnUrunMaliyetleri_Click(object sender, EventArgs e)
        {
            FormAc(new FrmÜrünMaliyetleri());
            MenuSec(btnUrunMaliyetleri);
        }

        private void btnFiyatListesi_Click(object sender, EventArgs e)
        {
            FormAc(new FrmFiyatListesi());
            MenuSec(btnFiyatListesi);
        }

        private void btnSiparişler_Click(object sender, EventArgs e)
        {
            FormAc(new FrmSiparişler());
            MenuSec(btnSiparişler);
        }

        private void btnSevkiyat_Click(object sender, EventArgs e)
        {
            FormAc(new FrmSevkiyat());
            MenuSec(btnSevkiyat);
        }

        private void btnMüşteriler_Click(object sender, EventArgs e)
        {
            FormAc(new FrmMüşteriler());
            MenuSec(btnMüşteriler);
        }

        private void btnİşlemGeçmişi_Click(object sender, EventArgs e)
        {
            FormAc(new FrmİşlemGeçmişi());
            MenuSec(btnİşlemGeçmişi);
        }

        private void btnYedekleme_Click(object sender, EventArgs e)
        {
            FormAc(new FrmYedekleme());
            MenuSec(btnYedekleme);
        }

        private void btnAnaEkran_Click(object sender, EventArgs e)
        {
            AnaSayfayiGoster();
        }
        private void MenuSec(Button secilenButon)
        {
            foreach (Control kontrol in flpMenu.Controls)
            {
                Button buton = kontrol as Button;

                if (buton != null)
                {
                    buton.BackColor = Color.FromArgb(18, 47, 70);
                    buton.ForeColor = Color.White;
                }
            }

            secilenButon.BackColor = Color.FromArgb(0, 150, 165);
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?","AYDENİZ" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void AnaSayfayiGoster()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            pnlIcerik.Show();
            pnlIcerik.BringToFront();

            MenuSec(btnAnaEkran);
        }
    }
}
