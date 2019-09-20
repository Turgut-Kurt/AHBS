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
    public partial class HKabulMuayeneKaydetme : Form
    {
        HastaKabulForm hkabul;
        public HKabulMuayeneKaydetme(HastaKabulForm hkabul)
        {
            InitializeComponent();
            this.hkabul = hkabul;
        }
        
        string tckno,deger,tanid,istemid,ilacid;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3L5LDLR;Initial Catalog=AHBS;Integrated Security=True");
        DataSet ds;
        SqlDataAdapter da;
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
        private void HKabulMuayeneKaydetme_Load(object sender, EventArgs e)
        {
            txthkmtc.Text = hkabul.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txthkmad.Text = hkabul.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txthmktarih.Text = DateTime.Now.ToShortDateString();
            baglanti.Open();
            da = new SqlDataAdapter("SELECT h.ad_soyad as [AdSoyad],hm.kayit_tarihi as [kayıt tarihi],hm.sikayet as sikayet,t.kodu as Tani,il.İlacAdi as [İlac Adi] FROM Hasta_Muayene as hm INNER JOIN Hasta_Bilgilerii as h ON hm.HastaID=h.HastaID INNER JOIN Tanilar as t ON hm.taniID=t.taniID INNER JOIN İstem as i ON hm.istemID=i.istemID INNER JOIN İlaclar as il ON hm.ilacID=il.ilacID WHERE h.ad_soyad='" + hkabul.dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
        }

        
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TanıEkle tani = new TanıEkle(this);
            tani.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            İstemEkleme istem = new İstemEkleme(this);
            istem.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            İlacEkleme ilac = new İlacEkleme(this);
            ilac.ShowDialog();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kayit = "INSERT INTO Hasta_Muayene (ates,nabız,tansiyonS,tansiyonHG,solunum,sikayet,HastaID,taniID,istemID,ilacID,kayit_tarihi) VALUES(@ates,@nabız,@tansiyonS,@tansiyonHG,@solunum,@sikayet,@HastaID,@taniID,@istemID,@ilacID,@kayit_tarihi)";
            baglanti.Open();
            tckno = txthkmtc.Text;
            SqlDataAdapter da = new SqlDataAdapter("SELECT HastaID FROM Hasta_Bilgilerii WHERE htc_no LIKE '" + tckno + "%'", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView5.DataSource = ds.Tables[0];
            deger= dataGridView5.Rows[0].Cells[0].Value.ToString();
            tanid=dataGridView2.Rows[0].Cells[0].Value.ToString();
            istemid= dataGridView3.Rows[0].Cells[0].Value.ToString();
            ilacid= dataGridView4.Rows[0].Cells[0].Value.ToString();
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.Add("@ates", SqlDbType.NChar);
            komut.Parameters["@ates"].Value = txtates.Text;
            komut.Parameters.Add("@nabız", SqlDbType.NChar);
            komut.Parameters["@nabız"].Value = txtnabız.Text;
            komut.Parameters.Add("@tansiyonS", SqlDbType.NChar);
            komut.Parameters["@tansiyonS"].Value = txttanS.Text;
            komut.Parameters.Add("@tansiyonHG", SqlDbType.NChar);
            komut.Parameters["@tansiyonHG"].Value = txttanHG.Text;
            komut.Parameters.Add("@solunum", SqlDbType.NChar);
            komut.Parameters["@solunum"].Value = txtsolunum.Text;
            komut.Parameters.Add("@sikayet", SqlDbType.NVarChar);
            komut.Parameters["@sikayet"].Value = txtsikayet.Text;
            komut.Parameters.Add("@HastaID", SqlDbType.NVarChar);
            komut.Parameters["@HastaID"].Value = deger;
            komut.Parameters.Add("@taniID", SqlDbType.Int);
            komut.Parameters["@taniID"].Value = tanid;
            komut.Parameters.Add("@istemID", SqlDbType.Int);
            komut.Parameters["@istemID"].Value = istemid;
            komut.Parameters.Add("@ilacID", SqlDbType.Int);
            komut.Parameters["@ilacID"].Value = ilacid;
            komut.Parameters.Add("@kayit_tarihi", SqlDbType.Date);
            komut.Parameters["@kayit_tarihi"].Value = txthmktarih.Text.Trim();
            komut.ExecuteNonQuery();
            temizle();
            dataGridView2.Columns.Clear();
            dataGridView2.Refresh();
            dataGridView3.Columns.Clear();
            dataGridView3.Refresh();
            dataGridView4.Columns.Clear();
            dataGridView4.Refresh();
            dataGridView5.Columns.Clear();
            dataGridView5.Refresh();
            baglanti.Close();
            MessageBox.Show("İşlem Tamamlandı","mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
