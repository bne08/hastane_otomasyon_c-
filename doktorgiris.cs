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
    public partial class doktorgiris : Form
    {
        sql_baglantısı bgl = new sql_baglantısı();
        public doktorgiris()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("alanları doldurunuz");
            }
            else
            {
                try
                {

                    SqlCommand komut = new SqlCommand("Select * From doktor where doktorid=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", textBox1.Text);                 
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        doktorpanel fr = new doktorpanel();
                        fr.label7.Text = textBox1.Text;
                        //fr.tc = textBox1.Text;
                        fr.Show();
                        this.Hide();
                    }
               
                    else
                    {
                        MessageBox.Show("veri tabanında böyle doktor bulunamadı");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void doktorgiris_Load(object sender, EventArgs e)
        {

        }

        private void iLETİŞİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ACİL DURUM İÇİN 0342 360 60 60 NUMARASIYLA HASTANEMİZİ ARAYABİLİRSİNİZ.");
        }

        private void bİLGİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hastanemizden randevu alan hastalarımızı, doktorlarımız sisteme id numaralarıyla giriş yaparak görebilmektedir");
        }

        private void yENİLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            doktorgiris fr = new doktorgiris();
            fr.Show();
                
        }

        private void gERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 dr = new Form1();
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

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
            timer1.Start();
        }
    }
}

