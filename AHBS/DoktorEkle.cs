using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AHBS
{
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
        }
        static string yol = "Data Source=DESKTOP-3L5LDLR;Initial Catalog=AHBS;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(yol);
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State==ConnectionState.Closed)
                {
                    baglanti.Open();
                    string kayit = "INSERT INTO Doktor_Bilgileri (tc_no,ad_soyad,sicil_no,cep_tel,ev_tel,adres,e_mail,kayit_tarihi,kayit_saati) VALUES (@tc,@ad_soyad,@sicil_no,@cep_tel,@ev_tel,@adres,@e_mail,@kayit_tarihi,@kayit_saati)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.Add("@tc", SqlDbType.NVarChar);
                    komut.Parameters["@tc"].Value = txtTC.Text.Trim();
                    komut.Parameters.Add("@ad_soyad", SqlDbType.NVarChar);
                    komut.Parameters["@ad_soyad"].Value = txtAd.Text.Trim();
                    komut.Parameters.Add("@sicil_no", SqlDbType.NVarChar);
                    komut.Parameters["@sicil_no"].Value = txtSicil.Text.Trim();
                    komut.Parameters.Add("@cep_tel", SqlDbType.NVarChar);
                    komut.Parameters["@cep_tel"].Value = txtCep.Text.Trim();
                    komut.Parameters.Add("@ev_tel", SqlDbType.NVarChar);
                    komut.Parameters["@ev_tel"].Value = txtEv.Text.Trim();
                    komut.Parameters.Add("@adres", SqlDbType.NVarChar);
                    komut.Parameters["@adres"].Value = txtAdres.Text.Trim();
                    komut.Parameters.Add("@e_mail", SqlDbType.NVarChar);
                    komut.Parameters["@e_mail"].Value = txtMail.Text.Trim();
                    komut.Parameters.Add("@kayit_tarihi", SqlDbType.Date);
                    komut.Parameters["@kayit_tarihi"].Value = txttarih.Text.Trim();
                    komut.Parameters.Add("@kayit_saati", SqlDbType.Time);
                    komut.Parameters["@kayit_saati"].Value = txtsaat.Text.Trim();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                } 
            }
            catch (Exception hata)
            {
                MessageBox.Show("hata olustu  "+hata.Message);
            }
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
            MessageBox.Show("Kayıt Edildi.");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {
            txttarih.Text = DateTime.Now.ToShortDateString();
            txtsaat.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
