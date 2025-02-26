using System;
using System.Windows.Forms;

namespace NotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtVize.Text, out double vize) && double.TryParse(txtFinal.Text, out double finalNotu))
            {
                double ortalama = (vize * 0.4) + (finalNotu * 0.6);
                if (ortalama >= 60)
                {
                    lblSonuc.Text = $"Ortalama: {ortalama:F2} - Geçtiniz!";
                    lblSonuc.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblSonuc.Text = $"Ortalama: {ortalama:F2} - Kaldınız.";
                    lblSonuc.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli sayılar girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
