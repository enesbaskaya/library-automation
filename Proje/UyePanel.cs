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
    public partial class UyePanel : Form
    {
        private NpgsqlConnection conn;
        private string kullanici;
        private AnaPanel panel;
        private Int64 uyeID;
        public UyePanel(object v, NpgsqlConnection conn, AnaPanel panel)
        {
            this.conn = conn;
            this.panel = panel;
            kullanici = (string)v;
            InitializeComponent();
        }

        private void bakiyeGuncelle()
        {
            var bakiye = new NpgsqlCommand("SELECT bakiye FROM uyeler WHERE \"uyeID\" = '" + uyeID + "'", conn);
            NpgsqlDataReader rd = bakiye.ExecuteReader();
            if (rd.Read())
                bakiyeGoster.Text = "Bakiyeniz: " + (Int64)rd[0] + "₺";
            else
                bakiyeGoster.Text = "Bakiyenizi gösterirken bir sorun oluştu!";
            rd.Close();
        }

        private void UyePanel_Load(object sender, EventArgs e)
        {
            var uye_id_komutu = new NpgsqlCommand("SELECT \"uyeID\" FROM uyeler WHERE \"adSoyad\" = '" + kullanici + "'", conn);
            NpgsqlDataReader uyeIDCekici = uye_id_komutu.ExecuteReader();
            if (uyeIDCekici.Read())
                uyeID = (Int64)uyeIDCekici[0];
            else
                MessageBox.Show("Sistemsel hata oluştu!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            uyeIDCekici.Close();
            hosGeldin.Text = "Hoşgeldiniz sayın, " + kullanici;
            this.kitapListele();
            this.kiralamalariGuncelle();
            this.satinalmalariGuncelle();
            this.iadeleriGuncelle();
            this.bakiyeGuncelle();

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            panel.Show();
        }

        private void kitapListele()
        {
            //Kitap
            var kitap = new NpgsqlCommand("SELECT \"kitapID\",\"kitapAdi\",\"ISBN\",\"adet\",\"dilAdi\",\"kategoriAdi\",\"yayinEviAdi\"," +
                "\"fiyat\", \"yazarAdiSoyadi\" FROM kitap,dil,kategori,\"kitapYazar\",\"yayinEvi\",yazar WHERE \"dil\" . \"dilID\" = \"kitap\".\"dilNO\"" +
                "AND \"kategori\".\"kategoriID\" = \"kitap\" . \"kategoriNO\" AND \"yayinEvi\" . \"yayinEviID\" = \"kitap\" . \"yayinEviNO\" AND" +
                "(\"yazar\". \"yazarID\" = \"kitapYazar\".\"yazarNO\" AND \"kitap\" . \"kitapID\" = \"kitapYazar\" . \"kitapNO\")  ORDER BY \"kitapID\"", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(kitap);
            DataTable dt = new DataTable();
            da.Fill(dt);
            kitaplar.DataSource = dt;
        }

        private void kiralaTikla_Click(object sender, EventArgs e)
        {

            var adetKontrol = new NpgsqlCommand("SELECT adet FROM kitap WHERE (kitap . \"kitapID\" = @kitap_id)", conn);
            adetKontrol.Parameters.AddWithValue("@kitap_id", kitaplar.CurrentRow.Cells[0].Value);
            NpgsqlDataReader adetKontrolx = adetKontrol.ExecuteReader();
            if (adetKontrolx.Read())
            {
                if (!((Int64) adetKontrolx[0] > 0))
                {
                    MessageBox.Show("Hata! Yetersiz kitap adeti!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    adetKontrolx.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Hata! Kitap bulunamadı...\nKiralama alım başarısız!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                adetKontrolx.Close();
                return;
            }
            adetKontrolx.Close();

            var kontrolKomutu = new NpgsqlCommand("SELECT * FROM kiralamalar WHERE \"kitapNO\" = " + kitaplar.CurrentRow.Cells[0].Value + "", conn);
            NpgsqlDataReader dr = kontrolKomutu.ExecuteReader();
            if (!dr.Read())
            {
                var kiralamaEkle = new NpgsqlCommand("INSERT INTO kiralamalar (\"kitapNO\", \"uyeNO\", \"alisTarihi\", \"iadeTarihi\")" +
                    " VALUES (@kitap_id, @uye_id, @alisTarihi, @iadeTarihi)", conn);
                kiralamaEkle.Parameters.AddWithValue("@alisTarihi", DateTime.Now);
                kiralamaEkle.Parameters.AddWithValue("@iadeTarihi", DateTime.Today.AddDays(30));
                kiralamaEkle.Parameters.AddWithValue("@uye_id", uyeID);
                kiralamaEkle.Parameters.AddWithValue("@kitap_id", kitaplar.CurrentRow.Cells[0].Value);
                dr.Close();
                kiralamaEkle.ExecuteNonQuery();
                MessageBox.Show("Kiralama işlemi başarıyla gerçekleştirildi!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.kiralamalariGuncelle();
                this.kitapListele();
            }
            else
            {
                MessageBox.Show("Hata! Bu kitabı daha önce kiraladığınız için tekrar kiralama \nişlem yapamazsınız!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
        }


        private void kiralamalariGuncelle()
        {
            var kiralamalar = new NpgsqlCommand("SELECT \"kiralamaID\",\"kitapAdi\",\"dilAdi\",\"kategoriAdi\",\"yayinEviAdi\"," +
                "\"yazarAdiSoyadi\" FROM kitap,dil,kategori,kiralamalar,\"kitapYazar\",\"yayinEvi\",yazar WHERE \"dil\" . \"dilID\" = \"kitap\".\"dilNO\"" +
                "AND \"kategori\".\"kategoriID\" = \"kitap\" . \"kategoriNO\" AND \"yayinEvi\" . \"yayinEviID\" = \"kitap\" . \"yayinEviNO\" AND" +
                "(\"yazar\". \"yazarID\" = \"kitapYazar\".\"yazarNO\" AND \"kitap\" . \"kitapID\" = \"kitapYazar\" . \"kitapNO\" AND kiralamalar.\"kitapNO\" = kitap.\"kitapID\" AND kiralamalar.\"uyeNO\"='" + uyeID + "')", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(kiralamalar);
            DataTable dt = new DataTable();
            da.Fill(dt);
            uyeKiralamari.DataSource = dt;
        }

        private void satinalmalariGuncelle()
        {
            var satinalmalar = new NpgsqlCommand("SELECT \"satinAlmaID\",\"kitapAdi\",\"dilAdi\",\"kategoriAdi\",\"yayinEviAdi\"," +
                 "\"yazarAdiSoyadi\", \"alisTarihi\" FROM kitap,dil,kategori,\"satinAlmalar\",\"kitapYazar\",\"yayinEvi\",yazar WHERE \"dil\" . \"dilID\" = \"kitap\".\"dilNO\"" +
                 "AND \"kategori\".\"kategoriID\" = \"kitap\" . \"kategoriNO\" AND \"yayinEvi\" . \"yayinEviID\" = \"kitap\" . \"yayinEviNO\" AND" +
                 "(\"yazar\". \"yazarID\" = \"kitapYazar\".\"yazarNO\" AND \"kitap\" . \"kitapID\" = \"kitapYazar\" . \"kitapNO\" AND \"satinAlmalar\".\"kitapNO\" = kitap.\"kitapID\" AND \"satinAlmalar\".\"uyeNO\"='" + uyeID + "')", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(satinalmalar);
            DataTable dt = new DataTable();
            da.Fill(dt);
            uyeSatinAlim.DataSource = dt;
        }


        private void programiKapat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            conn.Close();
        }

        private void satinAlTikla_Click(object sender, EventArgs e)
        {


            var paraKontrolKomutu = new NpgsqlCommand("SELECT bakiye, fiyat, adet FROM kitap, uyeler WHERE (kitap . \"kitapID\" = @kitap_id AND uyeler . \"uyeID\" = '" + uyeID + "')", conn);
            paraKontrolKomutu.Parameters.AddWithValue("@kitap_id", kitaplar.CurrentRow.Cells[0].Value);
            NpgsqlDataReader paraKontrol = paraKontrolKomutu.ExecuteReader();
            if (paraKontrol.Read())
            {
                if ((Int64)paraKontrol[0] > (Int64)paraKontrol[1])
                {
                    if ((Int64)paraKontrol[2] > 0)
                    {
                        paraKontrol.Close();
                        var kiralamaEkle = new NpgsqlCommand("INSERT INTO \"satinAlmalar\" (\"kitapNO\", \"uyeNO\", \"alisTarihi\")" +
                            " VALUES (@kitap_id, @uye_id, @alisTarihi)", conn);
                        kiralamaEkle.Parameters.AddWithValue("@alisTarihi", DateTime.Now);
                        kiralamaEkle.Parameters.AddWithValue("@uye_id", uyeID);
                        kiralamaEkle.Parameters.AddWithValue("@kitap_id", kitaplar.CurrentRow.Cells[0].Value);
                        kiralamaEkle.ExecuteNonQuery();
                        var bakiyeAzalt = new NpgsqlCommand("UPDATE uyeler SET bakiye = bakiye - @fiyat WHERE \"uyeID\" = '" + uyeID + "'", conn);
                        bakiyeAzalt.Parameters.AddWithValue("@fiyat", kitaplar.CurrentRow.Cells[7].Value);
                        bakiyeAzalt.ExecuteNonQuery();
                        MessageBox.Show("Satın alma işlemi başarıyla gerçekleştirildi!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.satinalmalariGuncelle();
                        this.kitapListele();
                        this.bakiyeGuncelle();
                    }
                    else
                    {
                        MessageBox.Show("Hata! Yetersiz kitap adeti!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Hata! Bakiyeniz yetersiz!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hata! Kitap bulunamadı...\nSatın alım başarısız!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            paraKontrol.Close();

        }

        private Boolean isInt(String s)
        {
            try
            {
                Convert.ToInt64(s);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void tutarYukle_Click(object sender, EventArgs e)
        {
            if (cvv.Text.Length > 0 && skt.Text.Length > 0 && kartNo.Text.Length > 0 && kartAS.Text.Length > 0 && tutar.Text.Length > 0)
            {
                if (this.isInt(cvv.Text) && this.isInt(skt.Text) && this.isInt(kartNo.Text) && this.isInt(tutar.Text))
                {
                    var komut = new NpgsqlCommand("SELECT uyeler.bakiye FROM uyeler,uye_kart WHERE (uye_kart.\"uyeNO\" ='" + uyeID + "' AND uye_kart.cvv = @cvv " +
                        "AND uye_kart.skt = @skt AND uye_kart.adsoyad = @adsoyad AND uye_kart.kart_no = @kartno)", conn);
                    komut.Parameters.AddWithValue("@cvv", Convert.ToInt16(cvv.Text));
                    komut.Parameters.AddWithValue("@skt", Convert.ToInt16(skt.Text));
                    komut.Parameters.AddWithValue("@kartno", Convert.ToInt16(kartNo.Text));
                    komut.Parameters.AddWithValue("@adsoyad", (kartAS.Text));
                    NpgsqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        Int64 bakiye = Convert.ToInt64(tutar.Text);
                        var bakiyeEkle = new NpgsqlCommand("UPDATE uyeler SET bakiye = bakiye + '" + bakiye + "' WHERE uyeler.\"uyeID\" = '" + uyeID + "'", conn);
                        dr.Close();
                        bakiyeEkle.ExecuteNonQuery();
                        MessageBox.Show("Tutar başarılı bir şekilde yüklendi!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cvv.Clear();
                        skt.Clear();
                        kartNo.Clear();
                        kartAS.Clear();
                        tutar.Clear();
                        this.bakiyeGuncelle();
                    }
                    else
                    {
                        MessageBox.Show("Kart bilgileri bulunumadı!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Sayı değeri girilecek alanlara lütfen yazı girmeyiniz!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void iadeleriGuncelle()
        {
            var iadeler = new NpgsqlCommand("SELECT \"iadeID\", \"kitapAdi\", \"yazarAdiSoyadi\", \"yayinEviAdi\", \"dilAdi\", \"kategoriAdi\", \"iadeTarihi\" FROM \"kitapYazar\",kategori, dil, \"yayinEvi\", yazar" +
                ", kitap, iadeler WHERE (kategori. \"kategoriID\" = kitap . \"kategoriNO\" AND dil . \"dilID\" = kitap . \"dilNO\" AND \"yayinEvi\". \"yayinEviID\" = kitap . \"yayinEviNO\" AND " +
                "yazar . \"yazarID\" = \"kitapYazar\" . \"yazarNO\" AND kitap . \"kitapID\" = \"kitapYazar\" . \"kitapNO\" AND iadeler. \"kitapNO\" = kitap . \"kitapID\" AND" +
                " iadeler. \"uyeNO\" = '" + uyeID + "')", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(iadeler);
            DataTable dt = new DataTable();
            da.Fill(dt);
            uyeIadeler.DataSource = dt;
        }

        private void iadeEtBeni_Click(object sender, EventArgs e)
        {
            if (uyeKiralamari.CurrentRow.Cells[0] != null)
            {
                var silmeKomutu = new NpgsqlCommand("DELETE FROM kiralamalar WHERE \"kiralamaID\" = @id", conn);
                silmeKomutu.Parameters.AddWithValue("@id", uyeKiralamari.CurrentRow.Cells[0].Value);
                silmeKomutu.ExecuteNonQuery();
                MessageBox.Show("İade işlemi başarıyla gerçekleştirildi!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.kiralamalariGuncelle();
                this.iadeleriGuncelle();
                this.kitapListele();
            }
            else
            {
                MessageBox.Show("Lütfen iade edeceğiniz kitabı seçin!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uyeIadeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
