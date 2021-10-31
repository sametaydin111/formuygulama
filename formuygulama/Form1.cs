using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formuygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rasgele = new Random();
            int sayi = rasgele.Next(1, 100);
            button1.Text = Convert.ToString(sayi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rasgele1 = new Random();
            int sayi1 = rasgele1.Next(1, 100);
            button2.Text = Convert.ToString(sayi1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rasgele2 = new Random();
            int sayi2 = rasgele2.Next(1, 100);
            button3.Text = Convert.ToString(sayi2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(button1.Text);
            int sayi2 = Convert.ToInt32(button2.Text);
            int sayi3 = Convert.ToInt32(button3.Text);
            
            button4.Text = Convert.ToString(sayi1 + sayi2 + sayi3); 

        }
    }
}
