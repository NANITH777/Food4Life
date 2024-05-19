namespace YemekSiparisSistemi
{
    partial class Menuform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMalzemeEkle = new System.Windows.Forms.LinkLabel();
            this.btnmalguncelle = new System.Windows.Forms.LinkLabel();
            this.uC_MalzemelerGuncelle1 = new YemekSiparisSistemi.KullaniciControl.UC_MalzemelerGuncelle();
            this.uC_Yemekmalzemeleri1 = new YemekSiparisSistemi.KullaniciControl.UC_Yemekmalzemeleri();
            this.uC_UrunGuncelle1 = new YemekSiparisSistemi.KullaniciControl.UC_UrunGuncelle();
            this.uC_UrunEkle1 = new YemekSiparisSistemi.KullaniciControl.UC_UrunEkle();
            this.uC_YemekGuncelleme1 = new YemekSiparisSistemi.KullaniciControl.UC_YemekGuncelleme();
            this.uC_Siparis1 = new YemekSiparisSistemi.KullaniciControl.UC_Siparis();
            this.uC_YemekEkleme1 = new YemekSiparisSistemi.KullaniciControl.UC_YemekEkleme();
            this.uC_Hosgeldiniz1 = new YemekSiparisSistemi.KullaniciControl.UC_Hosgeldiniz();
            this.btnSiparis = new System.Windows.Forms.LinkLabel();
            this.btnyemekekleme = new System.Windows.Forms.LinkLabel();
            this.btnyemekguncelleme = new System.Windows.Forms.LinkLabel();
            this.btnurunekleme = new System.Windows.Forms.LinkLabel();
            this.btnurunguncelleme = new System.Windows.Forms.LinkLabel();
            this.btnLokantaRaporu = new System.Windows.Forms.LinkLabel();
            this.uC_LokantaRaporu1 = new YemekSiparisSistemi.KullaniciControl.UC_LokantaRaporu();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnLokantaRaporu);
            this.panel1.Controls.Add(this.btnurunguncelleme);
            this.panel1.Controls.Add(this.btnurunekleme);
            this.panel1.Controls.Add(this.btnyemekekleme);
            this.panel1.Controls.Add(this.btnyemekguncelleme);
            this.panel1.Controls.Add(this.btnSiparis);
            this.panel1.Controls.Add(this.btnmalguncelle);
            this.panel1.Controls.Add(this.btnMalzemeEkle);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 698);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(31, 657);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 24);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.uC_LokantaRaporu1);
            this.panel4.Controls.Add(this.uC_MalzemelerGuncelle1);
            this.panel4.Controls.Add(this.uC_Yemekmalzemeleri1);
            this.panel4.Controls.Add(this.uC_UrunGuncelle1);
            this.panel4.Controls.Add(this.uC_UrunEkle1);
            this.panel4.Controls.Add(this.uC_YemekGuncelleme1);
            this.panel4.Controls.Add(this.uC_Siparis1);
            this.panel4.Controls.Add(this.uC_YemekEkleme1);
            this.panel4.Controls.Add(this.uC_Hosgeldiniz1);
            this.panel4.Location = new System.Drawing.Point(180, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(876, 698);
            this.panel4.TabIndex = 3;
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.AutoSize = true;
            this.btnMalzemeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMalzemeEkle.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnMalzemeEkle.LinkColor = System.Drawing.Color.White;
            this.btnMalzemeEkle.Location = new System.Drawing.Point(10, 365);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(175, 24);
            this.btnMalzemeEkle.TabIndex = 11;
            this.btnMalzemeEkle.TabStop = true;
            this.btnMalzemeEkle.Text = "Malzemeler ekleme";
            this.btnMalzemeEkle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnMalzemeEkle_LinkClicked);
            // 
            // btnmalguncelle
            // 
            this.btnmalguncelle.AutoSize = true;
            this.btnmalguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmalguncelle.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnmalguncelle.LinkColor = System.Drawing.Color.White;
            this.btnmalguncelle.Location = new System.Drawing.Point(13, 433);
            this.btnmalguncelle.Name = "btnmalguncelle";
            this.btnmalguncelle.Size = new System.Drawing.Size(113, 48);
            this.btnmalguncelle.TabIndex = 12;
            this.btnmalguncelle.TabStop = true;
            this.btnmalguncelle.Text = "Malzemeler\r\nGüncelleme";
            this.btnmalguncelle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnmalguncelle_LinkClicked);
            // 
            // uC_MalzemelerGuncelle1
            // 
            this.uC_MalzemelerGuncelle1.BackColor = System.Drawing.Color.Blue;
            this.uC_MalzemelerGuncelle1.Location = new System.Drawing.Point(0, 0);
            this.uC_MalzemelerGuncelle1.Name = "uC_MalzemelerGuncelle1";
            this.uC_MalzemelerGuncelle1.Size = new System.Drawing.Size(876, 701);
            this.uC_MalzemelerGuncelle1.TabIndex = 6;
            // 
            // uC_Yemekmalzemeleri1
            // 
            this.uC_Yemekmalzemeleri1.BackColor = System.Drawing.Color.Blue;
            this.uC_Yemekmalzemeleri1.ForeColor = System.Drawing.Color.White;
            this.uC_Yemekmalzemeleri1.Location = new System.Drawing.Point(0, 0);
            this.uC_Yemekmalzemeleri1.Name = "uC_Yemekmalzemeleri1";
            this.uC_Yemekmalzemeleri1.Size = new System.Drawing.Size(879, 698);
            this.uC_Yemekmalzemeleri1.TabIndex = 5;
            // 
            // uC_UrunGuncelle1
            // 
            this.uC_UrunGuncelle1.BackColor = System.Drawing.Color.Blue;
            this.uC_UrunGuncelle1.Location = new System.Drawing.Point(3, 0);
            this.uC_UrunGuncelle1.Name = "uC_UrunGuncelle1";
            this.uC_UrunGuncelle1.Size = new System.Drawing.Size(876, 701);
            this.uC_UrunGuncelle1.TabIndex = 4;
            // 
            // uC_UrunEkle1
            // 
            this.uC_UrunEkle1.BackColor = System.Drawing.Color.Blue;
            this.uC_UrunEkle1.Location = new System.Drawing.Point(3, 0);
            this.uC_UrunEkle1.Name = "uC_UrunEkle1";
            this.uC_UrunEkle1.Size = new System.Drawing.Size(876, 701);
            this.uC_UrunEkle1.TabIndex = 4;
            // 
            // uC_YemekGuncelleme1
            // 
            this.uC_YemekGuncelleme1.BackColor = System.Drawing.Color.Blue;
            this.uC_YemekGuncelleme1.Location = new System.Drawing.Point(0, 0);
            this.uC_YemekGuncelleme1.Name = "uC_YemekGuncelleme1";
            this.uC_YemekGuncelleme1.Size = new System.Drawing.Size(873, 701);
            this.uC_YemekGuncelleme1.TabIndex = 3;
            // 
            // uC_Siparis1
            // 
            this.uC_Siparis1.BackColor = System.Drawing.Color.Blue;
            this.uC_Siparis1.Location = new System.Drawing.Point(3, 0);
            this.uC_Siparis1.Name = "uC_Siparis1";
            this.uC_Siparis1.Size = new System.Drawing.Size(876, 701);
            this.uC_Siparis1.TabIndex = 2;
            // 
            // uC_YemekEkleme1
            // 
            this.uC_YemekEkleme1.BackColor = System.Drawing.Color.Blue;
            this.uC_YemekEkleme1.Location = new System.Drawing.Point(3, 0);
            this.uC_YemekEkleme1.Name = "uC_YemekEkleme1";
            this.uC_YemekEkleme1.Size = new System.Drawing.Size(876, 701);
            this.uC_YemekEkleme1.TabIndex = 1;
            // 
            // uC_Hosgeldiniz1
            // 
            this.uC_Hosgeldiniz1.BackColor = System.Drawing.Color.Blue;
            this.uC_Hosgeldiniz1.Location = new System.Drawing.Point(-9, 0);
            this.uC_Hosgeldiniz1.Name = "uC_Hosgeldiniz1";
            this.uC_Hosgeldiniz1.Size = new System.Drawing.Size(895, 701);
            this.uC_Hosgeldiniz1.TabIndex = 0;
            // 
            // btnSiparis
            // 
            this.btnSiparis.AutoSize = true;
            this.btnSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparis.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnSiparis.LinkColor = System.Drawing.Color.White;
            this.btnSiparis.Location = new System.Drawing.Point(57, 25);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(66, 24);
            this.btnSiparis.TabIndex = 13;
            this.btnSiparis.TabStop = true;
            this.btnSiparis.Text = "Sipariş";
            this.btnSiparis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSiparis_LinkClicked);
            // 
            // btnyemekekleme
            // 
            this.btnyemekekleme.AutoSize = true;
            this.btnyemekekleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyemekekleme.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnyemekekleme.LinkColor = System.Drawing.Color.White;
            this.btnyemekekleme.Location = new System.Drawing.Point(13, 93);
            this.btnyemekekleme.Name = "btnyemekekleme";
            this.btnyemekekleme.Size = new System.Drawing.Size(138, 24);
            this.btnyemekekleme.TabIndex = 14;
            this.btnyemekekleme.TabStop = true;
            this.btnyemekekleme.Text = "Yemek Ekleme";
            this.btnyemekekleme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnyemekekleme_LinkClicked);
            // 
            // btnyemekguncelleme
            // 
            this.btnyemekguncelleme.AutoSize = true;
            this.btnyemekguncelleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyemekguncelleme.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnyemekguncelleme.LinkColor = System.Drawing.Color.White;
            this.btnyemekguncelleme.Location = new System.Drawing.Point(-2, 161);
            this.btnyemekguncelleme.Name = "btnyemekguncelleme";
            this.btnyemekguncelleme.Size = new System.Drawing.Size(177, 24);
            this.btnyemekguncelleme.TabIndex = 15;
            this.btnyemekguncelleme.TabStop = true;
            this.btnyemekguncelleme.Text = "Yemek Güncelleme";
            this.btnyemekguncelleme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnyemekguncelleme_LinkClicked);
            // 
            // btnurunekleme
            // 
            this.btnurunekleme.AutoSize = true;
            this.btnurunekleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnurunekleme.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnurunekleme.LinkColor = System.Drawing.Color.White;
            this.btnurunekleme.Location = new System.Drawing.Point(31, 229);
            this.btnurunekleme.Name = "btnurunekleme";
            this.btnurunekleme.Size = new System.Drawing.Size(120, 24);
            this.btnurunekleme.TabIndex = 16;
            this.btnurunekleme.TabStop = true;
            this.btnurunekleme.Text = "Ürün Ekleme";
            this.btnurunekleme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnurunekleme_LinkClicked);
            // 
            // btnurunguncelleme
            // 
            this.btnurunguncelleme.AutoSize = true;
            this.btnurunguncelleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnurunguncelleme.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnurunguncelleme.LinkColor = System.Drawing.Color.White;
            this.btnurunguncelleme.Location = new System.Drawing.Point(16, 297);
            this.btnurunguncelleme.Name = "btnurunguncelleme";
            this.btnurunguncelleme.Size = new System.Drawing.Size(159, 24);
            this.btnurunguncelleme.TabIndex = 17;
            this.btnurunguncelleme.TabStop = true;
            this.btnurunguncelleme.Text = "Ürün Güncelleme";
            this.btnurunguncelleme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnurunguncelleme_LinkClicked);
            // 
            // btnLokantaRaporu
            // 
            this.btnLokantaRaporu.AutoSize = true;
            this.btnLokantaRaporu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLokantaRaporu.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnLokantaRaporu.LinkColor = System.Drawing.Color.White;
            this.btnLokantaRaporu.Location = new System.Drawing.Point(13, 525);
            this.btnLokantaRaporu.Name = "btnLokantaRaporu";
            this.btnLokantaRaporu.Size = new System.Drawing.Size(142, 24);
            this.btnLokantaRaporu.TabIndex = 18;
            this.btnLokantaRaporu.TabStop = true;
            this.btnLokantaRaporu.Text = "Lokanta Raporu";
            this.btnLokantaRaporu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLokantaRaporu_LinkClicked);
            // 
            // uC_LokantaRaporu1
            // 
            this.uC_LokantaRaporu1.BackColor = System.Drawing.Color.Blue;
            this.uC_LokantaRaporu1.Location = new System.Drawing.Point(2, 1);
            this.uC_LokantaRaporu1.Name = "uC_LokantaRaporu1";
            this.uC_LokantaRaporu1.Size = new System.Drawing.Size(874, 703);
            this.uC_LokantaRaporu1.TabIndex = 7;
            // 
            // Menuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1057, 703);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menuform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menuform";
            this.Load += new System.EventHandler(this.Menuform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel4;
        private KullaniciControl.UC_Hosgeldiniz uC_Hosgeldiniz1;
        private KullaniciControl.UC_YemekEkleme uC_YemekEkleme1;
        private KullaniciControl.UC_Siparis uC_Siparis1;
        private KullaniciControl.UC_YemekGuncelleme uC_YemekGuncelleme1;
        private KullaniciControl.UC_UrunEkle uC_UrunEkle1;
        private KullaniciControl.UC_UrunGuncelle uC_UrunGuncelle1;
        private System.Windows.Forms.LinkLabel btnMalzemeEkle;
        private KullaniciControl.UC_Yemekmalzemeleri uC_Yemekmalzemeleri1;
        private System.Windows.Forms.LinkLabel btnmalguncelle;
        private KullaniciControl.UC_MalzemelerGuncelle uC_MalzemelerGuncelle1;
        private System.Windows.Forms.LinkLabel btnSiparis;
        private System.Windows.Forms.LinkLabel btnyemekekleme;
        private System.Windows.Forms.LinkLabel btnyemekguncelleme;
        private System.Windows.Forms.LinkLabel btnurunekleme;
        private System.Windows.Forms.LinkLabel btnurunguncelleme;
        private System.Windows.Forms.LinkLabel btnLokantaRaporu;
        private KullaniciControl.UC_LokantaRaporu uC_LokantaRaporu1;
    }
}