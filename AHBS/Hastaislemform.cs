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
    public partial class Hastaislemform : Form
    {
        public Hastaislemform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3L5LDLR;Initial Catalog=AHBS;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        DataSet ds;

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            HastaEkle hastaekle = new HastaEkle();
            hastaekle.ShowDialog();
        }

        private void btnHastaara_Click(object sender, EventArgs e)
        {
            string aradeger = txtHastara.Text;
            if (cmbbxHara.SelectedIndex == 0)
            {
                baglanti.Open();
                da = new SqlDataAdapter("SELECT * FROM Hasta_Bilgilerii ", baglanti);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            if (cmbbxHara.SelectedIndex == 1)
            {
                baglanti.Open();
                da = new SqlDataAdapter("SELECT * FROM Hasta_bilgilerii WHERE htc_no LIKE '" + txtHastara.Text.Trim() + "%'", baglanti);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            if (cmbbxHara.SelectedIndex == 2)
            {
                baglanti.Open();
                da = new SqlDataAdapter("SELECT * FROM Hasta_bilgilerii WHERE ad_soyad LIKE '" + txtHastara.Text.Trim() + "%'", baglanti);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
        }
        

        private void btnHcikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHastaSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3L5LDLR;Initial Catalog=AHBS;Integrated Security=True");
                SqlCommand sorgu = new SqlCommand("DELETE FROM Hasta_Bilgilerii WHERE htc_no=@htc_no", baglanti);
                baglanti.Open();
                sorgu.Parameters.AddWithValue("@htc_no", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                sorgu.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("silme islemi başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {

            }
        }

        private void Hastaislemform_Load(object sender, EventArgs e)
        {
            cmbbxHara.SelectedIndex = 0;
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Hasta_Bilgilerii ", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
