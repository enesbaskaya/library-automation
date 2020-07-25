using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Npgsql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class AdminPanel : Form
    {

        private string admin;
        private NpgsqlConnection conn;
        private AnaPanel panel;
        public AdminPanel(object v, NpgsqlConnection conn, AnaPanel panel)
        {
            InitializeComponent();
            admin = (string)v;
            this.conn = conn;
            this.panel = panel;
            kAdiLabel.Text = "Hoşgeldiniz sayın, " + admin + "!";

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

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            this.listeGuncelle();
        }
        private void listeGuncelle()
        {
            this.kitapListele();
            this.uyeListele();
            this.kategoriListele();
            this.yazarlariListele();
            this.unvanlariListele();
            this.dilleriListele();
            this.bolumleriListele();
            this.dilListele();
            this.kategorileriListele();
            this.yayinEviListele();
            this.yayinEvleriListele();
            this.iadeleriListele();
            this.satislariListele();
            this.kiralamalariListele();
            this.yazarListele();
        }

        private void iadeleriListele()
        {
            //Kitap
            var iadeler = new NpgsqlCommand("SELECT * FROM iadeler ORDER BY \"iadeID\"", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(iadeler);
            DataTable dt = new DataTable();
            da.Fill(dt);
            iadelerAdmin.DataSource = dt;
        }

        private void satislariListele()
        {
            var satinalmalar = new NpgsqlCommand("SELECT \"adSoyad\",\"kitapAdi\",\"dilAdi\",\"kategoriAdi\",\"yayinEviAdi\"," +
                  "\"yazarAdiSoyadi\" FROM kitap,dil,kategori,\"satinAlmalar\",\"kitapYazar\",\"yayinEvi\",yazar, uyeler WHERE \"dil\" . \"dilID\" = \"kitap\".\"dilNO\"" +
                  "AND \"kategori\".\"kategoriID\" = \"kitap\" . \"kategoriNO\" AND \"yayinEvi\" . \"yayinEviID\" = \"kitap\" . \"yayinEviNO\" AND" +
                  "(\"yazar\". \"yazarID\" = \"kitapYazar\".\"yazarNO\" AND \"kitap\" . \"kitapID\" = \"kitapYazar\" . \"kitapNO\" AND \"satinAlmalar\".\"kitapNO\" = kitap.\"kitapID\" AND uyeler. \"uyeID\" = \"satinAlmalar\". \"uyeNO\")", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(satinalmalar);
            DataTable dt = new DataTable();
            da.Fill(dt);
            satislarAdmin.DataSource = dt;
        }

        private void kiralamalariListele()
        {
            var kiralamalar = new NpgsqlCommand("SELECT \"adSoyad\",\"kitapAdi\",\"dilAdi\",\"kategoriAdi\",\"yayinEviAdi\"," +
      "\"yazarAdiSoyadi\" FROM kitap,dil,kategori,kiralamalar,\"kitapYazar\",\"yayinEvi\",yazar, uyeler WHERE \"dil\" . \"dilID\" = \"kitap\".\"dilNO\"" +
      "AND \"kategori\".\"kategoriID\" = \"kitap\" . \"kategoriNO\" AND \"yayinEvi\" . \"yayinEviID\" = \"kitap\" . \"yayinEviNO\" AND" +
      "(\"yazar\". \"yazarID\" = \"kitapYazar\".\"yazarNO\" AND \"kitap\" . \"kitapID\" = \"kitapYazar\" . \"kitapNO\" AND kiralamalar.\"kitapNO\" = kitap.\"kitapID\" AND uyeler. \"uyeID\" = kiralamalar. \"uyeNO\")", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(kiralamalar);
            DataTable dt = new DataTable();
            da.Fill(dt);
            kiralamalarAdmin.DataSource = dt;
        }

        private void kitapListele()
        {
            //Kitap
            var kitap = new NpgsqlCommand("SELECT \"kitapID\",\"kitapAdi\",\"ISBN\",\"adet\",\"dilAdi\",\"kategoriAdi\",\"yayinEviAdi\"," +
                "\"fiyat\", \"yazarAdiSoyadi\" FROM kitap,dil,kategori,\"kitapYazar\",\"yayinEvi\",yazar WHERE \"dil\" . \"dilID\" = \"kitap\".\"dilNO\"" +
                "AND \"kategori\".\"kategoriID\" = \"kitap\" . \"kategoriNO\" AND \"yayinEvi\" . \"yayinEviID\" = \"kitap\" . \"yayinEviNO\" AND" +
                "(\"yazar\". \"yazarID\" = \"kitapYazar\".\"yazarNO\" AND \"kitap\" . \"kitapID\" = \"kitapYazar\" . \"kitapNO\")   ORDER BY \"kitapID\"", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(kitap);
            DataTable dt = new DataTable();
            da.Fill(dt);
            kitaplar.DataSource = dt;
        }

        private void uyeListele()
        {
            // Uye
            var uye = new NpgsqlCommand("SELECT \"uyeID\", \"adSoyad\", \"adres\", \"eMail\", \"GSM\", \"yetki\"," +
                " \"sifre\", \"unvanAdi\", \"bolumAdi\" FROM uyeler, unvanlar, bolumler WHERE \"uyeler\".\"bolumNo\"" +
                " = \"bolumler\". \"bolumID\" AND \"uyeler\".\"unvanNo\" = \"unvanlar\".\"unvanID\"", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(uye);
            DataTable dt = new DataTable();
            da.Fill(dt);
            uyeler.DataSource = dt;
        }

        private void kategoriListele()
        {      // Kategori
            var kategori = new NpgsqlCommand("SELECT * FROM kategori ORDER BY \"kategoriID\"", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(kategori);
            DataTable dt = new DataTable();
            da.Fill(dt);
            kategoriler.DataSource = dt;
        }

        private void dilleriListele()
        {            // Diller
            var dillerx = new NpgsqlCommand("SELECT * FROM dil ORDER BY \"dilID\"", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(dillerx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            diller.DataSource = dt;
        }

        private void yazarlariListele()
        {

            // Yazarlar
            var yazarlarx = new NpgsqlCommand("SELECT * FROM yazar ORDER BY \"yazarID\"", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(yazarlarx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            yazarlar.DataSource = dt;

        }

        private void bolumleriListele()
        {
            // Bolumler
            var bolumlerx = new NpgsqlCommand("SELECT * FROM bolumler ORDER BY \"bolumID\"", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(bolumlerx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bolumler.DataSource = dt;

        }

        private void yayinEvleriListele()
        {
            // Yayin Evleri
            var yEvleri = new NpgsqlCommand("SELECT * FROM \"yayinEvi\" ORDER BY \"yayinEviID\"", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(yEvleri);
            DataTable dt = new DataTable();
            da.Fill(dt);
            yayinEvleriListesi.DataSource = dt;

        }

        private void unvanlariListele()
        {
            // Unvanlar
            var unvanlarx = new NpgsqlCommand("SELECT * FROM unvanlar ORDER BY \"unvanID\"", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(unvanlarx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            unvanlar.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            panel.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var unvanlarE = new NpgsqlCommand("INSERT INTO unvanlar (\"unvanAdi\") VALUES (@adi)", conn);
            unvanlarE.Parameters.AddWithValue("@adi", ekleUnvanTB.Text);
            unvanlarE.ExecuteNonQuery();
            this.unvanlariListele();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            var unvanlarG = new NpgsqlCommand("UPDATE unvanlar SET \"unvanAdi\" = @adi WHERE  \"unvanID\"=@id", conn);
            unvanlarG.Parameters.AddWithValue("@id", unvanlar.CurrentRow.Cells[0].Value);
            unvanlarG.Parameters.AddWithValue("@adi", unvanlar.CurrentRow.Cells[1].Value);
            unvanlarG.ExecuteNonQuery();
            this.unvanlariListele();

        }

        private void sil_Click(object sender, EventArgs e)
        {
            var unvanlarS = new NpgsqlCommand("DELETE  FROM unvanlar WHERE \"unvanID\" = @id ", conn);
            unvanlarS.Parameters.AddWithValue("@id", unvanlar.CurrentRow.Cells[0].Value);
            unvanlarS.ExecuteNonQuery();
            this.unvanlariListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var bolumE = new NpgsqlCommand("INSERT INTO bolumler (\"bolumAdi\") VALUES (@adi)", conn);
            bolumE.Parameters.AddWithValue("@adi", bolumAdi.Text);
            bolumE.ExecuteNonQuery();
            this.bolumleriListele();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var bolumG = new NpgsqlCommand("UPDATE bolumler SET \"bolumAdi\" = @adi WHERE  \"bolumID\"=@id", conn);
            bolumG.Parameters.AddWithValue("@id", bolumler.CurrentRow.Cells[0].Value);
            bolumG.Parameters.AddWithValue("@adi", bolumler.CurrentRow.Cells[1].Value);
            bolumG.ExecuteNonQuery();
            this.bolumleriListele();

        }

        private void bolumSil_Click(object sender, EventArgs e)
        {
            var bolumS = new NpgsqlCommand("DELETE  FROM bolumler WHERE \"bolumID\" = @id ", conn);
            bolumS.Parameters.AddWithValue("@id", bolumler.CurrentRow.Cells[0].Value);
            bolumS.ExecuteNonQuery();
            this.bolumleriListele();


        }

        private void yazarEkle_Click(object sender, EventArgs e)
        {
            var yazarE = new NpgsqlCommand("INSERT INTO yazar (\"yazarAdiSoyadi\") VALUES (@adi)", conn);
            yazarE.Parameters.AddWithValue("@adi", yazarAdi.Text);
            yazarE.ExecuteNonQuery();
            this.yazarlariListele();
            this.yazarListele();
        }

        private void yazarGuncelle_Click(object sender, EventArgs e)
        {
            var yazarG = new NpgsqlCommand("UPDATE yazar SET \"yazarAdiSoyadi\" = @adi WHERE  \"yazarID\"=@id", conn);
            yazarG.Parameters.AddWithValue("@id", yazarlar.CurrentRow.Cells[0].Value);
            yazarG.Parameters.AddWithValue("@adi", yazarlar.CurrentRow.Cells[1].Value);
            yazarG.ExecuteNonQuery();
            this.yazarlariListele();
            this.yazarListele();
        }

        private void yazarSil_Click(object sender, EventArgs e)
        {
            var yazarS = new NpgsqlCommand("DELETE  FROM yazar WHERE \"yazarID\" = @id ", conn);
            yazarS.Parameters.AddWithValue("@id", yazarlar.CurrentRow.Cells[0].Value);
            yazarS.ExecuteNonQuery();
            this.yazarlariListele();
            this.yazarListele();

        }

        private void dilEkle_Click(object sender, EventArgs e)
        {
            var dilE = new NpgsqlCommand("INSERT INTO dil (\"dilAdi\") VALUES (@adi)", conn);
            dilE.Parameters.AddWithValue("@adi", dilAdi.Text);
            dilE.ExecuteNonQuery();
            this.dilleriListele();
            this.dilListele();
        }

        private void dilGuncelle_Click(object sender, EventArgs e)
        {
            var dilG = new NpgsqlCommand("UPDATE dil SET \"dilAdi\" = @adi WHERE  \"dilID\"=@id", conn);
            dilG.Parameters.AddWithValue("@id", diller.CurrentRow.Cells[0].Value);
            dilG.Parameters.AddWithValue("@adi", diller.CurrentRow.Cells[1].Value);
            dilG.ExecuteNonQuery();
            this.dilleriListele();
            this.dilListele();
        }

        private void dilSil_Click(object sender, EventArgs e)
        {
            var dilS = new NpgsqlCommand("DELETE  FROM dil WHERE \"dilID\" = @id ", conn);
            dilS.Parameters.AddWithValue("@id", diller.CurrentRow.Cells[0].Value);
            dilS.ExecuteNonQuery();
            this.dilleriListele();
            this.dilListele();
        }

        private void kEkle_Click(object sender, EventArgs e)
        {
            var katE = new NpgsqlCommand("INSERT INTO kategori (\"kategoriAdi\") VALUES (@adi)", conn);
            katE.Parameters.AddWithValue("@adi", kategoriAdi.Text);
            katE.ExecuteNonQuery();
            this.kategoriListele();
            this.kategorileriListele();
        }

        private void kGuncelle_Click(object sender, EventArgs e)
        {
            var katG = new NpgsqlCommand("UPDATE kategori SET \"kategoriAdi\" = @adi WHERE  \"kategoriID\"=@id", conn);
            katG.Parameters.AddWithValue("@id", kategoriler.CurrentRow.Cells[0].Value);
            katG.Parameters.AddWithValue("@adi", kategoriler.CurrentRow.Cells[1].Value);
            katG.ExecuteNonQuery();
            this.kategoriListele();
            this.kategorileriListele();
        }

        private void kSil_Click(object sender, EventArgs e)
        {
            var katS = new NpgsqlCommand("DELETE  FROM kategori WHERE \"kategoriID\" = @id ", conn);
            katS.Parameters.AddWithValue("@id", kategoriler.CurrentRow.Cells[0].Value);
            katS.ExecuteNonQuery();
            this.kategoriListele();
            this.kategorileriListele();
        }

        private void uyeSil_Click(object sender, EventArgs e)
        {
            var uyeS = new NpgsqlCommand("DELETE  FROM uyeler WHERE \"uyeID\" = @id ", conn);
            uyeS.Parameters.AddWithValue("@id", uyeler.CurrentRow.Cells[0].Value);
            uyeS.ExecuteNonQuery();
            this.uyeListele();
        }

        private void yEviEkle_Click(object sender, EventArgs e)
        {
            var yEviE = new NpgsqlCommand("INSERT INTO \"yayinEvi\" (\"yayinEviAdi\") VALUES (@adi)", conn);
            yEviE.Parameters.AddWithValue("@adi", yayinEviAdi.Text);
            yEviE.ExecuteNonQuery();
            this.yayinEvleriListele();
            this.yayinEviListele();
        }

        private void yEviGuncelle_Click(object sender, EventArgs e)
        {
            var yEviG = new NpgsqlCommand("UPDATE \"yayinEvi\" SET \"yayinEviAdi\" = @adi WHERE  \"yayinEviID\"=@id", conn);
            yEviG.Parameters.AddWithValue("@id", yayinEvleriListesi.CurrentRow.Cells[0].Value);
            yEviG.Parameters.AddWithValue("@adi", yayinEvleriListesi.CurrentRow.Cells[1].Value);
            yEviG.ExecuteNonQuery();
            this.yayinEvleriListele();
            this.yayinEviListele();
        }


        private void yEviSil_Click(object sender, EventArgs e)
        {
            var yEviSil = new NpgsqlCommand("DELETE  FROM \"yayinEvi\" WHERE \"yayinEviID\" = @id ", conn);
            yEviSil.Parameters.AddWithValue("@id", yayinEvleriListesi.CurrentRow.Cells[0].Value);
            yEviSil.ExecuteNonQuery();
            this.yayinEvleriListele();
            this.yayinEviListele();
        }

        private void uyeGuncelle_Click(object sender, EventArgs e)
        {
            var uyeG = new NpgsqlCommand("UPDATE uyeler SET \"adSoyad\" = @adi,  " +
                "\"adres\"=@adres,  \"eMail\"=@mail,\"GSM\"=@gsm, \"unvanNo\"=@unvan, \"bolumNo\"=@bolum" +
                ",\"yetki\"=@yetki,\"sifre\"=@sifre WHERE  \"uyeID\"=@id", conn);
            var uyeUnvan = new NpgsqlCommand("SELECT \"unvanID\" FROM unvanlar, uyeler WHERE" +
                " \"unvanlar\" . \"unvanID\" = \"uyeler\" . \"unvanNo\"", conn);
            NpgsqlDataReader dr = uyeUnvan.ExecuteReader();
            uyeG.Parameters.AddWithValue("@id", uyeler.CurrentRow.Cells[0].Value);
            uyeG.Parameters.AddWithValue("@adi", uyeler.CurrentRow.Cells[1].Value);
            uyeG.Parameters.AddWithValue("@adres", uyeler.CurrentRow.Cells[2].Value);
            uyeG.Parameters.AddWithValue("@mail", uyeler.CurrentRow.Cells[3].Value);
            uyeG.Parameters.AddWithValue("@gsm", uyeler.CurrentRow.Cells[4].Value);
            uyeG.Parameters.AddWithValue("@yetki", uyeler.CurrentRow.Cells[5].Value);
            uyeG.Parameters.AddWithValue("@sifre", uyeler.CurrentRow.Cells[6].Value);
            if (dr.Read())
                uyeG.Parameters.AddWithValue("@unvan", dr[0]);
            dr.Close();
            var uyeBOlum = new NpgsqlCommand("SELECT \"bolumID\" FROM bolumler, uyeler WHERE" +
                " \"uyeler\" . \"bolumNo\" = \"bolumler\" . \"bolumID\"", conn);
            NpgsqlDataReader drx = uyeBOlum.ExecuteReader();
            if (drx.Read())
                uyeG.Parameters.AddWithValue("@bolum", drx[0]);
            drx.Close();
            uyeG.ExecuteNonQuery();
            this.uyeListele();
        }

        private void yayinEviListele()
        {
            yevi.Items.Clear();
            var yayinEvleri = new NpgsqlCommand("SELECT * FROM \"yayinEvi\" ORDER BY \"yayinEviAdi\"", conn);
            NpgsqlDataReader dr = yayinEvleri.ExecuteReader();
            while (dr.Read())
            {
                yevi.Items.Add(dr[1]);
            }
            yevi.SelectedIndex = 0;
            dr.Close();
        }

        private void dilListele()
        {
            dil.Items.Clear();
            var diller = new NpgsqlCommand("SELECT * FROM dil ORDER BY \"dilAdi\"", conn);
            NpgsqlDataReader dr = diller.ExecuteReader();
            while (dr.Read())
            {
                dil.Items.Add(dr[1]);
            }
            dil.SelectedIndex = 0;
            dr.Close();
        }

        private void yazarListele()
        {
            yazar.Items.Clear();
            var yazarlar = new NpgsqlCommand("SELECT * FROM yazar ORDER BY \"yazarID\"", conn);
            NpgsqlDataReader dr = yazarlar.ExecuteReader();
            while (dr.Read())
            {
                yazar.Items.Add(dr[1]);
            }
            yazar.SelectedIndex = 0;
            dr.Close();
        }

        private void kategorileriListele()
        {
            kategori.Items.Clear();
            var katlar = new NpgsqlCommand("SELECT * FROM kategori ORDER BY \"kategoriAdi\"", conn);
            NpgsqlDataReader dr = katlar.ExecuteReader();
            while (dr.Read())
            {
                kategori.Items.Add(dr[1]);
            }
            kategori.SelectedIndex = 0;
            dr.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (kitapAdi.Text.Length > 0 && adet.Text.Length > 0 && ISBN.Text.Length > 0 && basimYil.Text.Length > 0 && fiyatTB.Text.Length > 0)
            {
                if (this.isInt(adet.Text) && this.isInt(fiyatTB.Text))
                {
                    var kitapEklemeKomutu = new NpgsqlCommand("INSERT INTO kitap (\"fiyat\", \"kategoriNO\", \"dilNO\", \"yayinEviNO\", \"ISBN\", \"adet\", \"girisTarihi\", \"basimYili\",\"kitapAdi\")" +
                    " VALUES (@fiyat, @ktg, @dil, @yayin, @isbn, @adet, @gTarih, @bTarih, @kitapAdi)", conn);
                    kitapEklemeKomutu.Parameters.AddWithValue("@kitapAdi", kitapAdi.Text);
                    DateTime result;
                    DateTime.TryParse(basimYil.Text, out result);
                    kitapEklemeKomutu.Parameters.AddWithValue("@bTarih", result);
                    DateTime time = DateTime.Now;
                    kitapEklemeKomutu.Parameters.AddWithValue("@gTarih", time);
                    kitapEklemeKomutu.Parameters.AddWithValue("@fiyat", Convert.ToInt64(fiyatTB.Text));
                    kitapEklemeKomutu.Parameters.AddWithValue("@adet", Convert.ToInt64(adet.Text));
                    kitapEklemeKomutu.Parameters.AddWithValue("@isbn", ISBN.Text);


                    // Yayin evi guncelle.
                    String yayinEviSecilen = (String)yevi.SelectedItem;
                    var yayinEviSecilenID = new NpgsqlCommand("SELECT \"yayinEviID\" FROM \"yayinEvi\" WHERE" +
                       " (\"yayinEviAdi\" = '" + yayinEviSecilen + "')", conn);
                    NpgsqlDataReader dryevi = yayinEviSecilenID.ExecuteReader();
                    if (dryevi.Read())
                    {
                        kitapEklemeKomutu.Parameters.AddWithValue("@yayin", dryevi[0]);
                    }
                    else
                    {
                        MessageBox.Show("Hata! Böyle bir yayın evi bulunamadı!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dryevi.Close();
                        return;
                    }
                    dryevi.Close();


                    // dil guncelle.
                    String dilSecilen = (String)dil.SelectedItem;
                    var dilSecilenID = new NpgsqlCommand("SELECT \"dilID\" FROM dil WHERE" +
                       " (\"dilAdi\" = '" + dilSecilen + "')", conn);
                    NpgsqlDataReader drdil = dilSecilenID.ExecuteReader();
                    if (drdil.Read())
                    {
                        kitapEklemeKomutu.Parameters.AddWithValue("@dil", drdil[0]);
                    }
                    else
                    {
                        MessageBox.Show("Hata! Böyle bir dil adı bulunamadı!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        drdil.Close();
                        return;
                    }
                    drdil.Close();


                    // kategori guncelle.
                    String kateSecilen = (String)kategori.SelectedItem;
                    var kateSecilenID = new NpgsqlCommand("SELECT \"kategoriID\" FROM kategori WHERE" +
                       " (\"kategoriAdi\" = '" + kateSecilen + "')", conn);
                    NpgsqlDataReader drkat = kateSecilenID.ExecuteReader();
                    if (drkat.Read())
                    {
                        kitapEklemeKomutu.Parameters.AddWithValue("@ktg", drkat[0]);
                    }
                    else
                    {
                        MessageBox.Show("Hata! Böyle bir kategori bulunamadı!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        drkat.Close();
                        return;
                    }
                    drkat.Close();

                    kitapEklemeKomutu.ExecuteNonQuery();
                    var kitapYazarEkleKomutu = new NpgsqlCommand("INSERT INTO \"kitapYazar\" (\"kitapNO\", \"yazarNO\") VALUES " +
                       "(@kitap_no, @yazar_no)", conn);
                    var sonID = new NpgsqlCommand("SELECT MAX(\"kitapID\") FROM kitap", conn);
                    NpgsqlDataReader dr = sonID.ExecuteReader();
                    if (dr.Read())
                        kitapYazarEkleKomutu.Parameters.AddWithValue("@kitap_no", dr[0]);
                    dr.Close();

                    var yazarID = new NpgsqlCommand("SELECT \"yazarID\" FROM yazar WHERE" +
                        " \"yazarAdiSoyadi\" = '" + yazar.SelectedItem.ToString() + "'", conn);
                    NpgsqlDataReader drx = yazarID.ExecuteReader();
                    if (drx.Read())
                        kitapYazarEkleKomutu.Parameters.AddWithValue("@yazar_no", drx[0]);
                    drx.Close();
                    kitapYazarEkleKomutu.ExecuteNonQuery();
                    this.kitapListele();
                    kitapAdi.Clear();
                    ISBN.Clear();
                    adet.Clear();
                    basimYil.Clear();
                }
                else
                {
                    MessageBox.Show("Adet ve fiyatı sadece sayılar ile ifade edebilirsiniz!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Hata! Boş alan bırakmayın!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (yeniAdet.Text.Length > 0 && yeniFiyatTB.Text.Length > 0)
            {
                if (this.isInt(adet.Text) && this.isInt(fiyatTB.Text))
                {
                    var guncelleKitap = new NpgsqlCommand("UPDATE kitap SET \"adet\" = @adet, \"fiyat\" = @fiyat WHERE  \"kitapID\"=@kitap_id", conn);
                    guncelleKitap.Parameters.AddWithValue("@adet", Convert.ToInt64(yeniAdet.Text));
                    guncelleKitap.Parameters.AddWithValue("@fiyat", Convert.ToInt64(yeniFiyatTB.Text));
                    guncelleKitap.Parameters.AddWithValue("@kitap_id", kitaplar.CurrentRow.Cells[0].Value);
                    guncelleKitap.ExecuteNonQuery();
                    this.kitapListele();
                }
                else
                {
                    MessageBox.Show("Adet ve fiyatı sadece sayılar ile ifade edebilirsiniz!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen fiyat ve adet alanını boş bırakmayınız!", "SAÜ Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var kitapS = new NpgsqlCommand("DELETE  FROM kitap WHERE \"kitapID\" = @id ", conn);
            kitapS.Parameters.AddWithValue("@id", kitaplar.CurrentRow.Cells[0].Value);
            kitapS.ExecuteNonQuery();
            this.kitapListele();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            conn.Close();
        }

    }
}
