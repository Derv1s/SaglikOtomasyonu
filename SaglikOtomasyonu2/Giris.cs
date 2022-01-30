using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SaglikOtomasyonu2
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        //Veritabanı dosya yolu ve provider nesnesinin belirlenmesi
        public readonly OleDbConnection baglantimUye = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\KullaniciGiris.accdb");
        //OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|KullaniciGiris.accdb");

        //Veri tabanında formlar arası kullanılacak değişkenler
        public static string tcno, ad, soyad, yetki;

        private void tcNo_Click(object sender, EventArgs e)
        {
            tcNo.Clear();
        }

        private void parola_Click(object sender, EventArgs e)
        {
            parola.Clear();
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            if (tcNo.Text=="" || parola.Text == "") 
                {
                    MessageBox.Show("TC No ve/veya Parola boş geçilemez!!");
                }
            else 
                {
                if (hak != 0) //eğer kullanıcının hala hakkı varsa anlamında
                {
                    baglantimUye.Open();  //veritabanını açma fonksiyonu
                    OleDbCommand selectsorgu = new OleDbCommand(string.Format("select tcno,ad, soyad,yetki from kullanicilar WHERE tcno='{0}' AND parola='{1}'", tcNo.Text, parola.Text), baglantimUye); //Format() fonksiyonu textbox içerisinde yer alan veriler 0 ve 1 numaralı alanlar içerisine aktarmaya yaramakta //kullanıcılar tablosundaki bütün veirleri çeken bir sorgu tanımladık.
                    OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();   //çekilen verilerin çalıştırılmaısnı sağlayan fonksiyon. Artık access tablosunun tamamının bir klonu bellekte.

                    while (kayitokuma.Read())    //Burada giriş ekranında yazdığımız bilgilerin bir karşılığı veritabanında varsa bu komut çalışır. 
                    {
                        if (doctorRadio.Checked == true)
                        {
                            if (kayitokuma["yetki"].ToString() == "Doktor")
                            {
                                durum = true;
                                tcno = kayitokuma.GetValue(0).ToString();
                                ad = kayitokuma.GetValue(1).ToString();
                                soyad = kayitokuma.GetValue(2).ToString();
                                yetki = kayitokuma.GetValue(3).ToString();
                                Doktor dr = new Doktor();
                                dr.tckimlikno = tcNo.Text;
                                dr.ShowDialog();
                                break;
                            }
                        }
                        if (hastaRadio.Checked == true)
                        {
                            if (kayitokuma["yetki"].ToString() == "Hasta")
                            {
                                durum = true;
                                tcno = kayitokuma.GetValue(0).ToString();
                                ad = kayitokuma.GetValue(1).ToString();
                                soyad = kayitokuma.GetValue(2).ToString();
                                yetki = kayitokuma.GetValue(3).ToString();
                                Hasta hst = new Hasta();
                                hst.hastatc = tcNo.Text;
                                hst.ShowDialog();
                                break;
                            }
                        }
                    }
                    if (durum == false)
                    hak--;
                    baglantimUye.Close();
                }
                }
                hakSayisi.Text = Convert.ToString(hak);
                if (hak == 0)
                {
                    girisButton.Enabled = false;
                    MessageBox.Show("Giriş Hakkı Kalmadı!");
                }
        }

        private void girisKayitol_Click(object sender, EventArgs e)
        {
            KayitOl kyt = new KayitOl();
            kyt.ShowDialog();
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sifreGoster_CheckedChanged(object sender, EventArgs e)
        {

            //işaretli değilse şifreyi normal şekilde gösterir
            if (sifreGoster.CheckState == CheckState.Unchecked)
            {
                parola.UseSystemPasswordChar = false;
                sifreGoster.Text = "GİZLE";
            }
            //işaretliyse şifreyi yıldız koyarak gizler
            else if (sifreGoster.CheckState == CheckState.Checked)
            {
                parola.UseSystemPasswordChar = true;
                sifreGoster.Text = "GÖSTER";
            }
        }

        private void tcNo_TextChanged_1(object sender, EventArgs e)
        {

        }

        int hak = 3;
        bool durum = false; //veri tabanından kullanıcı bilgilerine bakarken varsa true yoksa false değerini döndürecek.

        private void Giris_Load(object sender, EventArgs e)
        {
            this.Text = "Kullanıcı Girişi...";
            hakSayisi.Text = Convert.ToString(hak); //Burada hak değişkeni int iken stringe çeviriliyor.
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;  //Penceredeki simge durumuna küçült ve tam ekran yapma butonlarını deaktif eder.

            if (parola.Text=="Parola Giriniz")
            {
                parola.UseSystemPasswordChar = true;
            }
        }
    }
}
