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
using System.Linq.Expressions;

namespace hastaneotomasyon
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        sql_baglantısı bgl = new sql_baglantısı();
        private void login_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default["hastatc"].ToString();
            textBox3.Text = Properties.Settings.Default["hastaad"].ToString();
            if(textBox1.Text.Count()>1)
            {
                checkBox1.Checked = true;

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            yöneticiris fr = new yöneticiris();
            fr.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh:mm:tt");


        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           

            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void yARDIMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hAKKINDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void öNEMLİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hastanemizde covid-19 ile ilgili bütün tedbirler alınmış olup gönül rahatlığıyla randevularınızı alarak muayene olabilirsiniz.Hastanemize randevu alarak gelmek isteyen(20 yaş altı ve 65 yaş üstü) hastalar randevu aldıktan sonra cep telefonlarına gelen randevu teyit mesajı ile sokağa çıkmalarında herhangi bir sorun yaşamaksızın hastanemize gelebilirler.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void yENİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            login fr = new login();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " || textBox3.Text == " ")
            {
                MessageBox.Show("alanları doldurunuz");
            }
            else
            {
                try
                {
                    SqlCommand komut = new SqlCommand("Select * From hasta Where hastatc=@p1 and hastaad=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", textBox1.Text);
                    komut.Parameters.AddWithValue("@p2", textBox3.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {   
                        this.Hide();
                        loginpanel fr = new loginpanel();
                         fr.label1.Text = textBox1.Text;
                        //fr.tc = textBox1.Text;
                        fr.Show();
                        
                    }

                    else
                    {
                        MessageBox.Show("veri tabanında böyle hasta bulunamadı");
                    }
                    bgl.baglanti().Close();
                    
                 }
                catch(Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }

             }
            if(checkBox1.Checked)
            {
                Properties.Settings.Default["hastatc"] = textBox1.Text;
                Properties.Settings.Default["hastaad"] = textBox3.Text;

            }
            else
            {
               Properties.Settings.Default[" "] = textBox1.Text;
               Properties.Settings.Default[" "] = textBox3.Text;

            }
            Properties.Settings.Default.Save();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                MessageBox.Show("kullanıcı adınızı ve sifrenizi beni kaydet olarak dediniz", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
            timer1.Start();
        }

        private void statusBar1_PanelClick_1(object sender, StatusBarPanelClickEventArgs e)
        {

        }

        private void statusBar1_PanelClick_2(object sender, StatusBarPanelClickEventArgs e)
        {

        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hastanemize Hoşgeldiniz Ece hastaneleri olarak tecrübeli ve uzman kadrosundan aldığı güçle modern tıbbın imkanlarını kullanarak mümkün olan en iyi sağlık hizmetini halkımıza sunma gayreti içindeyiz.Sağlığınızı korumak, sürdürmek, geliştirmek ya da yeniden kazanmak amacıyla başvurduğunuz kurumumuzda 52 branşta 1131 yatak kapasiteli sağlık hizmeti, 266 poliklinikte ayaktan tedavi hizmeti yürütülürken 24 saat Acil Servis, Doğum hizmetleri verilmektedir.Hastanemizde poliklinik hizmeti verdiğimiz tüm branşlarda yataklı tedavi hizmetleri de doktorunuzun uygun görmesi durumunda verilmektedir.Bu hizmetlerin devamını ve teknik desteğini sağlık, teknik, idari hizmetler ve hizmet alımı sınıflarına mensup toplam 3385 çalışan personelle sağlamaktadır.");

        }

        private void çIKIŞToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void hASTANESİSTEMİZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hastane sistemimize hoşgeldiniz. " +
                " Eğer yöneticiyseniz kullanıcı adı ve şifrenizle sistemizie girip doktor sekreter ve hasta paneline erişebilirsiniz.Eğer hastanemizden randevu almış iseniz login panelinde tc kimlik ve adınızı girerek randevularınızı görüntüleyebilirsiniz");
        }

        private void iLETİŞİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ACİL DURUM İÇİN 0342 360 60 60 NUMARASIYLA HASTANEMİZİ ARAYABİLİRSİNİZ.");

        }
    }
}
