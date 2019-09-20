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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnCikis1_Click(object sender, EventArgs e)
        {
            Application.Exit();
             
        }

        private void btnDoktorİs_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DoktorİslemForm doktoris = new DoktorİslemForm();
            doktoris.ShowDialog();
            this.Visible = true;
            this.BringToFront();
        }

        private void btnHastaislem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Hastaislemform hastaislem = new Hastaislemform();
            hastaislem.ShowDialog();
            this.Visible = true;
            this.BringToFront();
        }

        private void btnMuayene_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Muayeneislemform muayene = new Muayeneislemform();
            muayene.ShowDialog();
            this.Visible = true;
            this.BringToFront();
        }
        private void btnDoktorİs_MouseHover(object sender ,MouseEventArgs e)
        {
            
        }

        private void btnHastaKabul_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HastaKabulForm hkabul = new HastaKabulForm();
            hkabul.ShowDialog();
            this.Visible = true;
            this.BringToFront();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
