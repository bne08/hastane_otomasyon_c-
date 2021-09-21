using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hastaneotomasyon
{
    public partial class loginpanel : Form
    {
        public loginpanel()
        {
            InitializeComponent();
        }
        sql_baglantısı bgl = new sql_baglantısı();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginpanel_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Select randevutarih,randevusaat,randevubrans,randevudoktor,randevudurum From randevular where hastatc=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", label1.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                dataGridView1.DataSource = dr3;
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From randevular where hastatc='" + label1.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //bgl.baglanti().Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iLETİŞİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0342 360 70 70 NUMARASIYLA BİZİMLE İLETİŞİME GEÇEBİLİRSİNİZ");
        }

        private void hAKKINDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sisteme giren kullanıcılarımız randevularını bu kısımdan görebilmektedir.");
        }

        private void yENİLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginpanel dr = new loginpanel();
            dr.ShowDialog();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh:mm:tt");
        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
            timer1.Start();
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            login cd = new login();
            cd.ShowDialog();
        }
    }
}
