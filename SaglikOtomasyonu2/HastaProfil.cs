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
    public partial class HastaProfil : Form
    {
        OleDbConnection profilBaglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\KullaniciGiris.accdb");
        OleDbCommand profilKomut;
        OleDbDataAdapter profilAdaptor;
        DataTable profilTablo = new DataTable();

        public HastaProfil()
        {
            InitializeComponent();
        }

        private void profilBilgisi()
        {
            profilBaglanti.Open();
            profilKomut = new OleDbCommand("SELECT tcno,ad,soyad,cinsiyet,dtarih,parola from kullanicilar where tcno = '@tcno' ", profilBaglanti);
            profilAdaptor = new OleDbDataAdapter(profilKomut);
            profilAdaptor.Fill(profilTablo);
            profilDataGridWiev.DataSource = profilTablo;
        }

        private void HastaProfil_Load(object sender, EventArgs e)
        {
            profilBilgisi();

            profilKomut = new OleDbCommand("SELECT * FROM kullanicilar", profilBaglanti); // WHERE tcno=@tcno AND ad=@ad AND soyad=@soyad AND cinsiyet=@cinsiyet AND dtarih=@dtarih AND parola=@parola"
            OleDbDataReader profilOku = profilKomut.ExecuteReader();

            while (profilOku.Read())
            {
                //profilDataGridWiev.
            }

            profilBaglanti.Close();
        }
    }
}
