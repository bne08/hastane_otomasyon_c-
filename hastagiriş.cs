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


namespace hastaneotomasyon
{
    public partial class Form2 : Form
    {
        // SQLiteConnection baglan = new SQLiteConnection("Data source=hastane.db");
        sql_baglantısı bgl = new sql_baglantısı();
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

         //   if (string.IsNullOrWhiteSpace(textBox1.Text))
         //   {
         //       MessageBox.Show("alanları doldurunuz");
          //  }
         //   else
          //  {
             //   try
             //   {
                  //  SqlCommand komut = new SqlCommand("Select * From hasta where hastatc=@p1", bgl.baglanti());
                 //   komut.Parameters.AddWithValue("@p1", textBox1.Text);
                  //  SqlDataReader dr = komut.ExecuteReader();
                 //  if (dr.Read())
                  //  {
                   //     randevual fr = new randevual();
                   //     fr.labeltc.Text = textBox1.Text;
                        //fr.tc = textBox1.Text;
                    //    fr.Show();
                    //    this.Hide();
                  //  }

                   // else
                  //  {
                  //      MessageBox.Show("veri tabanında böyle hasta bulunamadı");
                  //  }

                    // string sql = "select * from kayıt where tc='" + textBox1.Text + "',sifre='" + textBox2.Text + "'";

                    //komutislet.Connection.Open();
                    // komutislet.ExecuteNonQuery();
                    // MessageBox.Show("giriş yapıldı", "basarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

               // }
               // catch (Exception hata)
              //  {
              //      MessageBox.Show(hata.Message);
              //  }

           // }

            //if (string.IsNullOrWhiteSpace(textBox1.Text))
            // {
            //     MessageBox.Show("alanları doldurunuz");
            //  }
            //  else
            // {
            //     try
            //    {
            //
            //      baglan.Open();
            //     string sql = "SELECT * FROM hasta WHERE hastatc=@hastatc";
            //      SQLiteParameter prm1 = new SQLiteParameter("hastatc", textBox1.Text.Trim());
            //      SQLiteCommand cmd = new SQLiteCommand(sql, baglan);
            //     cmd.Parameters.Add(prm1);
            //    DataTable dt = new DataTable();
            //    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            //    da.Fill(dt);
            //    if (dt.Rows.Count > 0)
            //   {
            //       MessageBox.Show("giriş yapıldı" + textBox1.Text + " ");
            //       randevual fr = new randevual();
            //      fr.labeltc.Text =textBox1.Text;                       
            //fr.tc = textBox1.Text;
            //     fr.Show();
            //    this.Hide();

            //  }
            //  else
            //  {
            //     MessageBox.Show("veri tabanında böyle hasta bulunmadı");
            //  }

            // string sql = "select * from kayıt where tc='" + textBox1.Text + "',sifre='" + textBox2.Text + "'";

            //komutislet.Connection.Open();
            // komutislet.ExecuteNonQuery();
            // MessageBox.Show("giriş yapıldı", "basarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //  }
            //    catch (Exception hata)
            //  {
            //  MessageBox.Show(hata.Message);
            //  }

        }



        private void gERİToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hastalarımıza randevu alabilmeleri için tc kimlikleri ile  sisteme kayıtlı iseler bu panelden randevu alabilirler.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("alanları doldurunuz");
            }
            else
            {
                try
                {
                    SqlCommand komut = new SqlCommand("Select * From hasta where hastatc=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", textBox1.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        randevual fr = new randevual();
                        fr.labeltc.Text = textBox1.Text;
                        //fr.tc = textBox1.Text;
                        fr.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("veri tabanında böyle hasta bulunamadı");
                    }

                    // string sql = "select * from kayıt where tc='" + textBox1.Text + "',sifre='" + textBox2.Text + "'";

                    //komutislet.Connection.Open();
                    // komutislet.ExecuteNonQuery();
                    // MessageBox.Show("giriş yapıldı", "basarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void gERİToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 dr = new Form1();
            dr.ShowDialog();
        }

        private void yENİLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 dr = new Form2();
            dr.ShowDialog();
        }

        private void çIKIŞToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void yARDIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ACİL DURUM İÇİN 0342 360 60 60 NUMARASIYLA HASTANEMİZİ ARAYABİLİRSİNİZ.");

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

