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
    public partial class HastaMuayene : Form
    {
        public HastaMuayene()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3L5LDLR;Initial Catalog=AHBS;Integrated Security=True");
        DataSet ds;
        static string deger;
        static string deger2;
        void temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }

            }
        }

        private void HastaMuayene_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hasta_Bilgilerii", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT ad_soyad FROM Doktor_Bilgileri";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbbxDoktor.Items.Add(dr["ad_soyad"]);
            }
            baglanti.Close();
            cmbbxDoktor.SelectedIndex = 0;
            cmbbxMUyruk.SelectedIndex = 0;
            cmbbxMCinsiyet.SelectedIndex = 0;
            cmbbxMSosyal.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            temizle();
            txtHastaMtc.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtHastaMAd.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtHMbabaAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtHManaAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbbxMUyruk.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtHMdogyer.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmbbxMCinsiyet.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            cmbbxMSosyal.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtHMsguvno.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            cmbbxMMedeni.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtHasMil.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtHasMilce.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            txtHMBelde.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            txtHMMah.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            txtMAptno.Text = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
            txtMKatno.Text = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
            txtHMDaireno.Text = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
            txtHMevtel.Text = dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
            txtHMCep.Text = dataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString();
            txtHMmail.Text = dataGridView1.Rows[e.RowIndex].Cells[21].Value.ToString();
            deger= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHMtarih.Text = DateTime.Now.ToShortDateString();
            txtHMsaat.Text = DateTime.Now.ToShortTimeString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtHastaMtc.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            /*textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();*/

        }
        private void dataGridView1_Click(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHastakapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHastakaydet_Click(object sender, EventArgs e)
        {
            string kayit = "INSERT INTO Muayene_Kayit (islemturu,HastaID,DoktorID,kayit_tarihi,kayit_saati) VALUES (@islemturu,@HastaID,@DoktorID,@kayit_tarihi,@kayit_saati)";
            string doktor = cmbbxDoktor.Text;

            SqlDataAdapter da = new SqlDataAdapter("SELECT DoktorID FROM Doktor_Bilgileri WHERE ad_soyad LIKE '" + doktor + "%'", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            deger2 = dataGridView2.Rows[0].Cells[0].Value.ToString();
            if (radioButton1.Checked)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.Add("@islemturu", SqlDbType.NVarChar);
                komut.Parameters["@islemturu"].Value = radioButton1.Text;
                komut.Parameters.Add("@HastaID", SqlDbType.Int);
                komut.Parameters["@HastaID"].Value = deger;
                komut.Parameters.Add("@DoktorID", SqlDbType.Int);
                komut.Parameters["@DoktorID"].Value = deger2;
                komut.Parameters.Add("@kayit_tarihi", SqlDbType.Date);
                komut.Parameters["@kayit_tarihi"].Value = txtHMtarih.Text.Trim();
                komut.Parameters.Add("@kayit_saati", SqlDbType.Time);
                komut.Parameters["@kayit_saati"].Value = txtHMsaat.Text.Trim();
                komut.ExecuteNonQuery();
                baglanti.Close();
                temizle();
            }
            if (radioButton2.Checked)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.Add("@islemturu", SqlDbType.NVarChar);
                komut.Parameters["@islemturu"].Value = radioButton2.Text;
                komut.Parameters.Add("@HastaID", SqlDbType.Int);
                komut.Parameters["@HastaID"].Value = deger;
                komut.Parameters.Add("@DoktorID", SqlDbType.Int);
                komut.Parameters["@DoktorID"].Value = deger2;
                komut.Parameters.Add("@kayit_tarihi", SqlDbType.Date);
                komut.Parameters["@kayit_tarihi"].Value = txtHMtarih.Text.Trim();
                komut.Parameters.Add("@kayit_saati", SqlDbType.Time);
                komut.Parameters["@kayit_saati"].Value = txtHMsaat.Text.Trim();
                komut.ExecuteNonQuery();
                baglanti.Close();
                temizle();
            }






            if (radioButton3.Checked)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.Add("@islemturu", SqlDbType.NVarChar);
                komut.Parameters["@islemturu"].Value = radioButton3.Text;
                komut.Parameters.Add("@HastaID", SqlDbType.Int);
                komut.Parameters["@HastaID"].Value = deger;
                komut.Parameters.Add("@DoktorID", SqlDbType.Int);
                komut.Parameters["@DoktorID"].Value = deger2;
                komut.Parameters.Add("@kayit_tarihi", SqlDbType.Date);
                komut.Parameters["@kayit_tarihi"].Value = txtHMtarih.Text.Trim();
                komut.Parameters.Add("@kayit_saati", SqlDbType.Time);
                komut.Parameters["@kayit_saati"].Value = txtHMsaat.Text.Trim();
                komut.ExecuteNonQuery();
                baglanti.Close();
                temizle();
            }
            if (radioButton4.Checked)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.Add("@islemturu", SqlDbType.NVarChar);
                komut.Parameters["@islemturu"].Value = radioButton4.Text;
                komut.Parameters.Add("@HastaID", SqlDbType.Int);
                komut.Parameters["@HastaID"].Value = deger;
                komut.Parameters.Add("@DoktorID", SqlDbType.Int);
                komut.Parameters["@DoktorID"].Value = deger2;
                komut.Parameters.Add("@kayit_tarihi", SqlDbType.Date);
                komut.Parameters["@kayit_tarihi"].Value = txtHMtarih.Text.Trim();
                komut.Parameters.Add("@kayit_saati", SqlDbType.Time);
                komut.Parameters["@kayit_saati"].Value = txtHMsaat.Text.Trim();
                komut.ExecuteNonQuery();
                baglanti.Close();
                temizle();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radiotck.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hasta_Bilgilerii WHERE htc_no LIKE '" + txtHMAra.Text.Trim() + "%'", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (radioad.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hasta_Bilgilerii WHERE ad_soyad LIKE '" + txtHMAra.Text.Trim() + "%'", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (radiobabad.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hasta_Bilgilerii WHERE baba_adi LIKE '" + txtHMAra.Text.Trim() + "%'", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (radioanad.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hasta_Bilgilerii WHERE ana_adi LIKE '" + txtHMAra.Text.Trim() + "%'", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }

        }
    }
}
