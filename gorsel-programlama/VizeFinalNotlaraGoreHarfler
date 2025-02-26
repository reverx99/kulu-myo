using System;
using System.Windows.Forms;

namespace VizeFinalNotlaraGoreHarfler
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
            
            if (ortalama > 90 && ortalama <= 100)
                MessageBox.Show("Ortalamanız: " + ortalama.ToString() + " AA Geçtiniz !!");
            else if (ortalama > 80 && ortalama <= 90)
                MessageBox.Show("Ortalamanız: " + ortalama.ToString() + " BB Geçtiniz !!");
            else if (ortalama > 70 && ortalama <= 80)
                MessageBox.Show("Ortalamanız: " + ortalama.ToString() + " CB Geçtiniz !!");
            else if (ortalama >= 60 && ortalama <= 70)
                MessageBox.Show("Ortalamanız: " + ortalama.ToString() + " CC Geçtiniz !!");
            else
                MessageBox.Show("Ortalamanız: " + ortalama.ToString() + " Kaldınız !!");
        }
    }
}
