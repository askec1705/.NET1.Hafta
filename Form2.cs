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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            // Dışarıdan alınan iki sayının toplamı ile farkinin birbirine bölümünden kalan kaçtır?

            int s1 = int.Parse(txtSayi1.Text);
            int s2 = int.Parse(txtSayi2.Text);

            int toplam = s1 + s2;
            int fark = s1 - s2;

            int sonuc = toplam / fark;

            MessageBox.Show("İşlem Sonucu " + sonuc);
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            // Dışarıdan gelen bir sayının 30 eksiğinin 23 faslasının 2 ye bölümünden kalanın karesi kaçtır?
            int s1 = int.Parse(txtSayi1.Text);

            s1 = (((s1 - 30) + 23) % 2) * (((s1 - 30) + 23) % 2);

            MessageBox.Show("İşleminizin Sonucu : " + s1);
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //Vize notu'nun % 30'u, final notu'nun % 70'ini alıp öğrencinin not ortalamasini cikartan bir uygulama yaziniz... DİKKAT => Notlar ondalikli olabilir.

            double vize = double.Parse(txtSayi1.Text);
            double final = double.Parse(txtSayi2.Text);

            if (vize > 100 || final > 100 || vize < 0 || final < 0)
            {
                MessageBox.Show("HATALI NOT GİRDİNİZ");
            }
            else
            {
                double sonuc = (vize * 0.30) + (final * 0.70);

                MessageBox.Show("Not ortalamanız : " + sonuc);
            }
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            // Dışarıdan kullanıcı adını ve soyadını ayrı ayrı olarak alnız ve  adi.soyadi@hotmail.com şeklinde mail adresi oluşturup kullanıcıya gösteriniz.

            string adi = txtSayi1.Text;
            string soyadi = txtSayi2.Text;

            string mail = adi + "." + soyadi + "@hotmail.com";

            MessageBox.Show("Mail Adresiniz : " + mail);
        }
    }
}
