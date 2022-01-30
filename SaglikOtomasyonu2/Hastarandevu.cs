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
    public partial class Hastarandevu : Form
    {
        public Hastarandevu()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\KullaniciGiris.accdb");
        OleDbCommand komut;

        public string yazi;

        private void Hastarandevu_Load(object sender, EventArgs e)
        {
            randevusebep.Items.Add("Aşı Randevusu");
            randevusebep.Items.Add("Akciğer hastalıkları");
            randevusebep.Items.Add("Alerji hastalıkları");
            randevusebep.Items.Add("Kas rahatsızlıkları");
            randevusebep.Items.Add("Psikoloji");
            randevusebep.Items.Add("Kulak burun boğaz");
            randevusaatcombo.Items.Add("08.00-10.00");
            randevusaatcombo.Items.Add("10.00-12.00");
            randevusaatcombo.Items.Add("12.00.14.00");
            randevusaatcombo.Items.Add("14.00-16.00");
            randevusaatcombo.Items.Add("16.00-18.00");
            randevusaatcombo.Items.Add("18.00-20.00");
            Giris grs = new Giris();
            tclabel.Text = yazi + " TC numaralı kişi için randevu alma";
            
        }

        private void randevusaatsec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void randevualbuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new OleDbCommand("UPDATE kullanicilar SET randevutarih = '" + randevutarihsec.Value.ToShortDateString() + "', randevusaat = '"+randevusaatcombo.SelectedItem +"',randevusebebi = '" +randevusebep.SelectedItem+ "'where tcno = '" +yazi + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            if (randevusebep.Text == "" || randevusaatcombo.SelectedItem == "") //randevu sebep ve saatinin boş olup olmadığını kontrol eder
            {
                MessageBox.Show("Randevu sebebi ve randevu saati boş bırakılmamalıdır.");
            }
            else
            {
                MessageBox.Show("Randevunuz Başarıyla alındı");
            }
        }

        private void geridonbuton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
