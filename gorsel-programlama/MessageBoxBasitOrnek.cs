using System;
using System.Windows.Forms;

namespace MessageBoxBasitOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya...");
            this.BackColor = System.Drawing.Color.Aqua;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz...");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Güle güle...");
        }
    }
}
