namespace Proje
{
    partial class Kaydol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kaydol));
            this.adSoyad = new System.Windows.Forms.TextBox();
            this.GSM = new System.Windows.Forms.TextBox();
            this.eMail = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.bolumler = new System.Windows.Forms.ComboBox();
            this.unvanlar = new System.Windows.Forms.ComboBox();
            this.kaydedBeni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.geriDon = new System.Windows.Forms.Button();
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adSoyad
            // 
            this.adSoyad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.adSoyad.Location = new System.Drawing.Point(295, 255);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(215, 22);
            this.adSoyad.TabIndex = 0;
            // 
            // GSM
            // 
            this.GSM.Location = new System.Drawing.Point(295, 341);
            this.GSM.Name = "GSM";
            this.GSM.Size = new System.Drawing.Size(215, 22);
            this.GSM.TabIndex = 2;
            // 
            // eMail
            // 
            this.eMail.Location = new System.Drawing.Point(295, 296);
            this.eMail.Name = "eMail";
            this.eMail.Size = new System.Drawing.Size(215, 22);
            this.eMail.TabIndex = 1;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(295, 432);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(215, 22);
            this.adres.TabIndex = 4;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(295, 385);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(215, 22);
            this.sifre.TabIndex = 3;
            // 
            // bolumler
            // 
            this.bolumler.FormattingEnabled = true;
            this.bolumler.Location = new System.Drawing.Point(295, 479);
            this.bolumler.Name = "bolumler";
            this.bolumler.Size = new System.Drawing.Size(215, 24);
            this.bolumler.TabIndex = 5;
            // 
            // unvanlar
            // 
            this.unvanlar.FormattingEnabled = true;
            this.unvanlar.Location = new System.Drawing.Point(295, 530);
            this.unvanlar.Name = "unvanlar";
            this.unvanlar.Size = new System.Drawing.Size(215, 24);
            this.unvanlar.TabIndex = 6;
            // 
            // kaydedBeni
            // 
            this.kaydedBeni.BackColor = System.Drawing.Color.Chocolate;
            this.kaydedBeni.FlatAppearance.BorderSize = 0;
            this.kaydedBeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydedBeni.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaydedBeni.ForeColor = System.Drawing.Color.White;
            this.kaydedBeni.Location = new System.Drawing.Point(221, 581);
            this.kaydedBeni.Name = "kaydedBeni";
            this.kaydedBeni.Size = new System.Drawing.Size(144, 32);
            this.kaydedBeni.TabIndex = 7;
            this.kaydedBeni.Text = "Kayıt Ol";
            this.kaydedBeni.UseVisualStyleBackColor = false;
            this.kaydedBeni.Click += new System.EventHandler(this.kaydedBeni_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(197, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(197, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "GSM";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(197, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(197, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adres";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(197, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bölüm";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(197, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ünvan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Proje.Properties.Resources._010;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(282, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 211);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // geriDon
            // 
            this.geriDon.BackColor = System.Drawing.Color.Chocolate;
            this.geriDon.FlatAppearance.BorderSize = 0;
            this.geriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriDon.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geriDon.ForeColor = System.Drawing.Color.White;
            this.geriDon.Location = new System.Drawing.Point(413, 581);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(144, 32);
            this.geriDon.TabIndex = 8;
            this.geriDon.Text = "Geri Dön";
            this.geriDon.UseVisualStyleBackColor = false;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // Kaydol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proje.Properties.Resources.ap;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 648);
            this.Controls.Add(this.geriDon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kaydedBeni);
            this.Controls.Add(this.unvanlar);
            this.Controls.Add(this.bolumler);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.eMail);
            this.Controls.Add(this.GSM);
            this.Controls.Add(this.adSoyad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kaydol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAÜ Kütüphane";
            this.Load += new System.EventHandler(this.Kaydol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adSoyad;
        private System.Windows.Forms.TextBox GSM;
        private System.Windows.Forms.TextBox eMail;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.ComboBox bolumler;
        private System.Windows.Forms.ComboBox unvanlar;
        private System.Windows.Forms.Button kaydedBeni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button geriDon;
        private Npgsql.NpgsqlCommand npgsqlCommand1;
    }
}