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

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;

            vize = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox2.Text);

            ortalama = (vize * 0.4) + (final * 0.6);

            if (ortalama >= 60)
            {
                MessageBox.Show("Geçtiniz! Ortalama: " + ortalama.ToString("F2"));
            }
            else
            {
                MessageBox.Show("Kaldınız! Ortalama: " + ortalama.ToString("F2"));
            }
        }
    }
}
