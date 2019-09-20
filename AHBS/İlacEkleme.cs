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
    public partial class İlacEkleme : Form
    {
        HKabulMuayeneKaydetme hastakabul;
        public İlacEkleme(HKabulMuayeneKaydetme hastakabul)
        {
            InitializeComponent();
            this.hastakabul = hastakabul;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3L5LDLR;Initial Catalog=AHBS;Integrated Security=True");
        DataSet ds;
        SqlDataAdapter da;

        private void İlacEkleme_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM İlaclar", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM İlaclar WHERE İlacAdi='" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "' OR Firma='" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "' OR Fiyat='"+ dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()+"'", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hastakabul.dataGridView4.DataSource = ds.Tables[0];
            this.Close();
        }
    }
}
