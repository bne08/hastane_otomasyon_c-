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
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace hastaneotomasyon
{
    public partial class randevual : Form
    {
        
        sql_baglantısı bgl = new sql_baglantısı();

        public randevual()
        {
            InitializeComponent();
        }
        


        //public string tc;
        //public string tc { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {
            // labeltc.Text = tc;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void gERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(dateTimePicker1.Text) || string.IsNullOrWhiteSpace(maskedTextBox1.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text))
            {
              MessageBox.Show("alanları doldurunuz");
            }
            else
                try
                {
                    SqlCommand komutkaydet = new SqlCommand("Insert into randevular (hastatc,randevutarih,randevusaat,randevubrans,randevudoktor) values (@r1,@r2,@r3,@r4,@r5)", bgl.baglanti());
                    komutkaydet.Parameters.AddWithValue("@r1", textBox2.Text);
                    // komutkaydet.Parameters.AddWithValue("@r2", dateTimePicker1.Text);
                    komutkaydet.Parameters.AddWithValue("@r2", Convert.ToDateTime(dateTimePicker1.Text));
                    komutkaydet.Parameters.AddWithValue("@r3", maskedTextBox1.Text);
                    komutkaydet.Parameters.AddWithValue("@r4", comboBox1.Text);
                    komutkaydet.Parameters.AddWithValue("@r5", comboBox2.Text);
                    komutkaydet.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Randevu Oluşturuldu");
                }
                catch(Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }

        }


        private void labeltc_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            comboBox2.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select doktorAd,doktorSoyad From doktor where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox2.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void randevual_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From randevular where hastatc='" + textBox2.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //dataGridView1.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select hastatc,randevutarih,randevusaat,randevubrans,randevudoktor,randevudurum From randevular where hastatc=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", textBox2.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                dataGridView1.DataSource = dr3;
            }
            bgl.baglanti().Close();

            // SqlCommand komut = new SqlCommand("Select doktorad,doktorsoyad From doktor", bgl.baglanti());
            // SqlDataReader dr = komut.ExecuteReader();
            // while (dr.Read())
            // {
            //     comboBox2.Items.Add(dr[0] + " " + dr[1]);
            // }
            // bgl.baglanti().Close();

            // bransları comboboxa aktarma işlemi
            comboBox1.Items.Clear();
            SqlCommand komut2 = new SqlCommand("Select doktorbrans From doktor", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Select hastatc,randevutarih,randevusaat,randevubrans,randevudoktor,randevudurum From randevular where hastatc=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", labeltc.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                dataGridView1.DataSource = dr3;
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From randevular where hastatc='" + labeltc.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Silinecek randevu bulunmamaktadır !");
            }
            else
            {
                try
                {
                    // string sql = "update randevu set hastaad='" + adı.Text + "', hastasoyad='" + soyadi.Text + "',hastatelefon='" + tel.Text + "',hastayas='" + yas.Text + "' , dogtar ='" + Convert.ToDateTime(dogtar.Text) + "' where hastatc='" + tc.Text + "'";
                    SqlCommand komut = new SqlCommand("DELETE FROM randevular where  hastatc='" + labeltc.Text + "'", bgl.baglanti());
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Randevu silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //bgl.baglanti().Close();
                    //komut3.Connection.Open();
                    //komut3.ExecuteNonQuery();
                    //MessageBox.Show("kullanıcı basarıyla guncellendi");
                }

                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                }

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From randevular where hastatc='" + labeltc.Text + "'", bgl.baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.baglanti().Close();
            }           

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Güncellenecek randevu bulunmamaktadır !");
            }
            else
            {
                try
                {
                    SqlCommand komut = new SqlCommand("Update randevular set randevutarih=@d1,randevusaat=@d2,randevubrans=@d3,randevudoktor=@d4 where hastatc=@d5", bgl.baglanti());
                    komut.Parameters.AddWithValue("@d1", Convert.ToDateTime(dateTimePicker1.Text));
                    komut.Parameters.AddWithValue("@d2", maskedTextBox1.Text);
                    komut.Parameters.AddWithValue("@d3", comboBox1.Text);
                    komut.Parameters.AddWithValue("@d4", comboBox2.Text);
                    komut.Parameters.AddWithValue("@d5", textBox2.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Randevu Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("Select * From randevular where hastatc='" + labeltc.Text + "'", bgl.baglanti());
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    bgl.baglanti().Close();
                    // dataGridView1.DataSource = dt.Tables[0];
                }
                catch(Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        private void iLETİŞİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İLETİŞİM İÇİN 0342 360 70 70 NUMARASIYLA HASTANEMİZİ ARAYABİLİRSİNİZ.");

        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ACİL DURUM İÇİN 0342 360 60 60 NUMARASIYLA HASTANEMİZİ ARAYABİLİRSİNİZ.");

        }

        private void gERİToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void çIKIŞToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void statusBar2_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }
    }
}

