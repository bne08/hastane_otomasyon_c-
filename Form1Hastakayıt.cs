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
using System.Windows.Forms.VisualStyles;

namespace hastaneotomasyon
{
    public partial class Form1Hastakayıt : Form

    {
        // SQLiteConnection baglan = new SQLiteConnection("Data source=hastane.db"); // hastane db ye baglanmak için 
        sql_baglantısı bgl = new sql_baglantısı();

        public Form1Hastakayıt()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
                    SqlCommand komut = new SqlCommand("DELETE FROM hasta where  hastatc='" + tc.Text + "'", bgl.baglanti());
                    komut.ExecuteNonQuery();

                    MessageBox.Show("hasta silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From hasta where hastatc='" + tc.Text + "'", bgl.baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.baglanti().Close();
            }
        }
        private void button1_Click(object sender, EventArgs e) // veri ekleme işlemi 
        {
            
            if (string.IsNullOrWhiteSpace(adı.Text) || string.IsNullOrWhiteSpace(soyadi.Text) || string.IsNullOrWhiteSpace(tc.Text) || string.IsNullOrWhiteSpace(tel.Text) || string.IsNullOrWhiteSpace(yas.Text) || string.IsNullOrEmpty(dogtar.Text))
            {
                MessageBox.Show("alanları doldurunuz");
            }
            else
            {
                try
                {
                
                SqlCommand komutkaydet = new SqlCommand("Insert into hasta (hastatc,hastaad,hastasoyad,hastatel,hastayas,hastadogtar) values (@r1,@r2,@r3,@r4,@r5,@r6)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@r1", tc.Text);
                // komutkaydet.Parameters.AddWithValue("@r2", dateTimePicker1.Text);
                komutkaydet.Parameters.AddWithValue("@r2", adı.Text);
                komutkaydet.Parameters.AddWithValue("@r3", soyadi.Text);
                komutkaydet.Parameters.AddWithValue("@r4", tel.Text);
                komutkaydet.Parameters.AddWithValue("@r5", yas.Text);
                komutkaydet.Parameters.AddWithValue("@r6", Convert.ToDateTime(dogtar.Text));
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("hasta olusruruldı Oluşturuldu");
                }
            catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From hasta where hastatc='" + tc.Text + "'", bgl.baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                
            }
        }

        private void güncelle_Click(object sender, EventArgs e) // guncelleme işlemi 
        {
            if (string.IsNullOrWhiteSpace(adı.Text) || string.IsNullOrWhiteSpace(soyadi.Text) || string.IsNullOrWhiteSpace(tc.Text) || string.IsNullOrWhiteSpace(tel.Text) || string.IsNullOrWhiteSpace(yas.Text) || string.IsNullOrEmpty(dogtar.Text))
            {
                MessageBox.Show("alanları doldurunuz");
            }

            else
            {

                try
                {
                    SqlCommand komut = new SqlCommand("Update hasta set hastaad=@d2,hastasoyad=@d3,hastatel=@d4,hastayas=@d5,hastadogtar=@d6 where hastatc=@d7", bgl.baglanti());
                    komut.Parameters.AddWithValue("d7", tc.Text);
                    // komutkaydet.Parameters.AddWithValue("@r2", dateTimePicker1.Text);
                    komut.Parameters.AddWithValue("@d2", adı.Text);
                    komut.Parameters.AddWithValue("@d3", soyadi.Text);
                    komut.Parameters.AddWithValue("@d4", tel.Text);
                    komut.Parameters.AddWithValue("@d5", yas.Text);
                    komut.Parameters.AddWithValue("@d6", Convert.ToDateTime(dogtar.Text));
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("hasta guncellendi");

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("Select * From hasta where hastatc='" + tc.Text + "'", bgl.baglanti());
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    bgl.baglanti().Close();

                }

                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }

               


            }
        }
            private void kaydet_Click(object sender, EventArgs e)
            {
            SqlCommand komut3 = new SqlCommand("Select hastatc,hastaad,hastasoyad,hastatel,hastayas,hastadogtar From hasta where hastatc=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", tc.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                dataGridView1.DataSource = dr3;
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From hasta", bgl.baglanti());
            da.Fill(dt);
            DataSource = dt;
            //baglan.Open();
            //  SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select *From hasta", baglan);
            //  DataSet dset = new DataSet();
            //  adapter.Fill(dset, "info");
            //   dataGridView1.DataSource = dset.Tables[0];
            //   baglan.Close();

        }
        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // verilerimizin gelmesi
        {  
            //verilerin textboxlara dolması
            tc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            adı.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();         
            tel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            yas.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dogtar.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void Form1Hastakayıt_Load(object sender, EventArgs e)
        {

       
            //  baglan.Open();
            //  SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From hasta", baglan);
            //  DataSet dset = new DataSet();
            //  adapter.Fill(dset, "info");
            //  dataGridView1.DataSource = dset.Tables[0];
            //   baglan.Close();
        }

        private void tc_TextChanged(object sender, EventArgs e)
        {

        }

        private void soyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void yas_TextChanged(object sender, EventArgs e)
        {

        }

        private void tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //OpenFileDialog openfiledialog1 = new OpenFileDialog();
           // openfiledialog1.ShowDialog();
           // openfiledialog1.Filter = "veri |*.xls";
            //txtfilepath.Text = openfiledialog1.veri;
        }

        private void gERİToolStripMenuItem_Click(object sender, EventArgs e) // geri gitme işlemi 
        {
            
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0342 360 70 70 NUMARASIYLA BİZİMLE İLETİŞİME GEÇEBİLİRSİNİZ");
        }

        private void dogtar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gERİToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 dr = new Form1();
            dr.Show();
        }

        private void çIKIŞToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void öNEMLİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hastanemizde covid-19 ile ilgili bütün tedbirler alınmış olup gönül rahatlığıyla randevularınızı alarak muayene olabilirsiniz.Hastanemize randevu alarak gelmek isteyen(20 yaş altı ve 65 yaş üstü) hastalar randevu aldıktan sonra cep telefonlarına gelen randevu teyit mesajı ile sokağa çıkmalarında herhangi bir sorun yaşamaksızın hastanemize gelebilirler.");

        }

        private void yARDIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teknik arızalar için 0332 236 58 78 i arayabilirsiniz.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh:mm:tt");
        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
            timer1.Start();
        }
    }

}
