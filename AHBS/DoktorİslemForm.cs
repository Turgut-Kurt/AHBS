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
    public partial class DoktorİslemForm : Form
    {
        public DoktorİslemForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3L5LDLR;Initial Catalog=AHBS;Integrated Security=True");
        SqlCommand komut;

       
        private void btnCikis2_Click(object sender, EventArgs e)
        {
            this.Close();     
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DoktorEkle dokekle = new DoktorEkle();
            dokekle.ShowDialog();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aradeger = txtDoktorAra.Text;
            
            if (cmbbxDokAraSecim.SelectedIndex==0)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Doktor_Bilgileri ", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (cmbbxDokAraSecim.SelectedIndex==1)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Doktor_Bilgileri WHERE tc_no LIKE '" +txtDoktorAra.Text.Trim()+ "%'", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (cmbbxDokAraSecim.SelectedIndex == 2)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Doktor_Bilgileri WHERE ad_soyad LIKE '" + txtDoktorAra.Text.Trim() + "%'", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (cmbbxDokAraSecim.SelectedIndex == 3)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Doktor_Bilgileri WHERE sicil_no LIKE '" + txtDoktorAra.Text.Trim() + "%'", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (cmbbxDokAraSecim.SelectedIndex == 4)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Doktor_Bilgileri WHERE cep_tel LIKE '" + txtDoktorAra.Text.Trim() + "%'", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (cmbbxDokAraSecim.SelectedIndex == 5)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Doktor_Bilgileri WHERE ev_tel LIKE '" + txtDoktorAra.Text.Trim() + "%'", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (cmbbxDokAraSecim.SelectedIndex == 6)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Doktor_Bilgileri WHERE adres LIKE '" + txtDoktorAra.Text.Trim() + "%'", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (cmbbxDokAraSecim.SelectedIndex == 7)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Doktor_Bilgileri WHERE e_mail LIKE '" + txtDoktorAra.Text.Trim() + "%'", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            /*baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Doktor_Bilgileri",baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();*/

        }
        //void KayıtSil(int tc)
        //{
        //    string sorgu = "DELETE * FROM Doktor_bilgileri WHERE tc_no=@tc_no";
        //    komut = new SqlCommand(sorgu, baglanti);
        //    komut.Parameters.AddWithValue("@tc_no", tc);
        //    baglanti.Open();
        //    komut.ExecuteNonQuery();
        //    baglanti.Close();
        //}


        private void DoktorİslemForm_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3L5LDLR;Initial Catalog=AHBS;Integrated Security=True");
            cmbbxDokAraSecim.SelectedIndex = 0;
            SqlCommand sorgu = new SqlCommand("SELECT * FROM Doktor_Bilgileri ", baglanti);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3L5LDLR;Initial Catalog=AHBS;Integrated Security=True");
                SqlCommand sorgu = new SqlCommand("DELETE FROM Doktor_Bilgileri WHERE tc_no=@tc_no", baglanti);
                baglanti.Open();
                sorgu.Parameters.AddWithValue("@tc_no", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                sorgu.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("silme islemi başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
