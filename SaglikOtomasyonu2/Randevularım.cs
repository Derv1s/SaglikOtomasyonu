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
    public partial class Randevularım : Form
    {
        public Randevularım()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\KullaniciGiris.accdb");
        OleDbCommand komut; //listeler için komut oluşturduk
        OleDbDataAdapter adptr3;
        DataTable randevubilgitablo = new DataTable();

        public string tckimlik;

        private void Randevularım_Load(object sender, EventArgs e)
        {
            randevulistele();
        }

        private void randevulistele()
        {
            randevubilgitablo.Clear(); //göster butonuna her basıldığında mevcut kaydı silip üst üste yazmasını önleyecek
            baglanti.Close();
            baglanti.Open();
            komut = new OleDbCommand("select tcno,ad,soyad,randevusebebi,randevutarih,randevusaat from kullanicilar where tcno = '" + tckimlik + "'", baglanti); //sorgunun bulunduğu kısım
            adptr3 = new OleDbDataAdapter(komut); //bilgiler için köprü görevi görür
            adptr3.Fill(randevubilgitablo); //adptr içindeki verileri tabloya doldurur
            dataGridView1.DataSource = randevubilgitablo;
        }

        private void geributon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
