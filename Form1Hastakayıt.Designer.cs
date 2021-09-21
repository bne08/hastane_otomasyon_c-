namespace hastaneotomasyon
{
    partial class Form1Hastakayıt
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Hastakayıt));
            this.ekle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.TextBox();
            this.adı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.sil = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.yas = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dogtar = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.Label();
            this.soyadi = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gERİToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öNEMLİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yARDIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusBar2 = new System.Windows.Forms.StatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ekle.Font = new System.Drawing.Font("Roboto", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekle.ImageKey = "thumbnail_large (21).png";
            this.ekle.ImageList = this.ımageList1;
            this.ekle.Location = new System.Drawing.Point(43, 321);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(91, 54);
            this.ekle.TabIndex = 1;
            this.ekle.Text = "HASTA EKLE";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "thumbnail_large (3).png");
            this.ımageList1.Images.SetKeyName(1, "thumbnail_large (24).png");
            this.ımageList1.Images.SetKeyName(2, "thumbnail_large (21).png");
            this.ımageList1.Images.SetKeyName(3, "thumbnail_large (25).png");
            this.ımageList1.Images.SetKeyName(4, "tl (6).png");
            this.ımageList1.Images.SetKeyName(5, "tl (7).png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tc Kimlik No :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta Adı :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(173, 93);
            this.tc.Multiline = true;
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(121, 25);
            this.tc.TabIndex = 6;
            this.tc.TextChanged += new System.EventHandler(this.tc_TextChanged);
            // 
            // adı
            // 
            this.adı.Location = new System.Drawing.Point(173, 126);
            this.adı.Multiline = true;
            this.adı.Name = "adı";
            this.adı.Size = new System.Drawing.Size(121, 26);
            this.adı.TabIndex = 7;
            this.adı.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tel No :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(173, 193);
            this.tel.Multiline = true;
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(121, 26);
            this.tel.TabIndex = 13;
            this.tel.TextChanged += new System.EventHandler(this.tel_TextChanged);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sil.Font = new System.Drawing.Font("Roboto", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sil.ImageKey = "thumbnail_large (24).png";
            this.sil.ImageList = this.ımageList1;
            this.sil.Location = new System.Drawing.Point(140, 321);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(85, 54);
            this.sil.TabIndex = 17;
            this.sil.Text = "  HASTA SİL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.button2_Click);
            // 
            // güncelle
            // 
            this.güncelle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.güncelle.Font = new System.Drawing.Font("Roboto", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.güncelle.ImageKey = "tl (7).png";
            this.güncelle.ImageList = this.ımageList1;
            this.güncelle.Location = new System.Drawing.Point(231, 321);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(113, 54);
            this.güncelle.TabIndex = 18;
            this.güncelle.Text = "  KAYIT    GÜNCELLE";
            this.güncelle.UseVisualStyleBackColor = false;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // listele
            // 
            this.listele.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listele.Font = new System.Drawing.Font("Roboto", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listele.ImageKey = "tl (6).png";
            this.listele.ImageList = this.ımageList1;
            this.listele.Location = new System.Drawing.Point(350, 321);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(94, 54);
            this.listele.TabIndex = 19;
            this.listele.Text = "   LİSTELE";
            this.listele.UseVisualStyleBackColor = false;
            this.listele.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Yaş";
            // 
            // yas
            // 
            this.yas.Location = new System.Drawing.Point(173, 225);
            this.yas.Multiline = true;
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(121, 25);
            this.yas.TabIndex = 24;
            this.yas.TextChanged += new System.EventHandler(this.yas_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(478, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 370);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dogtar
            // 
            this.dogtar.Location = new System.Drawing.Point(173, 266);
            this.dogtar.Name = "dogtar";
            this.dogtar.Size = new System.Drawing.Size(178, 20);
            this.dogtar.TabIndex = 26;
            this.dogtar.ValueChanged += new System.EventHandler(this.dogtar_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(22, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.BackColor = System.Drawing.Color.Transparent;
            this.soyad.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad.Location = new System.Drawing.Point(22, 155);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(122, 23);
            this.soyad.TabIndex = 28;
            this.soyad.Text = "Hasta Soyadı :";
            // 
            // soyadi
            // 
            this.soyadi.Location = new System.Drawing.Point(173, 158);
            this.soyadi.Multiline = true;
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(121, 26);
            this.soyadi.TabIndex = 29;
            this.soyadi.TextChanged += new System.EventHandler(this.soyadi_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gERİToolStripMenuItem,
            this.çIKIŞToolStripMenuItem,
            this.öNEMLİToolStripMenuItem,
            this.yARDIMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gERİToolStripMenuItem
            // 
            this.gERİToolStripMenuItem.CheckOnClick = true;
            this.gERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gERİToolStripMenuItem1,
            this.çIKIŞToolStripMenuItem1});
            this.gERİToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gERİToolStripMenuItem.Image")));
            this.gERİToolStripMenuItem.Name = "gERİToolStripMenuItem";
            this.gERİToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.gERİToolStripMenuItem.Text = "DOSYA";
            this.gERİToolStripMenuItem.Click += new System.EventHandler(this.gERİToolStripMenuItem_Click);
            // 
            // gERİToolStripMenuItem1
            // 
            this.gERİToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("gERİToolStripMenuItem1.Image")));
            this.gERİToolStripMenuItem1.Name = "gERİToolStripMenuItem1";
            this.gERİToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.gERİToolStripMenuItem1.Text = "GERİ";
            this.gERİToolStripMenuItem1.Click += new System.EventHandler(this.gERİToolStripMenuItem1_Click);
            // 
            // çIKIŞToolStripMenuItem1
            // 
            this.çIKIŞToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("çIKIŞToolStripMenuItem1.Image")));
            this.çIKIŞToolStripMenuItem1.Name = "çIKIŞToolStripMenuItem1";
            this.çIKIŞToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.çIKIŞToolStripMenuItem1.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem1.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem1_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("çIKIŞToolStripMenuItem.BackgroundImage")));
            this.çIKIŞToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çIKIŞToolStripMenuItem.Image")));
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.çIKIŞToolStripMenuItem.Text = "İLETİŞİM";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // öNEMLİToolStripMenuItem
            // 
            this.öNEMLİToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öNEMLİToolStripMenuItem.Image")));
            this.öNEMLİToolStripMenuItem.Name = "öNEMLİToolStripMenuItem";
            this.öNEMLİToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.öNEMLİToolStripMenuItem.Text = "ÖNEMLİ";
            this.öNEMLİToolStripMenuItem.Click += new System.EventHandler(this.öNEMLİToolStripMenuItem_Click);
            // 
            // yARDIMToolStripMenuItem
            // 
            this.yARDIMToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yARDIMToolStripMenuItem.Image")));
            this.yARDIMToolStripMenuItem.Name = "yARDIMToolStripMenuItem";
            this.yARDIMToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.yARDIMToolStripMenuItem.Text = "YARDIM";
            this.yARDIMToolStripMenuItem.Click += new System.EventHandler(this.yARDIMToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Open Sans ExtraBold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(483, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 26);
            this.label5.TabIndex = 31;
            this.label5.Text = "KAYITLARI LİSTELEME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Open Sans ExtraBold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(48, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 28);
            this.label7.TabIndex = 32;
            this.label7.Text = "HASTA KAYIT FORMU";
            // 
            // statusBar1
            // 
            this.statusBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusBar1.Location = new System.Drawing.Point(769, 445);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(116, 26);
            this.statusBar1.TabIndex = 33;
            this.statusBar1.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.statusBar1_PanelClick);
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
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
            this.statusBar2.Location = new System.Drawing.Point(693, 0);
            this.statusBar2.Name = "statusBar2";
            this.statusBar2.Size = new System.Drawing.Size(192, 22);
            this.statusBar2.TabIndex = 34;
            this.statusBar2.Text = "BÜŞRA NUR ECE / 16010011050";
            // 
            // Form1Hastakayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 469);
            this.Controls.Add(this.statusBar2);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.soyadi);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dogtar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adı);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1Hastakayıt";
            this.Text = "Hasta Kayıt";
            this.Load += new System.EventHandler(this.Form1Hastakayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.TextBox adı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dogtar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.TextBox soyadi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gERİToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem öNEMLİToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem yARDIMToolStripMenuItem;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.StatusBar statusBar2;
    }
}

