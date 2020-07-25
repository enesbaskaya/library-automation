namespace Proje
{
    partial class UyePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyePanel));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Kiralama = new System.Windows.Forms.TabPage();
            this.kitaplar = new System.Windows.Forms.DataGridView();
            this.satinAlTikla = new System.Windows.Forms.Button();
            this.kiralaTikla = new System.Windows.Forms.Button();
            this.iade = new System.Windows.Forms.TabPage();
            this.uyeIadeler = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uyeKiralamari = new System.Windows.Forms.DataGridView();
            this.iadeEtBeni = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uyeSatinAlim = new System.Windows.Forms.DataGridView();
            this.uyeBakiye = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tutarYukle = new System.Windows.Forms.Button();
            this.tutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kartAS = new System.Windows.Forms.TextBox();
            this.cvv = new System.Windows.Forms.TextBox();
            this.skt = new System.Windows.Forms.TextBox();
            this.kartNo = new System.Windows.Forms.TextBox();
            this.cikis = new System.Windows.Forms.Button();
            this.hosGeldin = new System.Windows.Forms.Label();
            this.programiKapat = new System.Windows.Forms.Button();
            this.bakiyeGoster = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.Kiralama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplar)).BeginInit();
            this.iade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyeIadeler)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyeKiralamari)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyeSatinAlim)).BeginInit();
            this.uyeBakiye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Kiralama);
            this.TabControl.Controls.Add(this.iade);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.uyeBakiye);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabControl.Location = new System.Drawing.Point(0, 147);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1582, 706);
            this.TabControl.TabIndex = 1;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // Kiralama
            // 
            this.Kiralama.BackgroundImage = global::Proje.Properties.Resources.radial_spectrum_abstract_4k_iu_1920x1080;
            this.Kiralama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Kiralama.Controls.Add(this.label7);
            this.Kiralama.Controls.Add(this.kitaplar);
            this.Kiralama.Controls.Add(this.satinAlTikla);
            this.Kiralama.Controls.Add(this.kiralaTikla);
            this.Kiralama.Location = new System.Drawing.Point(4, 25);
            this.Kiralama.Name = "Kiralama";
            this.Kiralama.Padding = new System.Windows.Forms.Padding(3);
            this.Kiralama.Size = new System.Drawing.Size(1574, 677);
            this.Kiralama.TabIndex = 0;
            this.Kiralama.Text = "Kiralama & Satın Alma";
            this.Kiralama.UseVisualStyleBackColor = true;
            // 
            // kitaplar
            // 
            this.kitaplar.AllowUserToAddRows = false;
            this.kitaplar.AllowUserToDeleteRows = false;
            this.kitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kitaplar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kitaplar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kitaplar.Location = new System.Drawing.Point(3, 121);
            this.kitaplar.Name = "kitaplar";
            this.kitaplar.RowHeadersWidth = 51;
            this.kitaplar.RowTemplate.Height = 24;
            this.kitaplar.Size = new System.Drawing.Size(1568, 553);
            this.kitaplar.TabIndex = 5;
            // 
            // satinAlTikla
            // 
            this.satinAlTikla.BackColor = System.Drawing.SystemColors.HotTrack;
            this.satinAlTikla.FlatAppearance.BorderSize = 0;
            this.satinAlTikla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satinAlTikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satinAlTikla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.satinAlTikla.Location = new System.Drawing.Point(1292, 59);
            this.satinAlTikla.Name = "satinAlTikla";
            this.satinAlTikla.Size = new System.Drawing.Size(135, 56);
            this.satinAlTikla.TabIndex = 4;
            this.satinAlTikla.Text = "Satın Al";
            this.satinAlTikla.UseVisualStyleBackColor = false;
            this.satinAlTikla.Click += new System.EventHandler(this.satinAlTikla_Click);
            // 
            // kiralaTikla
            // 
            this.kiralaTikla.BackColor = System.Drawing.SystemColors.HotTrack;
            this.kiralaTikla.FlatAppearance.BorderSize = 0;
            this.kiralaTikla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kiralaTikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kiralaTikla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kiralaTikla.Location = new System.Drawing.Point(127, 59);
            this.kiralaTikla.Name = "kiralaTikla";
            this.kiralaTikla.Size = new System.Drawing.Size(135, 56);
            this.kiralaTikla.TabIndex = 3;
            this.kiralaTikla.Text = "Kirala";
            this.kiralaTikla.UseVisualStyleBackColor = false;
            this.kiralaTikla.Click += new System.EventHandler(this.kiralaTikla_Click);
            // 
            // iade
            // 
            this.iade.BackgroundImage = global::Proje.Properties.Resources.radial_spectrum_abstract_4k_iu_1920x1080;
            this.iade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iade.Controls.Add(this.label8);
            this.iade.Controls.Add(this.uyeIadeler);
            this.iade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iade.Location = new System.Drawing.Point(4, 25);
            this.iade.Name = "iade";
            this.iade.Padding = new System.Windows.Forms.Padding(3);
            this.iade.Size = new System.Drawing.Size(1574, 677);
            this.iade.TabIndex = 1;
            this.iade.Text = "İadelerim";
            this.iade.UseVisualStyleBackColor = true;
            // 
            // uyeIadeler
            // 
            this.uyeIadeler.AllowUserToAddRows = false;
            this.uyeIadeler.AllowUserToDeleteRows = false;
            this.uyeIadeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uyeIadeler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uyeIadeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyeIadeler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uyeIadeler.Location = new System.Drawing.Point(3, 121);
            this.uyeIadeler.Name = "uyeIadeler";
            this.uyeIadeler.RowHeadersWidth = 51;
            this.uyeIadeler.RowTemplate.Height = 24;
            this.uyeIadeler.Size = new System.Drawing.Size(1568, 553);
            this.uyeIadeler.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Proje.Properties.Resources.radial_spectrum_abstract_4k_iu_1920x1080;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.uyeKiralamari);
            this.tabPage1.Controls.Add(this.iadeEtBeni);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1574, 677);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Kiralamalarım";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // uyeKiralamari
            // 
            this.uyeKiralamari.AllowUserToAddRows = false;
            this.uyeKiralamari.AllowUserToDeleteRows = false;
            this.uyeKiralamari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uyeKiralamari.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uyeKiralamari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyeKiralamari.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uyeKiralamari.Location = new System.Drawing.Point(3, 121);
            this.uyeKiralamari.Name = "uyeKiralamari";
            this.uyeKiralamari.RowHeadersWidth = 51;
            this.uyeKiralamari.RowTemplate.Height = 24;
            this.uyeKiralamari.Size = new System.Drawing.Size(1568, 553);
            this.uyeKiralamari.TabIndex = 6;
            // 
            // iadeEtBeni
            // 
            this.iadeEtBeni.BackColor = System.Drawing.SystemColors.HotTrack;
            this.iadeEtBeni.FlatAppearance.BorderSize = 0;
            this.iadeEtBeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iadeEtBeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iadeEtBeni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iadeEtBeni.Location = new System.Drawing.Point(720, 66);
            this.iadeEtBeni.Name = "iadeEtBeni";
            this.iadeEtBeni.Size = new System.Drawing.Size(135, 49);
            this.iadeEtBeni.TabIndex = 5;
            this.iadeEtBeni.Text = "İade Et";
            this.iadeEtBeni.UseVisualStyleBackColor = false;
            this.iadeEtBeni.Click += new System.EventHandler(this.iadeEtBeni_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Proje.Properties.Resources.radial_spectrum_abstract_4k_iu_1920x1080;
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.uyeSatinAlim);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1574, 677);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Satın Alımlarım";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uyeSatinAlim
            // 
            this.uyeSatinAlim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uyeSatinAlim.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uyeSatinAlim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyeSatinAlim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uyeSatinAlim.Location = new System.Drawing.Point(3, 121);
            this.uyeSatinAlim.Name = "uyeSatinAlim";
            this.uyeSatinAlim.RowHeadersWidth = 51;
            this.uyeSatinAlim.RowTemplate.Height = 24;
            this.uyeSatinAlim.Size = new System.Drawing.Size(1568, 553);
            this.uyeSatinAlim.TabIndex = 0;
            // 
            // uyeBakiye
            // 
            this.uyeBakiye.BackgroundImage = global::Proje.Properties.Resources.abs_blue;
            this.uyeBakiye.Controls.Add(this.pictureBox1);
            this.uyeBakiye.Controls.Add(this.tutarYukle);
            this.uyeBakiye.Controls.Add(this.tutar);
            this.uyeBakiye.Controls.Add(this.label5);
            this.uyeBakiye.Controls.Add(this.label4);
            this.uyeBakiye.Controls.Add(this.label3);
            this.uyeBakiye.Controls.Add(this.label2);
            this.uyeBakiye.Controls.Add(this.label1);
            this.uyeBakiye.Controls.Add(this.kartAS);
            this.uyeBakiye.Controls.Add(this.cvv);
            this.uyeBakiye.Controls.Add(this.skt);
            this.uyeBakiye.Controls.Add(this.kartNo);
            this.uyeBakiye.Location = new System.Drawing.Point(4, 25);
            this.uyeBakiye.Name = "uyeBakiye";
            this.uyeBakiye.Padding = new System.Windows.Forms.Padding(3);
            this.uyeBakiye.Size = new System.Drawing.Size(1574, 677);
            this.uyeBakiye.TabIndex = 4;
            this.uyeBakiye.Text = "Bakiye Yükle";
            this.uyeBakiye.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Proje.Properties.Resources.mc;
            this.pictureBox1.Location = new System.Drawing.Point(579, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(992, 671);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tutarYukle
            // 
            this.tutarYukle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tutarYukle.FlatAppearance.BorderSize = 0;
            this.tutarYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutarYukle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tutarYukle.Location = new System.Drawing.Point(302, 394);
            this.tutarYukle.Name = "tutarYukle";
            this.tutarYukle.Size = new System.Drawing.Size(98, 29);
            this.tutarYukle.TabIndex = 5;
            this.tutarYukle.Text = "Yükle";
            this.tutarYukle.UseVisualStyleBackColor = false;
            this.tutarYukle.Click += new System.EventHandler(this.tutarYukle_Click);
            // 
            // tutar
            // 
            this.tutar.Location = new System.Drawing.Point(300, 317);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(100, 22);
            this.tutar.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(38, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yüklenecek Tutar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(38, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kart Üzerindeki Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(38, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "CVV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(38, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "SKT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(38, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kart No";
            // 
            // kartAS
            // 
            this.kartAS.Location = new System.Drawing.Point(302, 147);
            this.kartAS.Name = "kartAS";
            this.kartAS.Size = new System.Drawing.Size(100, 22);
            this.kartAS.TabIndex = 1;
            // 
            // cvv
            // 
            this.cvv.Location = new System.Drawing.Point(302, 194);
            this.cvv.Name = "cvv";
            this.cvv.Size = new System.Drawing.Size(100, 22);
            this.cvv.TabIndex = 2;
            // 
            // skt
            // 
            this.skt.Location = new System.Drawing.Point(302, 240);
            this.skt.Name = "skt";
            this.skt.Size = new System.Drawing.Size(100, 22);
            this.skt.TabIndex = 3;
            // 
            // kartNo
            // 
            this.kartNo.Location = new System.Drawing.Point(302, 104);
            this.kartNo.Name = "kartNo";
            this.kartNo.Size = new System.Drawing.Size(100, 22);
            this.kartNo.TabIndex = 0;
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cikis.FlatAppearance.BorderSize = 0;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikis.ForeColor = System.Drawing.Color.White;
            this.cikis.Location = new System.Drawing.Point(12, 93);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(162, 37);
            this.cikis.TabIndex = 2;
            this.cikis.Text = "Çıkış Yap";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // hosGeldin
            // 
            this.hosGeldin.BackColor = System.Drawing.Color.Transparent;
            this.hosGeldin.Dock = System.Windows.Forms.DockStyle.Top;
            this.hosGeldin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hosGeldin.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hosGeldin.ForeColor = System.Drawing.Color.White;
            this.hosGeldin.Location = new System.Drawing.Point(0, 0);
            this.hosGeldin.Name = "hosGeldin";
            this.hosGeldin.Size = new System.Drawing.Size(1582, 52);
            this.hosGeldin.TabIndex = 3;
            this.hosGeldin.Text = "Hoşgeldiniz";
            this.hosGeldin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // programiKapat
            // 
            this.programiKapat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.programiKapat.FlatAppearance.BorderSize = 0;
            this.programiKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.programiKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programiKapat.ForeColor = System.Drawing.Color.White;
            this.programiKapat.Location = new System.Drawing.Point(1386, 93);
            this.programiKapat.Name = "programiKapat";
            this.programiKapat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.programiKapat.Size = new System.Drawing.Size(162, 37);
            this.programiKapat.TabIndex = 4;
            this.programiKapat.Text = "Programı Kapat";
            this.programiKapat.UseVisualStyleBackColor = false;
            this.programiKapat.Click += new System.EventHandler(this.programiKapat_Click);
            // 
            // bakiyeGoster
            // 
            this.bakiyeGoster.BackColor = System.Drawing.Color.Transparent;
            this.bakiyeGoster.Dock = System.Windows.Forms.DockStyle.Top;
            this.bakiyeGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bakiyeGoster.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakiyeGoster.ForeColor = System.Drawing.Color.White;
            this.bakiyeGoster.Location = new System.Drawing.Point(0, 52);
            this.bakiyeGoster.Name = "bakiyeGoster";
            this.bakiyeGoster.Size = new System.Drawing.Size(1582, 38);
            this.bakiyeGoster.TabIndex = 5;
            this.bakiyeGoster.Text = "Bakiyeniz; ₺";
            this.bakiyeGoster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1568, 53);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kitap Listesi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1568, 122);
            this.label8.TabIndex = 7;
            this.label8.Text = "İade Ettiginiz Kitaplar";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1568, 60);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kiraladıgınız Kitaplar";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1568, 123);
            this.label10.TabIndex = 9;
            this.label10.Text = "Satın Alımlarınız";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UyePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proje.Properties.Resources.abstract_blue_color_5k_8h_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.bakiyeGoster);
            this.Controls.Add(this.programiKapat);
            this.Controls.Add(this.hosGeldin);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.cikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UyePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAÜ Kütüphane Üye Paneli";
            this.Load += new System.EventHandler(this.UyePanel_Load);
            this.TabControl.ResumeLayout(false);
            this.Kiralama.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kitaplar)).EndInit();
            this.iade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uyeIadeler)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uyeKiralamari)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uyeSatinAlim)).EndInit();
            this.uyeBakiye.ResumeLayout(false);
            this.uyeBakiye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Kiralama;
        private System.Windows.Forms.TabPage iade;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button satinAlTikla;
        private System.Windows.Forms.Button kiralaTikla;
        private System.Windows.Forms.Label hosGeldin;
        private System.Windows.Forms.Button programiKapat;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage uyeBakiye;
        private System.Windows.Forms.Button tutarYukle;
        private System.Windows.Forms.TextBox tutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kartAS;
        private System.Windows.Forms.TextBox cvv;
        private System.Windows.Forms.TextBox skt;
        private System.Windows.Forms.TextBox kartNo;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.Button iadeEtBeni;
        private System.Windows.Forms.Label bakiyeGoster;
        private System.Windows.Forms.DataGridView kitaplar;
        private System.Windows.Forms.DataGridView uyeIadeler;
        private System.Windows.Forms.DataGridView uyeKiralamari;
        private System.Windows.Forms.DataGridView uyeSatinAlim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}