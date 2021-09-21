using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaneotomasyon
{
    public partial class yöneticiris : Form
    {
        public yöneticiris()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))//(textBox1.Text == " " || textBox2.Text == " ") //string.IsNullOrWhiteSpace(listBox1.Text))
            {
                MessageBox.Show("alanları doldurunuz");
            }
            else
            {
                try
                {

                    if (textBox1.Text == "busranur" || textBox2.Text == "ece" &&
                        textBox1.Text == "ankara" || textBox2.Text == "123")
                    {
                        this.Hide();
                        Form1 git = new Form1();
                        git.ShowDialog();
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("sifre ve kullanıcı adı yanlıs !!");
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void yARDIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0342 360 70 70 NUMARASIYLA BİZİMLE İLETİŞİME GEÇEBİLİRSİNİZ");
        }

        private void hAKKINDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ece hastanesi randevu sistemine hoşgeldiniz.Randevularınızı sekreterden hasta kayıt işlemi yaparak hasTane sistemine kayıt olup doktorlarımızdan istediğiniz gibi randevu işlemini gerçekleştirebilirsiniz.");

        }

        private void yENİLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            yöneticiris dr = new yöneticiris();
            dr.ShowDialog();
            
        }

        private void aNASAYFAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            login dr = new login();
            dr.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh:mm:tt");
           
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
            timer1.Start();
        }

        private void statusBar2_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }

        private void statusBar2_PanelClick_1(object sender, StatusBarPanelClickEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
