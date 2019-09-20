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
    public partial class HastaKabulForm : Form
    {
        public HastaKabulForm()
        {
            InitializeComponent();
        }
        //public static string tc,ad;

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3L5LDLR;Initial Catalog=AHBS;Integrated Security=True");
        private void HastaKabulForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT h.htc_no as [TC],h.ad_soyad as [Adı Soyadı],m.islemturu as [işlem türü],h.baba_adi as [Baba Adı],h.cinsiyet as [Cinsiyet],h.dogum_tarihi as [Doğum Tarihi],d.ad_soyad as DOKTOR FROM Muayene_Kayit as m INNER JOIN Hasta_Bilgilerii as h ON m.HastaID=h.HastaID INNER JOIN Doktor_Bilgileri as d ON m.DoktorID=d.DoktorID", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnHGeridön_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Visible = false;
            HKabulMuayeneKaydetme hkabulmuayene = new HKabulMuayeneKaydetme(this);
            hkabulmuayene.ShowDialog();
            this.Visible = true;
        }
    }
}
