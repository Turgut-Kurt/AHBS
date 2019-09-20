using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHBS
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtKullanici.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("eksik bilgi");
                return;
            }
            string Kullanici, Sifre;
            Kullanici = txtKullanici.Text;
            Sifre = txtSifre.Text;
            if (Kullanici=="admin" && Sifre=="123456")
            {
                this.Hide();
                AnaForm aform = new AnaForm();
                aform.Show();

            }
            else
            {
                MessageBox.Show("Kullanici adi veya sifre yanlış");
            }

        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
