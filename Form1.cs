using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operatorler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            int s1 = 140;
            int s2 = 20;
            // int s1 nesnesi tanımlandı.
            int toplam = s1 + s2;
            MessageBox.Show("Toplama işleminin sonucu : " + toplam);
        }

        private void btnCikartma_Click(object sender, EventArgs e)
        {
            int s1 = 140;
            int s2 = 20;

            MessageBox.Show("Çıkartma işleminin sonucu : " + (s1 - s2));
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            double s1 = 9.50;
            double s2 = 10;

            double s3 = s1 * s2;
            MessageBox.Show("Çarpma işleminin sonucu " + s3);

        }

        private void btnBölme_Click(object sender, EventArgs e)
        {
            long s1 = 950;
            long s2 = 10;

            long s3 = s1 / s2;
            MessageBox.Show("Bölme işleminin sonucu " + s3);
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int s1 = 5;
            int s2 = 2;

            int s3 = s1 % s2;

            MessageBox.Show("Mod işleminin sonucu " + s3);
        }
    }
}
