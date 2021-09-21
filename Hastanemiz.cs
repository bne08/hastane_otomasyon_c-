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
    public partial class Hastanemiz : Form
    {
        public Hastanemiz()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh:mm:tt");
        }

        private void gERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.ShowDialog();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusBar2_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }
    }
}
