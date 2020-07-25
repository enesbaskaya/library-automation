using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Kaydol : Form
    {
        private NpgsqlConnection conn;
        private AnaPanel anaPanel;
        public Kaydol(NpgsqlConnection conn, AnaPanel panel)
        {
            InitializeComponent();
            this.conn = conn;
            sifre.PasswordChar = '*';
            this.anaPanel = panel;
        }

        private void Kaydol_Load(object sender, EventArgs e)
        {
            this.bolumleriListele();
            this.unvanlariListele();



        }

        private void bolumleriListele()
        {
            var bolumlerx = new NpgsqlCommand("SELECT * FROM bolumler ORDER BY \"bolumAdi\"", conn);
            NpgsqlDataReader dr = bolumlerx.ExecuteReader();
            while (dr.Read())
            {
                bolumler.Items.Add(dr[1]);
            }
            bolumler.SelectedIndex = 0;
            dr.Close();
        }

        private void unvanlariListele()
        {
            var unvanlarx = new NpgsqlCommand("SELECT * FROM unvanlar ORDER BY \"unvanAdi\"", conn);
            NpgsqlDataReader dr = unvanlarx.ExecuteReader();
            while (dr.Read())
            {
                unvanlar.Items.Add(dr[1]);
            }
            unvanlar.SelectedIndex = 0;
            dr.Close();
        }

        private void kaydedBeni_Click(object sender, EventArgs e)
        {
            if (adSoyad.Text != null && adres.Text != null && eMail.Text != null && GSM.Text != null && sifre.Text != null)
            {
                if (adSoyad.Text.Length > 0 && adres.Text.Length > 0 && eMail.Text.Length > 0 && GSM.Text.Length > 0 && sifre.Text.Length > 0)
                {
                    var uyeEkle = new NpgsqlCommand("INSERT INTO uyeler (\"adSoyad\",  " +
                       "\"adres\",  \"eMail\",\"GSM\", \"unvanNo\", \"bolumNo\"" +
                       ",\"yetki\",\"sifre\") VALUES (@adi, @adres, @mail, @gsm, @unvan, @bolum, @yetki, @sifre)", conn);
                    uyeEkle.Parameters.AddWithValue("@adi", adSoyad.Text);
                    uyeEkle.Parameters.AddWithValue("@adres", adres.Text);
                    uyeEkle.Parameters.AddWithValue("@mail", eMail.Text);
                    uyeEkle.Parameters.AddWithValue("@gsm", GSM.Text);
                    uyeEkle.Parameters.AddWithValue("@yetki", false);
                    uyeEkle.Parameters.AddWithValue("@sifre", sifre.Text);


                    String unvan = (String)unvanlar.SelectedItem;
                    var uyeUnvan = new NpgsqlCommand("SELECT \"unvanID\" FROM unvanlar WHERE" +
                       " (\"unvanAdi\" = '" + unvan + "')", conn);
                    NpgsqlDataReader drs = uyeUnvan.ExecuteReader();
                    if (drs.Read())
                    {
                        uyeEkle.Parameters.AddWithValue("@unvan", drs[0]);
                    }
                    drs.Close();


                    var uyeBOlum = new NpgsqlCommand("SELECT \"bolumID\" FROM bolumler WHERE" +
                        " '" + bolumler.SelectedItem + "' = \"bolumler\" . \"bolumAdi\"", conn);
                    NpgsqlDataReader drx = uyeBOlum.ExecuteReader();
                    if (drx.Read())
                        uyeEkle.Parameters.AddWithValue("@bolum", drx[0]);
                    drx.Close();
                    uyeEkle.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı!\nKütüphane arayüzüne yönlendiriliyorsunuz...", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UyePanel panel = new UyePanel(adSoyad.Text, conn, anaPanel);
                    this.Hide();
                    panel.Show();
                }
                else
                {
                    MessageBox.Show("Lütfen alanları eksiksiz doldurunuz!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen alanları eksiksiz doldurunuz!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            anaPanel.Show();

        }
    }
}
