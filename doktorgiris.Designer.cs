namespace hastaneotomasyon
{
    partial class doktorgiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doktorgiris));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aNASAYFAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yENİLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bİLGİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iLETİŞİMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusBar2 = new System.Windows.Forms.StatusBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(74, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOKTOR İD :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "thumbnail_large (16).png";
            this.button1.Location = new System.Drawing.Point(80, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "GİRİŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.statusBar1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 403);
            this.panel1.TabIndex = 4;
            // 
            // statusBar1
            // 
            this.statusBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusBar1.Location = new System.Drawing.Point(427, 381);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(122, 22);
            this.statusBar1.TabIndex = 5;
            this.statusBar1.Text = "statusBar1";
            this.statusBar1.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.statusBar1_PanelClick);
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(217, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 199);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImageKey = "thumbnail_large (16).png";
            this.label2.ImageList = this.ımageList1;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "     ";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "thumbnail_large (5).png");
            this.ımageList1.Images.SetKeyName(1, "thumbnail_large (16).png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNASAYFAToolStripMenuItem,
            this.bİLGİToolStripMenuItem,
            this.iLETİŞİMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aNASAYFAToolStripMenuItem
            // 
            this.aNASAYFAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yENİLEToolStripMenuItem,
            this.gERİToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.aNASAYFAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aNASAYFAToolStripMenuItem.Image")));
            this.aNASAYFAToolStripMenuItem.Name = "aNASAYFAToolStripMenuItem";
            this.aNASAYFAToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.aNASAYFAToolStripMenuItem.Text = "ANASAYFA";
            // 
            // yENİLEToolStripMenuItem
            // 
            this.yENİLEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yENİLEToolStripMenuItem.Image")));
            this.yENİLEToolStripMenuItem.Name = "yENİLEToolStripMenuItem";
            this.yENİLEToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.yENİLEToolStripMenuItem.Text = "YENİLE ";
            this.yENİLEToolStripMenuItem.Click += new System.EventHandler(this.yENİLEToolStripMenuItem_Click);
            // 
            // gERİToolStripMenuItem
            // 
            this.gERİToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gERİToolStripMenuItem.Image")));
            this.gERİToolStripMenuItem.Name = "gERİToolStripMenuItem";
            this.gERİToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.gERİToolStripMenuItem.Text = "GERİ";
            this.gERİToolStripMenuItem.Click += new System.EventHandler(this.gERİToolStripMenuItem_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çIKIŞToolStripMenuItem.Image")));
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // bİLGİToolStripMenuItem
            // 
            this.bİLGİToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bİLGİToolStripMenuItem.Image")));
            this.bİLGİToolStripMenuItem.Name = "bİLGİToolStripMenuItem";
            this.bİLGİToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.bİLGİToolStripMenuItem.Text = "BİLGİ";
            this.bİLGİToolStripMenuItem.Click += new System.EventHandler(this.bİLGİToolStripMenuItem_Click);
            // 
            // iLETİŞİMToolStripMenuItem
            // 
            this.iLETİŞİMToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iLETİŞİMToolStripMenuItem.Image")));
            this.iLETİŞİMToolStripMenuItem.Name = "iLETİŞİMToolStripMenuItem";
            this.iLETİŞİMToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.iLETİŞİMToolStripMenuItem.Text = "İLETİŞİM";
            this.iLETİŞİMToolStripMenuItem.Click += new System.EventHandler(this.iLETİŞİMToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusBar2
            // 
            this.statusBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBar2.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBar2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusBar2.Location = new System.Drawing.Point(370, 0);
            this.statusBar2.Name = "statusBar2";
            this.statusBar2.Size = new System.Drawing.Size(181, 24);
            this.statusBar2.TabIndex = 6;
            this.statusBar2.Text = "BÜŞRA NUR ECE / 16010011050";
            // 
            // doktorgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 431);
            this.Controls.Add(this.statusBar2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "doktorgiris";
            this.Text = "Doktor Giriş Paneli";
            this.Load += new System.EventHandler(this.doktorgiris_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aNASAYFAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yENİLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bİLGİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iLETİŞİMToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.StatusBar statusBar2;
    }
}