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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            doktorgiris dr = new doktorgiris();
            dr.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1Hastakayıt fr = new Form1Hastakayıt();
            fr.Show();
            this.Hide();

        }

        private void dOSYAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void öNEMLİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hastanemizde covid - 19 ile ilgili bütün tedbirler alınmış olup gönül rahatlığıyla randevularınızı alarak muayene olabilirsiniz.Hastanemize randevu alarak gelmek isteyen(20 yaş altı ve 65 yaş üstü) hastalar randevu aldıktan sonra cep telefonlarına gelen randevu teyit mesajı ile sokağa çıkmalarında herhangi bir sorun yaşamaksızın hastanemize gelebilirler.");
        }

        private void iLETİŞİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0342 360 70 70 NUMARASIYLA BİZİMLE İLETİŞİME GEÇEBİLİRSİNİZ");
        }

        private void bOLUMLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
          // MessageBox.Show("Son teknolojiyle donatılan Ece Hastanesi, kadrosu ve sunduğu hizmet kalitesiyle sağlık sektöründeki hayallerini gerçekleştirmeye devam ediyor. Öncülük ve liderlik ilkelerinden vazgeçmeden daha büyük başarılara yürümenin kararlılığını taşıyor.");
            this.Hide();
            Hastanemiz fr = new Hastanemiz();
            fr.ShowDialog();
        }




        private void bOLUMLERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Her anlamda öncelik sırasını üstlenen insan ve insan sağlığının en büyük hazine olduğu düşünülerek, bunun bilincinde hareket eden hekim ve idari çalışanları ile; sağlık hizmetlerini en üstün düzeye ve evrensel boyutlara taşıma anlayışı yanında, kaliteli ve düzeyli hizmetin devamlılığını sağlamaktır.");
        }

        private void vİZYONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eğitim Öğretim ve hizmet anlamında; gerçekten doğru, üstün vasıflı, güvenilir ve sınır tanımayan, ciddi prensiplerle tıbbi nitelikli hekimler yetiştirirken; bu fertlerin tedavi adına icraat yapabilecekleri, gerekli tıbbi ve teknik donanımlı araç ve gereçlerin zamanında temin edilip, gerekli hijyenik muhafazası sağlanarak, her geçen gün yenilik ve gelişim gösteren çalışma ortamlarının sağlandığı olağanüstü vasıflara haiz bir ARAŞTIRMA HASTANESİ konumuna gelmektir.");
        }

        private void bOLUMLERToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" dahiliye ,göz, KBB, fiziktedavi,nöroloji,üroloji,beyincerrahi,psikoloji");       }

        private void gERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dr = new Form1();
            dr.ShowDialog();
        }

        private void gERİToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            yöneticiris dr = new yöneticiris();
            dr.ShowDialog();
        }

        private void çIKIŞToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh:mm:tt");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
            timer1.Start();
        }
    }
 }

