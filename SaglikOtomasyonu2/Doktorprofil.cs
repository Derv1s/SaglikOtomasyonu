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
    public partial class Doktorprofil : Form
    {
        public Doktorprofil()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\KullaniciGiris.accdb");
        OleDbCommand komut; //listeler için komut oluşturduk
        OleDbDataAdapter adptr2;
        DataTable doktorbilgilertablo = new DataTable();

        public string tcno;

        private void Doktorprofil_Load(object sender, EventArgs e)
        {
            docTcLabel.Text = tcno; 
            Doktorprofililistele();
        }

        private void Doktorprofililistele()
        {
            //Giris grs = new Giris();
            doktorbilgilertablo.Clear(); //göster butonuna her basıldığında mevcut kaydı silip üst üste yazmasını önleyecek
            baglanti.Close();
            baglanti.Open();
            komut = new OleDbCommand("select ad,soyad,tcno,parola,dtarih from kullanicilar where tcno = '" +tcno+"'", baglanti); //sorgunun bulunduğu kısım
            adptr2 = new OleDbDataAdapter(komut); //bilgiler için köprü görevi görür
            adptr2.Fill(doktorbilgilertablo); //adptr içindeki verileri tabloya doldurur
            docBilgiler.DataSource = doktorbilgilertablo;
        }

        private void geridon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
