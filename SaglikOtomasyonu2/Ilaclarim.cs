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
    public partial class Ilaclarim : Form
    {
        public Ilaclarim()
        {
            InitializeComponent();
        }

        OleDbConnection ilacBaglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\KullaniciGiris.accdb");
        OleDbCommand ilacKomut;
        OleDbDataAdapter ilacAdaptor;
        DataTable ilacTablo = new DataTable();

        public string secilenkisitc;
        private void Ilaclarim_Load(object sender, EventArgs e)
        {
            
        }

        private void ilacButon_Click(object sender, EventArgs e)
        {
            ilacTablo.Clear();
            ilacBaglanti.Close();
            ilacBaglanti.Open();
            ilacKomut = new OleDbCommand("SELECT verilenilac,doz FROM kullanicilar WHERE tcno='" + secilenkisitc + "'", ilacBaglanti);
            ilacAdaptor = new OleDbDataAdapter(ilacKomut);
            ilacAdaptor.Fill(ilacTablo);
            ilacData.DataSource = ilacTablo;

            ilacBaglanti.Close();
        }
    }
}