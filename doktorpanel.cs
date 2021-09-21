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
    public partial class doktorpanel : Form
    {
        sql_baglantısı bgl = new sql_baglantısı();
        public doktorpanel()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void doktorpanel_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select doktorad,doktorsoyad,doktorbrans From doktor where doktorid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label7.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label3.Text = dr[0] + " " + dr[1];
                label5.Text = dr[2] + " ";
            }
            bgl.baglanti().Close();

           // DataTable dt = new DataTable();
           // SqlDataAdapter da = new SqlDataAdapter("Select * From randevular where randevudoktor='" + label3.Text + "'", bgl.baglanti());
            //da.Fill(dt);
           // dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {               
                SqlCommand komut = new SqlCommand("DELETE FROM randevular where  randevudoktor='" + label3.Text + "'", bgl.baglanti());
                komut.ExecuteNonQuery();

                MessageBox.Show("Randevu silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From randevular where randevudoktor='" + label3.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
       
    }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Select randevutarih,randevusaat,randevubrans,randevudoktor,randevudurum From randevular where randevudoktor=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", label3.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                dataGridView1.DataSource = dr3;
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From randevular where randevudoktor='" + label3.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void iLETİŞİMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh:mm:tt");

        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
            timer1.Start();
        }

        private void hAKKINDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hastalarınızın sizden aldıkları randevuları bu panelden görebilirsiniz.");
        }

        private void iLETİŞİMToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" İletişim için 0332 236 60 70 'i arayabilirsiniz. ");
        }

        private void gERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            doktorgiris dr = new doktorgiris();
            dr.Show();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
