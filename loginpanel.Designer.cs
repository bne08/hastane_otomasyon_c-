namespace hastaneotomasyon
{
    partial class loginpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginpanel));
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aNASAYFAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yENİLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hAKKINDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iLETİŞİMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusBar2 = new System.Windows.Forms.StatusBar();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.statusBar1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(1, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 434);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // statusBar1
            // 
            this.statusBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBar1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusBar1.Location = new System.Drawing.Point(594, 408);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(101, 26);
            this.statusBar1.TabIndex = 10;
            this.statusBar1.Text = "statusBar1";
            this.statusBar1.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.statusBar1_PanelClick);
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "TC :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(85, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "00000000000";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Roboto Slab ExtraBold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "thumbnail_large.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(80, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "   Randevu Sorgula";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "thumbnail_large.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(27, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 255);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevularım";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNASAYFAToolStripMenuItem,
            this.hAKKINDAToolStripMenuItem,
            this.iLETİŞİMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(696, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aNASAYFAToolStripMenuItem
            // 
            this.aNASAYFAToolStripMenuItem.CheckOnClick = true;
            this.aNASAYFAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yENİLEToolStripMenuItem,
            this.gERİToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.aNASAYFAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aNASAYFAToolStripMenuItem.Image")));
            this.aNASAYFAToolStripMenuItem.Name = "aNASAYFAToolStripMenuItem";
            this.aNASAYFAToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.aNASAYFAToolStripMenuItem.Text = "ANASAYFA";
            this.aNASAYFAToolStripMenuItem.Click += new System.EventHandler(this.aNASAYFAToolStripMenuItem_Click);
            // 
            // yENİLEToolStripMenuItem
            // 
            this.yENİLEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yENİLEToolStripMenuItem.Image")));
            this.yENİLEToolStripMenuItem.Name = "yENİLEToolStripMenuItem";
            this.yENİLEToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.yENİLEToolStripMenuItem.Text = "YENİLE";
            this.yENİLEToolStripMenuItem.Click += new System.EventHandler(this.yENİLEToolStripMenuItem_Click);
            // 
            // gERİToolStripMenuItem
            // 
            this.gERİToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gERİToolStripMenuItem.Image")));
            this.gERİToolStripMenuItem.Name = "gERİToolStripMenuItem";
            this.gERİToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.gERİToolStripMenuItem.Text = "GERİ";
            this.gERİToolStripMenuItem.Click += new System.EventHandler(this.gERİToolStripMenuItem_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çIKIŞToolStripMenuItem.Image")));
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // hAKKINDAToolStripMenuItem
            // 
            this.hAKKINDAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hAKKINDAToolStripMenuItem.Image")));
            this.hAKKINDAToolStripMenuItem.Name = "hAKKINDAToolStripMenuItem";
            this.hAKKINDAToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.hAKKINDAToolStripMenuItem.Text = "HAKKINDA";
            this.hAKKINDAToolStripMenuItem.Click += new System.EventHandler(this.hAKKINDAToolStripMenuItem_Click);
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
            this.statusBar2.Location = new System.Drawing.Point(516, 0);
            this.statusBar2.Name = "statusBar2";
            this.statusBar2.Size = new System.Drawing.Size(180, 24);
            this.statusBar2.TabIndex = 1;
            this.statusBar2.Text = "BÜŞRA NUR ECE / 16010011050";
            // 
            // loginpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(696, 458);
            this.Controls.Add(this.statusBar2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "loginpanel";
            this.Text = "Kullanıcı Detay";
            this.Load += new System.EventHandler(this.loginpanel_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aNASAYFAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hAKKINDAToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem iLETİŞİMToolStripMenuItem;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ToolStripMenuItem yENİLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusBar statusBar2;
    }
}