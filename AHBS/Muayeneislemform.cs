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
    public partial class Muayeneislemform : Form
    {
        public Muayeneislemform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3L5LDLR;Initial Catalog=AHBS;Integrated Security=True");
        private void Muayeneislemform_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string tarih = DateTime.Now.ToString("yyyy-MM-dd");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hasta_Bilgilerii WHERE kayit_tarihi='" + tarih + "'", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnHGeridön_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HastaMuayene hmuayene = new HastaMuayene();
            hmuayene.ShowDialog();
            this.Visible = true;
        }
    
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string tarih = DateTime.Now.ToString("yyyy-MM-dd");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hasta_Bilgilerii WHERE kayit_tarihi='"+tarih+"'" , baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hasta_Bilgilerii ORDER BY kayit_tarihi,kayit_saati ASC", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
