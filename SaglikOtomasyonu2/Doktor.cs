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
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\KullaniciGiris.accdb");
        OleDbCommand komut; //daha sonra kullanmak üzere komut oluşturduk
        OleDbDataAdapter adptr;
        DataTable tablo = new DataTable(); //hasta listesi için yeni bir veri tablosu oluşturduk
        DataTable tablo2 = new DataTable(); //ilaç listesi için yeni bir veri tablosu oluşturduk

        public string tckimlikno;
        public void Doktor_Load(object sender, EventArgs e)
        {
            hastalistele();
            komut = new OleDbCommand("Select ilacasiadi from ilaclar", baglanti); //komutun ilaçlar tablosundaki ilacadi sütununa verilmesini sağladık.
            OleDbDataReader oku = komut.ExecuteReader(); //komutu oku adında veri okuyucuya tanımladık
            while (oku.Read()) //while döngüsüyle ilacadi sütunundaki tüm verileri tek tek ilaccombobox icine ekledik
            {
                ilaccombobox.Items.Add(oku["ilacasiadi"]);
            }
            baglanti.Close();
            ilacdozcombobox.Items.Add("Günde 1");
            ilacdozcombobox.Items.Add("Günde 2");
            ilacdozcombobox.Items.Add("Günde 3");
            ilacdozcombobox.Items.Add("Dört haftada 1");
            ilacdozcombobox.Items.Add("Altı haftada 1");
            ilacdozcombobox.Items.Add("Sekiz haftada 1");

        }

        private void hastagoster_Click(object sender, EventArgs e)
        {
            hastalistele(); //hastalistele kısmına yazdığımız kodları burada çağırdık ve kullandık
        }

        private void hastalistele()
        {
            tablo.Clear(); //göster butonuna her basıldığında mevcut kaydı silip üst üste yazmasını önleyecek
            baglanti.Close();
            baglanti.Open();
            komut = new OleDbCommand("select tcno,ad,soyad,randevusebebi,verilenilac,doz from kullanicilar where yetki = 'hasta' ", baglanti); //sorgunun bulunduğu kısım
            //alttaki kısım veriyi datagridview içinde göstermek için
            adptr = new OleDbDataAdapter(komut); //bilgiler için köprü görevi görür
            adptr.Fill(tablo); //adptr içindeki verileri tabloya doldurur
            hastabilgileri.DataSource = tablo; //hastabilgileri isimli datagridview içine tabloyu aktarır
        }

        private void ilaclistele()
        {
            tablo2.Clear();
            baglanti.Close();
            baglanti.Open();
            komut = new OleDbCommand("select ilacasiadi,kullanimalani,ilacdoz,tur from ilaclar", baglanti);
            adptr = new OleDbDataAdapter(komut); //bilgiler için köprü görevi görür
            adptr.Fill(tablo2); //adptr içindeki verileri tabloya doldurur
            ilaclarliste.DataSource = tablo2; //hastabilgileri isimli datagridview içine tabloyu aktarır
        }

        private void ilaclarigoster_Click(object sender, EventArgs e)
        {
            ilaclistele();  //ilaclistele kısmına yazdıklarımızı çağırdık
        }

        private void ilaclarigizle_Click(object sender, EventArgs e)
        {
            tablo2.Clear();    //tablo2 isimli verikaynağımızdaki verileri temizledik
            ilaclarliste.DataSource = ""; //datagridview öğesinin boş görünmesini sağladık
        }

        private void ilacyazbuton_Click(object sender, EventArgs e)
        {
            if (hastatc.TextLength != 11)
            {
                MessageBox.Show("Eksik veya Hatalı TC numarası girdiniz\nTC numarası 11 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                baglanti.Close();
                baglanti.Open();
                komut = new OleDbCommand("UPDATE kullanicilar SET verilenilac = '" + ilaccombobox.SelectedItem + "',doz = '" + ilacdozcombobox.SelectedItem +"'where tcno = '" + hastatc.Text + "'", baglanti); //tc no girdiğimiz hastaya verilecek ilacı seçmek için
                komut.ExecuteNonQuery();  //sorgu olmadan komutu çalıştırır
                baglanti.Close();
                hastalistele(); //hastalistele kısmına yazdığımız kodları çağırdık
                MessageBox.Show("Reçete yazma işleminiz başarıyla tamamlandı."); 
            }

        }
        
        //hastatc textboxu tıklandığında içinde yazan 'tc kimlik no' yazısının kaybolmasını sağlar
        private void hastatc_Enter(object sender, EventArgs e)
        {
            if (hastatc.Text == "T.C. Kimlik No")
            {
                hastatc.Text = "";
            }
        }
        //hastatc textboxu içi boş ise 'tc kimlik no' yazısının görünmesini sağlar
        private void hastatc_Leave(object sender, EventArgs e)
        {
            if (hastatc.Text == "")
            {
                hastatc.Text = "T.C. Kimlik No";
            }
        }

        private void hastatc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //hastatc isimli textbox içine sadece sayı değerleri girilmesini sağlar
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); 
        }

        private void anamenubuton_Click(object sender, EventArgs e)
        {
            this.Close();    
        }

        private void bilgibuton_Click(object sender, EventArgs e)
        {
            Doktorprofil drprof = new Doktorprofil();
            drprof.tcno = tckimlikno;
            drprof.ShowDialog();
        }

    }
}