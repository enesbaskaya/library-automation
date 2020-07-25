using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class AnaPanel : Form
    {
        private static Boolean connection = false;
        public bool isAdmin = false;
        private string Host = "localhost";
        private string User = "postgres";
        private string DBname = "VTYSProje";
        private string Password = "123456";
        private string Port = "5432";
        public NpgsqlConnection conn;
        public AnaPanel()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            sifreTB.PasswordChar = '*';
            string connString =
            String.Format(
           "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer", Host, User, DBname, Port, Password);
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
                connection = true;
            }
            catch (Exception)
            {
                connection = false;
            }

                
        }


        ~AnaPanel()
        {
            conn.Close();
        }

        private void girisYap_Click(object sender, EventArgs e)
        {
            if (connection)
            {
                string e_Mail = eMailTB.Text;
                string sifre = sifreTB.Text;
                if (e_Mail.Length > 0 && sifre.Length > 0)
                {
                    var command = new NpgsqlCommand("SELECT \"adSoyad\", \"sifre\", \"eMail\", \"yetki\"" +
                        " FROM uyeler WHERE (\"eMail\" = '" + e_Mail + "' AND \"sifre\"='" + sifre + "')", conn);
                    NpgsqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Giriş başarılı!\nHosgeldiniz sayın, " + dr[0] + "!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isAdmin = (bool)dr[3];
                        if (isAdmin)
                        {

                            AdminPanel panel = new AdminPanel(dr[0], conn, this);
                            dr.Close();
                            panel.Show();
                            this.Hide();

                        }
                        else
                        {
                            UyePanel panel = new UyePanel(dr[0], conn, this);
                            dr.Close();
                            panel.Show();
                            this.Hide();
                           


                        }
                        eMailTB.Clear();
                        sifreTB.Clear();

                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Hata! Kullanıcı bulunamadı!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Hata! E-Mail veya Şifre boş!\nLütfen alanları tam olarak doldurunuz...", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hata! Veritabanı bağlantısı kurulamadı!\nLütfen bir yetkiliye bildiriniz...", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void kaydol_Click(object sender, EventArgs e)
        {
            if (connection)
            {
                this.Hide();
                Kaydol k = new Kaydol(conn, this);
                k.Show();
            }
            else
            {
                MessageBox.Show("Hata! Veritabanı bağlantısı kurulamadı!\nLütfen bir yetkiliye bildiriniz...", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
