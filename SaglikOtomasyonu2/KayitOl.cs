using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // access veritabı ile işlem yapabilmek için kütüphaneyi ekledik


namespace SaglikOtomasyonu2
{
    public partial class KayitOl : Form
    {   // veritabanı bağlantısını yapıyoruz
        OleDbConnection kayitBaglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\KullaniciGiris.accdb");
        OleDbCommand kayitKomut;
        public KayitOl()
        {
            InitializeComponent();
        }

        private void kayitAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // klavyeden girilen karakterin harf, silme tuşu veya boşluk tuşu olup olmadığı kontrol ediyoruz
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void kayitButtonKayıt_Click(object sender, EventArgs e)
        {
            string cins;
            if (kayitErkek.Checked == true)
            {
                cins = "Erkek";
            }
            else
            {
                cins = "Kadın";
            }
            // objelerimizin boş olup olmadığını kontrol ediyoruz
            if (kayitAd.Text == "" || kayitSoyAd.Text == "" || kayitTC.Text == "" || kayitSifre.Text == "" || kayitSifreTekrar.Text == "")
            {
                MessageBox.Show("Boş bıraktığınız alanlar var! \nLütfen bütün alanları doldurduğunuzdan emin olun!");
            }
            // cinsiyet seçimini kontrol ediyoruz
            else if (kayitErkek.Checked == false && kayitKadın.Checked == false)
            {
                MessageBox.Show("Lütfen cinsiyet seçimi yapınız!");
            }
            // girilen şifrelerin aynı olup olmadığını kontrol ediyoruz
            else if (kayitSifre.Text != kayitSifreTekrar.Text)
            {
                MessageBox.Show("Girilen şifreler aynı değil! \nLütfen iki kutuya da aynı şifreyi giriniz!");
            }
            // şifre uzunluğunun 6 karakterden uzun olup olmadığını kontrol ediyoruz
            else if (kayitSifre.Text.Length < 6)
            {
                MessageBox.Show("Lütfen en az 6 haneli bir şifre girin");
            }
            else
            {
                string dtarih = KayitDogumTarih.Value.ToShortDateString();

                // veritabanı bağlantısında hata olursa ekrana hata mesajı gösterecek
                try
                {
                kayitBaglanti.Open();
                kayitKomut = new OleDbCommand("INSERT INTO kullanicilar (ad,soyad,tcno,yetki,cinsiyet,parola, dtarih) values('" + kayitAd.Text + "','" + kayitSoyAd.Text + "','" + kayitTC.Text + "','" + "Hasta" + "','" + cins + "','" + kayitSifre.Text + "','" + dtarih + "')", kayitBaglanti);
                kayitKomut.ExecuteNonQuery();
                kayitBaglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Gerçekleştirildi!");
                }
                catch (Exception hata)
                {
                    kayitBaglanti.Close();
                    MessageBox.Show("Veritabanı bağlantı sırasında bir hata oluştu! Lütfen yetkili birine başvurunuz! \nhata: " + hata.ToString());
                }

            }

        }

        private void kayitGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KayitOl_KeyUp(object sender, KeyEventArgs e)
        {
            // ESC tuşuna basıldığında formu kapatır
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {

        }
    }
}
