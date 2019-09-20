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
using System.Data.SqlTypes;

namespace AHBS
{
    public partial class HastaEkle : Form
    {
        public HastaEkle()
        {
            InitializeComponent();
        }
        static string yol = "Data Source=DESKTOP-3L5LDLR;Initial Catalog=AHBS;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(yol);
        private void HastaEkle_Load(object sender, EventArgs e)
        {
            txtHtarih.Text = DateTime.Now.ToShortDateString();
            txtHsaat.Text = DateTime.Now.ToShortTimeString();
            cmbbxUyruk.SelectedIndex = 0;
            cmbbxCinsiyet.SelectedIndex = 0;
            cmbbxSosyal.SelectedIndex = 0;
            cmbbxMedeni.SelectedIndex = 0;
        }

        private void btnHastakaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    string kayit = "INSERT INTO Hasta_Bilgilerii (htc_no,ad_soyad,baba_adi,ana_adi,uyruk,dogum_yeri,dogum_tarihi,cinsiyet,sosyal_guvence,sosyal_guvenlikno,medeni_durumu,il,ilce,  belde,mahalle,apt_no,kat_no,daire_no,ev_tel,cep_tel,e_mail,kayit_tarihi,kayit_saati) VALUES (@htc_no,@ad_soyad,@baba_adi,@ana_adi,@uyruk,@dogum_yeri,@dogum_tarihi,@cinsiyet,@sosyal_guvence,@sosyal_guvenlikno,@medeni_durumu,@il,@ilce,@belde,@mahalle,@apt_no,@kat_no,@daire_no,@ev_tel,@cep_tel,@e_mail,@kayit_tarihi,@kayit_saati)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.Add("@htc_no", SqlDbType.NVarChar);
                    komut.Parameters["@htc_no"].Value = txtHastatc.Text.Trim();
                    komut.Parameters.Add("@ad_soyad", SqlDbType.NVarChar);
                    komut.Parameters["@ad_soyad"].Value = txtHastaAd.Text.Trim();
                    komut.Parameters.Add("@baba_adi", SqlDbType.NVarChar);
                    komut.Parameters["@baba_adi"].Value = txtHbabaAdi.Text.Trim();
                    komut.Parameters.Add("@ana_adi", SqlDbType.NVarChar);
                    komut.Parameters["@ana_adi"].Value = txtHanaAdi.Text.Trim();
                    komut.Parameters.Add("@uyruk", SqlDbType.NVarChar);
                    komut.Parameters["@uyruk"].Value = cmbbxUyruk.Text.Trim();
                    komut.Parameters.Add("@dogum_yeri", SqlDbType.NVarChar);
                    komut.Parameters["@dogum_yeri"].Value = txtHdogyer.Text.Trim();
                    komut.Parameters.Add("@dogum_tarihi", SqlDbType.Date);
                    komut.Parameters["@dogum_tarihi"].Value =dateTimePicker1.Value.Date;
                    komut.Parameters.Add("@cinsiyet", SqlDbType.NVarChar);
                    komut.Parameters["@cinsiyet"].Value = cmbbxCinsiyet.Text.Trim();
                    komut.Parameters.Add("@sosyal_guvence", SqlDbType.NVarChar);
                    komut.Parameters["@sosyal_guvence"].Value = cmbbxSosyal.Text.Trim();
                    komut.Parameters.Add("@sosyal_guvenlikno", SqlDbType.NVarChar);
                    komut.Parameters["@sosyal_guvenlikno"].Value = txtHsguvno.Text.Trim();
                    komut.Parameters.Add("@medeni_durumu", SqlDbType.NVarChar);
                    komut.Parameters["@medeni_durumu"].Value = cmbbxMedeni.Text.Trim();
                    komut.Parameters.Add("@il", SqlDbType.NVarChar);
                    komut.Parameters["@il"].Value = txtHasil.Text.Trim();
                    komut.Parameters.Add("@ilce", SqlDbType.NVarChar);
                    komut.Parameters["@ilce"].Value = txtHasilce.Text.Trim();
                    komut.Parameters.Add("@belde", SqlDbType.NVarChar);
                    komut.Parameters["@belde"].Value = txtHBelde.Text.Trim();
                    komut.Parameters.Add("@mahalle", SqlDbType.NVarChar);
                    komut.Parameters["@mahalle"].Value = txtHMah.Text.Trim();
                    komut.Parameters.Add("@apt_no", SqlDbType.NVarChar);
                    komut.Parameters["@apt_no"].Value = txtAptno.Text.Trim();
                    komut.Parameters.Add("@kat_no", SqlDbType.NVarChar);
                    komut.Parameters["@kat_no"].Value = txtKatno.Text.Trim();
                    komut.Parameters.Add("@daire_no", SqlDbType.NVarChar);
                    komut.Parameters["@daire_no"].Value = txtHDaireno.Text.Trim();
                    komut.Parameters.Add("@ev_tel", SqlDbType.NVarChar);
                    komut.Parameters["@ev_tel"].Value = txtHevtel.Text.Trim();
                    komut.Parameters.Add("@cep_tel", SqlDbType.NVarChar);
                    komut.Parameters["@cep_tel"].Value = txtHCep.Text.Trim();
                    komut.Parameters.Add("@e_mail", SqlDbType.NVarChar);
                    komut.Parameters["@e_mail"].Value = txtHmail.Text.Trim();
                    komut.Parameters.Add("@kayit_tarihi", SqlDbType.Date);
                    komut.Parameters["@kayit_tarihi"].Value = txtHtarih.Text.Trim();
                    komut.Parameters.Add("@kayit_saati", SqlDbType.Time);
                    komut.Parameters["@kayit_saati"].Value = txtHsaat.Text.Trim();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("hata olustur  " + hata.Message);
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

        private void btnHastakapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHdogyer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHtarih_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
