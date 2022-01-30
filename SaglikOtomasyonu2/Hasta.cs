using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaglikOtomasyonu2
{
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }

        public string hastatc;

        private void Hasta_Load(object sender, EventArgs e)
        {
     
        }

        private void yuvarlakResimKutusu1_Click(object sender, EventArgs e)
        {
            Doktorprofil drprof = new Doktorprofil();
            drprof.tcno = hastatc;
            drprof.ShowDialog();
            
            //HastaProfil hstprfl = new HastaProfil();
            //hstprfl.ShowDialog();
        }

        private void yuvarlakResimKutusu3_Click(object sender, EventArgs e)
        {
            Hastarandevu hstrndv = new Hastarandevu();
            hstrndv.yazi = hastatc;
            hstrndv.ShowDialog();
        }

        private void yuvarlakResimKutusu2_Click(object sender, EventArgs e)
        {
            Randevularım rnd = new Randevularım();
            rnd.tckimlik = hastatc;
            rnd.ShowDialog();
        }

        private void yuvarlakResimKutusu5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yuvarlakResimKutusu4_Click(object sender, EventArgs e)
        {
            Ilaclarim ilacfrm = new Ilaclarim();
            ilacfrm.secilenkisitc = hastatc;
            ilacfrm.ShowDialog();
        }
    }
}
